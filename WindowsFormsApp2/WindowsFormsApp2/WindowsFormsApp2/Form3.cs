using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        int[] num = new int[5];// { 2,1,3,4,5};
        char[] answer = new char[5];
        char[] answerj = new char[5];
        string[] answerf = new string[5] { "","","","",""};
        int page = 0;
        int flag = 0;
        int score = 0;
        DataSet ds = new DataSet();
        DataSet dsj = new DataSet();
        DataSet dsf = new DataSet();
        DataSet ds1 = new DataSet();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        DateTime tmStart;
        //DataTable ds1 = new DataTable();
        public Form3()
        {
            InitializeComponent();
            randint();           
            string str = "Server=127.0.0.1;User ID=sa;Password=123456;Database=TestData;";            
            try
           {
                    SqlConnection con = new SqlConnection(str);//实例化链接 
                    con.Open();//开启连接
                    string s1 = "select * from ChoiceQuestion ";   //编写SQL命令
                    SqlCommand cmd = new SqlCommand(s1, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.SelectCommand = cmd;
                    
                    ada.Fill(ds);//查询结果填充数据集
                    con.Close();
                    ds1.Tables.Add(dt1);
                    dt1 = ds.Tables[0].Clone();
               
                
                              
            }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            try
            {
                SqlConnection con = new SqlConnection(str);//实例化链接 
                con.Open();//开启连接
                string s1 = "select * from JudgeQuestion";   //编写SQL命令
                SqlCommand cmd = new SqlCommand(s1, con);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.SelectCommand = cmd;
                
                ada.Fill(dsj);//查询结果填充数据集
                con.Close();
                ds1.Tables.Add(dt2);
                dt2 = dsj.Tables[0].Clone();
                //copyds();
                //printfq();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            try
            {
                SqlConnection con = new SqlConnection(str);//实例化链接 
                con.Open();//开启连接
                string s1 = "select * from FillQuestion ";   //编写SQL命令
                SqlCommand cmd = new SqlCommand(s1, con);
                SqlDataAdapter ada = new SqlDataAdapter(cmd);
                ada.SelectCommand = cmd;
                
                ada.Fill(dsf);//查询结果填充数据集
                con.Close();
                ds1.Tables.Add(dt3);
                dt3 = dsf.Tables[0].Clone();

                //copyds();
               // printfq();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            copyds();
            printfq();
            tmStart = DateTime.Now;
            timer1.Start();
        }
        public void randint()             //随机函数
        {
            Random ra = new Random();
            for (int i = 0; i < 5; i++)
            {
                int tem = ra.Next(0, 6);
                foreach (int j in num)
                {
                    if (j == tem)
                    {
                        flag = 1;
                    }
                }
                if (flag == 1)
                {
                    flag = 0;
                    i--;
                }
                else
                {
                    num[i] = tem;
                }

            }
        }

        public void copyds()//取出题目
        {
            
            for (int i = 0; i < 5; i++)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (ds.Tables[0].Rows.IndexOf(dr) == num[i])
                    {
                        dt1.Rows.Add(dr.ItemArray);
                        //ds1.Tables[0].Rows.Add(dr);
                    }
                }
                foreach (DataRow dr1 in dsj.Tables[0].Rows)
                {
                    if (dsj.Tables[0].Rows.IndexOf(dr1) == num[i])
                    {
                        dt2.Rows.Add(dr1.ItemArray);
                        //ds1.Tables[0].Rows.Add(dr);
                    }
                }
                foreach (DataRow dr2 in dsf.Tables[0].Rows)
                {
                    if (dsf.Tables[0].Rows.IndexOf(dr2) == num[i])
                    {
                        dt3.Rows.Add(dr2.ItemArray);
                        //ds1.Tables[0].Rows.Add(dr);
                    }
                }
            }
        }
        public void printfq()
        {
            if(page>=0&&page<5)
            {
                radioButton1.Show();
                radioButton2.Show();
                radioButton3.Show();
                radioButton4.Show();
                textBox1.Hide();

                label1.Text = (page + 1).ToString() + "." + dt1.Rows[page][0].ToString();     //打印题目与选项
                radioButton1.Text = "A." + dt1.Rows[page][1].ToString();
                radioButton2.Text = "B." + dt1.Rows[page][2].ToString();
                radioButton3.Text = "C." + dt1.Rows[page][3].ToString();
                radioButton4.Text = "D." + dt1.Rows[page][4].ToString();
                
                if (answer[page] == 'A')
                {
                    radioButton1.Checked = true;
                }
                else if (answer[page] == 'B')
                {
                    radioButton2.Checked = true;
                }
                else if (answer[page] == 'C')
                {
                    radioButton3.Checked = true;
                }
                else if (answer[page] == 'D')
                {
                    radioButton4.Checked = true;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;
                    radioButton3.Checked = false;
                    radioButton4.Checked = false;
                }
            }
            else if (page >= 5 && page < 10)
            {
                radioButton1.Show();
                radioButton2.Show();
                radioButton3.Hide();
                radioButton4.Hide();
                textBox1.Hide();

                label1.Text = (page + 1).ToString() + "." + dt2.Rows[page-5][0].ToString();     //打印题目与选项
                radioButton1.Text = "T";
                radioButton2.Text = "F";
                
                if (answerj[page-5] == 'T')
                {
                    radioButton1.Checked = true;
                }
                else if (answerj[page-5] == 'F')
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = false;                  
                }

            }
            else if (page >= 10 && page < 15)
            {
                label1.Text = (page + 1).ToString() + "." + dt3.Rows[page - 10][0].ToString();     //打印题目与选项
                radioButton1.Hide();
                radioButton2.Hide();
                radioButton3.Hide();
                radioButton4.Hide();
                textBox1.Show();
                textBox1.Text = answerf[page - 10];
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if(page<14)
            {
                page = page + 1;
                printfq();
            }
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page = page - 1;
                printfq();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan nn = DateTime.Now - tmStart;
            int min = 2 - nn.Minutes;
            int sec = 59 - nn.Seconds;
            this.label3.Text = (min + ":" + sec);
            if (min == 0 && sec == 0)
            {
                MessageBox.Show("时间到");
                sendscore();
            }
        }
        private void choice()                          //判断选择,答案保留
        {
            if (page >= 0 && page < 5)
            {
                if (radioButton1.Checked == true)
                {
                    answer[page] = 'A';
                }
                else if (radioButton2.Checked == true)
                {
                    answer[page] = 'B';
                }
                else if (radioButton3.Checked == true)
                {
                    answer[page] = 'C';
                }
                else if (radioButton4.Checked == true)
                {
                    answer[page] = 'D';
                }
            }
            else if (page >= 5 && page < 10)
            {
                if (radioButton1.Checked == true)
                {
                    answerj[page-5] = 'T';
                }
                else if (radioButton2.Checked == true)
                {
                    answerj[page-5] = 'F';
                }

            }
            else if (page >= 10 && page < 15)
            {
                answerf[page - 10] = textBox1.Text.Trim().ToString();
            }
           
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            choice();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            choice();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            choice();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            choice();
        }
        private void sendscore()
        {
            score = 0;
            /*string p = "";
            for (int i = 0; i < 5; i++)
            {
                p += dt3.Rows[i][1].ToString().Trim();
            }
            textBox1.Text = p;*/
            for (int i = 0; i < 5; i++)
            {
                if (answer[i].ToString() == dt1.Rows[i][5].ToString())
                    score += 10;
                if (answerj[i].ToString() ==dt2.Rows[i][1].ToString())
                    score += 5;
                if (answerf[i].ToString()== dt3.Rows[i][1].ToString().Trim())
                    score += 5;
            }
            //label3.Text = score.ToString();
            try
            {
                string str = "Server=127.0.0.1;User ID=sa;Password=123456;Database=TestData;";
                SqlConnection con1 = new SqlConnection(str);//实例化链接 
                con1.Open();//开启连接
                string s1 = "update Suser set  score='" + score  + "' where num=" + Form1.num;    //编写SQL命令
                SqlCommand cmd = new SqlCommand(s1, con1);
                int count = -1;
                count = cmd.ExecuteNonQuery();
                con1.Close();
                if (count > 0)
                {
                    MessageBox.Show("提交完成");

                }
                else
                {
                    MessageBox.Show("提交失败");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());

            }
            Form1 form1 = new Form1();
            form1.Close();
        }
        private void button1_Click(object sender, EventArgs e)                     //提交成绩
        {
            sendscore();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            choice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            page = 0; printfq();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            page = 1; printfq();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            page = 2; printfq();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            page = 3; printfq();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            page = 4; printfq();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            page = 5; printfq();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            page = 6; printfq();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            page = 7; printfq();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            page = 8; printfq();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            page = 9; printfq();
        }
        private void button18_Click(object sender, EventArgs e)
        {
            page = 10; printfq();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            page = 11; printfq();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            page = 12; printfq();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            page = 13; printfq();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            page = 14;
            printfq();
        }
    }
}
