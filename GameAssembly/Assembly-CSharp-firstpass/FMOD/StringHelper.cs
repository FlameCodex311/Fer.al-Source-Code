/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace FMOD
{
	internal static class StringHelper // TypeDefIndex: 10126
	{
		// Fields
		private static List<ThreadSafeEncoding> encoders; // 0x00
	
		// Nested types
		public class ThreadSafeEncoding : IDisposable // TypeDefIndex: 10127
		{
			// Fields
			private UTF8Encoding encoding; // 0x10
			private byte[] encodedBuffer; // 0x18
			private char[] decodedBuffer; // 0x20
			private bool inUse; // 0x28
			private GCHandle gcHandle; // 0x2C
	
			// Constructors
			public ThreadSafeEncoding(); // 0x0000000181BEAD50-0x0000000181BEADE0
	
			// Methods
			public bool InUse(); // 0x00000001804C6790-0x00000001804C67A0
			public void SetInUse(); // 0x000000018085EB50-0x000000018085EB60
			private int roundUpPowerTwo(int number); // 0x0000000181BEAFC0-0x0000000181BEAFE0
			public byte[] byteFromStringUTF8(string s); // 0x0000000181BEADE0-0x0000000181BEAF40
			public IntPtr intptrFromStringUTF8(string s); // 0x0000000181BEAF40-0x0000000181BEAFC0
			public string stringFromNative(IntPtr nativePtr); // 0x0000000181BEAFE0-0x0000000181BEB240
			public void Dispose(); // 0x0000000181BEAC40-0x0000000181BEAD50
		}
	
		// Constructors
		static StringHelper(); // 0x0000000181BE0670-0x0000000181BE06D0
	
		// Methods
		public static ThreadSafeEncoding GetFreeHelper(); // 0x0000000181BE0380-0x0000000181BE0670
	}
}
