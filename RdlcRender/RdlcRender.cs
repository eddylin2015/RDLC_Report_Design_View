using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RdlcRender
{
    public class RdlcRender
    {
        public async Task<object> RenderRdlcToPdf(dynamic input)
        {
            var reportViewer=new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;
            reportViewer.LocalReport.ReportPath = input.rdlcPath;
            //DataTable dataTable=Newtonsoft.Json.JsonConvert.DeserializeObject<DataTable>(dataSourceJson);
            //reportViewer.LocalReport.DataSources.Add(new ReportDataSource(dataSetName,dataTable));
            byte[] pdfBytes = reportViewer.LocalReport.Render(
                format: "PDF",
                deviceInfo: "<DeviceInfo><OutputFormat>PDF</OutputFormat></DeviceInfo>",
                mimeType: out _,
                encoding: out _,
                fileNameExtension: out _,
                warnings: out _,
                streams: out _);
            return Convert.ToBase64String(pdfBytes);
        }
    }
}
