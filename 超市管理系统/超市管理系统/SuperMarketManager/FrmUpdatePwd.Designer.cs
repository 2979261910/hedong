namespace SuperMarketManager
{
    partial class FrmUpdatePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpdatePwd));
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnSure = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOldPwd = new SuperMarketCommon.SuperTextbox(this.components);
            this.txtNewPwd = new SuperMarketCommon.SuperTextbox(this.components);
            this.txtRePwd = new SuperMarketCommon.SuperTextbox(this.components);
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.Image = ((System.Drawing.Image)(resources.GetObject("btnCancle.Image")));
            this.btnCancle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancle.Location = new System.Drawing.Point(193, 170);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(114, 33);
            this.btnCancle.TabIndex = 7;
            this.btnCancle.Text = "取消修改";
            this.btnCancle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancle.UseVisualStyleBackColor = true;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnSure
            // 
            this.btnSure.Image = ((System.Drawing.Image)(resources.GetObject("btnSure.Image")));
            this.btnSure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSure.Location = new System.Drawing.Point(47, 170);
            this.btnSure.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSure.Name = "btnSure";
            this.btnSure.Size = new System.Drawing.Size(117, 33);
            this.btnSure.TabIndex = 6;
            this.btnSure.Text = "提交修改";
            this.btnSure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSure.UseVisualStyleBackColor = true;
            this.btnSure.Click += new System.EventHandler(this.btnSure_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(33, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "确认密码：";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(52, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "新密码：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "原密码：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtOldPwd
            // 
            this.txtOldPwd.Location = new System.Drawing.Point(128, 22);
            this.txtOldPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOldPwd.Multiline = true;
            this.txtOldPwd.Name = "txtOldPwd";
            this.txtOldPwd.PasswordChar = '●';
            this.txtOldPwd.Size = new System.Drawing.Size(174, 34);
            this.txtOldPwd.TabIndex = 3;
            // 
            // txtNewPwd
            // 
            this.txtNewPwd.Location = new System.Drawing.Point(127, 68);
            this.txtNewPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPwd.Multiline = true;
            this.txtNewPwd.Name = "txtNewPwd";
            this.txtNewPwd.PasswordChar = '●';
            this.txtNewPwd.Size = new System.Drawing.Size(174, 34);
            this.txtNewPwd.TabIndex = 4;
            // 
            // txtRePwd
            // 
            this.txtRePwd.Location = new System.Drawing.Point(126, 112);
            this.txtRePwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtRePwd.Multiline = true;
            this.txtRePwd.Name = "txtRePwd";
            this.txtRePwd.PasswordChar = '●';
            this.txtRePwd.Size = new System.Drawing.Size(174, 34);
            this.txtRePwd.TabIndex = 5;
            // 
            // FrmUpdatePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 225);
            this.Controls.Add(this.txtRePwd);
            this.Controls.Add(this.txtNewPwd);
            this.Controls.Add(this.txtOldPwd);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.btnSure);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmUpdatePwd";
            this.Text = "修改登录密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnSure;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SuperMarketCommon.SuperTextbox txtOldPwd;
        private SuperMarketCommon.SuperTextbox txtNewPwd;
        private SuperMarketCommon.SuperTextbox txtRePwd;
    }
}