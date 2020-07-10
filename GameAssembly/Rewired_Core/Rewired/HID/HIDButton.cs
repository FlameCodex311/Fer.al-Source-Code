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
	[CustomClassObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	[CustomObfuscation] // 0x00000001800C3A30-0x00000001800C3A80
	internal class HIDButton : HIDControllerElement // TypeDefIndex: 6399
	{
		// Fields
		public bool rawValue; // 0x20
		public float timestamp; // 0x24
	
		// Constructors
		public HIDButton(byte reportId, HIDInfo hidInfo); // 0x0000000180619770-0x00000001806197D0
	
		// Methods
		public void SetValue(bool rawValue, float timestamp); // 0x0000000180619700-0x0000000180619730
		public override void UpdateValue(NativeBuffer inputReport, float timestamp); // 0x0000000180619730-0x0000000180619770
	}
}
