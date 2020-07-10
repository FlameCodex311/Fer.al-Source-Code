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
	internal class HIDVibrationMotor // TypeDefIndex: 6432
	{
		// Fields
		private int sLupLSjimMgsSDZkuMpPOwGdDGl; // 0x10
		private int zjCwOmZQvRvOapcrHsQtvdsUiyN; // 0x14
		private int jwFwKnKMSLapEztTXotGFbpqDKsC; // 0x18
		private Action PQFgJuaNzSQzkiJMpWjkTZmvAtaY; // 0x20
	
		// Properties
		public float Speed { get; set; } // 0x000000018061B4D0-0x000000018061B500 0x000000018061B5E0-0x000000018061B670
		public int SpeedRaw { get; set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018061B5C0-0x000000018061B5E0
	
		// Events
		public event Action ValueChangedEvent {
			add; // 0x000000018061B3D0-0x000000018061B4B0
			remove; // 0x000000018061B500-0x000000018061B5C0
		}
	
		// Constructors
		public HIDVibrationMotor(int minSpeedRaw, int maxSpeedRaw); // 0x000000018061B390-0x000000018061B3D0
	
		// Methods
		private float KpNAMNOylfazNpRqZkWNjjnBNlU(int param_0000d4e4); // 0x000000018061B360-0x000000018061B390
		private int difKmeOfEceLFeNBoMdtCGDCLIqF(float param_0000d4e5); // 0x000000018061B4B0-0x000000018061B4D0
	}
}
