using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyCuaHangNoiThat.Forms.FormBaoCao
{
    public partial class frmBaoCaoHDNcuaNV : Form
    {
        public frmBaoCaoHDNcuaNV()
        {
            InitializeComponent();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
        ProcessDataBase pd = new ProcessDataBase();
        private void BaoCaoHDNcuaNV_Load(object sender, EventArgs e)
        {
            cbMaNV.DataSource = pd.table("select maNV from NhanVien");
            cbMaNV.DisplayMember = "maNV";
            object[] quy = { 1, 2, 3, 4 };
            cbQuy.Items.AddRange(quy);
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangNoiThat.Report.BaoCaoHDNcuaNV.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSetHDN";
            DataTable dt = new DataTable();
            dt = pd.table("select * from dbo.BaoCaoNhap('" + cbQuy.Text + "','" + txtNam.Text
                 + "','" + cbMaNV.Text + "')");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào cho lựa chọn của bạn ", "Thông Báo "
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            reportDataSource.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            ReportParameter MaNV = (new ReportParameter("MaNV", "Mã Nhân Viên :  " + cbMaNV.Text));
            this.reportViewer1.LocalReport.SetParameters(MaNV);

            ReportParameter Quy = (new ReportParameter("Quy", "Quý :  " + cbQuy.Text));
            this.reportViewer1.LocalReport.SetParameters(Quy);

            ReportParameter tt = (new ReportParameter("tt", "Tổng tiền :  " + getTT()));
            this.reportViewer1.LocalReport.SetParameters(tt);

            DateTime dateTime = DateTime.Now;
            ReportParameter day = new ReportParameter
                ("day", "Hà Nội ,Ngày " + dateTime.Day + " Tháng " + dateTime.Month + " Năm " + dateTime.Year);
            this.reportViewer1.LocalReport.SetParameters(day);

            this.reportViewer1.RefreshReport();
        }
        string getTT()
        {
            string tt = null;
            try
            {
                string stringQuery = " select [dbo].GetTongTienNhap('" + cbQuy.Text + "','" + txtNam.Text + "','" + cbMaNV.Text + "')";
                tt = pd.GetValue(stringQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail");
            }
            return tt;
        }
    }
}
