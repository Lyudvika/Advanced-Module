using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core;

public class CommandInterpreter : ICommandInterpreter
{
    public string Read(string args)
    {
        string[] commandArg = args.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        string commandName = commandArg[0];

        Type commandType = Assembly
            .GetEntryAssembly()
            .GetTypes()
            .FirstOrDefault(t => t.Name == $"{commandName}Command");

        if (commandType is null)
            throw new InvalidOperationException("Command not found");

        ICommand commandInstance = Activator.CreateInstance(commandType) as ICommand;

        return commandInstance.Execute(commandArg.Skip(1).ToArray());
    }
}
