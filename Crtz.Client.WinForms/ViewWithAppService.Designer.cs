
namespace Crtz.Client.WinForms
{
    partial class ViewWithAppService
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
            this.BtnStartSignalR = new System.Windows.Forms.Button();
            this.BtnStopSignalR = new System.Windows.Forms.Button();
            this.BtnStartAutoTickerData = new System.Windows.Forms.Button();
            this.BtnStopAutoTickerData = new System.Windows.Forms.Button();
            this.BtnSendOneTicker = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Field_Return = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStartSignalR
            // 
            this.BtnStartSignalR.Location = new System.Drawing.Point(3, 3);
            this.BtnStartSignalR.Name = "BtnStartSignalR";
            this.BtnStartSignalR.Size = new System.Drawing.Size(96, 30);
            this.BtnStartSignalR.TabIndex = 0;
            this.BtnStartSignalR.Text = "Start SignalR";
            this.BtnStartSignalR.UseVisualStyleBackColor = true;
            this.BtnStartSignalR.Click += new System.EventHandler(this.BtnStartSignalR_Click);
            // 
            // BtnStopSignalR
            // 
            this.BtnStopSignalR.Location = new System.Drawing.Point(105, 3);
            this.BtnStopSignalR.Name = "BtnStopSignalR";
            this.BtnStopSignalR.Size = new System.Drawing.Size(96, 30);
            this.BtnStopSignalR.TabIndex = 0;
            this.BtnStopSignalR.Text = "Stop SignalR";
            this.BtnStopSignalR.UseVisualStyleBackColor = true;
            this.BtnStopSignalR.Click += new System.EventHandler(this.BtnStopSignalR_Click);
            // 
            // BtnStartAutoTickerData
            // 
            this.BtnStartAutoTickerData.Location = new System.Drawing.Point(207, 3);
            this.BtnStartAutoTickerData.Name = "BtnStartAutoTickerData";
            this.BtnStartAutoTickerData.Size = new System.Drawing.Size(126, 30);
            this.BtnStartAutoTickerData.TabIndex = 0;
            this.BtnStartAutoTickerData.Text = "Start Auto Ticker Data";
            this.BtnStartAutoTickerData.UseVisualStyleBackColor = true;
            this.BtnStartAutoTickerData.Click += new System.EventHandler(this.BtnStartAutoTickerData_Click);
            // 
            // BtnStopAutoTickerData
            // 
            this.BtnStopAutoTickerData.Location = new System.Drawing.Point(339, 3);
            this.BtnStopAutoTickerData.Name = "BtnStopAutoTickerData";
            this.BtnStopAutoTickerData.Size = new System.Drawing.Size(126, 30);
            this.BtnStopAutoTickerData.TabIndex = 0;
            this.BtnStopAutoTickerData.Text = "Stop Auto Ticker Data";
            this.BtnStopAutoTickerData.UseVisualStyleBackColor = true;
            this.BtnStopAutoTickerData.Click += new System.EventHandler(this.BtnStopAutoTickerData_Click);
            // 
            // BtnSendOneTicker
            // 
            this.BtnSendOneTicker.Location = new System.Drawing.Point(471, 3);
            this.BtnSendOneTicker.Name = "BtnSendOneTicker";
            this.BtnSendOneTicker.Size = new System.Drawing.Size(96, 30);
            this.BtnSendOneTicker.TabIndex = 0;
            this.BtnSendOneTicker.Text = "Send One Ticker";
            this.BtnSendOneTicker.UseVisualStyleBackColor = true;
            this.BtnSendOneTicker.Click += new System.EventHandler(this.BtnSendOneTicker_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Field_Return, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 301F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1183, 343);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnStartSignalR);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnSendOneTicker);
            this.panel1.Controls.Add(this.BtnStopAutoTickerData);
            this.panel1.Controls.Add(this.BtnStopSignalR);
            this.panel1.Controls.Add(this.BtnStartAutoTickerData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1177, 36);
            this.panel1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(853, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 30);
            this.button3.TabIndex = 0;
            this.button3.Text = "Do something";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(751, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 30);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add Message";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(629, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hello World Sync";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Field_Return
            // 
            this.Field_Return.AutoSize = true;
            this.Field_Return.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Field_Return.Location = new System.Drawing.Point(3, 42);
            this.Field_Return.Name = "Field_Return";
            this.Field_Return.Size = new System.Drawing.Size(1177, 301);
            this.Field_Return.TabIndex = 1;
            // 
            // ViewWithAppClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 343);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ViewWithAppClient";
            this.Text = "With AppService";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnStartSignalR;
        private System.Windows.Forms.Button BtnStopSignalR;
        private System.Windows.Forms.Button BtnStartAutoTickerData;
        private System.Windows.Forms.Button BtnStopAutoTickerData;
        private System.Windows.Forms.Button BtnSendOneTicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Field_Return;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}

