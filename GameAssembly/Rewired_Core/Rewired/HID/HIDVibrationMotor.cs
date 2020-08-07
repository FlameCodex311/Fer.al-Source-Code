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
	internal class HIDVibrationMotor // TypeDefIndex: 6591
	{
		// Fields
		private int sLupLSjimMgsSDZkuMpPOwGdDGl; // 0x10
		private int zjCwOmZQvRvOapcrHsQtvdsUiyN; // 0x14
		private int jwFwKnKMSLapEztTXotGFbpqDKsC; // 0x18
		private Action PQFgJuaNzSQzkiJMpWjkTZmvAtaY; // 0x20
	
		// Properties
		public float Speed { get; set; } // 0x0000000180E5F350-0x0000000180E5F380 0x0000000180E5F460-0x0000000180E5F4F0
		public int SpeedRaw { get; set; } // 0x0000000180387590-0x0000000180387930 0x0000000180E5F440-0x0000000180E5F460
	
		// Events
		public event Action ValueChangedEvent {
			add; // 0x0000000180E5F250-0x0000000180E5F330
			remove; // 0x0000000180E5F380-0x0000000180E5F440
		}
	
		// Constructors
		public HIDVibrationMotor(int minSpeedRaw, int maxSpeedRaw); // 0x0000000180E5F210-0x0000000180E5F250
	
		// Methods
		private float KpNAMNOylfazNpRqZkWNjjnBNlU(int param_0000d754); // 0x0000000180E5F1E0-0x0000000180E5F210
		private int difKmeOfEceLFeNBoMdtCGDCLIqF(float param_0000d755); // 0x0000000180E5F330-0x0000000180E5F350
	}
}
