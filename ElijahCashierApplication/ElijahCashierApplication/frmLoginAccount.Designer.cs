namespace ElijahCashierApplication
{
    partial class frmLoginAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            username_textBox = new TextBox();
            password_textBox = new TextBox();
            label2 = new Label();
            login_Button = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 18);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // username_textBox
            // 
            username_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            username_textBox.Location = new Point(26, 36);
            username_textBox.Name = "username_textBox";
            username_textBox.Size = new Size(174, 23);
            username_textBox.TabIndex = 1;
            // 
            // password_textBox
            // 
            password_textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            password_textBox.Location = new Point(29, 95);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(174, 23);
            password_textBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 77);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // login_Button
            // 
            login_Button.Location = new Point(29, 134);
            login_Button.Name = "login_Button";
            login_Button.Size = new Size(171, 49);
            login_Button.TabIndex = 4;
            login_Button.Text = "Login";
            login_Button.UseVisualStyleBackColor = true;
            login_Button.Click += login_Button_Click;
            // 
            // frmLoginAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(228, 195);
            Controls.Add(login_Button);
            Controls.Add(password_textBox);
            Controls.Add(label2);
            Controls.Add(username_textBox);
            Controls.Add(label1);
            Name = "frmLoginAccount";
            Text = "User Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox username_textBox;
        private TextBox password_textBox;
        private Label label2;
        private Button login_Button;
    }
}