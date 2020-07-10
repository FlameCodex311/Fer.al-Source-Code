/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Zip
{
	public class KeysRequiredEventArgs : EventArgs // TypeDefIndex: 7560
	{
		// Fields
		private string fileName; // 0x10
		private byte[] key; // 0x18
	
		// Properties
		public byte[] Key { get; } // 0x000000018038B150-0x000000018038B160 
	
		// Constructors
		public KeysRequiredEventArgs(string name, byte[] keyValue); // 0x0000000180D5BE70-0x0000000180D5BEF0
	}
}
