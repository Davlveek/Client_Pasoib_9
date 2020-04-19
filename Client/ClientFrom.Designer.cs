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
            this.SendButton = new System.Windows.Forms.Button();
            this.MessageRichBox = new System.Windows.Forms.RichTextBox();
            this.HashButton = new System.Windows.Forms.Button();
            this.MessageHashTextBox = new System.Windows.Forms.TextBox();
            this.HashLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(52, 50);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // MessageRichBox
            // 
            this.MessageRichBox.Location = new System.Drawing.Point(52, 79);
            this.MessageRichBox.Name = "MessageRichBox";
            this.MessageRichBox.Size = new System.Drawing.Size(412, 240);
            this.MessageRichBox.TabIndex = 1;
            this.MessageRichBox.Text = "";
            // 
            // HashButton
            // 
            this.HashButton.Location = new System.Drawing.Point(133, 50);
            this.HashButton.Name = "HashButton";
            this.HashButton.Size = new System.Drawing.Size(75, 23);
            this.HashButton.TabIndex = 2;
            this.HashButton.Text = "Hash";
            this.HashButton.UseVisualStyleBackColor = true;
            this.HashButton.Click += new System.EventHandler(this.HashButton_Click);
            // 
            // MessageHashTextBox
            // 
            this.MessageHashTextBox.Location = new System.Drawing.Point(87, 325);
            this.MessageHashTextBox.Name = "MessageHashTextBox";
            this.MessageHashTextBox.ReadOnly = true;
            this.MessageHashTextBox.Size = new System.Drawing.Size(377, 20);
            this.MessageHashTextBox.TabIndex = 3;
            // 
            // HashLabel
            // 
            this.HashLabel.AutoSize = true;
            this.HashLabel.Location = new System.Drawing.Point(49, 328);
            this.HashLabel.Name = "HashLabel";
            this.HashLabel.Size = new System.Drawing.Size(32, 13);
            this.HashLabel.TabIndex = 4;
            this.HashLabel.Text = "Hash";
            // 
            // ClientFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HashLabel);
            this.Controls.Add(this.MessageHashTextBox);
            this.Controls.Add(this.HashButton);
            this.Controls.Add(this.MessageRichBox);
            this.Controls.Add(this.SendButton);
            this.Name = "ClientFrom";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.RichTextBox MessageRichBox;
        private System.Windows.Forms.Button HashButton;
        private System.Windows.Forms.TextBox MessageHashTextBox;
        private System.Windows.Forms.Label HashLabel;
    }
}

