/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ProtoBuf;

// Image 73: skCollisionDetectors.dll - Assembly: skCollisionDetectors, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9070-9075

namespace skCollisionDetectors
{
	[ProtoContract] // 0x00000001801CDAD0-0x00000001801CDAE0
	public class HitDetection // TypeDefIndex: 9072
	{
		// Fields
		[ProtoMember] // 0x0000000180209710-0x0000000180209730
		private static readonly string[] detectionLookup; // 0x00
	
		// Constructors
		static HitDetection(); // 0x00000001820E8A00-0x00000001820E9060
	
		// Methods
		public static string calculateHit(uint[] a, int b); // 0x00000001820E9200-0x00000001820E92A0
		private static string axisalignedBoundigBoxDetection(uint[] a, string b); // 0x00000001820E9060-0x00000001820E9200
		private static string toMatrixStr(uint[] a); // 0x00000001820E92A0-0x00000001820E9350
	}
}
