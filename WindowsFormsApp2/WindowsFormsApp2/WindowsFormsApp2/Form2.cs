using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //检查是否已经存在
            string userID = userId.Text.Trim();  //取出账号

            /**
             * 连接数据库
             */
            string str = "Server=192.168.91.1;User ID=root;Password=123456;Database=text;CharSet=gbk;";
            MySqlConnection con = new MySqlConnection(str);//实例化链接
            con.Open();//开启连接
            //查询新注册的用户是否存在
            string s1 = "select name from user where name='" + userID + "' "; //创建SQL命令执行对象                                           //编写SQL命令
            MySqlCommand checkcmd = new MySqlCommand(s1, con);
            MySqlDataAdapter checkada = new MySqlDataAdapter(checkcmd);//实例化数据适配器让适配器执行SELECT命令
                             
            DataSet checkData = new DataSet();                 //实例化结果数据集
            int n = checkada.Fill(checkData, "user");         //将结果放入数据适配器，返回元祖个数
            if (n != 0)
            {
                MessageBox.Show("用户名存在");
                userId.Text = ""; userPw.Text = "";
                //nickName.Text = "";
            }


            //确认密码
            if (ensurePw.Text != userPw.Text)
            {
                ensurePw.Text = "";
            }

          

            //插入数据SQL  逻辑
            string s2 = "insert into user(name,password) values ('" + userId.Text + "','" + userPw.Text + "')";                            //编写SQL命令
            MySqlCommand cmd = new MySqlCommand(s2, con);        //初始化命令
            cmd.ExecuteNonQuery();             //执行语句
            con.Close();                       //关闭连接
            cmd = null;
            //cmd.Dispose();                     //释放对象


            if (userId.Text == "" || userPw.TextLength <= 6  || ensurePw.Text == "")
            {
                MessageBox.Show("请将信息填完整");
            }
            else
            {
                MessageBox.Show("注册成功");
                this.Close();
            }
        }
}
    }

    

