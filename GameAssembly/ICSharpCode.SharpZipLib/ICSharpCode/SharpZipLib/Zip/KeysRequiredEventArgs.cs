/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Zip
{
	public class KeysRequiredEventArgs : EventArgs // TypeDefIndex: 7726
	{
		// Fields
		private string fileName; // 0x10
		private byte[] key; // 0x18
	
		// Properties
		public byte[] Key { get; } // 0x0000000180372430-0x0000000180372440 
	
		// Constructors
		public KeysRequiredEventArgs(string name, byte[] keyValue); // 0x0000000181EA37C0-0x0000000181EA3840
	}
}
