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

namespace Rewired.Utils
{
	[CustomClassObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	[CustomObfuscation] // 0x00000001801CDC90-0x00000001801CDCE0
	internal static class NativeTools // TypeDefIndex: 7049
	{
		// Fields
		private static byte[] VQWvhhNdJjshCTxywtnOnztLQzw; // 0x00
	
		// Methods
		public static IntPtr OffsetIntPtr(IntPtr intPtr, int offset); // 0x00000001813F8A10-0x00000001813F8AE0
		public static bool CopyMemory(IntPtr source, IntPtr destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true /* Metadata: 0x0076679A */); // 0x00000001813F7110-0x00000001813F76D0
		public static bool CopyMemory(byte[] source, IntPtr destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true /* Metadata: 0x0076679B */); // 0x00000001813F6D80-0x00000001813F7110
		public static bool CopyMemory(IntPtr source, byte[] destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true /* Metadata: 0x0076679C */); // 0x00000001813F6AA0-0x00000001813F6D80
		public static bool FillMemory(IntPtr buffer, int length, byte value, bool throwOnError = true /* Metadata: 0x0076679D */); // 0x00000001813F7B90-0x00000001813F7BC0
		public static bool FillMemory(IntPtr buffer, int startIndex, int length, byte value, bool throwOnError = true /* Metadata: 0x0076679E */); // 0x00000001813F7BF0-0x00000001813F8970
		public static bool FillMemory(byte[] buffer, int length, byte value, bool throwOnError = true /* Metadata: 0x0076679F */); // 0x00000001813F7BC0-0x00000001813F7BF0
		public static bool FillMemory(byte[] buffer, int startIndex, int length, byte value, bool throwOnError = true /* Metadata: 0x007667A0 */); // 0x00000001813F7870-0x00000001813F7B90
		public static void ZeroFillMemory(IntPtr buffer, int length); // 0x00000001813F8AE0-0x00000001813F8EC0
		public static string DumpToString(IntPtr buffer, int length, string stringFormat = "x2" /* Metadata: 0x007667A1 */); // 0x00000001813F76D0-0x00000001813F7870
		public static void FreeHGlobalSafe(ref IntPtr pointer); // 0x00000001813F8970-0x00000001813F8A10
	}
}
