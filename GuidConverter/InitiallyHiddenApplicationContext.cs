namespace Pihalve.GuidConverter;

internal class InitiallyHiddenApplicationContext<TForm> : ApplicationContext where TForm : Form
{
    private TForm _mainForm;

    public InitiallyHiddenApplicationContext(TForm mainForm)
    {
        _mainForm = mainForm;

        if (_mainForm != null)
        {
            // Wire up the destroy events similar to how the base ApplicationContext
            // does things when a form is provided.
            _mainForm.HandleDestroyed += OnFormDestroy;

            // We still want to call Show() here, but we can at least hide it from the user
            // by setting Opacity to 0 while the form is being shown for the first time.
            _mainForm.Opacity = 0;
            _mainForm.Show();
            _mainForm.Hide();
            _mainForm.Opacity = 1;
        }
    }

    private void OnFormDestroy(object sender, EventArgs e)
    {
        if (sender is Form form && !form.RecreatingHandle)
        {
            form.HandleDestroyed -= OnFormDestroy;
            OnMainFormClosed(sender, e);
        }
    }

    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (_mainForm != null)
            {
                if (!_mainForm.IsDisposed)
                {
                    _mainForm.Dispose();
                }

                _mainForm = null;
            }
        }

        base.Dispose(disposing);
    }
}
