# RDLC_Report_Design_View

## 微专业课程-进阶-3小时rdlc报表

职业技能培訓課程,學時短,學習快,有成效,能動手完成任務。

電腦程式职业技能，即学即用，快吃又有營養，技能入門，給你0到1的體驗。

幫助同學提高趣味感和成就感,電腦程式必備技能顧及技術堆叠，不会过时。

学完体验课程，衔接职业培训中心CM课程, 跟资深导师继续深造。

混合了多种编程C#, JS, Python以易用实用为主。

## 基礎知識

- 初级 HTML,XML標籤認識
- 初级 C#， Console，WinForm，Dll
- 中级 sqlLocalDB, DataSet
- 晋级 Edge-JS, pythonnet 
  
## 工具

- Microsoft RDLC Report Designer

https://marketplace.visualstudio.com/items?itemName=ProBITools.MicrosoftRdlcReportDesignerforVisualStudio-18001
- ReportViewerControl.Winforms

NuGet\Install-Package Microsoft.ReportingServices.ReportViewerControl.Winforms -Version 150.1652.0

- Install Microsoft Report Builder

https://www.microsoft.com/en-us/download/details.aspx?id=53613

## SQL LocalDB and DataGrid in C# WinForms

- Task 创建DB及TABLE

[本地資料庫localdb](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver17)

[管理工具ssms](https://learn.microsoft.com/en-us/ssms/install/install)

![ssms](https://github.com/eddylin2015/RDLC_Report_Design_View/blob/main/img/ssms.png?raw=true)

```CMD
rem C:\Program Files\Microsoft SQL Server\160\Tools\Binn\
REM Create an instance of LocalDB
"SqlLocalDB.exe" create LocalDBApp1
REM Start the instance of LocalDB
"SqlLocalDB.exe" start LocalDBApp1
REM Gather information about the instance of LocalDB
"SqlLocalDB.exe" info LocalDBApp1
REM Server=(localdb)\\LocalDBApp1;Integrated Security=true
REM Server=(localdb)\\LocalDBApp1;Initial Catalog=mydb;Integrated Security=true
REM C:\Users\usr\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\LocalDBApp1
```

- Task C# WinForm DataGridView and DataGridNavigator

![WinFormDataGrid](https://github.com/eddylin2015/RDLC_Report_Design_View/blob/main/img/WinFormDataGrid.png?raw=true)

- Task CRUD 更新资料至资料表

## RDLC 实验任务

#### 課一. Basic reports          

> [!NOTE]
>  Microsoft RDLC Report Designer   
>  NuGet\Install-Package Microsoft.ReportingServices.ReportViewerControl.Winforms -Version 150.1652.0

- Task : create a rdlc 报表

[使用 Report Builder 打开和编辑 RDLC 文件](https://my.oschina.net/emacs_9380709/blog/18461026)

设定报表页面

Report Property : 

![RepProperty](https://github.com/eddylin2015/RDLC_Report_Design_View/blob/main/img/RepProperty.png?raw=true)

> [!NOTE]
> "Report" -> "Report Properties"
> margin 0.2in    
> The A4 size paper measures 210 by 297 millimeters (8.27 in × 11.7 in)    
> 1 pages: size: 7.9in 9.4in   
> 1 page inner : 7.7in 9.0 in   
> [认识页面 Margin](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/pagination-in-reporting-services-report-builder-and-ssrs?view=sql-server-ver17)

- Task : Form2 ReportViewerControl 

![](https://learn.microsoft.com/en-us/sql/reporting-services/application-integration/media/windows-app-local-report-settings.png?view=sql-server-ver17)

[WinForms ReportViewer control](https://learn.microsoft.com/en-us/sql/reporting-services/application-integration/using-the-winforms-reportviewer-control?view=sql-server-ver17)

```js
var setup = frmReport.reportViewer1.GetPageSettings();           
setup.Margins = new System.Drawing.Printing.Margins(1, 1, 1, 1);
frmReport.reportViewer1.SetPageSettings(setup);
```

- Task : Form1 >[RDLC 報表]

```js
var form2=new Form2();
from2.Show();
```

#### 課二. Parameters , Data sources and datasets

[report-datasets](https://learn.microsoft.com/en-us/sql/reporting-services/report-data/report-datasets-ssrs?view=sql-server-ver17)

![report-datasets](https://learn.microsoft.com/en-us/sql/reporting-services/report-data/media/rs-datadesignandpreview.gif?view=sql-server-ver17)

#### 課三.Tables     

![](https://i.sstatic.net/6a5ck.png)

[reports-multiple-tables](https://learn.microsoft.com/en-us/dynamics365/business-central/dev-itpro/developer/devenv-walktrough-designing-reports-multiple-tables)

[one-to-many](https://stackoverflow.com/questions/48843956/creating-an-rdlc-report-with-multiple-tables-one-to-many-relationship)           

#### 課四.Grouping

[add-grouping-totals](https://learn.microsoft.com/en-us/sql/reporting-services/tutorial-step-06-add-grouping-totals-reporting-services?view=sql-server-ver17)

![add-grouping-totals](https://learn.microsoft.com/en-us/sql/reporting-services/media/rs-basictablesumgrandtotalpreview.gif?view=sql-server-ver17)

#### 課五.Expressions    

- Using Simple Expressions
- Using Complex Expressions

[Expression uses in paginated reports (Report Builder)](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/expression-uses-in-reports-report-builder-and-ssrs?view=sql-server-ver17)

[Expression reference in a paginated report (Report Builder)](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/expression-reference-report-builder-and-ssrs?view=sql-server-ver17)

[RDLC 报表系列（三） 参数、常量及常用表达式的使用](https://blog.csdn.net/weilu0328/article/details/5709436)

- Display Booleans on an RDLC Report

Change the font to Wingdings, and use an expression. checkmark in the box

=iif(Fields!FieldName.Value, ChrW(254), Chr(111)) 

#### 課六.Exporting reports    

- Preview (HTML-like, Soft Page-Break)
- Print (Hard Page-Break)
- PDF (Hard Page-Break)
- Word (Soft Page-Break)
- Excel (Soft Page-Break)

```js
Warning[] warnings;
string[] streamids;
string mimeType;
string encoding;
string filenameExtension;
byte[] bytes = reportViewer.LocalReport.Render(
    "PDF", null, out mimeType, out encoding, out filenameExtension,
    out streamids, out warnings);

using (FileStream fs = new FileStream("output.pdf", FileMode.Create))
{
    fs.Write(bytes, 0, bytes.Length);
}
```

[RDLC - Export Directly to Word, Excel or PDF from Code](https://www.codeproject.com/articles/RDLC-Export-Directly-to-Word-Excel-or-PDF-from-Cod#comments-section)

#### 課七.Parameters

[Paginated report parameters in Report Builder](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/report-parameters-report-builder-and-report-designer?view=sql-server-ver17)

```js
using Microsoft.Reporting.WinForms; // For WinForms applications
// ... inside your form or page where the ReportViewer is located
// Create a list or array of ReportParameter objects
List<ReportParameter> parameters = new List<ReportParameter>();
// Add individual parameters
parameters.Add(new ReportParameter("CustomerID", "123")); // Name and Value
parameters.Add(new ReportParameter("ReportTitle", "Sales Report for Q4"));
// Set the parameters to the LocalReport
reportViewer1.LocalReport.SetParameters(parameters);
// Refresh the report to display with the new parameters
reportViewer1.RefreshReport();
```

![Dataset query or stored procedure with parameters](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/media/ssrb-paramdatasetprops.png?view=sql-server-ver17)

[rdlc-passing-multiple-parameters](https://learn.microsoft.com/en-us/answers/questions/361199/rdlc-passing-multiple-parameters)

[建立具有參數的鑽研 (RDLC) 報表](https://learn.microsoft.com/zh-tw/sql/reporting-services/create-drillthrough-rdlc-report-with-parameters-reportviewer?view=sql-server-ver16)

#### 課八.Matrices              

![Tutorial: Create a matrix report (Report Builder)](https://learn.microsoft.com/en-us/sql/reporting-services/media/report-builder-matrix-tutorial.png?view=sql-server-ver17)

#### 課九.Charts

[charts](https://www.c-sharpcorner.com/UploadFile/4d9083/how-to-create-rdlc-charts-and-complete-series-of-all-charts/)

![chars](https://learn.microsoft.com/en-us/sql/reporting-services/media/report-builder-column-chart-tutorial.png?view=sql-server-ver17)

#### 課十.sparklines charts    

[Tutorial: Add a sparkline to your report (Report Builder)](https://learn.microsoft.com/en-us/sql/reporting-services/tutorial-add-a-sparkline-to-your-report-report-builder?view=sql-server-ver17)

[](https://learn.microsoft.com/en-us/sql/reporting-services/media/report-builder-kpi-report.png?view=sql-server-ver17)

![sparklines charts](https://learn.microsoft.com/en-us/sql/reporting-services/media/report-builder-sparkline-final.png?view=sql-server-ver17)

![Tutorial: Add a KPI to your report (Report Builder)](https://learn.microsoft.com/en-us/sql/reporting-services/media/report-builder-kpi-report.png?view=sql-server-ver17)

#### 課十一.Graphical indicators

[Indicators](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/indicators-report-builder-and-ssrs?view=sql-server-ver17)

![Indicators](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/media/rs-indicatortabletrafficlight.gif?view=sql-server-ver17)

#### 課十二.Lists         

![List](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/media/rs-basiclistformdesign.gif?view=sql-server-ver17)

[Create invoices and forms with lists in a paginated report (Report Builder)](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/create-invoices-and-forms-with-lists-report-builder-and-ssrs?view=sql-server-ver17)

#### 課十三.Subreports  

![subreport](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/media/rs-subreport.gif?view=sql-server-ver17)

[subreport](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/subreports-report-builder-and-ssrs?view=sql-server-ver17)

[sub rep](https://cloud.tencent.com/developer/article/2444311)

#### 課十四.Drill-through reports  

![](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/media/rs-drillthru.gif?view=sql-server-ver17)

[link next page](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/drillthrough-reports-report-builder-and-ssrs?view=sql-server-ver17)

[drill through](https://blog.csdn.net/GoodShot/article/details/8195690)

```js
private void reportViewer1_Drillthrough(object sender, DrillthroughEventArgs e)
    {
        Microsoft.Reporting.WinForms.ReportDataSource dataSrc = new Microsoft.Reporting.WinForms.ReportDataSource();
        dataSrc.Name = "DataSet1";
        dataSrc.Value = this.DataTable1BindingSource;
        LocalReport localReport = (LocalReport)e.Report;
        localReport.DataSources.Add(dataSrc);
    }
```    
#### 課十五.The SSRS web portal

- Task Install SSRS

Use the following steps to install SSRS.

Locate SQLServerReportingServices.exe and launch the installer.

For a free edition, choose either Evaluation or Developer.
![SSRS free edition](https://learn.microsoft.com/en-us/sql/reporting-services/install-windows/media/install-reporting-services/report-server-install-edition-select.png?view=sql-server-ver17)

- Task 自制網站.

- express.js
- Edge-JS
- pdf.js

> [!NOTE]
> 參考 RdlcRender + RdlcJs.html2pdf

## 附加

[ex1:Lesson 4 Creating Code to Generate the Report Definition File](https://learn.microsoft.com/en-us/previous-versions/sql/sql-server-2008-r2/ms170239(v=sql.105)?redirectedfrom=MSDN)

> [!NOTE]
> 修改NameSpace RDL 2005版改為2008版
> body升高二層, 移除ReportSections ReportSection


[ex2:PeriodicTable, Generating RDLC Dynamically](https://www.codeproject.com/articles/Generating-RDLC-Dynamically-for-the-Report-Viewer-#comments-section)

![PeriodicTable](https://github.com/eddylin2015/RDLC_Report_Design_View/blob/main/img/PeriodicTable.png?raw=true)

> [!NOTE]
> RDL 2005版改為2008版
> 修改 Report.cs
> 修改 PeriodicTableReportGenerator.cs
> 修改 Report1.rdlc

## 參考:
[教學課程：建立基本資料表報表 (報表產生器)](https://learn.microsoft.com/zh-tw/sql/reporting-services/tutorial-creating-a-basic-table-report-report-builder?view=sql-server-ver17&source=recommendations)

[Data regions and maps in a paginated report (Report Builder)](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/data-regions-and-maps-report-builder-and-ssrs?view=sql-server-ver17)

## 網上資料

- https://learn.microsoft.com/en-us/dynamics365/business-central/ui-rdlc-report-layouts
- https://www.cnblogs.com/NaughtyCat/p/auto-generate-report.html
- https://blog.darkthread.net/Blog/rdlc-with-objectdatasource/
- https://blog.csdn.net/lingxiao16888/article/details/140636856
- https://sdwh.dev/posts/2022/04/ASPNET-MVC-Reporting-With-RDLC/
- https://wenku.baidu.com/view/f47cb8bdf121dd36a32d825f.html?_wkts_=1764582882164&needWelcomeRecommand=1
- https://www.cnblogs.com/SkySoot/archive/2011/11/24/2261952.html
- https://lawrencetech.blogspot.com/2013/12/netpdf_6.html

## git 常用指令
[Git for Windows/x64 Setup](https://git-scm.com/install/windows)
```cmd
# 克隆源碼
git clone https://github.com/eddylin2015/RDLC_Report_Design_View.git

# 如果有編輯權限
git add .
git commit -m "update"
git push
# pull 來自github版本
git pull
git add .
git commit -m "update"
git push
# 有不同版本出現, 合並源碼
git merge
```

## git Merge

```cmd
(env) c:\code\fileshare\www\RDLC_Report_Design_View>git pull
Updating 4f3fe0a..2b0b862
error: Your local changes to the following files would be overwritten by merge:
        README.md
Please commit your changes or stash them before you merge.
Aborting

(env) c:\code\fileshare\www\RDLC_Report_Design_View>git add .

(env) c:\code\fileshare\www\RDLC_Report_Design_View>git commit -m "merge readme"
[main 1de82f9] merge readme
 1 file changed, 1 insertion(+), 1 deletion(-)

(env) c:\code\fileshare\www\RDLC_Report_Design_View>git merge
Auto-merging README.md
CONFLICT (content): Merge conflict in README.md
Automatic merge failed; fix conflicts and then commit the result.

(env) c:\code\fileshare\www\RDLC_Report_Design_View>code README.md

(env) c:\code\fileshare\www\RDLC_Report_Design_View>git add .

(env) c:\code\fileshare\www\RDLC_Report_Design_View>git commit -m "marge fix"
[main 5d719df] marge fix

(env) c:\code\fileshare\www\RDLC_Report_Design_View>git push
Writing objects: 100% (6/6), 576 bytes | 576.00 KiB/s, done.
Total 6 (delta 4), reused 0 (delta 0), pack-reused 0 (from 0)
remote: Resolving deltas: 100% (4/4), completed with 2 local objects.
To https://github.com/eddylin2015/RDLC_Report_Design_View.git
   2b0b862..5d719df  main -> main
```