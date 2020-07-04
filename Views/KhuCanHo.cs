using KhuCanHo.Controller;
using KhuCanHo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhuCanHo
{
    public partial class KhuCanHo : Form
    {
        KhuCanHoDAL kch = new KhuCanHoDAL();

        public void RefreshForm()
        {
            dataGridView_KhuCanHo.DataSource = NhanVien_Controller.Instance.Load_KhuCanHo();
            dataGridView_KhuCanHo.ReadOnly = true;
        }
        public KhuCanHo()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void button_them_KhuCanHo_MouseClick(object sender, MouseEventArgs e)
        {
            AddKhuCanHo addKhuCanHo = new AddKhuCanHo();
            addKhuCanHo.Show(this);
            RefreshForm();
        }

        private void button_sua_KhuCanHo_MouseClick(object sender, MouseEventArgs e)
        {

            EditKhuCanHo editKhuCanHo = new EditKhuCanHo(kch);
            editKhuCanHo.Show(this);
            RefreshForm();
        }

        private void dataGridView_KhuCanHo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_KhuCanHo.CurrentRow.Selected = true;
            int index = e.RowIndex;
            if (index >= 0)
            {
                kch.maKhu = dataGridView_KhuCanHo.Rows[index].Cells["maKhu"].Value.ToString();
                kch.tenKhu = dataGridView_KhuCanHo.Rows[index].Cells["tenKhu"].Value.ToString();
                kch.soCan = Int32.Parse(dataGridView_KhuCanHo.Rows[index].Cells["soCanHo"].Value.ToString());
                kch.soTang = Int32.Parse(dataGridView_KhuCanHo.Rows[index].Cells["soTang"].Value.ToString());
                kch.diaChi = dataGridView_KhuCanHo.Rows[index].Cells["diaChi"].Value.ToString();
            }
        }


        private void dataGridView_KhuCanHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_KhuCanHo.CurrentRow.Selected = true;
            int index = e.RowIndex;
            if (index >= 1)
            {
                
                kch.maKhu = dataGridView_KhuCanHo.Rows[index].Cells["maKhu"].Value.ToString();
                kch.tenKhu = dataGridView_KhuCanHo.Rows[index].Cells["tenKhu"].Value.ToString();
                kch.soCan = Int32.Parse(dataGridView_KhuCanHo.Rows[index].Cells["soCanHo"].Value.ToString());
                kch.soTang = Int32.Parse(dataGridView_KhuCanHo.Rows[index].Cells["soTang"].Value.ToString());
                kch.diaChi = dataGridView_KhuCanHo.Rows[index].Cells["diaChi"].Value.ToString();
            }
        }



        private void button_Del_KhuCanHo_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhanVien_Controller.Instance.Del_KhuCanHo(kch);
                MessageBox.Show("Đã xóa thành công!");
                dataGridView_KhuCanHo.DataSource = NhanVien_Controller.Instance.Load_KhuCanHo();
           
            }  
        }

        private void textBox_timKiemKhuCanHo_TextChanged(object sender, EventArgs e)
        {
            if (textBox_timKiemKhuCanHo.Text != "")
            {
                string searchstr, field;
                searchstr = textBox_timKiemKhuCanHo.Text;
                field = "maKhu";
                switch (comboBox_timKiem.SelectedIndex)
                {
                    case 0:
                        field = "maKhu";
                        // code block
                        break;
                    case 1:
                        field = "tenKhu";
                        // code block
                        break;
                    case 2:
                        field = "soTang";
                        // code block
                        break;
                    case 3:
                        field = "soCan";
                        // code block
                        break;
                    case 4:
                        field = "diaChi";
                        // code block
                        break;

                }
                dataGridView_KhuCanHo.DataSource = NhanVien_Controller.Instance.Search_KhuCanHo(searchstr, field);
            }
            else
            {
                dataGridView_KhuCanHo.DataSource = NhanVien_Controller.Instance.Load_KhuCanHo();
            }

        }
        //

        //
    }
}
