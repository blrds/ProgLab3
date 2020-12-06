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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.adding = new System.Windows.Forms.GroupBox();
            this.inLast = new System.Windows.Forms.RadioButton();
            this.inAfter = new System.Windows.Forms.RadioButton();
            this.inBefore = new System.Windows.Forms.RadioButton();
            this.inFirst = new System.Windows.Forms.RadioButton();
            this.insertIndex = new System.Windows.Forms.TextBox();
            this.inLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.delTo = new System.Windows.Forms.TextBox();
            this.delFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.deleting = new System.Windows.Forms.GroupBox();
            this.delLast = new System.Windows.Forms.RadioButton();
            this.delRange = new System.Windows.Forms.RadioButton();
            this.delFirst = new System.Windows.Forms.RadioButton();
            this.delete = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.make = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchIndex = new System.Windows.Forms.TextBox();
            this.adding.SuspendLayout();
            this.deleting.SuspendLayout();
            this.searchBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(435, 214);
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
            this.listBox1.Location = new System.Drawing.Point(13, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 225);
            this.listBox1.TabIndex = 3;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(6, 190);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(101, 28);
            this.add.TabIndex = 4;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 32);
            this.textBox1.MaxLength = 1;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // adding
            // 
            this.adding.Controls.Add(this.inLast);
            this.adding.Controls.Add(this.inAfter);
            this.adding.Controls.Add(this.inBefore);
            this.adding.Controls.Add(this.inFirst);
            this.adding.Controls.Add(this.insertIndex);
            this.adding.Controls.Add(this.inLabel);
            this.adding.Controls.Add(this.label1);
            this.adding.Controls.Add(this.add);
            this.adding.Controls.Add(this.textBox1);
            this.adding.Location = new System.Drawing.Point(139, 12);
            this.adding.Name = "adding";
            this.adding.Size = new System.Drawing.Size(112, 225);
            this.adding.TabIndex = 6;
            this.adding.TabStop = false;
            this.adding.Text = "Adding";
            // 
            // inLast
            // 
            this.inLast.AutoSize = true;
            this.inLast.Location = new System.Drawing.Point(6, 128);
            this.inLast.Name = "inLast";
            this.inLast.Size = new System.Drawing.Size(57, 17);
            this.inLast.TabIndex = 13;
            this.inLast.TabStop = true;
            this.inLast.Text = "to Last";
            this.inLast.UseVisualStyleBackColor = true;
            // 
            // inAfter
            // 
            this.inAfter.AutoSize = true;
            this.inAfter.Location = new System.Drawing.Point(6, 105);
            this.inAfter.Name = "inAfter";
            this.inAfter.Size = new System.Drawing.Size(56, 17);
            this.inAfter.TabIndex = 12;
            this.inAfter.TabStop = true;
            this.inAfter.Text = "Before";
            this.inAfter.UseVisualStyleBackColor = true;
            this.inAfter.CheckedChanged += new System.EventHandler(this.inAfter_CheckedChanged);
            // 
            // inBefore
            // 
            this.inBefore.AutoSize = true;
            this.inBefore.Location = new System.Drawing.Point(6, 82);
            this.inBefore.Name = "inBefore";
            this.inBefore.Size = new System.Drawing.Size(47, 17);
            this.inBefore.TabIndex = 11;
            this.inBefore.TabStop = true;
            this.inBefore.Text = "After";
            this.inBefore.UseVisualStyleBackColor = true;
            this.inBefore.CheckedChanged += new System.EventHandler(this.inAfter_CheckedChanged);
            // 
            // inFirst
            // 
            this.inFirst.AutoSize = true;
            this.inFirst.Location = new System.Drawing.Point(6, 59);
            this.inFirst.Name = "inFirst";
            this.inFirst.Size = new System.Drawing.Size(56, 17);
            this.inFirst.TabIndex = 10;
            this.inFirst.TabStop = true;
            this.inFirst.Text = "to First";
            this.inFirst.UseVisualStyleBackColor = true;
            // 
            // insertIndex
            // 
            this.insertIndex.Location = new System.Drawing.Point(6, 164);
            this.insertIndex.Name = "insertIndex";
            this.insertIndex.Size = new System.Drawing.Size(100, 20);
            this.insertIndex.TabIndex = 9;
            this.insertIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.insertIndex_KeyPress);
            // 
            // inLabel
            // 
            this.inLabel.AutoSize = true;
            this.inLabel.Location = new System.Drawing.Point(6, 148);
            this.inLabel.Name = "inLabel";
            this.inLabel.Size = new System.Drawing.Size(38, 13);
            this.inLabel.TabIndex = 7;
            this.inLabel.Text = "Before";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item";
            // 
            // delTo
            // 
            this.delTo.Location = new System.Drawing.Point(9, 140);
            this.delTo.Name = "delTo";
            this.delTo.Size = new System.Drawing.Size(100, 20);
            this.delTo.TabIndex = 14;
            this.delTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.insertIndex_KeyPress);
            // 
            // delFrom
            // 
            this.delFrom.Location = new System.Drawing.Point(9, 101);
            this.delFrom.Name = "delFrom";
            this.delFrom.Size = new System.Drawing.Size(100, 20);
            this.delFrom.TabIndex = 13;
            this.delFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.insertIndex_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "To";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "From";
            // 
            // deleting
            // 
            this.deleting.Controls.Add(this.delLast);
            this.deleting.Controls.Add(this.delTo);
            this.deleting.Controls.Add(this.delRange);
            this.deleting.Controls.Add(this.delFirst);
            this.deleting.Controls.Add(this.delFrom);
            this.deleting.Controls.Add(this.label4);
            this.deleting.Controls.Add(this.delete);
            this.deleting.Controls.Add(this.label5);
            this.deleting.Location = new System.Drawing.Point(257, 12);
            this.deleting.Name = "deleting";
            this.deleting.Size = new System.Drawing.Size(117, 202);
            this.deleting.TabIndex = 14;
            this.deleting.TabStop = false;
            this.deleting.Text = "Deleting";
            // 
            // delLast
            // 
            this.delLast.AutoSize = true;
            this.delLast.Location = new System.Drawing.Point(6, 65);
            this.delLast.Name = "delLast";
            this.delLast.Size = new System.Drawing.Size(45, 17);
            this.delLast.TabIndex = 13;
            this.delLast.TabStop = true;
            this.delLast.Text = "Last";
            this.delLast.UseVisualStyleBackColor = true;
            // 
            // delRange
            // 
            this.delRange.AutoSize = true;
            this.delRange.Location = new System.Drawing.Point(6, 42);
            this.delRange.Name = "delRange";
            this.delRange.Size = new System.Drawing.Size(57, 17);
            this.delRange.TabIndex = 12;
            this.delRange.TabStop = true;
            this.delRange.Text = "Range";
            this.delRange.UseVisualStyleBackColor = true;
            this.delRange.CheckedChanged += new System.EventHandler(this.delRange_CheckedChanged);
            // 
            // delFirst
            // 
            this.delFirst.AutoSize = true;
            this.delFirst.Location = new System.Drawing.Point(6, 19);
            this.delFirst.Name = "delFirst";
            this.delFirst.Size = new System.Drawing.Size(44, 17);
            this.delFirst.TabIndex = 10;
            this.delFirst.TabStop = true;
            this.delFirst.Text = "First";
            this.delFirst.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(9, 166);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(101, 28);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(516, 12);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 225);
            this.listBox2.TabIndex = 15;
            // 
            // make
            // 
            this.make.Location = new System.Drawing.Point(380, 12);
            this.make.Name = "make";
            this.make.Size = new System.Drawing.Size(130, 51);
            this.make.TabIndex = 16;
            this.make.Text = "Make dictionary";
            this.make.UseVisualStyleBackColor = true;
            this.make.Click += new System.EventHandler(this.make_Click);
            // 
            // searchBox
            // 
            this.searchBox.Controls.Add(this.search);
            this.searchBox.Controls.Add(this.label2);
            this.searchBox.Controls.Add(this.searchIndex);
            this.searchBox.Location = new System.Drawing.Point(380, 69);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(130, 98);
            this.searchBox.TabIndex = 17;
            this.searchBox.TabStop = false;
            this.searchBox.Text = "Search";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(6, 58);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(101, 28);
            this.search.TabIndex = 15;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Index of element";
            // 
            // searchIndex
            // 
            this.searchIndex.Location = new System.Drawing.Point(6, 32);
            this.searchIndex.Name = "searchIndex";
            this.searchIndex.Size = new System.Drawing.Size(100, 20);
            this.searchIndex.TabIndex = 14;
            this.searchIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.insertIndex_KeyPress);
            // 
            // Exer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 245);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.make);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.deleting);
            this.Controls.Add(this.adding);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.back);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Exer2";
            this.Text = "Exer2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exer2_FormClosing);
            this.Load += new System.EventHandler(this.Exer2_Load);
            this.adding.ResumeLayout(false);
            this.adding.PerformLayout();
            this.deleting.ResumeLayout(false);
            this.deleting.PerformLayout();
            this.searchBox.ResumeLayout(false);
            this.searchBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox adding;
        private System.Windows.Forms.RadioButton inLast;
        private System.Windows.Forms.RadioButton inAfter;
        private System.Windows.Forms.RadioButton inBefore;
        private System.Windows.Forms.RadioButton inFirst;
        private System.Windows.Forms.TextBox insertIndex;
        private System.Windows.Forms.Label inLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox delTo;
        private System.Windows.Forms.TextBox delFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox deleting;
        private System.Windows.Forms.RadioButton delLast;
        private System.Windows.Forms.RadioButton delRange;
        private System.Windows.Forms.RadioButton delFirst;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button make;
        private System.Windows.Forms.GroupBox searchBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchIndex;
    }
}