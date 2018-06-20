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
    public partial class Form1 : Form
    {
          public static int num = 0;
        private int errorTime = 3;
        public Form1()
        {
            InitializeComponent();
            //Form3 form3 = new Form3();
            //form3.ShowDialog();
            // MessageBox.Show("欢迎使用！");             //登录成功
           // this.Hide();
            radioButton1.Checked = true;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            errorTime = errorTime - 1;
            string username = txtName.Text.Trim();  //取出账号
            string pw = txtPwd.Text.Trim();  //取出密码
            string str = "Server=(local)\\mysql;DataBase=TestData; Integrated Security=True";
            if (radioButton1.Checked == true)
            {
                try
                {
                    SqlConnection con = new SqlConnection(str);//实例化链接 
                    con.Open();//开启连接
                    string s1 = "select * from Suser where name='" + username + "' and password='" + pw + "'";   //编写SQL命令
                    SqlCommand cmd = new SqlCommand(s1, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    int n = ada.Fill(ds);//查询结果填充数据集
                                         //ada.Fill(ds, "user");//将结果放入数据适配器，返回元素个数
                    if (n != 0)
                    {

                        num = int.Parse(ds.Tables[0].Rows[0]["num"].ToString());
                        this.Hide();
                        Form3 form3 = new Form3();
                        form3.ShowDialog();
                        // MessageBox.Show("欢迎使用！");             //登录成功


                    }
                    else
                        if (errorTime < 3)
                    {
                        MessageBox.Show("用户名或密码有错。请重新输入！还有" + errorTime.ToString() + "次机会");
                        txtName.Text = "";   //清空账号
                        txtPwd.Text = "";    //清空密码?
                        txtName.Focus();     //光标设置在账号上
                    }
                    else
                    {
                        MessageBox.Show("你输入的用户名或密码已达三次? 将退出程序");
                        this.Close();
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            
        }
            if (radioButton2.Checked == true)
            {
                try
                {
                    SqlConnection con = new SqlConnection(str);//实例化链接 
                    con.Open();//开启连接
                    string s1 = "select num,password from Tuser where num='" + username + "' and password='" + pw + "'";   //编写SQL命令
                    SqlCommand cmd = new SqlCommand(s1, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    ada.Fill(ds);//查询结果填充数据集
                    int n = ada.Fill(ds, "Tuser");//将结果放入数据适配器，返回元素个数
                    if (n != 0)
                    {
                        this.Visible = false;
                        Form4 form4 = new Form4();
                        form4.ShowDialog();
                        // MessageBox.Show("欢迎使用！");             //登录成功
                        this.Hide();
                        this.Visible = true;

                    }
                    else
                        if (errorTime < 3)
                    {
                        MessageBox.Show("用户名或密码有错。请重新输入！还有" + errorTime.ToString() + "次机会");
                        txtName.Text = "";   //清空账号
                        txtPwd.Text = "";    //清空密码?
                        txtName.Focus();     //光标设置在账号上
                    }
                    else
                    {
                        MessageBox.Show("你输入的用户名或密码已达三次? 将退出程序");
                        this.Close();
                    }
                    con.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        /*private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }*/

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
