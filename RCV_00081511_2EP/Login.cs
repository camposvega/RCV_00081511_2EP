using System;
using System.Windows.Forms;

namespace RCV_00081511_2EP
{
    public partial class Login : UserControl
    {
        private UserControl current = null;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((textBox1.Text.Equals("") || textBox2.Text.Equals("")) && Manager.Instance.LoginUser == null) ||
                (textBox2.Text.Equals("") && Manager.Instance.LoginUser != null))
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
                            
                            Manager.Instance.FormMain.TableLayoutPanel1.Controls.Remove(current);
                            current = new WelcomeUser();
                            Manager.Instance.FormMain.TableLayoutPanel1.Controls.Add(current,0,1);
                            Manager.Instance.FormMain.TableLayoutPanel1.SetColumnSpan(current,5);
                            if (user.UserType)
                            {
                                Manager.Instance.btnAdmin();
                            }
                            else
                            {
                                Manager.Instance.btnUser();
                            }

                            return;
                        }
                    }
                    
                    MessageBox.Show("Usuario o Contraseña incorrecta");
                    
                    //Manager.Instance.LoginUser = new User();
                }
            }
        }

        public Button Button1
        {
            get => button1;
            set => button1 = value;
        }

        public TextBox TextBox1
        {
            get => textBox1;
            set => textBox1 = value;
        }
    }
}