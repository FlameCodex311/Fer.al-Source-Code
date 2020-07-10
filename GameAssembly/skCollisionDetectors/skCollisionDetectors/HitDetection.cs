/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ProtoBuf;

// Image 72: skCollisionDetectors.dll - Assembly: skCollisionDetectors, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8904-8909

namespace skCollisionDetectors
{
	[ProtoContract] // 0x00000001800B36B0-0x00000001800B36C0
	public class HitDetection // TypeDefIndex: 8906
	{
		// Fields
		[ProtoMember] // 0x000000018016AFD0-0x000000018016AFF0
		private static readonly string[] detectionLookup; // 0x00
	
		// Constructors
		static HitDetection(); // 0x0000000180E04540-0x0000000180E04C00
	
		// Methods
		public static string calculateHit(uint[] a, int b); // 0x0000000180E04DA0-0x0000000180E04E40
		private static string axisalignedBoundigBoxDetection(uint[] a, string b); // 0x0000000180E04C00-0x0000000180E04DA0
		private static string toMatrixStr(uint[] a); // 0x0000000180E04E40-0x0000000180E04EF0
	}
}
