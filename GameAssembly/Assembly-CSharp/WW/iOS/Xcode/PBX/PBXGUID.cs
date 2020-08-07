/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class PBXGUID // TypeDefIndex: 16214
	{
		// Fields
		private static GuidGenerator guidGenerator; // 0x00
	
		// Nested types
		internal delegate string GuidGenerator(); // TypeDefIndex: 16215; 0x0000000180971630-0x0000000180971850
	
		// Constructors
		public PBXGUID(); // 0x0000000180373240-0x0000000180373250
		static PBXGUID(); // 0x00000001809779D0-0x0000000180977A30
	
		// Methods
		internal static string DefaultGuidGenerator(); // 0x0000000180977850-0x0000000180977900
		internal static void SetGuidGenerator(GuidGenerator generator); // 0x0000000180977970-0x00000001809779D0
		public static string Generate(); // 0x0000000180977900-0x0000000180977970
	}
}
