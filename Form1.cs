using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using 

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Weather.WeatherWebService w = new Weather.WeatherWebService(/*"WeatherWebServiceSoap"*/);
            //把webservice当做一个类来操作  
            string[] s = new string[23];//声明string数组存放返回结果  
            string city = this.textBox1.Text.Trim();//获得文本框录入的查询城市  
            s = w.getWeatherbyCityName(city);
            //以文本框内容为变量实现方法getWeatherbyCityName  
            if (s[8] == "")
            {
                MessageBox.Show("暂时不支持您查询的城市");
            }
            else
            {
                //pictureBox1.Image = Image.FromFile(@"d:\image\" + s[8] + "");
                this.label4.Text = s[1] + " " + s[6];
                textBox2.Text = s[10];
            }
        }
    }
}
