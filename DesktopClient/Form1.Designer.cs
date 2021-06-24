
namespace DesktopClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.getButton = new System.Windows.Forms.Button();
            this.setButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "State:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.ForeColor = System.Drawing.Color.Red;
            this.stateLabel.Location = new System.Drawing.Point(54, 9);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(79, 15);
            this.stateLabel.TabIndex = 1;
            this.stateLabel.Text = "Disconnected";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(139, 5);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 2;
            this.connectButton.Text = "&Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(6, 22);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(188, 23);
            this.nameBox.TabIndex = 4;
            this.nameBox.Text = "Anonymous";
            // 
            // getButton
            // 
            this.getButton.Location = new System.Drawing.Point(6, 51);
            this.getButton.Name = "getButton";
            this.getButton.Size = new System.Drawing.Size(89, 23);
            this.getButton.TabIndex = 5;
            this.getButton.Text = "&Get";
            this.getButton.UseVisualStyleBackColor = true;
            this.getButton.Click += new System.EventHandler(this.getButton_Click);
            // 
            // setButton
            // 
            this.setButton.Location = new System.Drawing.Point(105, 51);
            this.setButton.Name = "setButton";
            this.setButton.Size = new System.Drawing.Size(89, 23);
            this.setButton.TabIndex = 6;
            this.setButton.Text = "&Set";
            this.setButton.UseVisualStyleBackColor = true;
            this.setButton.Click += new System.EventHandler(this.setButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.setButton);
            this.groupBox1.Controls.Add(this.getButton);
            this.groupBox1.Location = new System.Drawing.Point(14, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 86);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.messageBox);
            this.groupBox2.Controls.Add(this.sendButton);
            this.groupBox2.Location = new System.Drawing.Point(14, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 142);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message";
            // 
            // messageBox
            // 
            this.messageBox.Location = new System.Drawing.Point(6, 22);
            this.messageBox.Multiline = true;
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(188, 85);
            this.messageBox.TabIndex = 4;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(105, 113);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(89, 23);
            this.sendButton.TabIndex = 5;
            this.sendButton.Text = "Sen&d";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(221, 5);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(377, 263);
            this.outputBox.TabIndex = 9;
            this.outputBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 276);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button getButton;
        private System.Windows.Forms.Button setButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.RichTextBox outputBox;
    }
}

