﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inbox2.Framework.Interfaces
{
	public interface IContentMapper
	{
		string PropertyName { get; }

		string GetContent();
	}
}
