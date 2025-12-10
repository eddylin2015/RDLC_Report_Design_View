# RDLC_Report_Design_View

## 微专业课程-进阶-3小时rdlc报表

即吃面，短视频，快餐体验课程。

课程是指電腦程式职业技能，即吃即用，快吃又有營養，技能入門，給你0到1的體驗，

幫助同學提高趣味感成就感,滿滿干貨,電腦程式必備技能。有类培训课程实用主义。学完体验课程衔接职业培训中心CM课程,资深导师继续深造。

这里混合了多种编程C#, JS, Python.以易用为主。

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

## C# Basics Tutorial for Beginners (采用 Deepseek 教程)
## C# WinForms Tutorial
## SQL LocalDB and DataSet in C# WinForms
[localdb](https://learn.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver17)
[ssms](https://learn.microsoft.com/en-us/ssms/install/install)
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

#### 課一. Basic reports          
[使用 Report Builder 打开和编辑 RDLC 文件](https://my.oschina.net/emacs_9380709/blog/18461026)

- Page set-up
Report Property : 

![RepProperty](https://github.com/eddylin2015/RDLC_Report_Design_View/blob/main/img/RepProperty.png?raw=true)


```cmd
margin 0.2in 
The A4 size paper measures 210 by 297 millimeters (8.27 in × 11.7 in)
2 pages: size: 7.9in 18.8in
1 page inner : 7.7in 9.0 in
```

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

#### 課二.Data sources and datasets
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
[RDLC 报表系列（三） 参数、常量及常用表达式的使用](https://blog.csdn.net/weilu0328/article/details/5709436)

- Display Booleans on an RDLC Report

Change the font to Wingdings, and use an expression. checkmark in the box

=iif(Fields!FieldName.Value, ChrW(254), Chr(111)) 

#### 課六.Exporting reports      
[RDLC - Export Directly to Word, Excel or PDF from Code](https://www.codeproject.com/articles/RDLC-Export-Directly-to-Word-Excel-or-PDF-from-Cod#comments-section)
#### 課七.Parameters
[rdlc-passing-multiple-parameters](https://learn.microsoft.com/en-us/answers/questions/361199/rdlc-passing-multiple-parameters)
#### 課八.Matrices              

![Tutorial: Create a matrix report (Report Builder)](https://learn.microsoft.com/en-us/sql/reporting-services/media/report-builder-matrix-tutorial.png?view=sql-server-ver17)



#### 課九.Charts
[charts](https://www.c-sharpcorner.com/UploadFile/4d9083/how-to-create-rdlc-charts-and-complete-series-of-all-charts/)
#### 課十.Miniature charts       

#### 課十一.Graphical indicators
[Indicators](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/indicators-report-builder-and-ssrs?view=sql-server-ver17)
![Indicators](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/media/rs-indicatortabletrafficlight.gif?view=sql-server-ver17)
#### 課十二.Lists         

[video SSRS -- Using a List Item to Display Details](https://www.youtube.com/watch?v=h8EidVXasYg)
#### 課十三.Subreports  

[sub rep](https://cloud.tencent.com/developer/article/2444311)

#### 課十四.Drill-through reports  

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

自制網站.參考RdlcRender + RdlcJs.html2pdf
- express.js
- Edge-JS
- pdf.js


## 附加

[ex1:Lesson 4 Creating Code to Generate the Report Definition File](https://learn.microsoft.com/en-us/previous-versions/sql/sql-server-2008-r2/ms170239(v=sql.105)?redirectedfrom=MSDN)
- 修改NameSpace RDL 2005版改為2008版
- body升高二層, 移除ReportSections ReportSection


[ex2:PeriodicTable, Generating RDLC Dynamically](https://www.codeproject.com/articles/Generating-RDLC-Dynamically-for-the-Report-Viewer-#comments-section)
![PeriodicTable](https://github.com/eddylin2015/RDLC_Report_Design_View/blob/main/img/PeriodicTable.png?raw=true)
- RDL 2005版改為2008版
- 修改 Report.cs
- 修改 PeriodicTableReportGenerator.cs
- 修改 Report1.rdlc

## 參考:

[report-design](https://learn.microsoft.com/en-us/sql/reporting-services/report-design/data-regions-and-maps-report-builder-and-ssrs?view=sql-server-ver17)

## 網上資料

- https://learn.microsoft.com/en-us/dynamics365/business-central/ui-rdlc-report-layouts
- https://www.cnblogs.com/NaughtyCat/p/auto-generate-report.html
- https://blog.darkthread.net/Blog/rdlc-with-objectdatasource/
- https://blog.csdn.net/lingxiao16888/article/details/140636856
- https://sdwh.dev/posts/2022/04/ASPNET-MVC-Reporting-With-RDLC/
- https://wenku.baidu.com/view/f47cb8bdf121dd36a32d825f.html?_wkts_=1764582882164&needWelcomeRecommand=1
- https://www.cnblogs.com/SkySoot/archive/2011/11/24/2261952.html
- https://lawrencetech.blogspot.com/2013/12/netpdf_6.html

## git 教學

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