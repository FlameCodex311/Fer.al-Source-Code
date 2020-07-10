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
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal class HIDLight // TypeDefIndex: 6425
	{
		// Fields
		private byte hcXwLbFwjukcdeawVajxUiIIeKCj; // 0x10
		private byte DCWzKtfuqzsYRqdWGwGZEcsicAM; // 0x11
		private byte iOCWQLvKyKqFOHEJWWldtrzSrLw; // 0x12
		private Action PQFgJuaNzSQzkiJMpWjkTZmvAtaY; // 0x18
	
		// Properties
		public float ColorR { get; set; } // 0x000000018061A970-0x000000018061A990 0x000000018061ABF0-0x000000018061AC40
		public float ColorG { get; set; } // 0x000000018061A950-0x000000018061A970 0x000000018061AB60-0x000000018061ABD0
		public float ColorB { get; set; } // 0x000000018061A930-0x000000018061A950 0x000000018061AAA0-0x000000018061AB10
		public byte ColorRRaw { get; set; } // 0x0000000180375540-0x0000000180375550 0x000000018061ABD0-0x000000018061ABF0
		public byte ColorGRaw { get; set; } // 0x0000000180375550-0x0000000180375560 0x000000018061AB10-0x000000018061AB60
		public byte ColorBRaw { get; set; } // 0x000000018036CB60-0x000000018036CB70 0x000000018061AA50-0x000000018061AAA0
	
		// Events
		public event Action ValueChangedEvent {
			add; // 0x000000018061A860-0x000000018061A930
			remove; // 0x000000018061A990-0x000000018061AA50
		}
	
		// Constructors
		public HIDLight(); // 0x000000018036B6C0-0x000000018036B6D0
		public HIDLight(byte colorRRaw, byte colorGRaw, byte colorBRaw); // 0x000000018061A810-0x000000018061A860
	}
}
