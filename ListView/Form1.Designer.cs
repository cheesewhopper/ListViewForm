namespace ListView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "item1",
            "2022-12-12",
            "file",
            "113"}, 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("item2", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("item3", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("item4", 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("item5", 4);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btAdd = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.radLarge = new System.Windows.Forms.RadioButton();
            this.radDetail = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(24, 27);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(529, 245);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "이름";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "날짜";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "유형";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "크기";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "logo.ico");
            this.imageList1.Images.SetKeyName(1, "램버거.png");
            this.imageList1.Images.SetKeyName(2, "레몬.png");
            this.imageList1.Images.SetKeyName(3, "사과.png");
            this.imageList1.Images.SetKeyName(4, "치킨.png");
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(570, 27);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(109, 50);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "추가";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(570, 96);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(109, 50);
            this.btDelete.TabIndex = 2;
            this.btDelete.Text = "삭제";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.button2_Click);
            // 
            // radLarge
            // 
            this.radLarge.AutoSize = true;
            this.radLarge.Location = new System.Drawing.Point(570, 176);
            this.radLarge.Name = "radLarge";
            this.radLarge.Size = new System.Drawing.Size(81, 19);
            this.radLarge.TabIndex = 3;
            this.radLarge.Text = "Large Icon";
            this.radLarge.UseVisualStyleBackColor = true;
            this.radLarge.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radDetail
            // 
            this.radDetail.AutoSize = true;
            this.radDetail.Checked = true;
            this.radDetail.Location = new System.Drawing.Point(570, 201);
            this.radDetail.Name = "radDetail";
            this.radDetail.Size = new System.Drawing.Size(86, 19);
            this.radDetail.TabIndex = 4;
            this.radDetail.TabStop = true;
            this.radDetail.Text = "Detail View";
            this.radDetail.UseVisualStyleBackColor = true;
            this.radDetail.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 325);
            this.Controls.Add(this.radDetail);
            this.Controls.Add(this.radLarge);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private Button btAdd;
        private Button btDelete;
        private ImageList imageList1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private RadioButton radLarge;
        private RadioButton radDetail;
    }
}