namespace ProgLab2
{
    partial class Exer4
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
            this.deleting = new System.Windows.Forms.GroupBox();
            this.delete = new System.Windows.Forms.Button();
            this.adding = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this._item = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.deleting.SuspendLayout();
            this.adding.SuspendLayout();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(180, 253);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 1;
            this.back.Text = "Назад";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // deleting
            // 
            this.deleting.Controls.Add(this.delete);
            this.deleting.Location = new System.Drawing.Point(138, 116);
            this.deleting.Name = "deleting";
            this.deleting.Size = new System.Drawing.Size(117, 54);
            this.deleting.TabIndex = 23;
            this.deleting.TabStop = false;
            this.deleting.Text = "Deleting";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(6, 19);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(101, 28);
            this.delete.TabIndex = 4;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // adding
            // 
            this.adding.Controls.Add(this.label1);
            this.adding.Controls.Add(this.add);
            this.adding.Controls.Add(this._item);
            this.adding.Location = new System.Drawing.Point(138, 12);
            this.adding.Name = "adding";
            this.adding.Size = new System.Drawing.Size(117, 98);
            this.adding.TabIndex = 22;
            this.adding.TabStop = false;
            this.adding.Text = "Adding";
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
            // add
            // 
            this.add.Location = new System.Drawing.Point(6, 58);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(101, 28);
            this.add.TabIndex = 4;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // _item
            // 
            this._item.Location = new System.Drawing.Point(6, 32);
            this._item.MaxLength = 1;
            this._item.Name = "_item";
            this._item.Size = new System.Drawing.Size(100, 20);
            this._item.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 264);
            this.listBox1.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "label2";
            // 
            // Exer4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 278);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.deleting);
            this.Controls.Add(this.adding);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.back);
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Exer4";
            this.Text = "Exer4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Exer4_FormClosing);
            this.Load += new System.EventHandler(this.Exer4_Load);
            this.deleting.ResumeLayout(false);
            this.adding.ResumeLayout(false);
            this.adding.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.GroupBox deleting;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.GroupBox adding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox _item;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
    }
}