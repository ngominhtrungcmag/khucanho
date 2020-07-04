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
    public partial class CanHo : Form
    {
        CanHoDAL caho = new CanHoDAL();

        public void RefreshForm()
        {
            dataGridView_canHo.DataSource = NhanVien_Controller.Instance.Load_CanHo();
            dataGridView_canHo.ReadOnly = true;
        }
        public CanHo()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void button_them_CanHo_MouseClick(object sender, MouseEventArgs e)
        {
            AddCanHo addCanHo = new AddCanHo();
            addCanHo.Show(this);
            RefreshForm();

        }

        private void button_sua_CanHo_MouseClick(object sender, MouseEventArgs e)
        {
            EditCanHo editCanHo = new EditCanHo(caho);
            editCanHo.Show(this);
            RefreshForm();

        }

        private void button_xoa_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhanVien_Controller.Instance.Del_CanHo(caho);
                MessageBox.Show("Đã xóa thành công!");
                dataGridView_canHo.DataSource = NhanVien_Controller.Instance.Load_CanHo();
            }
        }

        private void dataGridView_canHo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        //    int temp1 = 1, temp2 = 0;
            dataGridView_canHo.CurrentRow.Selected = true;
            int index = e.RowIndex;
            if (index >= 0)
            {
                caho.maCanHo = dataGridView_canHo.Rows[index].Cells["maCanHo"].Value.ToString();
                caho.dienTich = dataGridView_canHo.Rows[index].Cells["dienTich"].Value.ToString();
                caho.giaBan = Int32.Parse(dataGridView_canHo.Rows[index].Cells["giaBan"].Value.ToString());
                if (dataGridView_canHo.Rows[index].Cells["trangThai"].Value.ToString() == "True")
                {
                    caho.trangThai = 1;
                }
                if (dataGridView_canHo.Rows[index].Cells["trangThai"].Value.ToString() == "False")
                {
                    caho.trangThai = 0;
                }
             //   caho.trangThai =Byte.Parse(dataGridView_canHo.Rows[index].Cells["trangThai"].Value.ToString());
                caho.soPhong = Int32.Parse(dataGridView_canHo.Rows[index].Cells["soPhong"].Value.ToString());
                caho.maKhu = dataGridView_canHo.Rows[index].Cells["maKhu"].Value.ToString();
            }
        }

        private void dataGridView_canHo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_canHo.CurrentRow.Selected = true;
            int index = e.RowIndex;
            if (index >= 0)
            {
                caho.maCanHo = dataGridView_canHo.Rows[index].Cells["maCanHo"].Value.ToString();
                caho.dienTich = dataGridView_canHo.Rows[index].Cells["dienTich"].Value.ToString();
                caho.giaBan = Int32.Parse(dataGridView_canHo.Rows[index].Cells["giaBan"].Value.ToString());
                if (dataGridView_canHo.Rows[index].Cells["trangThai"].Value.ToString() == "True")
                {
                    caho.trangThai = 1;
                }
                if (dataGridView_canHo.Rows[index].Cells["trangThai"].Value.ToString() == "False")
                {
                    caho.trangThai = 0;
                }
                //   caho.trangThai =Byte.Parse(dataGridView_canHo.Rows[index].Cells["trangThai"].Value.ToString());
                caho.soPhong = Int32.Parse(dataGridView_canHo.Rows[index].Cells["soPhong"].Value.ToString());
                caho.maKhu = dataGridView_canHo.Rows[index].Cells["maKhu"].Value.ToString();
            }
        }

        private void textBox_timCanHo_TextChanged(object sender, EventArgs e)
        {
            if (textBox_timCanHo.Text != "")
            {
                string searchstr, field;
                searchstr = textBox_timCanHo.Text;
                field = "maKhu";
                switch (comboBox_timKiem.SelectedIndex)
                {
                    case 0:
                        field = "maKhu";
                        // code block
                        break;
                    case 1:
                        field = "maCanHo";
                        // code block
                        break;
                    case 2:
                        field = "dienTich";
                        // code block
                        break;
                    case 3:
                        field = "giaBan";
                        // code block
                        break;
                    case 4:
                        field = "trangThai";
                        // code block
                        break;
                    case 5:
                        field = "soPhong";
                        // code block
                        break;
                }
               dataGridView_canHo.DataSource = NhanVien_Controller.Instance.Search_CanHo(searchstr, field);
            }   
            else
            {
                dataGridView_canHo.DataSource = NhanVien_Controller.Instance.Load_CanHo();
            } 
        }
    }
}
