using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void 选择题查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Hide();
            this.Visible = true;
        }

        private void 选择题增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            Form6 f6 = new Form6();
            f6.ShowDialog();
            this.Hide();
            this.Visible = true;

        }

        private void 选择题修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            Form7 f7 = new Form7();
            f7.ShowDialog();
            this.Hide();
            this.Visible = true;
        }

        private void 选择题删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            Form8 f8 = new Form8();
            f8.ShowDialog();
            this.Hide();
            this.Visible = true;
        }

        private void 判断题查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            Form9 f9 = new Form9();
            f9.ShowDialog();
            this.Hide();
            this.Visible = true;
        }

        private void 判断题增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            Form10 f10 = new Form10();
            f10.ShowDialog();
            this.Hide();
            this.Visible = true;
        }

        private void 判断题修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            Form11 f11 = new Form11();
            f11.ShowDialog();
            this.Hide();
            this.Visible = true;
        }

        private void 判断题删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            Form12 f12 = new Form12();
            f12.ShowDialog();
            this.Hide();
            this.Visible = true;
        }

        private void 填空题查看ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            Form13 f13 = new Form13();
            f13.ShowDialog();
            this.Hide();
            this.Visible = true;
        }

        private void 填空题修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            Form14 f14 = new Form14();
            f14.ShowDialog();
            this.Hide();
            this.Visible = true;
        }

        private void 填空题增加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            Form15 f15 = new Form15();
            f15.ShowDialog();
            this.Hide();
            this.Visible = true;
        }

        private void 填空题删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            Form16 f16 = new Form16();
            f16.ShowDialog();
            this.Hide();
            this.Visible = true;
        }

        private void 学生得分ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;


            Form17 f17 = new Form17();
            f17.ShowDialog();
            this.Hide();
            this.Visible = true;
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 选择题库ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
