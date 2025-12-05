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
