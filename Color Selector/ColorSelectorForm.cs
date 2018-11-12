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

      string strColorRedMath = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.00}", 1.0 * trackBarColorRed.Value / 255);
      string strColorGreenMath = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.00}", 1.0 * trackBarColorGreen.Value / 255);
      string strColorBlueMath = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.00}", 1.0 * trackBarColorBlue.Value / 255);
      
      pictureBoxColorRGB.BackColor = Color.FromArgb(trackBarColorRed.Value, trackBarColorGreen.Value, trackBarColorBlue.Value);

      textBoxHexColorCode.Text = "$" + strColorBlueHex + strColorGreenHex + strColorRedHex;
      textBoxHtmlColorCode.Text = "#" + strColorRedHex + strColorGreenHex + strColorBlueHex;
      textBoxRgbColorCode.Text = "(" + trackBarColorRed.Value + ", " + trackBarColorGreen.Value + ", " + trackBarColorBlue.Value + ")";
      textBoxMathColorCode.Text = strColorRedMath + ", " + strColorGreenMath + ", " + strColorBlueMath;
    }

    private void trackBarColorRed_Scroll(object sender, EventArgs e)
    {
      numericUpDownColorRed.Value = trackBarColorRed.Value;
      ChangePicBoxColor();
    }

    private void trackBarColorGreen_Scroll(object sender, EventArgs e)
    {
      numericUpDownColorGreen.Value = trackBarColorGreen.Value;
      ChangePicBoxColor();
    }

    private void trackBarColorBlue_Scroll(object sender, EventArgs e)
    {
      numericUpDownColorBlue.Value = trackBarColorBlue.Value;
      ChangePicBoxColor();
    }

    private void buttonInformation_Click(object sender, EventArgs e)
    {
      AboutBoxForm formAboutBox = new AboutBoxForm();
      formAboutBox.ShowDialog();
    }

    private void buttonEnd_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void ColorSelectorForm_Load(object sender, EventArgs e)
    {
      ChangePicBoxColor();
    }

    private void buttonHexColorCodeCopyToClipboard_Click(object sender, EventArgs e)
    {
      textBoxHexColorCode.SelectAll();
      textBoxHexColorCode.Copy();
    }

    private void buttonHtmlColorCodeCopyToClipboard_Click(object sender, EventArgs e)
    {
      textBoxHtmlColorCode.SelectAll();
      textBoxHtmlColorCode.Copy();
    }

    private void buttonRgbColorCodeCopyToClipboard_Click(object sender, EventArgs e)
    {
      textBoxRgbColorCode.SelectAll();
      textBoxRgbColorCode.Copy();
    }

    private void buttonMathColorCode_Click(object sender, EventArgs e)
    {
      textBoxMathColorCode.SelectAll();
      textBoxMathColorCode.Copy();
    }

    private void numericUpDownColorRed_ValueChanged(object sender, EventArgs e)
    {
      trackBarColorRed.Value = (int)numericUpDownColorRed.Value;
      ChangePicBoxColor();
    }

    private void numericUpDownColorGreen_ValueChanged(object sender, EventArgs e)
    {
      trackBarColorGreen.Value = (int)numericUpDownColorGreen.Value;
      ChangePicBoxColor();
    }

    private void numericUpDownColorBlue_ValueChanged(object sender, EventArgs e)
    {
      trackBarColorBlue.Value = (int)numericUpDownColorBlue.Value;
      ChangePicBoxColor();
    }

    private void buttonInvertColor_Click(object sender, EventArgs e)
    {
      contextMenuStripInvertColor.Show(buttonInvertColor, 0, buttonInvertColor.Size.Height);
    }

    private void buttonSwapColor_Click(object sender, EventArgs e)
    {
      contextMenuStripSwapColor.Show(buttonSwapColor, 0, buttonSwapColor.Size.Height);
    }

    private void ToolStripMenuItemSwapRG_Click(object sender, EventArgs e)
    {
      int swap;

      swap = trackBarColorRed.Value;
      trackBarColorRed.Value = trackBarColorGreen.Value;
      trackBarColorGreen.Value = swap;

      swap = (int)numericUpDownColorRed.Value;
      numericUpDownColorRed.Value = numericUpDownColorGreen.Value;
      numericUpDownColorGreen.Value = swap;
    }

    private void ToolStripMenuItemSwapRB_Click(object sender, EventArgs e)
    {
      int swap;

      swap = trackBarColorRed.Value;
      trackBarColorRed.Value = trackBarColorBlue.Value;
      trackBarColorBlue.Value = swap;

      swap = (int)numericUpDownColorRed.Value;
      numericUpDownColorRed.Value = numericUpDownColorBlue.Value;
      numericUpDownColorBlue.Value = swap;
    }

    private void ToolStripMenuItemSwapGB_Click(object sender, EventArgs e)
    {
      int swap;

      swap = trackBarColorGreen.Value;
      trackBarColorGreen.Value = trackBarColorBlue.Value;
      trackBarColorBlue.Value = swap;

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
      trackBarColorRed.Value = color;
      numericUpDownColorRed.Value = color;
    }

    private void ToolStripMenuItemInvertColorG_Click(object sender, EventArgs e)
    {
      byte color = (byte)trackBarColorGreen.Value;
      color += 128;
      trackBarColorGreen.Value = color;
      numericUpDownColorGreen.Value = color;
    }

    private void ToolStripMenuItemInvertColorB_Click(object sender, EventArgs e)
    {
      byte color = (byte)trackBarColorBlue.Value;
      color += 128;
      trackBarColorBlue.Value = color;
      numericUpDownColorBlue.Value = color;
    }
  }
}
