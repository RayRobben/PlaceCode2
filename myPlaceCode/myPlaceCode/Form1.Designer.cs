namespace myPlaceCode
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
            this.lblCoor = new System.Windows.Forms.Label();
            this.txtCoor = new System.Windows.Forms.TextBox();
            this.lblExp = new System.Windows.Forms.Label();
            this.lblCodeExp = new System.Windows.Forms.Label();
            this.btnGenCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCoor
            // 
            this.lblCoor.AutoSize = true;
            this.lblCoor.Location = new System.Drawing.Point(36, 48);
            this.lblCoor.Name = "lblCoor";
            this.lblCoor.Size = new System.Drawing.Size(41, 12);
            this.lblCoor.TabIndex = 0;
            this.lblCoor.Text = "坐标XY";
            // 
            // txtCoor
            // 
            this.txtCoor.Location = new System.Drawing.Point(97, 46);
            this.txtCoor.Name = "txtCoor";
            this.txtCoor.Size = new System.Drawing.Size(84, 21);
            this.txtCoor.TabIndex = 1;
            this.txtCoor.Text = "106.1256,28.32657";
            // 
            // lblExp
            // 
            this.lblExp.AutoSize = true;
            this.lblExp.Location = new System.Drawing.Point(36, 84);
            this.lblExp.Name = "lblExp";
            this.lblExp.Size = new System.Drawing.Size(53, 12);
            this.lblExp.TabIndex = 0;
            this.lblExp.Text = "编码输出";
            // 
            // lblCodeExp
            // 
            this.lblCodeExp.Location = new System.Drawing.Point(95, 84);
            this.lblCodeExp.Name = "lblCodeExp";
            this.lblCodeExp.Size = new System.Drawing.Size(248, 51);
            this.lblCodeExp.TabIndex = 0;
            // 
            // btnGenCode
            // 
            this.btnGenCode.Location = new System.Drawing.Point(55, 138);
            this.btnGenCode.Name = "btnGenCode";
            this.btnGenCode.Size = new System.Drawing.Size(80, 30);
            this.btnGenCode.TabIndex = 2;
            this.btnGenCode.Text = "生成编码";
            this.btnGenCode.UseVisualStyleBackColor = true;
            this.btnGenCode.Click += new System.EventHandler(this.btnGenCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 261);
            this.Controls.Add(this.btnGenCode);
            this.Controls.Add(this.txtCoor);
            this.Controls.Add(this.lblCodeExp);
            this.Controls.Add(this.lblExp);
            this.Controls.Add(this.lblCoor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCoor;
        private System.Windows.Forms.TextBox txtCoor;
        private System.Windows.Forms.Label lblExp;
        private System.Windows.Forms.Label lblCodeExp;
        private System.Windows.Forms.Button btnGenCode;
    }
}

