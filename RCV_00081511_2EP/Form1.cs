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
                Manager.Instance.llenarTabla(((DetalleUsuarios)current).DataGridView1,
                    "SELECT iduser, username, fullname FROM APPUSER");
                tableLayoutPanel1.Controls.Add(current,0,1);
                tableLayoutPanel1.SetColumnSpan(current,5);   
            }
            else
            {
                tableLayoutPanel1.Controls.Remove(current);
                current = new Login();
                Manager.Instance.cambiarStrBtn(((Login)current).Button1,"Guardar");
                Manager.Instance.cambiarReadO(((Login)current).TextBox1, true);
                tableLayoutPanel1.Controls.Add(current,0,1);
                tableLayoutPanel1.SetColumnSpan(current,5); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Remove(current);
            current = new NegociosAdmin();
            Manager.Instance.llenarTabla(((NegociosAdmin)current).DataGridView1,
                "SELECT * FROM business");
            tableLayoutPanel1.Controls.Add(current,0,1);
            tableLayoutPanel1.SetColumnSpan(current,5); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        public TableLayoutPanel TableLayoutPanel1
        {
            get => tableLayoutPanel1;
            set => tableLayoutPanel1 = value;
        }
        
        public Button Button1
        {
            get => button1;
            set => button1 = value;
        }

        public Button Button2
        {
            get => button2;
            set => button2 = value;
        }

        public Button Button3
        {
            get => button3;
            set => button3 = value;
        }

        public Button Button4
        {
            get => button4;
            set => button4 = value;
        }

        public Button Button5
        {
            get => button5;
            set => button5 = value;
        }
    }
}