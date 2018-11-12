using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

    public ColorSelectorForm()
    {
      InitializeComponent();
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

pictureBoxColorRGB.BackgroundImage = null;

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

    private void trackBarColorGreen_Scroll(object sender, EventArgs e)
    {
      int oldGreenValue = (int)numericUpDownColorGreen.Value;
      numericUpDownColorGreen.Value = trackBarColorGreen.Value;
      if (isColorRGBind)
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
      ChangePicBoxColor();
    }

    private void trackBarColorBlue_Scroll(object sender, EventArgs e)
    {
      int oldBlueValue = (int)numericUpDownColorBlue.Value;
      numericUpDownColorBlue.Value = trackBarColorBlue.Value;
      if (isColorGBBind)
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

    private void ColorSelectorForm_Load(object sender, EventArgs e)
    {
      Random rnd = new Random();
      numericUpDownColorRed.Value = rnd.Next(0, 255);
      numericUpDownColorGreen.Value = rnd.Next(0, 255); 
      numericUpDownColorBlue.Value = rnd.Next(0, 255);
      numericUpDownColorAlpha.Value = rnd.Next(0, 255);
      checkBoxEnableAlpha.Checked = true;
      ChangePicBoxColor();
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
      //contextMenuStripInvertColor.Show(buttonInvertColor, 0, buttonInvertColor.Size.Height);
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

    private void randomizeColorRed()
    {
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorRed.Value = i;
    }

    private void randomizeColorGreen()
    {
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorGreen.Value = i;
    }

    private void randomizeColorBlue()
    {
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorBlue.Value = i;
    }

    private void buttonRandomizeColorRed_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorRed.Value = i;
      if (isColorRGBind) { i = rnd.Next(0, 255); numericUpDownColorGreen.Value = i; };
      if (isColorRBBind) { i = rnd.Next(0, 255); numericUpDownColorBlue.Value = i; };
      if (isColorRGBBind) { i = rnd.Next(0, 255); numericUpDownColorGreen.Value = i; i = rnd.Next(0, 255); numericUpDownColorBlue.Value = i; };
    }

    private void buttonRandomizeColorGreen_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorGreen.Value = i;
      if (isColorRGBind) { i = rnd.Next(0, 255); numericUpDownColorRed.Value = i; };
      if (isColorGBBind) { i = rnd.Next(0, 255); numericUpDownColorBlue.Value = i; };
      if (isColorRGBBind) { i = rnd.Next(0, 255); numericUpDownColorRed.Value = i; i = rnd.Next(0, 255); numericUpDownColorBlue.Value = i; };
    }

    private void buttonRandomizeColorBlue_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorBlue.Value = i;
      if (isColorRBBind) { i = rnd.Next(0, 255); numericUpDownColorRed.Value = i; };
      if (isColorGBBind) { i = rnd.Next(0, 255); numericUpDownColorGreen.Value = i; };
      if (isColorRGBBind) { i = rnd.Next(0, 255); numericUpDownColorRed.Value = i; i = rnd.Next(0, 255); numericUpDownColorGreen.Value = i; };
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
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorRed.Value = i;
      i = rnd.Next(0, 255);
      numericUpDownColorGreen.Value = i;
      i = rnd.Next(0, 255);
      numericUpDownColorBlue.Value = i;
      if (checkBoxEnableAlpha.Checked)
      {
        i = rnd.Next(0, 255);
        numericUpDownColorAlpha.Value = i;
      }
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
      } else {
        labelAlpha.Enabled = false;
        trackBarColorAlpha.Enabled = false;
        numericUpDownColorAlpha.Enabled = false;
        buttonRandomizeColorAlpha.Enabled = false;
        buttonInvertColorAlpha.Enabled = false;
      }

      ChangePicBoxColor();
    }

    private void invertColorRed()
    {
      byte color = (byte)trackBarColorRed.Value;
      color += 128;
      numericUpDownColorRed.Value = color;
    }

    private void invertColorGreen()
    {
      byte color = (byte)trackBarColorGreen.Value;
      color += 128;
      numericUpDownColorGreen.Value = color;
    }

    private void invertColorBlue()
    {
      byte color = (byte)trackBarColorBlue.Value;
      color += 128;
      numericUpDownColorBlue.Value = color;
    }

    private void invertColorAlpha()
    {
      byte color = (byte)trackBarColorAlpha.Value;
      color += 128;
      numericUpDownColorAlpha.Value = color;
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
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorRed.Value = i;
      i = rnd.Next(0, 255);
      numericUpDownColorGreen.Value = i;
      i = rnd.Next(0, 255);
      numericUpDownColorBlue.Value = i;
    }

    private void toolStripMenuItemRandomizeColorRG_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorRed.Value = i;
      i = rnd.Next(0, 255);
      numericUpDownColorGreen.Value = i;
    }

    private void toolStripMenuItemRandomizeColorRB_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorRed.Value = i;
      i = rnd.Next(0, 255);
      numericUpDownColorBlue.Value = i;
    }

    private void toolStripMenuItemRandomizeColorGB_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorGreen.Value = i;
      i = rnd.Next(0, 255);
      numericUpDownColorBlue.Value = i;
    }

    private void toolStripMenuItemRandomizeColorR_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorRed.Value = i;
    }

    private void toolStripMenuItemRandomizeColorG_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorGreen.Value = i;
    }

    private void toolStripMenuItemRandomizeColorB_Click(object sender, EventArgs e)
    {
      Random rnd = new Random();
      int i = rnd.Next(0, 255);
      numericUpDownColorBlue.Value = i;
    }
  }
}
