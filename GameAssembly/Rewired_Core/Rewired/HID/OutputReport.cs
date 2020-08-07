/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal struct OutputReport // TypeDefIndex: 6560
	{
		// Fields
		public int reportId; // 0x00
		public IntPtr buffer; // 0x08
		public int bufferLength; // 0x10
		public int reportLength; // 0x14
		public OutputReportOptions options; // 0x18
	
		// Properties
		public bool IsValid { get; } // 0x00000001800A4280-0x00000001800A42E0 
	
		// Constructors
		public OutputReport(IntPtr buffer, int bufferLength, int reportLength); // 0x00000001800A4260-0x00000001800A4280
	
		// Methods
		public void Clear(); // 0x00000001800A4240-0x00000001800A4250
		public override string ToString(); // 0x00000001800A4250-0x00000001800A4260
	}
}
