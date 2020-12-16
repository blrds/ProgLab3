namespace ProgLab2
{
    partial class Exer2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.all = new System.Windows.Forms.RadioButton();
            this.birthday = new System.Windows.Forms.RadioButton();
            this.group = new System.Windows.Forms.RadioButton();
            this.surname = new System.Windows.Forms.RadioButton();
            this.course = new System.Windows.Forms.RadioButton();
            this.name = new System.Windows.Forms.RadioButton();
            this.patronomyc = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list = new System.Windows.Forms.RadioButton();
            this.count = new System.Windows.Forms.RadioButton();
            this.first = new System.Windows.Forms.RadioButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 479);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(100, 30);
            this.back.TabIndex = 2;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(6, 327);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(100, 30);
            this.Search.TabIndex = 7;
            this.Search.Text = "Искать";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Location = new System.Drawing.Point(218, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(113, 361);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.all);
            this.groupBox3.Controls.Add(this.birthday);
            this.groupBox3.Controls.Add(this.group);
            this.groupBox3.Controls.Add(this.surname);
            this.groupBox3.Controls.Add(this.course);
            this.groupBox3.Controls.Add(this.name);
            this.groupBox3.Controls.Add(this.patronomyc);
            this.groupBox3.Location = new System.Drawing.Point(6, 135);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 186);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // all
            // 
            this.all.AutoSize = true;
            this.all.Location = new System.Drawing.Point(5, 166);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(44, 17);
            this.all.TabIndex = 21;
            this.all.TabStop = true;
            this.all.Text = "Все";
            this.all.UseVisualStyleBackColor = true;
            // 
            // birthday
            // 
            this.birthday.AutoSize = true;
            this.birthday.Location = new System.Drawing.Point(6, 84);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(75, 30);
            this.birthday.TabIndex = 18;
            this.birthday.TabStop = true;
            this.birthday.Text = "Дата \r\nрождения";
            this.birthday.UseVisualStyleBackColor = true;
            // 
            // group
            // 
            this.group.AutoSize = true;
            this.group.Location = new System.Drawing.Point(6, 143);
            this.group.Name = "group";
            this.group.Size = new System.Drawing.Size(60, 17);
            this.group.TabIndex = 20;
            this.group.TabStop = true;
            this.group.Text = "Группа";
            this.group.UseVisualStyleBackColor = true;
            // 
            // surname
            // 
            this.surname.AutoSize = true;
            this.surname.Location = new System.Drawing.Point(6, 15);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(74, 17);
            this.surname.TabIndex = 15;
            this.surname.TabStop = true;
            this.surname.Text = "Фамилия";
            this.surname.UseVisualStyleBackColor = true;
            // 
            // course
            // 
            this.course.AutoSize = true;
            this.course.Location = new System.Drawing.Point(6, 120);
            this.course.Name = "course";
            this.course.Size = new System.Drawing.Size(49, 17);
            this.course.TabIndex = 19;
            this.course.TabStop = true;
            this.course.Text = "Курс";
            this.course.UseVisualStyleBackColor = true;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(6, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(47, 17);
            this.name.TabIndex = 16;
            this.name.TabStop = true;
            this.name.Text = "Имя";
            this.name.UseVisualStyleBackColor = true;
            // 
            // patronomyc
            // 
            this.patronomyc.AutoSize = true;
            this.patronomyc.Location = new System.Drawing.Point(6, 61);
            this.patronomyc.Name = "patronomyc";
            this.patronomyc.Size = new System.Drawing.Size(72, 17);
            this.patronomyc.TabIndex = 17;
            this.patronomyc.TabStop = true;
            this.patronomyc.Text = "Отчество";
            this.patronomyc.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.list);
            this.groupBox2.Controls.Add(this.count);
            this.groupBox2.Controls.Add(this.first);
            this.groupBox2.Location = new System.Drawing.Point(6, 45);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(100, 84);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // list
            // 
            this.list.AutoSize = true;
            this.list.Location = new System.Drawing.Point(5, 38);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(62, 17);
            this.list.TabIndex = 9;
            this.list.TabStop = true;
            this.list.Text = "Список";
            this.list.UseVisualStyleBackColor = true;
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(6, 15);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(59, 17);
            this.count.TabIndex = 8;
            this.count.TabStop = true;
            this.count.Text = "Кол-во";
            this.count.UseVisualStyleBackColor = true;
            // 
            // first
            // 
            this.first.AutoSize = true;
            this.first.Location = new System.Drawing.Point(5, 61);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(65, 17);
            this.first.TabIndex = 10;
            this.first.TabStop = true;
            this.first.Text = "Первый";
            this.first.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 420);
            this.listBox1.TabIndex = 13;
            // 
            // Exer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 521);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.back);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Exer2";
            this.Text = "Exer2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exer2_FormClosing);
            this.Load += new System.EventHandler(this.Exer2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton course;
        private System.Windows.Forms.RadioButton first;
        private System.Windows.Forms.RadioButton birthday;
        private System.Windows.Forms.RadioButton list;
        private System.Windows.Forms.RadioButton patronomyc;
        private System.Windows.Forms.RadioButton count;
        private System.Windows.Forms.RadioButton name;
        private System.Windows.Forms.RadioButton surname;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton group;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton all;
    }
}