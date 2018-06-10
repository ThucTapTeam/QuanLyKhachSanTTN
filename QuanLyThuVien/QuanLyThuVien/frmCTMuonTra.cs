using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyThuVien;

namespace QLTV
{
    public partial class frmCTMuonTra : Form
    {
        string strConn = @"Data Source=DESKTOP-SSCJKUR;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        int chon;
        public frmCTMuonTra()
        {
            InitializeComponent();
            conn = new SqlConnection(strConn);
            conn.Open();
            LoadCTMuonTra();
            btnLuu.Enabled = false;
            loadDBCombobox();

        }
        private void LoadCTMuonTra()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from CTMuonTra", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                cboMaPM.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["MaPM"].Value);
                cboMaSach.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["MaSach"].Value);
                dtNgayTra.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["NgayTra"].Value);
                txtTrangThai.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["TrangThai"].Value);
                rtbGHICHU.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["GhiChu"].Value);
            }
        }
        public void loadDBCombobox()
        {
            SqlCommand cmd = new SqlCommand("select MaPM from PhieuMuon", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cboMaPM.DataSource = ds.Tables[0];
            cboMaPM.ValueMember = "MaPM";

            SqlCommand cmd1 = new SqlCommand("select MaSach from Sach", conn);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd1);
            DataSet ds1 = new DataSet();
            da1.Fill(ds1);
            cboMaSach.DataSource = ds1.Tables[0];
            cboMaSach.ValueMember = "MaSach";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            chon = 1;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            chon = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            chon = 3;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            switch (chon)
            {
                case 1:
                    {
                        SqlCommand cmd = new SqlCommand("Sp_AddCTMuonTra", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p = new SqlParameter("@MaPM", cboMaPM.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@MaSach", cboMaSach.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@NgayTra", dtNgayTra.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@TrangThai", txtTrangThai.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@GhiChu", rtbGHICHU.Text);
                        cmd.Parameters.Add(p);
                        int count = cmd.ExecuteNonQuery();
                        if (count >= 1)
                        {
                            MessageBox.Show("Thêm mới thành công");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm mới");
                        }
                        LoadCTMuonTra();
                        break;
                    }
                case 2:
                    {
                        SqlCommand cmd = new SqlCommand("Sp_UpdateCTMuonTra", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p = new SqlParameter("@MaPM", cboMaPM.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@MaSach", cboMaSach.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@NgayTra", dtNgayTra.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@TrangThai", txtTrangThai.Text);
                        cmd.Parameters.Add(p);
                        p = new SqlParameter("@GhiChu", rtbGHICHU.Text);
                        cmd.Parameters.Add(p);
                        int count = cmd.ExecuteNonQuery();
                        if (count >= 1)
                        {
                            MessageBox.Show("Sửa thành công");
                        }
                        else
                        {
                            MessageBox.Show("Không thể sửa được");
                        }
                        LoadCTMuonTra();
                        break;
                    }
                case 3:
                    {
                        SqlCommand cmd = new SqlCommand("Sp_DeleteCTMuonTra", conn);
                        cmd.CommandType = CommandType.StoredProcedure;
                        SqlParameter p = new SqlParameter("@MaPM", cboMaPM.Text);
                        cmd.Parameters.Add(p);
                        int count = cmd.ExecuteNonQuery();
                        if (count >= 1)
                        {
                            MessageBox.Show("Xoá thành công");
                        }
                        else
                        {
                            MessageBox.Show("Không thể xoá được");
                        }
                        LoadCTMuonTra();
                        break;
                    }

            }
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
