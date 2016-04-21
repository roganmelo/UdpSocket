namespace UdpSocket
{
    partial class ServerForm
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
            this.BtnStartServer = new System.Windows.Forms.Button();
            this.ListServerInformations = new System.Windows.Forms.ListBox();
            this.BtnStopServer = new System.Windows.Forms.Button();
            this.TextBoxHostName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnStartServer
            // 
            this.BtnStartServer.Location = new System.Drawing.Point(12, 49);
            this.BtnStartServer.Name = "BtnStartServer";
            this.BtnStartServer.Size = new System.Drawing.Size(167, 75);
            this.BtnStartServer.TabIndex = 0;
            this.BtnStartServer.Text = "Start Server";
            this.BtnStartServer.UseVisualStyleBackColor = true;
            this.BtnStartServer.Click += new System.EventHandler(this.BtnStartServer_Click);
            // 
            // ListServerInformations
            // 
            this.ListServerInformations.FormattingEnabled = true;
            this.ListServerInformations.Location = new System.Drawing.Point(12, 134);
            this.ListServerInformations.Name = "ListServerInformations";
            this.ListServerInformations.Size = new System.Drawing.Size(353, 199);
            this.ListServerInformations.TabIndex = 1;
            // 
            // BtnStopServer
            // 
            this.BtnStopServer.Enabled = false;
            this.BtnStopServer.Location = new System.Drawing.Point(201, 49);
            this.BtnStopServer.Name = "BtnStopServer";
            this.BtnStopServer.Size = new System.Drawing.Size(164, 75);
            this.BtnStopServer.TabIndex = 2;
            this.BtnStopServer.Text = "Stop Server";
            this.BtnStopServer.UseVisualStyleBackColor = true;
            this.BtnStopServer.Click += new System.EventHandler(this.BtnStopServer_Click);
            // 
            // TextBoxHostName
            // 
            this.TextBoxHostName.Location = new System.Drawing.Point(12, 23);
            this.TextBoxHostName.Name = "TextBoxHostName";
            this.TextBoxHostName.Size = new System.Drawing.Size(167, 20);
            this.TextBoxHostName.TabIndex = 9;
            this.TextBoxHostName.Text = "localhost";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Host Name:";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Location = new System.Drawing.Point(201, 23);
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(164, 20);
            this.textBoxPort.TabIndex = 10;
            this.textBoxPort.Text = "3000";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Port:";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 342);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPort);
            this.Controls.Add(this.TextBoxHostName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStopServer);
            this.Controls.Add(this.ListServerInformations);
            this.Controls.Add(this.BtnStartServer);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStartServer;
        private System.Windows.Forms.ListBox ListServerInformations;
        private System.Windows.Forms.Button BtnStopServer;
        private System.Windows.Forms.TextBox TextBoxHostName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label label2;
    }
}

