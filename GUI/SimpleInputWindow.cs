using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDTreeVisualizer.GUI
{
    public partial class SimpleInputWindow : Form
    {
        private bool inputResult;
        private string textInputWatermark;
        private Func<string, Tuple<bool, string>> validationFunction;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="windowName"></param>
        /// <param name="labelText"></param>
        /// <param name="textBoxWatermark"></param>
        /// <param name="validationFunction">The validation fucntion to be performed on the users input. It has the following signature:
        /// in string: The user string input.
        /// out Tuple&lt;bool,string&gt;&lt;/bool&gt;: The result of the validation where true means the validation succeeded and false means the validation failed, the string is a message to the user explaining why the validation failed.
        /// </param>
        public SimpleInputWindow(string windowName, string labelText, string textBoxWatermark, Func<string, Tuple<bool, string>> validationFunction)
        {
            this.inputResult = true;
            this.textInputWatermark = textBoxWatermark;
            this.validationFunction = validationFunction;

            InitializeComponent();

            this.Name = windowName;
            textInputLabel.Text = labelText;
            textInput.Text = textBoxWatermark;

            okButton.MouseClick += OkButton_MouseClick;
        }

        private void OkButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (textInput.Text != textInputWatermark)
            {
                var result = validationFunction(textInput.Text);
                if (result.Item1)
                {
                    this.Close();
                }else
                {
                    MessageBox.Show(result.Item2, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public string getInputString()
        {
            return textInput.Text;
        }

        private void textInputLabel_Click(object sender, EventArgs e)
        {
            textInput.Focus();
        }

        private void textInput_Enter(object sender, EventArgs e)
        {
            if(textInput.Text == textInputWatermark)
            {
                textInput.Text = "";
            }
        }

        private void textInput_Leave(object sender, EventArgs e)
        {
            if(textInput.Text == "")
            {
                textInput.Text = textInputWatermark;
            }
        }
    }
}
