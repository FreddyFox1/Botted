﻿using System.Linq;
using Botted.Core.Database.Abstractions;
using Botted.Core.Users.Abstractions.Data;

namespace Botted.Core.Users.Abstractions
{
	/// <summary>
	/// Represents a database for <see cref="User"/>
	/// </summary>
	public interface IUserDatabase : IDatabase
	{
		/// <summary>
		/// Users of the bot
		/// </summary>
		IQueryable<User> Users { get; }

		/// <summary>
		/// Register new user
		/// </summary>
		/// <returns></returns>
		User RegisterUser();
	}
}