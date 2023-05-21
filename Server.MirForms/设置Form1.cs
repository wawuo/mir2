using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.MirObjects;
using Shared;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static Server.MirObjects.HumanObject;

namespace Server
{
    public partial class myForm1 : Form
    {


        public myForm1()
        {
            InitializeComponent();

            // 从文件中读取 bool 值并设置 CheckBox 的状态
            切换穿怪cb.Checked = Settings.穿怪;


        }


        //public void Save()
        //{
        //    Settings.穿怪 = 切换穿怪cb.Checked;
        //}
        private void 切换穿怪cb_CheckedChanged(object sender, EventArgs e)
        {

            Settings.穿怪 = 切换穿怪cb.Checked;

            变量.穿怪 = Settings.穿怪;

            Settings.Save();
            //using (FileStream fs = new FileStream(变量.配置文件, FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    StreamWriter writer = new StreamWriter(fs);
            //    writer.Write(切换穿怪cb.Checked);
            //}


        }
        private void 设置Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
