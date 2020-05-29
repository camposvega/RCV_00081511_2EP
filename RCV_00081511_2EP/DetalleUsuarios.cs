using System;
using System.Windows.Forms;

namespace RCV_00081511_2EP
{
    public partial class DetalleUsuarios : UserControl
    {
        public DetalleUsuarios()
        {
            InitializeComponent();
        }

        public DataGridView DataGridView1
        {
            get => dataGridView1;
            set => dataGridView1 = value;
        }

        

        private void cellDobleClickEvent(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.ColumnIndex == 0)
            {
                DialogResult dialogResult = MessageBox.Show("Esta seguro que quiere eliminar esta usuario?"
                    , "Some Title", MessageBoxButtons.YesNo);
                if(dialogResult == DialogResult.Yes)
                {
                    //MessageBox.Show(dgv.SelectedCells[0].Value.ToString());
                    String id = dgv.SelectedCells[0].Value.ToString();
                    try
                    {
                        ConnectionDB.executeNonQuery($"DELETE FROM APPUSER " +
                                                     $"WHERE iduser = {id}");
                        Manager.Instance.llenarTabla(dgv,
                            "SELECT iduser, username, fullname FROM APPUSER");
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
                MessageBox.Show("Si desea borrar un usuario doble click en el ID");
            }
        }
    }
}