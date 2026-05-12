using BusinessLayer;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormReportDoanhThu : Form
    {
        private DateTime _tuNgay;
        private DateTime _denNgay;
        DoanhThuBL doanhThuBL = new DoanhThuBL();
        public FormReportDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            InitializeComponent();
            _tuNgay = tuNgay;
            _denNgay = denNgay;
        }

        private void FormReportDoanhThu_Load(object sender, EventArgs e)
        {

            LoadReport();
        }
        private void LoadReport()
        {
            DataTable dt = doanhThuBL.LayDoanhThuTheoNgay(_tuNgay, _denNgay);

            reportViewer1.ProcessingMode = ProcessingMode.Local;

            reportViewer1.LocalReport.ReportPath = Application.StartupPath + "\\ReportDoanhThu.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();

            ReportDataSource rds = new ReportDataSource("DataSetDoanhThu", dt);
            reportViewer1.LocalReport.DataSources.Add(rds);

            ReportParameter[] parameters =
            {
                new ReportParameter("TuNgay", _tuNgay.ToString("dd/MM/yyyy")),
                new ReportParameter("DenNgay", _denNgay.ToString("dd/MM/yyyy"))
            };

            reportViewer1.LocalReport.SetParameters(parameters);

            reportViewer1.RefreshReport();
        }
    }
}
