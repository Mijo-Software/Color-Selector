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
      this.label1 = new System.Windows.Forms.Label();
      this.trackBarColorRed = new System.Windows.Forms.TrackBar();
      this.trackBarColorGreen = new System.Windows.Forms.TrackBar();
      this.label2 = new System.Windows.Forms.Label();
      this.trackBarColorBlue = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.pictureBoxColorRGB = new System.Windows.Forms.PictureBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxHexColorCode = new System.Windows.Forms.TextBox();
      this.textBoxHtmlColorCode = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.buttonInformation = new System.Windows.Forms.Button();
      this.buttonEnd = new System.Windows.Forms.Button();
      this.textBoxRgbColorCode = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.buttonHexColorCodeCopyToClipboard = new System.Windows.Forms.Button();
      this.buttonHtmlColorCodeCopyToClipboard = new System.Windows.Forms.Button();
      this.buttonRgbColorCodeCopyToClipboard = new System.Windows.Forms.Button();
      this.numericUpDownColorRed = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownColorGreen = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownColorBlue = new System.Windows.Forms.NumericUpDown();
      this.toolTipAppForm = new System.Windows.Forms.ToolTip(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.trackBarColorRed)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarColorGreen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarColorBlue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorRGB)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorRed)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorGreen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownColorBlue)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(24, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "&Rot";
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
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 62);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(30, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "&Grün";
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
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 101);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(28, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "&Blau";
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
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(147, 143);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(80, 13);
      this.label4.TabIndex = 9;
      this.label4.Text = "HE&X-Farbcode:";
      // 
      // textBoxHexColorCode
      // 
      this.textBoxHexColorCode.Location = new System.Drawing.Point(233, 140);
      this.textBoxHexColorCode.Name = "textBoxHexColorCode";
      this.textBoxHexColorCode.Size = new System.Drawing.Size(81, 20);
      this.textBoxHexColorCode.TabIndex = 10;
      this.toolTipAppForm.SetToolTip(this.textBoxHexColorCode, "Zeigt den HEX-Farbcode an");
      // 
      // textBoxHtmlColorCode
      // 
      this.textBoxHtmlColorCode.Location = new System.Drawing.Point(233, 166);
      this.textBoxHtmlColorCode.Name = "textBoxHtmlColorCode";
      this.textBoxHtmlColorCode.Size = new System.Drawing.Size(81, 20);
      this.textBoxHtmlColorCode.TabIndex = 13;
      this.toolTipAppForm.SetToolTip(this.textBoxHtmlColorCode, "Zeigt den HTML-Farbcode an");
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(147, 169);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(88, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "&HTML-Farbcode:";
      // 
      // buttonInformation
      // 
      this.buttonInformation.Image = ((System.Drawing.Image)(resources.GetObject("buttonInformation.Image")));
      this.buttonInformation.Location = new System.Drawing.Point(161, 231);
      this.buttonInformation.Name = "buttonInformation";
      this.buttonInformation.Size = new System.Drawing.Size(85, 34);
      this.buttonInformation.TabIndex = 18;
      this.buttonInformation.Text = "&Information";
      this.buttonInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipAppForm.SetToolTip(this.buttonInformation, "Zeigt Informationen über das Programm an");
      this.buttonInformation.UseVisualStyleBackColor = true;
      this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
      // 
      // buttonEnd
      // 
      this.buttonEnd.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnd.Image")));
      this.buttonEnd.Location = new System.Drawing.Point(258, 231);
      this.buttonEnd.Name = "buttonEnd";
      this.buttonEnd.Size = new System.Drawing.Size(75, 34);
      this.buttonEnd.TabIndex = 19;
      this.buttonEnd.Text = "B&eenden";
      this.buttonEnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.toolTipAppForm.SetToolTip(this.buttonEnd, "Beendet das Programm");
      this.buttonEnd.UseVisualStyleBackColor = true;
      this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
      // 
      // textBoxRgbColorCode
      // 
      this.textBoxRgbColorCode.Location = new System.Drawing.Point(233, 192);
      this.textBoxRgbColorCode.Name = "textBoxRgbColorCode";
      this.textBoxRgbColorCode.Size = new System.Drawing.Size(81, 20);
      this.textBoxRgbColorCode.TabIndex = 16;
      this.toolTipAppForm.SetToolTip(this.textBoxRgbColorCode, "Zeigt den RGB-Farbcode an");
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(147, 195);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(81, 13);
      this.label6.TabIndex = 15;
      this.label6.Text = "RGB-&Farbcode:";
      // 
      // buttonHexColorCodeCopyToClipboard
      // 
      this.buttonHexColorCodeCopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("buttonHexColorCodeCopyToClipboard.Image")));
      this.buttonHexColorCodeCopyToClipboard.Location = new System.Drawing.Point(320, 140);
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
      this.buttonHtmlColorCodeCopyToClipboard.Location = new System.Drawing.Point(320, 165);
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
      this.buttonRgbColorCodeCopyToClipboard.Location = new System.Drawing.Point(320, 192);
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
      // ColorSelectorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(359, 282);
      this.Controls.Add(this.numericUpDownColorBlue);
      this.Controls.Add(this.numericUpDownColorGreen);
      this.Controls.Add(this.numericUpDownColorRed);
      this.Controls.Add(this.buttonRgbColorCodeCopyToClipboard);
      this.Controls.Add(this.buttonHtmlColorCodeCopyToClipboard);
      this.Controls.Add(this.buttonHexColorCodeCopyToClipboard);
      this.Controls.Add(this.textBoxRgbColorCode);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.buttonEnd);
      this.Controls.Add(this.buttonInformation);
      this.Controls.Add(this.textBoxHtmlColorCode);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textBoxHexColorCode);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.pictureBoxColorRGB);
      this.Controls.Add(this.trackBarColorBlue);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.trackBarColorGreen);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.trackBarColorRed);
      this.Controls.Add(this.label1);
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
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TrackBar trackBarColorRed;
    private System.Windows.Forms.TrackBar trackBarColorGreen;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TrackBar trackBarColorBlue;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PictureBox pictureBoxColorRGB;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxHexColorCode;
    private System.Windows.Forms.TextBox textBoxHtmlColorCode;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button buttonInformation;
    private System.Windows.Forms.Button buttonEnd;
    private System.Windows.Forms.TextBox textBoxRgbColorCode;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button buttonHexColorCodeCopyToClipboard;
    private System.Windows.Forms.Button buttonHtmlColorCodeCopyToClipboard;
    private System.Windows.Forms.Button buttonRgbColorCodeCopyToClipboard;
    private System.Windows.Forms.NumericUpDown numericUpDownColorRed;
    private System.Windows.Forms.NumericUpDown numericUpDownColorGreen;
    private System.Windows.Forms.NumericUpDown numericUpDownColorBlue;
    private System.Windows.Forms.ToolTip toolTipAppForm;
  }
}

