/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace FMOD
{
	public struct Memory // TypeDefIndex: 9659
	{
		// Methods
		public static RESULT Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags = MEMORY_TYPE.NORMAL | MEMORY_TYPE.STREAM_FILE | MEMORY_TYPE.STREAM_DECODE | MEMORY_TYPE.SAMPLEDATA | MEMORY_TYPE.DSP_BUFFER | MEMORY_TYPE.PLUGIN | MEMORY_TYPE.PERSISTENT | MEMORY_TYPE.ALL /* Metadata: 0x007457FB */); // 0x0000000181EF30A0-0x0000000181EF3190
		public static RESULT GetStats(out int currentalloced, out int maxalloced, bool blocking = true /* Metadata: 0x007457FF */); // 0x0000000181EF2FE0-0x0000000181EF30A0
		private static extern RESULT FMOD5_Memory_Initialize(IntPtr poolmem, int poollen, MEMORY_ALLOC_CALLBACK useralloc, MEMORY_REALLOC_CALLBACK userrealloc, MEMORY_FREE_CALLBACK userfree, MEMORY_TYPE memtypeflags); // 0x0000000181EF30A0-0x0000000181EF3190
		private static extern RESULT FMOD5_Memory_GetStats(out int currentalloced, out int maxalloced, bool blocking); // 0x0000000181EF2FE0-0x0000000181EF30A0
	}
}
