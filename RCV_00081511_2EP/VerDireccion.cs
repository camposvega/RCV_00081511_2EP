using System;
using System.Windows.Forms;

namespace RCV_00081511_2EP
{
    public partial class VerDireccion : UserControl
    {
        public VerDireccion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Equals(""))
            {    
                DataGridView dgv = dataGridView1;
                try
                {
                    ConnectionDB.executeNonQuery($"INSERT INTO ADDRESS(idUser, address) " +
                                                 $"VALUES({Manager.Instance.LoginUser.IdUser}," +
                                                 $" '{textBox1.Text}')");
                    Manager.Instance.llenarTabla(dgv,
                        $"SELECT * FROM ADDRESS where iduser = {Manager.Instance.LoginUser.IdUser}");
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            }
        }

        public DataGridView DataGridView1
        {
            get => dataGridView1;
            set => dataGridView1 = value;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.ColumnIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar esta direccion?"
                    , "Some Title", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    //MessageBox.Show(dgv.SelectedCells[0].Value.ToString());
                    String id = dgv.SelectedCells[0].Value.ToString();
                    try
                    {
                        ConnectionDB.executeNonQuery($"DELETE FROM ADDRESS " +
                                                     $"WHERE idaddress = {id}");
                        Manager.Instance.llenarTabla(dgv,
                            $"SELECT * FROM ADDRESS where iduser = {Manager.Instance.LoginUser.IdUser}");
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show("Error en la conn");
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    
                    
                }
                
            }
            else
            {
                MessageBox.Show("Si desea borrar una dirrecion doble click en el ID");
            }
        }
    }
}