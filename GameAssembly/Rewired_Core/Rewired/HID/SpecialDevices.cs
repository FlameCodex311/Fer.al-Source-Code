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
	internal static class SpecialDevices // TypeDefIndex: 6585
	{
		// Fields
		private const float OdgVMIGmcdvVCXspKVMTQHbqIqPA = 0.034f; // Metadata: 0x00764D6A
		private static OjeKXdhUJsCWfJEnEDuCzIszAfzk[] diZYduXNckIEvSEgUcqZAfzGCuwb; // 0x00
	
		// Nested types
		private class OjeKXdhUJsCWfJEnEDuCzIszAfzk // TypeDefIndex: 6586
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
			public OjeKXdhUJsCWfJEnEDuCzIszAfzk(ushort vendorId, ushort productId, string productName, bool hasRelativeAxes, int axisMin, int axisMax, int axisZero, float relToAbsAxisConversionTimeout); // 0x0000000180E647B0-0x0000000180E652B0
	
			// Methods
			public bool VksWkFcIbcxasOuOjdIIhJZFOb(ushort param_0000d739, ushort param_0000d73a); // 0x0000000180E64710-0x0000000180E64730
			public bool VksWkFcIbcxasOuOjdIIhJZFOb(ushort param_0000d73b, ushort param_0000d73c, string param_0000d73d); // 0x0000000180E64730-0x0000000180E647B0
			public bool VksWkFcIbcxasOuOjdIIhJZFOb(string param_0000d73e); // 0x0000000180E646C0-0x0000000180E64710
		}
	
		// Constructors
		static SpecialDevices(); // 0x0000000180E679F0-0x0000000180E67CC0
	
		// Methods
		public static bool RequiresRelativeToAbsoluteAxisConversion(ushort vendorId, ushort productId, string productName = null); // 0x0000000180E67960-0x0000000180E679F0
		public static float GetRelativeToAbsoluteAxisEventTimeout(ushort vendorId, ushort productId, string productName = null); // 0x0000000180E675B0-0x0000000180E67640
		public static bool GetRelativeAxisRanges(ushort vendorId, ushort productId, out int min, out int max, out int zero); // 0x0000000180E67160-0x0000000180E67200
		public static bool GetRelativeAxisRanges(ushort vendorId, ushort productId, string productName, out int min, out int max, out int zero); // 0x0000000180E67200-0x0000000180E675B0
		public static bool IsSupportedSpecialDevice(ushort vendorId, ushort productId, string productName = null); // 0x0000000180E67640-0x0000000180E677F0
		private static bool NqTYujJMvcEBuASjFeLpqBpAnKRY(ushort param_0000d72b, ushort param_0000d72c, string param_0000d72d = null); // 0x0000000180E677F0-0x0000000180E67960
		private static OjeKXdhUJsCWfJEnEDuCzIszAfzk BPbDFbWgRBOiQDwvTljzwmueKJZ(ushort param_0000d72e, ushort param_0000d72f, string param_0000d730 = null); // 0x0000000180E66FA0-0x0000000180E67160
	}
}
