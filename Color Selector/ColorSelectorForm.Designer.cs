namespace ColorSelector
{
  partial class ColorSelectorForm
  {
    /// <summary>
    /// Erforderliche Designervariable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Verwendete Ressourcen bereinigen.
    /// </summary>
    /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Vom Windows Form-Designer generierter Code

    /// <summary>
    /// Erforderliche Methode für die Designerunterstützung.
    /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorSelectorForm));
      this.labelRed = new System.Windows.Forms.Label();
      this.trackBarColorRed = new System.Windows.Forms.TrackBar();
      this.trackBarColorGreen = new System.Windows.Forms.TrackBar();
      this.labelGreen = new System.Windows.Forms.Label();
      this.trackBarColorBlue = new System.Windows.Forms.TrackBar();
      this.labelBlue = new System.Windows.Forms.Label();
      this.pictureBoxColorRGB = new System.Windows.Forms.PictureBox();
      this.labelHexColorCode = new System.Windows.Forms.Label();
      this.textBoxHexColorCode = new System.Windows.Forms.TextBox();
      this.textBoxHtmlColorCode = new System.Windows.Forms.TextBox();
      this.labelHtmlColorCode = new System.Windows.Forms.Label();
      this.buttonInformation = new System.Windows.Forms.Button();
      this.buttonEnd = new System.Windows.Forms.Button();
      this.textBoxRgbColorCode = new System.Windows.Forms.TextBox();
      this.labelRgbColorCode = new System.Windows.Forms.Label();
      this.buttonHexColorCodeCopyToClipboard = new System.Windows.Forms.Button();
      this.buttonHtmlColorCodeCopyToClipboard = new System.Windows.Forms.Button();
      this.buttonRgbColorCodeCopyToClipboard = new System.Windows.Forms.Button();
      this.numericUpDownColorRed = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownColorGreen = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownColorBlue = new System.Windows.Forms.NumericUpDown();
      this.toolTipAppForm = new System.Windows.Forms.ToolTip(this.components);
      this.buttonInvertColor = new System.Windows.Forms.Button();
      this.contextMenuStripInvertColor = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ToolStripMenuItemInvertColorRGB = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemInvertColorRG = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemInvertColorRB = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemInvertColorGB = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemInvertColorR = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemInvertColorG = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemInvertColorB = new System.Windows.Forms.ToolStripMenuItem();
      this.buttonSwapColor = new System.Windows.Forms.Button();
      this.contextMenuStripSwapColor = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ToolStripMenuItemSwapRG = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemSwapRB = new System.Windows.Forms.ToolStripMenuItem();
      this.ToolStripMenuItemSwapGB = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.buttonMathColorCode = new System.Windows.Forms.Button();
      this.textBoxMathColorCode = new System.Windows.Forms.TextBox();
      this.labelMathColorCode = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarColorRed)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarColorGreen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarColorBlue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorRGB)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorRed)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorGreen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorBlue)).BeginInit();
      this.contextMenuStripInvertColor.SuspendLayout();
      this.contextMenuStripSwapColor.SuspendLayout();
      this.SuspendLayout();
      // 
      // labelRed
      // 
      this.labelRed.AutoSize = true;
      this.labelRed.Location = new System.Drawing.Point(13, 24);
      this.labelRed.Name = "labelRed";
      this.labelRed.Size = new System.Drawing.Size(24, 13);
      this.labelRed.TabIndex = 0;
      this.labelRed.Text = "&Rot";
      // 
      // trackBarColorRed
      // 
      this.trackBarColorRed.LargeChange = 1;
      this.trackBarColorRed.Location = new System.Drawing.Point(43, 12);
      this.trackBarColorRed.Maximum = 255;
      this.trackBarColorRed.Name = "trackBarColorRed";
      this.trackBarColorRed.Size = new System.Drawing.Size(256, 45);
      this.trackBarColorRed.TabIndex = 1;
      this.trackBarColorRed.TickFrequency = 26;
      this.trackBarColorRed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
      this.toolTipAppForm.SetToolTip(this.trackBarColorRed, "Bestimmt den Rot-Anteil der Farbe");
      this.trackBarColorRed.Scroll += new System.EventHandler(this.trackBarColorRed_Scroll);
      // 
      // trackBarColorGreen
      // 
      this.trackBarColorGreen.LargeChange = 1;
      this.trackBarColorGreen.Location = new System.Drawing.Point(43, 50);
      this.trackBarColorGreen.Maximum = 255;
      this.trackBarColorGreen.Name = "trackBarColorGreen";
      this.trackBarColorGreen.Size = new System.Drawing.Size(256, 45);
      this.trackBarColorGreen.TabIndex = 4;
      this.trackBarColorGreen.TickFrequency = 26;
      this.trackBarColorGreen.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
      this.toolTipAppForm.SetToolTip(this.trackBarColorGreen, "Bestimmt den Grün-Anteil der Farbe");
      this.trackBarColorGreen.Scroll += new System.EventHandler(this.trackBarColorGreen_Scroll);
      // 
      // labelGreen
      // 
      this.labelGreen.AutoSize = true;
      this.labelGreen.Location = new System.Drawing.Point(13, 62);
      this.labelGreen.Name = "labelGreen";
      this.labelGreen.Size = new System.Drawing.Size(30, 13);
      this.labelGreen.TabIndex = 3;
      this.labelGreen.Text = "&Grün";
      // 
      // trackBarColorBlue
      // 
      this.trackBarColorBlue.LargeChange = 1;
      this.trackBarColorBlue.Location = new System.Drawing.Point(43, 89);
      this.trackBarColorBlue.Maximum = 255;
      this.trackBarColorBlue.Name = "trackBarColorBlue";
      this.trackBarColorBlue.Size = new System.Drawing.Size(256, 45);
      this.trackBarColorBlue.TabIndex = 7;
      this.trackBarColorBlue.TickFrequency = 26;
      this.trackBarColorBlue.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
      this.toolTipAppForm.SetToolTip(this.trackBarColorBlue, "Bestimmt den Blau-Anteil der Farbe");
      this.trackBarColorBlue.Scroll += new System.EventHandler(this.trackBarColorBlue_Scroll);
      // 
      // labelBlue
      // 
      this.labelBlue.AutoSize = true;
      this.labelBlue.Location = new System.Drawing.Point(13, 101);
      this.labelBlue.Name = "labelBlue";
      this.labelBlue.Size = new System.Drawing.Size(28, 13);
      this.labelBlue.TabIndex = 6;
      this.labelBlue.Text = "&Blau";
      // 
      // pictureBoxColorRGB
      // 
      this.pictureBoxColorRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBoxColorRGB.Location = new System.Drawing.Point(16, 140);
      this.pictureBoxColorRGB.Name = "pictureBoxColorRGB";
      this.pictureBoxColorRGB.Size = new System.Drawing.Size(125, 125);
      this.pictureBoxColorRGB.TabIndex = 9;
      this.pictureBoxColorRGB.TabStop = false;
      this.toolTipAppForm.SetToolTip(this.pictureBoxColorRGB, "Zeigt die Farbe an");
      // 
      // labelHexColorCode
      // 
      this.labelHexColorCode.AutoSize = true;
      this.labelHexColorCode.Location = new System.Drawing.Point(147, 153);
      this.labelHexColorCode.Name = "labelHexColorCode";
      this.labelHexColorCode.Size = new System.Drawing.Size(80, 13);
      this.labelHexColorCode.TabIndex = 9;
      this.labelHexColorCode.Text = "HE&X-Farbcode:";
      // 
      // textBoxHexColorCode
      // 
      this.textBoxHexColorCode.Location = new System.Drawing.Point(233, 150);
      this.textBoxHexColorCode.Name = "textBoxHexColorCode";
      this.textBoxHexColorCode.ReadOnly = true;
      this.textBoxHexColorCode.Size = new System.Drawing.Size(81, 20);
      this.textBoxHexColorCode.TabIndex = 10;
      this.toolTipAppForm.SetToolTip(this.textBoxHexColorCode, "Zeigt den HEX-Farbcode an");
      // 
      // textBoxHtmlColorCode
      // 
      this.textBoxHtmlColorCode.Location = new System.Drawing.Point(233, 176);
      this.textBoxHtmlColorCode.Name = "textBoxHtmlColorCode";
      this.textBoxHtmlColorCode.ReadOnly = true;
      this.textBoxHtmlColorCode.Size = new System.Drawing.Size(81, 20);
      this.textBoxHtmlColorCode.TabIndex = 13;
      this.toolTipAppForm.SetToolTip(this.textBoxHtmlColorCode, "Zeigt den HTML-Farbcode an");
      // 
      // labelHtmlColorCode
      // 
      this.labelHtmlColorCode.AutoSize = true;
      this.labelHtmlColorCode.Location = new System.Drawing.Point(147, 179);
      this.labelHtmlColorCode.Name = "labelHtmlColorCode";
      this.labelHtmlColorCode.Size = new System.Drawing.Size(88, 13);
      this.labelHtmlColorCode.TabIndex = 12;
      this.labelHtmlColorCode.Text = "&HTML-Farbcode:";
      // 
      // buttonInformation
      // 
      this.buttonInformation.Image = ((System.Drawing.Image)(resources.GetObject("buttonInformation.Image")));
      this.buttonInformation.Location = new System.Drawing.Point(198, 275);
      this.buttonInformation.Name = "buttonInformation";
      this.buttonInformation.Size = new System.Drawing.Size(88, 35);
      this.buttonInformation.TabIndex = 23;
      this.buttonInformation.Text = "&Information";
      this.buttonInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipAppForm.SetToolTip(this.buttonInformation, "Zeigt Informationen über das Programm an");
      this.buttonInformation.UseVisualStyleBackColor = true;
      this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
      // 
      // buttonEnd
      // 
      this.buttonEnd.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnd.Image")));
      this.buttonEnd.Location = new System.Drawing.Point(292, 275);
      this.buttonEnd.Name = "buttonEnd";
      this.buttonEnd.Size = new System.Drawing.Size(75, 35);
      this.buttonEnd.TabIndex = 24;
      this.buttonEnd.Text = "B&eenden";
      this.buttonEnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipAppForm.SetToolTip(this.buttonEnd, "Beendet das Programm");
      this.buttonEnd.UseVisualStyleBackColor = true;
      this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
      // 
      // textBoxRgbColorCode
      // 
      this.textBoxRgbColorCode.Location = new System.Drawing.Point(233, 202);
      this.textBoxRgbColorCode.Name = "textBoxRgbColorCode";
      this.textBoxRgbColorCode.ReadOnly = true;
      this.textBoxRgbColorCode.Size = new System.Drawing.Size(81, 20);
      this.textBoxRgbColorCode.TabIndex = 16;
      this.toolTipAppForm.SetToolTip(this.textBoxRgbColorCode, "Zeigt den RGB-Farbcode an");
      // 
      // labelRgbColorCode
      // 
      this.labelRgbColorCode.AutoSize = true;
      this.labelRgbColorCode.Location = new System.Drawing.Point(147, 205);
      this.labelRgbColorCode.Name = "labelRgbColorCode";
      this.labelRgbColorCode.Size = new System.Drawing.Size(81, 13);
      this.labelRgbColorCode.TabIndex = 15;
      this.labelRgbColorCode.Text = "RGB-&Farbcode:";
      // 
      // buttonHexColorCodeCopyToClipboard
      // 
      this.buttonHexColorCodeCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonHexColorCodeCopyToClipboard.Image")));
      this.buttonHexColorCodeCopyToClipboard.Location = new System.Drawing.Point(320, 150);
      this.buttonHexColorCodeCopyToClipboard.Name = "buttonHexColorCodeCopyToClipboard";
      this.buttonHexColorCodeCopyToClipboard.Size = new System.Drawing.Size(27, 20);
      this.buttonHexColorCodeCopyToClipboard.TabIndex = 11;
      this.toolTipAppForm.SetToolTip(this.buttonHexColorCodeCopyToClipboard, "Kopiert den HEX-Farbcode in die Zwischenablage");
      this.buttonHexColorCodeCopyToClipboard.UseVisualStyleBackColor = true;
      this.buttonHexColorCodeCopyToClipboard.Click += new System.EventHandler(this.buttonHexColorCodeCopyToClipboard_Click);
      // 
      // buttonHtmlColorCodeCopyToClipboard
      // 
      this.buttonHtmlColorCodeCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonHtmlColorCodeCopyToClipboard.Image")));
      this.buttonHtmlColorCodeCopyToClipboard.Location = new System.Drawing.Point(320, 175);
      this.buttonHtmlColorCodeCopyToClipboard.Name = "buttonHtmlColorCodeCopyToClipboard";
      this.buttonHtmlColorCodeCopyToClipboard.Size = new System.Drawing.Size(27, 20);
      this.buttonHtmlColorCodeCopyToClipboard.TabIndex = 14;
      this.toolTipAppForm.SetToolTip(this.buttonHtmlColorCodeCopyToClipboard, "Kopiert den HTML-Farbcode in die Zwischenablage");
      this.buttonHtmlColorCodeCopyToClipboard.UseVisualStyleBackColor = true;
      this.buttonHtmlColorCodeCopyToClipboard.Click += new System.EventHandler(this.buttonHtmlColorCodeCopyToClipboard_Click);
      // 
      // buttonRgbColorCodeCopyToClipboard
      // 
      this.buttonRgbColorCodeCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonRgbColorCodeCopyToClipboard.Image")));
      this.buttonRgbColorCodeCopyToClipboard.Location = new System.Drawing.Point(320, 202);
      this.buttonRgbColorCodeCopyToClipboard.Name = "buttonRgbColorCodeCopyToClipboard";
      this.buttonRgbColorCodeCopyToClipboard.Size = new System.Drawing.Size(27, 20);
      this.buttonRgbColorCodeCopyToClipboard.TabIndex = 17;
      this.toolTipAppForm.SetToolTip(this.buttonRgbColorCodeCopyToClipboard, "Kopiert den RGB-Farbcode in die Zwischenablage");
      this.buttonRgbColorCodeCopyToClipboard.UseVisualStyleBackColor = true;
      this.buttonRgbColorCodeCopyToClipboard.Click += new System.EventHandler(this.buttonRgbColorCodeCopyToClipboard_Click);
      // 
      // numericUpDownColorRed
      // 
      this.numericUpDownColorRed.Location = new System.Drawing.Point(305, 22);
      this.numericUpDownColorRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numericUpDownColorRed.Name = "numericUpDownColorRed";
      this.numericUpDownColorRed.Size = new System.Drawing.Size(42, 20);
      this.numericUpDownColorRed.TabIndex = 2;
      this.toolTipAppForm.SetToolTip(this.numericUpDownColorRed, "Bestimmt den Rot-Anteil der Farbe");
      this.numericUpDownColorRed.ValueChanged += new System.EventHandler(this.numericUpDownColorRed_ValueChanged);
      // 
      // numericUpDownColorGreen
      // 
      this.numericUpDownColorGreen.Location = new System.Drawing.Point(305, 60);
      this.numericUpDownColorGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numericUpDownColorGreen.Name = "numericUpDownColorGreen";
      this.numericUpDownColorGreen.Size = new System.Drawing.Size(42, 20);
      this.numericUpDownColorGreen.TabIndex = 5;
      this.toolTipAppForm.SetToolTip(this.numericUpDownColorGreen, "Bestimmt den Grün-Anteil der Farbe");
      this.numericUpDownColorGreen.ValueChanged += new System.EventHandler(this.numericUpDownColorGreen_ValueChanged);
      // 
      // numericUpDownColorBlue
      // 
      this.numericUpDownColorBlue.Location = new System.Drawing.Point(305, 99);
      this.numericUpDownColorBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.numericUpDownColorBlue.Name = "numericUpDownColorBlue";
      this.numericUpDownColorBlue.Size = new System.Drawing.Size(42, 20);
      this.numericUpDownColorBlue.TabIndex = 8;
      this.toolTipAppForm.SetToolTip(this.numericUpDownColorBlue, "Bestimmt den Blau-Anteil der Farbe");
      this.numericUpDownColorBlue.ValueChanged += new System.EventHandler(this.numericUpDownColorBlue_ValueChanged);
      // 
      // buttonInvertColor
      // 
      this.buttonInvertColor.ContextMenuStrip = this.contextMenuStripInvertColor;
      this.buttonInvertColor.Image = ((System.Drawing.Image)(resources.GetObject("buttonInvertColor.Image")));
      this.buttonInvertColor.Location = new System.Drawing.Point(5, 275);
      this.buttonInvertColor.Name = "buttonInvertColor";
      this.buttonInvertColor.Size = new System.Drawing.Size(91, 35);
      this.buttonInvertColor.TabIndex = 21;
      this.buttonInvertColor.Text = "Farbkanäle invertieren";
      this.buttonInvertColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipAppForm.SetToolTip(this.buttonInvertColor, "Invertiert die Farbkanäle");
      this.buttonInvertColor.UseVisualStyleBackColor = true;
      this.buttonInvertColor.Click += new System.EventHandler(this.buttonInvertColor_Click);
      // 
      // contextMenuStripInvertColor
      // 
      this.contextMenuStripInvertColor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemInvertColorRGB,
            this.toolStripSeparator1,
            this.ToolStripMenuItemInvertColorRG,
            this.ToolStripMenuItemInvertColorRB,
            this.ToolStripMenuItemInvertColorGB,
            this.toolStripSeparator2,
            this.ToolStripMenuItemInvertColorR,
            this.ToolStripMenuItemInvertColorG,
            this.ToolStripMenuItemInvertColorB});
      this.contextMenuStripInvertColor.Name = "contextMenuStripInvertColor";
      this.contextMenuStripInvertColor.Size = new System.Drawing.Size(112, 170);
      this.toolTipAppForm.SetToolTip(this.contextMenuStripInvertColor, "Invertiert die Farbkanäle");
      // 
      // ToolStripMenuItemInvertColorRGB
      // 
      this.ToolStripMenuItemInvertColorRGB.Name = "ToolStripMenuItemInvertColorRGB";
      this.ToolStripMenuItemInvertColorRGB.Size = new System.Drawing.Size(111, 22);
      this.ToolStripMenuItemInvertColorRGB.Text = "R, G, B ";
      this.ToolStripMenuItemInvertColorRGB.ToolTipText = "Invertiert die Farbkanäle Rot, Gelb und Blau";
      this.ToolStripMenuItemInvertColorRGB.Click += new System.EventHandler(this.ToolStripMenuItemInvertColorRGB_Click);
      // 
      // ToolStripMenuItemInvertColorRG
      // 
      this.ToolStripMenuItemInvertColorRG.Name = "ToolStripMenuItemInvertColorRG";
      this.ToolStripMenuItemInvertColorRG.Size = new System.Drawing.Size(111, 22);
      this.ToolStripMenuItemInvertColorRG.Text = "R, G";
      this.ToolStripMenuItemInvertColorRG.ToolTipText = "Invertiert die Farbkanäle Rot und Gelb";
      this.ToolStripMenuItemInvertColorRG.Click += new System.EventHandler(this.ToolStripMenuItemInvertColorRG_Click);
      // 
      // ToolStripMenuItemInvertColorRB
      // 
      this.ToolStripMenuItemInvertColorRB.Name = "ToolStripMenuItemInvertColorRB";
      this.ToolStripMenuItemInvertColorRB.Size = new System.Drawing.Size(111, 22);
      this.ToolStripMenuItemInvertColorRB.Text = "R, B";
      this.ToolStripMenuItemInvertColorRB.ToolTipText = "Invertiert die Farbkanäle Rot und Blau";
      this.ToolStripMenuItemInvertColorRB.Click += new System.EventHandler(this.ToolStripMenuItemInvertColorRB_Click);
      // 
      // ToolStripMenuItemInvertColorGB
      // 
      this.ToolStripMenuItemInvertColorGB.Name = "ToolStripMenuItemInvertColorGB";
      this.ToolStripMenuItemInvertColorGB.Size = new System.Drawing.Size(111, 22);
      this.ToolStripMenuItemInvertColorGB.Text = "G, B";
      this.ToolStripMenuItemInvertColorGB.ToolTipText = "Invertiert die Farbkanäle Gelb und Blau";
      this.ToolStripMenuItemInvertColorGB.Click += new System.EventHandler(this.ToolStripMenuItemInvertColorGB_Click);
      // 
      // ToolStripMenuItemInvertColorR
      // 
      this.ToolStripMenuItemInvertColorR.Name = "ToolStripMenuItemInvertColorR";
      this.ToolStripMenuItemInvertColorR.Size = new System.Drawing.Size(111, 22);
      this.ToolStripMenuItemInvertColorR.Text = "R";
      this.ToolStripMenuItemInvertColorR.ToolTipText = "Invertiert den Farbkanal Rot";
      this.ToolStripMenuItemInvertColorR.Click += new System.EventHandler(this.ToolStripMenuItemInvertColorR_Click);
      // 
      // ToolStripMenuItemInvertColorG
      // 
      this.ToolStripMenuItemInvertColorG.Name = "ToolStripMenuItemInvertColorG";
      this.ToolStripMenuItemInvertColorG.Size = new System.Drawing.Size(111, 22);
      this.ToolStripMenuItemInvertColorG.Text = "G";
      this.ToolStripMenuItemInvertColorG.ToolTipText = "Invertiert den Farbkanal Grün";
      this.ToolStripMenuItemInvertColorG.Click += new System.EventHandler(this.ToolStripMenuItemInvertColorG_Click);
      // 
      // ToolStripMenuItemInvertColorB
      // 
      this.ToolStripMenuItemInvertColorB.Name = "ToolStripMenuItemInvertColorB";
      this.ToolStripMenuItemInvertColorB.Size = new System.Drawing.Size(111, 22);
      this.ToolStripMenuItemInvertColorB.Text = "B";
      this.ToolStripMenuItemInvertColorB.ToolTipText = "Invertiert den Farbkanal Blau";
      this.ToolStripMenuItemInvertColorB.Click += new System.EventHandler(this.ToolStripMenuItemInvertColorB_Click);
      // 
      // buttonSwapColor
      // 
      this.buttonSwapColor.ContextMenuStrip = this.contextMenuStripSwapColor;
      this.buttonSwapColor.Image = ((System.Drawing.Image)(resources.GetObject("buttonSwapColor.Image")));
      this.buttonSwapColor.Location = new System.Drawing.Point(102, 275);
      this.buttonSwapColor.Name = "buttonSwapColor";
      this.buttonSwapColor.Size = new System.Drawing.Size(90, 35);
      this.buttonSwapColor.TabIndex = 22;
      this.buttonSwapColor.Text = "Farbkanäle vertauschen";
      this.buttonSwapColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipAppForm.SetToolTip(this.buttonSwapColor, "Vertauscht die Farbkanäle");
      this.buttonSwapColor.UseVisualStyleBackColor = true;
      this.buttonSwapColor.Click += new System.EventHandler(this.buttonSwapColor_Click);
      // 
      // contextMenuStripSwapColor
      // 
      this.contextMenuStripSwapColor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemSwapRG,
            this.ToolStripMenuItemSwapRB,
            this.ToolStripMenuItemSwapGB});
      this.contextMenuStripSwapColor.Name = "contextMenuStripSwapColor";
      this.contextMenuStripSwapColor.ShowImageMargin = false;
      this.contextMenuStripSwapColor.Size = new System.Drawing.Size(155, 70);
      this.toolTipAppForm.SetToolTip(this.contextMenuStripSwapColor, "Vertauscht die Farbkanäle");
      // 
      // ToolStripMenuItemSwapRG
      // 
      this.ToolStripMenuItemSwapRG.Name = "ToolStripMenuItemSwapRG";
      this.ToolStripMenuItemSwapRG.Size = new System.Drawing.Size(154, 22);
      this.ToolStripMenuItemSwapRG.Text = "R <=> G  |  G <=> R";
      this.ToolStripMenuItemSwapRG.ToolTipText = "Vertauscht die Farbkanäle Rot und Gelb";
      this.ToolStripMenuItemSwapRG.Click += new System.EventHandler(this.ToolStripMenuItemSwapRG_Click);
      // 
      // ToolStripMenuItemSwapRB
      // 
      this.ToolStripMenuItemSwapRB.Name = "ToolStripMenuItemSwapRB";
      this.ToolStripMenuItemSwapRB.Size = new System.Drawing.Size(154, 22);
      this.ToolStripMenuItemSwapRB.Text = "R <=> B  |  B <=> R";
      this.ToolStripMenuItemSwapRB.ToolTipText = "Vertauscht die Farbkanäle Rot und Blau";
      this.ToolStripMenuItemSwapRB.Click += new System.EventHandler(this.ToolStripMenuItemSwapRB_Click);
      // 
      // ToolStripMenuItemSwapGB
      // 
      this.ToolStripMenuItemSwapGB.Name = "ToolStripMenuItemSwapGB";
      this.ToolStripMenuItemSwapGB.Size = new System.Drawing.Size(154, 22);
      this.ToolStripMenuItemSwapGB.Text = "G <=> B  | B <=> G";
      this.ToolStripMenuItemSwapGB.ToolTipText = "Vertauscht die Farbkanäle Gelb und Blau";
      this.ToolStripMenuItemSwapGB.Click += new System.EventHandler(this.ToolStripMenuItemSwapGB_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(108, 6);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(108, 6);
      // 
      // buttonMathColorCode
      // 
      this.buttonMathColorCode.Image = ((System.Drawing.Image)(resources.GetObject("buttonMathColorCode.Image")));
      this.buttonMathColorCode.Location = new System.Drawing.Point(320, 230);
      this.buttonMathColorCode.Name = "buttonMathColorCode";
      this.buttonMathColorCode.Size = new System.Drawing.Size(27, 20);
      this.buttonMathColorCode.TabIndex = 20;
      this.toolTipAppForm.SetToolTip(this.buttonMathColorCode, "Kopiert den mathematischen Farbcode in die Zwischenablage");
      this.buttonMathColorCode.UseVisualStyleBackColor = true;
      this.buttonMathColorCode.Click += new System.EventHandler(this.buttonMathColorCode_Click);
      // 
      // textBoxMathColorCode
      // 
      this.textBoxMathColorCode.Location = new System.Drawing.Point(234, 230);
      this.textBoxMathColorCode.Name = "textBoxMathColorCode";
      this.textBoxMathColorCode.ReadOnly = true;
      this.textBoxMathColorCode.Size = new System.Drawing.Size(81, 20);
      this.textBoxMathColorCode.TabIndex = 19;
      this.toolTipAppForm.SetToolTip(this.textBoxMathColorCode, "Zeigt den mathematischen Farbcode an");
      // 
      // labelMathColorCode
      // 
      this.labelMathColorCode.AutoSize = true;
      this.labelMathColorCode.Location = new System.Drawing.Point(147, 233);
      this.labelMathColorCode.Name = "labelMathColorCode";
      this.labelMathColorCode.Size = new System.Drawing.Size(88, 13);
      this.labelMathColorCode.TabIndex = 18;
      this.labelMathColorCode.Text = "&Mathe-Farbcode:";
      // 
      // ColorSelectorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(373, 322);
      this.Controls.Add(this.buttonMathColorCode);
      this.Controls.Add(this.textBoxMathColorCode);
      this.Controls.Add(this.labelMathColorCode);
      this.Controls.Add(this.numericUpDownColorBlue);
      this.Controls.Add(this.numericUpDownColorGreen);
      this.Controls.Add(this.numericUpDownColorRed);
      this.Controls.Add(this.buttonRgbColorCodeCopyToClipboard);
      this.Controls.Add(this.buttonHtmlColorCodeCopyToClipboard);
      this.Controls.Add(this.buttonHexColorCodeCopyToClipboard);
      this.Controls.Add(this.textBoxRgbColorCode);
      this.Controls.Add(this.labelRgbColorCode);
      this.Controls.Add(this.textBoxHtmlColorCode);
      this.Controls.Add(this.labelHtmlColorCode);
      this.Controls.Add(this.textBoxHexColorCode);
      this.Controls.Add(this.labelHexColorCode);
      this.Controls.Add(this.pictureBoxColorRGB);
      this.Controls.Add(this.trackBarColorBlue);
      this.Controls.Add(this.labelBlue);
      this.Controls.Add(this.trackBarColorGreen);
      this.Controls.Add(this.labelGreen);
      this.Controls.Add(this.trackBarColorRed);
      this.Controls.Add(this.labelRed);
      this.Controls.Add(this.buttonInvertColor);
      this.Controls.Add(this.buttonSwapColor);
      this.Controls.Add(this.buttonInformation);
      this.Controls.Add(this.buttonEnd);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "ColorSelectorForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Color Selector";
      this.Load += new System.EventHandler(this.ColorSelectorForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.trackBarColorRed)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarColorGreen)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarColorBlue)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorRGB)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorRed)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorGreen)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorBlue)).EndInit();
      this.contextMenuStripInvertColor.ResumeLayout(false);
      this.contextMenuStripSwapColor.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label labelRed;
    private System.Windows.Forms.TrackBar trackBarColorRed;
    private System.Windows.Forms.TrackBar trackBarColorGreen;
    private System.Windows.Forms.Label labelGreen;
    private System.Windows.Forms.TrackBar trackBarColorBlue;
    private System.Windows.Forms.Label labelBlue;
    private System.Windows.Forms.PictureBox pictureBoxColorRGB;
    private System.Windows.Forms.Label labelHexColorCode;
    private System.Windows.Forms.TextBox textBoxHexColorCode;
    private System.Windows.Forms.TextBox textBoxHtmlColorCode;
    private System.Windows.Forms.Label labelHtmlColorCode;
    private System.Windows.Forms.Button buttonInformation;
    private System.Windows.Forms.Button buttonEnd;
    private System.Windows.Forms.TextBox textBoxRgbColorCode;
    private System.Windows.Forms.Label labelRgbColorCode;
    private System.Windows.Forms.Button buttonHexColorCodeCopyToClipboard;
    private System.Windows.Forms.Button buttonHtmlColorCodeCopyToClipboard;
    private System.Windows.Forms.Button buttonRgbColorCodeCopyToClipboard;
    private System.Windows.Forms.NumericUpDown numericUpDownColorRed;
    private System.Windows.Forms.NumericUpDown numericUpDownColorGreen;
    private System.Windows.Forms.NumericUpDown numericUpDownColorBlue;
    private System.Windows.Forms.ToolTip toolTipAppForm;
    private System.Windows.Forms.Button buttonInvertColor;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripInvertColor;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInvertColorRGB;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInvertColorRG;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInvertColorRB;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInvertColorGB;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInvertColorR;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInvertColorG;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemInvertColorB;
    private System.Windows.Forms.Button buttonSwapColor;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ContextMenuStrip contextMenuStripSwapColor;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSwapRG;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSwapRB;
    private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSwapGB;
    private System.Windows.Forms.Button buttonMathColorCode;
    private System.Windows.Forms.TextBox textBoxMathColorCode;
    private System.Windows.Forms.Label labelMathColorCode;
  }
}

