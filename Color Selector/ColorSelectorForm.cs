using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace ColorSelector
{
	public partial class ColorSelectorForm : Form
	{
		private bool isCanalNoneBind = true;
		private bool isCanalRGBind;
		private bool isCanalRBBind;
		private bool isCanalGBBind;
		private bool isCanalRGBBind;

		//Graphics g;
		private readonly Random rnd = new Random();

		public ColorSelectorForm()
		{
			InitializeComponent();
			SetStyle(flag: ControlStyles.SupportsTransparentBackColor, value: true);
		}

		private void ColorSelectorForm_Load(object sender, EventArgs e)
		{
			//pictureBoxColorRGB.Image = new Bitmap("C:\\Users\\micha_000\\Documents\\Visual Studio 2015\\Projects\\Color Selector\\Color Selector\\Resources\\information.png");
			numericUpDownCanalRed.Value = rnd.Next(minValue: 0, maxValue: 255);
			numericUpDownCanalGreen.Value = rnd.Next(minValue: 0, maxValue: 255);
			numericUpDownCanalBlue.Value = rnd.Next(minValue: 0, maxValue: 255);
			numericUpDownCanalAlpha.Value = rnd.Next(minValue: 0, maxValue: 255);
			checkBoxEnableAlpha.Checked = true;
			ChangePicBoxColor();
		}

		private void ChangePicBoxColor()
		{
			string strColorRedHex = $"{trackBarCanalRed.Value:X}";
			if (trackBarCanalRed.Value < 10)
			{
				strColorRedHex = "0" + strColorRedHex;
			}
			string strColorGreenHex = $"{trackBarCanalGreen.Value:X}";
			if (trackBarCanalGreen.Value < 10)
			{
				strColorGreenHex = "0" + strColorGreenHex;
			}
			string strColorBlueHex = $"{trackBarCanalBlue.Value:X}";
			if (trackBarCanalBlue.Value < 10)
			{
				strColorBlueHex = $"0{strColorBlueHex}";
			}
			string strColorAlphaHex = $"{trackBarCanalAlpha.Value:X}";
			if (checkBoxEnableAlpha.Checked && trackBarCanalAlpha.Value < 10)
			{
				strColorAlphaHex = $"0{strColorAlphaHex}";
			}
			string strColorRedMath = string.Format(provider: NumberFormatInfo.InvariantInfo, format: "{0:0.00}", args: 1.0 * trackBarCanalRed.Value / 255);
			string strColorGreenMath = string.Format(provider: NumberFormatInfo.InvariantInfo, format: "{0:0.00}", args: 1.0 * trackBarCanalGreen.Value / 255);
			string strColorBlueMath = string.Format(provider: NumberFormatInfo.InvariantInfo, format: "{0:0.00}", args: 1.0 * trackBarCanalBlue.Value / 255);
			string strColorAlphaMath = string.Format(provider: NumberFormatInfo.InvariantInfo, format: "{0:0.00}", args: 1.0 * trackBarCanalAlpha.Value / 255);
			if (checkBoxEnableAlpha.Checked)
			{
				pictureBoxColorRGB.BackColor = Color.FromArgb(alpha: trackBarCanalAlpha.Value, red: trackBarCanalRed.Value, green: trackBarCanalGreen.Value, blue: trackBarCanalBlue.Value);
			}
			else
			{
				pictureBoxColorRGB.BackColor = Color.FromArgb(alpha: 255, red: trackBarCanalRed.Value, green: trackBarCanalGreen.Value, blue: trackBarCanalBlue.Value);
			}
			//ColorSelectorForm_Paint(this, null);
			/*g = CreateGraphics();
      g.CompositingQuality = CompositingQuality.GammaCorrected;
      Pen pen = new Pen(Color.FromArgb(trackBarCanalAlpha.Value, trackBarCanalRed.Value, trackBarCanalGreen.Value, trackBarCanalBlue.Value), 15);
      Pen semiTransPen = new Pen(Color.FromArgb(128, 0, 0, 255), 15);
      SolidBrush opaqueBrush = new SolidBrush(pictureBoxColorRGB.BackColor);
      g.DrawLine(pen, 0, 20, 100, 20);
      g.DrawLine(semiTransPen, 0, 40, 100, 40);
      g.DrawLine(pen, pictureBoxColorRGB.Left, pictureBoxColorRGB.Top, pictureBoxColorRGB.Right, pictureBoxColorRGB.Bottom);
      g.FillRectangle(opaqueBrush, pictureBoxColorRGB.Bounds);*/

			if (checkBoxEnableAlpha.Checked)
			{
				textBoxHexColorCode.Text = $"${strColorAlphaHex}{strColorBlueHex}{strColorGreenHex}{strColorRedHex}";
				textBoxHtmlColorCode.Text = $"#{strColorRedHex}{strColorGreenHex}{strColorBlueHex}{strColorAlphaHex}";
				textBoxRgbColorCode.Text = $"({trackBarCanalRed.Value}, {trackBarCanalGreen.Value}, {trackBarCanalBlue.Value}, {trackBarCanalAlpha.Value})";
				textBoxMathColorCode.Text = $"{strColorRedMath}, {strColorGreenMath}, {strColorBlueMath}, {strColorAlphaMath}";
			}
			else
			{
				textBoxHexColorCode.Text = $"${strColorBlueHex}{strColorGreenHex}{strColorRedHex}";
				textBoxHtmlColorCode.Text = $"#{strColorRedHex}{strColorGreenHex}{strColorBlueHex}";
				textBoxRgbColorCode.Text = $"({trackBarCanalRed.Value}, {trackBarCanalGreen.Value}, {trackBarCanalBlue.Value})";
				textBoxMathColorCode.Text = $"{strColorRedMath}, {strColorGreenMath}, {strColorBlueMath}";
			}
		}

		private void TrackBarCanalRed_Scroll(object sender, EventArgs e)
		{
			//int oldRedValue = (int)numericUpDownCanalRed.Value;
			numericUpDownCanalRed.Value = trackBarCanalRed.Value;
			/*if (isCanalRGBind)
      {
        int n = trackBarCanalGreen.Value + (trackBarCanalRed.Value - oldRedValue);
        if (n > 0 && n < 255)
        {
          numericUpDownCanalGreen.Value = trackBarCanalGreen.Value + (trackBarCanalRed.Value - oldRedValue);
          numericUpDownCanalRed.Value = trackBarCanalRed.Value;
        }
      }
      if (isCanalRBBind)
      {
        int n = trackBarCanalBlue.Value + (trackBarCanalRed.Value - oldRedValue);
        if (n > 0 && n < 255)
        {
          numericUpDownCanalBlue.Value = trackBarCanalBlue.Value + (trackBarCanalRed.Value - oldRedValue);
          numericUpDownCanalRed.Value = trackBarCanalRed.Value;
          }
      }
      if (isCanalRGBBind)
      {
        int n = trackBarCanalGreen.Value + (trackBarCanalRed.Value - oldRedValue);
        int n2 = trackBarCanalBlue.Value + (trackBarCanalRed.Value - oldRedValue);
        if (n > 0 && n < 255 && n2 > 0 && n2 < 255)
        {
          numericUpDownCanalGreen.Value = trackBarCanalGreen.Value + (trackBarCanalRed.Value - oldRedValue);
          numericUpDownCanalBlue.Value = trackBarCanalBlue.Value + (trackBarCanalRed.Value - oldRedValue);
          numericUpDownCanalRed.Value = trackBarCanalRed.Value;
        }
      }
      */
			ChangePicBoxColor();
		}

		private void TrackBarCanalGreen_Scroll(object sender, EventArgs e)
		{
			//int oldGreenValue = (int)numericUpDownCanalGreen.Value;
			numericUpDownCanalGreen.Value = trackBarCanalGreen.Value;
			/*if (isCanalRGBind)
      {
        int n = trackBarCanalRed.Value + (trackBarCanalGreen.Value - oldGreenValue);
        if (n > 0 && n < 255)
        {
          numericUpDownCanalRed.Value = trackBarCanalRed.Value + (trackBarCanalGreen.Value - oldGreenValue);
          numericUpDownCanalGreen.Value = trackBarCanalGreen.Value;
        }
      }
      if (isCanalGBBind)
      {
        int n = trackBarCanalBlue.Value + (trackBarCanalGreen.Value - oldGreenValue);
        if (n > 0 && n < 255)
        {
          numericUpDownCanalBlue.Value = trackBarCanalBlue.Value + (trackBarCanalGreen.Value - oldGreenValue);
          numericUpDownCanalGreen.Value = trackBarCanalGreen.Value;
        }
      }
      if (isCanalRGBBind)
      {
        int n = trackBarCanalRed.Value + (trackBarCanalGreen.Value - oldGreenValue);
        int n2 = trackBarCanalBlue.Value + (trackBarCanalGreen.Value - oldGreenValue);
        if (n > 0 && n < 255 && n2 > 0 && n2 < 255)
        {
          numericUpDownCanalRed.Value = trackBarCanalRed.Value + (trackBarCanalGreen.Value - oldGreenValue);
          numericUpDownCanalBlue.Value = trackBarCanalBlue.Value + (trackBarCanalGreen.Value - oldGreenValue);
          numericUpDownCanalGreen.Value = trackBarCanalGreen.Value;
        }
      }
      */
			ChangePicBoxColor();
		}

		private void TrackBarCanalBlue_Scroll(object sender, EventArgs e)
		{
			//int oldBlueValue = (int)numericUpDownCanalBlue.Value;
			numericUpDownCanalBlue.Value = trackBarCanalBlue.Value;
			/*if (isCanalGBBind)
      {
        int n = trackBarCanalGreen.Value + (trackBarCanalBlue.Value - oldBlueValue);
        if (n > 0 && n < 255)
        {
          numericUpDownCanalGreen.Value = trackBarCanalGreen.Value + (trackBarCanalBlue.Value - oldBlueValue);
          numericUpDownCanalBlue.Value = trackBarCanalBlue.Value;
        }
      }
      if (isCanalRBBind)
      {
        int n = trackBarCanalRed.Value + (trackBarCanalBlue.Value - oldBlueValue);
        if (n > 0 && n < 255)
        {
          numericUpDownCanalRed.Value = trackBarCanalRed.Value + (trackBarCanalBlue.Value - oldBlueValue);
          numericUpDownCanalBlue.Value = trackBarCanalBlue.Value;
        }
      }
      if (isCanalRGBBind)
      {
        int n = trackBarCanalGreen.Value + (trackBarCanalBlue.Value - oldBlueValue);
        int n2 = trackBarCanalRed.Value + (trackBarCanalBlue.Value - oldBlueValue);
        if (n > 0 && n < 255 && n2 > 0 && n2 < 255)
        {
          numericUpDownCanalGreen.Value = trackBarCanalGreen.Value + (trackBarCanalBlue.Value - oldBlueValue);
          numericUpDownCanalRed.Value = trackBarCanalRed.Value + (trackBarCanalBlue.Value - oldBlueValue);
          numericUpDownCanalBlue.Value = trackBarCanalBlue.Value;
         }
      }
      */
			ChangePicBoxColor();
		}

		private void TrackBarCanalAlpha_Scroll(object sender, EventArgs e)
		{
			//int oldAlphaValue = (int)numericUpDownCanalAlpha.Value;
			numericUpDownCanalAlpha.Value = trackBarCanalAlpha.Value;
			ChangePicBoxColor();
		}

		private void ButtonInformation_Click(object sender, EventArgs e)
		{
			using AboutBoxForm formAboutBox = new AboutBoxForm();
			formAboutBox.ShowDialog();
		}

		private void ButtonHexColorCodeCopyToClipboard_Click(object sender, EventArgs e)
		{
			pictureBoxHexColorCodeCopyToClipboard.Visible = true;
			textBoxHexColorCode.SelectAll();
			textBoxHexColorCode.Copy();
			timer.Start();
		}

		private void ButtonHtmlColorCodeCopyToClipboard_Click(object sender, EventArgs e)
		{
			pictureBoxHtmlColorCodeCopyToClipboard.Visible = true;
			textBoxHtmlColorCode.SelectAll();
			textBoxHtmlColorCode.Copy();
		}

		private void ButtonRgbColorCodeCopyToClipboard_Click(object sender, EventArgs e)
		{
			pictureBoxRgbColorCodeCopyToClipboard.Visible = true;
			textBoxRgbColorCode.SelectAll();
			textBoxRgbColorCode.Copy();
		}

		private void ButtonMathColorCode_Click(object sender, EventArgs e)
		{
			pictureBoxMathColorCodeCopyToClipboard.Visible = true;
			textBoxMathColorCode.SelectAll();
			textBoxMathColorCode.Copy();
		}

		private void NumericUpDownCanalRed_ValueChanged(object sender, EventArgs e)
		{
			int oldRedValue = trackBarCanalRed.Value;
			trackBarCanalRed.Value = (int)numericUpDownCanalRed.Value;
			if (isCanalRGBind)
			{
				int n = trackBarCanalGreen.Value + trackBarCanalRed.Value - oldRedValue;
				if (n > 0 && n < 255)
				{
					numericUpDownCanalGreen.Value = trackBarCanalGreen.Value + trackBarCanalRed.Value - oldRedValue;
					numericUpDownCanalRed.Value = trackBarCanalRed.Value;
				}
			}
			if (isCanalRBBind)
			{
				int n = trackBarCanalBlue.Value + trackBarCanalRed.Value - oldRedValue;
				if (n > 0 && n < 255)
				{
					numericUpDownCanalBlue.Value = trackBarCanalBlue.Value + trackBarCanalRed.Value - oldRedValue;
					numericUpDownCanalRed.Value = trackBarCanalRed.Value;
				}
			}
			if (isCanalRGBBind)
			{
				int n = trackBarCanalGreen.Value + trackBarCanalRed.Value - oldRedValue;
				int n2 = trackBarCanalBlue.Value + trackBarCanalRed.Value - oldRedValue;
				if (n > 0 && n < 255 && n2 > 0 && n2 < 255)
				{
					numericUpDownCanalGreen.Value = trackBarCanalGreen.Value + trackBarCanalRed.Value - oldRedValue;
					numericUpDownCanalBlue.Value = trackBarCanalBlue.Value + trackBarCanalRed.Value - oldRedValue;
					numericUpDownCanalRed.Value = trackBarCanalRed.Value;
				}
			}
			ChangePicBoxColor();
		}

		private void NumericUpDownCanalGreen_ValueChanged(object sender, EventArgs e)
		{
			int oldGreenValue = trackBarCanalGreen.Value;
			trackBarCanalGreen.Value = (int)numericUpDownCanalGreen.Value;
			if (isCanalRGBind)
			{
				int n = trackBarCanalGreen.Value + trackBarCanalRed.Value - oldGreenValue;
				if (n > 0 && n < 255)
				{
					numericUpDownCanalGreen.Value = trackBarCanalGreen.Value + trackBarCanalRed.Value - oldGreenValue;
					numericUpDownCanalRed.Value = trackBarCanalRed.Value;
				}
			}
			ChangePicBoxColor();
		}

		private void NumericUpDownCanalBlue_ValueChanged(object sender, EventArgs e)
		{
			//int oldBlueValue = trackBarCanalBlue.Value;
			trackBarCanalBlue.Value = (int)numericUpDownCanalBlue.Value;
			ChangePicBoxColor();
		}

		private void NumericUpDownCanalAlpha_ValueChanged(object sender, EventArgs e)
		{
			//int oldAlphaValue = trackBarCanalAlpha.Value;
			trackBarCanalAlpha.Value = (int)numericUpDownCanalAlpha.Value;
			ChangePicBoxColor();
		}

		private void ButtonInvertCanal_Click(object sender, EventArgs e)
		{
			InvertCanalRed();
			InvertCanalGreen();
			InvertCanalBlue();
			if (checkBoxEnableAlpha.Checked)
			{
				InvertCanalAlpha();
			}
		}

		private void ButtonSwapCanal_Click(object sender, EventArgs e) => contextMenuStripSwapCanal.Show(control: buttonSwapCanal, x: 0, y: buttonSwapCanal.Size.Height);

		private void ToolStripMenuItemSwapRG_Click(object sender, EventArgs e)
		{
			int swap = (int)numericUpDownCanalRed.Value;
			numericUpDownCanalRed.Value = numericUpDownCanalGreen.Value;
			numericUpDownCanalGreen.Value = swap;
		}

		private void ToolStripMenuItemSwapRB_Click(object sender, EventArgs e)
		{
			int swap = (int)numericUpDownCanalRed.Value;
			numericUpDownCanalRed.Value = numericUpDownCanalBlue.Value;
			numericUpDownCanalBlue.Value = swap;
		}

		private void ToolStripMenuItemSwapGB_Click(object sender, EventArgs e)
		{
			int swap = (int)numericUpDownCanalGreen.Value;
			numericUpDownCanalGreen.Value = numericUpDownCanalBlue.Value;
			numericUpDownCanalBlue.Value = swap;
		}

		private void ToolStripMenuItemInvertCanalRGB_Click(object sender, EventArgs e)
		{
			ToolStripMenuItemInvertCanalR_Click(sender: null, e: EventArgs.Empty);
			ToolStripMenuItemInvertCanalG_Click(sender: null, e: EventArgs.Empty);
			ToolStripMenuItemInvertCanalB_Click(sender: null, e: EventArgs.Empty);
		}

		private void ToolStripMenuItemInvertCanalRG_Click(object sender, EventArgs e)
		{
			ToolStripMenuItemInvertCanalR_Click(sender: null, e: EventArgs.Empty);
			ToolStripMenuItemInvertCanalG_Click(sender: null, e: EventArgs.Empty);
		}

		private void ToolStripMenuItemInvertCanalRB_Click(object sender, EventArgs e)
		{
			ToolStripMenuItemInvertCanalR_Click(sender: null, e: EventArgs.Empty);
			ToolStripMenuItemInvertCanalB_Click(sender: null, e: EventArgs.Empty);
		}

		private void ToolStripMenuItemInvertCanalGB_Click(object sender, EventArgs e)
		{
			ToolStripMenuItemInvertCanalG_Click(sender: null, e: EventArgs.Empty);
			ToolStripMenuItemInvertCanalB_Click(sender: null, e: EventArgs.Empty);
		}

		private void ToolStripMenuItemInvertCanalR_Click(object sender, EventArgs e)
		{
			byte color = (byte)trackBarCanalRed.Value;
			color += 128;
			numericUpDownCanalRed.Value = color;
		}

		private void ToolStripMenuItemInvertCanalG_Click(object sender, EventArgs e)
		{
			byte color = (byte)trackBarCanalGreen.Value;
			color += 128;
			numericUpDownCanalGreen.Value = color;
		}

		private void ToolStripMenuItemInvertCanalB_Click(object sender, EventArgs e)
		{
			byte color = (byte)trackBarCanalBlue.Value;
			color += 128;
			numericUpDownCanalBlue.Value = color;
		}

		private void CheckBoxWebsafeColor_CheckedChanged(object sender, EventArgs e)
		{
			using WebsafeColorForm websafeColorForm = new WebsafeColorForm();
			if (checkBoxWebsafeColor.Checked)
			{
				websafeColorForm.Show();
			}
			else
			{
				websafeColorForm.Close();
			}
		}

		private void ButtonRandomizeCanalRed_Click(object sender, EventArgs e)
		{
			numericUpDownCanalRed.Value = rnd.Next(0, 255);
			if (isCanalRGBind) { numericUpDownCanalGreen.Value = rnd.Next(minValue: 0, maxValue: 255); }
			if (isCanalRBBind) { numericUpDownCanalBlue.Value = rnd.Next(minValue: 0, maxValue: 255); }
			if (isCanalRGBBind) { numericUpDownCanalRed.Value = rnd.Next(minValue: 0, maxValue: 255); numericUpDownCanalBlue.Value = rnd.Next(minValue: 0, maxValue: 255); }
		}

		private void ButtonRandomizeCanalGreen_Click(object sender, EventArgs e)
		{
			numericUpDownCanalGreen.Value = rnd.Next(minValue: 0, maxValue: 255);
			if (isCanalRGBind) { numericUpDownCanalRed.Value = rnd.Next(minValue: 0, maxValue: 255); }
			if (isCanalGBBind) { numericUpDownCanalBlue.Value = rnd.Next(minValue: 0, maxValue: 255); }
			if (isCanalRGBBind) { numericUpDownCanalRed.Value = rnd.Next(minValue: 0, maxValue: 255); numericUpDownCanalBlue.Value = rnd.Next(minValue: 0, maxValue: 255); }
		}

		private void ButtonRandomizeCanalBlue_Click(object sender, EventArgs e)
		{
			numericUpDownCanalBlue.Value = rnd.Next(minValue: 0, maxValue: 255);
			if (isCanalRBBind) { numericUpDownCanalRed.Value = rnd.Next(minValue: 0, maxValue: 255); }
			if (isCanalGBBind) { numericUpDownCanalGreen.Value = rnd.Next(minValue: 0, maxValue: 255); }
			if (isCanalRGBBind) { numericUpDownCanalRed.Value = rnd.Next(minValue: 0, maxValue: 255); numericUpDownCanalGreen.Value = rnd.Next(minValue: 0, maxValue: 255); }
		}

		private void ButtonRandomizeCanalAlpha_Click(object sender, EventArgs e) => numericUpDownCanalAlpha.Value = rnd.Next(minValue: 0, maxValue: 255);

		private void CheckBindLinks()
		{
			if (isCanalNoneBind) { pictureBoxBindCanalR.Visible = false; pictureBoxBindCanalG.Visible = false; pictureBoxBindCanalB.Visible = false; }
			if (isCanalRGBind) { pictureBoxBindCanalR.Visible = true; pictureBoxBindCanalG.Visible = true; pictureBoxBindCanalB.Visible = false; }
			if (isCanalRBBind) { pictureBoxBindCanalR.Visible = true; pictureBoxBindCanalG.Visible = false; pictureBoxBindCanalB.Visible = true; }
			if (isCanalGBBind) { pictureBoxBindCanalR.Visible = false; pictureBoxBindCanalG.Visible = true; pictureBoxBindCanalB.Visible = true; }
			if (isCanalRGBBind) { pictureBoxBindCanalR.Visible = true; pictureBoxBindCanalG.Visible = true; pictureBoxBindCanalB.Visible = true; }
		}

		private void ButtonBindCanal_Click(object sender, EventArgs e) => contextMenuStripBindCanal.Show(control: buttonRandomizeCanal, x: 0, y: buttonRandomizeCanal.Size.Height);

		private void ToolStripMenuItemBindCanalNone_Click(object sender, EventArgs e)
		{
			isCanalNoneBind = true;
			isCanalRGBind = false;
			isCanalRBBind = false;
			isCanalGBBind = false;
			isCanalRGBBind = false;
			CheckBindLinks();
		}

		private void ToolStripMenuItemBindCanalRG_Click(object sender, EventArgs e)
		{
			isCanalNoneBind = false;
			isCanalRGBind = true;
			isCanalRBBind = false;
			isCanalGBBind = false;
			isCanalRGBBind = false;
			CheckBindLinks();
		}

		private void ToolStripMenuItemBindCanalRB_Click(object sender, EventArgs e)
		{
			isCanalNoneBind = false;
			isCanalRGBind = false;
			isCanalRBBind = true;
			isCanalGBBind = false;
			isCanalRGBBind = false;
			CheckBindLinks();
		}

		private void ToolStripMenuItemGB_Click(object sender, EventArgs e)
		{
			isCanalNoneBind = false;
			isCanalRGBind = false;
			isCanalRBBind = false;
			isCanalGBBind = true;
			isCanalRGBBind = false;
			CheckBindLinks();
		}

		private void ToolStripMenuItemBindCanalRGB_Click(object sender, EventArgs e)
		{
			isCanalNoneBind = false;
			isCanalRGBind = false;
			isCanalRBBind = false;
			isCanalGBBind = false;
			isCanalRGBBind = true;
			CheckBindLinks();
		}

		private void TimerTick(object sender, EventArgs e)
		{
			pictureBoxHexColorCodeCopyToClipboard.Visible = false;
			pictureBoxHtmlColorCodeCopyToClipboard.Visible = false;
			pictureBoxRgbColorCodeCopyToClipboard.Visible = false;
			pictureBoxMathColorCodeCopyToClipboard.Visible = false;
		}

		private void ButtonRandomizeCanal_Click(object sender, EventArgs e)
		{
			numericUpDownCanalRed.Value = rnd.Next(minValue: 0, maxValue: 255);
			numericUpDownCanalGreen.Value = rnd.Next(minValue: 0, maxValue: 255);
			numericUpDownCanalBlue.Value = rnd.Next(minValue: 0, maxValue: 255);
			if (checkBoxEnableAlpha.Checked) { numericUpDownCanalAlpha.Value = rnd.Next(minValue: 0, maxValue: 255); }
		}

		private void CheckBoxEnableAlpha_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBoxEnableAlpha.Checked)
			{
				labelAlpha.Enabled = true;
				trackBarCanalAlpha.Enabled = true;
				numericUpDownCanalAlpha.Enabled = true;
				buttonRandomizeCanalAlpha.Enabled = true;
				buttonInvertCanalAlpha.Enabled = true;
				buttonMirrorCanalAlpha.Enabled = true;
			}
			else
			{
				labelAlpha.Enabled = false;
				trackBarCanalAlpha.Enabled = false;
				numericUpDownCanalAlpha.Enabled = false;
				buttonRandomizeCanalAlpha.Enabled = false;
				buttonInvertCanalAlpha.Enabled = false;
				buttonMirrorCanalAlpha.Enabled = false;
			}
			ChangePicBoxColor();
		}

		private void InvertRed()
		{
			byte value = (byte)trackBarCanalRed.Value;
			value += 128;
			numericUpDownCanalRed.Value = value;
		}

		private void InvertGreen()
		{
			byte value = (byte)trackBarCanalGreen.Value;
			value += 128;
			numericUpDownCanalGreen.Value = value;
		}

		private void InvertBlue()
		{
			byte value = (byte)trackBarCanalBlue.Value;
			value += 128;
			numericUpDownCanalBlue.Value = value;
		}

		private void InvertAlpha()
		{
			byte value = (byte)trackBarCanalAlpha.Value;
			value += 128;
			numericUpDownCanalAlpha.Value = value;
		}

		private void InvertCanalRed()
		{
			InvertRed();
			if (isCanalRGBind) { InvertGreen(); }
			if (isCanalRBBind) { InvertBlue(); }
			if (isCanalRGBBind) { InvertGreen(); InvertBlue(); }
		}

		private void InvertCanalGreen()
		{
			InvertGreen();
			if (isCanalRGBind) { InvertRed(); }
			if (isCanalGBBind) { InvertBlue(); }
			if (isCanalRGBBind) { InvertRed(); InvertBlue(); }
		}

		private void InvertCanalBlue()
		{
			InvertBlue();
			if (isCanalRBBind) { InvertRed(); }
			if (isCanalGBBind) { InvertGreen(); }
			if (isCanalRGBBind) { InvertRed(); InvertGreen(); }
		}

		private void InvertCanalAlpha() => InvertAlpha();

		private void ButtonInvertCanalRed_Click(object sender, EventArgs e) => InvertCanalRed();

		private void ButtonInvertCanalGreen_Click(object sender, EventArgs e) => InvertCanalGreen();

		private void ButtonInvertCanalBlue_Click(object sender, EventArgs e) => InvertCanalBlue();

		private void ButtonInvertCanalAlpha_Click(object sender, EventArgs e) => InvertCanalAlpha();

		private void ToolStripMenuItemRandomizeCanalRGB_Click(object sender, EventArgs e)
		{
			numericUpDownCanalRed.Value = rnd.Next(minValue: 0, maxValue: 255);
			numericUpDownCanalGreen.Value = rnd.Next(minValue: 0, maxValue: 255);
			numericUpDownCanalBlue.Value = rnd.Next(minValue: 0, maxValue: 255);
		}

		private void ToolStripMenuItemRandomizeCanalRG_Click(object sender, EventArgs e)
		{
			numericUpDownCanalRed.Value = rnd.Next(minValue: 0, maxValue: 255);
			numericUpDownCanalGreen.Value = rnd.Next(minValue: 0, maxValue: 255);
		}

		private void ToolStripMenuItemRandomizeCanalRB_Click(object sender, EventArgs e)
		{
			numericUpDownCanalRed.Value = rnd.Next(minValue: 0, maxValue: 255);
			numericUpDownCanalBlue.Value = rnd.Next(minValue: 0, maxValue: 255);
		}

		private void ToolStripMenuItemRandomizeCanalGB_Click(object sender, EventArgs e)
		{
			numericUpDownCanalGreen.Value = rnd.Next(minValue: 0, maxValue: 255);
			numericUpDownCanalBlue.Value = rnd.Next(minValue: 0, maxValue: 255);
		}

		private void ToolStripMenuItemRandomizeCanalR_Click(object sender, EventArgs e) => numericUpDownCanalRed.Value = rnd.Next(minValue: 0, maxValue: 255);

		private void ToolStripMenuItemRandomizeCanalG_Click(object sender, EventArgs e) => numericUpDownCanalGreen.Value = rnd.Next(minValue: 0, maxValue: 255);

		private void ToolStripMenuItemRandomizeCanalB_Click(object sender, EventArgs e) => numericUpDownCanalBlue.Value = rnd.Next(minValue: 0, maxValue: 255);

		private void PictureBoxColorRGB_DoubleClick(object sender, EventArgs e)
		{
			colorDialog.AllowFullOpen = true;
			colorDialog.AnyColor = false;
			colorDialog.FullOpen = false;
			colorDialog.ShowHelp = false;
			colorDialog.SolidColorOnly = false;
			colorDialog.Color = pictureBoxColorRGB.BackColor;
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				numericUpDownCanalRed.Value = colorDialog.Color.R;
				numericUpDownCanalGreen.Value = colorDialog.Color.G;
				numericUpDownCanalBlue.Value = colorDialog.Color.B;
				if (checkBoxEnableAlpha.Checked)
				{
					numericUpDownCanalAlpha.Value = colorDialog.Color.A;
				}
			}
		}

		private void ColorSelectorForm_Paint(object sender, PaintEventArgs e)
		{
			/*Graphics g = e.Graphics;
      Pen opaquePen = new Pen(Color.FromArgb(255, 0, 0, 255), 15);
      Pen pen = new Pen(Color.FromArgb(trackBarCanalAlpha.Value, trackBarCanalRed.Value, trackBarCanalGreen.Value, trackBarCanalBlue.Value), 15);
      Pen semiTransPen = new Pen(Color.FromArgb(128, 0, 0, 255), 15);
      SolidBrush opaqueBrush = new SolidBrush(pictureBoxColorRGB.BackColor);
      g.DrawLine(opaquePen, 0, 20, 100, 20);
      g.DrawLine(semiTransPen, 0, 40, 100, 40);
      g.FillRectangle(opaqueBrush, pictureBoxColorRGB.Bounds);*/
		}

		private void MirrorCanalRed() => numericUpDownCanalRed.Value = numericUpDownCanalRed.Value <= 127 ? 128 - numericUpDownCanalRed.Value + 127 : 255 - numericUpDownCanalRed.Value;

		private void MirrorCanalGreen() => numericUpDownCanalGreen.Value = numericUpDownCanalGreen.Value <= 127 ? 128 - numericUpDownCanalGreen.Value + 127 : 255 - numericUpDownCanalGreen.Value;

		private void MirrorCanalBlue() => numericUpDownCanalBlue.Value = numericUpDownCanalBlue.Value <= 127 ? 128 - numericUpDownCanalBlue.Value + 127 : 255 - numericUpDownCanalBlue.Value;

		private void MirrorCanalAlpha()
		{
			if (checkBoxEnableAlpha.Checked)
			{
				numericUpDownCanalAlpha.Value = numericUpDownCanalAlpha.Value <= 127 ? 128 - numericUpDownCanalAlpha.Value + 127 : 255 - numericUpDownCanalAlpha.Value;
			}
		}

		private void ButtonMirrorCanalRed_Click(object sender, EventArgs e) => MirrorCanalRed();

		private void ButtonMirrorCanalGreen_Click(object sender, EventArgs e) => MirrorCanalGreen();

		private void ButtonMirrorCanalBlue_Click(object sender, EventArgs e) => MirrorCanalBlue();

		private void ButtonMirrorCanalAlpha_Click(object sender, EventArgs e)
		{
			if (checkBoxEnableAlpha.Checked)
			{
				MirrorCanalAlpha();
			}
		}

		private void ButtonMirrorCanal_Click(object sender, EventArgs e)
		{
			MirrorCanalRed();
			MirrorCanalGreen();
			MirrorCanalBlue();
			if (checkBoxEnableAlpha.Checked)
			{
				MirrorCanalAlpha();
			}
		}

		private void ToolStripMenuItemMirrorRGB_Click(object sender, EventArgs e)
		{
			MirrorCanalRed();
			MirrorCanalGreen();
			MirrorCanalBlue();
		}

		private void ToolStripMenuItemMirrorRG_Click(object sender, EventArgs e)
		{
			MirrorCanalRed();
			MirrorCanalGreen();
		}

		private void ToolStripMenuItemMirrorRB_Click(object sender, EventArgs e)
		{
			MirrorCanalRed();
			MirrorCanalBlue();
		}

		private void ToolStripMenuItemMirrorGB_Click(object sender, EventArgs e)
		{
			MirrorCanalGreen();
			MirrorCanalBlue();
		}

		private void ToolStripMenuItemMirrorR_Click(object sender, EventArgs e) => MirrorCanalRed();

		private void ToolStripMenuItemMirrorG_Click(object sender, EventArgs e) => MirrorCanalGreen();

		private void ToolStripMenuItemMirrorB_Click(object sender, EventArgs e) => MirrorCanalBlue();
	}
}
