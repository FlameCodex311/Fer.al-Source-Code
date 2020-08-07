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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.HID
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal class HIDButton : HIDControllerElement // TypeDefIndex: 6558
	{
		// Fields
		public bool rawValue; // 0x20
		public float timestamp; // 0x24
	
		// Constructors
		public HIDButton(byte reportId, HIDInfo hidInfo); // 0x0000000180E5D660-0x0000000180E5D6C0
	
		// Methods
		public void SetValue(bool rawValue, float timestamp); // 0x0000000180E5D5F0-0x0000000180E5D620
		public override void UpdateValue(NativeBuffer inputReport, float timestamp); // 0x0000000180E5D620-0x0000000180E5D660
	}
}
