/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	[CustomObfuscation] // 0x00000001801CDED0-0x00000001801CDF20
	internal struct RewiredVersion // TypeDefIndex: 5940
	{
		// Fields
		public int version1; // 0x00
		public int version2; // 0x04
		public int version3; // 0x08
		public int version4; // 0x0C
		public string unityVersion; // 0x10
	
		// Constructors
		public RewiredVersion(int version1, int version2, int version3, int version4, string unityVersion); // 0x00000001800B5550-0x00000001800B55F0
		public RewiredVersion(string versionString); // 0x00000001800B5540-0x00000001800B5550
	
		// Methods
		public override bool Equals(object obj); // 0x00000001800B53B0-0x00000001800B5470
		public override int GetHashCode(); // 0x00000001800B5470-0x00000001800B5530
		public override string ToString(); // 0x00000001800B5530-0x00000001800B5540
		public static bool operator ==(RewiredVersion a, RewiredVersion b); // 0x000000018109B500-0x000000018109B600
		public static bool operator !=(RewiredVersion a, RewiredVersion b); // 0x000000018109B6B0-0x000000018109B700
		public static bool operator >(RewiredVersion a, RewiredVersion b); // 0x000000018109B600-0x000000018109B6B0
		public static bool operator <(RewiredVersion a, RewiredVersion b); // 0x000000018109B700-0x000000018109B7B0
	}
}
