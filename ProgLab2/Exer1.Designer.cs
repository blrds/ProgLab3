namespace ProgLab2
{
    partial class Exer1
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
            this.back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Index = new System.Windows.Forms.Button();
            this.Season = new System.Windows.Forms.Button();
            this.Alphabet = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Parametrs = new System.Windows.Forms.Button();
            this.Winter = new System.Windows.Forms.CheckBox();
            this.Spring = new System.Windows.Forms.CheckBox();
            this.Summer = new System.Windows.Forms.CheckBox();
            this.Autumn = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(154, 410);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 2;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // Index
            // 
            this.Index.Location = new System.Drawing.Point(125, 31);
            this.Index.Name = "Index";
            this.Index.Size = new System.Drawing.Size(125, 33);
            this.Index.TabIndex = 5;
            this.Index.Text = "По длине";
            this.Index.UseVisualStyleBackColor = true;
            this.Index.Click += new System.EventHandler(this.Index_Click);
            // 
            // Season
            // 
            this.Season.Location = new System.Drawing.Point(125, 162);
            this.Season.Name = "Season";
            this.Season.Size = new System.Drawing.Size(125, 33);
            this.Season.TabIndex = 6;
            this.Season.Text = "По сезону";
            this.Season.UseVisualStyleBackColor = true;
            this.Season.Click += new System.EventHandler(this.Season_Click);
            // 
            // Alphabet
            // 
            this.Alphabet.Location = new System.Drawing.Point(125, 201);
            this.Alphabet.Name = "Alphabet";
            this.Alphabet.Size = new System.Drawing.Size(125, 33);
            this.Alphabet.TabIndex = 11;
            this.Alphabet.Text = "По алфавиту";
            this.Alphabet.UseVisualStyleBackColor = true;
            this.Alphabet.Click += new System.EventHandler(this.Alphabet_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 240);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(125, 266);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 20);
            this.textBox3.TabIndex = 13;
            // 
            // Parametrs
            // 
            this.Parametrs.Location = new System.Drawing.Point(125, 292);
            this.Parametrs.Name = "Parametrs";
            this.Parametrs.Size = new System.Drawing.Size(125, 33);
            this.Parametrs.TabIndex = 14;
            this.Parametrs.Text = "По параметрам";
            this.Parametrs.UseVisualStyleBackColor = true;
            this.Parametrs.Click += new System.EventHandler(this.Parametrs_Click);
            // 
            // Winter
            // 
            this.Winter.AutoSize = true;
            this.Winter.Location = new System.Drawing.Point(125, 70);
            this.Winter.Name = "Winter";
            this.Winter.Size = new System.Drawing.Size(53, 17);
            this.Winter.TabIndex = 15;
            this.Winter.Text = "Зима";
            this.Winter.UseVisualStyleBackColor = true;
            // 
            // Spring
            // 
            this.Spring.AutoSize = true;
            this.Spring.Location = new System.Drawing.Point(125, 93);
            this.Spring.Name = "Spring";
            this.Spring.Size = new System.Drawing.Size(57, 17);
            this.Spring.TabIndex = 16;
            this.Spring.Text = "Весна";
            this.Spring.UseVisualStyleBackColor = true;
            // 
            // Summer
            // 
            this.Summer.AutoSize = true;
            this.Summer.Location = new System.Drawing.Point(125, 116);
            this.Summer.Name = "Summer";
            this.Summer.Size = new System.Drawing.Size(51, 17);
            this.Summer.TabIndex = 17;
            this.Summer.Text = "Лето";
            this.Summer.UseVisualStyleBackColor = true;
            // 
            // Autumn
            // 
            this.Autumn.AutoSize = true;
            this.Autumn.Location = new System.Drawing.Point(125, 139);
            this.Autumn.Name = "Autumn";
            this.Autumn.Size = new System.Drawing.Size(58, 17);
            this.Autumn.TabIndex = 18;
            this.Autumn.Text = "Осень";
            this.Autumn.UseVisualStyleBackColor = true;
            // 
            // Exer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 450);
            this.Controls.Add(this.Autumn);
            this.Controls.Add(this.Summer);
            this.Controls.Add(this.Spring);
            this.Controls.Add(this.Winter);
            this.Controls.Add(this.Parametrs);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Alphabet);
            this.Controls.Add(this.Season);
            this.Controls.Add(this.Index);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.back);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Exer1";
            this.Text = "Exer1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exer1_FormClosing);
            this.Load += new System.EventHandler(this.Exer1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Index;
        private System.Windows.Forms.Button Season;
        private System.Windows.Forms.Button Alphabet;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button Parametrs;
        private System.Windows.Forms.CheckBox Winter;
        private System.Windows.Forms.CheckBox Spring;
        private System.Windows.Forms.CheckBox Summer;
        private System.Windows.Forms.CheckBox Autumn;
    }
}