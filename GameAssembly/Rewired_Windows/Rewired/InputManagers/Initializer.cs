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

// Image 66: Rewired_Windows.dll - Assembly: Rewired_Windows, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8066-8357

namespace Rewired.InputManagers
{
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal class Initializer : PlatformInitializer // TypeDefIndex: 8078
	{
		// Fields
		private static PlatformInitializer instance; // 0x00
	
		// Constructors
		public Initializer(); // 0x000000018037E800-0x000000018037E810
	
		// Methods
		public static PlatformInitializer GetPlatformInitializer(); // 0x0000000180419540-0x00000001804195C0
		public override object Initialize(ConfigVars configVars); // 0x00000001804195C0-0x0000000180419710
		public override IElementIdentifierTool CreateTool(string inputSourceString); // 0x00000001804194B0-0x0000000180419540
	}
}
