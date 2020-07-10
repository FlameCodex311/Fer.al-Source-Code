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
	internal class HIDHat : HIDControllerElement // TypeDefIndex: 6420
	{
		// Fields
		public int rawValue; // 0x20
		public float timestamp; // 0x24
		public readonly int byteLength; // 0x28
		public readonly int startIndex; // 0x2C
		public readonly Type type; // 0x30
		private Func<int, int> PDRBnHNQdiYApABXTHhIWvbNQyR; // 0x38
	
		// Nested types
		[CustomObfuscation] // 0x00000001800B36C0-0x00000001800B36F0
		public enum Type // TypeDefIndex: 6421
		{
			ABeAWOemtDNDbkuEcBndYTrwdsCb = 0,
			fgdzdTPVbORjFIfFuGrChHZLMlg = 1
		}
	
		// Constructors
		public HIDHat(byte reportId, HIDInfo hidInfo, Type type); // 0x000000018061A6C0-0x000000018061A760
		public HIDHat(byte reportId, HIDInfo hidInfo, Func<int, int> calcValueDelegate); // 0x000000018061A760-0x000000018061A810
	
		// Methods
		public override void UpdateValue(NativeBuffer inputReport, float timestamp); // 0x000000018061A4A0-0x000000018061A6C0
	}
}
