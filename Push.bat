echo off
REM cls
echo Push Data
set /p commmit= "Commit message:  "
git config user.name "ddalairac"
git config user.email "diegodalairac@gmail.com"
git add .
git commit -m " %commmit% "
git push
pause
