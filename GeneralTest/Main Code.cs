using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



//i love spaghetti, and no i dont make comments
//dont go looking into the code, trust me this runs VERY efficiently and is so well optimized! trust me it only needs ~8mb of memory, but thats still 7.99mb too much
//see if this was in c it would use -1 bits of memory but c is too hawd and confwusing UWU
namespace Calculator
{
    class MainCode
    {

        static void Main(string[] args)
        {

            Console.Title = "CALCULATOR";
            Console.WriteLine("Calculator started at "+DateTime.Now);
            Console.WriteLine("\"help\" for help");
            Codes MyObj = new Codes();
            string HistoryAdd;
            string HistorySub;
            string HistoryDiv;
            string HistoryMul;
            
            int x;
            int y;

            while (MyObj.x0!="c")
            {
                
                
                    try
                    {
                        MyObj.Getit();
                        Check();
                        Check();
                        double x1 = Convert.ToDouble(MyObj.x0);
                        double y1 = Convert.ToDouble(MyObj.y0);
                        HistoryAdd = DateTime.Now + ": " + x1 + "+" + y1 + "= " + (x1 + y1);
                        HistorySub = DateTime.Now + ": " + x1 + "-" + y1 + "= " + (x1 - y1);
                        HistoryDiv = DateTime.Now + ": " + x1 + "-" + y1 + "= " + (x1 / y1);
                        HistoryMul = DateTime.Now + ": " + x1 + "-" + y1 + "= " + (x1 * y1);
                        if (MyObj.doaction == "add") { Console.WriteLine("="+(x1 + y1)); File.AppendAllText("History.txt","\n"+ HistoryAdd); }
                        if (MyObj.doaction == "sub") { Console.WriteLine("="+(x1 - y1)); File.AppendAllText("History.txt", "\n" + HistorySub); }
                        if (MyObj.doaction == "div") { Console.WriteLine("=" + (x1 / y1)); File.AppendAllText("History.txt", "\n" + HistoryDiv); }
                        if (MyObj.doaction == "mul") { Console.WriteLine("=" + (x1 * y1)); File.AppendAllText("History.txt", "\n" + HistoryMul); }



                    }
                    catch 
                    {
                        Console.WriteLine("ERROR");

                        continue;
                    }

                
            }
            

            


            
       void Check()
            {
                if (MyObj.ClearHistory == true) { File.WriteAllText("History.txt", ""); Console.WriteLine("HISTORY CLEARED"); MyObj.ClearHistory = false; MyObj.Getit(); Check(); }
                if (MyObj.x0 == "c") { Console.Clear(); Console.WriteLine("CLEARED"); MyObj.Getit(); Check(); }
                if (MyObj.y0 == "c") { Console.Clear(); Console.WriteLine("CLEARED"); MyObj.Getit(); Check(); }
                if (MyObj.action == "add") { Console.WriteLine("ADDING"); MyObj.action = ""; MyObj.Getit(); Check(); }
                if (MyObj.action == "div") { Console.WriteLine("DIVIDING"); MyObj.action = ""; MyObj.Getit(); Check(); }
                if (MyObj.action == "mul") { Console.WriteLine("MULTIPLYING"); MyObj.action = ""; MyObj.Getit(); Check(); }
                if (MyObj.action == "sub") { Console.WriteLine("SUBTRACING"); MyObj.action = ""; MyObj.Getit(); Check(); }
                if (MyObj.showHistory == true) { Console.Clear(); Console.WriteLine("HISTORY:" + File.ReadAllText("History.txt")); MyObj.showHistory = false; MyObj.Getit(); Check(); }
                if (MyObj.help == true) { Console.Clear(); Console.WriteLine("HELP MENU:\n a for add, \n s for subtract, \n h for history, \n c for clear,\n help for help,\n ch to clear history,\n d to divide,\n m to multiply. \n If you get \"ERROR\", is likely you typed a letter not a number. please only use numbers or the commands above"); MyObj.help = false; MyObj.Getit(); Check(); }
                if (MyObj.x0 == ":)") { Console.WriteLine("yipee! easter egg moment ;)"); MyObj.Getit(); Check(); }
            }
        }
        
    }
}
