/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Utils
{
	internal class xxHash // TypeDefIndex: 7171
	{
		// Fields
		private const uint PRIME32_1 = 2654435761; // Metadata: 0x00741207
		private const uint PRIME32_2 = 2246822519; // Metadata: 0x0074120B
		private const uint PRIME32_3 = 3266489917; // Metadata: 0x0074120F
		private const uint PRIME32_4 = 668265263; // Metadata: 0x00741213
		private const uint PRIME32_5 = 374761393; // Metadata: 0x00741217
	
		// Constructors
		public xxHash(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static uint CalculateHash(byte[] buf, int len, uint seed); // 0x000000018229F880-0x000000018229FDF0
	}
}
