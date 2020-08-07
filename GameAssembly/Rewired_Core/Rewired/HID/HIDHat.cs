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
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal class HIDHat : HIDControllerElement // TypeDefIndex: 6579
	{
		// Fields
		public int rawValue; // 0x20
		public float timestamp; // 0x24
		public readonly int byteLength; // 0x28
		public readonly int startIndex; // 0x2C
		public readonly Type type; // 0x30
		private Func<int, int> PDRBnHNQdiYApABXTHhIWvbNQyR; // 0x38
	
		// Nested types
		[CustomObfuscation] // 0x00000001801CF5D0-0x00000001801CF600
		public enum Type // TypeDefIndex: 6580
		{
			ABeAWOemtDNDbkuEcBndYTrwdsCb = 0,
			fgdzdTPVbORjFIfFuGrChHZLMlg = 1
		}
	
		// Constructors
		public HIDHat(byte reportId, HIDInfo hidInfo, Type type); // 0x0000000180E5E580-0x0000000180E5E620
		public HIDHat(byte reportId, HIDInfo hidInfo, Func<int, int> calcValueDelegate); // 0x0000000180E5E620-0x0000000180E5E6C0
	
		// Methods
		public override void UpdateValue(NativeBuffer inputReport, float timestamp); // 0x0000000180E5E360-0x0000000180E5E580
	}
}
