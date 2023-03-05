// ReSharper disable LocalizableElement
namespace Pihalve.GuidConverter;

public partial class ConverterForm : Form
{
    private readonly Converter _converter;

    public ConverterForm()
    {
        InitializeComponent();

        _converter = new Converter();

        var menuItemGuidConverter = new ToolStripMenuItem("&GUID Converter");
        menuItemGuidConverter.Click += MenuItemGuidConverter_Click;
        var menuItemQuit = new ToolStripMenuItem("&Quit");
        menuItemQuit.Click += MenuItemQuit_Click;
        var contextMenu = new ContextMenuStrip();
        contextMenu.Items.AddRange(new ToolStripItem[] { menuItemGuidConverter, menuItemQuit });

        notifyIcon1.Text = Text;
        notifyIcon1.Icon = Icon;
        notifyIcon1.ContextMenuStrip = contextMenu;
        notifyIcon1.MouseClick += NotifyIcon1_MouseClick;
        notifyIcon1.Visible = true;
    }

    private void Converter_Load(object sender, EventArgs e)
    {
        lblInputInvalid.Visible = false;
        //txtInputGuid.Text = "3c8534f4-39e3-422e-8adc-0002538d4a98";
        Visible = false;
    }

    private void btnConvert_Click(object sender, EventArgs e)
    {
        lblInputInvalid.Visible = false;
        txtMongoDbGuid.Text = "";
        txtMongoDbGuidBinData.Text = "";
        txtMongoDbGuidIdFilter.Text = "";
        txtNormalGuid.Text = "";

        var result = _converter.Convert(txtInputGuid.Text);
        if (result != null)
        {
            PresentConversionResult(result);
            return;
        }

        lblInputInvalid.Visible = true;
    }

    private void Converter_Activated(object sender, EventArgs e)
    {
        var input = Clipboard.GetText();
        var result = _converter.Convert(input);
        if (result != null)
        {
            lblInputInvalid.Visible = false;
            txtInputGuid.Text = input;
            PresentConversionResult(result);
        }
    }

    private void PresentConversionResult(ConversionResult result)
    {
        txtMongoDbGuid.Text = result.MongoDb;
        txtMongoDbGuidBinData.Text = $"BinData(3, '{result.MongoDb}')";
        txtMongoDbGuidIdFilter.Text = $"{{_id: BinData(3, '{result.MongoDb}')}}";

        txtNormalGuid.Text = result.Normal.ToString();
    }

    private void txtMongoDbGuid_Click(object sender, EventArgs e)
    {
        txtMongoDbGuid.SelectAll();
    }

    private void txtMongoDbGuidBinData_Click(object sender, EventArgs e)
    {
        txtMongoDbGuidBinData.SelectAll();
    }

    private void txtMongoDbGuidIdFilter_Click(object sender, EventArgs e)
    {
        txtMongoDbGuidIdFilter.SelectAll();
    }

    private void txtNormalGuid_Click(object sender, EventArgs e)
    {
        txtNormalGuid.SelectAll();
    }

    private void MenuItemQuit_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void MenuItemGuidConverter_Click(object sender, EventArgs e)
    {
        Visible = true;
        Activate();
    }

    private void NotifyIcon1_MouseClick(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            Visible = true;
            Activate();
        }
    }

    private void ConverterForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        if (e.CloseReason != CloseReason.ApplicationExitCall)
        {
            e.Cancel = true;
            Visible = false;
        }
    }
}
