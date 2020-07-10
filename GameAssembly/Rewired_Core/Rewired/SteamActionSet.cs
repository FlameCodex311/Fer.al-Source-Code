/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal class SteamActionSet // TypeDefIndex: 5779
	{
		// Fields
		public readonly string name; // 0x10
		public readonly ulong handle; // 0x18
		public readonly Dictionary<string, SteamAction> actions; // 0x20
	
		// Constructors
		public SteamActionSet(string name, ulong handle); // 0x00000001807B38C0-0x00000001807B3970
	
		// Methods
		public void AddAction(SteamAction action); // 0x00000001807B3820-0x00000001807B38C0
	}
}
