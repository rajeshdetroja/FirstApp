@echo off

REM    ***************************************************************************
REM    * 									 *
REM    *  Undeploy-NugetPack-1.0.0.bat					 *
REM    * 									 *
REM    * 	Removes BizTalk Solution using Installed BTDF MSI Package	 *
REM    * 	Prior to executing script, MSI must be installed using 		 *
REM    * 	Install-NugetPack-1.0.0.bat					 *
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

IF EXIST "%windir%\Microsoft.NET\Framework\v3.5\MSBuild.exe" (
SET BTDFMSBuildPath="%windir%\Microsoft.NET\Framework\v3.5\MSBuild.exe"
) ELSE IF EXIST "%windir%\Microsoft.NET\Framework\v2.0.50727\MSBuild.exe" (
SET BTDFMSBuildPath="%windir%\Microsoft.NET\Framework\v2.0.50727\MSBuild.exe"
)

CD /D %CD%

SET DEPLOY_CONFIG_FILE="..\..\deploy-config.xml"
SET LOG_FILE ="NugetPack-1.0.0.Deploy.log"

ECHO Reading deploy-config.xml ....

for /F "tokens=3 delims=<>" %%i in ('findstr "<ENVIRONMENT>" %DEPLOY_CONFIG_FILE%') do SET CONFIG-ENV=%%i
for /F "tokens=3 delims=<>" %%i in ('findstr "<PRIMARYSERVER>" %DEPLOY_CONFIG_FILE%') do SET CONFIG-ISPRIMARY=%%i
for /F "tokens=3 delims=<>" %%i in ('findstr "<SHAREDSERVER>" %DEPLOY_CONFIG_FILE%') do SET CONFIG-ISSHARED=%%i
for /F "tokens=3 delims=<>" %%i in ('findstr "<INSTALLROOT>" %DEPLOY_CONFIG_FILE%') do SET CONFIG-INSTALLROOT=%%i

ECHO Environment = %CONFIG-ENV%
ECHO Primary = %CONFIG-ISPRIMARY%
ECHO Shared = %CONFIG-ISSHARED%
ECHO Install Root = %CONFIG-INSTALLROOT%

@PAUSE

SET INSTALL_DIR="%CONFIG-INSTALLROOT%\NugetPack\1.0"
SET SETTINGS_FILE=Exported_%CONFIG-ENV%Settings.xml
SET IS_PRIMARY=%CONFIG-ISPRIMARY%
SET IS_SHARED_ENV=%CONFIG-ISSHARED%

ECHO "Undeploying Application..."

"%BTDFMSBuildPath%" "%INSTALL_DIR%\Deployment\Deployment.btdfproj" /nologo /t:ServerUndeploy /l:FileLogger,Microsoft.Build.Engine;logfile="%INSTALL_DIR%\DeployResults\UndeployResults.txt" /p:Configuration=Server;IS_SHARED=%IS_SHARED_ENV%;ENV_SETTINGS="%INSTALL_DIR%\Deployment\EnvironmentSettings\%SETTINGS_FILE%" /p:IS_SHARED=%IS_SHARED_ENV% /p:BT_DEPLOY_MGMT=%IS_PRIMARY% /p:ENV_SETTINGS="%INSTALL_DIR%\Deployment\EnvironmentSettings\%SETTINGS_FILE%"

@echo on
@echo -----
@echo off
@pause

