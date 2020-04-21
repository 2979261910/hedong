namespace SuperMarketManager.AdminFrm
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AdminId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdminStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnStartSysAdm = new System.Windows.Forms.Button();
            this.btnStopSysAdm = new System.Windows.Forms.Button();
            this.btnUpdateSysAdm = new System.Windows.Forms.Button();
            this.btnAddSysAdm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdminId,
            this.AdminName,
            this.AdminType,
            this.AdminStatus});
            this.dataGridView1.Location = new System.Drawing.Point(41, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1052, 595);
            this.dataGridView1.TabIndex = 6;
            // 
            // AdminId
            // 
            this.AdminId.HeaderText = "登录账号";
            this.AdminId.MinimumWidth = 8;
            this.AdminId.Name = "AdminId";
            this.AdminId.ReadOnly = true;
            this.AdminId.Width = 150;
            // 
            // AdminName
            // 
            this.AdminName.HeaderText = "用户名称";
            this.AdminName.MinimumWidth = 8;
            this.AdminName.Name = "AdminName";
            this.AdminName.ReadOnly = true;
            this.AdminName.Width = 150;
            // 
            // AdminType
            // 
            this.AdminType.HeaderText = "用户类型";
            this.AdminType.MinimumWidth = 8;
            this.AdminType.Name = "AdminType";
            this.AdminType.ReadOnly = true;
            this.AdminType.Width = 150;
            // 
            // AdminStatus
            // 
            this.AdminStatus.HeaderText = "当前状态";
            this.AdminStatus.MinimumWidth = 8;
            this.AdminStatus.Name = "AdminStatus";
            this.AdminStatus.ReadOnly = true;
            this.AdminStatus.Width = 150;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(945, 19);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(147, 45);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnStartSysAdm
            // 
            this.btnStartSysAdm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartSysAdm.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnStartSysAdm.Image = ((System.Drawing.Image)(resources.GetObject("btnStartSysAdm.Image")));
            this.btnStartSysAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStartSysAdm.Location = new System.Drawing.Point(548, 22);
            this.btnStartSysAdm.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartSysAdm.Name = "btnStartSysAdm";
            this.btnStartSysAdm.Size = new System.Drawing.Size(108, 42);
            this.btnStartSysAdm.TabIndex = 10;
            this.btnStartSysAdm.Text = "启用";
            this.btnStartSysAdm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStartSysAdm.UseVisualStyleBackColor = true;
            this.btnStartSysAdm.Click += new System.EventHandler(this.btnStartSysAdm_Click);
            // 
            // btnStopSysAdm
            // 
            this.btnStopSysAdm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStopSysAdm.ForeColor = System.Drawing.Color.Red;
            this.btnStopSysAdm.Image = ((System.Drawing.Image)(resources.GetObject("btnStopSysAdm.Image")));
            this.btnStopSysAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStopSysAdm.Location = new System.Drawing.Point(368, 22);
            this.btnStopSysAdm.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopSysAdm.Name = "btnStopSysAdm";
            this.btnStopSysAdm.Size = new System.Drawing.Size(108, 42);
            this.btnStopSysAdm.TabIndex = 9;
            this.btnStopSysAdm.Text = "禁用";
            this.btnStopSysAdm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStopSysAdm.UseVisualStyleBackColor = true;
            this.btnStopSysAdm.Click += new System.EventHandler(this.btnStopSysAdm_Click);
            // 
            // btnUpdateSysAdm
            // 
            this.btnUpdateSysAdm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateSysAdm.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateSysAdm.Image")));
            this.btnUpdateSysAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateSysAdm.Location = new System.Drawing.Point(207, 22);
            this.btnUpdateSysAdm.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateSysAdm.Name = "btnUpdateSysAdm";
            this.btnUpdateSysAdm.Size = new System.Drawing.Size(108, 42);
            this.btnUpdateSysAdm.TabIndex = 8;
            this.btnUpdateSysAdm.Text = "修改";
            this.btnUpdateSysAdm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateSysAdm.UseVisualStyleBackColor = true;
            this.btnUpdateSysAdm.Click += new System.EventHandler(this.btnUpdateSysAdm_Click);
            // 
            // btnAddSysAdm
            // 
            this.btnAddSysAdm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAddSysAdm.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSysAdm.Image")));
            this.btnAddSysAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddSysAdm.Location = new System.Drawing.Point(53, 22);
            this.btnAddSysAdm.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddSysAdm.Name = "btnAddSysAdm";
            this.btnAddSysAdm.Size = new System.Drawing.Size(108, 42);
            this.btnAddSysAdm.TabIndex = 7;
            this.btnAddSysAdm.Text = "添加";
            this.btnAddSysAdm.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddSysAdm.UseVisualStyleBackColor = true;
            this.btnAddSysAdm.Click += new System.EventHandler(this.btnAddSysAdm_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 695);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnStartSysAdm);
            this.Controls.Add(this.btnStopSysAdm);
            this.Controls.Add(this.btnUpdateSysAdm);
            this.Controls.Add(this.btnAddSysAdm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmAdmin";
            this.Text = "用户管理";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminId;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdminStatus;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnStartSysAdm;
        private System.Windows.Forms.Button btnStopSysAdm;
        private System.Windows.Forms.Button btnUpdateSysAdm;
        private System.Windows.Forms.Button btnAddSysAdm;
    }
}