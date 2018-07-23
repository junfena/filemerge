namespace mergefile
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.BTopenFile = new System.Windows.Forms.Button();
            this.textEfilePath = new DevExpress.XtraEditors.TextEdit();
            this.BTStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.destPath = new DevExpress.XtraEditors.TextEdit();
            this.openDest = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.exten = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEfilePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.destPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exten.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "请选择文件目录：";
            // 
            // BTopenFile
            // 
            this.BTopenFile.Location = new System.Drawing.Point(308, 19);
            this.BTopenFile.Name = "BTopenFile";
            this.BTopenFile.Size = new System.Drawing.Size(75, 23);
            this.BTopenFile.TabIndex = 1;
            this.BTopenFile.Text = "打开";
            this.BTopenFile.UseVisualStyleBackColor = true;
            this.BTopenFile.Click += new System.EventHandler(this.BTopenFile_Click);
            // 
            // textEfilePath
            // 
            this.textEfilePath.Location = new System.Drawing.Point(151, 22);
            this.textEfilePath.Name = "textEfilePath";
            this.textEfilePath.Size = new System.Drawing.Size(138, 20);
            this.textEfilePath.TabIndex = 2;
            // 
            // BTStart
            // 
            this.BTStart.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BTStart.Location = new System.Drawing.Point(308, 92);
            this.BTStart.Name = "BTStart";
            this.BTStart.Size = new System.Drawing.Size(75, 23);
            this.BTStart.TabIndex = 3;
            this.BTStart.Text = "开始合并";
            this.BTStart.UseVisualStyleBackColor = true;
            this.BTStart.Click += new System.EventHandler(this.BTStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "请选择需要保存的文件：";
            // 
            // destPath
            // 
            this.destPath.Location = new System.Drawing.Point(151, 58);
            this.destPath.Name = "destPath";
            this.destPath.Size = new System.Drawing.Size(138, 20);
            this.destPath.TabIndex = 5;
            // 
            // openDest
            // 
            this.openDest.Location = new System.Drawing.Point(308, 57);
            this.openDest.Name = "openDest";
            this.openDest.Size = new System.Drawing.Size(75, 23);
            this.openDest.TabIndex = 6;
            this.openDest.Text = "打开";
            this.openDest.UseVisualStyleBackColor = true;
            this.openDest.Click += new System.EventHandler(this.openDest_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "请填写文件的后缀名：";
            // 
            // exten
            // 
            this.exten.Location = new System.Drawing.Point(151, 89);
            this.exten.Name = "exten";
            this.exten.Size = new System.Drawing.Size(138, 20);
            this.exten.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 152);
            this.Controls.Add(this.exten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.openDest);
            this.Controls.Add(this.destPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTStart);
            this.Controls.Add(this.textEfilePath);
            this.Controls.Add(this.BTopenFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "文件合并";
            ((System.ComponentModel.ISupportInitialize)(this.textEfilePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.destPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exten.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTopenFile;
        private DevExpress.XtraEditors.TextEdit textEfilePath;
        private System.Windows.Forms.Button BTStart;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit destPath;
        private System.Windows.Forms.Button openDest;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit exten;
    }
}

