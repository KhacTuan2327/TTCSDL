﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;

namespace TTCSDL
{
    public partial class DeTai : Form
    {
        string makhoa = "", quyen = "";
        //DataTable datatable;
        public DeTai()
        {
            InitializeComponent();
        }
        public DeTai(string makhoa, string quyen)
        {
            InitializeComponent();
            this.makhoa = makhoa;
            this.quyen = quyen;
        }
        Modify modify = new Modify();
        detai dt;

        private void DeTai_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            pnlBtn.Visible = false;
            // Hiện bảng
            try
            {
                dataDeTai.DataSource = modify.Table("DT_PQ'" + makhoa + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteTextBoxs()
        {
            txtmadt.Text = "";
            txttendt.Text = "";
            txtkinhphi.Text = "";
            txtchudt.Text = "";
            txtnam.Text = "";
            txtkq.Text = "";
            txtnganh.Text = "";
            txttt.Text = "";
            timedk.Text = "";
            txttieuban.Text = "";
            txtcapql.Text = "";
        }

        private bool CheckTextBoxes()
        {
            if (txtmadt.Text == "") { MessageBox.Show("Vui lòng nhập Mã Đề tài!"); return false; }
            if (txttendt.Text == "") { MessageBox.Show("Vui lòng nhập Tên Đề tài!"); return false; }
            if (txtnganh.Text == "") { MessageBox.Show("Vui lòng nhập Mã ngành!"); return false; }
            if (txtchudt.Text == "") { MessageBox.Show("Vui lòng nhập Chủ Nhiệm!"); return false; }
            if (timedk.Text == "") { MessageBox.Show("Vui lòng nhập thời gian đăng ký!"); return false; }
            return true;
        }

        private void GetValuesTextBox()
        {
            string madt = this.txtmadt.Text;
            string tendt = this.txttendt.Text;
            string kinhphi = this.txtkinhphi.Text;
            string chudt = this.txtchudt.Text;
            string nam = this.txtnam.Text;
            string ketqua = this.txtkq.Text;
            string nganh = this.txtnganh.Text;
            string trangthai = this.txttt.Text;
            string ngaydangky = this.timedk.Text;
            string tieuban = this.txttieuban.Text;
            string capql = this.txtcapql.Text;
            dt = new detai(madt, tendt, kinhphi, ngaydangky, nam, tieuban, nganh, capql, chudt, trangthai, ketqua);
        }


        private void hideSubMenu()
        {
            if (pnlBtn.Visible == true)
                pnlBtn.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }


        private void export2Excel(DataGridView g, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;
            for (int i = 1; i < g.Columns.Count + 1; i++) { obj.Cells[1, i] = g.Columns[i - 1].HeaderText; }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null) { obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString(); }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void btnbb_Click(object sender, EventArgs e)
        {
            BaiBaoKH baiBaoKH = new BaiBaoKH(txtmadt.Text);
            baiBaoKH.ShowDialog();
            hideSubMenu();
        }

        private void btnExportFile_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                export2Excel(dataDeTai, saveFileDialog1.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có muốn Lưu không?");
            if (CheckTextBoxes())
            {
                GetValuesTextBox();
                string query = "UPDATE DETAI SET MADT = N'" + dt.Madt + " ', Tendt = N'" + dt.Tendt + " ', KINHPHI = N' " + dt.Kinhphi + "', NGAYDANGKI = N'" + dt.Ngaydangky + "', NAMTHUCHIEN = N'" + dt.Nam + "', TIENDO = N'" + dt.Tiendo + "', TRANGTHAI = N'" + dt.Trangthai + "', MATB = N'" + dt.Tieuban + "', MANGANH = N'" + dt.Tennganh + "', MACAP = N'" + dt.Capql + "', MACB = N'" + dt.Chudt + "'";
                query += "Where MADT = N'" + dt.Madt + " '";
                //string query = "insert into KHOA values (N'" + "'khoa.Id'" + ",N " + "khoa.Name", N'Hải Phòng', N'Trần Xuân Nam', 0123465433)
                try //insert into khoa value ('khoa.Id', "N'Khoa.name'"
                {
                    if (MessageBox.Show("Bạn có muốn sửa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Sửa thành công!");
                        DeTai_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa: " + ex.Message);
                }
            }
        }

        private void btnDltDT_Click(object sender, EventArgs e)
        {
            if (dataDeTai.Rows.Count > 1)
            {
                string choose = dataDeTai.SelectedRows[0].Cells[0].Value.ToString();
                string query = "XOA_DETAI";
                query += "'" + choose + "'";

                try //insert into khoa value ('khoa.Id', "N'Khoa.name'"
                {
                    if (MessageBox.Show("Bạn có muốn xóa không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        modify.Command(query);
                        MessageBox.Show("Xóa thành công!");
                        DeTai_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa: " + ex.Message);
                }
            }
        }

        private void lbtenkhoa_Click(object sender, EventArgs e)
        {

        }

        private void btnbc_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            BaoCaoTD baoCao = new BaoCaoTD(txtmadt.Text);
            baoCao.ShowDialog();
        }

        private void btnqd_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            QuyetDinh_DT quyetDinh_DT = new QuyetDinh_DT(txtmadt.Text);
            quyetDinh_DT.ShowDialog();
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string name = search.Text.Trim();
            if (name == "")
            {
                DeTai_Load(sender, e);
            }
            else
            {
                string query = "SEARCH_DT'"+search.Text+"'";
                dataDeTai.DataSource = modify.Table(query);
            }
        }

        private void dataDeTai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataDeTai_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TTThanhVien_PD tTThanhVien_PD = new TTThanhVien_PD(txtmadt.Text);
            tTThanhVien_PD.ShowDialog();
        }

        private void dataDeTai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataDeTai.Rows.Count > 1)
            {
                txtmadt.Text = dataDeTai.SelectedRows[0].Cells[0].Value.ToString();
                txttendt.Text = dataDeTai.SelectedRows[0].Cells[1].Value.ToString();
                txtchudt.Text = dataDeTai.SelectedRows[0].Cells[2].Value.ToString();
                txttieuban.SelectedItem = dataDeTai.SelectedRows[0].Cells[3].Value.ToString();
                txtcapql.SelectedItem = dataDeTai.SelectedRows[0].Cells[4].Value.ToString();
                txtnganh.SelectedItem = dataDeTai.SelectedRows[0].Cells[5].Value.ToString();
                timedk.Text = dataDeTai.SelectedRows[0].Cells[6].Value.ToString();
                txtnam.Text = dataDeTai.SelectedRows[0].Cells[7].Value.ToString();
                txttt.Text = dataDeTai.SelectedRows[0].Cells[8].Value.ToString();
                txtkq.Text = dataDeTai.SelectedRows[0].Cells[9].Value.ToString();
                txtkinhphi.Text = dataDeTai.SelectedRows[0].Cells[10].Value.ToString();
            }
            showSubMenu(pnlBtn);
        }
    }
}
