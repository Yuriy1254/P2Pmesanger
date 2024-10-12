namespace MV2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            textField = new TextBox();
            ipField = new TextBox();
            ownIp = new Label();
            ipLabel = new Label();
            sendButton = new Button();
            messagesTextBox = new TextBox();
            contactsLabel = new Label();
            SuspendLayout();
            // 
            // textField
            // 
            textField.Location = new Point(369, 388);
            textField.Margin = new Padding(4, 5, 4, 5);
            textField.Multiline = true;
            textField.Name = "textField";
            textField.Size = new Size(572, 35);
            textField.TabIndex = 0;
            // 
            // ipField
            // 
            ipField.Location = new Point(16, 38);
            ipField.Margin = new Padding(4, 5, 4, 5);
            ipField.Name = "ipField";
            ipField.Size = new Size(345, 27);
            ipField.TabIndex = 2;
            // 
            // ownIp
            // 
            ownIp.AutoSize = true;
            ownIp.Location = new Point(16, 74);
            ownIp.Margin = new Padding(4, 0, 4, 0);
            ownIp.Name = "ownIp";
            ownIp.Size = new Size(70, 20);
            ownIp.TabIndex = 3;
            ownIp.Text = "Your IP: ...";
            // 
            // ipLabel
            // 
            ipLabel.AutoSize = true;
            ipLabel.Location = new Point(16, 14);
            ipLabel.Margin = new Padding(4, 0, 4, 0);
            ipLabel.Name = "ipLabel";
            ipLabel.Size = new Size(151, 20);
            ipLabel.TabIndex = 1;
            ipLabel.Text = "Enter Peer IP Address:";
            // 
            // sendButton
            // 
            sendButton.Location = new Point(841, 388);
            sendButton.Margin = new Padding(4, 5, 4, 5);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(100, 35);
            sendButton.TabIndex = 6;
            sendButton.Text = "Send";
            sendButton.UseVisualStyleBackColor = true;
            sendButton.Click += SendButton_Click;
            // 
            // messagesTextBox
            // 
            messagesTextBox.Location = new Point(369, 14);
            messagesTextBox.Margin = new Padding(4, 5, 4, 5);
            messagesTextBox.Multiline = true;
            messagesTextBox.Name = "messagesTextBox";
            messagesTextBox.ReadOnly = true;
            messagesTextBox.Size = new Size(572, 351);
            messagesTextBox.TabIndex = 5;
            // 
            // contactsLabel
            // 
            contactsLabel.AutoSize = true;
            contactsLabel.Location = new Point(16, 109);
            contactsLabel.Margin = new Padding(4, 0, 4, 0);
            contactsLabel.Name = "contactsLabel";
            contactsLabel.Size = new Size(207, 20);
            contactsLabel.TabIndex = 4;
            contactsLabel.Text = "Here will be contacts in future";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 489);
            Controls.Add(sendButton);
            Controls.Add(messagesTextBox);
            Controls.Add(contactsLabel);
            Controls.Add(ownIp);
            Controls.Add(ipField);
            Controls.Add(ipLabel);
            Controls.Add(textField);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "P2P Messenger";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textField; // Поле для введення повідомлення
        private System.Windows.Forms.TextBox ipField; // Поле для введення IP співрозмовника
        private System.Windows.Forms.Label ownIp; // Мітка для власної IP
        private System.Windows.Forms.Label ipLabel; // Мітка для введення IP
        private System.Windows.Forms.Button sendButton; // Кнопка для відправлення повідомлення
        private System.Windows.Forms.TextBox messagesTextBox; // Поле для відображення повідомлень
        private System.Windows.Forms.Label contactsLabel; // Мітка для контактів
    }
}
