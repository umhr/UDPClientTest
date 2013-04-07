namespace UDPTest
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.SendButton = new System.Windows.Forms.Button();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.recivePortTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.targetIPTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.targetPortTextBox = new System.Windows.Forms.TextBox();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SendButton
            // 
            this.SendButton.Location = new System.Drawing.Point(197, 60);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(75, 23);
            this.SendButton.TabIndex = 0;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(12, 89);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(260, 161);
            this.logTextBox.TabIndex = 1;
            // 
            // recivePortTextBox
            // 
            this.recivePortTextBox.Location = new System.Drawing.Point(141, 8);
            this.recivePortTextBox.Name = "recivePortTextBox";
            this.recivePortTextBox.Size = new System.Drawing.Size(50, 19);
            this.recivePortTextBox.TabIndex = 2;
            this.recivePortTextBox.Text = "8989";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(197, 6);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "IPAddress";
            // 
            // targetIPTextBox
            // 
            this.targetIPTextBox.Location = new System.Drawing.Point(69, 35);
            this.targetIPTextBox.Name = "targetIPTextBox";
            this.targetIPTextBox.Size = new System.Drawing.Size(85, 19);
            this.targetIPTextBox.TabIndex = 6;
            this.targetIPTextBox.Text = "192.168.0.255";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "送信先";
            // 
            // targetPortTextBox
            // 
            this.targetPortTextBox.Location = new System.Drawing.Point(160, 35);
            this.targetPortTextBox.Name = "targetPortTextBox";
            this.targetPortTextBox.Size = new System.Drawing.Size(50, 19);
            this.targetPortTextBox.TabIndex = 8;
            this.targetPortTextBox.Text = "7777";
            // 
            // messageTextBox
            // 
            this.messageTextBox.Location = new System.Drawing.Point(15, 60);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(174, 19);
            this.messageTextBox.TabIndex = 9;
            this.messageTextBox.Text = "Message";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.targetPortTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.targetIPTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.recivePortTextBox);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.SendButton);
            this.Name = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.TextBox recivePortTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox targetIPTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox targetPortTextBox;
        private System.Windows.Forms.TextBox messageTextBox;
    }
}

