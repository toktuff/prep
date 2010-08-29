#!/bin/bash

TARGET=/cygdrive/c/www/tutorial/
# Compile
CSC=/cygdrive/c/Windows/Microsoft.NET/Framework/v3.5/csc

[ -d bin ] || mkdir bin
$CSC /nologo /out:bin/CodeBehind.dll /r:System.dll,System.Web.dll,System.Data.dll /t:library FirstPage.cs


cp -rf WhiteLove $TARGET

cp -f master1.master firstpage.aspx /cygdrive/c/www/tutorial/

[ -d /cygdrive/c/www/tutorial/bin ] || mkdir /cygdrive/c/www/tutorial/bin
cp -f bin/CodeBehind.dll /cygdrive/c/www/tutorial/bin
