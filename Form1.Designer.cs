namespace collectionEditor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.open = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.itemList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeCom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.childTypeCom = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.desT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // open
            // 
            this.open.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.open.Location = new System.Drawing.Point(87, 30);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(93, 42);
            this.open.TabIndex = 0;
            this.open.Text = "打开";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.save.Location = new System.Drawing.Point(229, 30);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(93, 42);
            this.save.TabIndex = 1;
            this.save.Text = "另存为";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add.Location = new System.Drawing.Point(54, 107);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(77, 37);
            this.add.TabIndex = 2;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.delete.Location = new System.Drawing.Point(167, 107);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(77, 37);
            this.delete.TabIndex = 3;
            this.delete.Text = "-";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.ItemHeight = 17;
            this.itemList.Location = new System.Drawing.Point(54, 174);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(190, 276);
            this.itemList.TabIndex = 4;
            this.itemList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(367, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // idT
            // 
            this.idT.Location = new System.Drawing.Point(398, 175);
            this.idT.Name = "idT";
            this.idT.Size = new System.Drawing.Size(121, 23);
            this.idT.TabIndex = 6;
            this.idT.TextChanged += new System.EventHandler(this.idT_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(349, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "type";
            // 
            // typeCom
            // 
            this.typeCom.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.typeCom.FormattingEnabled = true;
            this.typeCom.Location = new System.Drawing.Point(398, 216);
            this.typeCom.Name = "typeCom";
            this.typeCom.Size = new System.Drawing.Size(178, 29);
            this.typeCom.TabIndex = 8;
            this.typeCom.SelectedIndexChanged += new System.EventHandler(this.typeCom_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(310, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "childType";
            // 
            // childTypeCom
            // 
            this.childTypeCom.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.childTypeCom.FormattingEnabled = true;
            this.childTypeCom.Location = new System.Drawing.Point(398, 263);
            this.childTypeCom.Name = "childTypeCom";
            this.childTypeCom.Size = new System.Drawing.Size(178, 29);
            this.childTypeCom.TabIndex = 10;
            this.childTypeCom.SelectedIndexChanged += new System.EventHandler(this.childTypeCom_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(298, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "description";
            // 
            // desT
            // 
            this.desT.Location = new System.Drawing.Point(398, 309);
            this.desT.Name = "desT";
            this.desT.Size = new System.Drawing.Size(178, 23);
            this.desT.TabIndex = 12;
            this.desT.TextChanged += new System.EventHandler(this.desT_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 473);
            this.Controls.Add(this.desT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.childTypeCom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itemList);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.save);
            this.Controls.Add(this.open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private Button open;
        private Button save;
        private Button add;
        private Button delete;
        private ListBox itemList;
        private Label label1;
        private TextBox idT;
        private Label label2;
        private ComboBox typeCom;
        private Label label3;
        private ComboBox childTypeCom;
        private Label label4;
        private TextBox desT;
    }
}