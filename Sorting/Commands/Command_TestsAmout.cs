using System;

namespace Sorting.Commands
{
    class Command_TestsAmout : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Input new amout of tests:");
            string comm = Console.ReadLine();
            if (TrySetTestsAmout(comm))
            {
                Console.WriteLine("New amout has been set");
            }
            else
            {
                Console.WriteLine("Input is incorrect");
            }
        }

        private bool TrySetTestsAmout(string comm)
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
            Properties.TestsAmout = value;
            return true;
        }

        public override string ToString()
        {
            return "Set amout of tests\n";
        }
    }
}
