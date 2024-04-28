namespace _20200305026
{
    partial class Form1
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
            passwordlabel = new Label();
            usernamelabel = new Label();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            loginbutton = new Button();
            buttonexit = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // passwordlabel
            // 
            passwordlabel.Anchor = AnchorStyles.None;
            passwordlabel.AutoSize = true;
            passwordlabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            passwordlabel.Location = new Point(203, 231);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(93, 28);
            passwordlabel.TabIndex = 0;
            passwordlabel.Text = "Password";
            // 
            // usernamelabel
            // 
            usernamelabel.Anchor = AnchorStyles.None;
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            usernamelabel.Location = new Point(203, 187);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(99, 28);
            usernamelabel.TabIndex = 1;
            usernamelabel.Text = "Username";
            usernamelabel.Click += usernamelabel_Click;
            // 
            // txtusername
            // 
            txtusername.Anchor = AnchorStyles.None;
            txtusername.Location = new Point(318, 184);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(191, 27);
            txtusername.TabIndex = 2;
            // 
            // txtpassword
            // 
            txtpassword.Anchor = AnchorStyles.None;
            txtpassword.Location = new Point(318, 228);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(191, 27);
            txtpassword.TabIndex = 3;
            // 
            // loginbutton
            // 
            loginbutton.Anchor = AnchorStyles.None;
            loginbutton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            loginbutton.Location = new Point(415, 271);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(94, 37);
            loginbutton.TabIndex = 4;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = true;
            // 
            // buttonexit
            // 
            buttonexit.Anchor = AnchorStyles.None;
            buttonexit.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 162);
            buttonexit.Location = new Point(318, 271);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new Size(94, 37);
            buttonexit.TabIndex = 5;
            buttonexit.Text = "Exit";
            buttonexit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Cursor = Cursors.No;
            label1.Font = new Font("Lucida Handwriting", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 65);
            label1.Name = "label1";
            label1.Size = new Size(656, 42);
            label1.TabIndex = 6;
            label1.Text = "SHADY COMPANY STOCK MANAGEMENT";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(buttonexit);
            Controls.Add(loginbutton);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(usernamelabel);
            Controls.Add(passwordlabel);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label passwordlabel;
        private Label usernamelabel;
        private TextBox txtusername;
        private TextBox txtpassword;
        private Button loginbutton;
        private Button buttonexit;
        private Label label1;
    }
}
