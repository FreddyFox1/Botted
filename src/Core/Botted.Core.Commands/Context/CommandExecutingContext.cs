﻿using Botted.Core.Commands.Abstractions.Context;
using Botted.Core.Commands.Abstractions.Data;

namespace Botted.Core.Commands.Context
{
	/// <inheritdoc />
	public class CommandExecutingContext : ICommandExecutingContext
	{
		public CommandExecutingContext(string commandName, 
									   ICommandData commandData, 
									   bool canExecute)
		{
			CommandName = commandName;
			CommandData = commandData;
			CanExecute = canExecute;
		}

		public string CommandName { get; }

		public ICommandData CommandData { get; }

		public bool CanExecute { get; set; }
	}
}