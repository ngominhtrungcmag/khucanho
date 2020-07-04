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
    public partial class DienNuocKhac : Form
    {
        DienNuocDAL dinc = new DienNuocDAL();

        public void RefreshForm()
        {
            dataGridView_dienNuoc.DataSource = NhanVien_Controller.Instance.Load_DienNuocKhac();
            dataGridView_dienNuoc.ReadOnly = true;
  
        }
        public DienNuocKhac()
        {
            InitializeComponent();
            RefreshForm();
        }

        private void button_them_DienNuoc_MouseClick(object sender, MouseEventArgs e)
        {
            AddDienNuoc addDienNuoc = new AddDienNuoc();
            addDienNuoc.Show(this);
            RefreshForm();
        }

        private void button_sua_DienNuoc_MouseClick(object sender, MouseEventArgs e)
        {
            EditDienNuoc editDienNuoc = new EditDienNuoc(dinc);
            editDienNuoc.Show(this);
            RefreshForm();
        }

        private void dataGridView_dienNuoc_Click(object sender, EventArgs e)
        {
            dataGridView_dienNuoc.CurrentRow.Selected = true;
            int index = dataGridView_dienNuoc.CurrentRow.Index;
            if (index >= 0)
            {
                dinc.maCanHo = dataGridView_dienNuoc.Rows[index].Cells["maCanHo"].Value.ToString();
             //   dinc.trangThai = dataGridView_dienNuoc.Rows[index].Cells["trangThai"].Value.ToString();
                dinc.eChiSoCu = Int32.Parse(dataGridView_dienNuoc.Rows[index].Cells["eChiSoCu"].Value.ToString());
                dinc.eChiSoMoi = Int32.Parse(dataGridView_dienNuoc.Rows[index].Cells["eChiSoMoi"].Value.ToString());
                dinc.eChiSoCu = Int32.Parse(dataGridView_dienNuoc.Rows[index].Cells["wChiSoCu"].Value.ToString());
                dinc.eChiSoMoi = Int32.Parse(dataGridView_dienNuoc.Rows[index].Cells["wChiSoMoi"].Value.ToString());
            }
        }

        private void button_xoa_DienNuoc_MouseClick(object sender, MouseEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                NhanVien_Controller.Instance.Del_DienNuoc(dinc);
                MessageBox.Show("Đã xóa..!");
                dataGridView_dienNuoc.DataSource = NhanVien_Controller.Instance.Load_DienNuocKhac();
            }
        }

        private void dataGridView_dienNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView_dienNuoc.CurrentRow.Selected = true;
            int index = e.RowIndex;
            if (index >= 0)
            {
                dinc.maCanHo = dataGridView_dienNuoc.Rows[index].Cells["maCanHo"].Value.ToString();
                dinc.eChiSoCu = Int32.Parse(dataGridView_dienNuoc.Rows[index].Cells["eChiSoCu"].Value.ToString());
                dinc.eChiSoMoi = Int32.Parse(dataGridView_dienNuoc.Rows[index].Cells["eChiSoMoi"].Value.ToString());
                dinc.eChiSoCu = Int32.Parse(dataGridView_dienNuoc.Rows[index].Cells["wChiSoCu"].Value.ToString());
                dinc.eChiSoMoi = Int32.Parse(dataGridView_dienNuoc.Rows[index].Cells["wChiSoMoi"].Value.ToString());

            }
        }

        private void textBox_timKiem_TextChanged(object sender, EventArgs e)
        {
            if (textBox_timKiem.Text != "")
            {
                string searchstr, field;
                searchstr = textBox_timKiem.Text;
                field = "maCanHo";
                switch (comboBox_timKiem.SelectedIndex)
                {
                    case 0:
                        field = "maCanHo";
                        // code block
                        break;
               }
                dataGridView_dienNuoc.DataSource = NhanVien_Controller.Instance.Search_DienNuoc(searchstr, field);
            }
            else
            {
                dataGridView_dienNuoc.DataSource = NhanVien_Controller.Instance.Load_DienNuocKhac();
            }
        }
    }
}
