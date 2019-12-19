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
    public partial class ProcessingDialog : Form
    {
        private string ProcessingText;
        public ProcessingDialog(string initText)
        {
            ProcessingText = initText;
            InitializeComponent();
        }

        public void SetProcessingPercentage(int absoluteValue)
        {
            ProcessingLabel.Text = ProcessingText + " 进度："
                + absoluteValue.ToString() + "%";
            ProgressBar.Value = absoluteValue;
        }

        public void SetProcessingPercentage(int nowValue, int totalValue)
        {
            int absoluteValue = (int)(nowValue * 1.0 / totalValue);
            ProcessingLabel.Text = ProcessingText + " 进度："
                + absoluteValue.ToString() + "%";
            ProgressBar.Value = absoluteValue;
        }
    }
}
