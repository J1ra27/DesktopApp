using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace QuanLyCuaHangNoiThat.Forms.FormBaoCao
{
    public partial class frmBaoCaoNCC : Form
    {
        public frmBaoCaoNCC()
        {
            InitializeComponent();
        }
        ProcessDataBase pd = new ProcessDataBase();
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangNoiThat.Report.ReportBaoCaoTenNCC.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSetNCC";
            DataTable dt = new DataTable();
            dt = pd.table("select * from dbo.BaocaoNCC('" +
                cbTenNT.SelectedValue.ToString() + "','" + cbThang.Text + "')");
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi nào cho lựa chọn của bạn ", "Thông Báo "
                    , MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }
            reportDataSource.Value = dt;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);

            this.reportViewer1.RefreshReport();
            ReportParameter TenNT = (new ReportParameter("TenNT", "Tên Nội Thất :  " + cbTenNT.Text.ToString()));
            this.reportViewer1.LocalReport.SetParameters(TenNT);

            ReportParameter Thang = new ReportParameter("Thang", "Tháng " + cbThang.Text.ToString());
            this.reportViewer1.LocalReport.SetParameters(Thang);

            DateTime dateTime = DateTime.Now;
            ReportParameter day = new ReportParameter
                ("day", "Hà Nội ,Ngày " + dateTime.Day + " Tháng " + dateTime.Month + " Năm " + dateTime.Year);
            this.reportViewer1.LocalReport.SetParameters(day);

            this.reportViewer1.RefreshReport();
        }

        private void frmBaoCaoNCC_Load(object sender, EventArgs e)
        {
            cbTenNT.DataSource = pd.table("select MaNoiThat,TenNoiThat from DMNoiThat");
            cbTenNT.DisplayMember = "TenNoiThat";
            cbTenNT.ValueMember = "MaNoiThat";
            object[] thangs = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            cbThang.Items.AddRange(thangs);
            cbThang.Text = "1";
            this.reportViewer1.RefreshReport();

        }
    }
}
