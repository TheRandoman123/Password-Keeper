namespace Encriptor_And_Decriptor
{
    partial class Decriptor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Decriptor));
            this.label1 = new System.Windows.Forms.Label();
            this.file_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox_output = new System.Windows.Forms.TextBox();
            this.open_file = new System.Windows.Forms.OpenFileDialog();
            this.decript_and_encrypt_button = new System.Windows.Forms.Button();
            this.clear_textboxes = new System.Windows.Forms.Button();
            this.encrypt_checkbox = new System.Windows.Forms.CheckBox();
            this.decrypt_checkbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Do you want to Encrypt or Decrypt?";
            // 
            // file_textbox
            // 
            this.file_textbox.Location = new System.Drawing.Point(69, 110);
            this.file_textbox.Name = "file_textbox";
            this.file_textbox.Size = new System.Drawing.Size(179, 20);
            this.file_textbox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Or just enter in the text here\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(92, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "File Locator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output";
            // 
            // textbox_output
            // 
            this.textbox_output.Location = new System.Drawing.Point(11, 165);
            this.textbox_output.Multiline = true;
            this.textbox_output.Name = "textbox_output";
            this.textbox_output.Size = new System.Drawing.Size(302, 86);
            this.textbox_output.TabIndex = 6;
            // 
            // open_file
            // 
            this.open_file.FileName = "openFileDialog1";
            // 
            // decript_and_encrypt_button
            // 
            this.decript_and_encrypt_button.Location = new System.Drawing.Point(211, 136);
            this.decript_and_encrypt_button.Name = "decript_and_encrypt_button";
            this.decript_and_encrypt_button.Size = new System.Drawing.Size(102, 23);
            this.decript_and_encrypt_button.TabIndex = 7;
            this.decript_and_encrypt_button.Text = "Encrypt/Decrypt";
            this.decript_and_encrypt_button.UseVisualStyleBackColor = true;
            this.decript_and_encrypt_button.Click += new System.EventHandler(this.decript_and_encrypt_button_Click);
            // 
            // clear_textboxes
            // 
            this.clear_textboxes.Location = new System.Drawing.Point(11, 136);
            this.clear_textboxes.Name = "clear_textboxes";
            this.clear_textboxes.Size = new System.Drawing.Size(106, 23);
            this.clear_textboxes.TabIndex = 8;
            this.clear_textboxes.Text = "Clear Textboxes";
            this.clear_textboxes.UseVisualStyleBackColor = true;
            this.clear_textboxes.Click += new System.EventHandler(this.clear_textboxes_Click);
            // 
            // encrypt_checkbox
            // 
            this.encrypt_checkbox.AutoSize = true;
            this.encrypt_checkbox.Location = new System.Drawing.Point(37, 31);
            this.encrypt_checkbox.Name = "encrypt_checkbox";
            this.encrypt_checkbox.Size = new System.Drawing.Size(62, 17);
            this.encrypt_checkbox.TabIndex = 9;
            this.encrypt_checkbox.Text = "Encrypt";
            this.encrypt_checkbox.UseVisualStyleBackColor = true;
            // 
            // decrypt_checkbox
            // 
            this.decrypt_checkbox.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.decrypt_checkbox.AutoSize = true;
            this.decrypt_checkbox.Location = new System.Drawing.Point(211, 31);
            this.decrypt_checkbox.Name = "decrypt_checkbox";
            this.decrypt_checkbox.Size = new System.Drawing.Size(63, 17);
            this.decrypt_checkbox.TabIndex = 10;
            this.decrypt_checkbox.Text = "Decrypt";
            this.decrypt_checkbox.UseVisualStyleBackColor = true;
            // 
            // Decriptor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 263);
            this.Controls.Add(this.decrypt_checkbox);
            this.Controls.Add(this.encrypt_checkbox);
            this.Controls.Add(this.clear_textboxes);
            this.Controls.Add(this.decript_and_encrypt_button);
            this.Controls.Add(this.textbox_output);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.file_textbox);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Decriptor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decriptor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox file_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textbox_output;
        private System.Windows.Forms.OpenFileDialog open_file;
        private System.Windows.Forms.Button decript_and_encrypt_button;
        private System.Windows.Forms.Button clear_textboxes;
        private System.Windows.Forms.CheckBox encrypt_checkbox;
        private System.Windows.Forms.CheckBox decrypt_checkbox;
    }
}

