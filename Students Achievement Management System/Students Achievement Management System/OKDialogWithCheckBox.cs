using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Achievement_Management_System
{
    public partial class OKDialogWithCheckBox : Form
    {
        public OKDialogWithCheckBox(string DialogText, string TitleText,
            string OKButtonText, string CancelButtonText,
            string CheckBoxText, bool InitCheckBoxState = true)
        {
            InitializeComponent();
            this.LabelText.Text = DialogText;
            this.Text = TitleText;
            this.OKButton.Text = OKButtonText;
            this.CancelButton.Text = CancelButtonText;
            this.CheckBox.Text = CheckBoxText;
            this.CheckBox.Checked = InitCheckBoxState;
        }

        public bool CheckBoxState
        {
            get
            {
                return this.CheckBox.Checked;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
