namespace SuperMarketManager.AdminFrm
{
    partial class FrmUpdateAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdateAdmin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAdmPwd = new SuperMarketCommon.SuperTextbox(this.components);
            this.txtAdmName = new SuperMarketCommon.SuperTextbox(this.components);
            this.lblLogId = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAdminRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSure = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAdmPwd);
            this.groupBox1.Controls.Add(this.txtAdmName);
            this.groupBox1.Controls.Add(this.lblLogId);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbAdminRole);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(28, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(471, 262);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "【用户信息】";
            // 
            // txtAdmPwd
            // 
            this.txtAdmPwd.Location = new System.Drawing.Point(144, 150);
            this.txtAdmPwd.Multiline = true;
            this.txtAdmPwd.Name = "txtAdmPwd";
            this.txtAdmPwd.PasswordChar = '*';
            this.txtAdmPwd.Size = new System.Drawing.Size(270, 44);
            this.txtAdmPwd.TabIndex = 10;
            this.txtAdmPwd.Text = "123456";
            // 
            // txtAdmName
            // 
            this.txtAdmName.Location = new System.Drawing.Point(144, 94);
            this.txtAdmName.Multiline = true;
            this.txtAdmName.Name = "txtAdmName";
            this.txtAdmName.Size = new System.Drawing.Size(270, 44);
            this.txtAdmName.TabIndex = 9;
            // 
            // lblLogId
            // 
            this.lblLogId.AutoSize = true;
            this.lblLogId.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLogId.Location = new System.Drawing.Point(146, 52);
            this.lblLogId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogId.Name = "lblLogId";
            this.lblLogId.Size = new System.Drawing.Size(60, 27);
            this.lblLogId.TabIndex = 8;
            this.lblLogId.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(40, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "登录账号：";
            // 
            // cmbAdminRole
            // 
            this.cmbAdminRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAdminRole.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbAdminRole.FormattingEnabled = true;
            this.cmbAdminRole.Items.AddRange(new object[] {
            "超级管理员",
            "一般管理员"});
            this.cmbAdminRole.Location = new System.Drawing.Point(144, 204);
            this.cmbAdminRole.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAdminRole.Name = "cmbAdminRole";
            this.cmbAdminRole.Size = new System.Drawing.Size(277, 35);
            this.cmbAdminRole.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(40, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 27);
            this.label3.TabIndex = 4;
            this.label3.Text = "用户类型：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(40, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "用户密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(40, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名称：";
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(258, 297);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(118, 34);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消修改";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSure
            // 
            this.btnSure.Image = ((System.Drawing.Image)(resources.GetObject("btnSure.Image")));
            this.btnSure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSure.Location = new System.Drawing.Point(110, 297);
            this.btnSure.Margin = new System.Windows.Forms.Padding(4);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(118, 34);
            this.btnSure.TabIndex = 9;
            this.btnSure.Text = "确认修改";
            this.btnSure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // FrmUpdateAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 349);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSure);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmUpdateAdmin";
            this.Text = "修改密码";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLogId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAdminRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSure;
        private SuperMarketCommon.SuperTextbox txtAdmPwd;
        private SuperMarketCommon.SuperTextbox txtAdmName;
    }
}