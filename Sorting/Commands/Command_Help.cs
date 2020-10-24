using System;
using System.Collections.Generic;

namespace Sorting.Commands
{
    class Command_Help : ICommand
    {
        private Dictionary<string, ICommand> _commands_ref;

        public Command_Help(Dictionary<string, ICommand> commands_ref)
        {
            _commands_ref = commands_ref;
        }

        public void Execute()
        {
            List<string> keys = new List<string>();
            foreach (string key in _commands_ref.Keys)
            {
                keys.Add(key);
            }

            List<string> descriptions = new List<string>();
            foreach (ICommand comm in _commands_ref.Values)
            {
                descriptions.Add(comm.ToString());
            }

            string message = "";
            for (int i = 0; i < keys.Count; i++)
            {
                message += $"{keys[i]} - {descriptions[i]}\n";
            }
            message += "\n";
            message += $"Show lists = {Properties.ShowLists}\n";  //TODO: перенести в команду info
            message += $"Lists count = {Properties.ListCount}\n"; //
            message += $"Max value = {Properties.MaxValue}\n";    //
            message += $"Tests amout = {Properties.TestsAmout}\n";//
            Console.Write(message);
        }

        public override string ToString()
        {
            return "Show list of commands";
        }
    }
}
