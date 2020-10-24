using System;
using Sorting.Sorts;

namespace Sorting.Commands
{
    class Command_ShowList : ICommand
    {
        public void Execute()
        {
            if (Properties.ShowLists)
            {
                Properties.ShowLists = false;
                Console.WriteLine("ShowLists: disabled");
            }
            else {
                Properties.ShowLists = true;
                Console.WriteLine("ShowLists: enabled");
            }
        }

        public override string ToString()
        {
            return "Enable/disable showing of lists. It slows down the process a lot!";
        }
    }
}
