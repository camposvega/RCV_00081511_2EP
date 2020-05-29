using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RCV_00081511_2EP
{
    public class Manager
    {
        private static Manager instance=null;
        private User loginUser;
        private List<User> users;
        private Form1 formMain;
        
        private Manager()
        {
        }
        
        public static Manager Instance
        {
            get
            {
                if (instance==null)
                {
                    instance = new Manager();
                }
                return instance;
            }
        }

        public void btnAdmin()
        {
            formMain.Button1.Enabled = true;
            formMain.Button2.Enabled = true;
            formMain.Button3.Enabled = true;
            formMain.Button4.Enabled = true;
            formMain.Button5.Enabled = true;
        }
        
        public void btnUser()
        {
            formMain.Button1.Enabled = true;
            formMain.Button2.Enabled = true;
            //formMain.Button3.Enabled = true;
            //formMain.Button4.Enabled = true;
            formMain.Button5.Enabled = true;
        }

        public void cambiarStrBtn(Button btn, String str)
        {
            btn.Text = str;
        }
        
        public void cambiarReadO(TextBox te, Boolean bo)
        {
            te.ReadOnly = bo;
        }

        public void llenarTabla(DataGridView dg, String query)
        {
            try
            {
                var dt = ConnectionDB.executeQuery(query);
                dg.DataSource = dt;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error en conn a la BD");
            }
        }

        public Form1 FormMain
        {
            get => formMain;
            set => formMain = value;
        }

        public List<User> Users
        {
            get => users;
            set => users = value;
        }

        public User LoginUser
        {
            get => loginUser;
            set => loginUser = value;
        }

    }
}