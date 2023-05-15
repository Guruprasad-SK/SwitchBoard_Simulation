using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchBoardWithAppliance
{
    public class SwitchBoard
    {       
        int _totalNumber { get; set; }
        List<Switch> Switches = new();
        public SwitchBoard()
        {
            IntializeSwitchBoard();
            DisplaySwitches();
        }
        public void IntializeSwitchBoard()
        {
            Console.WriteLine("Enter number of fans");
            int _numberOfFans = ValidateInput(Console.ReadLine());

            Console.WriteLine("Enter number of Ac");
            int _numberOfAc = ValidateInput(Console.ReadLine());

            Console.WriteLine("Enter number of Bulb");
            int _numberOfBulb = ValidateInput(Console.ReadLine());
            _totalNumber = _numberOfAc + _numberOfBulb + _numberOfFans;
            int id = 1;
            for (int i = 1; i <= _totalNumber; i++)
            {
                if (i >= 0 && i <= _numberOfFans) 
                {
                    Switches.Add(new Fan(id++));
                }
                else if (i > _numberOfFans && i <= _numberOfFans + _numberOfAc) 
                {
                    Switches.Add(new Ac(id++));
                }
                else if (i > _numberOfAc && i <= _totalNumber)
                {
                    Switches.Add(new Bulb(id++));
                }
            }
            int ValidateInput(string input)
            {
                int output;
                var isValid = int.TryParse(input, out output);
                if (isValid)
                {
                    return output;
                }
                Console.WriteLine("Enter valid Input");
                var input2 = Console.ReadLine();
                return ValidateInput(input2);
            }
        }
        public void DisplaySwitches()
        {
            DisplaySwitchesByLoop();
            while (true)
            {
              
                Console.WriteLine("enter any key to exit");
                Console.WriteLine("select device");
              
                bool choice = int.TryParse(Console.ReadLine(), out int X);
                if (choice == true)
                {
                    if (X>0 && X <= _totalNumber)
                    {
                        
                        var _switch = Switches.FirstOrDefault(x => x.Id == X);

                        _switch.IsOn = !_switch.IsOn;
                        DisplaySwitchesByLoop();
                    }
                    else
                    {
                        Console.WriteLine("enter valid input");
                    }
                }
               
                else
                {
                    Console.WriteLine("Enter valid input");
                }
             }
         }
        void DisplaySwitchesByLoop()
        {
            foreach (var types in Switches)
            {
               String Switch= types.IsOn ? "ON" : "OFF";
                
                Console.WriteLine(types+" "+Switch);
            }
        }
    }
}
