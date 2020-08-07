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
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class HIDLight // TypeDefIndex: 6584
	{
		// Fields
		private byte hcXwLbFwjukcdeawVajxUiIIeKCj; // 0x10
		private byte DCWzKtfuqzsYRqdWGwGZEcsicAM; // 0x11
		private byte iOCWQLvKyKqFOHEJWWldtrzSrLw; // 0x12
		private Action PQFgJuaNzSQzkiJMpWjkTZmvAtaY; // 0x18
	
		// Properties
		public float ColorR { get; set; } // 0x0000000180E5E820-0x0000000180E5E840 0x0000000180E5EAA0-0x0000000180E5EAF0
		public float ColorG { get; set; } // 0x0000000180E5E800-0x0000000180E5E820 0x0000000180E5EA10-0x0000000180E5EA80
		public float ColorB { get; set; } // 0x0000000180E5E7E0-0x0000000180E5E800 0x0000000180E5E950-0x0000000180E5E9C0
		public byte ColorRRaw { get; set; } // 0x00000001803FD450-0x00000001803FD460 0x0000000180E5EA80-0x0000000180E5EAA0
		public byte ColorGRaw { get; set; } // 0x0000000180400120-0x0000000180400130 0x0000000180E5E9C0-0x0000000180E5EA10
		public byte ColorBRaw { get; set; } // 0x000000018041B680-0x000000018041B690 0x0000000180E5E900-0x0000000180E5E950
	
		// Events
		public event Action ValueChangedEvent {
			add; // 0x0000000180E5E710-0x0000000180E5E7E0
			remove; // 0x0000000180E5E840-0x0000000180E5E900
		}
	
		// Constructors
		public HIDLight(); // 0x0000000180373240-0x0000000180373250
		public HIDLight(byte colorRRaw, byte colorGRaw, byte colorBRaw); // 0x0000000180E5E6C0-0x0000000180E5E710
	}
}
