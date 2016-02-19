namespace SmartCar
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BackPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ParameterPanel = new System.Windows.Forms.Panel();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.LogGroupBox = new System.Windows.Forms.GroupBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.ControlGroupBox = new System.Windows.Forms.GroupBox();
            this.SensorStatus = new System.Windows.Forms.GroupBox();
            this.MonitorGroupBox = new System.Windows.Forms.GroupBox();
            this.BackPanel.SuspendLayout();
            this.ParameterPanel.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            this.LogGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackPanel
            // 
            this.BackPanel.AutoSize = true;
            this.BackPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackPanel.ColumnCount = 2;
            this.BackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.BackPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BackPanel.Controls.Add(this.ParameterPanel, 1, 0);
            this.BackPanel.Controls.Add(this.StatusPanel, 0, 1);
            this.BackPanel.Controls.Add(this.MonitorGroupBox, 0, 0);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackPanel.Location = new System.Drawing.Point(0, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.RowCount = 2;
            this.BackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.BackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.BackPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BackPanel.Size = new System.Drawing.Size(671, 518);
            this.BackPanel.TabIndex = 0;
            // 
            // ParameterPanel
            // 
            this.ParameterPanel.Controls.Add(this.ControlGroupBox);
            this.ParameterPanel.Controls.Add(this.SensorStatus);
            this.ParameterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ParameterPanel.Location = new System.Drawing.Point(506, 3);
            this.ParameterPanel.Name = "ParameterPanel";
            this.BackPanel.SetRowSpan(this.ParameterPanel, 2);
            this.ParameterPanel.Size = new System.Drawing.Size(162, 512);
            this.ParameterPanel.TabIndex = 0;
            // 
            // StatusPanel
            // 
            this.StatusPanel.Controls.Add(this.LogGroupBox);
            this.StatusPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StatusPanel.Location = new System.Drawing.Point(3, 365);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(497, 150);
            this.StatusPanel.TabIndex = 1;
            // 
            // LogGroupBox
            // 
            this.LogGroupBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LogGroupBox.Controls.Add(this.LogTextBox);
            this.LogGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogGroupBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.LogGroupBox.Location = new System.Drawing.Point(0, 0);
            this.LogGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.LogGroupBox.Name = "LogGroupBox";
            this.LogGroupBox.Padding = new System.Windows.Forms.Padding(0);
            this.LogGroupBox.Size = new System.Drawing.Size(497, 150);
            this.LogGroupBox.TabIndex = 0;
            this.LogGroupBox.TabStop = false;
            this.LogGroupBox.Text = "Log";
            // 
            // LogTextBox
            // 
            this.LogTextBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LogTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LogTextBox.Location = new System.Drawing.Point(0, 22);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(497, 128);
            this.LogTextBox.TabIndex = 1;
            // 
            // ControlGroupBox
            // 
            this.ControlGroupBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ControlGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ControlGroupBox.Location = new System.Drawing.Point(0, 238);
            this.ControlGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.ControlGroupBox.Name = "ControlGroupBox";
            this.ControlGroupBox.Size = new System.Drawing.Size(162, 274);
            this.ControlGroupBox.TabIndex = 1;
            this.ControlGroupBox.TabStop = false;
            this.ControlGroupBox.Text = "控制器";
            // 
            // SensorStatus
            // 
            this.SensorStatus.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SensorStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.SensorStatus.Location = new System.Drawing.Point(0, 0);
            this.SensorStatus.Margin = new System.Windows.Forms.Padding(0);
            this.SensorStatus.Name = "SensorStatus";
            this.SensorStatus.Size = new System.Drawing.Size(162, 235);
            this.SensorStatus.TabIndex = 0;
            this.SensorStatus.TabStop = false;
            this.SensorStatus.Text = "传感器信息";
            // 
            // MonitorGroupBox
            // 
            this.MonitorGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonitorGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MonitorGroupBox.Margin = new System.Windows.Forms.Padding(0);
            this.MonitorGroupBox.Name = "MonitorGroupBox";
            this.MonitorGroupBox.Size = new System.Drawing.Size(503, 362);
            this.MonitorGroupBox.TabIndex = 2;
            this.MonitorGroupBox.TabStop = false;
            this.MonitorGroupBox.Text = "模拟器";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 518);
            this.Controls.Add(this.BackPanel);
            this.Name = "Form1";
            this.Text = "智能车模拟器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.BackPanel.ResumeLayout(false);
            this.ParameterPanel.ResumeLayout(false);
            this.StatusPanel.ResumeLayout(false);
            this.LogGroupBox.ResumeLayout(false);
            this.LogGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BackPanel;
        private System.Windows.Forms.Panel ParameterPanel;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.GroupBox LogGroupBox;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.GroupBox ControlGroupBox;
        private System.Windows.Forms.GroupBox SensorStatus;
        private System.Windows.Forms.GroupBox MonitorGroupBox;
    }
}

