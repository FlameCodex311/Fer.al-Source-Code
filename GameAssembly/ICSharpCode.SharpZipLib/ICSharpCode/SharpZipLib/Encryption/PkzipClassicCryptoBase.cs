/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Encryption
{
	internal class PkzipClassicCryptoBase // TypeDefIndex: 7691
	{
		// Fields
		private uint[] keys; // 0x10
	
		// Constructors
		public PkzipClassicCryptoBase(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		protected byte TransformByte(); // 0x0000000181EA4710-0x0000000181EA4760
		protected void SetKeys(byte[] keyData); // 0x0000000181EA4430-0x0000000181EA4710
		protected void UpdateKeys(byte ch); // 0x0000000181EA4760-0x0000000181EA49B0
		protected void Reset(); // 0x0000000181EA43A0-0x0000000181EA4430
	}
}
