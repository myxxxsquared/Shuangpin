namespace Shuangpin
{
	partial class FormMain
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
            this.pinyin = new System.Windows.Forms.Label();
            this.key = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pinyin
            // 
            this.pinyin.AutoSize = true;
            this.pinyin.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pinyin.Location = new System.Drawing.Point(109, 168);
            this.pinyin.Name = "pinyin";
            this.pinyin.Size = new System.Drawing.Size(163, 83);
            this.pinyin.TabIndex = 0;
            this.pinyin.Text = "拼音";
            this.pinyin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // key
            // 
            this.key.AutoSize = true;
            this.key.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.key.ForeColor = System.Drawing.Color.Red;
            this.key.Location = new System.Drawing.Point(109, 251);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(163, 83);
            this.key.TabIndex = 0;
            this.key.Text = "按键";
            this.key.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 150);
            this.label1.TabIndex = 0;
            this.label1.Text = "按任意键开始\r\n按\"1\"保存学习进度\r\n开始后请按下拼音所对应的按键\r\n按对自动下一个\r\n按错则显示正确拼音\r\n出错次数越多，拼音的出现次数也会越多";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 344);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pinyin);
            this.Name = "FormMain";
            this.Text = "双拼练习";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormMain_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label pinyin;
		private System.Windows.Forms.Label key;
        private System.Windows.Forms.Label label1;
    }
}

