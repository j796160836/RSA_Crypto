namespace RSA_Crypto
{
    partial class Form1
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
            this.public_text = new System.Windows.Forms.TextBox();
            this.msg_text = new System.Windows.Forms.TextBox();
            this.encrypt_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.crypt_text = new System.Windows.Forms.TextBox();
            this.private_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.org_text = new System.Windows.Forms.TextBox();
            this.decrypt_button = new System.Windows.Forms.Button();
            this.generate_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // public_text
            // 
            this.public_text.Location = new System.Drawing.Point(13, 43);
            this.public_text.Multiline = true;
            this.public_text.Name = "public_text";
            this.public_text.Size = new System.Drawing.Size(425, 109);
            this.public_text.TabIndex = 0;
            // 
            // msg_text
            // 
            this.msg_text.Location = new System.Drawing.Point(70, 158);
            this.msg_text.Name = "msg_text";
            this.msg_text.Size = new System.Drawing.Size(285, 22);
            this.msg_text.TabIndex = 1;
            this.msg_text.Text = "Hello,World";
            // 
            // encrypt_button
            // 
            this.encrypt_button.Location = new System.Drawing.Point(361, 158);
            this.encrypt_button.Name = "encrypt_button";
            this.encrypt_button.Size = new System.Drawing.Size(75, 23);
            this.encrypt_button.TabIndex = 2;
            this.encrypt_button.Text = "Encrypt";
            this.encrypt_button.UseVisualStyleBackColor = true;
            this.encrypt_button.Click += new System.EventHandler(this.encrypt_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Public Key:";
            // 
            // crypt_text
            // 
            this.crypt_text.Location = new System.Drawing.Point(12, 199);
            this.crypt_text.Name = "crypt_text";
            this.crypt_text.Size = new System.Drawing.Size(424, 22);
            this.crypt_text.TabIndex = 4;
            // 
            // private_text
            // 
            this.private_text.Location = new System.Drawing.Point(11, 263);
            this.private_text.Multiline = true;
            this.private_text.Name = "private_text";
            this.private_text.Size = new System.Drawing.Size(425, 101);
            this.private_text.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Private Key:";
            // 
            // org_text
            // 
            this.org_text.Location = new System.Drawing.Point(12, 387);
            this.org_text.Name = "org_text";
            this.org_text.Size = new System.Drawing.Size(343, 22);
            this.org_text.TabIndex = 7;
            // 
            // decrypt_button
            // 
            this.decrypt_button.Location = new System.Drawing.Point(361, 385);
            this.decrypt_button.Name = "decrypt_button";
            this.decrypt_button.Size = new System.Drawing.Size(75, 23);
            this.decrypt_button.TabIndex = 8;
            this.decrypt_button.Text = "Decrypt";
            this.decrypt_button.UseVisualStyleBackColor = true;
            this.decrypt_button.Click += new System.EventHandler(this.decrypt_button_Click);
            // 
            // generate_button
            // 
            this.generate_button.Location = new System.Drawing.Point(284, 12);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(154, 23);
            this.generate_button.TabIndex = 9;
            this.generate_button.Text = "Generate New KeyPair";
            this.generate_button.UseVisualStyleBackColor = true;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 424);
            this.Controls.Add(this.generate_button);
            this.Controls.Add(this.decrypt_button);
            this.Controls.Add(this.org_text);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.crypt_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.encrypt_button);
            this.Controls.Add(this.msg_text);
            this.Controls.Add(this.private_text);
            this.Controls.Add(this.public_text);
            this.Name = "Form1";
            this.Text = "RSA Crypto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox public_text;
        private System.Windows.Forms.TextBox msg_text;
        private System.Windows.Forms.Button encrypt_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox crypt_text;
        private System.Windows.Forms.TextBox private_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox org_text;
        private System.Windows.Forms.Button decrypt_button;
        private System.Windows.Forms.Button generate_button;
    }
}

