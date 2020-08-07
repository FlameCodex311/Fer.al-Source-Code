/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.Utils
{
	internal class xxHash // TypeDefIndex: 7337
	{
		// Fields
		private const uint PRIME32_1 = 2654435761; // Metadata: 0x00775EF5
		private const uint PRIME32_2 = 2246822519; // Metadata: 0x00775EF9
		private const uint PRIME32_3 = 3266489917; // Metadata: 0x00775EFD
		private const uint PRIME32_4 = 668265263; // Metadata: 0x00775F01
		private const uint PRIME32_5 = 374761393; // Metadata: 0x00775F05
	
		// Constructors
		public xxHash(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static uint CalculateHash(byte[] buf, int len, uint seed); // 0x000000018200ADC0-0x000000018200BF20
	}
}
