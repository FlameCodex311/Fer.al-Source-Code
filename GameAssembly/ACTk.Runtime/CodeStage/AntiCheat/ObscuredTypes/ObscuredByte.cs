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
	public struct ObscuredByte : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredByte>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredByte>, IComparable<byte>, IComparable // TypeDefIndex: 7178
	{
		// Fields
		private byte currentCryptoKey; // 0x00
		private byte hiddenValue; // 0x01
		private bool inited; // 0x02
		private byte fakeValue; // 0x03
		private bool fakeValueActive; // 0x04
	
		// Constructors
		private ObscuredByte(byte value); // 0x00000001802DC030-0x00000001802DC0E0
	
		// Methods
		public static byte Encrypt(byte value, byte key); // 0x0000000181BACEA0-0x0000000181BACEB0
		public static void Encrypt(byte[] value, byte key); // 0x0000000181BACEB0-0x0000000181BACF10
		public static byte Decrypt(byte value, byte key); // 0x0000000181BACEA0-0x0000000181BACEB0
		public static void Decrypt(byte[] value, byte key); // 0x0000000181BACEB0-0x0000000181BACF10
		public static ObscuredByte FromEncrypted(byte encrypted, byte key); // 0x0000000181BAD000-0x0000000181BAD0A0
		public static byte GenerateKey(); // 0x0000000181BACD00-0x0000000181BACE20
		public byte GetEncrypted(out byte key); // 0x00000001802DBE50-0x00000001802DBE60
		public void SetEncrypted(byte encrypted, byte key); // 0x00000001802DBEF0-0x00000001802DBF30
		public byte GetDecrypted(); // 0x00000001802DBE40-0x00000001802DBE50
		public void RandomizeCryptoKey(); // 0x00000001802DBEB0-0x00000001802DBEF0
		private byte InternalDecrypt(); // 0x00000001802DBEA0-0x00000001802DBEB0
		public static implicit operator ObscuredByte(byte value); // 0x0000000181BAD2B0-0x0000000181BAD300
		public static implicit operator byte(ObscuredByte value); // 0x0000000181BAD300-0x0000000181BAD310
		public static ObscuredByte operator ++(ObscuredByte input); // 0x0000000181BAD310-0x0000000181BAD400
		public static ObscuredByte operator --(ObscuredByte input); // 0x0000000181BAD1C0-0x0000000181BAD2B0
		private static ObscuredByte Increment(ObscuredByte input, int increment); // 0x0000000181BAD0A0-0x0000000181BAD1C0
		public override int GetHashCode(); // 0x00000001802DBE70-0x00000001802DBEA0
		public override string ToString(); // 0x00000001802DC000-0x00000001802DC030
		public string ToString(string format); // 0x00000001802DBF70-0x00000001802DBFB0
		public string ToString(IFormatProvider provider); // 0x00000001802DBF30-0x00000001802DBF70
		public string ToString(string format, IFormatProvider provider); // 0x00000001802DBFB0-0x00000001802DC000
		public override bool Equals(object obj); // 0x00000001802DBD60-0x00000001802DBE40
		public bool Equals(ObscuredByte obj); // 0x00000001802DBCF0-0x00000001802DBD60
		public int CompareTo(ObscuredByte other); // 0x00000001802DBBF0-0x00000001802DBCB0
		public int CompareTo(byte other); // 0x00000001802DBCB0-0x00000001802DBCF0
		public int CompareTo(object obj); // 0x00000001802DBBB0-0x00000001802DBBF0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(byte newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D4DC0-0x00000001800D4DF0
		public static byte EncryptDecrypt(byte value); // 0x0000000181BACF60-0x0000000181BACFB0
		[Obsolete] // 0x00000001800D4DC0-0x00000001800D4DF0
		public static byte EncryptDecrypt(byte[] value); // 0x0000000181BACF10-0x0000000181BACF60
		[Obsolete] // 0x00000001800D5120-0x00000001800D5150
		public static byte EncryptDecrypt(byte value, byte key); // 0x0000000181BACEA0-0x0000000181BACEB0
		[Obsolete] // 0x00000001800D5120-0x00000001800D5150
		public static void EncryptDecrypt(byte[] value, byte key); // 0x0000000181BACEB0-0x0000000181BACF10
		[Obsolete] // 0x00000001800D43F0-0x00000001800D4420
		public static ObscuredByte FromEncrypted(byte encrypted); // 0x0000000181BACFB0-0x0000000181BAD000
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public byte GetEncrypted(); // 0x00000001802DBE60-0x00000001802DBE70
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(byte encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
