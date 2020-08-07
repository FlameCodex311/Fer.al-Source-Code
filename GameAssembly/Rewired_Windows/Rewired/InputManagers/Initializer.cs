/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Data;
using Rewired.Interfaces;

// Image 67: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8232-8523

namespace Rewired.InputManagers
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal class Initializer : PlatformInitializer // TypeDefIndex: 8244
	{
		// Fields
		private static PlatformInitializer instance; // 0x00
	
		// Constructors
		public Initializer(); // 0x00000001803F46D0-0x00000001803F46E0
	
		// Methods
		public static PlatformInitializer GetPlatformInitializer(); // 0x0000000180825320-0x00000001808253A0
		public override object Initialize(ConfigVars configVars); // 0x00000001808253A0-0x00000001808254F0
		public override IElementIdentifierTool CreateTool(string inputSourceString); // 0x0000000180825290-0x0000000180825320
	}
}
