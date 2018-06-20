using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            string str = "Server=(local)\\mysql;DataBase=TestData; Integrated Security=True";
            SqlConnection con = new SqlConnection(str);


            try
            {
                con.Open();
                string str1 = "select * from JudgeQuestion";
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = str1;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                sqlDataAdapter.SelectCommand = com;
                com.ExecuteNonQuery();
                DataSet ds = new DataSet();
                sqlDataAdapter.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    dataGridView1.DataSource = ds.Tables[0];
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
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
            Form4 f4 = new Form4();
            f4.ShowDialog();
            // this.Close();
        }
        private void 选择题库ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void Form5_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;

            string str = "Server=(local)\\mysql;DataBase=TestData; Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            textBox1.Text = "";



            try
            {
                con.Open();
                if (num != "")
                {
                    SqlCommand com = new SqlCommand();
                    com.Connection = con;
                    string str1 = "select * from JudgeQuestion where num like'%" + num + "%' ";
                    com.CommandText = str1;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = com;
               
                    DataSet ds = new DataSet();
                    sqlDataAdapter.Fill(ds);

                    DataTable dt = new DataTable();
                    dt = ds.Tables[0].Copy();
                    dataGridView1.DataSource = null;

                    this.dataGridView1.DataSource = dt;

                    if (dataGridView1.Rows.Count == 1)
                    {
                        MessageBox.Show("没有该题");
                    }

                }
                else { MessageBox.Show("请输入需要查询的判断题序号"); }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 填空题库ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
