namespace SuperMarketManager.AdminFrm
{
    partial class FrmLogCheck
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogCheck));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtWhere = new SuperMarketCommon.SuperTextbox(this.components);
            this.pageNav = new SuperMarketCommon.PageController();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LoginID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LogServer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoginTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginID,
            this.UserName,
            this.LogServer,
            this.LoginTime,
            this.ExitTime});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.Location = new System.Drawing.Point(3, 60);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("楷体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1098, 486);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(2, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "查询区间：";
            // 
            // startTime
            // 
            this.startTime.Location = new System.Drawing.Point(114, 21);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(200, 28);
            this.startTime.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(316, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "至";
            // 
            // endTime
            // 
            this.endTime.Location = new System.Drawing.Point(349, 20);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(200, 28);
            this.endTime.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(687, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "其他条件：";
            // 
            // btnCheck
            // 
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheck.Location = new System.Drawing.Point(997, 11);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(122, 42);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "开始查询";
            this.btnCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtWhere
            // 
            this.txtWhere.Location = new System.Drawing.Point(799, 19);
            this.txtWhere.Multiline = true;
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(182, 30);
            this.txtWhere.TabIndex = 2;
            this.txtWhere.Tag = "1";
            this.txtWhere.Text = "姓名、账号、服务器";
            // 
            // pageNav
            // 
            this.pageNav.CurrentPage = 1;
            this.pageNav.Location = new System.Drawing.Point(34, 543);
            this.pageNav.Name = "pageNav";
            this.pageNav.PageSize = 0;
            this.pageNav.ProcName = null;
            this.pageNav.RecordCount = 0;
            this.pageNav.Size = new System.Drawing.Size(979, 68);
            this.pageNav.SortType = SuperMarketCommon.SortType.ASC;
            this.pageNav.TabIndex = 9;
            this.pageNav.TableName = null;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(553, 24);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 22);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "是否选择区间";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // LoginID
            // 
            this.LoginID.DataPropertyName = "LoginId";
            this.LoginID.HeaderText = "登录账号";
            this.LoginID.MinimumWidth = 8;
            this.LoginID.Name = "LoginID";
            this.LoginID.ReadOnly = true;
            this.LoginID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoginID.Width = 150;
            // 
            // UserName
            // 
            this.UserName.DataPropertyName = "SPName";
            this.UserName.HeaderText = "登录名称";
            this.UserName.MinimumWidth = 8;
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.UserName.Width = 150;
            // 
            // LogServer
            // 
            this.LogServer.DataPropertyName = "ServerName";
            this.LogServer.HeaderText = "登录服务器";
            this.LogServer.MinimumWidth = 8;
            this.LogServer.Name = "LogServer";
            this.LogServer.ReadOnly = true;
            this.LogServer.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LogServer.Width = 150;
            // 
            // LoginTime
            // 
            this.LoginTime.DataPropertyName = "LoginTime";
            this.LoginTime.HeaderText = "登录时间";
            this.LoginTime.MinimumWidth = 8;
            this.LoginTime.Name = "LoginTime";
            this.LoginTime.ReadOnly = true;
            this.LoginTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoginTime.Width = 150;
            // 
            // ExitTime
            // 
            this.ExitTime.DataPropertyName = "ExitTime";
            this.ExitTime.HeaderText = "退出系统时间";
            this.ExitTime.MinimumWidth = 8;
            this.ExitTime.Name = "ExitTime";
            this.ExitTime.ReadOnly = true;
            this.ExitTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ExitTime.Width = 150;
            // 
            // FrmLogCheck
            // 
            this.AcceptButton = this.btnCheck;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 616);
            this.Controls.Add(this.txtWhere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.endTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.startTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pageNav);
            this.Controls.Add(this.checkBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLogCheck";
            this.Text = "日志查看";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker startTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endTime;
        private System.Windows.Forms.Label label3;
        private SuperMarketCommon.SuperTextbox txtWhere;
        private System.Windows.Forms.Button btnCheck;
        private SuperMarketCommon.PageController pageNav;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExitTime;
    }
}