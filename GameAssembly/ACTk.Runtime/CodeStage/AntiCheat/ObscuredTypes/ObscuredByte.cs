/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredByte : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredByte>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredByte>, IComparable<byte>, IComparable // TypeDefIndex: 7344
	{
		// Fields
		private byte currentCryptoKey; // 0x00
		private byte hiddenValue; // 0x01
		private bool inited; // 0x02
		private byte fakeValue; // 0x03
		private bool fakeValueActive; // 0x04
	
		// Constructors
		private ObscuredByte(byte value); // 0x00000001800F0E00-0x00000001800F0EB0
	
		// Methods
		public static byte Encrypt(byte value, byte key); // 0x000000018187E740-0x000000018187E750
		public static void Encrypt(byte[] value, byte key); // 0x000000018187E750-0x000000018187E7A0
		public static byte Decrypt(byte value, byte key); // 0x000000018187E740-0x000000018187E750
		public static void Decrypt(byte[] value, byte key); // 0x000000018187E750-0x000000018187E7A0
		public static ObscuredByte FromEncrypted(byte encrypted, byte key); // 0x000000018187E890-0x000000018187E930
		public static byte GenerateKey(); // 0x000000018187E5A0-0x000000018187E6C0
		public byte GetEncrypted(out byte key); // 0x00000001800F0C20-0x00000001800F0C30
		public void SetEncrypted(byte encrypted, byte key); // 0x00000001800F0CC0-0x00000001800F0D00
		public byte GetDecrypted(); // 0x00000001800F0C10-0x00000001800F0C20
		public void RandomizeCryptoKey(); // 0x00000001800F0C80-0x00000001800F0CC0
		private byte InternalDecrypt(); // 0x00000001800F0C70-0x00000001800F0C80
		public static implicit operator ObscuredByte(byte value); // 0x000000018187EB40-0x000000018187EB90
		public static implicit operator byte(ObscuredByte value); // 0x000000018187EB90-0x000000018187EBA0
		public static ObscuredByte operator ++(ObscuredByte input); // 0x000000018187EBA0-0x000000018187EC90
		public static ObscuredByte operator --(ObscuredByte input); // 0x000000018187EA50-0x000000018187EB40
		private static ObscuredByte Increment(ObscuredByte input, int increment); // 0x000000018187E930-0x000000018187EA50
		public override int GetHashCode(); // 0x00000001800F0C40-0x00000001800F0C70
		public override string ToString(); // 0x00000001800F0DD0-0x00000001800F0E00
		public string ToString(string format); // 0x00000001800F0D40-0x00000001800F0D80
		public string ToString(IFormatProvider provider); // 0x00000001800F0D00-0x00000001800F0D40
		public string ToString(string format, IFormatProvider provider); // 0x00000001800F0D80-0x00000001800F0DD0
		public override bool Equals(object obj); // 0x00000001800F0B30-0x00000001800F0C10
		public bool Equals(ObscuredByte obj); // 0x00000001800F0AC0-0x00000001800F0B30
		public int CompareTo(ObscuredByte other); // 0x00000001800F09C0-0x00000001800F0A80
		public int CompareTo(byte other); // 0x00000001800F0A80-0x00000001800F0AC0
		public int CompareTo(object obj); // 0x00000001800F0980-0x00000001800F09C0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(byte newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180235560-0x0000000180235590
		public static byte EncryptDecrypt(byte value); // 0x000000018187E7F0-0x000000018187E840
		[Obsolete] // 0x0000000180235560-0x0000000180235590
		public static byte EncryptDecrypt(byte[] value); // 0x000000018187E7A0-0x000000018187E7F0
		[Obsolete] // 0x0000000180235940-0x0000000180235970
		public static byte EncryptDecrypt(byte value, byte key); // 0x000000018187E740-0x000000018187E750
		[Obsolete] // 0x0000000180235940-0x0000000180235970
		public static void EncryptDecrypt(byte[] value, byte key); // 0x000000018187E750-0x000000018187E7A0
		[Obsolete] // 0x0000000180234D70-0x0000000180234DA0
		public static ObscuredByte FromEncrypted(byte encrypted); // 0x000000018187E840-0x000000018187E890
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public byte GetEncrypted(); // 0x00000001800F0C30-0x00000001800F0C40
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(byte encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
