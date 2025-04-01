namespace PacketListener
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
            tabControl1 = new TabControl();
            startPage = new TabPage();
            resultLbl = new Label();
            button1 = new Button();
            slCheckBox = new CheckBox();
            portTB = new TextBox();
            label4 = new Label();
            ipTB = new TextBox();
            tarServIPlabel = new Label();
            pkPage = new TabPage();
            btnClient = new Button();
            btnServer = new Button();
            label3 = new Label();
            cPacketTB = new TextBox();
            label2 = new Label();
            label1 = new Label();
            clientTB = new TextBox();
            serverTB = new TextBox();
            tabControl1.SuspendLayout();
            startPage.SuspendLayout();
            pkPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(startPage);
            tabControl1.Controls.Add(pkPage);
            tabControl1.ItemSize = new Size(67, 20);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(974, 544);
            tabControl1.TabIndex = 0;
            // 
            // startPage
            // 
            startPage.Controls.Add(resultLbl);
            startPage.Controls.Add(button1);
            startPage.Controls.Add(slCheckBox);
            startPage.Controls.Add(portTB);
            startPage.Controls.Add(label4);
            startPage.Controls.Add(ipTB);
            startPage.Controls.Add(tarServIPlabel);
            startPage.Location = new Point(4, 24);
            startPage.Name = "startPage";
            startPage.Padding = new Padding(3);
            startPage.Size = new Size(966, 516);
            startPage.TabIndex = 1;
            startPage.Text = "Initialisation/Setting";
            startPage.UseVisualStyleBackColor = true;
            // 
            // resultLbl
            // 
            resultLbl.AutoSize = true;
            resultLbl.Font = new Font("Microsoft JhengHei UI", 16F);
            resultLbl.Location = new Point(27, 244);
            resultLbl.Name = "resultLbl";
            resultLbl.Size = new Size(0, 28);
            resultLbl.TabIndex = 8;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 18F);
            button1.Location = new Point(23, 161);
            button1.Name = "button1";
            button1.Size = new Size(918, 50);
            button1.TabIndex = 7;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // slCheckBox
            // 
            slCheckBox.AutoSize = true;
            slCheckBox.CheckAlign = ContentAlignment.MiddleRight;
            slCheckBox.Font = new Font("Microsoft JhengHei UI", 18F);
            slCheckBox.ImageAlign = ContentAlignment.MiddleLeft;
            slCheckBox.Location = new Point(23, 430);
            slCheckBox.Name = "slCheckBox";
            slCheckBox.Size = new Size(184, 34);
            slCheckBox.TabIndex = 6;
            slCheckBox.Text = "Stop Logging";
            slCheckBox.UseVisualStyleBackColor = true;
            // 
            // portTB
            // 
            portTB.Font = new Font("Microsoft JhengHei UI", 23F);
            portTB.Location = new Point(299, 90);
            portTB.Name = "portTB";
            portTB.Size = new Size(135, 46);
            portTB.TabIndex = 3;
            portTB.TextChanged += portTB_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 23F);
            label4.Location = new Point(23, 90);
            label4.Name = "label4";
            label4.Size = new Size(204, 40);
            label4.TabIndex = 2;
            label4.Text = "Target Port : ";
            // 
            // ipTB
            // 
            ipTB.Font = new Font("Microsoft JhengHei UI", 23F);
            ipTB.Location = new Point(299, 19);
            ipTB.Name = "ipTB";
            ipTB.Size = new Size(339, 46);
            ipTB.TabIndex = 1;
            // 
            // tarServIPlabel
            // 
            tarServIPlabel.AutoSize = true;
            tarServIPlabel.Font = new Font("Microsoft JhengHei UI", 23F);
            tarServIPlabel.Location = new Point(23, 22);
            tarServIPlabel.Name = "tarServIPlabel";
            tarServIPlabel.Size = new Size(270, 40);
            tarServIPlabel.TabIndex = 0;
            tarServIPlabel.Text = "Target Server IP : ";
            // 
            // pkPage
            // 
            pkPage.Controls.Add(btnClient);
            pkPage.Controls.Add(btnServer);
            pkPage.Controls.Add(label3);
            pkPage.Controls.Add(cPacketTB);
            pkPage.Controls.Add(label2);
            pkPage.Controls.Add(label1);
            pkPage.Controls.Add(clientTB);
            pkPage.Controls.Add(serverTB);
            pkPage.Location = new Point(4, 24);
            pkPage.Name = "pkPage";
            pkPage.Padding = new Padding(3);
            pkPage.Size = new Size(966, 516);
            pkPage.TabIndex = 0;
            pkPage.Text = "PacketControl";
            pkPage.UseVisualStyleBackColor = true;
            // 
            // btnClient
            // 
            btnClient.Location = new Point(759, 147);
            btnClient.Name = "btnClient";
            btnClient.Size = new Size(201, 30);
            btnClient.TabIndex = 7;
            btnClient.Text = "Send Custom Packet to Client";
            btnClient.UseVisualStyleBackColor = true;
            btnClient.Click += btnClient_Click;
            // 
            // btnServer
            // 
            btnServer.Location = new Point(272, 147);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(201, 30);
            btnServer.TabIndex = 6;
            btnServer.Text = "Send Custom Packet to Server";
            btnServer.UseVisualStyleBackColor = true;
            btnServer.Click += btnServer_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 21F);
            label3.Location = new Point(6, 9);
            label3.Name = "label3";
            label3.Size = new Size(212, 36);
            label3.TabIndex = 5;
            label3.Text = "Custom Packet";
            // 
            // cPacketTB
            // 
            cPacketTB.Location = new Point(6, 48);
            cPacketTB.Multiline = true;
            cPacketTB.Name = "cPacketTB";
            cPacketTB.Size = new Size(954, 93);
            cPacketTB.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 21F);
            label2.Location = new Point(493, 144);
            label2.Name = "label2";
            label2.Size = new Size(217, 36);
            label2.TabIndex = 3;
            label2.Text = "Client Received";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 21F);
            label1.Location = new Point(6, 144);
            label1.Name = "label1";
            label1.Size = new Size(223, 36);
            label1.TabIndex = 2;
            label1.Text = "Server Received";
            // 
            // clientTB
            // 
            clientTB.BackColor = SystemColors.ScrollBar;
            clientTB.Location = new Point(493, 183);
            clientTB.Multiline = true;
            clientTB.Name = "clientTB";
            clientTB.ReadOnly = true;
            clientTB.ScrollBars = ScrollBars.Vertical;
            clientTB.Size = new Size(467, 327);
            clientTB.TabIndex = 1;
            // 
            // serverTB
            // 
            serverTB.BackColor = SystemColors.ScrollBar;
            serverTB.Location = new Point(6, 183);
            serverTB.Multiline = true;
            serverTB.Name = "serverTB";
            serverTB.ReadOnly = true;
            serverTB.ScrollBars = ScrollBars.Vertical;
            serverTB.Size = new Size(467, 327);
            serverTB.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 568);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            startPage.ResumeLayout(false);
            startPage.PerformLayout();
            pkPage.ResumeLayout(false);
            pkPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage pkPage;
        private TextBox serverTB;
        private TabPage startPage;
        private Label label2;
        private Label label1;
        private TextBox clientTB;
        private TextBox cPacketTB;
        private Button btnClient;
        private Button btnServer;
        private Label label3;
        private TextBox ipTB;
        private Label tarServIPlabel;
        private TextBox portTB;
        private Label label4;
        private Button button1;
        private CheckBox slCheckBox;
        private Label resultLbl;
    }
}
