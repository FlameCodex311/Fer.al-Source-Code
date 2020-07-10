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
	internal struct PidVid : IEquatable<Rewired.PidVid> // TypeDefIndex: 5782
	{
		// Fields
		private const string qnFwinHbdbSxOuzzgyWciEJlHZv = "[^a-fA-F0-9]"; // Metadata: 0x0072EB97
		public ushort productId; // 0x00
		public ushort vendorId; // 0x02
	
		// Properties
		public bool isZero { get; } // 0x000000018000C320-0x000000018000C340 
	
		// Constructors
		public PidVid(ushort productId, ushort vendorId); // 0x000000018000C310-0x000000018000C320
		public PidVid(string pidVid); // 0x000000018000C300-0x000000018000C310
		public PidVid(Guid productGuid); // 0x000000018000C2B0-0x000000018000C300
	
		// Methods
		public bool Equals(string pidVid); // 0x000000018000C080-0x000000018000C0B0
		public Guid ToProductGuid(); // 0x000000018000C1B0-0x000000018000C240
		private bool FIUpKXqfwFwMbRkVcqLiuqHApWR(string param_0000c63b); // 0x000000018000C160-0x000000018000C170
		public override bool Equals(object obj); // 0x000000018000C0D0-0x000000018000C160
		public override int GetHashCode(); // 0x000000018000C170-0x000000018000C1B0
		public bool Equals(PidVid other); // 0x000000018000C0B0-0x000000018000C0D0
		public static bool operator ==(PidVid x, PidVid y); // 0x000000018063AA60-0x000000018063AA80
		public static bool operator !=(PidVid x, PidVid y); // 0x000000018063AA80-0x000000018063AAB0
		public override string ToString(); // 0x000000018000C240-0x000000018000C2B0
		public static bool ArrayContains(string[] pidVids, ref PidVid vidPid); // 0x000000018063A580-0x000000018063AA60
		private static string qRqEoCBxgxWKqwKgDkLBiIxJpArm(string param_0000c644); // 0x000000018063AAB0-0x000000018063ABA0
	}
}
