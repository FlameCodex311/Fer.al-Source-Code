﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Data;
using Rewired.Interfaces;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal abstract class PlatformInitializer // TypeDefIndex: 5906
	{
		// Constructors
		protected PlatformInitializer(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public abstract object Initialize(ConfigVars configVars);
		public abstract IElementIdentifierTool CreateTool(string inputSourceString);
	}
}
