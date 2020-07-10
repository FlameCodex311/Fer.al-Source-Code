/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Classes.Data;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal class HIDAccelerometer : HIDControllerElement // TypeDefIndex: 6397
	{
		// Fields
		public readonly float[] rawValue; // 0x20
		public float timestamp; // 0x28
		public readonly int valueLength; // 0x2C
		private readonly byte[] wuZPrKFhqfAdgfTBtloBkqjVrylu; // 0x30
		private readonly int vUlXhrGGqPAoBatyhmmMclfytPX; // 0x38
		private readonly int hKTyGPOfFdpmnBQRnpBRLEKDhlKk; // 0x3C
		private readonly Action<byte[], float[]> PDRBnHNQdiYApABXTHhIWvbNQyR; // 0x40
	
		// Constructors
		public HIDAccelerometer(byte reportId, HIDInfo hidInfo, int valueLength, Action<byte[], float[]> calcValueDelegate); // 0x0000000180619400-0x00000001806194F0
	
		// Methods
		public override void UpdateValue(NativeBuffer inputReport, float timestamp); // 0x0000000180619290-0x0000000180619400
	}
}
