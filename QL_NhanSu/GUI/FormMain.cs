using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Data.SqlClient;

namespace GUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            
            string a;
           a= Application.StartupPath.ToString();
           a= a.Substring( 0,a.Length - 13);
            a += "DAL\\DATA\\NhanSu.mdf";
            DBConnect tam = new DBConnect(a);
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
