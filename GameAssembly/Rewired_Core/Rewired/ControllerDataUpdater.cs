/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class ControllerDataUpdater // TypeDefIndex: 6549
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
		public ControllerDataUpdater(InputSource source, int axisCount, int buttonCount, UnknownControllerHat[] unknownControllerHats); // 0x00000001808C4720-0x00000001808C4850
	
		// Methods
		public bool IsUnknownHatCardinal(int buttonIndex); // 0x00000001808C4620-0x00000001808C4720
		public UnknownControllerHat.HatButtons GetUnknownHatButtons(int buttonIndex); // 0x00000001808C4500-0x00000001808C4620
		public void ClearData(); // 0x00000001808C4440-0x00000001808C4500
	}
}
