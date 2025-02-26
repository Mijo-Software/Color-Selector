using System.Diagnostics;
using DisksizeWatcher;
using NLog;

namespace Color_Selector
{
	/// <summary>
	/// Represents the form for selecting and manipulating colors.
	/// </summary>
	public partial class ColorSelectorForm : Form
	{
		/// <summary>
		/// Logger instance for logging messages and exceptions.
		/// </summary>
		private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

		/// <summary>
		/// Random number generator for randomizing color channels.
		/// </summary>
		private readonly Random rnd = new();

		/// <summary>
		/// Indicates whether the alpha channel is enabled.
		/// </summary>
		private bool isChannelAlphaEnabled = true;

		#region Helpers

		/// <summary>
		/// Handles exceptions by logging the error and showing a message box.
		/// </summary>
		/// <param name="ex">The exception that occurred.</param>
		/// <param name="message">The message to log and display.</param>
		/// <param name="sender">The source of the event that caused the exception.</param>
		/// <param name="e">The event data associated with the exception.</param>
		private static void HandleException(Exception ex, string message, object? sender = null, EventArgs? e = null)
		{
			// Implement logging logic here (e.g., log to a file or monitoring system)
			string msg = $"Error: {ex}\nMessage: {ex.Message}\nStackTrack: {ex.StackTrace}\nSender: {sender}, EventArgs: {e}";
			Debug.WriteLine(value: msg);
			Console.WriteLine(value: msg);
			Logger.Error(exception: ex, message: msg);
			_ = MessageBox.Show(text: message, caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
		}

		/// <summary>
		/// Changes the color of the picture box based on the track bar values.
		/// </summary>
		private void ChangePicBoxColor()
		{
			string FormatHex(int value) => value < 16 ? $"0{value:X}" : $"{value:X}";
			string FormatMath(int value) => $"{1.0 * value / 255:0.00}";

			string strColorRedHex = FormatHex(value: trackBarChannelRed.Value);
			string strColorGreenHex = FormatHex(value: trackBarChannelGreen.Value);
			string strColorBlueHex = FormatHex(value: trackBarChannelBlue.Value);
			string strColorAlphaHex = FormatHex(value: trackBarChannelAlpha.Value);

			string strColorRedMath = FormatMath(value: trackBarChannelRed.Value);
			string strColorGreenMath = FormatMath(value: trackBarChannelGreen.Value);
			string strColorBlueMath = FormatMath(value: trackBarChannelBlue.Value);
			string strColorAlphaMath = FormatMath(value: trackBarChannelAlpha.Value);

			pictureBoxCanvas.BackColor = isChannelAlphaEnabled
				? Color.FromArgb(alpha: trackBarChannelAlpha.Value, red: trackBarChannelRed.Value, green: trackBarChannelGreen.Value, blue: trackBarChannelBlue.Value)
				: Color.FromArgb(alpha: 255, red: trackBarChannelRed.Value, green: trackBarChannelGreen.Value, blue: trackBarChannelBlue.Value);

			if (isChannelAlphaEnabled)
			{
				textBoxColorCodeHex.Text = $"${strColorAlphaHex}{strColorBlueHex}{strColorGreenHex}{strColorRedHex}";
				textBoxColorCodeHtml.Text = $"#{strColorRedHex}{strColorGreenHex}{strColorBlueHex}{strColorAlphaHex}";
				textBoxColorCodeRgb.Text = $"({trackBarChannelRed.Value}, {trackBarChannelGreen.Value}, {trackBarChannelBlue.Value}, {trackBarChannelAlpha.Value})";
				textBoxColorCodeMath.Text = $"{strColorRedMath}, {strColorGreenMath}, {strColorBlueMath}, {strColorAlphaMath}";
			}
			else
			{
				textBoxColorCodeHex.Text = $"${strColorBlueHex}{strColorGreenHex}{strColorRedHex}";
				textBoxColorCodeHtml.Text = $"#{strColorRedHex}{strColorGreenHex}{strColorBlueHex}";
				textBoxColorCodeRgb.Text = $"({trackBarChannelRed.Value}, {trackBarChannelGreen.Value}, {trackBarChannelBlue.Value})";
				textBoxColorCodeMath.Text = $"{strColorRedMath}, {strColorGreenMath}, {strColorBlueMath}";
			}
		}

		/// <summary>
		/// Set a specific text to the status bar
		/// </summary>
		/// <param name="text">text with some information</param>
		private void SetStatusbarText(string text)
		{
			try
			{
				toolStripStatusLabelInformation.Enabled = !string.IsNullOrEmpty(value: text);
				toolStripStatusLabelInformation.Text = text;
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while setting the status bar text.");
			}
		}

		/// <summary>
		/// Detect the accessibility description to set as information text in the status bar
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void SetStatusbar_Enter(object sender, EventArgs e)
		{
			try
			{
				if (sender is Control { AccessibleDescription: { } } control)
				{
					SetStatusbarText(text: control.AccessibleDescription);
				}
				else if (sender is ToolStripMenuItem { AccessibleDescription: { } } control2)
				{
					SetStatusbarText(text: control2.AccessibleDescription);
				}
				else if (sender is ToolStripStatusLabel { AccessibleDescription: { } } control3)
				{
					SetStatusbarText(text: control3.AccessibleDescription);
				}
				else if (sender is ToolStripButton { AccessibleDescription: { } } control4)
				{
					SetStatusbarText(text: control4.AccessibleDescription);
				}
				else if (sender is ToolStripDropDownButton { AccessibleDescription: { } } control5)
				{
					SetStatusbarText(text: control5.AccessibleDescription);
				}
				else if (sender is ToolStripSplitButton { AccessibleDescription: { } } control6)
				{
					SetStatusbarText(text: control6.AccessibleDescription);
				}
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while setting the status bar text.", sender: sender, e: e);
			}
		}

		/// <summary>
		/// Clear the information text of the status bar
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="KeyEventArgs"/> instance that contains the event data.</param>
		private void ClearStatusbar_Leave(object sender, EventArgs e)
		{
			try
			{
				SetStatusbarText(text: string.Empty);
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while clearing the status bar text.");
			}
		}

		/// <summary>
		/// Opens the About form.
		/// </summary>
		private void OpenAboutForm()
		{
			try
			{
				using AboutBoxForm aboutBoxForm = new();
				_ = aboutBoxForm.ShowDialog(owner: this);
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while opening the About form.");
			}
		}

		/// <summary>
		/// Inverts the value of a color channel.
		/// </summary>
		/// <param name="value">The value to invert.</param>
		/// <returns>The inverted value.</returns>
		private static byte InvertChannel(int value)
		{
			byte color = (byte)value;
			color += 128;
			return color;
		}

		/// <summary>
		/// Inverts the red color channel.
		/// </summary>
		private void InvertChannelRed() => numericUpDownChannelRed.Value = InvertChannel(value: trackBarChannelRed.Value);

		/// <summary>
		/// Inverts the green color channel.
		/// </summary>
		private void InvertChannelGreen() => numericUpDownChannelGreen.Value = InvertChannel(value: trackBarChannelGreen.Value);

		/// <summary>
		/// Inverts the blue color channel.
		/// </summary>
		private void InvertChannelBlue() => numericUpDownChannelBlue.Value = InvertChannel(value: trackBarChannelBlue.Value);

		/// <summary>
		/// Inverts the alpha color channel.
		/// </summary>
		private void InvertChannelAlpha() => numericUpDownChannelAlpha.Value = InvertChannel(value: trackBarChannelAlpha.Value);

		/// <summary>
		/// Inverts all color channels.
		/// </summary>
		private void InvertAllColorChannels()
		{
			InvertChannelRed();
			InvertChannelGreen();
			InvertChannelBlue();
			if (isChannelAlphaEnabled)
			{
				InvertChannelAlpha();
			}
		}

		/// <summary>
		/// Randomizes the red color channel.
		/// </summary>
		private void RandomizeChannelRed() => numericUpDownChannelRed.Value = rnd.Next(minValue: 0, maxValue: 255);

		/// <summary>
		/// Randomizes the green color channel.
		/// </summary>
		private void RandomizeChannelGreen() => numericUpDownChannelGreen.Value = rnd.Next(minValue: 0, maxValue: 255);

		/// <summary>
		/// Randomizes the blue color channel.
		/// </summary>
		private void RandomizeChannelBlue() => numericUpDownChannelBlue.Value = rnd.Next(minValue: 0, maxValue: 255);

		/// <summary>
		/// Randomizes the alpha color channel.
		/// </summary>
		private void RandomizeChannelAlpha() => numericUpDownChannelAlpha.Value = rnd.Next(minValue: 0, maxValue: 255);

		/// <summary>
		/// Randomizes all color channels.
		/// </summary>
		private void RandomizeAllColorChannels()
		{
			RandomizeChannelRed();
			RandomizeChannelGreen();
			RandomizeChannelBlue();
			if (isChannelAlphaEnabled)
			{
				RandomizeChannelAlpha();
			}
		}

		/// <summary>
		/// Mirrors the red color channel.
		/// </summary>
		private void MirrorChannelRed() => numericUpDownChannelRed.Value = 255 - numericUpDownChannelRed.Value;

		/// <summary>
		/// Mirrors the green color channel.
		/// </summary>
		private void MirrorChannelGreen() => numericUpDownChannelGreen.Value = 255 - numericUpDownChannelGreen.Value;

		/// <summary>
		/// Mirrors the blue color channel.
		/// </summary>
		private void MirrorChannelBlue() => numericUpDownChannelBlue.Value = 255 - numericUpDownChannelBlue.Value;

		/// <summary>
		/// Mirrors the alpha color channel.
		/// </summary>
		private void MirrorChannelAlpha() => numericUpDownChannelAlpha.Value = 255 - numericUpDownChannelAlpha.Value;

		/// <summary>
		/// Swaps the red and green color channels.
		/// </summary>
		private void SwapChannelRedGreen() => (numericUpDownChannelRed.Value, numericUpDownChannelGreen.Value) = (numericUpDownChannelGreen.Value, numericUpDownChannelRed.Value);

		/// <summary>
		/// Swaps the red and blue color channels.
		/// </summary>
		private void SwapChannelRedBlue() => (numericUpDownChannelRed.Value, numericUpDownChannelBlue.Value) = (numericUpDownChannelBlue.Value, numericUpDownChannelRed.Value);

		/// <summary>
		/// Swaps the blue and green color channels.
		/// </summary>
		private void SwapChannelBlueGreen() => (numericUpDownChannelBlue.Value, numericUpDownChannelGreen.Value) = (numericUpDownChannelGreen.Value, numericUpDownChannelBlue.Value);

		/// <summary>
		/// Mirrors all color channels.
		/// </summary>
		private void MirrorAllColorChannels()
		{
			MirrorChannelRed();
			MirrorChannelGreen();
			MirrorChannelBlue();
			if (isChannelAlphaEnabled)
			{
				MirrorChannelAlpha();
			}
		}

		#endregion

		#region Constructor

		/// <summary>
		/// Initializes a new instance of the <see cref="ColorSelectorForm"/> class.
		/// </summary>
		public ColorSelectorForm()
		{
			InitializeComponent();
			toolStripStatusLabelInformation.Text = string.Empty;
			this.KeyDown += new KeyEventHandler(ColorSelectorForm_KeyDown);
			this.KeyPreview = true; // Ensures the form receives key events before the controls
			Logger.Info(message: "ColorSelectorForm initialized");
		}

		#endregion

		#region Form Events

		/// <summary>
		/// Handles the Load event of the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ColorSelectorForm_Load(object sender, EventArgs e)
		{
			RandomizeAllColorChannels();
			ChangePicBoxColor();
		}

		#endregion

		#region KeyDown Events

		/// <summary>
		/// Handles the KeyDown event of the LicenseForm.
		/// Closes the form when the Escape key is pressed.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="KeyEventArgs"/> instance that contains the event data.</param>
		private void ColorSelectorForm_KeyDown(object? sender, KeyEventArgs e)
		{
			try
			{
				if (e.KeyCode == Keys.Escape)
				{
					this.Close();
				}
			}
			catch (Exception ex)
			{
				HandleException(ex: ex, message: "An error occurred while setting the status bar text.", sender: sender, e: e);
			}
		}

		#endregion

		#region Click Events

		/// <summary>
		/// Handles the Click event of the ButtonInvertChannelRed control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonInvertChannelRed_Click(object sender, EventArgs e) => InvertChannelRed();

		/// <summary>
		/// Handles the Click event of the ButtonInvertChannelGreen control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonInvertChannelGreen_Click(object sender, EventArgs e) => InvertChannelGreen();

		/// <summary>
		/// Handles the Click event of the ButtonInvertChannelBlue control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonInvertChannelBlue_Click(object sender, EventArgs e) => InvertChannelBlue();

		/// <summary>
		/// Handles the Click event of the ButtonInvertChannelAlpha control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonInvertChannelAlpha_Click(object sender, EventArgs e) => InvertChannelAlpha();

		/// <summary>
		/// Handles the Click event of the ToolStripButtonInvert control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonInvert_Click(object sender, EventArgs e) => InvertAllColorChannels();

		/// <summary>
		/// Handles the Click event of the ToolStripMenuItemInvert control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemInvert_Click(object sender, EventArgs e) => InvertAllColorChannels();

		/// <summary>
		/// Handles the Click event of the ButtonRandomizeChannelRed control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonRandomizeChannelRed_Click(object sender, EventArgs e) => RandomizeChannelRed();

		/// <summary>
		/// Handles the Click event of the ButtonRandomizeChannelGreen control.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonRandomizeChannelGreen_Click(object sender, EventArgs e) => RandomizeChannelGreen();

		/// <summary>	   		/// <summary>
		/// Handles the Click event of the ButtonRandomizeChannelBlue control.
		/// Randomizes the blue color channel.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonRandomizeChannelBlue_Click(object sender, EventArgs e) => RandomizeChannelBlue();

		/// <summary>
		/// Handles the Click event of the ButtonRandomizeChannelAlpha control.
		/// Randomizes the alpha color channel.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonRandomizeChannelAlpha_Click(object sender, EventArgs e) => RandomizeChannelAlpha();

		/// <summary>
		/// Handles the Click event of the ToolStripButtonRandomize control.
		/// Randomizes all color channels.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonRandomize_Click(object sender, EventArgs e) => RandomizeAllColorChannels();

		/// <summary>
		/// Handles the Click event of the ToolStripMenuItemRandomize control.
		/// Randomizes all color channels.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemRandomize_Click(object sender, EventArgs e) => RandomizeAllColorChannels();

		/// <summary>
		/// Handles the Click event of the ButtonMirrorChannelRed control.
		/// Mirrors the red color channel.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonMirrorChannelRed_Click(object sender, EventArgs e) => MirrorChannelRed();

		/// <summary>
		/// Handles the Click event of the ButtonMirrorChannelGreen control.
		/// Mirrors the green color channel.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonMirrorChannelGreen_Click(object sender, EventArgs e) => MirrorChannelGreen();

		/// <summary>
		/// Handles the Click event of the ButtonMirrorChannelBlue control.
		/// Mirrors the blue color channel.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonMirrorChannelBlue_Click(object sender, EventArgs e) => MirrorChannelBlue();

		/// <summary>
		/// Handles the Click event of the ButtonMirrorChannelAlpha control.
		/// Mirrors the alpha color channel.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonMirrorChannelAlpha_Click(object sender, EventArgs e) => MirrorChannelAlpha();

		/// <summary>
		/// Handles the Click event of the ToolStripButtonMirror control.
		/// Mirrors all color channels.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonMirror_Click(object sender, EventArgs e) => MirrorAllColorChannels();

		/// <summary>
		/// Handles the Click event of the ToolStripMenuItemMirror control.
		/// Mirrors all color channels.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemMirror_Click(object sender, EventArgs e) => MirrorAllColorChannels();

		/// <summary>
		/// Handles the Click event of the ButtonCopyToClipboardColorCodeHex control.
		/// Copies the hex color code to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonCopyToClipboardColorCodeHex_Click(object sender, EventArgs e)
		{
			textBoxColorCodeHex.SelectAll();
			textBoxColorCodeHex.Copy();
		}

		/// <summary>
		/// Handles the Click event of the ButtonCopyToClipboardColorCodeHtml control.
		/// Copies the HTML color code to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonCopyToClipboardColorCodeHtml_Click(object sender, EventArgs e)
		{
			textBoxColorCodeHtml.SelectAll();
			textBoxColorCodeHtml.Copy();
		}

		/// <summary>
		/// Handles the Click event of the ButtonCopyToClipboardColorCodeRgb control.
		/// Copies the RGB color code to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonCopyToClipboardColorCodeRgb_Click(object sender, EventArgs e)
		{
			textBoxColorCodeRgb.SelectAll();
			textBoxColorCodeRgb.Copy();
		}

		/// <summary>
		/// Handles the Click event of the ButtonCopyToClipboardColorCodeMath control.
		/// Copies the mathematical color code to the clipboard.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ButtonCopyToClipboardColorCodeMath_Click(object sender, EventArgs e)
		{
			textBoxColorCodeMath.SelectAll();
			textBoxColorCodeMath.Copy();
		}

		/// <summary>
		/// Handles the Click event of the ToolStripButtonAbout control.
		/// Opens the About form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripButtonAbout_Click(object sender, EventArgs e) => OpenAboutForm();

		/// <summary>
		/// Handles the Click event of the ToolStripMenuItemAbout control.
		/// Opens the About form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemAbout_Click(object sender, EventArgs e) => OpenAboutForm();

		/// <summary>
		/// Handles the Click event of the ToolStripMenuItemExit control.
		/// Closes the form.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemExit_Click(object sender, EventArgs e) => Close();

		/// <summary>
		/// Handles the Click event of the ToolStripMenuItemSwapRedGreen control.
		/// Swaps the red and green color channels.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemSwapRedGreen_Click(object sender, EventArgs e) => SwapChannelRedGreen();

		/// <summary>
		/// Handles the Click event of the ToolStripMenuItemSwapRedBlue control.
		/// Swaps the red and blue color channels.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemSwapRedBlue_Click(object sender, EventArgs e) => SwapChannelRedBlue();

		/// <summary>
		/// Handles the Click event of the ToolStripMenuItemBlueGreen control.
		/// Swaps the blue and green color channels.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void ToolStripMenuItemBlueGreen_Click(object sender, EventArgs e) => SwapChannelBlueGreen();

		/// <summary>
		/// Handles the Click event of the LabelChannelAlpha control.
		/// Toggles the alpha channel's enabled state and updates the UI accordingly.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void LabelChannelAlpha_Click(object sender, EventArgs e)
		{
			isChannelAlphaEnabled = !isChannelAlphaEnabled;
			labelChannelAlpha.ForeColor = isChannelAlphaEnabled ? Color.Black : Color.Gray;
			trackBarChannelAlpha.Enabled = isChannelAlphaEnabled;
			numericUpDownChannelAlpha.Enabled = isChannelAlphaEnabled;
			buttonRandomizeChannelAlpha.Enabled = isChannelAlphaEnabled;
			buttonInvertChannelAlpha.Enabled = isChannelAlphaEnabled;
			buttonMirrorChannelAlpha.Enabled = isChannelAlphaEnabled;
			ChangePicBoxColor();
		}

		#endregion

		#region DoubleClick Events

		/// <summary>
		/// Handles the DoubleClick event of the PictureBoxCanvas control.
		/// Opens a color dialog to select a new color for the picture box.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void PictureBoxCanvas_DoubleClick(object sender, EventArgs e)
		{
			colorDialog.Color = pictureBoxCanvas.BackColor;
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				numericUpDownChannelRed.Value = colorDialog.Color.R;
				numericUpDownChannelGreen.Value = colorDialog.Color.G;
				numericUpDownChannelBlue.Value = colorDialog.Color.B;
				if (isChannelAlphaEnabled)
				{
					numericUpDownChannelAlpha.Value = colorDialog.Color.A;
				}
			}
		}

		#endregion

		#region ValueChanged Events

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownChannelRed control.
		/// Updates the track bar value and changes the picture box color.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownChannelRed_ValueChanged(object sender, EventArgs e)
		{
			trackBarChannelRed.Value = (int)numericUpDownChannelRed.Value;
			ChangePicBoxColor();
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownChannelGreen control.
		/// Updates the track bar value and changes the picture box color.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownChannelGreen_ValueChanged(object sender, EventArgs e)
		{
			trackBarChannelGreen.Value = (int)numericUpDownChannelGreen.Value;
			ChangePicBoxColor();
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownChannelBlue control.
		/// Updates the track bar value and changes the picture box color.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownChannelBlue_ValueChanged(object sender, EventArgs e)
		{
			trackBarChannelBlue.Value = (int)numericUpDownChannelBlue.Value;
			ChangePicBoxColor();
		}

		/// <summary>
		/// Handles the ValueChanged event of the NumericUpDownChannelAlpha control.
		/// Updates the track bar value and changes the picture box color.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void NumericUpDownChannelAlpha_ValueChanged(object sender, EventArgs e)
		{
			trackBarChannelAlpha.Value = (int)numericUpDownChannelAlpha.Value;
			ChangePicBoxColor();
		}

		#endregion

		#region Scroll Events

		/// <summary>
		/// Handles the Scroll event of the TrackBarChannelRed control.
		/// Updates the numeric up-down value.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void TrackBarChannelRed_Scroll(object sender, EventArgs e) => numericUpDownChannelRed.Value = trackBarChannelRed.Value;

		/// <summary>
		/// Handles the Scroll event of the TrackBarChannelGreen control.
		/// Updates the numeric up-down value.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void TrackBarChannelGreen_Scroll(object sender, EventArgs e) => numericUpDownChannelGreen.Value = trackBarChannelGreen.Value;

		/// <summary>
		/// Handles the Scroll event of the TrackBarChannelBlue control.
		/// Updates the numeric up-down value.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void TrackBarChannelBlue_Scroll(object sender, EventArgs e) => numericUpDownChannelBlue.Value = trackBarChannelBlue.Value;

		/// <summary>
		/// Handles the Scroll event of the TrackBarChannelAlpha control.
		/// Updates the numeric up-down value and changes the picture box color.
		/// </summary>
		/// <param name="sender">The event source.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance that contains the event data.</param>
		private void TrackBarChannelAlpha_Scroll(object sender, EventArgs e)
		{
			numericUpDownChannelAlpha.Value = trackBarChannelAlpha.Value;
			ChangePicBoxColor();
		}

		#endregion
	}
}
