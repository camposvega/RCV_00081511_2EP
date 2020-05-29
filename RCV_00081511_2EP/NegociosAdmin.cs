using System;
using System.Windows.Forms;

namespace RCV_00081511_2EP
{
    public partial class NegociosAdmin : UserControl
    {
        public NegociosAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Debe llenar todos los datos");
            }
            else
            {
                DataGridView dgv = dataGridView1;
                try
                {
                    ConnectionDB.executeNonQuery($"INSERT INTO business(name, description) " +
                                                 $"VALUES ('{textBox1.Text}', '{textBox2.Text}')");
                    Manager.Instance.llenarTabla(dgv,
                        "SELECT * FROM business");
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Error en la conn a la BD");
                    MessageBox.Show(exception.Message);
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
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar esta Negocio?"
                    , "Some Title", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    //MessageBox.Show(dgv.SelectedCells[0].Value.ToString());
                    String id = dgv.SelectedCells[0].Value.ToString();
                    try
                    {
                        ConnectionDB.executeNonQuery($"DELETE FROM business " +
                                                     $"WHERE idbusiness = {id}");
                        Manager.Instance.llenarTabla(dgv,
                            "SELECT * FROM business");
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
                MessageBox.Show("Si desea borrar un negocio doble click en el ID");
            }
        }
    }
}