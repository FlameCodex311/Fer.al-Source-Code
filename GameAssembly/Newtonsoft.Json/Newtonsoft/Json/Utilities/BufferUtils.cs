/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using Newtonsoft.Json.Shims;

// Image 65: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7764-8065

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
	internal static class BufferUtils // TypeDefIndex: 7871
	{
		// Methods
		public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize); // 0x000000018057F2B0-0x000000018057F320
		public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer); // 0x000000018057F320-0x000000018057F380
		public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer); // 0x000000018057F210-0x000000018057F2B0
	}
}
