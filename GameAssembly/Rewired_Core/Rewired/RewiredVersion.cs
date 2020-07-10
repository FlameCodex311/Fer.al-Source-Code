/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired
{
	[CustomClassObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	[CustomObfuscation] // 0x00000001800C3C10-0x00000001800C3C60
	internal struct RewiredVersion // TypeDefIndex: 5781
	{
		// Fields
		public int version1; // 0x00
		public int version2; // 0x04
		public int version3; // 0x08
		public int version4; // 0x0C
		public string unityVersion; // 0x10
	
		// Constructors
		public RewiredVersion(int version1, int version2, int version3, int version4, string unityVersion); // 0x0000000180010E50-0x0000000180010EF0
		public RewiredVersion(string versionString); // 0x0000000180010E40-0x0000000180010E50
	
		// Methods
		public override bool Equals(object obj); // 0x0000000180010CB0-0x0000000180010D70
		public override int GetHashCode(); // 0x0000000180010D70-0x0000000180010E30
		public override string ToString(); // 0x0000000180010E30-0x0000000180010E40
		public static bool operator ==(RewiredVersion a, RewiredVersion b); // 0x00000001807A6600-0x00000001807A6700
		public static bool operator !=(RewiredVersion a, RewiredVersion b); // 0x00000001807A67B0-0x00000001807A6800
		public static bool operator >(RewiredVersion a, RewiredVersion b); // 0x00000001807A6700-0x00000001807A67B0
		public static bool operator <(RewiredVersion a, RewiredVersion b); // 0x00000001807A6800-0x00000001807A68B0
	}
}
