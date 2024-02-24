namespace задание_1
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
            label1 = new Label();
            registrationButton = new Button();
            loginBox = new TextBox();
            passBox = new TextBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(195, 88);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 0;
            label1.Text = "логин";
            // 
            // registrationButton
            // 
            registrationButton.Location = new Point(305, 300);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(94, 29);
            registrationButton.TabIndex = 1;
            registrationButton.Text = "регистрация";
            registrationButton.UseVisualStyleBackColor = true;
            registrationButton.Click += registrationButton_Click;
            // 
            // loginBox
            // 
            loginBox.Location = new Point(337, 88);
            loginBox.Name = "loginBox";
            loginBox.Size = new Size(125, 27);
            loginBox.TabIndex = 2;
            // 
            // passBox
            // 
            passBox.Location = new Point(337, 166);
            passBox.Name = "passBox";
            passBox.Size = new Size(125, 27);
            passBox.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(466, 300);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "вход";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 166);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 3;
            label2.Text = "пороль";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 216);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(passBox);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(loginBox);
            Controls.Add(registrationButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button registrationButton;
        private TextBox loginBox;
        private TextBox passBox;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}
