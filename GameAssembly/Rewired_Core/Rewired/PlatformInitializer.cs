/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Data;
using Rewired.Interfaces;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal abstract class PlatformInitializer // TypeDefIndex: 5747
	{
		// Constructors
		protected PlatformInitializer(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public abstract object Initialize(ConfigVars configVars);
		public abstract IElementIdentifierTool CreateTool(string inputSourceString);
	}
}
