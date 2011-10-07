﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using Inbox2.Framework;
using Inbox2.Framework.Plugins;

namespace Inbox2.Core.LauncherCommands
{
	[Export(typeof(LauncherCommand))]
	public class FindAPersonCommand : LauncherCommand
	{
		const string CommandText = "View the person {0}";

		public FindAPersonCommand() : base(CommandText)
		{
		}

		public override void Execute(string query)
		{
			LauncherState.Current.Channel.Search(query);
		}

		public override void UpdateDescription(string query)
		{
			Description = String.Format(CommandText, query);
		}

		public override bool CanExecute(string query)
		{
			return LauncherState.Current.HasSelectedAddresses;
		}
	}
}