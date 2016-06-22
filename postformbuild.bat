@echo off
set RAR="C:\Program Files\WinRAR\WinRAR.exe"
set PORTABLEZIP="D:\dremote\site\dl\dRemote_portable.zip"
set PORTABLESFX="D:\dremote\site\dl\dRemote_sfx.exe"
set buildpath="D:\dRemote-develop\mRemoteV1\bin\Debug Portable\*.*"
IF EXIST "D:\dRemote-develop\mRemoteV1\bin\Debug Portable\putty.exe" del /F "D:\dRemote-develop\mRemoteV1\bin\Debug Portable\putty.exe"
COPY "D:\dRemote-develop\mRemoteV1\References\putty.exe" "D:\dRemote-develop\mRemoteV1\bin\Debug Portable\putty.exe"
IF EXIST %PORTABLEZIP% del /F %PORTABLEZIP%
IF EXIST %PORTABLESFX% del /F %PORTABLESFX%
%RAR% a -m5 -r -ep1 -afzip -inul %PORTABLEZIP% %buildpath%
%RAR% a -m5 -r -ep1 -sfx -inul %PORTABLESFX% %buildpath%