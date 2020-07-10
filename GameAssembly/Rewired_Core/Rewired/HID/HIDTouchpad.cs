/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Classes.Data;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal class HIDTouchpad : HIDControllerElement // TypeDefIndex: 6428
	{
		// Fields
		private TouchpadInfo GBluTNNcQBtQoTXZVzOQZAmhzh; // 0x20
		private Queue<TouchData> GsszQXQGwmfqfgIvEraNKFGmkfA; // 0x28
		private TouchData[] fyGBMrkPBiRFscYVITjZlMMNmwpX; // 0x30
		private Action<NativeBuffer, TouchData[]> PDRBnHNQdiYApABXTHhIWvbNQyR; // 0x38
		public TouchData[] values; // 0x40
	
		// Nested types
		[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
		[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
		internal class TouchpadInfo // TypeDefIndex: 6429
		{
			// Fields
			public int maxTouches; // 0x10
			public int minX; // 0x14
			public int maxX; // 0x18
			public int minY; // 0x1C
			public int maxY; // 0x20
			public bool invertY; // 0x24
			public bool reverseY; // 0x25
	
			// Constructors
			public TouchpadInfo(int maxTouches, int minX, int maxX, int minY, int maxY, bool invertY, bool reverseY); // 0x0000000180624350-0x00000001806243C0
	
			// Methods
			public void CalculateTouch(ref TouchData data); // 0x00000001806241C0-0x0000000180624350
		}
	
		[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
		[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
		internal struct TouchData // TypeDefIndex: 6430
		{
			// Fields
			public int touchId; // 0x00
			public float timeStamp; // 0x04
			public bool isTouching; // 0x08
			public int positionRawX; // 0x0C
			public int positionRawY; // 0x10
			public float positionX; // 0x14
			public float positionY; // 0x18
			public int positionAbsX; // 0x1C
			public int positionAbsY; // 0x20
	
			// Methods
			public void Clear(); // 0x000000018000BB70-0x000000018000C080
		}
	
		// Constructors
		public HIDTouchpad(byte reportId, TouchpadInfo info, HIDInfo hidInfo, Action<NativeBuffer, TouchData[]> calcValueDelegate); // 0x000000018061B1B0-0x000000018061B360
	
		// Methods
		public override void UpdateValue(NativeBuffer inputReport, float timestamp); // 0x000000018061AFA0-0x000000018061B1B0
		public void ProcessQueue(); // 0x000000018061AD00-0x000000018061AFA0
		public bool IsTouching(int touchId); // 0x000000018061AC40-0x000000018061AD00
	}
}
