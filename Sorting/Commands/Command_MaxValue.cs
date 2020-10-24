using System;

namespace Sorting.Commands
{
    class Command_MaxValue : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Input max value:");
            string comm = Console.ReadLine();
            if (TrySetMaxValue(comm))
            {
                Console.WriteLine("New value has been set");
            }
            else
            {
                Console.WriteLine("Input is incorrect");
            }
        }

        private bool TrySetMaxValue(string comm)
        {
            int value;
            try
            {
                value = int.Parse(comm);
            }
            catch (Exception)
            {
                return false;
            }
            if (value < 1)
            {
                return false;
            }
            Properties.MaxValue = value;
            return true;
        }

        public override string ToString()
        {
            return "Set max value to elements of lists";
        }
    }
}
