/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Encryption
{
	internal class PkzipClassicCryptoBase // TypeDefIndex: 7525
	{
		// Fields
		private uint[] keys; // 0x10
	
		// Constructors
		public PkzipClassicCryptoBase(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		protected byte TransformByte(); // 0x0000000180D5CE50-0x0000000180D5CEA0
		protected void SetKeys(byte[] keyData); // 0x0000000180D5CB30-0x0000000180D5CE50
		protected void UpdateKeys(byte ch); // 0x0000000180D5CEA0-0x0000000180D5D120
		protected void Reset(); // 0x0000000180D5CA90-0x0000000180D5CB30
	}
}
