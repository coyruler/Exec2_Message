using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Button click 時, 用 Label 顯示目前系統時間及問候語用
             * MessageBox 顯示目前時間,格式為 yyyy/MM/dd HH:mm:ss
             * Button click 時, 用 Label 顯示目前系統時間及問候語(用兩行呈現)
             */
            DateTime now = DateTime.Now;
            string message = $"你好，現在時間是:{now:yyyy/MM/dd HH:mm:ss}";
            lblGreeting1.Text = message;
            MessageBox.Show($"目前時間是 {now:yyyy/MM/dd HH:mm:ss}");
        }

        private void btnGreet2_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string message = $"你好，現在時間是:\r\n{now:yyyy/MM/dd HH:mm:ss}";
            lblGreeting2.Text = message;

        }
    }
}
