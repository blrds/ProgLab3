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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.additem = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.serchitem = new System.Windows.Forms.TextBox();
            this.adding = new System.Windows.Forms.GroupBox();
            this.searching = new System.Windows.Forms.GroupBox();
            this.adding.SuspendLayout();
            this.searching.SuspendLayout();
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
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 420);
            this.listBox1.TabIndex = 3;
            // 
            // additem
            // 
            this.additem.Location = new System.Drawing.Point(6, 19);
            this.additem.Name = "additem";
            this.additem.Size = new System.Drawing.Size(100, 20);
            this.additem.TabIndex = 4;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(6, 46);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 23);
            this.add.TabIndex = 5;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(139, 128);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 23);
            this.delete.TabIndex = 6;
            this.delete.Text = "Удалить";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Кол-во элемнтов";
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(139, 112);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(0, 13);
            this.count.TabIndex = 8;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(6, 46);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(100, 23);
            this.search.TabIndex = 10;
            this.search.Text = "Искать";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // serchitem
            // 
            this.serchitem.Location = new System.Drawing.Point(6, 19);
            this.serchitem.Name = "serchitem";
            this.serchitem.Size = new System.Drawing.Size(100, 20);
            this.serchitem.TabIndex = 9;
            // 
            // adding
            // 
            this.adding.Controls.Add(this.additem);
            this.adding.Controls.Add(this.add);
            this.adding.Location = new System.Drawing.Point(139, 13);
            this.adding.Name = "adding";
            this.adding.Size = new System.Drawing.Size(116, 79);
            this.adding.TabIndex = 11;
            this.adding.TabStop = false;
            this.adding.Text = "Добавление";
            // 
            // searching
            // 
            this.searching.Controls.Add(this.serchitem);
            this.searching.Controls.Add(this.search);
            this.searching.Location = new System.Drawing.Point(139, 157);
            this.searching.Name = "searching";
            this.searching.Size = new System.Drawing.Size(110, 76);
            this.searching.TabIndex = 12;
            this.searching.TabStop = false;
            this.searching.Text = "Поиск";
            // 
            // Exer1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 450);
            this.Controls.Add(this.searching);
            this.Controls.Add(this.adding);
            this.Controls.Add(this.count);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.back);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Exer1";
            this.Text = "Exer1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exer1_FormClosing);
            this.Load += new System.EventHandler(this.Exer1_Load);
            this.adding.ResumeLayout(false);
            this.adding.PerformLayout();
            this.searching.ResumeLayout(false);
            this.searching.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox additem;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox serchitem;
        private System.Windows.Forms.GroupBox adding;
        private System.Windows.Forms.GroupBox searching;
    }
}