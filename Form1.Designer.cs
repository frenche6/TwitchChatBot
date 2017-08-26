namespace TwitchChatBot
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
            this.button1 = new System.Windows.Forms.Button();
            this.Textbox_ChannelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Textbox_Username = new System.Windows.Forms.TextBox();
            this.Textbox_Oath = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Textbox_Message = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Button_Disconnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Textbox_OutputLog = new System.Windows.Forms.Label();
            this.Button_ListenToChannel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Textbox_ChannelName
            // 
            this.Textbox_ChannelName.Location = new System.Drawing.Point(12, 37);
            this.Textbox_ChannelName.Name = "Textbox_ChannelName";
            this.Textbox_ChannelName.Size = new System.Drawing.Size(100, 20);
            this.Textbox_ChannelName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Channel Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Oath";
            // 
            // Textbox_Username
            // 
            this.Textbox_Username.Location = new System.Drawing.Point(12, 32);
            this.Textbox_Username.Name = "Textbox_Username";
            this.Textbox_Username.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Username.TabIndex = 5;
            // 
            // Textbox_Oath
            // 
            this.Textbox_Oath.Location = new System.Drawing.Point(12, 71);
            this.Textbox_Oath.Name = "Textbox_Oath";
            this.Textbox_Oath.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Oath.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Textbox_Username);
            this.groupBox1.Controls.Add(this.Textbox_Oath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect as someone else";
            // 
            // Textbox_Message
            // 
            this.Textbox_Message.Location = new System.Drawing.Point(12, 85);
            this.Textbox_Message.Name = "Textbox_Message";
            this.Textbox_Message.Size = new System.Drawing.Size(100, 20);
            this.Textbox_Message.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Message";
            // 
            // Button_Disconnect
            // 
            this.Button_Disconnect.Location = new System.Drawing.Point(49, 281);
            this.Button_Disconnect.Name = "Button_Disconnect";
            this.Button_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Button_Disconnect.TabIndex = 10;
            this.Button_Disconnect.Text = "Disconnect";
            this.Button_Disconnect.UseVisualStyleBackColor = true;
            this.Button_Disconnect.Click += new System.EventHandler(this.Button_Disconnect_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 352);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 171);
            this.textBox1.TabIndex = 11;
            // 
            // Textbox_OutputLog
            // 
            this.Textbox_OutputLog.AutoSize = true;
            this.Textbox_OutputLog.Location = new System.Drawing.Point(9, 336);
            this.Textbox_OutputLog.Name = "Textbox_OutputLog";
            this.Textbox_OutputLog.Size = new System.Drawing.Size(60, 13);
            this.Textbox_OutputLog.TabIndex = 12;
            this.Textbox_OutputLog.Text = "Output Log";
            // 
            // Button_ListenToChannel
            // 
            this.Button_ListenToChannel.Location = new System.Drawing.Point(136, 281);
            this.Button_ListenToChannel.Name = "Button_ListenToChannel";
            this.Button_ListenToChannel.Size = new System.Drawing.Size(75, 23);
            this.Button_ListenToChannel.TabIndex = 13;
            this.Button_ListenToChannel.Text = "Listen To Channel";
            this.Button_ListenToChannel.UseVisualStyleBackColor = true;
            this.Button_ListenToChannel.Click += new System.EventHandler(this.Button_ListenToChannel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 545);
            this.Controls.Add(this.Button_ListenToChannel);
            this.Controls.Add(this.Textbox_OutputLog);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Button_Disconnect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Textbox_Message);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Textbox_ChannelName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Textbox_ChannelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Textbox_Username;
        private System.Windows.Forms.TextBox Textbox_Oath;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Textbox_Message;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Button_Disconnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Textbox_OutputLog;
        private System.Windows.Forms.Button Button_ListenToChannel;
    }
}

