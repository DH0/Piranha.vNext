﻿/*
 * Copyright (c) 2014-2015 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 * 
 * http://github.com/piranhacms/piranha.vnext
 * 
 */

using System;

namespace Piranha.Extend
{
	/// <summary>
	/// The different types of extensions available.
	/// </summary>
	[Flags]
	public enum ExtensionType
	{
		Property=1,
		Region=2
	}
}
