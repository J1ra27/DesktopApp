using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat.Forms.FormBaoCao
{
    public partial class frmBaoCaoSanPham : Form
    {
        ProcessDataBase pd = new ProcessDataBase();
        public frmBaoCaoSanPham()
        {
            InitializeComponent();
        }

        private void frmBaoCaoSanPham_Load(object sender, EventArgs e)
        {
            addKhachHang();
            addThang();
            addNam();
            this.reportViewer1.RefreshReport();
        }

        private void addKhachHang()
        {
            cmbKhachHang.DataSource = pd.table("select makhach,tenkhach from KhachHang");
            cmbKhachHang.DisplayMember = "tenkhach";
            cmbKhachHang.ValueMember = "makhach";
        }

        private void addThang()
        {
            for (int i = 1; i <= 12; i++)
            {
                cmbThang.Items.Add(i);
            }
        }

        private void addNam()
        {
            for (int i = 2010; i <= 2050; i++)
            {
                cmbNam.Items.Add(i);
            }
        }

        private bool isChecked()
        {
            if (cmbKhachHang.SelectedValue == null)
            {
                MessageBox.Show("Hãy chọn khách hàng", "Thông báo");
                return false;
            }
            if (cmbThang.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn tháng", "Thông báo");
                return false;
            }
            if (cmbNam.SelectedItem == null)
            {
                MessageBox.Show("Hãy chọn năm", "Thông báo");
                return false;
            }
            return true;
        }
        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (isChecked())
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangNoiThat.Report.ReportBaoCaoSanPham.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSetBaoCaoSanPham";
                DataTable dt = new DataTable();
                dt = pd.table("select * from dbo.baocaosanpham('" + cmbKhachHang.SelectedValue.ToString().Trim() + "'," + cmbThang.Text.ToString().Trim() + "," + cmbNam.Text.ToString().Trim() + ")");
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có bản ghi nào cho lựa chọn của bạn ", "Thông Báo "
                        , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
                reportDataSource.Value = dt;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);

                ReportParameter TenKH = (new ReportParameter("KhachHang", " Tên Khách Hàng :  " + cmbKhachHang.Text));
                this.reportViewer1.LocalReport.SetParameters(TenKH);

                ReportParameter thang = (new ReportParameter("Thang", " Tháng : " + cmbThang.Text + " Năm : " + cmbNam.Text));
                this.reportViewer1.LocalReport.SetParameters(thang);

                DateTime dateTime = DateTime.Now;
                ReportParameter day = new ReportParameter
                    ("NgayTao", "Hà Nội ,Ngày " + dateTime.Day + " Tháng " + dateTime.Month + " Năm " + dateTime.Year);
                this.reportViewer1.LocalReport.SetParameters(day);

                this.reportViewer1.RefreshReport();
            }
        }

        private void gbTimKiem_Enter(object sender, EventArgs e)
        {

        }
    }
}
