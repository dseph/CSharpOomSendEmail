using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpOomSendEmail
{
    public partial class DisplayText : Form
    {
        public DisplayText()
        {
            InitializeComponent();
        }
        public DisplayText(string sBody, string sTitle)
        {
            InitializeComponent();
            this.Text = sTitle;
            this.textBox1.Text = sBody;
        }

        private void DisplayText_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
