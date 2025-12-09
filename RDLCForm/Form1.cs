using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDLCForm
{
    public partial class Form1 : Form
    {
        private IEnumerable<Tbl1> tbl = new List<Tbl1>()
        {
            new Tbl1(){CountryName="a",StateProvince="a"},
            new Tbl1(){CountryName="b",StateProvince="b"},
            new Tbl1(){CountryName="c",StateProvince="c"}
        };
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource() { Name = "DataSet1" ,Value=tbl});
            this.reportViewer1.RefreshReport();
        }
    }
}
