# RDLC_Report_Design_View

## 微专业课程-进阶-3小时rdlc报表

即吃面，短视频，快餐体验课程。

课程是指電腦程式职业技能，即吃即用，快吃又有營養，技能入門，給你0到1的體驗，

幫助同學提高趣味感成就感,滿滿干貨,電腦程式必備技能。有类培训课程实用主义。学完体验课程衔接职业培训中心CM课程,资深导师继续深造。

这里混合了多种编程C#, JS, Python.以易用为主。

## 基礎知識

- 初级 C#， Console，WinForm，Dll
- 中级 Mysql, DataSet
- 晋级 Edge-JS, pythonnet 
  
## 工具
- Microsoft RDLC Report Designer
https://marketplace.visualstudio.com/items?itemName=ProBITools.MicrosoftRdlcReportDesignerforVisualStudio-18001
- ReportViewerControl.Winforms
NuGet\Install-Package Microsoft.ReportingServices.ReportViewerControl.Winforms -Version 150.1652.0
- Install Microsoft Report Builder
https://www.microsoft.com/en-us/download/details.aspx?id=53613

## C# Basics Tutorial for Beginners (采用 Deepseek 教程)
## C# WinForms Tutorial
## SQL LocalDB and DataSet in C# WinForms
https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver17
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
## RDLC 教学大纲
- Basic reports          

+ 2 pages: size: 7.9in 18.8in
+ 1 page inner : 7.7in 9.0 in
[page margin](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/pagination-in-reporting-services-report-builder-and-ssrs?view=sql-server-ver17)

![](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/media/rspagemargins.gif?view=sql-server-ver17)
```js
// "Report" -> "Report Properties"
var setup = frmReport.reportViewer1.GetPageSettings();           
setup.Margins = new System.Drawing.Printing.Margins(1, 1, 1, 1);
frmReport.reportViewer1.SetPageSettings(setup);
```

[WinForms ReportViewer control](https://learn.microsoft.com/en-us/sql/reporting-services/application-integration/using-the-winforms-reportviewer-control?view=sql-server-ver17)

![](https://learn.microsoft.com/en-us/sql/reporting-services/application-integration/media/windows-app-local-report-settings.png?view=sql-server-ver17)
>>>>>>> 8349e9d390b8d9208cac77ef1c12a62d0c6e4b4d

- Data sources and datasets
- Tables                 
- Grouping
- Expressions            
- Page set-up
- Exporting reports      
- Parameters
- Matrices               
- Charts
- Miniature charts       
- Graphical indicators
- Lists                  
- Subreports  
- Drill-through reports  
- The SSRS web portal

[advance sample1:Generating RDLC Dynamically](https://www.codeproject.com/articles/Generating-RDLC-Dynamically-for-the-Report-Viewer-#comments-section)

### Display Booleans on an RDLC Report

Change the font to Wingdings, and use an expression.

=iif(Fields!FieldName.Value, ChrW(254), Chr(111)) If the boolean is true, you will get a checkmark in the box, otherwise you will get an empty box.

## 參考:

### 網上資料

- https://learn.microsoft.com/en-us/dynamics365/business-central/ui-rdlc-report-layouts
- https://www.cnblogs.com/NaughtyCat/p/auto-generate-report.html
- https://blog.darkthread.net/Blog/rdlc-with-objectdatasource/
- https://blog.csdn.net/lingxiao16888/article/details/140636856
- https://sdwh.dev/posts/2022/04/ASPNET-MVC-Reporting-With-RDLC/
- https://wenku.baidu.com/view/f47cb8bdf121dd36a32d825f.html?_wkts_=1764582882164&needWelcomeRecommand=1
- https://www.cnblogs.com/SkySoot/archive/2011/11/24/2261952.html
- https://lawrencetech.blogspot.com/2013/12/netpdf_6.html
