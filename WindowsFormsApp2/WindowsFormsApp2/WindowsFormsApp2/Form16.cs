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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
            string str = "Server=(local)\\mysql;DataBase=TestData; Integrated Security=True";
            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                string str1 = "select * from FillQuestion";
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
        private void 选择题库ToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                string str1;
                if (num != "")
                {
                    try
                    {

                        if (MessageBox.Show("您真的要删除吗？", "此删除不可恢复", MessageBoxButtons.YesNo) == DialogResult.Yes)

                        {
                            str1 = "delete  from FillQuestion where num ='" + num + "' ";
                            com.CommandText = str1;
                            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                            sqlDataAdapter.SelectCommand = com;
                            int r = com.ExecuteNonQuery();
                            DataSet ds = new DataSet();
                            sqlDataAdapter.Fill(ds);

                            if (ds.Tables.Count > 0)
                            {
                                dataGridView1.DataSource = ds.Tables[0];
                            }
                            if (r == 0)
                            {
                                MessageBox.Show("删除失败，没找到该填空题");
                            }
                            else
                            {
                                MessageBox.Show("删除成功");
                            }
                        }

                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

    }
}
