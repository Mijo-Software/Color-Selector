using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

      pictureBoxColorRGB.BackColor = Color.FromArgb(trackBarColorRed.Value, trackBarColorGreen.Value, trackBarColorBlue.Value);

      textBoxHexColorCode.Text = "$" + strColorBlueHex + strColorGreenHex + strColorRedHex;
      textBoxHtmlColorCode.Text = "#" + strColorRedHex + strColorGreenHex + strColorBlueHex;
    }

    private void trackBarColorRed_Scroll(object sender, EventArgs e)
    {
      textBoxColorRed.Text = trackBarColorRed.Value.ToString();
      ChangePicBoxColor();
    }

    private void trackBarColorGreen_Scroll(object sender, EventArgs e)
    {
      textBoxColorGreen.Text = trackBarColorGreen.Value.ToString();
      ChangePicBoxColor();
    }

    private void trackBarColorBlue_Scroll(object sender, EventArgs e)
    {
      textBoxColorBlue.Text = trackBarColorBlue.Value.ToString();
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
      textBoxColorRed.Text = "0";
      textBoxColorGreen.Text = "0";
      textBoxColorBlue.Text = "0";
    }
  }
}
