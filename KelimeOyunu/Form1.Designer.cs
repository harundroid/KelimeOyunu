namespace KelimeOyunu
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.question = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.answerA = new System.Windows.Forms.Button();
            this.answerB = new System.Windows.Forms.Button();
            this.answerC = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.question, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // question
            // 
            this.question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.question.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.question.Location = new System.Drawing.Point(23, 3);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(754, 89);
            this.question.TabIndex = 0;
            this.question.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.answerA, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.answerB, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.answerC, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 115);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(754, 332);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // answerA
            // 
            this.answerA.BackColor = System.Drawing.Color.White;
            this.answerA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerA.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.answerA.FlatAppearance.BorderSize = 3;
            this.answerA.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.answerA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.answerA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.answerA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerA.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.answerA.Location = new System.Drawing.Point(3, 3);
            this.answerA.Name = "answerA";
            this.answerA.Size = new System.Drawing.Size(748, 104);
            this.answerA.TabIndex = 0;
            this.answerA.Text = "button1";
            this.answerA.UseVisualStyleBackColor = false;
            this.answerA.Click += new System.EventHandler(this.answerA_Click);
            // 
            // answerB
            // 
            this.answerB.BackColor = System.Drawing.Color.White;
            this.answerB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerB.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.answerB.FlatAppearance.BorderSize = 3;
            this.answerB.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.answerB.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.answerB.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.answerB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerB.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.answerB.Location = new System.Drawing.Point(3, 113);
            this.answerB.Name = "answerB";
            this.answerB.Size = new System.Drawing.Size(748, 104);
            this.answerB.TabIndex = 1;
            this.answerB.Text = "button1";
            this.answerB.UseVisualStyleBackColor = false;
            this.answerB.Click += new System.EventHandler(this.answerB_Click);
            // 
            // answerC
            // 
            this.answerC.BackColor = System.Drawing.Color.White;
            this.answerC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.answerC.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.answerC.FlatAppearance.BorderSize = 3;
            this.answerC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Aqua;
            this.answerC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.answerC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.answerC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.answerC.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.answerC.Location = new System.Drawing.Point(3, 223);
            this.answerC.Name = "answerC";
            this.answerC.Size = new System.Drawing.Size(748, 106);
            this.answerC.TabIndex = 2;
            this.answerC.Text = "button1";
            this.answerC.UseVisualStyleBackColor = false;
            this.answerC.Click += new System.EventHandler(this.answerC_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Kelime Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox question;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button answerA;
        private System.Windows.Forms.Button answerB;
        private System.Windows.Forms.Button answerC;
    }
}

