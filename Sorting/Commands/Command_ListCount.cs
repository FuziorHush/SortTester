using System;

namespace Sorting.Commands
{
    class Command_ListCount : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Input new length of lists:");
            string comm = Console.ReadLine();
            if (TrySetCount(comm))
            {
                Console.WriteLine("New length has been set");
            }
            else {
                Console.WriteLine("Input is incorrect");
            }
        }

        private bool TrySetCount(string comm) {
            int value;
            try
            {
                 value = int.Parse(comm);
            }
            catch(Exception) {
                return false;
            }
            if (value < 2) {
                return false;
            }
            Properties.ListCount = value;
            return true;
        }

        public override string ToString()
        {
            return "Set length of lists";
        }
    }
}
