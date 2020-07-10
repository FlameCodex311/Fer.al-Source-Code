/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD
{
	internal static class StringHelper // TypeDefIndex: 9672
	{
		// Fields
		private static List<ThreadSafeEncoding> encoders; // 0x00
	
		// Nested types
		public class ThreadSafeEncoding : IDisposable // TypeDefIndex: 9673
		{
			// Fields
			private UTF8Encoding encoding; // 0x10
			private byte[] encodedBuffer; // 0x18
			private char[] decodedBuffer; // 0x20
			private bool inUse; // 0x28
			private GCHandle gcHandle; // 0x2C
	
			// Constructors
			public ThreadSafeEncoding(); // 0x0000000181EF8590-0x0000000181EF8620
	
			// Methods
			public bool InUse(); // 0x00000001803A2790-0x00000001803A27A0
			public void SetInUse(); // 0x0000000181191FA0-0x0000000181191FB0
			private int roundUpPowerTwo(int number); // 0x0000000181EF8810-0x0000000181EF8830
			public byte[] byteFromStringUTF8(string s); // 0x0000000181EF8620-0x0000000181EF8790
			public IntPtr intptrFromStringUTF8(string s); // 0x0000000181EF8790-0x0000000181EF8810
			public string stringFromNative(IntPtr nativePtr); // 0x0000000181EF8830-0x0000000181EF8A90
			public void Dispose(); // 0x0000000181EF8480-0x0000000181EF8590
		}
	
		// Constructors
		static StringHelper(); // 0x0000000181EF8310-0x0000000181EF8370
	
		// Methods
		public static ThreadSafeEncoding GetFreeHelper(); // 0x0000000181EF8020-0x0000000181EF8310
	}
}
