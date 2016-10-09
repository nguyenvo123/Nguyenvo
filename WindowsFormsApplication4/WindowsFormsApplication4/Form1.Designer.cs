namespace WindowsFormsApplication4
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbxthumoi = new System.Windows.Forms.ListBox();
            this.lbxdanhsach = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblthoigian = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hồSơToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtThúcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sữaĐổiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cắtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnluu = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxthumoi
            // 
            this.lbxthumoi.AllowDrop = true;
            this.lbxthumoi.FormattingEnabled = true;
            this.lbxthumoi.Location = new System.Drawing.Point(41, 74);
            this.lbxthumoi.Name = "lbxthumoi";
            this.lbxthumoi.Size = new System.Drawing.Size(105, 199);
            this.lbxthumoi.TabIndex = 0;
            this.lbxthumoi.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.lbxthumoi.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // lbxdanhsach
            // 
            this.lbxdanhsach.AllowDrop = true;
            this.lbxdanhsach.FormattingEnabled = true;
            this.lbxdanhsach.Location = new System.Drawing.Point(152, 74);
            this.lbxdanhsach.Name = "lbxdanhsach";
            this.lbxdanhsach.Size = new System.Drawing.Size(103, 199);
            this.lbxdanhsach.TabIndex = 1;
            this.lbxdanhsach.SelectedIndexChanged += new System.EventHandler(this.lbxdanhsach_SelectedIndexChanged);
            this.lbxdanhsach.DragDrop += new System.Windows.Forms.DragEventHandler(this.listDanhsach_DragDrop);
            this.lbxdanhsach.DragEnter += new System.Windows.Forms.DragEventHandler(this.ListBox_DragEnter);
            this.lbxdanhsach.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ListBox_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Thú mới";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Danh sach thu";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblthoigian
            // 
            this.lblthoigian.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblthoigian.Location = new System.Drawing.Point(38, 313);
            this.lblthoigian.Name = "lblthoigian";
            this.lblthoigian.Size = new System.Drawing.Size(249, 24);
            this.lblthoigian.TabIndex = 4;
            this.lblthoigian.Text = "label3";
            this.lblthoigian.Click += new System.EventHandler(this.timer1_Tick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "download.jpg");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hồSơToolStripMenuItem,
            this.sữaĐổiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(466, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hồSơToolStripMenuItem
            // 
            this.hồSơToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLoad,
            this.mnuSave,
            this.kếtThúcToolStripMenuItem});
            this.hồSơToolStripMenuItem.Name = "hồSơToolStripMenuItem";
            this.hồSơToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.hồSơToolStripMenuItem.Text = "Hồ sơ";
            // 
            // mnuLoad
            // 
            this.mnuLoad.Image = global::WindowsFormsApplication4.Properties.Resources.download1;
            this.mnuLoad.Name = "mnuLoad";
            this.mnuLoad.Size = new System.Drawing.Size(151, 22);
            this.mnuLoad.Text = "Tải danh sách";
            this.mnuLoad.Click += new System.EventHandler(this.mnuLoad_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Image = global::WindowsFormsApplication4.Properties.Resources.download;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(151, 22);
            this.mnuSave.Text = "Lưu danh sách";
            this.mnuSave.Click += new System.EventHandler(this.Save);
            // 
            // kếtThúcToolStripMenuItem
            // 
            this.kếtThúcToolStripMenuItem.Name = "kếtThúcToolStripMenuItem";
            this.kếtThúcToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.kếtThúcToolStripMenuItem.Text = "Kết thúc";
            this.kếtThúcToolStripMenuItem.Click += new System.EventHandler(this.kếtThúcToolStripMenuItem_Click);
            // 
            // sữaĐổiToolStripMenuItem
            // 
            this.sữaĐổiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cắtToolStripMenuItem,
            this.dánToolStripMenuItem,
            this.saoToolStripMenuItem});
            this.sữaĐổiToolStripMenuItem.Name = "sữaĐổiToolStripMenuItem";
            this.sữaĐổiToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+";
            this.sữaĐổiToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.sữaĐổiToolStripMenuItem.Text = "Sữa đổi";
            // 
            // cắtToolStripMenuItem
            // 
            this.cắtToolStripMenuItem.Name = "cắtToolStripMenuItem";
            this.cắtToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+X";
            this.cắtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cắtToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cắtToolStripMenuItem.Text = "Cắt";
            // 
            // dánToolStripMenuItem
            // 
            this.dánToolStripMenuItem.Name = "dánToolStripMenuItem";
            this.dánToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+V";
            this.dánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.dánToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.dánToolStripMenuItem.Text = "Dán";
            // 
            // saoToolStripMenuItem
            // 
            this.saoToolStripMenuItem.Name = "saoToolStripMenuItem";
            this.saoToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+C";
            this.saoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.saoToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.saoToolStripMenuItem.Text = "Sao";
            this.saoToolStripMenuItem.Click += new System.EventHandler(this.saoToolStripMenuItem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.ImageIndex = 0;
            this.btnluu.ImageList = this.imageList1;
            this.btnluu.Location = new System.Drawing.Point(310, 313);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(144, 30);
            this.btnluu.TabIndex = 5;
            this.btnluu.Text = "Lưu danh sách";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.Save);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 355);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.lblthoigian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxdanhsach);
            this.Controls.Add(this.lbxthumoi);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sở thú";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxthumoi;
        private System.Windows.Forms.ListBox lbxdanhsach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblthoigian;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hồSơToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuLoad;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem kếtThúcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sữaĐổiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cắtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saoToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

