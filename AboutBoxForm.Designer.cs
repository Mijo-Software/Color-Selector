
namespace DisksizeWatcher
{
    partial class AboutBoxForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
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
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutBoxForm));
			tableLayoutPanel = new TableLayoutPanel();
			logoPictureBox = new PictureBox();
			labelProductName = new Label();
			labelVersion = new Label();
			labelCopyright = new Label();
			labelCompanyName = new Label();
			textBoxDescription = new TextBox();
			okButton = new Button();
			toolTip = new ToolTip(components);
			statusStrip = new StatusStrip();
			labelInformation = new ToolStripStatusLabel();
			toolStripContainer = new ToolStripContainer();
			tableLayoutPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).BeginInit();
			statusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel
			// 
			tableLayoutPanel.AccessibleDescription = "Just a pane";
			tableLayoutPanel.AccessibleName = "pane";
			tableLayoutPanel.AccessibleRole = AccessibleRole.Pane;
			tableLayoutPanel.ColumnCount = 2;
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.75F));
			tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.25F));
			tableLayoutPanel.Controls.Add(logoPictureBox, 0, 0);
			tableLayoutPanel.Controls.Add(labelProductName, 1, 0);
			tableLayoutPanel.Controls.Add(labelVersion, 1, 1);
			tableLayoutPanel.Controls.Add(labelCopyright, 1, 2);
			tableLayoutPanel.Controls.Add(labelCompanyName, 1, 3);
			tableLayoutPanel.Controls.Add(textBoxDescription, 1, 4);
			tableLayoutPanel.Controls.Add(okButton, 1, 5);
			tableLayoutPanel.Dock = DockStyle.Fill;
			tableLayoutPanel.Location = new Point(0, 0);
			tableLayoutPanel.Margin = new Padding(4, 3, 4, 3);
			tableLayoutPanel.Name = "tableLayoutPanel";
			tableLayoutPanel.RowCount = 6;
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 36.94268F));
			tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 24.84076F));
			tableLayoutPanel.Size = new Size(295, 156);
			tableLayoutPanel.TabIndex = 0;
			// 
			// logoPictureBox
			// 
			logoPictureBox.AccessibleDescription = "This is the program icon.";
			logoPictureBox.AccessibleName = "program icon";
			logoPictureBox.AccessibleRole = AccessibleRole.Graphic;
			logoPictureBox.Dock = DockStyle.Fill;
			logoPictureBox.Location = new Point(4, 3);
			logoPictureBox.Margin = new Padding(4, 3, 4, 3);
			logoPictureBox.Name = "logoPictureBox";
			tableLayoutPanel.SetRowSpan(logoPictureBox, 6);
			logoPictureBox.Size = new Size(47, 150);
			logoPictureBox.TabIndex = 12;
			logoPictureBox.TabStop = false;
			toolTip.SetToolTip(logoPictureBox, "program icon");
			logoPictureBox.MouseEnter += SetStatusbar_Enter;
			logoPictureBox.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelProductName
			// 
			labelProductName.AccessibleDescription = "Show the product name";
			labelProductName.AccessibleName = "Product name";
			labelProductName.AccessibleRole = AccessibleRole.StaticText;
			labelProductName.AutoEllipsis = true;
			labelProductName.Dock = DockStyle.Fill;
			labelProductName.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelProductName.Location = new Point(62, 0);
			labelProductName.Margin = new Padding(7, 0, 4, 0);
			labelProductName.MaximumSize = new Size(0, 20);
			labelProductName.Name = "labelProductName";
			labelProductName.Size = new Size(229, 15);
			labelProductName.TabIndex = 0;
			labelProductName.Text = "Product name";
			labelProductName.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelProductName, "Product name");
			labelProductName.Enter += SetStatusbar_Enter;
			labelProductName.Leave += ClearStatusbar_Leave;
			labelProductName.MouseEnter += SetStatusbar_Enter;
			labelProductName.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelVersion
			// 
			labelVersion.AccessibleDescription = "Show the version";
			labelVersion.AccessibleName = "Version";
			labelVersion.AccessibleRole = AccessibleRole.StaticText;
			labelVersion.AutoEllipsis = true;
			labelVersion.Dock = DockStyle.Fill;
			labelVersion.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelVersion.Location = new Point(62, 15);
			labelVersion.Margin = new Padding(7, 0, 4, 0);
			labelVersion.MaximumSize = new Size(0, 20);
			labelVersion.Name = "labelVersion";
			labelVersion.Size = new Size(229, 15);
			labelVersion.TabIndex = 1;
			labelVersion.Text = "Version";
			labelVersion.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelVersion, "Version");
			labelVersion.Enter += SetStatusbar_Enter;
			labelVersion.Leave += ClearStatusbar_Leave;
			labelVersion.MouseEnter += SetStatusbar_Enter;
			labelVersion.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelCopyright
			// 
			labelCopyright.AccessibleDescription = "Show the copyright";
			labelCopyright.AccessibleName = "Copyright";
			labelCopyright.AccessibleRole = AccessibleRole.StaticText;
			labelCopyright.AutoEllipsis = true;
			labelCopyright.Dock = DockStyle.Fill;
			labelCopyright.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelCopyright.Location = new Point(62, 30);
			labelCopyright.Margin = new Padding(7, 0, 4, 0);
			labelCopyright.MaximumSize = new Size(0, 20);
			labelCopyright.Name = "labelCopyright";
			labelCopyright.Size = new Size(229, 15);
			labelCopyright.TabIndex = 2;
			labelCopyright.Text = "Copyright";
			labelCopyright.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelCopyright, "Copyright");
			labelCopyright.Enter += SetStatusbar_Enter;
			labelCopyright.Leave += ClearStatusbar_Leave;
			labelCopyright.MouseEnter += SetStatusbar_Enter;
			labelCopyright.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelCompanyName
			// 
			labelCompanyName.AccessibleDescription = "Show the company name";
			labelCompanyName.AccessibleName = "Company name";
			labelCompanyName.AccessibleRole = AccessibleRole.StaticText;
			labelCompanyName.AutoEllipsis = true;
			labelCompanyName.Dock = DockStyle.Fill;
			labelCompanyName.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Polite;
			labelCompanyName.Location = new Point(62, 45);
			labelCompanyName.Margin = new Padding(7, 0, 4, 0);
			labelCompanyName.MaximumSize = new Size(0, 20);
			labelCompanyName.Name = "labelCompanyName";
			labelCompanyName.Size = new Size(229, 15);
			labelCompanyName.TabIndex = 3;
			labelCompanyName.Text = "Company name";
			labelCompanyName.TextAlign = ContentAlignment.MiddleLeft;
			toolTip.SetToolTip(labelCompanyName, "Copyright name");
			labelCompanyName.Enter += SetStatusbar_Enter;
			labelCompanyName.Leave += ClearStatusbar_Leave;
			labelCompanyName.MouseEnter += SetStatusbar_Enter;
			labelCompanyName.MouseLeave += ClearStatusbar_Leave;
			// 
			// textBoxDescription
			// 
			textBoxDescription.AccessibleDescription = "Show the description";
			textBoxDescription.AccessibleName = "Description";
			textBoxDescription.AccessibleRole = AccessibleRole.Text;
			textBoxDescription.Dock = DockStyle.Fill;
			textBoxDescription.Location = new Point(62, 63);
			textBoxDescription.Margin = new Padding(7, 3, 4, 3);
			textBoxDescription.Multiline = true;
			textBoxDescription.Name = "textBoxDescription";
			textBoxDescription.ReadOnly = true;
			textBoxDescription.ScrollBars = ScrollBars.Both;
			textBoxDescription.Size = new Size(229, 50);
			textBoxDescription.TabIndex = 4;
			textBoxDescription.TabStop = false;
			textBoxDescription.Text = "Description";
			toolTip.SetToolTip(textBoxDescription, "Description");
			textBoxDescription.Enter += SetStatusbar_Enter;
			textBoxDescription.Leave += ClearStatusbar_Leave;
			textBoxDescription.MouseEnter += AboutBoxForm_Load;
			textBoxDescription.MouseLeave += ClearStatusbar_Leave;
			// 
			// okButton
			// 
			okButton.AccessibleDescription = "Close the window";
			okButton.AccessibleName = "OK button";
			okButton.AccessibleRole = AccessibleRole.PushButton;
			okButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			okButton.AutoEllipsis = true;
			okButton.DialogResult = DialogResult.OK;
			okButton.Image = ColorSelector.Properties.Resources.tick;
			okButton.ImageAlign = ContentAlignment.MiddleRight;
			okButton.Location = new Point(203, 126);
			okButton.Margin = new Padding(4, 3, 4, 3);
			okButton.Name = "okButton";
			okButton.Size = new Size(88, 27);
			okButton.TabIndex = 5;
			okButton.Text = "&OK";
			okButton.TextImageRelation = TextImageRelation.ImageBeforeText;
			okButton.Enter += SetStatusbar_Enter;
			okButton.Leave += ClearStatusbar_Leave;
			okButton.MouseEnter += SetStatusbar_Enter;
			okButton.MouseLeave += ClearStatusbar_Leave;
			// 
			// statusStrip
			// 
			statusStrip.AccessibleDescription = "Show the status bar";
			statusStrip.AccessibleName = "status bar";
			statusStrip.AccessibleRole = AccessibleRole.StatusBar;
			statusStrip.AllowItemReorder = true;
			statusStrip.Dock = DockStyle.None;
			statusStrip.Items.AddRange(new ToolStripItem[] { labelInformation });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.ShowItemToolTips = true;
			statusStrip.Size = new Size(295, 22);
			statusStrip.SizingGrip = false;
			statusStrip.TabIndex = 0;
			statusStrip.TabStop = true;
			statusStrip.Text = "statusStrip";
			toolTip.SetToolTip(statusStrip, "Show the status bar");
			// 
			// labelInformation
			// 
			labelInformation.AccessibleDescription = "Show some information";
			labelInformation.AccessibleName = "some information";
			labelInformation.AccessibleRole = AccessibleRole.StaticText;
			labelInformation.AutoToolTip = true;
			labelInformation.Name = "labelInformation";
			labelInformation.Size = new Size(28, 17);
			labelInformation.Text = "info";
			// 
			// toolStripContainer
			// 
			toolStripContainer.AccessibleDescription = "Just a tool bar";
			toolStripContainer.AccessibleName = "tool bar";
			toolStripContainer.AccessibleRole = AccessibleRole.ToolBar;
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(tableLayoutPanel);
			toolStripContainer.ContentPanel.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.ContentPanel.Size = new Size(295, 156);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(3, 3);
			toolStripContainer.Margin = new Padding(4, 3, 4, 3);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(295, 203);
			toolStripContainer.TabIndex = 8;
			toolStripContainer.Text = "toolStripContainer";
			// 
			// AboutBoxForm
			// 
			AcceptButton = okButton;
			AccessibleDescription = "This is the program information window.";
			AccessibleName = "Program information";
			AccessibleRole = AccessibleRole.Dialog;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(301, 209);
			Controls.Add(toolStripContainer);
			FormBorderStyle = FormBorderStyle.FixedDialog;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AboutBoxForm";
			Padding = new Padding(3);
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterParent;
			Text = "Program information";
			Load += AboutBoxForm_Load;
			tableLayoutPanel.ResumeLayout(false);
			tableLayoutPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)logoPictureBox).EndInit();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Label labelProductName;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelCopyright;
        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelInformation;
        private System.Windows.Forms.ToolStripContainer toolStripContainer;
    }
}
