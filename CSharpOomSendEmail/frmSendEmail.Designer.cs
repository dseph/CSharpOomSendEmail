namespace CSharpOomSendEmail
{
    partial class frmSendEmail
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTo = new TextBox();
            txtSubject = new TextBox();
            txtBody = new TextBox();
            btnSend = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 71);
            label1.Name = "label1";
            label1.Size = new Size(44, 32);
            label1.TabIndex = 0;
            label1.Text = "To:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 140);
            label2.Name = "label2";
            label2.Size = new Size(98, 32);
            label2.TabIndex = 1;
            label2.Text = "Subject:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 219);
            label3.Name = "label3";
            label3.Size = new Size(73, 32);
            label3.TabIndex = 2;
            label3.Text = "Body:";
            // 
            // txtTo
            // 
            txtTo.Location = new Point(156, 64);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(477, 39);
            txtTo.TabIndex = 7;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(156, 137);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(1384, 39);
            txtSubject.TabIndex = 8;
            // 
            // txtBody
            // 
            txtBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBody.Location = new Point(156, 216);
            txtBody.Multiline = true;
            txtBody.Name = "txtBody";
            txtBody.ScrollBars = ScrollBars.Both;
            txtBody.Size = new Size(1384, 560);
            txtBody.TabIndex = 9;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSend.Location = new Point(1399, 818);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(150, 46);
            btnSend.TabIndex = 10;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(705, 67);
            label4.Name = "label4";
            label4.Size = new Size(340, 32);
            label4.TabIndex = 11;
            label4.Text = "(Enter only one SMTP address)";
            // 
            // frmSendEmail
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 887);
            Controls.Add(label4);
            Controls.Add(btnSend);
            Controls.Add(txtBody);
            Controls.Add(txtSubject);
            Controls.Add(txtTo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmSendEmail";
            Text = "Send Email";
            Load += frmSendEmail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTo;
        private TextBox txtSubject;
        private TextBox txtBody;
        private Button btnSend;
        private Label label4;
    }
}
