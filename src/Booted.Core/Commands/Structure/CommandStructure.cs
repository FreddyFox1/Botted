﻿using System.Collections.Generic;
using System.Linq;
using Booted.Core.Commands.Abstractions;
using Booted.Core.Commands.Structure.Abstractions;
using Booted.Core.Events.EventData;
using Pidgin;

namespace Booted.Core.Commands.Structure
{
	public class CommandStructure<TData> : ICommandStructure
		where TData : class, ICommandData, new()
	{
		private readonly IList<IArgumentStructure> _arguments;

		public CommandStructure(IList<IArgumentStructure> arguments)
		{
			_arguments = arguments;
		}

		public ICommandData ParseData(BotMessage message)
		{
			var data = new TData();
			var args = Parser.CommandName
							 .IgnoreResult()
							 .Then(Parser.Argument.Many())
							 .ParseOrThrow(message.Text)
							 .ToList();
			for (var i = 0; i < args.Count; i++)
			{
				_arguments[i].PopulateValue(data, args[i]);
			}
			return data;
		}
	}
}