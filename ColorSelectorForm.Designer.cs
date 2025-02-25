namespace Color_Selector
{
    partial class ColorSelectorForm
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
			statusStrip = new StatusStrip();
			toolStripStatusLabelInformation = new ToolStripStatusLabel();
			toolStripContainer = new ToolStripContainer();
			tableLayoutPanelColorCodes = new TableLayoutPanel();
			labelColorCodeMath = new Label();
			textBoxColorCodeMath = new TextBox();
			labelColorCodeRgb = new Label();
			textBoxColorCodeRgb = new TextBox();
			labelColorCodeHtml = new Label();
			textBoxColorCodeHtml = new TextBox();
			labelColorCodeHex = new Label();
			textBoxColorCodeHex = new TextBox();
			buttonbuttonCopyToClipboardColorCodeMath = new Button();
			buttonCopyToClipboardColorCodeHex = new Button();
			buttonCopyToClipboardColorCodeRgb = new Button();
			buttonCopyToClipboardColorCodeHtml = new Button();
			panelCanvas = new Panel();
			pictureBoxCanvas = new PictureBox();
			tableLayoutPanelRgba = new TableLayoutPanel();
			pictureBoxBindChannelBlue = new PictureBox();
			pictureBoxBindChannelGreen = new PictureBox();
			pictureBoxBindChannelRed = new PictureBox();
			buttonMirrorChannelAlpha = new Button();
			buttonMirrorChannelBlue = new Button();
			buttonMirrorChannelGreen = new Button();
			buttonMirrorChannelRed = new Button();
			buttonInvertChannelAlpha = new Button();
			buttonInvertChannelBlue = new Button();
			buttonInvertChannelGreen = new Button();
			buttonInvertChannelRed = new Button();
			labelChannelRed = new Label();
			labelChannelGreen = new Label();
			labelChannelBlue = new Label();
			labelAlpha = new Label();
			numericUpDownChannelAlpha = new NumericUpDown();
			trackBarChannelAlpha = new TrackBar();
			numericUpDownChannelBlue = new NumericUpDown();
			numericUpDownChannelGreen = new NumericUpDown();
			trackBarChannelBlue = new TrackBar();
			trackBarChannelGreen = new TrackBar();
			numericUpDownChannelRed = new NumericUpDown();
			trackBarChannelRed = new TrackBar();
			buttonRandomizeChannelRed = new Button();
			buttonRandomizeChannelGreen = new Button();
			buttonRandomizeChannelBlue = new Button();
			buttonRandomizeChannelAlpha = new Button();
			menuStrip = new MenuStrip();
			toolStripMenuItemFile = new ToolStripMenuItem();
			toolStripMenuItemAbout = new ToolStripMenuItem();
			toolStripSeparator2 = new ToolStripSeparator();
			toolStripMenuItemExit = new ToolStripMenuItem();
			toolStripMenuItemOperations = new ToolStripMenuItem();
			toolStripMenuItemInvert = new ToolStripMenuItem();
			toolStripMenuItemRandomize = new ToolStripMenuItem();
			toolStripMenuItemMirror = new ToolStripMenuItem();
			toolStripMenuItemSwap = new ToolStripMenuItem();
			contextMenuStripSwap = new ContextMenuStrip(components);
			toolStripMenuItemSwapRedGreen = new ToolStripMenuItem();
			toolStripMenuItemSwapRedBlue = new ToolStripMenuItem();
			toolStripMenuItemBlueGreen = new ToolStripMenuItem();
			toolStrip = new ToolStrip();
			toolStripButtonInvert = new ToolStripButton();
			toolStripButtonRandomize = new ToolStripButton();
			toolStripButtonMirror = new ToolStripButton();
			toolStripDropDownButtonSwap = new ToolStripDropDownButton();
			toolStripDropDownButton1 = new ToolStripDropDownButton();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripButtonAbout = new ToolStripButton();
			toolTip = new ToolTip(components);
			statusStrip.SuspendLayout();
			toolStripContainer.BottomToolStripPanel.SuspendLayout();
			toolStripContainer.ContentPanel.SuspendLayout();
			toolStripContainer.TopToolStripPanel.SuspendLayout();
			toolStripContainer.SuspendLayout();
			tableLayoutPanelColorCodes.SuspendLayout();
			panelCanvas.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).BeginInit();
			tableLayoutPanelRgba.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxBindChannelBlue).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxBindChannelGreen).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxBindChannelRed).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownChannelAlpha).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBarChannelAlpha).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownChannelBlue).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownChannelGreen).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBarChannelBlue).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBarChannelGreen).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownChannelRed).BeginInit();
			((System.ComponentModel.ISupportInitialize)trackBarChannelRed).BeginInit();
			menuStrip.SuspendLayout();
			contextMenuStripSwap.SuspendLayout();
			toolStrip.SuspendLayout();
			SuspendLayout();
			// 
			// statusStrip
			// 
			statusStrip.Dock = DockStyle.None;
			statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelInformation });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
			statusStrip.Size = new Size(480, 22);
			statusStrip.TabIndex = 0;
			statusStrip.Enter += SetStatusbar_Enter;
			statusStrip.Leave += ClearStatusbar_Leave;
			statusStrip.MouseEnter += SetStatusbar_Enter;
			statusStrip.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripStatusLabelInformation
			// 
			toolStripStatusLabelInformation.Name = "toolStripStatusLabelInformation";
			toolStripStatusLabelInformation.Size = new Size(70, 17);
			toolStripStatusLabelInformation.Text = "information";
			toolStripStatusLabelInformation.MouseEnter += SetStatusbar_Enter;
			toolStripStatusLabelInformation.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripContainer
			// 
			// 
			// toolStripContainer.BottomToolStripPanel
			// 
			toolStripContainer.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer.ContentPanel
			// 
			toolStripContainer.ContentPanel.Controls.Add(tableLayoutPanelColorCodes);
			toolStripContainer.ContentPanel.Controls.Add(panelCanvas);
			toolStripContainer.ContentPanel.Controls.Add(tableLayoutPanelRgba);
			toolStripContainer.ContentPanel.Size = new Size(480, 256);
			toolStripContainer.Dock = DockStyle.Fill;
			toolStripContainer.Location = new Point(0, 0);
			toolStripContainer.Name = "toolStripContainer";
			toolStripContainer.Size = new Size(480, 327);
			toolStripContainer.TabIndex = 1;
			toolStripContainer.Text = "toolStripContainer";
			// 
			// toolStripContainer.TopToolStripPanel
			// 
			toolStripContainer.TopToolStripPanel.Controls.Add(menuStrip);
			toolStripContainer.TopToolStripPanel.Controls.Add(toolStrip);
			toolStripContainer.TopToolStripPanel.Enter += SetStatusbar_Enter;
			toolStripContainer.TopToolStripPanel.Leave += ClearStatusbar_Leave;
			toolStripContainer.TopToolStripPanel.MouseEnter += SetStatusbar_Enter;
			toolStripContainer.TopToolStripPanel.MouseLeave += ClearStatusbar_Leave;
			// 
			// tableLayoutPanelColorCodes
			// 
			tableLayoutPanelColorCodes.ColumnCount = 3;
			tableLayoutPanelColorCodes.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanelColorCodes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
			tableLayoutPanelColorCodes.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
			tableLayoutPanelColorCodes.Controls.Add(labelColorCodeMath, 0, 3);
			tableLayoutPanelColorCodes.Controls.Add(textBoxColorCodeMath, 1, 3);
			tableLayoutPanelColorCodes.Controls.Add(labelColorCodeRgb, 0, 2);
			tableLayoutPanelColorCodes.Controls.Add(textBoxColorCodeRgb, 1, 2);
			tableLayoutPanelColorCodes.Controls.Add(labelColorCodeHtml, 0, 1);
			tableLayoutPanelColorCodes.Controls.Add(textBoxColorCodeHtml, 1, 1);
			tableLayoutPanelColorCodes.Controls.Add(labelColorCodeHex, 0, 0);
			tableLayoutPanelColorCodes.Controls.Add(textBoxColorCodeHex, 1, 0);
			tableLayoutPanelColorCodes.Controls.Add(buttonbuttonCopyToClipboardColorCodeMath, 2, 3);
			tableLayoutPanelColorCodes.Controls.Add(buttonCopyToClipboardColorCodeHex, 2, 0);
			tableLayoutPanelColorCodes.Controls.Add(buttonCopyToClipboardColorCodeRgb, 2, 2);
			tableLayoutPanelColorCodes.Controls.Add(buttonCopyToClipboardColorCodeHtml, 2, 1);
			tableLayoutPanelColorCodes.Location = new Point(137, 130);
			tableLayoutPanelColorCodes.Name = "tableLayoutPanelColorCodes";
			tableLayoutPanelColorCodes.RowCount = 4;
			tableLayoutPanelColorCodes.RowStyles.Add(new RowStyle());
			tableLayoutPanelColorCodes.RowStyles.Add(new RowStyle());
			tableLayoutPanelColorCodes.RowStyles.Add(new RowStyle());
			tableLayoutPanelColorCodes.RowStyles.Add(new RowStyle());
			tableLayoutPanelColorCodes.Size = new Size(299, 119);
			tableLayoutPanelColorCodes.TabIndex = 3;
			tableLayoutPanelColorCodes.Enter += SetStatusbar_Enter;
			tableLayoutPanelColorCodes.Leave += ClearStatusbar_Leave;
			tableLayoutPanelColorCodes.MouseEnter += SetStatusbar_Enter;
			tableLayoutPanelColorCodes.MouseLeave += ClearStatusbar_Leave;
			// 
			// labelColorCodeMath
			// 
			labelColorCodeMath.Dock = DockStyle.Fill;
			labelColorCodeMath.Location = new Point(3, 89);
			labelColorCodeMath.Name = "labelColorCodeMath";
			labelColorCodeMath.Size = new Size(100, 30);
			labelColorCodeMath.TabIndex = 9;
			labelColorCodeMath.Text = "Mathe-Farbcode";
			labelColorCodeMath.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBoxColorCodeMath
			// 
			textBoxColorCodeMath.Dock = DockStyle.Fill;
			textBoxColorCodeMath.Location = new Point(109, 92);
			textBoxColorCodeMath.Name = "textBoxColorCodeMath";
			textBoxColorCodeMath.ReadOnly = true;
			textBoxColorCodeMath.Size = new Size(144, 23);
			textBoxColorCodeMath.TabIndex = 10;
			// 
			// labelColorCodeRgb
			// 
			labelColorCodeRgb.Dock = DockStyle.Fill;
			labelColorCodeRgb.Location = new Point(3, 60);
			labelColorCodeRgb.Name = "labelColorCodeRgb";
			labelColorCodeRgb.Size = new Size(100, 29);
			labelColorCodeRgb.TabIndex = 6;
			labelColorCodeRgb.Text = "RGB-Farbcode";
			labelColorCodeRgb.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBoxColorCodeRgb
			// 
			textBoxColorCodeRgb.Dock = DockStyle.Fill;
			textBoxColorCodeRgb.Location = new Point(109, 63);
			textBoxColorCodeRgb.Name = "textBoxColorCodeRgb";
			textBoxColorCodeRgb.ReadOnly = true;
			textBoxColorCodeRgb.Size = new Size(144, 23);
			textBoxColorCodeRgb.TabIndex = 7;
			// 
			// labelColorCodeHtml
			// 
			labelColorCodeHtml.Dock = DockStyle.Fill;
			labelColorCodeHtml.Location = new Point(3, 30);
			labelColorCodeHtml.Name = "labelColorCodeHtml";
			labelColorCodeHtml.Size = new Size(100, 30);
			labelColorCodeHtml.TabIndex = 3;
			labelColorCodeHtml.Text = "HTML-Farbcode";
			labelColorCodeHtml.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBoxColorCodeHtml
			// 
			textBoxColorCodeHtml.Dock = DockStyle.Fill;
			textBoxColorCodeHtml.Location = new Point(109, 33);
			textBoxColorCodeHtml.Name = "textBoxColorCodeHtml";
			textBoxColorCodeHtml.ReadOnly = true;
			textBoxColorCodeHtml.Size = new Size(144, 23);
			textBoxColorCodeHtml.TabIndex = 4;
			// 
			// labelColorCodeHex
			// 
			labelColorCodeHex.Dock = DockStyle.Fill;
			labelColorCodeHex.Location = new Point(3, 0);
			labelColorCodeHex.Name = "labelColorCodeHex";
			labelColorCodeHex.Size = new Size(100, 30);
			labelColorCodeHex.TabIndex = 0;
			labelColorCodeHex.Text = "HEX-Farbcode";
			labelColorCodeHex.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// textBoxColorCodeHex
			// 
			textBoxColorCodeHex.Dock = DockStyle.Fill;
			textBoxColorCodeHex.Location = new Point(109, 3);
			textBoxColorCodeHex.Name = "textBoxColorCodeHex";
			textBoxColorCodeHex.ReadOnly = true;
			textBoxColorCodeHex.Size = new Size(144, 23);
			textBoxColorCodeHex.TabIndex = 1;
			// 
			// buttonbuttonCopyToClipboardColorCodeMath
			// 
			buttonbuttonCopyToClipboardColorCodeMath.Dock = DockStyle.Fill;
			buttonbuttonCopyToClipboardColorCodeMath.Image = ColorSelector.Properties.Resources.clipboard_empty;
			buttonbuttonCopyToClipboardColorCodeMath.Location = new Point(259, 92);
			buttonbuttonCopyToClipboardColorCodeMath.Name = "buttonbuttonCopyToClipboardColorCodeMath";
			buttonbuttonCopyToClipboardColorCodeMath.Size = new Size(37, 24);
			buttonbuttonCopyToClipboardColorCodeMath.TabIndex = 11;
			buttonbuttonCopyToClipboardColorCodeMath.UseVisualStyleBackColor = true;
			buttonbuttonCopyToClipboardColorCodeMath.Click += ButtonbuttonCopyToClipboardColorCodeMath_Click;
			// 
			// buttonCopyToClipboardColorCodeHex
			// 
			buttonCopyToClipboardColorCodeHex.Dock = DockStyle.Fill;
			buttonCopyToClipboardColorCodeHex.Image = ColorSelector.Properties.Resources.clipboard_empty;
			buttonCopyToClipboardColorCodeHex.Location = new Point(259, 3);
			buttonCopyToClipboardColorCodeHex.Name = "buttonCopyToClipboardColorCodeHex";
			buttonCopyToClipboardColorCodeHex.Size = new Size(37, 24);
			buttonCopyToClipboardColorCodeHex.TabIndex = 2;
			buttonCopyToClipboardColorCodeHex.UseVisualStyleBackColor = true;
			buttonCopyToClipboardColorCodeHex.Click += ButtonCopyToClipboardColorCodeHex_Click;
			// 
			// buttonCopyToClipboardColorCodeRgb
			// 
			buttonCopyToClipboardColorCodeRgb.Dock = DockStyle.Fill;
			buttonCopyToClipboardColorCodeRgb.Image = ColorSelector.Properties.Resources.clipboard_empty;
			buttonCopyToClipboardColorCodeRgb.Location = new Point(259, 63);
			buttonCopyToClipboardColorCodeRgb.Name = "buttonCopyToClipboardColorCodeRgb";
			buttonCopyToClipboardColorCodeRgb.Size = new Size(37, 23);
			buttonCopyToClipboardColorCodeRgb.TabIndex = 8;
			buttonCopyToClipboardColorCodeRgb.UseVisualStyleBackColor = true;
			buttonCopyToClipboardColorCodeRgb.Click += ButtonCopyToClipboardColorCodeRgb_Click;
			// 
			// buttonCopyToClipboardColorCodeHtml
			// 
			buttonCopyToClipboardColorCodeHtml.Dock = DockStyle.Fill;
			buttonCopyToClipboardColorCodeHtml.Image = ColorSelector.Properties.Resources.clipboard_empty;
			buttonCopyToClipboardColorCodeHtml.Location = new Point(259, 33);
			buttonCopyToClipboardColorCodeHtml.Name = "buttonCopyToClipboardColorCodeHtml";
			buttonCopyToClipboardColorCodeHtml.Size = new Size(37, 24);
			buttonCopyToClipboardColorCodeHtml.TabIndex = 5;
			buttonCopyToClipboardColorCodeHtml.UseVisualStyleBackColor = true;
			buttonCopyToClipboardColorCodeHtml.Click += ButtonCopyToClipboardColorCodeHtml_Click;
			// 
			// panelCanvas
			// 
			panelCanvas.BackColor = Color.Transparent;
			panelCanvas.BackgroundImage = ColorSelector.Properties.Resources.bg;
			panelCanvas.Controls.Add(pictureBoxCanvas);
			panelCanvas.Location = new Point(6, 130);
			panelCanvas.Name = "panelCanvas";
			panelCanvas.Size = new Size(125, 119);
			panelCanvas.TabIndex = 0;
			panelCanvas.Enter += SetStatusbar_Enter;
			panelCanvas.Leave += ClearStatusbar_Leave;
			panelCanvas.MouseEnter += SetStatusbar_Enter;
			panelCanvas.MouseLeave += ClearStatusbar_Leave;
			// 
			// pictureBoxCanvas
			// 
			pictureBoxCanvas.BackColor = Color.Transparent;
			pictureBoxCanvas.BackgroundImageLayout = ImageLayout.None;
			pictureBoxCanvas.BorderStyle = BorderStyle.FixedSingle;
			pictureBoxCanvas.Dock = DockStyle.Fill;
			pictureBoxCanvas.Location = new Point(0, 0);
			pictureBoxCanvas.Name = "pictureBoxCanvas";
			pictureBoxCanvas.Size = new Size(125, 119);
			pictureBoxCanvas.TabIndex = 1;
			pictureBoxCanvas.TabStop = false;
			// 
			// tableLayoutPanelRgba
			// 
			tableLayoutPanelRgba.ColumnCount = 7;
			tableLayoutPanelRgba.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 54F));
			tableLayoutPanelRgba.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 251F));
			tableLayoutPanelRgba.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50F));
			tableLayoutPanelRgba.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 32F));
			tableLayoutPanelRgba.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
			tableLayoutPanelRgba.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
			tableLayoutPanelRgba.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 30F));
			tableLayoutPanelRgba.Controls.Add(pictureBoxBindChannelBlue, 6, 2);
			tableLayoutPanelRgba.Controls.Add(pictureBoxBindChannelGreen, 6, 1);
			tableLayoutPanelRgba.Controls.Add(pictureBoxBindChannelRed, 6, 0);
			tableLayoutPanelRgba.Controls.Add(buttonMirrorChannelAlpha, 5, 3);
			tableLayoutPanelRgba.Controls.Add(buttonMirrorChannelBlue, 5, 2);
			tableLayoutPanelRgba.Controls.Add(buttonMirrorChannelGreen, 5, 1);
			tableLayoutPanelRgba.Controls.Add(buttonMirrorChannelRed, 5, 0);
			tableLayoutPanelRgba.Controls.Add(buttonInvertChannelAlpha, 4, 3);
			tableLayoutPanelRgba.Controls.Add(buttonInvertChannelBlue, 4, 2);
			tableLayoutPanelRgba.Controls.Add(buttonInvertChannelGreen, 4, 1);
			tableLayoutPanelRgba.Controls.Add(buttonInvertChannelRed, 4, 0);
			tableLayoutPanelRgba.Controls.Add(labelChannelRed, 0, 0);
			tableLayoutPanelRgba.Controls.Add(labelChannelGreen, 0, 1);
			tableLayoutPanelRgba.Controls.Add(labelChannelBlue, 0, 2);
			tableLayoutPanelRgba.Controls.Add(labelAlpha, 0, 3);
			tableLayoutPanelRgba.Controls.Add(numericUpDownChannelAlpha, 2, 3);
			tableLayoutPanelRgba.Controls.Add(trackBarChannelAlpha, 1, 3);
			tableLayoutPanelRgba.Controls.Add(numericUpDownChannelBlue, 2, 2);
			tableLayoutPanelRgba.Controls.Add(numericUpDownChannelGreen, 2, 1);
			tableLayoutPanelRgba.Controls.Add(trackBarChannelBlue, 1, 2);
			tableLayoutPanelRgba.Controls.Add(trackBarChannelGreen, 1, 1);
			tableLayoutPanelRgba.Controls.Add(numericUpDownChannelRed, 2, 0);
			tableLayoutPanelRgba.Controls.Add(trackBarChannelRed, 1, 0);
			tableLayoutPanelRgba.Controls.Add(buttonRandomizeChannelRed, 3, 0);
			tableLayoutPanelRgba.Controls.Add(buttonRandomizeChannelGreen, 3, 1);
			tableLayoutPanelRgba.Controls.Add(buttonRandomizeChannelBlue, 3, 2);
			tableLayoutPanelRgba.Controls.Add(buttonRandomizeChannelAlpha, 3, 3);
			tableLayoutPanelRgba.Location = new Point(3, 3);
			tableLayoutPanelRgba.Name = "tableLayoutPanelRgba";
			tableLayoutPanelRgba.RowCount = 4;
			tableLayoutPanelRgba.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanelRgba.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanelRgba.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanelRgba.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
			tableLayoutPanelRgba.Size = new Size(475, 121);
			tableLayoutPanelRgba.TabIndex = 0;
			tableLayoutPanelRgba.Enter += SetStatusbar_Enter;
			tableLayoutPanelRgba.Leave += ClearStatusbar_Leave;
			tableLayoutPanelRgba.MouseEnter += SetStatusbar_Enter;
			tableLayoutPanelRgba.MouseLeave += ClearStatusbar_Leave;
			// 
			// pictureBoxBindChannelBlue
			// 
			pictureBoxBindChannelBlue.Location = new Point(450, 63);
			pictureBoxBindChannelBlue.Name = "pictureBoxBindChannelBlue";
			pictureBoxBindChannelBlue.Size = new Size(16, 16);
			pictureBoxBindChannelBlue.TabIndex = 2;
			pictureBoxBindChannelBlue.TabStop = false;
			// 
			// pictureBoxBindChannelGreen
			// 
			pictureBoxBindChannelGreen.Location = new Point(450, 33);
			pictureBoxBindChannelGreen.Name = "pictureBoxBindChannelGreen";
			pictureBoxBindChannelGreen.Size = new Size(16, 16);
			pictureBoxBindChannelGreen.TabIndex = 2;
			pictureBoxBindChannelGreen.TabStop = false;
			// 
			// pictureBoxBindChannelRed
			// 
			pictureBoxBindChannelRed.Location = new Point(450, 3);
			pictureBoxBindChannelRed.Name = "pictureBoxBindChannelRed";
			pictureBoxBindChannelRed.Size = new Size(16, 16);
			pictureBoxBindChannelRed.TabIndex = 1;
			pictureBoxBindChannelRed.TabStop = false;
			// 
			// buttonMirrorChannelAlpha
			// 
			buttonMirrorChannelAlpha.BackgroundImageLayout = ImageLayout.Center;
			buttonMirrorChannelAlpha.Dock = DockStyle.Fill;
			buttonMirrorChannelAlpha.Image = ColorSelector.Properties.Resources.ice_cube;
			buttonMirrorChannelAlpha.Location = new Point(420, 93);
			buttonMirrorChannelAlpha.Name = "buttonMirrorChannelAlpha";
			buttonMirrorChannelAlpha.Size = new Size(24, 25);
			buttonMirrorChannelAlpha.TabIndex = 23;
			buttonMirrorChannelAlpha.UseVisualStyleBackColor = true;
			buttonMirrorChannelAlpha.Click += ButtonMirrorChannelAlpha_Click;
			// 
			// buttonMirrorChannelBlue
			// 
			buttonMirrorChannelBlue.BackgroundImageLayout = ImageLayout.Center;
			buttonMirrorChannelBlue.Dock = DockStyle.Fill;
			buttonMirrorChannelBlue.Image = ColorSelector.Properties.Resources.ice_cube;
			buttonMirrorChannelBlue.Location = new Point(420, 63);
			buttonMirrorChannelBlue.Name = "buttonMirrorChannelBlue";
			buttonMirrorChannelBlue.Size = new Size(24, 24);
			buttonMirrorChannelBlue.TabIndex = 17;
			buttonMirrorChannelBlue.UseVisualStyleBackColor = true;
			buttonMirrorChannelBlue.Click += ButtonMirrorChannelBlue_Click;
			// 
			// buttonMirrorChannelGreen
			// 
			buttonMirrorChannelGreen.BackgroundImageLayout = ImageLayout.Center;
			buttonMirrorChannelGreen.Dock = DockStyle.Fill;
			buttonMirrorChannelGreen.Image = ColorSelector.Properties.Resources.ice_cube;
			buttonMirrorChannelGreen.Location = new Point(420, 33);
			buttonMirrorChannelGreen.Name = "buttonMirrorChannelGreen";
			buttonMirrorChannelGreen.Size = new Size(24, 24);
			buttonMirrorChannelGreen.TabIndex = 11;
			buttonMirrorChannelGreen.UseVisualStyleBackColor = true;
			buttonMirrorChannelGreen.Click += ButtonMirrorChannelGreen_Click;
			// 
			// buttonMirrorChannelRed
			// 
			buttonMirrorChannelRed.BackgroundImageLayout = ImageLayout.Center;
			buttonMirrorChannelRed.Dock = DockStyle.Fill;
			buttonMirrorChannelRed.Image = ColorSelector.Properties.Resources.ice_cube;
			buttonMirrorChannelRed.Location = new Point(420, 3);
			buttonMirrorChannelRed.Name = "buttonMirrorChannelRed";
			buttonMirrorChannelRed.Size = new Size(24, 24);
			buttonMirrorChannelRed.TabIndex = 5;
			buttonMirrorChannelRed.UseVisualStyleBackColor = true;
			buttonMirrorChannelRed.Click += ButtonMirrorChannelRed_Click;
			// 
			// buttonInvertChannelAlpha
			// 
			buttonInvertChannelAlpha.BackgroundImageLayout = ImageLayout.Center;
			buttonInvertChannelAlpha.Dock = DockStyle.Fill;
			buttonInvertChannelAlpha.Image = ColorSelector.Properties.Resources.contrast;
			buttonInvertChannelAlpha.Location = new Point(390, 93);
			buttonInvertChannelAlpha.Name = "buttonInvertChannelAlpha";
			buttonInvertChannelAlpha.Size = new Size(24, 25);
			buttonInvertChannelAlpha.TabIndex = 22;
			buttonInvertChannelAlpha.UseVisualStyleBackColor = true;
			buttonInvertChannelAlpha.Click += ButtonInvertChannelAlpha_Click;
			// 
			// buttonInvertChannelBlue
			// 
			buttonInvertChannelBlue.BackgroundImageLayout = ImageLayout.Center;
			buttonInvertChannelBlue.Dock = DockStyle.Fill;
			buttonInvertChannelBlue.Image = ColorSelector.Properties.Resources.contrast;
			buttonInvertChannelBlue.Location = new Point(390, 63);
			buttonInvertChannelBlue.Name = "buttonInvertChannelBlue";
			buttonInvertChannelBlue.Size = new Size(24, 24);
			buttonInvertChannelBlue.TabIndex = 16;
			buttonInvertChannelBlue.UseVisualStyleBackColor = true;
			buttonInvertChannelBlue.Click += ButtonInvertChannelBlue_Click;
			// 
			// buttonInvertChannelGreen
			// 
			buttonInvertChannelGreen.BackgroundImageLayout = ImageLayout.Center;
			buttonInvertChannelGreen.Dock = DockStyle.Fill;
			buttonInvertChannelGreen.Image = ColorSelector.Properties.Resources.contrast;
			buttonInvertChannelGreen.Location = new Point(390, 33);
			buttonInvertChannelGreen.Name = "buttonInvertChannelGreen";
			buttonInvertChannelGreen.Size = new Size(24, 24);
			buttonInvertChannelGreen.TabIndex = 10;
			buttonInvertChannelGreen.UseVisualStyleBackColor = true;
			buttonInvertChannelGreen.Click += ButtonInvertChannelGreen_Click;
			// 
			// buttonInvertChannelRed
			// 
			buttonInvertChannelRed.BackgroundImageLayout = ImageLayout.Center;
			buttonInvertChannelRed.Dock = DockStyle.Fill;
			buttonInvertChannelRed.Image = ColorSelector.Properties.Resources.contrast;
			buttonInvertChannelRed.Location = new Point(390, 3);
			buttonInvertChannelRed.Name = "buttonInvertChannelRed";
			buttonInvertChannelRed.Size = new Size(24, 24);
			buttonInvertChannelRed.TabIndex = 4;
			buttonInvertChannelRed.UseVisualStyleBackColor = true;
			buttonInvertChannelRed.Click += ButtonInvertChannelRed_Click;
			// 
			// labelChannelRed
			// 
			labelChannelRed.AutoEllipsis = true;
			labelChannelRed.Dock = DockStyle.Fill;
			labelChannelRed.Location = new Point(3, 0);
			labelChannelRed.Name = "labelChannelRed";
			labelChannelRed.Size = new Size(48, 30);
			labelChannelRed.TabIndex = 0;
			labelChannelRed.Text = "Rot";
			labelChannelRed.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelChannelGreen
			// 
			labelChannelGreen.AutoEllipsis = true;
			labelChannelGreen.Dock = DockStyle.Fill;
			labelChannelGreen.Location = new Point(3, 30);
			labelChannelGreen.Name = "labelChannelGreen";
			labelChannelGreen.Size = new Size(48, 30);
			labelChannelGreen.TabIndex = 6;
			labelChannelGreen.Text = "Grün";
			labelChannelGreen.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelChannelBlue
			// 
			labelChannelBlue.AutoEllipsis = true;
			labelChannelBlue.Dock = DockStyle.Fill;
			labelChannelBlue.Location = new Point(3, 60);
			labelChannelBlue.Name = "labelChannelBlue";
			labelChannelBlue.Size = new Size(48, 30);
			labelChannelBlue.TabIndex = 12;
			labelChannelBlue.Text = "Blau";
			labelChannelBlue.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// labelAlpha
			// 
			labelAlpha.AutoEllipsis = true;
			labelAlpha.Cursor = Cursors.Hand;
			labelAlpha.Dock = DockStyle.Fill;
			labelAlpha.Location = new Point(3, 90);
			labelAlpha.Name = "labelAlpha";
			labelAlpha.Size = new Size(48, 31);
			labelAlpha.TabIndex = 18;
			labelAlpha.Text = "Alpha";
			labelAlpha.TextAlign = ContentAlignment.MiddleLeft;
			// 
			// numericUpDownChannelAlpha
			// 
			numericUpDownChannelAlpha.Dock = DockStyle.Fill;
			numericUpDownChannelAlpha.Location = new Point(308, 93);
			numericUpDownChannelAlpha.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
			numericUpDownChannelAlpha.Name = "numericUpDownChannelAlpha";
			numericUpDownChannelAlpha.Size = new Size(44, 23);
			numericUpDownChannelAlpha.TabIndex = 20;
			numericUpDownChannelAlpha.TextAlign = HorizontalAlignment.Center;
			numericUpDownChannelAlpha.Value = new decimal(new int[] { 255, 0, 0, 0 });
			numericUpDownChannelAlpha.ValueChanged += NumericUpDownChannelAlpha_ValueChanged;
			// 
			// trackBarChannelAlpha
			// 
			trackBarChannelAlpha.Dock = DockStyle.Fill;
			trackBarChannelAlpha.Location = new Point(57, 93);
			trackBarChannelAlpha.Maximum = 255;
			trackBarChannelAlpha.Name = "trackBarChannelAlpha";
			trackBarChannelAlpha.Size = new Size(245, 25);
			trackBarChannelAlpha.TabIndex = 19;
			trackBarChannelAlpha.TickFrequency = 0;
			trackBarChannelAlpha.TickStyle = TickStyle.TopLeft;
			trackBarChannelAlpha.Scroll += TrackBarChannelAlpha_Scroll;
			// 
			// numericUpDownChannelBlue
			// 
			numericUpDownChannelBlue.Dock = DockStyle.Fill;
			numericUpDownChannelBlue.Location = new Point(308, 63);
			numericUpDownChannelBlue.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
			numericUpDownChannelBlue.Name = "numericUpDownChannelBlue";
			numericUpDownChannelBlue.Size = new Size(44, 23);
			numericUpDownChannelBlue.TabIndex = 14;
			numericUpDownChannelBlue.TextAlign = HorizontalAlignment.Center;
			numericUpDownChannelBlue.Value = new decimal(new int[] { 255, 0, 0, 0 });
			numericUpDownChannelBlue.ValueChanged += NumericUpDownChannelBlue_ValueChanged;
			// 
			// numericUpDownChannelGreen
			// 
			numericUpDownChannelGreen.Dock = DockStyle.Fill;
			numericUpDownChannelGreen.Location = new Point(308, 33);
			numericUpDownChannelGreen.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
			numericUpDownChannelGreen.Name = "numericUpDownChannelGreen";
			numericUpDownChannelGreen.Size = new Size(44, 23);
			numericUpDownChannelGreen.TabIndex = 8;
			numericUpDownChannelGreen.TextAlign = HorizontalAlignment.Center;
			numericUpDownChannelGreen.Value = new decimal(new int[] { 255, 0, 0, 0 });
			numericUpDownChannelGreen.ValueChanged += NumericUpDownChannelGreen_ValueChanged;
			// 
			// trackBarChannelBlue
			// 
			trackBarChannelBlue.Dock = DockStyle.Fill;
			trackBarChannelBlue.Location = new Point(57, 63);
			trackBarChannelBlue.Maximum = 255;
			trackBarChannelBlue.Name = "trackBarChannelBlue";
			trackBarChannelBlue.Size = new Size(245, 24);
			trackBarChannelBlue.TabIndex = 13;
			trackBarChannelBlue.TickFrequency = 0;
			trackBarChannelBlue.TickStyle = TickStyle.TopLeft;
			trackBarChannelBlue.Scroll += TrackBarChannelBlue_Scroll;
			// 
			// trackBarChannelGreen
			// 
			trackBarChannelGreen.Dock = DockStyle.Fill;
			trackBarChannelGreen.Location = new Point(57, 33);
			trackBarChannelGreen.Maximum = 255;
			trackBarChannelGreen.Name = "trackBarChannelGreen";
			trackBarChannelGreen.Size = new Size(245, 24);
			trackBarChannelGreen.TabIndex = 7;
			trackBarChannelGreen.TickFrequency = 0;
			trackBarChannelGreen.TickStyle = TickStyle.TopLeft;
			trackBarChannelGreen.Scroll += TrackBarChannelGreen_Scroll;
			// 
			// numericUpDownChannelRed
			// 
			numericUpDownChannelRed.Dock = DockStyle.Fill;
			numericUpDownChannelRed.Location = new Point(308, 3);
			numericUpDownChannelRed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
			numericUpDownChannelRed.Name = "numericUpDownChannelRed";
			numericUpDownChannelRed.Size = new Size(44, 23);
			numericUpDownChannelRed.TabIndex = 2;
			numericUpDownChannelRed.TextAlign = HorizontalAlignment.Center;
			numericUpDownChannelRed.Value = new decimal(new int[] { 255, 0, 0, 0 });
			numericUpDownChannelRed.ValueChanged += NumericUpDownChannelRed_ValueChanged;
			// 
			// trackBarChannelRed
			// 
			trackBarChannelRed.Dock = DockStyle.Fill;
			trackBarChannelRed.Location = new Point(57, 3);
			trackBarChannelRed.Maximum = 255;
			trackBarChannelRed.Name = "trackBarChannelRed";
			trackBarChannelRed.Size = new Size(245, 24);
			trackBarChannelRed.TabIndex = 1;
			trackBarChannelRed.TickFrequency = 0;
			trackBarChannelRed.TickStyle = TickStyle.TopLeft;
			trackBarChannelRed.Scroll += TrackBarChannelRed_Scroll;
			// 
			// buttonRandomizeChannelRed
			// 
			buttonRandomizeChannelRed.BackgroundImageLayout = ImageLayout.Center;
			buttonRandomizeChannelRed.Dock = DockStyle.Fill;
			buttonRandomizeChannelRed.Image = ColorSelector.Properties.Resources.dice;
			buttonRandomizeChannelRed.Location = new Point(358, 3);
			buttonRandomizeChannelRed.Name = "buttonRandomizeChannelRed";
			buttonRandomizeChannelRed.Size = new Size(26, 24);
			buttonRandomizeChannelRed.TabIndex = 3;
			buttonRandomizeChannelRed.UseVisualStyleBackColor = true;
			buttonRandomizeChannelRed.Click += ButtonRandomizeChannelRed_Click;
			// 
			// buttonRandomizeChannelGreen
			// 
			buttonRandomizeChannelGreen.BackgroundImageLayout = ImageLayout.Center;
			buttonRandomizeChannelGreen.Dock = DockStyle.Fill;
			buttonRandomizeChannelGreen.Image = ColorSelector.Properties.Resources.dice;
			buttonRandomizeChannelGreen.Location = new Point(358, 33);
			buttonRandomizeChannelGreen.Name = "buttonRandomizeChannelGreen";
			buttonRandomizeChannelGreen.Size = new Size(26, 24);
			buttonRandomizeChannelGreen.TabIndex = 9;
			buttonRandomizeChannelGreen.UseVisualStyleBackColor = true;
			buttonRandomizeChannelGreen.Click += ButtonRandomizeChannelGreen_Click;
			// 
			// buttonRandomizeChannelBlue
			// 
			buttonRandomizeChannelBlue.BackgroundImageLayout = ImageLayout.Center;
			buttonRandomizeChannelBlue.Dock = DockStyle.Fill;
			buttonRandomizeChannelBlue.Image = ColorSelector.Properties.Resources.dice;
			buttonRandomizeChannelBlue.Location = new Point(358, 63);
			buttonRandomizeChannelBlue.Name = "buttonRandomizeChannelBlue";
			buttonRandomizeChannelBlue.Size = new Size(26, 24);
			buttonRandomizeChannelBlue.TabIndex = 15;
			buttonRandomizeChannelBlue.UseVisualStyleBackColor = true;
			buttonRandomizeChannelBlue.Click += ButtonRandomizeChannelBlue_Click;
			// 
			// buttonRandomizeChannelAlpha
			// 
			buttonRandomizeChannelAlpha.BackgroundImageLayout = ImageLayout.Center;
			buttonRandomizeChannelAlpha.Dock = DockStyle.Fill;
			buttonRandomizeChannelAlpha.Image = ColorSelector.Properties.Resources.dice;
			buttonRandomizeChannelAlpha.Location = new Point(358, 93);
			buttonRandomizeChannelAlpha.Name = "buttonRandomizeChannelAlpha";
			buttonRandomizeChannelAlpha.Size = new Size(26, 25);
			buttonRandomizeChannelAlpha.TabIndex = 21;
			buttonRandomizeChannelAlpha.UseVisualStyleBackColor = true;
			buttonRandomizeChannelAlpha.Click += ButtonRandomizeChannelAlpha_Click;
			// 
			// menuStrip
			// 
			menuStrip.Dock = DockStyle.None;
			menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile, toolStripMenuItemOperations });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.Size = new Size(480, 24);
			menuStrip.TabIndex = 0;
			menuStrip.Text = "menuStrip";
			menuStrip.Enter += SetStatusbar_Enter;
			menuStrip.Leave += ClearStatusbar_Leave;
			menuStrip.MouseEnter += SetStatusbar_Enter;
			menuStrip.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemFile
			// 
			toolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemAbout, toolStripSeparator2, toolStripMenuItemExit });
			toolStripMenuItemFile.Name = "toolStripMenuItemFile";
			toolStripMenuItemFile.Size = new Size(46, 20);
			toolStripMenuItemFile.Text = "&Datei";
			toolStripMenuItemFile.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemFile.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemAbout
			// 
			toolStripMenuItemAbout.Image = ColorSelector.Properties.Resources.information;
			toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
			toolStripMenuItemAbout.Size = new Size(100, 22);
			toolStripMenuItemAbout.Text = "&Info";
			toolStripMenuItemAbout.Click += ToolStripMenuItemAbout_Click;
			toolStripMenuItemAbout.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemAbout.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(97, 6);
			toolStripSeparator2.MouseEnter += SetStatusbar_Enter;
			toolStripSeparator2.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemExit
			// 
			toolStripMenuItemExit.Image = ColorSelector.Properties.Resources.door;
			toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			toolStripMenuItemExit.Size = new Size(100, 22);
			toolStripMenuItemExit.Text = "&Ende";
			toolStripMenuItemExit.Click += ToolStripMenuItemExit_Click;
			toolStripMenuItemExit.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemExit.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemOperations
			// 
			toolStripMenuItemOperations.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemInvert, toolStripMenuItemRandomize, toolStripMenuItemMirror, toolStripMenuItemSwap });
			toolStripMenuItemOperations.Name = "toolStripMenuItemOperations";
			toolStripMenuItemOperations.Size = new Size(85, 20);
			toolStripMenuItemOperations.Text = "&Operationen";
			toolStripMenuItemOperations.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemOperations.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemInvert
			// 
			toolStripMenuItemInvert.Image = ColorSelector.Properties.Resources.contrast;
			toolStripMenuItemInvert.Name = "toolStripMenuItemInvert";
			toolStripMenuItemInvert.Size = new Size(210, 22);
			toolStripMenuItemInvert.Text = "Farbkänale &invertieren";
			toolStripMenuItemInvert.Click += ToolStripMenuItemInvert_Click;
			toolStripMenuItemInvert.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemInvert.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemRandomize
			// 
			toolStripMenuItemRandomize.Image = ColorSelector.Properties.Resources.dice;
			toolStripMenuItemRandomize.Name = "toolStripMenuItemRandomize";
			toolStripMenuItemRandomize.Size = new Size(210, 22);
			toolStripMenuItemRandomize.Text = "Farbkanäle &randomisieren";
			toolStripMenuItemRandomize.Click += ToolStripMenuItemRandomize_Click;
			toolStripMenuItemRandomize.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemRandomize.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemMirror
			// 
			toolStripMenuItemMirror.Image = ColorSelector.Properties.Resources.ice_cube;
			toolStripMenuItemMirror.Name = "toolStripMenuItemMirror";
			toolStripMenuItemMirror.Size = new Size(210, 22);
			toolStripMenuItemMirror.Text = "Farbkanäle &spiegeln";
			toolStripMenuItemMirror.Click += ToolStripMenuItemMirror_Click;
			toolStripMenuItemMirror.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemMirror.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemSwap
			// 
			toolStripMenuItemSwap.DropDown = contextMenuStripSwap;
			toolStripMenuItemSwap.Image = ColorSelector.Properties.Resources.arrow_switch;
			toolStripMenuItemSwap.Name = "toolStripMenuItemSwap";
			toolStripMenuItemSwap.Size = new Size(210, 22);
			toolStripMenuItemSwap.Text = "Farbkanäle &vertauschen";
			toolStripMenuItemSwap.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemSwap.MouseLeave += ClearStatusbar_Leave;
			// 
			// contextMenuStripSwap
			// 
			contextMenuStripSwap.Items.AddRange(new ToolStripItem[] { toolStripMenuItemSwapRedGreen, toolStripMenuItemSwapRedBlue, toolStripMenuItemBlueGreen });
			contextMenuStripSwap.Name = "contextMenuStripSwap";
			contextMenuStripSwap.Size = new Size(107, 70);
			contextMenuStripSwap.MouseEnter += SetStatusbar_Enter;
			contextMenuStripSwap.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemSwapRedGreen
			// 
			toolStripMenuItemSwapRedGreen.Name = "toolStripMenuItemSwapRedGreen";
			toolStripMenuItemSwapRedGreen.Size = new Size(106, 22);
			toolStripMenuItemSwapRedGreen.Text = "R ⇄ G";
			toolStripMenuItemSwapRedGreen.Click += ToolStripMenuItemSwapRedGreen_Click;
			toolStripMenuItemSwapRedGreen.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemSwapRedGreen.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemSwapRedBlue
			// 
			toolStripMenuItemSwapRedBlue.Name = "toolStripMenuItemSwapRedBlue";
			toolStripMenuItemSwapRedBlue.Size = new Size(106, 22);
			toolStripMenuItemSwapRedBlue.Text = "R ⇄ B";
			toolStripMenuItemSwapRedBlue.Click += ToolStripMenuItemSwapRedBlue_Click;
			toolStripMenuItemSwapRedBlue.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemSwapRedBlue.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripMenuItemBlueGreen
			// 
			toolStripMenuItemBlueGreen.Name = "toolStripMenuItemBlueGreen";
			toolStripMenuItemBlueGreen.Size = new Size(106, 22);
			toolStripMenuItemBlueGreen.Text = "B ⇄ G";
			toolStripMenuItemBlueGreen.Click += ToolStripMenuItemBlueGreen_Click;
			toolStripMenuItemBlueGreen.MouseEnter += SetStatusbar_Enter;
			toolStripMenuItemBlueGreen.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStrip
			// 
			toolStrip.AllowItemReorder = true;
			toolStrip.Dock = DockStyle.None;
			toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButtonInvert, toolStripButtonRandomize, toolStripButtonMirror, toolStripDropDownButtonSwap, toolStripDropDownButton1, toolStripSeparator1, toolStripButtonAbout });
			toolStrip.Location = new Point(3, 24);
			toolStrip.Name = "toolStrip";
			toolStrip.RenderMode = ToolStripRenderMode.System;
			toolStrip.Size = new Size(152, 25);
			toolStrip.TabIndex = 1;
			toolStrip.TabStop = true;
			toolStrip.Text = "toolStrip";
			// 
			// toolStripButtonInvert
			// 
			toolStripButtonInvert.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonInvert.Image = ColorSelector.Properties.Resources.contrast;
			toolStripButtonInvert.ImageTransparentColor = Color.Magenta;
			toolStripButtonInvert.Name = "toolStripButtonInvert";
			toolStripButtonInvert.Size = new Size(23, 22);
			toolStripButtonInvert.Text = "Farbkänäle &invertieren";
			toolStripButtonInvert.Click += ToolStripButtonInvert_Click;
			toolStripButtonInvert.MouseEnter += SetStatusbar_Enter;
			toolStripButtonInvert.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonRandomize
			// 
			toolStripButtonRandomize.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonRandomize.Image = ColorSelector.Properties.Resources.dice;
			toolStripButtonRandomize.ImageTransparentColor = Color.Magenta;
			toolStripButtonRandomize.Name = "toolStripButtonRandomize";
			toolStripButtonRandomize.Size = new Size(23, 22);
			toolStripButtonRandomize.Text = "Farbkanäle &randomisieren";
			toolStripButtonRandomize.Click += ToolStripButtonRandomize_Click;
			toolStripButtonRandomize.MouseEnter += SetStatusbar_Enter;
			toolStripButtonRandomize.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonMirror
			// 
			toolStripButtonMirror.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonMirror.Image = ColorSelector.Properties.Resources.ice_cube;
			toolStripButtonMirror.ImageTransparentColor = Color.Magenta;
			toolStripButtonMirror.Name = "toolStripButtonMirror";
			toolStripButtonMirror.Size = new Size(23, 22);
			toolStripButtonMirror.Text = "Farbkanäle &spiegeln";
			toolStripButtonMirror.Click += ToolStripButtonMirror_Click;
			toolStripButtonMirror.MouseEnter += SetStatusbar_Enter;
			toolStripButtonMirror.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripDropDownButtonSwap
			// 
			toolStripDropDownButtonSwap.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButtonSwap.DropDown = contextMenuStripSwap;
			toolStripDropDownButtonSwap.Image = ColorSelector.Properties.Resources.arrow_switch;
			toolStripDropDownButtonSwap.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButtonSwap.Name = "toolStripDropDownButtonSwap";
			toolStripDropDownButtonSwap.Size = new Size(29, 22);
			toolStripDropDownButtonSwap.Text = "Farbkanäle &spiegeln";
			toolStripDropDownButtonSwap.MouseEnter += SetStatusbar_Enter;
			toolStripDropDownButtonSwap.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripDropDownButton1
			// 
			toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButton1.DropDown = contextMenuStripSwap;
			toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			toolStripDropDownButton1.Size = new Size(13, 22);
			toolStripDropDownButton1.Text = "Farbkanäle &vertauschen";
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 25);
			toolStripSeparator1.MouseEnter += SetStatusbar_Enter;
			toolStripSeparator1.MouseLeave += ClearStatusbar_Leave;
			// 
			// toolStripButtonAbout
			// 
			toolStripButtonAbout.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonAbout.Image = ColorSelector.Properties.Resources.information;
			toolStripButtonAbout.ImageTransparentColor = Color.Magenta;
			toolStripButtonAbout.Name = "toolStripButtonAbout";
			toolStripButtonAbout.Size = new Size(23, 22);
			toolStripButtonAbout.Text = "&Info";
			toolStripButtonAbout.Click += ToolStripButtonAbout_Click;
			toolStripButtonAbout.MouseEnter += SetStatusbar_Enter;
			toolStripButtonAbout.MouseLeave += ClearStatusbar_Leave;
			// 
			// ColorSelectorForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(480, 327);
			Controls.Add(toolStripContainer);
			MainMenuStrip = menuStrip;
			Name = "ColorSelectorForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Color Selector";
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer.BottomToolStripPanel.PerformLayout();
			toolStripContainer.ContentPanel.ResumeLayout(false);
			toolStripContainer.TopToolStripPanel.ResumeLayout(false);
			toolStripContainer.TopToolStripPanel.PerformLayout();
			toolStripContainer.ResumeLayout(false);
			toolStripContainer.PerformLayout();
			tableLayoutPanelColorCodes.ResumeLayout(false);
			tableLayoutPanelColorCodes.PerformLayout();
			panelCanvas.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBoxCanvas).EndInit();
			tableLayoutPanelRgba.ResumeLayout(false);
			tableLayoutPanelRgba.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pictureBoxBindChannelBlue).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxBindChannelGreen).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBoxBindChannelRed).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownChannelAlpha).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBarChannelAlpha).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownChannelBlue).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownChannelGreen).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBarChannelBlue).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBarChannelGreen).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownChannelRed).EndInit();
			((System.ComponentModel.ISupportInitialize)trackBarChannelRed).EndInit();
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			contextMenuStripSwap.ResumeLayout(false);
			toolStrip.ResumeLayout(false);
			toolStrip.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private StatusStrip statusStrip;
		private ToolStripContainer toolStripContainer;
		private TableLayoutPanel tableLayoutPanelRgba;
		private MenuStrip menuStrip;
		private ToolTip toolTip;
		private Label labelChannelRed;
		private Label labelChannelGreen;
		private Label labelChannelBlue;
		private Label labelAlpha;
		private TrackBar trackBarChannelRed;
		private TrackBar trackBarChannelAlpha;
		private TrackBar trackBarChannelBlue;
		private TrackBar trackBarChannelGreen;
		private NumericUpDown numericUpDownChannelAlpha;
		private NumericUpDown numericUpDownChannelBlue;
		private NumericUpDown numericUpDownChannelGreen;
		private NumericUpDown numericUpDownChannelRed;
		private Button buttonRandomizeChannelRed;
		private Button buttonRandomizeChannelGreen;
		private Button buttonRandomizeChannelBlue;
		private Button buttonRandomizeChannelAlpha;
		private Button buttonMirrorChannelRed;
		private Button buttonInvertChannelAlpha;
		private Button buttonInvertChannelBlue;
		private Button buttonInvertChannelGreen;
		private Button buttonInvertChannelRed;
		private PictureBox pictureBoxBindChannelBlue;
		private PictureBox pictureBoxBindChannelGreen;
		private PictureBox pictureBoxBindChannelRed;
		private Button buttonMirrorChannelAlpha;
		private Button buttonMirrorChannelBlue;
		private Button buttonMirrorChannelGreen;
		private ToolStrip toolStrip;
		private ToolStripButton toolStripButtonInvert;
		private ToolStripButton toolStripButtonRandomize;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton toolStripButtonAbout;
		private ToolStripDropDownButton toolStripDropDownButton1;
		private Panel panelCanvas;
		private PictureBox pictureBoxCanvas;
		private Button buttonCopyToClipboardColorCodeHex;
		private TableLayoutPanel tableLayoutPanelColorCodes;
		private Button buttonbuttonCopyToClipboardColorCodeMath;
		private Button buttonCopyToClipboardColorCodeRgb;
		private Button buttonCopyToClipboardColorCodeHtml;
		private Label labelColorCodeMath;
		private Label labelColorCodeRgb;
		private Label labelColorCodeHtml;
		private Label labelColorCodeHex;
		private TextBox textBoxColorCodeMath;
		private TextBox textBoxColorCodeRgb;
		private TextBox textBoxColorCodeHtml;
		private TextBox textBoxColorCodeHex;
		private ToolStripStatusLabel toolStripStatusLabelInformation;
		private ToolStripMenuItem toolStripMenuItemFile;
		private ToolStripMenuItem toolStripMenuItemAbout;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripMenuItem toolStripMenuItemExit;
		private ToolStripMenuItem toolStripMenuItemOperations;
		private ToolStripMenuItem toolStripMenuItemInvert;
		private ToolStripMenuItem toolStripMenuItemRandomize;
		private ToolStripMenuItem toolStripMenuItemMirror;
		private ToolStripMenuItem toolStripMenuItemSwap;
		private ToolStripMenuItem bGToolStripMenuItem;
		private ToolStripMenuItem rBToolStripMenuItem;
		private ToolStripMenuItem rGToolStripMenuItem;
		private ContextMenuStrip contextMenuStripSwap;
		private ToolStripMenuItem toolStripMenuItemSwapRedGreen;
		private ToolStripMenuItem toolStripMenuItemSwapRedBlue;
		private ToolStripMenuItem toolStripMenuItemBlueGreen;
		private ToolStripButton toolStripButtonMirror;
		private ToolStripDropDownButton toolStripDropDownButtonSwap;
	}
}
