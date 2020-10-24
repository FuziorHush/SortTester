using System;
using System.Collections.Generic;
using Sorting.Sorts;
using Sorting.Commands;

namespace Sorting
{
    class BaseController
    {
        //TODO: тесты

        private Dictionary<string, ICommand> _commands;

        public BaseController()
        {
            FillCommands();
            CallCommand("help");
            GetCommand();
        }

        private void FillCommands()
        {
            _commands = new Dictionary<string, ICommand>();
            _commands.Add("help", new Command_Help(_commands));
            _commands.Add("show", new Command_ShowList());
            _commands.Add("count", new Command_ListCount());
            _commands.Add("max", new Command_MaxValue());
            _commands.Add("tests", new Command_TestsAmout());

            _commands.Add("worst", new Command_WorstSort());
            _commands.Add("bubble", new Command_InsertionSort());
            _commands.Add("cocktail", new Command_CocktailSort());
            _commands.Add("insert", new Command_InsertionSort());
            _commands.Add("shell", new Command_ShellSort());
            _commands.Add("select", new Command_SelectionSort());
        }

        private void GetCommand() {
            while (true) {
                CallCommand(Console.ReadLine().ToLower());
            }
        }

        private void CallCommand(string comm) {
            if (_commands.ContainsKey(comm))
            {
                _commands[comm].Execute();
            }
            else {
                Console.WriteLine("Unknown command");
            }
        }
    }
}
