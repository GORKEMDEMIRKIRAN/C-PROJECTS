namespace QuizShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.question_no = new System.Windows.Forms.Label();
            this.question_true = new System.Windows.Forms.Label();
            this.question_false = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.PictureBox();
            this.red = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 9);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(562, 253);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(615, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Soru No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(629, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Doğru:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(629, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Yanlış: ";
            // 
            // question_no
            // 
            this.question_no.AutoSize = true;
            this.question_no.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.question_no.Location = new System.Drawing.Point(729, 28);
            this.question_no.Name = "question_no";
            this.question_no.Size = new System.Drawing.Size(29, 33);
            this.question_no.TabIndex = 4;
            this.question_no.Text = "0";
            // 
            // question_true
            // 
            this.question_true.AutoSize = true;
            this.question_true.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.question_true.Location = new System.Drawing.Point(729, 83);
            this.question_true.Name = "question_true";
            this.question_true.Size = new System.Drawing.Size(29, 33);
            this.question_true.TabIndex = 5;
            this.question_true.Text = "0";
            // 
            // question_false
            // 
            this.question_false.AutoSize = true;
            this.question_false.Font = new System.Drawing.Font("Corbel", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.question_false.Location = new System.Drawing.Point(729, 134);
            this.question_false.Name = "question_false";
            this.question_false.Size = new System.Drawing.Size(29, 33);
            this.question_false.TabIndex = 6;
            this.question_false.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(612, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(707, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "label8";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(12, 268);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(289, 47);
            this.btnA.TabIndex = 9;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(307, 268);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(267, 47);
            this.btnB.TabIndex = 10;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(12, 321);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(289, 51);
            this.btnC.TabIndex = 11;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(307, 321);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(267, 51);
            this.btnD.TabIndex = 12;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(616, 205);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(142, 45);
            this.next.TabIndex = 13;
            this.next.Text = "next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // green
            // 
            this.green.Image = ((System.Drawing.Image)(resources.GetObject("green.Image")));
            this.green.Location = new System.Drawing.Point(580, 268);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(102, 104);
            this.green.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.green.TabIndex = 14;
            this.green.TabStop = false;
            this.green.Visible = false;
            // 
            // red
            // 
            this.red.Image = ((System.Drawing.Image)(resources.GetObject("red.Image")));
            this.red.Location = new System.Drawing.Point(688, 268);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(105, 104);
            this.red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.red.TabIndex = 15;
            this.red.TabStop = false;
            this.red.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 412);
            this.Controls.Add(this.red);
            this.Controls.Add(this.green);
            this.Controls.Add(this.next);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.question_false);
            this.Controls.Add(this.question_true);
            this.Controls.Add(this.question_no);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.red)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label question_no;
        private System.Windows.Forms.Label question_true;
        private System.Windows.Forms.Label question_false;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.PictureBox green;
        private System.Windows.Forms.PictureBox red;
    }
}

