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
        int[] num = new int[5] { 1,2,3,4,5};
        int page = 0;
        int flag = 0;
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();       
        public Form3()
        {
            InitializeComponent();
            string str = "Server=127.0.0.1;User ID=sa;Password=123456;Database=TestData;";
            try
           {
                    SqlConnection con = new SqlConnection(str);//实例化链接 
                    con.Open();//开启连接
                    string s1 = "select Question,A,B,C,D,Correct from ChoiceQuestion ";   //编写SQL命令
                    SqlCommand cmd = new SqlCommand(s1, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.SelectCommand = cmd;
                    
                    ada.Fill(ds);//查询结果填充数据集
                    con.Close();

                //for (int i = 0; i < 5; i++)
                {
                    foreach (DataRow dr in ds.Tables[0].Rows)
                    {
                        //if (ds.Tables[0].Rows.IndexOf(dr) == num[i])
                        {
                            ds1.Tables[0].Rows.Add(dr);
                        }
                    }
                }
                // copyds();
                printfq();                  
            }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            
        }
        public void copyds()
        {
            Random ra = new Random();
            for (int i = 0; i < 5; i++)
            {
                int tem = ra.Next(0, 5);
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
            for (int i = 0; i < 5; i++)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    if (ds.Tables[0].Rows.IndexOf(dr) == num[i])
                    {
                        
                        //ds1.Tables[0].Rows.Add(dr);
                    }
                }
            }
        }
        public void printfq()
        {
            label1.Text = (page + 1).ToString() + "." + ds1.Tables[0].Rows[page][0].ToString();     //打印题目与选项
            radioButton1.Text = "A." + ds1.Tables[0].Rows[page][1].ToString();
            radioButton2.Text = "B." + ds1.Tables[0].Rows[page][2].ToString();
            radioButton3.Text = "C." + ds1.Tables[0].Rows[page][3].ToString();
            radioButton4.Text = "D." + ds1.Tables[0].Rows[page][4].ToString();
        }
    }
}
