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
	internal struct PidVid : IEquatable<Rewired.PidVid> // TypeDefIndex: 5941
	{
		// Fields
		private const string qnFwinHbdbSxOuzzgyWciEJlHZv = "[^a-fA-F0-9]"; // Metadata: 0x00763834
		public ushort productId; // 0x00
		public ushort vendorId; // 0x02
	
		// Properties
		public bool isZero { get; } // 0x00000001800A4CA0-0x00000001800A4CC0 
	
		// Constructors
		public PidVid(ushort productId, ushort vendorId); // 0x00000001800A4C90-0x00000001800A4CA0
		public PidVid(string pidVid); // 0x00000001800A4C80-0x00000001800A4C90
		public PidVid(Guid productGuid); // 0x00000001800A4C30-0x00000001800A4C80
	
		// Methods
		public bool Equals(string pidVid); // 0x00000001800A4A00-0x00000001800A4A30
		public Guid ToProductGuid(); // 0x00000001800A4B30-0x00000001800A4BC0
		private bool FIUpKXqfwFwMbRkVcqLiuqHApWR(string param_0000c8ab); // 0x00000001800A4AE0-0x00000001800A4AF0
		public override bool Equals(object obj); // 0x00000001800A4A50-0x00000001800A4AE0
		public override int GetHashCode(); // 0x00000001800A4AF0-0x00000001800A4B30
		public bool Equals(PidVid other); // 0x00000001800A4A30-0x00000001800A4A50
		public static bool operator ==(PidVid x, PidVid y); // 0x0000000180EB21F0-0x0000000180EB2210
		public static bool operator !=(PidVid x, PidVid y); // 0x0000000180EB2210-0x0000000180EB2240
		public override string ToString(); // 0x00000001800A4BC0-0x00000001800A4C30
		public static bool ArrayContains(string[] pidVids, ref PidVid vidPid); // 0x0000000180EB1D10-0x0000000180EB21F0
		private static string qRqEoCBxgxWKqwKgDkLBiIxJpArm(string param_0000c8b4); // 0x0000000180EB2240-0x0000000180EB2330
	}
}
