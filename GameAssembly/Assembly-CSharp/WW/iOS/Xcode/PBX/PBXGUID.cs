/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class PBXGUID // TypeDefIndex: 15834
	{
		// Fields
		private static GuidGenerator guidGenerator; // 0x00
	
		// Nested types
		internal delegate string GuidGenerator(); // TypeDefIndex: 15835; 0x0000000180ABE4F0-0x0000000180ABE710
	
		// Constructors
		public PBXGUID(); // 0x000000018036B6C0-0x000000018036B6D0
		static PBXGUID(); // 0x000000018167F5D0-0x000000018167F630
	
		// Methods
		internal static string DefaultGuidGenerator(); // 0x000000018167F450-0x000000018167F500
		internal static void SetGuidGenerator(GuidGenerator generator); // 0x000000018167F570-0x000000018167F5D0
		public static string Generate(); // 0x000000018167F500-0x000000018167F570
	}
}
