@echo off
:inicio
cls
echo ==========================================
echo         MENU DE QUESTOES
echo ==========================================
echo Digite a funcao que deseja realizar:
echo (0) = Sair
echo (1) = Executar Questao 1
echo (2) = Executar Questao 2
echo (3) = Executar Questao 3
echo (4) = Executar Questao 4
echo (5) = Executar Questao 5
echo (6) = Executar Questao 6
echo (7) = Executar Questao Bonus
echo.

set /p opcao="Opcao: "

if "%opcao%"=="0" goto fim
if "%opcao%"=="1" goto q1
if "%opcao%"=="2" goto q2
if "%opcao%"=="3" goto q3
if "%opcao%"=="4" goto q4
if "%opcao%"=="5" goto q5
if "%opcao%"=="6" goto q6
if "%opcao%"=="7" goto q7

echo Opcao invalida!
pause
goto inicio

:q1
cls
cd questao1
dotnet run
cd ..
pause
goto inicio

:q2
cls
cd questao2
dotnet run
cd ..
pause
goto inicio

:q3
cls
cd questao3
dotnet run
cd ..
pause
goto inicio

:q4
cls
cd questao4
dotnet run
cd ..
pause
goto inicio

:q5
cls
cd questao5
dotnet run
cd ..
pause
goto inicio

:q6
cls
cd questao6
dotnet run
cd ..
pause
goto inicio

:q7
cls
cd bonus
dotnet run
cd ..
pause
goto inicio

:fim
echo Saindo...
pause