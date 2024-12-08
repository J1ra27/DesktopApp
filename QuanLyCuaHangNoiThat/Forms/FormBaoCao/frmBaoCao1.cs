using Microsoft.Reporting.WinForms;
using System;
using System.Windows.Forms;
using DataTable = System.Data.DataTable;

namespace QuanLyCuaHangNoiThat.Forms.FormBaoCao
{
    public partial class frmBaoCao1 : Form
    {
        public frmBaoCao1()
        {
            InitializeComponent();
        }
        ProcessDataBase pd = new ProcessDataBase();
        private void frmBaoCao1_Load(object sender, EventArgs e)
        {
            cbTenNT.DataSource = pd.table("select MaNoiThat,TenNoiThat from DMNoiThat");
            cbTenNT.DisplayMember = "TenNoiThat";
            cbTenNT.ValueMember = "MaNoiThat";
            this.reportViewer1.RefreshReport();
        }
        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyCuaHangNoiThat.Report.Report1.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "DataSet1";
            DataTable dt = new DataTable();
            dt = pd.table("select * from dbo.Baocao1('" +
                cbTenNT.SelectedValue.ToString() + "')");
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

                string stringQuery = " select [dbo].GetTongTien('" + cbTenNT.SelectedValue.ToString() + "')";
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
