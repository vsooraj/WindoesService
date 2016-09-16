http://www.c-sharpcorner.com/uploadfile/naresh.avari/develop-and-install-a-windows-service-in-c-sharp/

Installing the Windows Service

Go to "Start" >> "All Programs" >> "Microsoft Visual Studio 2012" >> "Visual Studio Tools" then click "Developer Command Prompt for VS2012".

Type the following command:

cd <physical location of your TestWindowService.exe file>

in my case it is :

cd C:\Sandbox\WindowServices\TestWindowService\TestWindowService\bin\Debug
 
Installing the Window Service 
 
Next type the following command:

InstallUtil.exe “TestWindowService.exe”


InstallUtil.exe /u “TestWindowService.exe”