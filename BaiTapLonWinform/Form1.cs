using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Reporting.WinForms;

namespace BaiTapLonWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        modify modify = new modify();
        string query = "select *from PHIEUBH";
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "BaiTapLonWinform.Report1.rdlc";
                ReportDataSource reportDataSource=new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                reportDataSource.Value = modify.getAllData(query);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        
    }
}
