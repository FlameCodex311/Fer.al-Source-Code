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

// Image 66: Newtonsoft.Json.dll - Assembly: Newtonsoft.Json, Version=8.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7930-8231

namespace Newtonsoft.Json.Utilities
{
	[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
	internal static class BufferUtils // TypeDefIndex: 8037
	{
		// Methods
		public static char[] RentBuffer(IArrayPool<char> bufferPool, int minSize); // 0x0000000180C17AE0-0x0000000180C17B50
		public static void ReturnBuffer(IArrayPool<char> bufferPool, char[] buffer); // 0x0000000180C17B50-0x0000000180C17BB0
		public static char[] EnsureBufferSize(IArrayPool<char> bufferPool, int size, char[] buffer); // 0x0000000180C17A40-0x0000000180C17AE0
	}
}
