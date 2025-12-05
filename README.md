# RDLC_Report_Design_View

## 微专业课程-进阶-3小时rdlc报表

即吃面，短视频，快餐体验课程。

课程是指電腦程式职业技能，即吃即用，快吃又有營養，技能入門，給你0到1的體驗，

幫助同學提高趣味感成就感,滿滿干貨,電腦程式必備技能。有类培训课程实用主义。学完体验课程衔接职业培训中心CM课程,资深导师继续深造。

## 基礎知識

- 初级 C#, Console 
- 中阶 WinForm , Dll
- 高级 Mysql, DataSet
- 阶级 Edge-JS (rdlc_render.dll Export PDF using Node.js)
  
## 工具

- Microsoft RDLC Report Designer
https://marketplace.visualstudio.com/items?itemName=ProBITools.MicrosoftRdlcReportDesignerforVisualStudio-18001
- Microsoft.ReportViewer.Runtime.WinForms
NuGet\Install-Package Microsoft.ReportViewer.Runtime.WinForms -Version 12.0.2402.15
- Install Microsoft Report Builder
https://www.microsoft.com/en-us/download/details.aspx?id=53613

## C# Basics Tutorial for Beginners (Deepseek 教程)
## C# WinForms Tutorial
## MySQL and DataSet in C# WinForms
## RDLC 教学大纲

- 1.simple report , image
- 2.DataSet and List , Table, Matrix
- 3.Group(footer, header)
- 4.Sub Report

### 实验代码
```C#
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
            if (e.ReportPath == "subReport1") {
                var STDMARKREP = new ReportDataSource()
                {
                    Name = "DataSet1",
                    Value = this.STDMARKDataTable
                };
                e.DataSources.Add(STDMARKREP);
                var STDCDREP14 = new ReportDataSource()
                {
                    Name = "DataSet2",
                    Value = this.STDCDDataTable
                };
                e.DataSources.Add(STDCDREP14);
            }
         }
  ```

### Display Booleans on an RDLC Report

Change the font to Wingdings, and use an expression.

=iif(Fields!FieldName.Value, ChrW(254), Chr(111)) If the boolean is true, you will get a checkmark in the box, otherwise you will get an empty box.

## 參考:
### dll
```C#
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
```
### edge-js console export PDF
```js
const { error } = require('console');
const edge=require('edge-js');
const fs=require('fs');
const path=require('path');
const { writer } = require('repl');
const rdlcRenderer=edge.func({
    assemblyFile:path.resolve(__dirname,"RdlcRender/bin/Debug/RdlcRender.dll"),
    typeName:'RdlcRender.RdlcRender',
    methodName:'RenderRdlcToPdf'
});
const reportParams={
    rdlcPath:path.resolve(__dirname,"RdlcRender/Report1.rdlc"),
    dataSetName: 'DataSet1',
    dataSourceJson:""
};
rdlcRenderer(reportParams,(error,result)=>{
    if(error) return console.log(error);
    let d=new Date().toLocaleString('sv').replace(/[: -]/g,"");
    const pdfBuffer=Buffer.from(result,'base64');
    const outputPath=path.resolve(__dirname,`pdf/${d}.pdf`)
    fs.writeFile(outputPath,pdfBuffer,(wirteErr)=>{
        if(wirteErr) return console.log(wirteErr);
        console.log(outputPath);
    })
});
```
### Web Download PDF
```js
const express = require('express');
const edge = require('edge-js');
const fs = require('fs');
const path = require('path');
const cors = require('cors');

const app = express();
const PORT = 3000;

const { error } = require('console');
const { writer } = require('repl');

// 1. 中间件配置：解析 JSON 请求体、允许跨域
app.use(cors());
app.use(express.json()); // 接收前端传递的报表参数（如数据源、RDLC路径）
// 2. 初始化 Edge-js，关联 .NET DLL（关键：路径需指向你的 DLL 文件）
const rdlcRenderer=edge.func({
    assemblyFile:path.resolve(__dirname,"RdlcRender/bin/Debug/RdlcRender.dll"),
    typeName:'RdlcRender.RdlcRender',
    methodName:'RenderRdlcToPdf'
});

const reportParams={
    rdlcPath:path.resolve(__dirname,"RdlcRender/Report1.rdlc"),
    dataSetName: 'DataSet1',
    dataSourceJson:""
};

rdlcRenderer(reportParams,(error,result)=>{
    if(error) return console.log(error);
    let d=new Date().toLocaleString('sv').replace(/[: -]/g,"");
    const pdfBuffer=Buffer.from(result,'base64');
    const outputPath=path.resolve(__dirname,`pdf/${d}.pdf`)
    fs.writeFile(outputPath,pdfBuffer,(wirteErr)=>{
        if(wirteErr) return console.log(wirteErr);
        console.log(outputPath);
    })
});

// 3. 核心接口：接收请求 → 调用.NET渲染 → 返回PDF下载
app.get('/api/generate-rdlc-pdf', (req, res) => {
    try {
        // 3.1 从请求体获取参数（前端需传递这些数据）
        //const { rdlcFileName, dataSetName, dataSource } = req.body;
        //if (!rdlcFileName || !dataSetName || !dataSource) {
        //    return res.status(400).json({ error: '参数：rdlcFileName、dataSetName、dataSource' });
        //}

        // 3.2 组装 .NET 方法需要的参数（RDLC路径转为绝对路径）
        //const reportParams = {
        //    rdlcPath: path.resolve(__dirname, 'rdlcs', rdlcFileName), // 建议将RDLC文件放在rdlcs文件夹
        //    dataSetName: dataSetName,
        //    dataSourceJson: JSON.stringify(dataSource) // 数据源转为JSON字符串，供.NET解析
        //};

        // 3.3 调用 .NET 渲染报表（异步）
        rdlcRenderer(reportParams, (error, pdfBase64) => {
            if (error) {
                console.error('报表渲染失败：', error);
                return res.status(500).json({ error: '报表生成失败，详情：' + error.message });
            }

            // 3.4 将 Base64 转为 Buffer，设置响应头实现下载
            let d=new Date().toLocaleString('sv').replace(/[: -]/g,"");
            const pdfBuffer = Buffer.from(pdfBase64, 'base64');
            res.setHeader('Content-Type', 'application/pdf');
            res.setHeader('Content-Disposition', `attachment; filename=REP_${d}.pdf`); // 动态文件名
            res.setHeader('Content-Length', pdfBuffer.length);
            
            // 3.5 返回 PDF 文件流
            res.end(pdfBuffer);
        });
    } catch (err) {
        res.status(500).json({ error: '服务器异常：' + err.message });
    }
});

// 4. 启动服务
app.listen(PORT, () => {
    console.log(`Express 服务已启动，报表接口：http://localhost:${PORT}/api/generate-rdlc-pdf`);
});
```

### 網上資料

- https://learn.microsoft.com/en-us/dynamics365/business-central/ui-rdlc-report-layouts
- https://www.cnblogs.com/NaughtyCat/p/auto-generate-report.html
- https://blog.darkthread.net/Blog/rdlc-with-objectdatasource/
- https://blog.csdn.net/lingxiao16888/article/details/140636856
- https://sdwh.dev/posts/2022/04/ASPNET-MVC-Reporting-With-RDLC/
- https://wenku.baidu.com/view/f47cb8bdf121dd36a32d825f.html?_wkts_=1764582882164&needWelcomeRecommand=1
- https://www.cnblogs.com/SkySoot/archive/2011/11/24/2261952.html
- https://lawrencetech.blogspot.com/2013/12/netpdf_6.html
