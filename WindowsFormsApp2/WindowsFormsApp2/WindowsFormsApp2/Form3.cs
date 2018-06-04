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
        public Form3()
        {
            InitializeComponent();
            string str = "Server=127.0.0.1;User ID=sa;Password=123456;Database=TestData;";
                try
                {
                    SqlConnection con = new SqlConnection(str);//实例化链接 
                    con.Open();//开启连接
                    string s1 = "select Question,A,B,C,D from ChoiceQuestion ";   //编写SQL命令
                    SqlCommand cmd = new SqlCommand(s1, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    ada.Fill(ds);//查询结果填充数据集
                    con.Close();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            
        }
    }
}
