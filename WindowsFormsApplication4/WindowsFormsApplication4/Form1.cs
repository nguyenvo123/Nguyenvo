using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void saoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblthoigian.Text = String.Format("Bây giờ là {0}:{1}:{2} ngày {3} tháng {4} năm {5}",
           DateTime.Now.Hour,
           DateTime.Now.Minute,
           DateTime.Now.Second,
           DateTime.Now.Day,
           DateTime.Now.Month,
           DateTime.Now.Year);
        }

        private void kếtThúcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void mnuLoad_Click(object sender, EventArgs e)
        {
            // Mở tập tin
            StreamReader reader = new StreamReader("Thumoi.txt");
            if (reader == null) return;
            // Đọc từng dòng văn bản trong tập tin
            string input = null;
            while ((input = reader.ReadLine()) != null)
            {
                lbxthumoi.Items.Add(input);
            }
            // Đóng tập tin
            reader.Close();
            using (StreamReader rs = new StreamReader("Thudaco.txt"))
            {
                input = null;
                while ((input = rs.ReadLine()) != null)
                {
                    lbxdanhsach.Items.Add(input);
                }
            }
        }

        private void lbxthumoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Save(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("Thudaco.txt");
            if (writer == null) return;
            foreach (var item in lbxdanhsach.Items)
                writer.WriteLine(item.ToString());
        }

        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {

            //Tìm item cần drag
            ListBox lb = (ListBox)sender;
            int index = lb.IndexFromPoint(e.X, e.Y);

            if (index >= 0)
            {
                lb.DoDragDrop(lb.Items[index].ToString(), DragDropEffects.Link);
            }

            //Điều kiện để drag
            //Bắt đầu drag item (chỉ cần text. của item đó)
            DragDropEffects effect = lb.DoDragDrop(lb.Items[index].ToString(), DragDropEffects.Copy);

        }


        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
           if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void listDanhsach_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                ListBox lb = (ListBox)sender;
                lb.Items.Add(e.Data.GetData(DataFormats.Text));
            }
        }

        private void lbxdanhsach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
