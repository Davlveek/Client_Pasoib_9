namespace Client
{
    partial class ClientFrom
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
            this.MessageRichBox = new System.Windows.Forms.RichTextBox();
            this.HashButton = new System.Windows.Forms.Button();
            this.MessageHashTextBox = new System.Windows.Forms.TextBox();
            this.HashLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SignButton = new System.Windows.Forms.Button();
            this.DisconnectButton = new System.Windows.Forms.Button();
            this.ConnectButton = new System.Windows.Forms.Button();
            this.EncryptButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MessageRichBox
            // 
            this.MessageRichBox.Location = new System.Drawing.Point(12, 68);
            this.MessageRichBox.Name = "MessageRichBox";
            this.MessageRichBox.Size = new System.Drawing.Size(429, 240);
            this.MessageRichBox.TabIndex = 1;
            this.MessageRichBox.Text = "";
            // 
            // HashButton
            // 
            this.HashButton.Location = new System.Drawing.Point(212, 318);
            this.HashButton.Name = "HashButton";
            this.HashButton.Size = new System.Drawing.Size(75, 23);
            this.HashButton.TabIndex = 2;
            this.HashButton.Text = "Hash";
            this.HashButton.UseVisualStyleBackColor = true;
            this.HashButton.Click += new System.EventHandler(this.HashButton_Click);
            // 
            // MessageHashTextBox
            // 
            this.MessageHashTextBox.Location = new System.Drawing.Point(47, 347);
            this.MessageHashTextBox.Name = "MessageHashTextBox";
            this.MessageHashTextBox.ReadOnly = true;
            this.MessageHashTextBox.Size = new System.Drawing.Size(394, 20);
            this.MessageHashTextBox.TabIndex = 3;
            // 
            // HashLabel
            // 
            this.HashLabel.AutoSize = true;
            this.HashLabel.Location = new System.Drawing.Point(9, 350);
            this.HashLabel.Name = "HashLabel";
            this.HashLabel.Size = new System.Drawing.Size(32, 13);
            this.HashLabel.TabIndex = 4;
            this.HashLabel.Text = "Hash";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(93, 42);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(171, 20);
            this.AddressTextBox.TabIndex = 5;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(270, 42);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(171, 20);
            this.PortTextBox.TabIndex = 6;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(128, 18);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(91, 13);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Server IP address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port";
            // 
            // SignButton
            // 
            this.SignButton.Location = new System.Drawing.Point(47, 318);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(75, 23);
            this.SignButton.TabIndex = 12;
            this.SignButton.Text = "Sign";
            this.SignButton.UseVisualStyleBackColor = true;
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // DisconnectButton
            // 
            this.DisconnectButton.Location = new System.Drawing.Point(12, 42);
            this.DisconnectButton.Name = "DisconnectButton";
            this.DisconnectButton.Size = new System.Drawing.Size(75, 23);
            this.DisconnectButton.TabIndex = 13;
            this.DisconnectButton.Text = "Disconnect";
            this.DisconnectButton.UseVisualStyleBackColor = true;
            this.DisconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // ConnectButton
            // 
            this.ConnectButton.Location = new System.Drawing.Point(12, 13);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 14;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // EncryptButton
            // 
            this.EncryptButton.Location = new System.Drawing.Point(131, 318);
            this.EncryptButton.Name = "EncryptButton";
            this.EncryptButton.Size = new System.Drawing.Size(75, 23);
            this.EncryptButton.TabIndex = 16;
            this.EncryptButton.Text = "Encrypt";
            this.EncryptButton.UseVisualStyleBackColor = true;
            this.EncryptButton.Click += new System.EventHandler(this.EncryptButton_Click);
            // 
            // ClientFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 376);
            this.Controls.Add(this.EncryptButton);
            this.Controls.Add(this.ConnectButton);
            this.Controls.Add(this.DisconnectButton);
            this.Controls.Add(this.SignButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.PortTextBox);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.HashLabel);
            this.Controls.Add(this.MessageHashTextBox);
            this.Controls.Add(this.HashButton);
            this.Controls.Add(this.MessageRichBox);
            this.Name = "ClientFrom";
            this.Text = "Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox MessageRichBox;
        private System.Windows.Forms.Button HashButton;
        private System.Windows.Forms.TextBox MessageHashTextBox;
        private System.Windows.Forms.Label HashLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SignButton;
        private System.Windows.Forms.Button DisconnectButton;
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button EncryptButton;
    }
}

