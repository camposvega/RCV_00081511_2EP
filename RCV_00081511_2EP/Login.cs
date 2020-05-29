using System;
using System.Windows.Forms;

namespace RCV_00081511_2EP
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                if (Manager.Instance.LoginUser != null)
                {
                    try
                    {
                        ConnectionDB.executeNonQuery($"UPDATE public.appuser SET password = {textBox2.Text}" +
                                                     $" WHERE iduser = {Manager.Instance.LoginUser.IdUser}");
                        MessageBox.Show("Cambio correcto");
                    }
                    catch (Exception exception)
                    {
                         MessageBox.Show("Ocurrio un error inesperado");
                    }
                }
                else
                {
                    foreach (var user in Manager.Instance.Users)
                    {
                        if (user.Username.Equals(textBox1.Text) && user.Pass.Equals(textBox2.Text))
                        {
                            Manager.Instance.LoginUser = user;
                            MessageBox.Show($"Hola {user.Name}");
                            
                            return;
                        }
                    }
                    
                    MessageBox.Show("Usuario o Contraseña incorrecta");
                    
                    //Manager.Instance.LoginUser = new User();
                }
            }
        }
    }
}