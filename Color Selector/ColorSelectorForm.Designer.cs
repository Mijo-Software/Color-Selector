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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColorSelectorForm));
      this.label1 = new System.Windows.Forms.Label();
      this.trackBarColorRed = new System.Windows.Forms.TrackBar();
      this.textBoxColorRed = new System.Windows.Forms.TextBox();
      this.textBoxColorGreen = new System.Windows.Forms.TextBox();
      this.trackBarColorGreen = new System.Windows.Forms.TrackBar();
      this.label2 = new System.Windows.Forms.Label();
      this.textBoxColorBlue = new System.Windows.Forms.TextBox();
      this.trackBarColorBlue = new System.Windows.Forms.TrackBar();
      this.label3 = new System.Windows.Forms.Label();
      this.pictureBoxColorRGB = new System.Windows.Forms.PictureBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textBoxHexColorCode = new System.Windows.Forms.TextBox();
      this.textBoxHtmlColorCode = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.buttonInformation = new System.Windows.Forms.Button();
      this.buttonEnd = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarColorRed)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarColorGreen)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarColorBlue)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColorRGB)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 24);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(24, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Rot";
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
      this.trackBarColorRed.Scroll += new System.EventHandler(this.trackBarColorRed_Scroll);
      // 
      // textBoxColorRed
      // 
      this.textBoxColorRed.Location = new System.Drawing.Point(306, 24);
      this.textBoxColorRed.Name = "textBoxColorRed";
      this.textBoxColorRed.Size = new System.Drawing.Size(27, 20);
      this.textBoxColorRed.TabIndex = 2;
      // 
      // textBoxColorGreen
      // 
      this.textBoxColorGreen.Location = new System.Drawing.Point(306, 62);
      this.textBoxColorGreen.Name = "textBoxColorGreen";
      this.textBoxColorGreen.Size = new System.Drawing.Size(27, 20);
      this.textBoxColorGreen.TabIndex = 5;
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
      this.trackBarColorGreen.Scroll += new System.EventHandler(this.trackBarColorGreen_Scroll);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 62);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(30, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Grün";
      // 
      // textBoxColorBlue
      // 
      this.textBoxColorBlue.Location = new System.Drawing.Point(306, 101);
      this.textBoxColorBlue.Name = "textBoxColorBlue";
      this.textBoxColorBlue.Size = new System.Drawing.Size(27, 20);
      this.textBoxColorBlue.TabIndex = 8;
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
      this.trackBarColorBlue.Scroll += new System.EventHandler(this.trackBarColorBlue_Scroll);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(13, 101);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(28, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Blau";
      // 
      // pictureBoxColorRGB
      // 
      this.pictureBoxColorRGB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pictureBoxColorRGB.Location = new System.Drawing.Point(16, 140);
      this.pictureBoxColorRGB.Name = "pictureBoxColorRGB";
      this.pictureBoxColorRGB.Size = new System.Drawing.Size(125, 125);
      this.pictureBoxColorRGB.TabIndex = 9;
      this.pictureBoxColorRGB.TabStop = false;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(158, 156);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(80, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "HEX-Farbcode:";
      // 
      // textBoxHexColorCode
      // 
      this.textBoxHexColorCode.Location = new System.Drawing.Point(245, 153);
      this.textBoxHexColorCode.Name = "textBoxHexColorCode";
      this.textBoxHexColorCode.Size = new System.Drawing.Size(54, 20);
      this.textBoxHexColorCode.TabIndex = 11;
      // 
      // textBoxHtmlColorCode
      // 
      this.textBoxHtmlColorCode.Location = new System.Drawing.Point(245, 179);
      this.textBoxHtmlColorCode.Name = "textBoxHtmlColorCode";
      this.textBoxHtmlColorCode.Size = new System.Drawing.Size(54, 20);
      this.textBoxHtmlColorCode.TabIndex = 13;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(158, 182);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(88, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "HTML-Farbcode:";
      // 
      // buttonInformation
      // 
      this.buttonInformation.Image = ((System.Drawing.Image)(resources.GetObject("buttonInformation.Image")));
      this.buttonInformation.Location = new System.Drawing.Point(161, 231);
      this.buttonInformation.Name = "buttonInformation";
      this.buttonInformation.Size = new System.Drawing.Size(85, 34);
      this.buttonInformation.TabIndex = 14;
      this.buttonInformation.Text = "&Information";
      this.buttonInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonInformation.UseVisualStyleBackColor = true;
      this.buttonInformation.Click += new System.EventHandler(this.buttonInformation_Click);
      // 
      // buttonEnd
      // 
      this.buttonEnd.Image = ((System.Drawing.Image)(resources.GetObject("buttonEnd.Image")));
      this.buttonEnd.Location = new System.Drawing.Point(258, 231);
      this.buttonEnd.Name = "buttonEnd";
      this.buttonEnd.Size = new System.Drawing.Size(75, 34);
      this.buttonEnd.TabIndex = 15;
      this.buttonEnd.Text = "&Beenden";
      this.buttonEnd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.buttonEnd.UseVisualStyleBackColor = true;
      this.buttonEnd.Click += new System.EventHandler(this.buttonEnd_Click);
      // 
      // ColorSelectorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(350, 282);
      this.Controls.Add(this.buttonEnd);
      this.Controls.Add(this.buttonInformation);
      this.Controls.Add(this.textBoxHtmlColorCode);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.textBoxHexColorCode);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.pictureBoxColorRGB);
      this.Controls.Add(this.textBoxColorBlue);
      this.Controls.Add(this.trackBarColorBlue);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.textBoxColorGreen);
      this.Controls.Add(this.trackBarColorGreen);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxColorRed);
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
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TrackBar trackBarColorRed;
    private System.Windows.Forms.TextBox textBoxColorRed;
    private System.Windows.Forms.TextBox textBoxColorGreen;
    private System.Windows.Forms.TrackBar trackBarColorGreen;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textBoxColorBlue;
    private System.Windows.Forms.TrackBar trackBarColorBlue;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.PictureBox pictureBoxColorRGB;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textBoxHexColorCode;
    private System.Windows.Forms.TextBox textBoxHtmlColorCode;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button buttonInformation;
    private System.Windows.Forms.Button buttonEnd;
  }
}

