/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal struct OutputReport // TypeDefIndex: 6401
	{
		// Fields
		public int reportId; // 0x00
		public IntPtr buffer; // 0x08
		public int bufferLength; // 0x10
		public int reportLength; // 0x14
		public OutputReportOptions options; // 0x18
	
		// Properties
		public bool IsValid { get; } // 0x000000018000BB10-0x000000018000BB70 
	
		// Constructors
		public OutputReport(IntPtr buffer, int bufferLength, int reportLength); // 0x000000018000BAF0-0x000000018000BB10
	
		// Methods
		public void Clear(); // 0x000000018000BAD0-0x000000018000BAE0
		public override string ToString(); // 0x000000018000BAE0-0x000000018000BAF0
	}
}
