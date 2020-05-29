using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCV_00081511_2EP
{
    public partial class Form1 : Form
    {
        private UserControl current = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Manager.Instance.LoginUser.UserType)
            {
                tableLayoutPanel1.Controls.Remove(current);
                current = new DetalleUsuarios();
                tableLayoutPanel1.Controls.Add(current,0,1);
                tableLayoutPanel1.SetColumnSpan(current,5);   
            }
            else
            {
                tableLayoutPanel1.Controls.Remove(current);
                current = new Login();
                tableLayoutPanel1.Controls.Add(current,0,1);
                tableLayoutPanel1.SetColumnSpan(current,5); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}