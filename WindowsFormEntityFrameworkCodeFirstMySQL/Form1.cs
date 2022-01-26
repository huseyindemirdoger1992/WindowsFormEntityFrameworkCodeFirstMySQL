using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormEntityFrameworkCodeFirstMySQL.Models;

namespace WindowsFormEntityFrameworkCodeFirstMySQL
{
    public partial class Form1 : Form
    {
        ApplicationConnectionDb db = new ApplicationConnectionDb();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Personel.ToList();
        }
    }
}
