/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal class ControllerDataUpdater // TypeDefIndex: 6390
	{
		// Fields
		public readonly InputSource source; // 0x10
		public readonly int axisCount; // 0x14
		public readonly int buttonCount; // 0x18
		public readonly float[] axisValues; // 0x20
		public readonly bool[] buttonValues; // 0x28
		public readonly float[] buttonPressureValues; // 0x30
		public readonly bool[] axisHasBeenPressedOSXLinux; // 0x38
		private readonly UnknownControllerHat[] ErRHNThzMhIMWynLycClNnBrZXD; // 0x40
		public bool hasReceivedInput; // 0x48
	
		// Constructors
		public ControllerDataUpdater(InputSource source, int axisCount, int buttonCount, UnknownControllerHat[] unknownControllerHats); // 0x000000018043DA10-0x000000018043DB40
	
		// Methods
		public bool IsUnknownHatCardinal(int buttonIndex); // 0x000000018043D900-0x000000018043DA10
		public UnknownControllerHat.HatButtons GetUnknownHatButtons(int buttonIndex); // 0x000000018043D7D0-0x000000018043D900
		public void ClearData(); // 0x000000018043D710-0x000000018043D7D0
	}
}
