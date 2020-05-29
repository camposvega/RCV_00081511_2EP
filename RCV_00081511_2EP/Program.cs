using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RCV_00081511_2EP
{
    static class Program
    {
        
        static void Main()
        {
            try
            {
                var usuarioT = ConnectionDB.executeQuery("SELECT * FROM public.appuser");
                Manager.Instance.Users = new List<User>();
            
                foreach (DataRow dr in usuarioT.Rows)
                {
                    Boolean b = dr[4].ToString().Equals("True");
                    Manager.Instance.Users.Add(new User(dr[0].ToString(),dr[1].ToString(),dr[2].ToString(),dr[3].ToString(),b));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error inesperado");
            }
            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Manager.Instance.FormMain = new Form1();
            Application.Run(Manager.Instance.FormMain);
        }
    }
}