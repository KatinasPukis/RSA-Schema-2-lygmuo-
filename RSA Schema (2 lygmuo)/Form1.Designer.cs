namespace RSA_Schema__2_lygmuo_
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
            this.SendMessage = new System.Windows.Forms.Button();
            this.MessageTextBox = new System.Windows.Forms.RichTextBox();
            this.JustLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SendMessage
            // 
            this.SendMessage.Location = new System.Drawing.Point(137, 154);
            this.SendMessage.Name = "SendMessage";
            this.SendMessage.Size = new System.Drawing.Size(75, 23);
            this.SendMessage.TabIndex = 0;
            this.SendMessage.Text = "Send";
            this.SendMessage.UseVisualStyleBackColor = true;
            this.SendMessage.Click += new System.EventHandler(this.SendMessage_Click);
            // 
            // MessageTextBox
            // 
            this.MessageTextBox.Location = new System.Drawing.Point(41, 120);
            this.MessageTextBox.Name = "MessageTextBox";
            this.MessageTextBox.Size = new System.Drawing.Size(272, 28);
            this.MessageTextBox.TabIndex = 1;
            this.MessageTextBox.Text = "";
            // 
            // JustLabel
            // 
            this.JustLabel.AutoSize = true;
            this.JustLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JustLabel.Location = new System.Drawing.Point(37, 93);
            this.JustLabel.Name = "JustLabel";
            this.JustLabel.Size = new System.Drawing.Size(175, 24);
            this.JustLabel.TabIndex = 2;
            this.JustLabel.Text = "Message to send:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JustLabel);
            this.Controls.Add(this.MessageTextBox);
            this.Controls.Add(this.SendMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.RichTextBox MessageTextBox;
        private System.Windows.Forms.Label JustLabel;
    }
}

