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
            this.ipTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.certsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.MessageRichBox.Size = new System.Drawing.Size(439, 240);
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
            this.MessageHashTextBox.Size = new System.Drawing.Size(404, 20);
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
            // ipTextBox
            // 
            this.ipTextBox.Location = new System.Drawing.Point(214, 52);
            this.ipTextBox.Name = "ipTextBox";
            this.ipTextBox.Size = new System.Drawing.Size(171, 20);
            this.ipTextBox.TabIndex = 5;
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(391, 53);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 6;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(275, 36);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(431, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port";
            // 
            // certsListBox
            // 
            this.certsListBox.FormattingEnabled = true;
            this.certsListBox.Location = new System.Drawing.Point(497, 79);
            this.certsListBox.Name = "certsListBox";
            this.certsListBox.Size = new System.Drawing.Size(319, 238);
            this.certsListBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(607, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Certificates";
            // 
            // ClientFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.certsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.ipTextBox);
            this.Controls.Add(this.HashLabel);
            this.Controls.Add(this.MessageHashTextBox);
            this.Controls.Add(this.HashButton);
            this.Controls.Add(this.MessageRichBox);
            this.Controls.Add(this.SendButton);
            this.Name = "ClientFrom";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientFrom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.RichTextBox MessageRichBox;
        private System.Windows.Forms.Button HashButton;
        private System.Windows.Forms.TextBox MessageHashTextBox;
        private System.Windows.Forms.Label HashLabel;
        private System.Windows.Forms.TextBox ipTextBox;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox certsListBox;
        private System.Windows.Forms.Label label1;
    }
}

