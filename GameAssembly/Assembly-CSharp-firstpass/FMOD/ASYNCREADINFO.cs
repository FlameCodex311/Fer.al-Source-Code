/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD
{
	public struct ASYNCREADINFO // TypeDefIndex: 10061
	{
		// Fields
		public IntPtr handle; // 0x00
		public uint offset; // 0x08
		public uint sizebytes; // 0x0C
		public int priority; // 0x10
		public IntPtr userdata; // 0x18
		public IntPtr buffer; // 0x20
		public uint bytesread; // 0x28
		public FILE_ASYNCDONE_FUNC done; // 0x30
	}
}
