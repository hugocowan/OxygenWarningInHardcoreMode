set solutionDir=%~f1
set targetDir=%~f2

xcopy "%targetDir%bin\Release\OxygenWarningInHardcoreMode.dll" "%solutionDir%"  /I /Q /Y
xcopy "%targetDir%mod.json" "%solutionDir%"  /I /Q /Y