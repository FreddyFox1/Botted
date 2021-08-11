﻿using Booted.Core.Commands.Abstractions;

namespace Booted.Core.Commands
{
	public static class CommandResult
	{
		public static ICommandResult Ok(string text) 
			=> new OkCommandResult(text);
		public static ICommandResult Error(string text) 
			=> new ErrorCommandResult(text);
		
		public class OkCommandResult : CommandResultBase
		{
			public OkCommandResult(string text) : base(text) {}
		}

		public class ErrorCommandResult : CommandResultBase
		{
			public ErrorCommandResult(string text) : base(text) {}
		}

		public abstract class CommandResultBase : ICommandResult
		{
			protected CommandResultBase(string text)
			{
				Text = text;
			}
			
			public string Text { get; }
		}
	}
}