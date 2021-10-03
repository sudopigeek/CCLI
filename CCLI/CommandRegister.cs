using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace CCLI
{
    public class CommandRegister
    {
        internal static List<Command> Commands = new List<Command>();
        public Command this[string command]
        {
            get
            {
                for (int i = 0; i < Commands.Count; i++)
                {
                    if (Commands[i].CommandName == command)
                    {
                        return Commands[i];
                    }
                }
                return null;
            }
        }
        public CommandRegister()
        {

        }

        public void RegisterCommand(Command command)
        {
            Commands.Add(command);
        }
    }

    public class Command
    {
        internal EventHandler OnExecute_Handler;
        public event EventHandler OnExecute
        {
            add
            {
                OnExecute_Handler = value;
            }
            remove
            {
                OnExecute_Handler -= value;
            }
        }
        public string CommandName { get; }
        public string[] Args { get; }
        public char ArgChar { get; }
        public Command(string commandName, string[] args, char argChar = '-')
        {
            CommandName = commandName;
            Args = args;
            ArgChar = argChar;
        }
    }
}
