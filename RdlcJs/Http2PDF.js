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
        //    return res.status(400).json({ error: '缺少必要参数：rdlcFileName、dataSetName、dataSource' });
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