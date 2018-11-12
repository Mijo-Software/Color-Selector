using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace ColorSelector
{
  public partial class ColorSelectorForm : Form
  {

    bool isCanalNoneBind = true;
    bool isCanalRGBind = false;
    bool isCanalRBBind = false;
    bool isCanalGBBind = false;
    bool isCanalRGBBind = false;
    //Graphics g;
    Random rnd = new Random();


    public ColorSelectorForm()
    {
      InitializeComponent();
      this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
    }

    private void ColorSelectorForm_Load(object sender, EventArgs e)
    {
      //pictureBoxColorRGB.Image = new Bitmap("C:\\Users\\micha_000\\Documents\\Visual Studio 2015\\Projects\\Color Selector\\Color Selector\\Resources\\information.png");
      numericUpDownCanalRed.Value = rnd.Next(0, 255);
      numericUpDownCanalGreen.Value = rnd.Next(0, 255);
      numericUpDownCanalBlue.Value = rnd.Next(0, 255);
      numericUpDownCanalAlpha.Value = rnd.Next(0, 255);
      checkBoxEnableAlpha.Checked = true;
      ChangePicBoxColor();
    }

    private void ChangePicBoxColor()
    {
      string strColorRedHex = string.Format("{0:X}", trackBarCanalRed.Value);
      if (trackBarCanalRed.Value < 10) strColorRedHex = "0" + strColorRedHex;

      string strColorGreenHex = string.Format("{0:X}", trackBarCanalGreen.Value);
      if (trackBarCanalGreen.Value < 10) strColorGreenHex = "0" + strColorGreenHex;

      string strColorBlueHex = string.Format("{0:X}", trackBarCanalBlue.Value);
      if (trackBarCanalBlue.Value < 10) strColorBlueHex = "0" + strColorBlueHex;

      string strColorAlphaHex = string.Format("{0:X}", trackBarCanalAlpha.Value);
      if (checkBoxEnableAlpha.Checked)
      {
        if (trackBarCanalAlpha.Value < 10) strColorAlphaHex = "0" + strColorAlphaHex;
      }

      string strColorRedMath = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.00}", 1.0 * trackBarCanalRed.Value / 255);
      string strColorGreenMath = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.00}", 1.0 * trackBarCanalGreen.Value / 255);
      string strColorBlueMath = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.00}", 1.0 * trackBarCanalBlue.Value / 255);
      string strColorAlphaMath = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.00}", 1.0 * trackBarCanalAlpha.Value / 255);

      if (checkBoxEnableAlpha.Checked) pictureBoxColorRGB.BackColor = Color.FromArgb(trackBarCanalAlpha.Value, trackBarCanalRed.Value, trackBarCanalGreen.Value, trackBarCanalBlue.Value); else pictureBoxColorRGB.BackColor = Color.FromArgb(255, trackBarCanalRed.Value, trackBarCanalGreen.Value, trackBarCanalBlue.Value);
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
        textBoxHexColorCode.Text = "$" + strColorAlphaHex + strColorBlueHex + strColorGreenHex + strColorRedHex;
        textBoxHtmlColorCode.Text = "#" + strColorRedHex + strColorGreenHex + strColorBlueHex + strColorAlphaHex;
        textBoxRgbColorCode.Text = "(" + trackBarCanalRed.Value + ", " + trackBarCanalGreen.Value + ", " + trackBarCanalBlue.Value + ", " + trackBarCanalAlpha.Value + ")";
        textBoxMathColorCode.Text = strColorRedMath + ", " + strColorGreenMath + ", " + strColorBlueMath + ", " + strColorAlphaMath;
      } else {
        textBoxHexColorCode.Text = "$" + strColorBlueHex + strColorGreenHex + strColorRedHex;
        textBoxHtmlColorCode.Text = "#" + strColorRedHex + strColorGreenHex + strColorBlueHex;
        textBoxRgbColorCode.Text = "(" + trackBarCanalRed.Value + ", " + trackBarCanalGreen.Value + ", " + trackBarCanalBlue.Value + ")";
        textBoxMathColorCode.Text = strColorRedMath + ", " + strColorGreenMath + ", " + strColorBlueMath;
      }
    }

    private void trackBarCanalRed_Scroll(object sender, EventArgs e)
    {
      int oldRedValue = (int)numericUpDownCanalRed.Value;
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

    private void trackBarCanalGreen_Scroll(object sender, EventArgs e)
    {
      int oldGreenValue = (int)numericUpDownCanalGreen.Value;
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

    private void trackBarCanalBlue_Scroll(object sender, EventArgs e)
    {
      int oldBlueValue = (int)numericUpDownCanalBlue.Value;
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

    private void trackBarCanalAlpha_Scroll(object sender, EventArgs e)
    {
      int oldAlphaValue = (int)numericUpDownCanalAlpha.Value;
      numericUpDownCanalAlpha.Value = trackBarCanalAlpha.Value;
      ChangePicBoxColor();
    }

    private void buttonInformation_Click(object sender, EventArgs e)
    {
      AboutBoxForm formAboutBox = new AboutBoxForm();
      formAboutBox.ShowDialog();
    }

    private void buttonHexColorCodeCopyToClipboard_Click(object sender, EventArgs e)
    {
      pictureBoxHexColorCodeCopyToClipboard.Visible = true;
      textBoxHexColorCode.SelectAll();
      textBoxHexColorCode.Copy();
      timer.Start();
    }

    private void buttonHtmlColorCodeCopyToClipboard_Click(object sender, EventArgs e)
    {
      pictureBoxHtmlColorCodeCopyToClipboard.Visible = true;
      textBoxHtmlColorCode.SelectAll();
      textBoxHtmlColorCode.Copy();
    }

    private void buttonRgbColorCodeCopyToClipboard_Click(object sender, EventArgs e)
    {
      pictureBoxRgbColorCodeCopyToClipboard.Visible = true;
      textBoxRgbColorCode.SelectAll();
      textBoxRgbColorCode.Copy();
    }

    private void buttonMathColorCode_Click(object sender, EventArgs e)
    {
      pictureBoxMathColorCodeCopyToClipboard.Visible = true;
      textBoxMathColorCode.SelectAll();
      textBoxMathColorCode.Copy();
    }

    private void numericUpDownCanalRed_ValueChanged(object sender, EventArgs e)
    {
      int oldRedValue = trackBarCanalRed.Value;
      trackBarCanalRed.Value = (int)numericUpDownCanalRed.Value;
      if (isCanalRGBind)
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
      ChangePicBoxColor();
    }

    private void numericUpDownCanalGreen_ValueChanged(object sender, EventArgs e)
    {
      int oldGreenValue = trackBarCanalGreen.Value;
      trackBarCanalGreen.Value = (int)numericUpDownCanalGreen.Value;
      if (isCanalRGBind)
      {
        int n = trackBarCanalGreen.Value + (trackBarCanalRed.Value - oldGreenValue);
        if (n > 0 && n < 255)
        {
          numericUpDownCanalGreen.Value = trackBarCanalGreen.Value + (trackBarCanalRed.Value - oldGreenValue);
          numericUpDownCanalRed.Value = trackBarCanalRed.Value;
        }
      }

      ChangePicBoxColor();
    }

    private void numericUpDownCanalBlue_ValueChanged(object sender, EventArgs e)
    {
      int oldBlueValue = trackBarCanalBlue.Value;
      trackBarCanalBlue.Value = (int)numericUpDownCanalBlue.Value;

      ChangePicBoxColor();
    }

    private void numericUpDownCanalAlpha_ValueChanged(object sender, EventArgs e)
    {
      int oldAlphaValue = trackBarCanalAlpha.Value;
      trackBarCanalAlpha.Value = (int)numericUpDownCanalAlpha.Value;

      ChangePicBoxColor();
    }

    private void buttonInvertCanal_Click(object sender, EventArgs e)
    {
      invertCanalRed();
      invertCanalGreen();
      invertCanalBlue();
      if (checkBoxEnableAlpha.Checked) invertCanalAlpha();
    }

    private void buttonSwapCanal_Click(object sender, EventArgs e)
    {
      contextMenuStripSwapCanal.Show(buttonSwapCanal, 0, buttonSwapCanal.Size.Height);
    }

    private void ToolStripMenuItemSwapRG_Click(object sender, EventArgs e)
    {
      int swap;
      swap = (int)numericUpDownCanalRed.Value;
      numericUpDownCanalRed.Value = numericUpDownCanalGreen.Value;
      numericUpDownCanalGreen.Value = swap;
    }

    private void ToolStripMenuItemSwapRB_Click(object sender, EventArgs e)
    {
      int swap;
      swap = (int)numericUpDownCanalRed.Value;
      numericUpDownCanalRed.Value = numericUpDownCanalBlue.Value;
      numericUpDownCanalBlue.Value = swap;
    }

    private void ToolStripMenuItemSwapGB_Click(object sender, EventArgs e)
    {
      int swap;
      swap = (int)numericUpDownCanalGreen.Value;
      numericUpDownCanalGreen.Value = numericUpDownCanalBlue.Value;
      numericUpDownCanalBlue.Value = swap;
    }

    private void ToolStripMenuItemInvertCanalRGB_Click(object sender, EventArgs e)
    {
      ToolStripMenuItemInvertCanalR_Click(sender, e);
      ToolStripMenuItemInvertCanalG_Click(sender, e);
      ToolStripMenuItemInvertCanalB_Click(sender, e);
    }

    private void ToolStripMenuItemInvertCanalRG_Click(object sender, EventArgs e)
    {
      ToolStripMenuItemInvertCanalR_Click(sender, e);
      ToolStripMenuItemInvertCanalG_Click(sender, e);
    }

    private void ToolStripMenuItemInvertCanalRB_Click(object sender, EventArgs e)
    {
      ToolStripMenuItemInvertCanalR_Click(sender, e);
      ToolStripMenuItemInvertCanalB_Click(sender, e);
    }

    private void ToolStripMenuItemInvertCanalGB_Click(object sender, EventArgs e)
    {
      ToolStripMenuItemInvertCanalG_Click(sender, e);
      ToolStripMenuItemInvertCanalB_Click(sender, e);
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

    private void checkBoxWebsafeColor_CheckedChanged(object sender, EventArgs e)
    {
      WebsafeColorForm formWebsafeColor = new WebsafeColorForm();
      if (checkBoxWebsafeColor.Checked)
      {
          formWebsafeColor.Show();
      }
      else formWebsafeColor.Close();
    }

    private void buttonRandomizeCanalRed_Click(object sender, EventArgs e)
    {
      numericUpDownCanalRed.Value = rnd.Next(0, 255);
      if (isCanalRGBind) { numericUpDownCanalGreen.Value = rnd.Next(0, 255); };
      if (isCanalRBBind) { numericUpDownCanalBlue.Value = rnd.Next(0, 255); };
      if (isCanalRGBBind) { numericUpDownCanalRed.Value = rnd.Next(0, 255); numericUpDownCanalBlue.Value = rnd.Next(0, 255); };
    }

    private void buttonRandomizeCanalGreen_Click(object sender, EventArgs e)
    {
      numericUpDownCanalGreen.Value = rnd.Next(0, 255);
      if (isCanalRGBind) { numericUpDownCanalRed.Value = rnd.Next(0, 255); };
      if (isCanalGBBind) { numericUpDownCanalBlue.Value = rnd.Next(0, 255); };
      if (isCanalRGBBind) { numericUpDownCanalRed.Value = rnd.Next(0, 255); numericUpDownCanalBlue.Value = rnd.Next(0, 255); };
    }

    private void buttonRandomizeCanalBlue_Click(object sender, EventArgs e)
    {
      numericUpDownCanalBlue.Value = rnd.Next(0, 255);
      if (isCanalRBBind) { numericUpDownCanalRed.Value = rnd.Next(0, 255); };
      if (isCanalGBBind) { numericUpDownCanalGreen.Value = rnd.Next(0, 255); };
      if (isCanalRGBBind) { numericUpDownCanalRed.Value = rnd.Next(0, 255); numericUpDownCanalGreen.Value = rnd.Next(0, 255); };
    }

    private void buttonRandomizeCanalAlpha_Click(object sender, EventArgs e)
    {
      numericUpDownCanalAlpha.Value = rnd.Next(0, 255);
    }

    private void checkBindLinks()
    {
      if (isCanalNoneBind) { pictureBoxBindCanalR.Visible = false; pictureBoxBindCanalG.Visible = false; pictureBoxBindCanalB.Visible = false; };
      if (isCanalRGBind)   { pictureBoxBindCanalR.Visible = true;  pictureBoxBindCanalG.Visible = true;  pictureBoxBindCanalB.Visible = false; };
      if (isCanalRBBind)   { pictureBoxBindCanalR.Visible = true;  pictureBoxBindCanalG.Visible = false; pictureBoxBindCanalB.Visible = true; };
      if (isCanalGBBind)   { pictureBoxBindCanalR.Visible = false; pictureBoxBindCanalG.Visible = true;  pictureBoxBindCanalB.Visible = true; };
      if (isCanalRGBBind)  { pictureBoxBindCanalR.Visible = true;  pictureBoxBindCanalG.Visible = true;  pictureBoxBindCanalB.Visible = true; };
    }

    private void buttonBindCanal_Click(object sender, EventArgs e)
    {
       contextMenuStripBindCanal.Show(buttonRandomizeCanal, 0, buttonRandomizeCanal.Size.Height);
    }

    private void toolStripMenuItemBindCanalNone_Click(object sender, EventArgs e)
    {
      isCanalNoneBind = true;
      isCanalRGBind = false;
      isCanalRBBind = false;
      isCanalGBBind = false;
      isCanalRGBBind = false;
      checkBindLinks();
    }

    private void toolStripMenuItemBindCanalRG_Click(object sender, EventArgs e)
    {
      isCanalNoneBind = false;
      isCanalRGBind = true;
      isCanalRBBind = false;
      isCanalGBBind = false;
      isCanalRGBBind = false;
      checkBindLinks();
    }

    private void toolStripMenuItemBindCanalRB_Click(object sender, EventArgs e)
    {
      isCanalNoneBind = false;
      isCanalRGBind = false;
      isCanalRBBind = true;
      isCanalGBBind = false;
      isCanalRGBBind = false;
      checkBindLinks();
    }

    private void toolStripMenuItemGB_Click(object sender, EventArgs e)
    {
      isCanalNoneBind = false;
      isCanalRGBind = false;
      isCanalRBBind = false;
      isCanalGBBind = true;
      isCanalRGBBind = false;
      checkBindLinks();
    }

    private void toolStripMenuItemBindCanalRGB_Click(object sender, EventArgs e)
    {
      isCanalNoneBind = false;
      isCanalRGBind = false;
      isCanalRBBind = false;
      isCanalGBBind = false;
      isCanalRGBBind = true;
      checkBindLinks();
    }

    private void timerTick(object sender, EventArgs e)
    {
      pictureBoxHexColorCodeCopyToClipboard.Visible = false;
      pictureBoxHtmlColorCodeCopyToClipboard.Visible = false;
      pictureBoxRgbColorCodeCopyToClipboard.Visible = false;
      pictureBoxMathColorCodeCopyToClipboard.Visible = false;
    }

    private void buttonRandomizeCanal_Click(object sender, EventArgs e)
    {
      numericUpDownCanalRed.Value = rnd.Next(0, 255);
      numericUpDownCanalGreen.Value = rnd.Next(0, 255);
      numericUpDownCanalBlue.Value = rnd.Next(0, 255);
      if (checkBoxEnableAlpha.Checked) { numericUpDownCanalAlpha.Value = rnd.Next(0, 255); }
    }

    private void checkBoxEnableAlpha_CheckedChanged(object sender, EventArgs e)
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
      else {
        labelAlpha.Enabled = false;
        trackBarCanalAlpha.Enabled = false;
        numericUpDownCanalAlpha.Enabled = false;
        buttonRandomizeCanalAlpha.Enabled = false;
        buttonInvertCanalAlpha.Enabled = false;
        buttonMirrorCanalAlpha.Enabled = false;
      }
      ChangePicBoxColor();
    }

    private void invertRed()
    {
      byte value = (byte)trackBarCanalRed.Value;
      value += 128;
      numericUpDownCanalRed.Value = value;
    }

    private void invertGreen()
    {
      byte value = (byte)trackBarCanalGreen.Value;
      value += 128;
      numericUpDownCanalGreen.Value = value;
    }

    private void invertBlue()
    {
      byte value = (byte)trackBarCanalBlue.Value;
      value += 128;
      numericUpDownCanalBlue.Value = value;
    }

    private void invertAlpha()
    {
      byte value = (byte)trackBarCanalAlpha.Value;
      value += 128;
      numericUpDownCanalAlpha.Value = value;
    }

    private void invertCanalRed()
    {
      invertRed();
      if (isCanalRGBind) { invertGreen(); };
      if (isCanalRBBind) { invertBlue(); };
      if (isCanalRGBBind) { invertGreen(); invertBlue(); };
    }

    private void invertCanalGreen()
    {
      invertGreen();
      if (isCanalRGBind) { invertRed(); };
      if (isCanalGBBind) { invertBlue(); };
      if (isCanalRGBBind) { invertRed(); invertBlue(); };
    }

    private void invertCanalBlue()
    {
      invertBlue();
      if (isCanalRBBind) { invertRed(); };
      if (isCanalGBBind) { invertGreen(); };
      if (isCanalRGBBind) { invertRed(); invertGreen(); };
    }

    private void invertCanalAlpha()
    {
      invertAlpha();
    }

    private void buttonInvertCanalRed_Click(object sender, EventArgs e)
    {
      invertCanalRed();
    }

    private void buttonInvertCanalGreen_Click(object sender, EventArgs e)
    {
      invertCanalGreen();
    }

    private void buttonInvertCanalBlue_Click(object sender, EventArgs e)
    {
      invertCanalBlue();
    }

    private void buttonInvertCanalAlpha_Click(object sender, EventArgs e)
    {
      invertCanalAlpha();
    }

    private void toolStripMenuItemRandomizeCanalRGB_Click(object sender, EventArgs e)
    {
      numericUpDownCanalRed.Value = rnd.Next(0, 255);
      numericUpDownCanalGreen.Value = rnd.Next(0, 255);
      numericUpDownCanalBlue.Value = rnd.Next(0, 255);

    }

    private void toolStripMenuItemRandomizeCanalRG_Click(object sender, EventArgs e)
    {
      numericUpDownCanalRed.Value = rnd.Next(0, 255);
      numericUpDownCanalGreen.Value = rnd.Next(0, 255);
    }

    private void toolStripMenuItemRandomizeCanalRB_Click(object sender, EventArgs e)
    {
      numericUpDownCanalRed.Value = rnd.Next(0, 255);
      numericUpDownCanalBlue.Value = rnd.Next(0, 255);
    }

    private void toolStripMenuItemRandomizeCanalGB_Click(object sender, EventArgs e)
    {
      numericUpDownCanalGreen.Value = rnd.Next(0, 255);
      numericUpDownCanalBlue.Value = rnd.Next(0, 255);
    }

    private void toolStripMenuItemRandomizeCanalR_Click(object sender, EventArgs e)
    {
      numericUpDownCanalRed.Value = rnd.Next(0, 255);
    }

    private void toolStripMenuItemRandomizeCanalG_Click(object sender, EventArgs e)
    {
      numericUpDownCanalGreen.Value = rnd.Next(0, 255);
    }

    private void toolStripMenuItemRandomizeCanalB_Click(object sender, EventArgs e)
    {
      numericUpDownCanalBlue.Value = rnd.Next(0, 255);
    }

    private void pictureBoxColorRGB_DoubleClick(object sender, EventArgs e)
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
        if (checkBoxEnableAlpha.Checked) numericUpDownCanalAlpha.Value = colorDialog.Color.A;
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

    private void mirrorCanalRed()
    {
      if (numericUpDownCanalRed.Value <= 127) numericUpDownCanalRed.Value = 128 - numericUpDownCanalRed.Value + 127; else numericUpDownCanalRed.Value = 255 - numericUpDownCanalRed.Value;
    }

    private void mirrorCanalGreen()
    {
      if (numericUpDownCanalGreen.Value <= 127) numericUpDownCanalGreen.Value = 128 - numericUpDownCanalGreen.Value + 127; else numericUpDownCanalGreen.Value = 255 - numericUpDownCanalGreen.Value;
    }

    private void mirrorCanalBlue()
    {
      if (numericUpDownCanalBlue.Value <= 127) numericUpDownCanalBlue.Value = 128 - numericUpDownCanalBlue.Value + 127; else numericUpDownCanalBlue.Value = 255 - numericUpDownCanalBlue.Value;
    }

    private void mirrorCanalAlpha()
    {
      if (checkBoxEnableAlpha.Checked) if (numericUpDownCanalAlpha.Value <= 127) numericUpDownCanalAlpha.Value = 128 - numericUpDownCanalAlpha.Value + 127; else numericUpDownCanalAlpha.Value = 255 - numericUpDownCanalAlpha.Value;
    }

    private void buttonMirrorCanalRed_Click(object sender, EventArgs e)
    {
      mirrorCanalRed();
    }

    private void buttonMirrorCanalGreen_Click(object sender, EventArgs e)
    {
      mirrorCanalGreen();
    }

    private void buttonMirrorCanalBlue_Click(object sender, EventArgs e)
    {
      mirrorCanalBlue();
    }

    private void buttonMirrorCanalAlpha_Click(object sender, EventArgs e)
    {
      if (checkBoxEnableAlpha.Checked) mirrorCanalAlpha();
    }

    private void buttonMirrorCanal_Click(object sender, EventArgs e)
    {
      mirrorCanalRed();
      mirrorCanalGreen();
      mirrorCanalBlue();
      if (checkBoxEnableAlpha.Checked) mirrorCanalAlpha();
    }

    private void toolStripMenuItemMirrorRGB_Click(object sender, EventArgs e)
    {
      mirrorCanalRed();
      mirrorCanalGreen();
      mirrorCanalBlue();
    }

    private void toolStripMenuItemMirrorRG_Click(object sender, EventArgs e)
    {
      mirrorCanalRed();
      mirrorCanalGreen();
    }

    private void toolStripMenuItemMirrorRB_Click(object sender, EventArgs e)
    {
      mirrorCanalRed();
      mirrorCanalBlue();
    }

    private void toolStripMenuItemMirrorGB_Click(object sender, EventArgs e)
    {
      mirrorCanalGreen();
      mirrorCanalBlue();
    }

    private void toolStripMenuItemMirrorR_Click(object sender, EventArgs e)
    {
      mirrorCanalRed();
    }

    private void toolStripMenuItemMirrorG_Click(object sender, EventArgs e)
    {
      mirrorCanalGreen();
    }

    private void toolStripMenuItemMirrorB_Click(object sender, EventArgs e)
    {
      mirrorCanalBlue();
    }
  }
}
