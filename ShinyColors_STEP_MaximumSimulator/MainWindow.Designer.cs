
namespace ShinyColors_STEP_MaximumSimulator
{
    partial class MainWindow
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonExecute = new System.Windows.Forms.Button();
            this.textStatusLimit = new System.Windows.Forms.TextBox();
            this.textSkillLevel = new System.Windows.Forms.TextBox();
            this.textSkillPoint = new System.Windows.Forms.TextBox();
            this.textStatusCount = new System.Windows.Forms.TextBox();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.textStatusLimitCount = new System.Windows.Forms.TextBox();
            this.textResult = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonExecute
            // 
            this.buttonExecute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(91)))), ((int)(((byte)(236)))));
            this.buttonExecute.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonExecute.Location = new System.Drawing.Point(66, 513);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(473, 127);
            this.buttonExecute.TabIndex = 6;
            this.buttonExecute.Text = "じっこう";
            this.buttonExecute.UseVisualStyleBackColor = false;
            this.buttonExecute.Click += new System.EventHandler(this.ButtonExecuteClick);
            // 
            // textStatusLimit
            // 
            this.textStatusLimit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(66)))), ((int)(((byte)(117)))));
            this.textStatusLimit.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textStatusLimit.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textStatusLimit.Location = new System.Drawing.Point(318, 199);
            this.textStatusLimit.Name = "textStatusLimit";
            this.textStatusLimit.Size = new System.Drawing.Size(160, 37);
            this.textStatusLimit.TabIndex = 1;
            this.textStatusLimit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextStatusKeyPress);
            // 
            // textSkillLevel
            // 
            this.textSkillLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(66)))), ((int)(((byte)(117)))));
            this.textSkillLevel.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textSkillLevel.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textSkillLevel.Location = new System.Drawing.Point(66, 297);
            this.textSkillLevel.Name = "textSkillLevel";
            this.textSkillLevel.Size = new System.Drawing.Size(160, 37);
            this.textSkillLevel.TabIndex = 2;
            this.textSkillLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextStatusKeyPress);
            // 
            // textSkillPoint
            // 
            this.textSkillPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(66)))), ((int)(((byte)(117)))));
            this.textSkillPoint.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textSkillPoint.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textSkillPoint.Location = new System.Drawing.Point(318, 297);
            this.textSkillPoint.Name = "textSkillPoint";
            this.textSkillPoint.Size = new System.Drawing.Size(160, 37);
            this.textSkillPoint.TabIndex = 3;
            this.textSkillPoint.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextStatusKeyPress);
            // 
            // textStatusCount
            // 
            this.textStatusCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(66)))), ((int)(((byte)(117)))));
            this.textStatusCount.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textStatusCount.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textStatusCount.Location = new System.Drawing.Point(63, 402);
            this.textStatusCount.Name = "textStatusCount";
            this.textStatusCount.Size = new System.Drawing.Size(160, 37);
            this.textStatusCount.TabIndex = 4;
            this.textStatusCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextStatusKeyPress);
            // 
            // textStatus
            // 
            this.textStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(66)))), ((int)(((byte)(117)))));
            this.textStatus.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textStatus.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textStatus.Location = new System.Drawing.Point(63, 200);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(160, 37);
            this.textStatus.TabIndex = 0;
            this.textStatus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextStatusKeyPress);
            // 
            // textStatusLimitCount
            // 
            this.textStatusLimitCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(66)))), ((int)(((byte)(117)))));
            this.textStatusLimitCount.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textStatusLimitCount.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.textStatusLimitCount.Location = new System.Drawing.Point(318, 401);
            this.textStatusLimitCount.Name = "textStatusLimitCount";
            this.textStatusLimitCount.Size = new System.Drawing.Size(160, 37);
            this.textStatusLimitCount.TabIndex = 5;
            this.textStatusLimitCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextStatusKeyPress);
            // 
            // textResult
            // 
            this.textResult.BackColor = System.Drawing.Color.White;
            this.textResult.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textResult.Location = new System.Drawing.Point(652, 193);
            this.textResult.Multiline = true;
            this.textResult.Name = "textResult";
            this.textResult.ReadOnly = true;
            this.textResult.Size = new System.Drawing.Size(439, 454);
            this.textResult.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(39, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "特化ステータス値";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(303, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "特化ステータス上限";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(39, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "特化ステータスの熟練度";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(303, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 12;
            this.label4.Text = "団結力";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(39, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 30);
            this.label5.TabIndex = 13;
            this.label5.Text = "特化ステータスの成長回数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(303, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "特化ステータス上限の成長回数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("メイリオ", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(634, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 30);
            this.label7.TabIndex = 15;
            this.label7.Text = "けっか";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.Location = new System.Drawing.Point(112, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(582, 36);
            this.label8.TabIndex = 16;
            this.label8.Text = "6個のパラメータを入力して「じっこう」を押そう！";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("メイリオ", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label9.Location = new System.Drawing.Point(980, 769);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 24);
            this.label9.TabIndex = 17;
            this.label9.Text = "誰かUI直して...";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(1138, 818);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textResult);
            this.Controls.Add(this.textStatusLimitCount);
            this.Controls.Add(this.textStatus);
            this.Controls.Add(this.textStatusCount);
            this.Controls.Add(this.textSkillPoint);
            this.Controls.Add(this.textSkillLevel);
            this.Controls.Add(this.textStatusLimit);
            this.Controls.Add(this.buttonExecute);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "MainWindow";
            this.Text = "Shiny-Colors-STEP-maximum-simulator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextStatusKeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonExecute;
        private System.Windows.Forms.TextBox textStatusLimit;
        private System.Windows.Forms.TextBox textSkillLevel;
        private System.Windows.Forms.TextBox textSkillPoint;
        private System.Windows.Forms.TextBox textStatusCount;
        protected System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.TextBox textStatusLimitCount;
        private System.Windows.Forms.TextBox textResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

