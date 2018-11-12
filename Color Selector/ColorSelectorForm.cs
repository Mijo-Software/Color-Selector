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

    bool isColorNoneBind = true;
    bool isColorRGBind = false;
    bool isColorRBBind = false;
    bool isColorGBBind = false;
    bool isColorRGBBind = false;
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
      numericUpDownColorRed.Value = rnd.Next(0, 255);
      numericUpDownColorGreen.Value = rnd.Next(0, 255);
      numericUpDownColorBlue.Value = rnd.Next(0, 255);
      numericUpDownColorAlpha.Value = rnd.Next(0, 255);
      checkBoxEnableAlpha.Checked = true;
      ChangePicBoxColor();
    }

    private void ChangePicBoxColor()
    {
      string strColorRedHex = string.Format("{0:X}", trackBarColorRed.Value);
      if (trackBarColorRed.Value < 10) strColorRedHex = "0" + strColorRedHex;

      string strColorGreenHex = string.Format("{0:X}", trackBarColorGreen.Value);
      if (trackBarColorGreen.Value < 10) strColorGreenHex = "0" + strColorGreenHex;

      string strColorBlueHex = string.Format("{0:X}", trackBarColorBlue.Value);
      if (trackBarColorBlue.Value < 10) strColorBlueHex = "0" + strColorBlueHex;

      string strColorAlphaHex = string.Format("{0:X}", trackBarColorAlpha.Value);
      if (checkBoxEnableAlpha.Checked)
      {
        if (trackBarColorAlpha.Value < 10) strColorAlphaHex = "0" + strColorAlphaHex;
      }

      string strColorRedMath = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.00}", 1.0 * trackBarColorRed.Value / 255);
      string strColorGreenMath = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.00}", 1.0 * trackBarColorGreen.Value / 255);
      string strColorBlueMath = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.00}", 1.0 * trackBarColorBlue.Value / 255);
      string strColorAlphaMath = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.00}", 1.0 * trackBarColorAlpha.Value / 255);

      if (checkBoxEnableAlpha.Checked) pictureBoxColorRGB.BackColor = Color.FromArgb(trackBarColorAlpha.Value, trackBarColorRed.Value, trackBarColorGreen.Value, trackBarColorBlue.Value); else pictureBoxColorRGB.BackColor = Color.FromArgb(255, trackBarColorRed.Value, trackBarColorGreen.Value, trackBarColorBlue.Value);
      //ColorSelectorForm_Paint(this, null);
      /*g = CreateGraphics();
      g.CompositingQuality = CompositingQuality.GammaCorrected;
      Pen pen = new Pen(Color.FromArgb(trackBarColorAlpha.Value, trackBarColorRed.Value, trackBarColorGreen.Value, trackBarColorBlue.Value), 15);
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
        textBoxRgbColorCode.Text = "(" + trackBarColorRed.Value + ", " + trackBarColorGreen.Value + ", " + trackBarColorBlue.Value + ", " + trackBarColorAlpha.Value + ")";
        textBoxMathColorCode.Text = strColorRedMath + ", " + strColorGreenMath + ", " + strColorBlueMath + ", " + strColorAlphaMath;
      } else {
        textBoxHexColorCode.Text = "$" + strColorBlueHex + strColorGreenHex + strColorRedHex;
        textBoxHtmlColorCode.Text = "#" + strColorRedHex + strColorGreenHex + strColorBlueHex;
        textBoxRgbColorCode.Text = "(" + trackBarColorRed.Value + ", " + trackBarColorGreen.Value + ", " + trackBarColorBlue.Value + ")";
        textBoxMathColorCode.Text = strColorRedMath + ", " + strColorGreenMath + ", " + strColorBlueMath;
      }
    }

    private void trackBarColorRed_Scroll(object sender, EventArgs e)
    {
      int oldRedValue = (int)numericUpDownColorRed.Value;
      numericUpDownColorRed.Value = trackBarColorRed.Value;
      /*if (isColorRGBind)
      {
        int n = trackBarColorGreen.Value + (trackBarColorRed.Value - oldRedValue);
        if (n > 0 && n < 255)
        {
          numericUpDownColorGreen.Value = trackBarColorGreen.Value + (trackBarColorRed.Value - oldRedValue);
          numericUpDownColorRed.Value = trackBarColorRed.Value;
        }
      }
      if (isColorRBBind)
      {
        int n = trackBarColorBlue.Value + (trackBarColorRed.Value - oldRedValue);
        if (n > 0 && n < 255)
        {
          numericUpDownColorBlue.Value = trackBarColorBlue.Value + (trackBarColorRed.Value - oldRedValue);
          numericUpDownColorRed.Value = trackBarColorRed.Value;
          }
      }
      if (isColorRGBBind)
      {
        int n = trackBarColorGreen.Value + (trackBarColorRed.Value - oldRedValue);
        int n2 = trackBarColorBlue.Value + (trackBarColorRed.Value - oldRedValue);
        if (n > 0 && n < 255 && n2 > 0 && n2 < 255)
        {
          numericUpDownColorGreen.Value = trackBarColorGreen.Value + (trackBarColorRed.Value - oldRedValue);
          numericUpDownColorBlue.Value = trackBarColorBlue.Value + (trackBarColorRed.Value - oldRedValue);
          numericUpDownColorRed.Value = trackBarColorRed.Value;
        }
      }
      */
      ChangePicBoxColor();
    }

    private void trackBarColorGreen_Scroll(object sender, EventArgs e)
    {
      int oldGreenValue = (int)numericUpDownColorGreen.Value;
      numericUpDownColorGreen.Value = trackBarColorGreen.Value;
      /*if (isColorRGBind)
      {
        int n = trackBarColorRed.Value + (trackBarColorGreen.Value - oldGreenValue);
        if (n > 0 && n < 255)
        {
          numericUpDownColorRed.Value = trackBarColorRed.Value + (trackBarColorGreen.Value - oldGreenValue);
          numericUpDownColorGreen.Value = trackBarColorGreen.Value;
        }
      }
      if (isColorGBBind)
      {
        int n = trackBarColorBlue.Value + (trackBarColorGreen.Value - oldGreenValue);
        if (n > 0 && n < 255)
        {
          numericUpDownColorBlue.Value = trackBarColorBlue.Value + (trackBarColorGreen.Value - oldGreenValue);
          numericUpDownColorGreen.Value = trackBarColorGreen.Value;
        }
      }
      if (isColorRGBBind)
      {
        int n = trackBarColorRed.Value + (trackBarColorGreen.Value - oldGreenValue);
        int n2 = trackBarColorBlue.Value + (trackBarColorGreen.Value - oldGreenValue);
        if (n > 0 && n < 255 && n2 > 0 && n2 < 255)
        {
          numericUpDownColorRed.Value = trackBarColorRed.Value + (trackBarColorGreen.Value - oldGreenValue);
          numericUpDownColorBlue.Value = trackBarColorBlue.Value + (trackBarColorGreen.Value - oldGreenValue);
          numericUpDownColorGreen.Value = trackBarColorGreen.Value;
        }
      }
      */
      ChangePicBoxColor();
    }

    private void trackBarColorBlue_Scroll(object sender, EventArgs e)
    {
      int oldBlueValue = (int)numericUpDownColorBlue.Value;
      numericUpDownColorBlue.Value = trackBarColorBlue.Value;
      /*if (isColorGBBind)
      {
        int n = trackBarColorGreen.Value + (trackBarColorBlue.Value - oldBlueValue);
        if (n > 0 && n < 255)
        {
          numericUpDownColorGreen.Value = trackBarColorGreen.Value + (trackBarColorBlue.Value - oldBlueValue);
          numericUpDownColorBlue.Value = trackBarColorBlue.Value;
        }
      }
      if (isColorRBBind)
      {
        int n = trackBarColorRed.Value + (trackBarColorBlue.Value - oldBlueValue);
        if (n > 0 && n < 255)
        {
          numericUpDownColorRed.Value = trackBarColorRed.Value + (trackBarColorBlue.Value - oldBlueValue);
          numericUpDownColorBlue.Value = trackBarColorBlue.Value;
        }
      }
      if (isColorRGBBind)
      {
        int n = trackBarColorGreen.Value + (trackBarColorBlue.Value - oldBlueValue);
        int n2 = trackBarColorRed.Value + (trackBarColorBlue.Value - oldBlueValue);
        if (n > 0 && n < 255 && n2 > 0 && n2 < 255)
        {
          numericUpDownColorGreen.Value = trackBarColorGreen.Value + (trackBarColorBlue.Value - oldBlueValue);
          numericUpDownColorRed.Value = trackBarColorRed.Value + (trackBarColorBlue.Value - oldBlueValue);
          numericUpDownColorBlue.Value = trackBarColorBlue.Value;
         }
      }
      */
      ChangePicBoxColor();
    }

    private void trackBarColorAlpha_Scroll(object sender, EventArgs e)
    {
      int oldAlphaValue = (int)numericUpDownColorAlpha.Value;
      numericUpDownColorAlpha.Value = trackBarColorAlpha.Value;
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

    private void numericUpDownColorRed_ValueChanged(object sender, EventArgs e)
    {
      int oldRedValue = trackBarColorRed.Value;
      trackBarColorRed.Value = (int)numericUpDownColorRed.Value;
      if (isColorRGBind)
      {
        int n = trackBarColorGreen.Value + (trackBarColorRed.Value - oldRedValue);
        if (n > 0 && n < 255)
        {
          numericUpDownColorGreen.Value = trackBarColorGreen.Value + (trackBarColorRed.Value - oldRedValue);
          numericUpDownColorRed.Value = trackBarColorRed.Value;
        }
      }
      if (isColorRBBind)
      {
        int n = trackBarColorBlue.Value + (trackBarColorRed.Value - oldRedValue);
        if (n > 0 && n < 255)
        {
          numericUpDownColorBlue.Value = trackBarColorBlue.Value + (trackBarColorRed.Value - oldRedValue);
          numericUpDownColorRed.Value = trackBarColorRed.Value;
        }
      }
      if (isColorRGBBind)
      {
        int n = trackBarColorGreen.Value + (trackBarColorRed.Value - oldRedValue);
        int n2 = trackBarColorBlue.Value + (trackBarColorRed.Value - oldRedValue);
        if (n > 0 && n < 255 && n2 > 0 && n2 < 255)
        {
          numericUpDownColorGreen.Value = trackBarColorGreen.Value + (trackBarColorRed.Value - oldRedValue);
          numericUpDownColorBlue.Value = trackBarColorBlue.Value + (trackBarColorRed.Value - oldRedValue);
          numericUpDownColorRed.Value = trackBarColorRed.Value;
        }
      }
      ChangePicBoxColor();
    }

    private void numericUpDownColorGreen_ValueChanged(object sender, EventArgs e)
    {
      int oldGreenValue = trackBarColorGreen.Value;
      trackBarColorGreen.Value = (int)numericUpDownColorGreen.Value;
      if (isColorRGBind)
      {
        int n = trackBarColorGreen.Value + (trackBarColorRed.Value - oldGreenValue);
        if (n > 0 && n < 255)
        {
          numericUpDownColorGreen.Value = trackBarColorGreen.Value + (trackBarColorRed.Value - oldGreenValue);
          numericUpDownColorRed.Value = trackBarColorRed.Value;
        }
      }

      ChangePicBoxColor();
    }

    private void numericUpDownColorBlue_ValueChanged(object sender, EventArgs e)
    {
      int oldBlueValue = trackBarColorBlue.Value;
      trackBarColorBlue.Value = (int)numericUpDownColorBlue.Value;

      ChangePicBoxColor();
    }

    private void numericUpDownColorAlpha_ValueChanged(object sender, EventArgs e)
    {
      int oldAlphaValue = trackBarColorAlpha.Value;
      trackBarColorAlpha.Value = (int)numericUpDownColorAlpha.Value;

      ChangePicBoxColor();
    }

    private void buttonInvertColor_Click(object sender, EventArgs e)
    {
      invertColorRed();
      invertColorGreen();
      invertColorBlue();
      if (checkBoxEnableAlpha.Checked) invertColorAlpha();
    }

    private void buttonSwapColor_Click(object sender, EventArgs e)
    {
      contextMenuStripSwapColor.Show(buttonSwapColor, 0, buttonSwapColor.Size.Height);
    }

    private void ToolStripMenuItemSwapRG_Click(object sender, EventArgs e)
    {
      int swap;

      swap = (int)numericUpDownColorRed.Value;
      numericUpDownColorRed.Value = numericUpDownColorGreen.Value;
      numericUpDownColorGreen.Value = swap;
    }

    private void ToolStripMenuItemSwapRB_Click(object sender, EventArgs e)
    {
      int swap;

      swap = (int)numericUpDownColorRed.Value;
      numericUpDownColorRed.Value = numericUpDownColorBlue.Value;
      numericUpDownColorBlue.Value = swap;
    }

    private void ToolStripMenuItemSwapGB_Click(object sender, EventArgs e)
    {
      int swap;

      swap = (int)numericUpDownColorGreen.Value;
      numericUpDownColorGreen.Value = numericUpDownColorBlue.Value;
      numericUpDownColorBlue.Value = swap;
    }

    private void ToolStripMenuItemInvertColorRGB_Click(object sender, EventArgs e)
    {
      ToolStripMenuItemInvertColorR_Click(sender, e);
      ToolStripMenuItemInvertColorG_Click(sender, e);
      ToolStripMenuItemInvertColorB_Click(sender, e);
    }

    private void ToolStripMenuItemInvertColorRG_Click(object sender, EventArgs e)
    {
      ToolStripMenuItemInvertColorR_Click(sender, e);
      ToolStripMenuItemInvertColorG_Click(sender, e);
    }

    private void ToolStripMenuItemInvertColorRB_Click(object sender, EventArgs e)
    {
      ToolStripMenuItemInvertColorR_Click(sender, e);
      ToolStripMenuItemInvertColorB_Click(sender, e);
    }

    private void ToolStripMenuItemInvertColorGB_Click(object sender, EventArgs e)
    {
      ToolStripMenuItemInvertColorG_Click(sender, e);
      ToolStripMenuItemInvertColorB_Click(sender, e);
    }

    private void ToolStripMenuItemInvertColorR_Click(object sender, EventArgs e)
    {
      byte color = (byte)trackBarColorRed.Value;
      color += 128;
      numericUpDownColorRed.Value = color;
    }

    private void ToolStripMenuItemInvertColorG_Click(object sender, EventArgs e)
    {
      byte color = (byte)trackBarColorGreen.Value;
      color += 128;
      numericUpDownColorGreen.Value = color;
    }

    private void ToolStripMenuItemInvertColorB_Click(object sender, EventArgs e)
    {
      byte color = (byte)trackBarColorBlue.Value;
      color += 128;
      numericUpDownColorBlue.Value = color;
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

    private void buttonRandomizeColorRed_Click(object sender, EventArgs e)
    {
      numericUpDownColorRed.Value = rnd.Next(0, 255);
      if (isColorRGBind) { numericUpDownColorGreen.Value = rnd.Next(0, 255); };
      if (isColorRBBind) { numericUpDownColorBlue.Value = rnd.Next(0, 255); };
      if (isColorRGBBind) { numericUpDownColorRed.Value = rnd.Next(0, 255); numericUpDownColorBlue.Value = rnd.Next(0, 255); };
    }

    private void buttonRandomizeColorGreen_Click(object sender, EventArgs e)
    {
      numericUpDownColorGreen.Value = rnd.Next(0, 255);
      if (isColorRGBind) { numericUpDownColorRed.Value = rnd.Next(0, 255); };
      if (isColorGBBind) { numericUpDownColorBlue.Value = rnd.Next(0, 255); };
      if (isColorRGBBind) { numericUpDownColorRed.Value = rnd.Next(0, 255); numericUpDownColorBlue.Value = rnd.Next(0, 255); };
    }

    private void buttonRandomizeColorBlue_Click(object sender, EventArgs e)
    {
      numericUpDownColorBlue.Value = rnd.Next(0, 255);
      if (isColorRBBind) { numericUpDownColorRed.Value = rnd.Next(0, 255); };
      if (isColorGBBind) { numericUpDownColorGreen.Value = rnd.Next(0, 255); };
      if (isColorRGBBind) { numericUpDownColorRed.Value = rnd.Next(0, 255); numericUpDownColorGreen.Value = rnd.Next(0, 255); };
    }

    private void buttonRandomizeColorAlpha_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorAlpha.Value = i;
    }

    private void checkBindLinks()
    {
      if (isColorNoneBind) { pictureBoxBindColorR.Visible = false; pictureBoxBindColorG.Visible = false; pictureBoxBindColorB.Visible = false; };
      if (isColorRGBind)   { pictureBoxBindColorR.Visible = true;  pictureBoxBindColorG.Visible = true;  pictureBoxBindColorB.Visible = false; };
      if (isColorRBBind)   { pictureBoxBindColorR.Visible = true;  pictureBoxBindColorG.Visible = false; pictureBoxBindColorB.Visible = true; };
      if (isColorGBBind)   { pictureBoxBindColorR.Visible = false; pictureBoxBindColorG.Visible = true;  pictureBoxBindColorB.Visible = true; };
      if (isColorRGBBind)  { pictureBoxBindColorR.Visible = true;  pictureBoxBindColorG.Visible = true;  pictureBoxBindColorB.Visible = true; };
    }

    private void buttonBindColor_Click(object sender, EventArgs e)
    {
       contextMenuStripBindColor.Show(buttonRandomizeColor, 0, buttonRandomizeColor.Size.Height);
    }

    private void toolStripMenuItemBindColorNone_Click(object sender, EventArgs e)
    {
      isColorNoneBind = true;
      isColorRGBind = false;
      isColorRBBind = false;
      isColorGBBind = false;
      isColorRGBBind = false;
      checkBindLinks();
    }

    private void toolStripMenuItemBindColorRG_Click(object sender, EventArgs e)
    {
      isColorNoneBind = false;
      isColorRGBind = true;
      isColorRBBind = false;
      isColorGBBind = false;
      isColorRGBBind = false;
      checkBindLinks();
    }

    private void toolStripMenuItemBindColorRB_Click(object sender, EventArgs e)
    {
      isColorNoneBind = false;
      isColorRGBind = false;
      isColorRBBind = true;
      isColorGBBind = false;
      isColorRGBBind = false;
      checkBindLinks();
    }

    private void toolStripMenuItemGB_Click(object sender, EventArgs e)
    {
      isColorNoneBind = false;
      isColorRGBind = false;
      isColorRBBind = false;
      isColorGBBind = true;
      isColorRGBBind = false;
      checkBindLinks();
    }

    private void toolStripMenuItemBindColorRGB_Click(object sender, EventArgs e)
    {
      isColorNoneBind = false;
      isColorRGBind = false;
      isColorRBBind = false;
      isColorGBBind = false;
      isColorRGBBind = true;
      checkBindLinks();
    }

    private void timer_Tick(object sender, EventArgs e)
    {
      pictureBoxHexColorCodeCopyToClipboard.Visible = false;
      pictureBoxHtmlColorCodeCopyToClipboard.Visible = false;
      pictureBoxRgbColorCodeCopyToClipboard.Visible = false;
      pictureBoxMathColorCodeCopyToClipboard.Visible = false;
    }

    private void buttonRandomizeColor_Click(object sender, EventArgs e)
    {
      numericUpDownColorRed.Value = rnd.Next(0, 255);
      numericUpDownColorGreen.Value = rnd.Next(0, 255);
      numericUpDownColorBlue.Value = rnd.Next(0, 255);
      if (checkBoxEnableAlpha.Checked) { numericUpDownColorAlpha.Value = rnd.Next(0, 255); }
    }

    private void checkBoxEnableAlpha_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBoxEnableAlpha.Checked)
      {
        labelAlpha.Enabled = true;
        trackBarColorAlpha.Enabled = true;
        numericUpDownColorAlpha.Enabled = true;
        buttonRandomizeColorAlpha.Enabled = true;
        buttonInvertColorAlpha.Enabled = true;
        buttonMirrorColorAlpha.Enabled = true;
      }
      else {
        labelAlpha.Enabled = false;
        trackBarColorAlpha.Enabled = false;
        numericUpDownColorAlpha.Enabled = false;
        buttonRandomizeColorAlpha.Enabled = false;
        buttonInvertColorAlpha.Enabled = false;
        buttonMirrorColorAlpha.Enabled = false;
      }
      ChangePicBoxColor();
    }

    private void invertRed()
    {
      byte color = (byte)trackBarColorRed.Value;
      color += 128;
      numericUpDownColorRed.Value = color;
    }

    private void invertGreen()
    {
      byte color = (byte)trackBarColorGreen.Value;
      color += 128;
      numericUpDownColorGreen.Value = color;
    }

    private void invertBlue()
    {
      byte color = (byte)trackBarColorBlue.Value;
      color += 128;
      numericUpDownColorBlue.Value = color;
    }

    private void invertAlpha()
    {
      byte color = (byte)trackBarColorAlpha.Value;
      color += 128;
      numericUpDownColorAlpha.Value = color;
    }

    private void invertColorRed()
    {
      invertRed();
      if (isColorRGBind) { invertGreen(); };
      if (isColorRBBind) { invertBlue(); };
      if (isColorRGBBind) { invertGreen(); invertBlue(); };
    }

    private void invertColorGreen()
    {
      invertGreen();
      if (isColorRGBind) { invertRed(); };
      if (isColorGBBind) { invertBlue(); };
      if (isColorRGBBind) { invertRed(); invertBlue(); };
    }

    private void invertColorBlue()
    {
      invertBlue();
      if (isColorRBBind) { invertRed(); };
      if (isColorGBBind) { invertGreen(); };
      if (isColorRGBBind) { invertRed(); invertGreen(); };
    }

    private void invertColorAlpha()
    {
      invertAlpha();
    }

    private void buttonInvertColorRed_Click(object sender, EventArgs e)
    {
      invertColorRed();
    }

    private void buttonInvertColorGreen_Click(object sender, EventArgs e)
    {
      invertColorGreen();
    }

    private void buttonInvertColorBlue_Click(object sender, EventArgs e)
    {
      invertColorBlue();
    }

    private void buttonInvertColorAlpha_Click(object sender, EventArgs e)
    {
      invertColorAlpha();
    }

    private void toolStripMenuItemRandomizeColorRGB_Click(object sender, EventArgs e)
    {
      int i = rnd.Next(0, 255);
      numericUpDownColorRed.Value = i;
      i = rnd.Next(0, 255);
      numericUpDownColorGreen.Value = i;
      i = rnd.Next(0, 255);
      numericUpDownColorBlue.Value = i;
    }

    private void toolStripMenuItemRandomizeColorRG_Click(object sender, EventArgs e)
    {
      numericUpDownColorRed.Value = rnd.Next(0, 255);
      numericUpDownColorGreen.Value = rnd.Next(0, 255);
    }

    private void toolStripMenuItemRandomizeColorRB_Click(object sender, EventArgs e)
    {
      numericUpDownColorRed.Value = rnd.Next(0, 255);
      numericUpDownColorBlue.Value = rnd.Next(0, 255);
    }

    private void toolStripMenuItemRandomizeColorGB_Click(object sender, EventArgs e)
    {
      numericUpDownColorGreen.Value = rnd.Next(0, 255);
      numericUpDownColorBlue.Value = rnd.Next(0, 255);
    }

    private void toolStripMenuItemRandomizeColorR_Click(object sender, EventArgs e)
    {
      numericUpDownColorRed.Value = rnd.Next(0, 255);
    }

    private void toolStripMenuItemRandomizeColorG_Click(object sender, EventArgs e)
    {
      numericUpDownColorGreen.Value = rnd.Next(0, 255);
    }

    private void toolStripMenuItemRandomizeColorB_Click(object sender, EventArgs e)
    {
      numericUpDownColorBlue.Value = rnd.Next(0, 255);
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
        numericUpDownColorRed.Value = colorDialog.Color.R;
        numericUpDownColorGreen.Value = colorDialog.Color.G;
        numericUpDownColorBlue.Value = colorDialog.Color.B;
        if (checkBoxEnableAlpha.Checked) numericUpDownColorAlpha.Value = colorDialog.Color.A;
      }
    }

    private void ColorSelectorForm_Paint(object sender, PaintEventArgs e)
    {
      /*Graphics g = e.Graphics;
      Pen opaquePen = new Pen(Color.FromArgb(255, 0, 0, 255), 15);
      Pen pen = new Pen(Color.FromArgb(trackBarColorAlpha.Value, trackBarColorRed.Value, trackBarColorGreen.Value, trackBarColorBlue.Value), 15);
      Pen semiTransPen = new Pen(Color.FromArgb(128, 0, 0, 255), 15);
      SolidBrush opaqueBrush = new SolidBrush(pictureBoxColorRGB.BackColor);
      g.DrawLine(opaquePen, 0, 20, 100, 20);
      g.DrawLine(semiTransPen, 0, 40, 100, 40);
      g.FillRectangle(opaqueBrush, pictureBoxColorRGB.Bounds);*/
    }

    private void mirrorColorRed()
    {
      if (numericUpDownColorRed.Value <= 127) numericUpDownColorRed.Value = 128 - numericUpDownColorRed.Value + 127; else numericUpDownColorRed.Value = 255 - numericUpDownColorRed.Value;
    }

    private void mirrorColorGreen()
    {
      if (numericUpDownColorGreen.Value <= 127) numericUpDownColorGreen.Value = 128 - numericUpDownColorGreen.Value + 127; else numericUpDownColorGreen.Value = 255 - numericUpDownColorGreen.Value;
    }

    private void mirrorColorBlue()
    {
      if (numericUpDownColorBlue.Value <= 127) numericUpDownColorBlue.Value = 128 - numericUpDownColorBlue.Value + 127; else numericUpDownColorBlue.Value = 255 - numericUpDownColorBlue.Value;
    }

    private void mirrorColorAlpha()
    {
      if (checkBoxEnableAlpha.Checked) if (numericUpDownColorAlpha.Value <= 127) numericUpDownColorAlpha.Value = 128 - numericUpDownColorAlpha.Value + 127; else numericUpDownColorAlpha.Value = 255 - numericUpDownColorAlpha.Value;
    }

    private void buttonMirrorColorRed_Click(object sender, EventArgs e)
    {
      mirrorColorRed();
    }

    private void buttonMirrorColorGreen_Click(object sender, EventArgs e)
    {
      mirrorColorGreen();
    }

    private void buttonMirrorColorBlue_Click(object sender, EventArgs e)
    {
      mirrorColorBlue();
    }

    private void buttonMirrorColorAlpha_Click(object sender, EventArgs e)
    {
      if (checkBoxEnableAlpha.Checked) mirrorColorAlpha();
    }

    private void buttonMirrorColor_Click(object sender, EventArgs e)
    {
      mirrorColorRed();
      mirrorColorGreen();
      mirrorColorBlue();
      if (checkBoxEnableAlpha.Checked) mirrorColorAlpha();
    }

    private void toolStripMenuItemRGB_Click(object sender, EventArgs e)
    {
      mirrorColorRed();
      mirrorColorGreen();
      mirrorColorBlue();
    }

    private void toolStripMenuItemMirrorRG_Click(object sender, EventArgs e)
    {
      mirrorColorRed();
      mirrorColorGreen();
    }

    private void toolStripMenuItemMirrorRB_Click(object sender, EventArgs e)
    {
      mirrorColorRed();
      mirrorColorBlue();
    }

    private void toolStripMenuItemMirrorGB_Click(object sender, EventArgs e)
    {
      mirrorColorGreen();
      mirrorColorBlue();
    }

    private void toolStripMenuItemMirrorR_Click(object sender, EventArgs e)
    {
      mirrorColorRed();
    }

    private void toolStripMenuItemMirrorG_Click(object sender, EventArgs e)
    {
      mirrorColorGreen();
    }

    private void toolStripMenuItemMirrorB_Click(object sender, EventArgs e)
    {
      mirrorColorBlue();
    }
  }
}
