using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ATENDIMENTO_MÓVEL
{
    class Navegadores
    {
        ProcessStartInfo ExplorerExe = new ProcessStartInfo("iexplore.exe");
        ProcessStartInfo ChromeExe = new ProcessStartInfo("chrome.exe");

        //Sprinklr
        public void AbrirUmEx()
        {
            ExplorerExe.Arguments = "";
            Process.Start(ExplorerExe);
        }

        public void AbrirumCr()
        {
            ChromeExe.Arguments = "";
            Process.Start(ChromeExe);
        }
        //360
        public void AbrirdoisEx()
        {
            ExplorerExe.Arguments = "";
            Process.Start(ExplorerExe);
        }

        public void AbrirdoisCr()
        {
            ChromeExe.Arguments = "";
            Process.Start(ChromeExe);
        }

        public void AbrirTresEx()
        {
            ExplorerExe.Arguments = "";
            Process.Start(ExplorerExe);
        }

        public void AbrirTresCr()
        {
            ChromeExe.Arguments = "";
            Process.Start(ChromeExe);
        }

   

        public void AbrircincoEx()
        {
            ExplorerExe.Arguments = "";
            Process.Start(ExplorerExe);
        }

        public void AbrircincoCr()
        {
            ChromeExe.Arguments = "";
            Process.Start(ChromeExe);
        }

        public void AbrirseisEx()
        {
            ExplorerExe.Arguments = "";
            Process.Start(ExplorerExe);
        }

        public void AbrirseisCr()
        {
            ChromeExe.Arguments = "";
            Process.Start(ChromeExe);
        }
        public void AbrirseteEx()
        {
            ExplorerExe.Arguments = "";
            Process.Start(ExplorerExe);
        }

        public void AbrirseteCr()
        {
            ChromeExe.Arguments = "";
            Process.Start(ChromeExe);
        }

        public void AbriroitoEx()
        {
            ExplorerExe.Arguments = "";
            Process.Start(ExplorerExe);
        }

        public void AbriroitoCr()
        {
            ChromeExe.Arguments = "";
            Process.Start(ChromeExe);
        }

        public void AbrirnoveEx()
        {
            ExplorerExe.Arguments = "";
            Process.Start(ExplorerExe);
        }

        public void AbrirnoveCr()
        {
            ChromeExe.Arguments = "";
            Process.Start(ChromeExe);
        }

        public void AbrirdezEx()
        {
            ExplorerExe.Arguments = "";
            Process.Start(ExplorerExe);
        }

        public void AbrirdezCr()
        {
            ChromeExe.Arguments = "";
            Process.Start(ChromeExe);
        }

        public void AbrironzeEx()
        {
            ExplorerExe.Arguments = "";
            Process.Start(ExplorerExe);
        }

        public void AbrironzeCr()
        {
            ChromeExe.Arguments = "";
            Process.Start(ChromeExe);
        }
        public void AbrirdozeEx()
        {
            ExplorerExe.Arguments = "http://www.vivo.com.br";
            Process.Start(ExplorerExe);
        }

        public void AbrirdozeCr()
        {
            ChromeExe.Arguments = "http://www.vivo.com.br";
            Process.Start(ChromeExe);
        }

        public void AbrirtrezeEx()
        {
            ExplorerExe.Arguments = "";
            Process.Start(ExplorerExe);
        }

        public void AbrirtrezeCr()
        {
            ChromeExe.Arguments = "";
            Process.Start(ChromeExe);
        }

        public void AbrirquatorzeCr()
        {
            ProcessStartInfo BlocoDeNotas = new ProcessStartInfo("Notepad.exe");
            
            Process.Start(BlocoDeNotas);
        }

        public void AbrirquinzeCr()
        {
            ProcessStartInfo Calc = new ProcessStartInfo("Calc.exe");

            Process.Start(Calc);
        }

        public void AbrirdezesseisCr()
        {
            ProcessStartInfo Excel = new ProcessStartInfo("Excel.exe");

            Process.Start(Excel);
        }

        public void AbrirdezesseteCr()
        {
            ProcessStartInfo Word = new ProcessStartInfo("WINWORD.EXE");

            Process.Start(Word);
        }

        public void AbrirdezoitoCr()
        {
            ProcessStartInfo Cmd = new ProcessStartInfo("CMD.EXE");

            Process.Start(Cmd);
        }

        
     
    }
}
