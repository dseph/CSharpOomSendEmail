using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using Outlook = Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop.Outlook;
using Microsoft.Office.Interop;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace CSharpOomSendEmail
{
    public partial class frmSendEmail : Form
    {

        private Outlook.MailItem _EmailMessage = null;

        private Outlook.MailItem _ResponseMessage = null;

        Microsoft.Office.Interop.Outlook._Application _oApp = null;
        Microsoft.Office.Interop.Outlook._NameSpace _oNS = null;

        public frmSendEmail()
        {
            InitializeComponent();
        }

        private void frmSendEmail_Load(object sender, EventArgs e)
        {
 
        }

  

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                // Create the Outlook application.
                Outlook.Application outlookApp = new Outlook.Application();

                // Create a new mail item.
                Outlook.MailItem mailItem = (Outlook.MailItem)outlookApp.CreateItem(Outlook.OlItemType.olMailItem);

                // Set the properties of the mail item.
                mailItem.Subject = txtSubject.Text.Trim() ;
                mailItem.To = txtTo.Text.Trim();
                mailItem.Body = txtBody.Text.Trim();

                // Send the email.
                mailItem.Send();
                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Microsoft.Office.Interop.Outlook.Exception
            }
            catch (System.Exception ex)
            {
                //MessageBox.Show(" Error Message: " + ex.Message +"\r\n\r\nInnerException: ", 
                //    "Error", 
                //    MessageBoxButtons.OK, 
                //    MessageBoxIcon.Error);
                string s =
                    "Message: " + ex.Message + "\r\n\r\n" +
                    "InnerException: " + ex.InnerException + "\r\n\r\n" +
                    "Stack Trace: " + ex.StackTrace;


                DisplayText oForm = new DisplayText(s, "Error");
                oForm.ShowDialog();
            }
 
        }

    }
}
 