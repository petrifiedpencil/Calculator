using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//legit only used another class (other than Main) because my main code got too hard to read :)
namespace Calculator
{
    public class Codes
    {
        //EVERYTHINGS PUBLIC!!!!!! 
        //who needed data security or abstraction anyway, if someone ever finds out p=np it wont even matter
        //see im not lazy im just preparing for the future where p=np so data security will be pointless so why bother with it now
        public string x0 = "5";
        public string y0 = "5";
        public string action = "";
        public string doaction = "add";
        public bool showHistory = false;
        public bool help = false;
        public bool ClearHistory = false;
        public bool isnan = false;
        public double x3;
        public void Getit()
        {
           x0 = Console.ReadLine();
            try { x3 = Convert.ToDouble(x0) - 0; }
            catch { isnan = true; }
            if (x0 == "c")
            { isnan = false; }
            
            else if (x0 == "a") { action = "add"; doaction = "add"; isnan = false; }
            else if (x0 == "s") { action = "sub"; doaction = "sub"; isnan = false; }
            else if (x0 == "h") { showHistory = true; isnan = false; }
            else if (x0 == "help") { help = true; isnan = false; }
            else if (x0 == "ch") {ClearHistory = true; isnan = false; }
            else if (x0 == "d") { action = "div"; doaction = "div"; isnan = false; }
            else if (x0 == "m") { action = "mul"; doaction = "mul"; isnan = false; }
            else if (x0 == ":)") { isnan = false; }
            else if (isnan == true) { isnan = false; Console.WriteLine("ERROR: TYPE A NUMBER!!! or \"help\" for a list of commands"); Getit(); }
            else
            {
                y0 = Console.ReadLine();
            }
        }
    }
}
