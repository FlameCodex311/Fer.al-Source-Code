/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredSByte : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte>, IComparable<sbyte>, IComparable // TypeDefIndex: 7190
	{
		// Fields
		private sbyte currentCryptoKey; // 0x00
		private sbyte hiddenValue; // 0x01
		private bool inited; // 0x02
		private sbyte fakeValue; // 0x03
		private bool fakeValueActive; // 0x04
	
		// Constructors
		private ObscuredSByte(sbyte value); // 0x00000001802DE790-0x00000001802DE7E0
	
		// Methods
		public static sbyte Encrypt(sbyte value, sbyte key); // 0x0000000181BACEA0-0x0000000181BACEB0
		public static sbyte Decrypt(sbyte value, sbyte key); // 0x0000000181BACEA0-0x0000000181BACEB0
		public static ObscuredSByte FromEncrypted(sbyte encrypted, sbyte key); // 0x0000000181BB1240-0x0000000181BB1290
		public static sbyte GenerateKey(); // 0x0000000181BB1290-0x0000000181BB12F0
		public sbyte GetEncrypted(out sbyte key); // 0x00000001802DBE50-0x00000001802DBE60
		public void SetEncrypted(sbyte encrypted, sbyte key); // 0x00000001802DE650-0x00000001802DE690
		public sbyte GetDecrypted(); // 0x00000001802DE5B0-0x00000001802DE5C0
		public void RandomizeCryptoKey(); // 0x00000001802DE610-0x00000001802DE650
		private sbyte InternalDecrypt(); // 0x00000001802DE600-0x00000001802DE610
		public static implicit operator ObscuredSByte(sbyte value); // 0x0000000181BB1500-0x0000000181BB1550
		public static implicit operator sbyte(ObscuredSByte value); // 0x0000000181BB1550-0x0000000181BB1560
		public static ObscuredSByte operator ++(ObscuredSByte input); // 0x0000000181BB1560-0x0000000181BB1650
		public static ObscuredSByte operator --(ObscuredSByte input); // 0x0000000181BB1410-0x0000000181BB1500
		private static ObscuredSByte Increment(ObscuredSByte input, int increment); // 0x0000000181BB12F0-0x0000000181BB1410
		public override int GetHashCode(); // 0x00000001802DE5D0-0x00000001802DE600
		public override string ToString(); // 0x00000001802DE760-0x00000001802DE790
		public string ToString(string format); // 0x00000001802DE690-0x00000001802DE6D0
		public string ToString(IFormatProvider provider); // 0x00000001802DE6D0-0x00000001802DE710
		public string ToString(string format, IFormatProvider provider); // 0x00000001802DE710-0x00000001802DE760
		public override bool Equals(object obj); // 0x00000001802DE4D0-0x00000001802DE5B0
		public bool Equals(ObscuredSByte obj); // 0x00000001802DBCF0-0x00000001802DBD60
		public int CompareTo(ObscuredSByte other); // 0x00000001802DE3D0-0x00000001802DE490
		public int CompareTo(sbyte other); // 0x00000001802DE390-0x00000001802DE3D0
		public int CompareTo(object obj); // 0x00000001802DE490-0x00000001802DE4D0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(sbyte newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D4DC0-0x00000001800D4DF0
		public static sbyte EncryptDecrypt(sbyte value); // 0x0000000181BB11A0-0x0000000181BB11F0
		[Obsolete] // 0x00000001800D5120-0x00000001800D5150
		public static sbyte EncryptDecrypt(sbyte value, sbyte key); // 0x0000000181BACEA0-0x0000000181BACEB0
		[Obsolete] // 0x00000001800D43F0-0x00000001800D4420
		public static ObscuredSByte FromEncrypted(sbyte encrypted); // 0x0000000181BB11F0-0x0000000181BB1240
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public sbyte GetEncrypted(); // 0x00000001802DE5C0-0x00000001802DE5D0
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(sbyte encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
