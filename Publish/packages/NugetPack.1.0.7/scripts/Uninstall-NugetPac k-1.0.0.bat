@echo off

REM    ***************************************************************************
REM    * 									 *
REM    *  Uninstall-NugetPack-1.0.0.bat					 *
REM    * 									 *
REM    * 	Uninstalls BTDF MSI Package (Including Framework Components)	 *
REM    * 									 *
REM    * 									 *
REM    *  Version Information: 							 * 
REM    * 									 *
REM    * 	roblazny	1-Oct-2013 					 *
REM    *                        Initial Revision				 *
REM    * 									 *
REM    * 	roblazny	10-Oct-2013					 *
REM    * 			Update to support configurable Installation	 *
REM    *			Root Directory					 *
REM    * 									 *
REM    * 									 *
REM    ***************************************************************************

CD /D %CD%

SET DEPLOY_CONFIG_FILE="..\..\deploy-config.xml"
SET LOG_FILE=NugetPack-1.0.0.Uninstall.log

ECHO Reading deploy-config.xml ....


for /F "tokens=3 delims=<>" %%i in ('findstr "<INSTALLROOT>" %DEPLOY_CONFIG_FILE%') do SET CONFIG-INSTALLROOT=%%i

ECHO Install Root = %CONFIG-INSTALLROOT%

@PAUSE

SET INSTALL_DIR="%CONFIG-INSTALLROOT%\NugetPack\1.0"

start "" msiexec.exe /x NugetPack-1.0.0.msi /passive /log %LOG_FILE% INSTALLDIR=%INSTALL_DIR%

