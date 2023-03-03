namespace Pihalve.GuidConverter;

partial class ConverterForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConverterForm));
        txtInputGuid = new TextBox();
        lblInputGuid = new Label();
        lblMongoDbGuid = new Label();
        txtMongoDbGuid = new TextBox();
        btnConvert = new Button();
        lblNormalGuid = new Label();
        txtNormalGuid = new TextBox();
        txtMongoDbGuidBinData = new TextBox();
        txtMongoDbGuidIdFilter = new TextBox();
        lblInputInvalid = new Label();
        notifyIcon1 = new NotifyIcon(components);
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        SuspendLayout();
        // 
        // txtInputGuid
        // 
        txtInputGuid.Location = new Point(12, 32);
        txtInputGuid.Name = "txtInputGuid";
        txtInputGuid.Size = new Size(389, 27);
        txtInputGuid.TabIndex = 0;
        // 
        // lblInputGuid
        // 
        lblInputGuid.AutoSize = true;
        lblInputGuid.Location = new Point(12, 9);
        lblInputGuid.Name = "lblInputGuid";
        lblInputGuid.Size = new Size(111, 20);
        lblInputGuid.TabIndex = 1;
        lblInputGuid.Text = "Guid to convert";
        // 
        // lblMongoDbGuid
        // 
        lblMongoDbGuid.AutoSize = true;
        lblMongoDbGuid.Location = new Point(12, 72);
        lblMongoDbGuid.Name = "lblMongoDbGuid";
        lblMongoDbGuid.Size = new Size(126, 20);
        lblMongoDbGuid.TabIndex = 2;
        lblMongoDbGuid.Text = "MongoDB format";
        // 
        // txtMongoDbGuid
        // 
        txtMongoDbGuid.Location = new Point(12, 95);
        txtMongoDbGuid.Name = "txtMongoDbGuid";
        txtMongoDbGuid.ReadOnly = true;
        txtMongoDbGuid.Size = new Size(389, 27);
        txtMongoDbGuid.TabIndex = 2;
        txtMongoDbGuid.Click += txtMongoDbGuid_Click;
        // 
        // btnConvert
        // 
        btnConvert.Location = new Point(407, 31);
        btnConvert.Name = "btnConvert";
        btnConvert.Size = new Size(94, 29);
        btnConvert.TabIndex = 1;
        btnConvert.Text = "&Convert";
        btnConvert.UseVisualStyleBackColor = true;
        btnConvert.Click += btnConvert_Click;
        // 
        // lblNormalGuid
        // 
        lblNormalGuid.AutoSize = true;
        lblNormalGuid.Location = new Point(12, 200);
        lblNormalGuid.Name = "lblNormalGuid";
        lblNormalGuid.Size = new Size(108, 20);
        lblNormalGuid.TabIndex = 4;
        lblNormalGuid.Text = "Normal format";
        // 
        // txtNormalGuid
        // 
        txtNormalGuid.Location = new Point(12, 223);
        txtNormalGuid.Name = "txtNormalGuid";
        txtNormalGuid.ReadOnly = true;
        txtNormalGuid.Size = new Size(389, 27);
        txtNormalGuid.TabIndex = 5;
        txtNormalGuid.Click += txtNormalGuid_Click;
        // 
        // txtMongoDbGuidBinData
        // 
        txtMongoDbGuidBinData.Location = new Point(12, 128);
        txtMongoDbGuidBinData.Name = "txtMongoDbGuidBinData";
        txtMongoDbGuidBinData.ReadOnly = true;
        txtMongoDbGuidBinData.Size = new Size(389, 27);
        txtMongoDbGuidBinData.TabIndex = 3;
        txtMongoDbGuidBinData.Click += txtMongoDbGuidBinData_Click;
        // 
        // txtMongoDbGuidIdFilter
        // 
        txtMongoDbGuidIdFilter.Location = new Point(12, 161);
        txtMongoDbGuidIdFilter.Name = "txtMongoDbGuidIdFilter";
        txtMongoDbGuidIdFilter.ReadOnly = true;
        txtMongoDbGuidIdFilter.Size = new Size(389, 27);
        txtMongoDbGuidIdFilter.TabIndex = 4;
        txtMongoDbGuidIdFilter.Click += txtMongoDbGuidIdFilter_Click;
        // 
        // lblInputInvalid
        // 
        lblInputInvalid.AutoSize = true;
        lblInputInvalid.ForeColor = Color.Red;
        lblInputInvalid.Location = new Point(338, 9);
        lblInputInvalid.Name = "lblInputInvalid";
        lblInputInvalid.Size = new Size(63, 20);
        lblInputInvalid.TabIndex = 6;
        lblInputInvalid.Text = "[invalid]";
        // 
        // notifyIcon1
        // 
        notifyIcon1.Text = "notifyIcon1";
        notifyIcon1.Visible = true;
        // 
        // ConverterForm
        // 
        AcceptButton = btnConvert;
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(513, 268);
        Controls.Add(lblInputInvalid);
        Controls.Add(txtMongoDbGuidIdFilter);
        Controls.Add(txtMongoDbGuidBinData);
        Controls.Add(txtNormalGuid);
        Controls.Add(lblNormalGuid);
        Controls.Add(btnConvert);
        Controls.Add(txtMongoDbGuid);
        Controls.Add(lblMongoDbGuid);
        Controls.Add(lblInputGuid);
        Controls.Add(txtInputGuid);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Icon = (Icon)resources.GetObject("$this.Icon");
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "ConverterForm";
        ShowInTaskbar = false;
        SizeGripStyle = SizeGripStyle.Hide;
        Text = "GUID Converter";
        Activated += Converter_Activated;
        FormClosing += ConverterForm_FormClosing;
        Load += Converter_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtInputGuid;
    private Label lblInputGuid;
    private Label lblMongoDbGuid;
    private TextBox txtMongoDbGuid;
    private Button btnConvert;
    private Label lblNormalGuid;
    private TextBox txtNormalGuid;
    private TextBox txtMongoDbGuidBinData;
    private TextBox txtMongoDbGuidIdFilter;
    private Label lblInputInvalid;
    private NotifyIcon notifyIcon1;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
}
