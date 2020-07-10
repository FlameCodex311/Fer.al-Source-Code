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
	internal static class SpecialDevices // TypeDefIndex: 6426
	{
		// Fields
		private const float OdgVMIGmcdvVCXspKVMTQHbqIqPA = 0.034f; // Metadata: 0x007300CD
		private static OjeKXdhUJsCWfJEnEDuCzIszAfzk[] diZYduXNckIEvSEgUcqZAfzGCuwb; // 0x00
	
		// Nested types
		private class OjeKXdhUJsCWfJEnEDuCzIszAfzk // TypeDefIndex: 6427
		{
			// Fields
			public readonly ushort XhiEgqjbuAkAJiKStOyrRevgyUk; // 0x10
			public readonly ushort fWIHgJTjXCUBnzYSvNWWvOXYbTY; // 0x12
			public readonly string AKhjmrPeabYLzqmorhqnKUSTEEEO; // 0x18
			public readonly bool SbOydaPOccuZSsTsckVbJCvGBbTe; // 0x20
			public readonly int bWVozTtFHfFjEBifOBXkApezXrwa; // 0x24
			public readonly int sUyGZUGXmFWqPgBaSaSRXuwPzXNC; // 0x28
			public readonly int wImrAulfVJSdfQwZgHmaSgdzvSo; // 0x2C
			public readonly float iudGcGnqgExcyaQwepwnXVPpuCb; // 0x30
	
			// Constructors
			public OjeKXdhUJsCWfJEnEDuCzIszAfzk(ushort vendorId, ushort productId, string productName, bool hasRelativeAxes, int axisMin, int axisMax, int axisZero, float relToAbsAxisConversionTimeout); // 0x0000000180620B10-0x0000000180621670
	
			// Methods
			public bool VksWkFcIbcxasOuOjdIIhJZFOb(ushort param_0000d4c9, ushort param_0000d4ca); // 0x0000000180620A70-0x0000000180620A90
			public bool VksWkFcIbcxasOuOjdIIhJZFOb(ushort param_0000d4cb, ushort param_0000d4cc, string param_0000d4cd); // 0x0000000180620A90-0x0000000180620B10
			public bool VksWkFcIbcxasOuOjdIIhJZFOb(string param_0000d4ce); // 0x0000000180620A20-0x0000000180620A70
		}
	
		// Constructors
		static SpecialDevices(); // 0x0000000180623EE0-0x00000001806241C0
	
		// Methods
		public static bool RequiresRelativeToAbsoluteAxisConversion(ushort vendorId, ushort productId, string productName = null); // 0x0000000180623E50-0x0000000180623EE0
		public static float GetRelativeToAbsoluteAxisEventTimeout(ushort vendorId, ushort productId, string productName = null); // 0x0000000180623A80-0x0000000180623B10
		public static bool GetRelativeAxisRanges(ushort vendorId, ushort productId, out int min, out int max, out int zero); // 0x0000000180623610-0x00000001806236B0
		public static bool GetRelativeAxisRanges(ushort vendorId, ushort productId, string productName, out int min, out int max, out int zero); // 0x00000001806236B0-0x0000000180623A80
		public static bool IsSupportedSpecialDevice(ushort vendorId, ushort productId, string productName = null); // 0x0000000180623B10-0x0000000180623CD0
		private static bool NqTYujJMvcEBuASjFeLpqBpAnKRY(ushort param_0000d4bb, ushort param_0000d4bc, string param_0000d4bd = null); // 0x0000000180623CD0-0x0000000180623E50
		private static OjeKXdhUJsCWfJEnEDuCzIszAfzk BPbDFbWgRBOiQDwvTljzwmueKJZ(ushort param_0000d4be, ushort param_0000d4bf, string param_0000d4c0 = null); // 0x0000000180623450-0x0000000180623610
	}
}
