using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_LoadRep3(sender, e);
        }
        public DataTable myDataTable = new DataTable("DataSet1");
        public DataTable STDTRANDataTable = new DataTable("DataSet1");
        public DataTable STDMARKDataTable = new DataTable("DataSet1");
        public DataTable STDCDDataTable = new DataTable("DataSet1");
        private void Form1_LoadRep4(object sender, EventArgs e)
        {

            myDataTable.Columns.Add("STDID", typeof(string));
            myDataTable.Columns.Add("STDNAME", typeof(string));
            myDataTable.Rows.Add("1", "Alice");
            myDataTable.Rows.Add("2", "Bob");
            myDataTable.Rows.Add("3", "Charlie");
            STDTRANDataTable.Columns.Add("TRID", typeof(string));
            STDTRANDataTable.Columns.Add("STDID", typeof(string));
            STDTRANDataTable.Columns.Add("YEAR", typeof(string));
            STDTRANDataTable.Columns.Add("CLASSNO", typeof(string));
            STDTRANDataTable.Columns.Add("SEAT", typeof(string));
            STDTRANDataTable.Rows.Add("1", "1", "1", "1", "Alice");
            STDTRANDataTable.Rows.Add("2", "1", "1", "1", "Bob");
            STDTRANDataTable.Rows.Add("3", "2", "1", "1", "Charlie");

            STDMARKDataTable.Columns.Add("SCID", typeof(string));
            STDMARKDataTable.Columns.Add("STDID", typeof(string));
            STDMARKDataTable.Columns.Add("YEAR", typeof(string));
            STDMARKDataTable.Columns.Add("COURSE", typeof(string));
            STDMARKDataTable.Columns.Add("MARK", typeof(string));
            STDMARKDataTable.Rows.Add("1", "1", "1", "1", "Alice");
            STDMARKDataTable.Rows.Add("2", "1", "1", "1", "Bob");
            STDMARKDataTable.Rows.Add("3", "2", "1", "1", "Charlie");

            STDCDDataTable.Columns.Add("CDID", typeof(string));
            STDCDDataTable.Columns.Add("STDID", typeof(string));
            STDCDDataTable.Columns.Add("YEAR", typeof(string));
            STDCDDataTable.Columns.Add("CD", typeof(string));
            STDCDDataTable.Rows.Add("1", "1", "1", "Alice");
            STDCDDataTable.Rows.Add("2", "1", "1", "Bob");
            STDCDDataTable.Rows.Add("3", "2", "1", "Charlie");

            // Age will be 0 due to DefaultValue
            //List<ReportParameter> parameters = new List<ReportParameter>();
            //parameters.Add(new ReportParameter("ReportParameter1", "10250"));
            //this.reportViewer1.LocalReport.SetParameters(parameters);
            // Print the DataTable to see the new column
            // Set the parameters to the LocalReport object of your ReportViewer
            foreach (DataRow row in myDataTable.Rows)
            {
                //Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}, Age: {row["Age"]}");
            }



            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", STDMARKDataTable));
            var path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));
            var MainPage = path + @"\STDMARKREP.rdlc";
            this.reportViewer1.LocalReport.ReportPath = MainPage;
            //this.reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.Refresh();
            this.reportViewer1.RefreshReport();


        }
        private void Form1_LoadRep3(object sender, EventArgs e)
        {
            
            myDataTable.Columns.Add("STDID", typeof(string));
            myDataTable.Columns.Add("STDNAME", typeof(string));
            myDataTable.Rows.Add("1", "Alice");
            myDataTable.Rows.Add("2", "Bob");
            myDataTable.Rows.Add("3", "Charlie");
            STDTRANDataTable.Columns.Add("TRID", typeof(string));
            STDTRANDataTable.Columns.Add("STDID", typeof(string));
            STDTRANDataTable.Columns.Add("YEAR", typeof(string));
            STDTRANDataTable.Columns.Add("CLASSNO", typeof(string));
            STDTRANDataTable.Columns.Add("SEAT", typeof(string));
            STDTRANDataTable.Rows.Add("1","1", "1","1","Alice");
            STDTRANDataTable.Rows.Add("2","1", "1", "1", "Bob");
            STDTRANDataTable.Rows.Add("3", "2", "1", "1", "Charlie");
            
            STDMARKDataTable.Columns.Add("SCID", typeof(string));
            STDMARKDataTable.Columns.Add("STDID", typeof(string));
            STDMARKDataTable.Columns.Add("YEAR", typeof(string));
            STDMARKDataTable.Columns.Add("COURSE", typeof(string));
            STDMARKDataTable.Columns.Add("MARK", typeof(string));
            STDMARKDataTable.Rows.Add("1", "1", "1", "1", "Alice");
            STDMARKDataTable.Rows.Add("2", "1", "1", "1", "Bob");
            STDMARKDataTable.Rows.Add("3", "2", "1", "1", "Charlie");
            
            STDCDDataTable.Columns.Add("CDID", typeof(string));
            STDCDDataTable.Columns.Add("STDID", typeof(string));
            STDCDDataTable.Columns.Add("YEAR", typeof(string));
            STDCDDataTable.Columns.Add("CD", typeof(string));
            STDCDDataTable.Rows.Add("1", "1", "1", "Alice");
            STDCDDataTable.Rows.Add("2", "1", "1", "Bob");
            STDCDDataTable.Rows.Add("3", "2", "1", "Charlie");

            // Age will be 0 due to DefaultValue
            //List<ReportParameter> parameters = new List<ReportParameter>();
            //parameters.Add(new ReportParameter("ReportParameter1", "10250"));
            //this.reportViewer1.LocalReport.SetParameters(parameters);
            // Print the DataTable to see the new column
            // Set the parameters to the LocalReport object of your ReportViewer
            foreach (DataRow row in myDataTable.Rows)
            {
                //Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}, Age: {row["Age"]}");
            }
            
            

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("STDINFO", myDataTable));
            var path = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())));
            var MainPage = path + @"\Report3.rdlc";
            //this.reportViewer1.LocalReport.ReportPath = MainPage;
            this.reportViewer1.LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            this.reportViewer1.LocalReport.EnableExternalImages = true;
            this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            this.reportViewer1.Refresh();
            this.reportViewer1.RefreshReport();

        
        }
        private void LocalReport_SubreportProcessing(object sender, SubreportProcessingEventArgs e)
         {  
             var STDID = e.Parameters[0].Values[0];  
             //var employeegroup = Employees.FindAll(x => x.ID == ID);
            if (e.ReportPath == "STDTRANREP") {
                var STDTRANREP = new ReportDataSource()
                {
                    Name = "STDTRAN",
                    Value = this.STDTRANDataTable
                };
                e.DataSources.Add(STDTRANREP);
            }
            if (e.ReportPath == "subReport1") {
                var STDMARKREP = new ReportDataSource()
                {
                    Name = "DataSet1",
                    Value = this.STDMARKDataTable
                };
                e.DataSources.Add(STDMARKREP);
            }
            if (e.ReportPath == "STDCDREP")  
             {  
                 var STDCDREP = new ReportDataSource()
                    {
                        Name = "STDCD",
                        Value = this.STDCDDataTable
                    };  
                 e.DataSources.Add(STDCDREP);  
             }  
         }
private void Form1_LoadRep2(object sender, EventArgs e)
        {
            DataTable myDataTable = new DataTable("DataSet1");
            // Add some existing columns
            myDataTable.Columns.Add("DataColumn1", typeof(string));
            myDataTable.Columns.Add("DataColumn2", typeof(string));
            // Add some data to the table
            myDataTable.Rows.Add("1", "Alice");
            myDataTable.Rows.Add("2", "Bob");
            myDataTable.Rows.Add("3", "Charlie"); // Age will be 0 due to DefaultValue
            List<ReportParameter> parameters = new List<ReportParameter>();
            parameters.Add(new ReportParameter("ReportParameter1", "10250"));
            // Print the DataTable to see the new column
            foreach (DataRow row in myDataTable.Rows)
            {
                //Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}, Age: {row["Age"]}");
            }
            // Set the parameters to the LocalReport object of your ReportViewer
            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", myDataTable));

            this.reportViewer1.RefreshReport();
        }
        private void Form1_LoadRep1(object sender, EventArgs e) 
        { 
            DataTable myDataTable = new DataTable("DataSet1");
            // Add some existing columns
            myDataTable.Columns.Add("DataColumn1", typeof(string));
            myDataTable.Columns.Add("DataColumn2", typeof(string));
            // Add some data to the table
            myDataTable.Rows.Add("1", "Alice");
            myDataTable.Rows.Add("2", "Bob");
            myDataTable.Rows.Add("3", "Charlie"); // Age will be 0 due to DefaultValue
            List<ReportParameter> parameters = new List<ReportParameter>();
            parameters.Add(new ReportParameter("ReportParameter1", "10250"));
            // Print the DataTable to see the new column
            foreach (DataRow row in myDataTable.Rows)
            {
                //Console.WriteLine($"ID: {row["ID"]}, Name: {row["Name"]}, Age: {row["Age"]}");
            }
            // Set the parameters to the LocalReport object of your ReportViewer
            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", myDataTable));

            this.reportViewer1.RefreshReport();
        }
    }
}
