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
    public partial class Form10 : Form
    {
        public Form10()
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

 
        private void Form5_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button4_Click(object sender, EventArgs e)
        {

            string num = textBox1.Text;
            string Question = textBox2.Text;
      
            string Correct = textBox7.Text;
            string str = "Server=(local)\\mysql;DataBase=TestData; Integrated Security=True";
            try
            {
                SqlConnection con = new SqlConnection(str);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox7.Text = "";
                con.Open();

                SqlCommand com = con.CreateCommand();
                string s1 = "select num from JudgeQuestion where  num='" + num + "' ";                                            //编写SQL命令
                com.CommandText = s1;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = com;
                DataSet ds = new DataSet();
                int n = da.Fill(ds, "JudgeQuestion");
                if (n == 0)
                {
                    try
                    {

                        if (num != "" && Correct != "" && Question != "")
                        {
                            if (Correct == "T" || Correct == "F")
                            {
                                SqlCommand com1 = new SqlCommand();
                                com1.Connection = con;
                                string str1 = "insert into JudgeQuestion(num,Question,Correct) values('" + num + "','" + Question + "','" + Correct + "')";
                                com1.CommandText = str1;
                                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
                                sqlDataAdapter.SelectCommand = com1;
                                int i = com1.ExecuteNonQuery();

                                if (i == 0)
                                {
                                    MessageBox.Show("添加失败");
                                }

                                if (i == 1)
                                {
                                    MessageBox.Show("成功添加");
                                    //this.Close();
                                }
                            }
                            else { MessageBox.Show("请输入判断题的选项只能为T或F"); }

                        }
                        else { MessageBox.Show("请输入判断题的全部信息"); }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    con.Close();
                }
                else { MessageBox.Show("该序号判断题已有"); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
