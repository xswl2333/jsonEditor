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
            open = new Button();
            save = new Button();
            add = new Button();
            delete = new Button();
            itemList = new ListBox();
            label1 = new Label();
            idT = new TextBox();
            label2 = new Label();
            typeCom = new ComboBox();
            label3 = new Label();
            childTypeCom = new ComboBox();
            label4 = new Label();
            desT = new TextBox();
            label5 = new Label();
            sourceTypeCom = new ComboBox();
            addMap = new Button();
            deleteMap = new Button();
            sourceMapList = new ListBox();
            sourceIdT = new TextBox();
            sourceType = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // open
            // 
            open.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            open.Location = new Point(99, 35);
            open.Margin = new Padding(3, 4, 3, 4);
            open.Name = "open";
            open.Size = new Size(106, 49);
            open.TabIndex = 0;
            open.Text = "打开";
            open.UseVisualStyleBackColor = true;
            open.Click += open_Click;
            // 
            // save
            // 
            save.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            save.Location = new Point(262, 35);
            save.Margin = new Padding(3, 4, 3, 4);
            save.Name = "save";
            save.Size = new Size(106, 49);
            save.TabIndex = 1;
            save.Text = "另存为";
            save.UseVisualStyleBackColor = true;
            save.Click += save_Click;
            // 
            // add
            // 
            add.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            add.Location = new Point(62, 126);
            add.Margin = new Padding(3, 4, 3, 4);
            add.Name = "add";
            add.Size = new Size(88, 44);
            add.TabIndex = 2;
            add.Text = "+";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // delete
            // 
            delete.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            delete.Location = new Point(191, 126);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Size = new Size(88, 44);
            delete.TabIndex = 3;
            delete.Text = "-";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // itemList
            // 
            itemList.FormattingEnabled = true;
            itemList.ItemHeight = 20;
            itemList.Location = new Point(62, 205);
            itemList.Margin = new Padding(3, 4, 3, 4);
            itemList.Name = "itemList";
            itemList.Size = new Size(217, 384);
            itemList.TabIndex = 4;
            itemList.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(462, 207);
            label1.Name = "label1";
            label1.Size = new Size(25, 21);
            label1.TabIndex = 5;
            label1.Text = "Id";
            // 
            // idT
            // 
            idT.Location = new Point(493, 205);
            idT.Margin = new Padding(3, 4, 3, 4);
            idT.Name = "idT";
            idT.Size = new Size(138, 25);
            idT.TabIndex = 6;
            idT.TextChanged += idT_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(370, 256);
            label2.Name = "label2";
            label2.Size = new Size(117, 21);
            label2.TabIndex = 7;
            label2.Text = "type(数据类型)";
            // 
            // typeCom
            // 
            typeCom.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            typeCom.FormattingEnabled = true;
            typeCom.Location = new Point(493, 253);
            typeCom.Margin = new Padding(3, 4, 3, 4);
            typeCom.Name = "typeCom";
            typeCom.Size = new Size(203, 29);
            typeCom.TabIndex = 8;
            typeCom.SelectedIndexChanged += typeCom_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(299, 311);
            label3.Name = "label3";
            label3.Size = new Size(188, 21);
            label3.TabIndex = 9;
            label3.Text = "childType(对应界面类型)";
            // 
            // childTypeCom
            // 
            childTypeCom.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            childTypeCom.FormattingEnabled = true;
            childTypeCom.Location = new Point(493, 308);
            childTypeCom.Margin = new Padding(3, 4, 3, 4);
            childTypeCom.Name = "childTypeCom";
            childTypeCom.Size = new Size(203, 29);
            childTypeCom.TabIndex = 10;
            childTypeCom.SelectedIndexChanged += childTypeCom_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(303, 365);
            label4.Name = "label4";
            label4.Size = new Size(184, 21);
            label4.TabIndex = 11;
            label4.Text = "description(来源的描述)";
            // 
            // desT
            // 
            desT.Location = new Point(493, 363);
            desT.Margin = new Padding(3, 4, 3, 4);
            desT.Name = "desT";
            desT.Size = new Size(203, 25);
            desT.TabIndex = 12;
            desT.TextChanged += desT_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(319, 421);
            label5.Name = "label5";
            label5.Size = new Size(95, 21);
            label5.TabIndex = 13;
            label5.Text = "sourceMap";
            // 
            // sourceTypeCom
            // 
            sourceTypeCom.FormattingEnabled = true;
            sourceTypeCom.Location = new Point(428, 473);
            sourceTypeCom.Name = "sourceTypeCom";
            sourceTypeCom.Size = new Size(203, 28);
            sourceTypeCom.TabIndex = 14;
            sourceTypeCom.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // addMap
            // 
            addMap.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            addMap.Location = new Point(433, 408);
            addMap.Margin = new Padding(3, 4, 3, 4);
            addMap.Name = "addMap";
            addMap.Size = new Size(88, 44);
            addMap.TabIndex = 15;
            addMap.Text = "+";
            addMap.UseVisualStyleBackColor = true;
            addMap.Click += addMap_Click;
            // 
            // deleteMap
            // 
            deleteMap.Font = new Font("Microsoft YaHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            deleteMap.Location = new Point(543, 408);
            deleteMap.Margin = new Padding(3, 4, 3, 4);
            deleteMap.Name = "deleteMap";
            deleteMap.Size = new Size(88, 44);
            deleteMap.TabIndex = 16;
            deleteMap.Text = "-";
            deleteMap.UseVisualStyleBackColor = true;
            deleteMap.Click += deleteMap_Click;
            // 
            // sourceMapList
            // 
            sourceMapList.FormattingEnabled = true;
            sourceMapList.ItemHeight = 20;
            sourceMapList.Location = new Point(665, 461);
            sourceMapList.Name = "sourceMapList";
            sourceMapList.Size = new Size(198, 84);
            sourceMapList.TabIndex = 17;
            sourceMapList.SelectedIndexChanged += sourceMapList_SelectedIndexChanged;
            // 
            // sourceIdT
            // 
            sourceIdT.Location = new Point(428, 520);
            sourceIdT.Margin = new Padding(3, 4, 3, 4);
            sourceIdT.Name = "sourceIdT";
            sourceIdT.Size = new Size(203, 25);
            sourceIdT.TabIndex = 18;
            sourceIdT.TextChanged += sourceIdT_TextChanged;
            // 
            // sourceType
            // 
            sourceType.AutoSize = true;
            sourceType.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            sourceType.Location = new Point(319, 475);
            sourceType.Name = "sourceType";
            sourceType.Size = new Size(96, 21);
            sourceType.TabIndex = 19;
            sourceType.Text = "sourceType";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(330, 524);
            label6.Name = "label6";
            label6.Size = new Size(75, 21);
            label6.TabIndex = 20;
            label6.Text = "sourceId";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(945, 705);
            Controls.Add(label6);
            Controls.Add(sourceType);
            Controls.Add(sourceIdT);
            Controls.Add(sourceMapList);
            Controls.Add(deleteMap);
            Controls.Add(addMap);
            Controls.Add(sourceTypeCom);
            Controls.Add(label5);
            Controls.Add(desT);
            Controls.Add(label4);
            Controls.Add(childTypeCom);
            Controls.Add(label3);
            Controls.Add(typeCom);
            Controls.Add(label2);
            Controls.Add(idT);
            Controls.Add(label1);
            Controls.Add(itemList);
            Controls.Add(delete);
            Controls.Add(add);
            Controls.Add(save);
            Controls.Add(open);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Label label5;
        private ComboBox sourceTypeCom;
        private Button addMap;
        private Button deleteMap;
        private ListBox sourceMapList;
        private TextBox sourceIdT;
        private Label sourceType;
        private Label label6;
    }
}