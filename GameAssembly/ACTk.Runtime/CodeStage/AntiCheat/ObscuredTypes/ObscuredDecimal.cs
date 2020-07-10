/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDecimal : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal>, IComparable<decimal>, IComparable // TypeDefIndex: 7180
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private long currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ACTkByte16 hiddenValue; // 0x08
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x18
		private decimal fakeValue; // 0x1C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValueActive; // 0x2C
	
		// Nested types
		private struct DecimalLongBytesUnion // TypeDefIndex: 7181
		{
			// Fields
			private decimal d; // 0x00
			private long l1; // 0x00
			private long l2; // 0x08
			private ACTkByte16 b16; // 0x00
	
			// Methods
			internal static decimal XorDecimalToDecimal(decimal value, long key); // 0x0000000181BABEE0-0x0000000181BABF10
			internal static ACTkByte16 XorDecimalToB16(decimal value, long key); // 0x0000000181BABEE0-0x0000000181BABF10
			internal static decimal XorB16ToDecimal(ACTkByte16 value, long key); // 0x0000000181BABEE0-0x0000000181BABF10
			internal static decimal ConvertB16ToDecimal(ACTkByte16 value); // 0x00000001807FD2A0-0x00000001807FD2B0
			internal static ACTkByte16 ConvertDecimalToB16(decimal value); // 0x00000001807FD2A0-0x00000001807FD2B0
			private static DecimalLongBytesUnion FromDecimal(decimal value); // 0x00000001807FD2A0-0x00000001807FD2B0
			private static DecimalLongBytesUnion FromB16(ACTkByte16 value); // 0x00000001807FD2A0-0x00000001807FD2B0
			private DecimalLongBytesUnion XorLongs(long key); // 0x00000001802DB5F0-0x00000001802DB6B0
		}
	
		// Constructors
		private ObscuredDecimal(decimal value); // 0x00000001802DCAE0-0x00000001802DCB60
	
		// Methods
		public static decimal Encrypt(decimal value, long key); // 0x0000000181BABEE0-0x0000000181BABF10
		public static decimal Decrypt(decimal value, long key); // 0x0000000181BABEE0-0x0000000181BABF10
		public static ObscuredDecimal FromEncrypted(decimal encrypted, long key); // 0x0000000181BAE040-0x0000000181BAE0A0
		public static long GenerateKey(); // 0x0000000181BAE0F0-0x0000000181BAE150
		public decimal GetEncrypted(out long key); // 0x00000001802DC880-0x00000001802DC8A0
		public void SetEncrypted(decimal encrypted, long key); // 0x00000001802DC980-0x00000001802DC9D0
		public decimal GetDecrypted(); // 0x00000001802DC850-0x00000001802DC880
		public void RandomizeCryptoKey(); // 0x00000001802DC920-0x00000001802DC980
		private static ACTkByte16 InternalEncrypt(decimal value, long key); // 0x0000000181BABEE0-0x0000000181BABF10
		private decimal InternalDecrypt(); // 0x00000001802DC900-0x00000001802DC920
		public static implicit operator ObscuredDecimal(decimal value); // 0x0000000181BAE7B0-0x0000000181BAE7F0
		public static implicit operator decimal(ObscuredDecimal value); // 0x0000000181BAE7F0-0x0000000181BAE820
		public static explicit operator ObscuredDecimal(ObscuredFloat f); // 0x0000000181BAE640-0x0000000181BAE7B0
		public static ObscuredDecimal operator ++(ObscuredDecimal input); // 0x0000000181BAE820-0x0000000181BAE9A0
		public static ObscuredDecimal operator --(ObscuredDecimal input); // 0x0000000181BAE4C0-0x0000000181BAE640
		private static ObscuredDecimal Increment(ObscuredDecimal input, decimal increment); // 0x0000000181BAE150-0x0000000181BAE4C0
		public override int GetHashCode(); // 0x00000001802DC8C0-0x00000001802DC900
		public override string ToString(); // 0x00000001802DCA20-0x00000001802DCA60
		public string ToString(string format); // 0x00000001802DCAA0-0x00000001802DCAE0
		public string ToString(IFormatProvider provider); // 0x00000001802DCA60-0x00000001802DCAA0
		public string ToString(string format, IFormatProvider provider); // 0x00000001802DC9D0-0x00000001802DCA20
		public override bool Equals(object obj); // 0x00000001802DC6D0-0x00000001802DC7D0
		public bool Equals(ObscuredDecimal obj); // 0x00000001802DC7D0-0x00000001802DC850
		public int CompareTo(ObscuredDecimal other); // 0x00000001802DC5C0-0x00000001802DC640
		public int CompareTo(decimal other); // 0x00000001802DC680-0x00000001802DC6D0
		public int CompareTo(object obj); // 0x00000001802DC640-0x00000001802DC680
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(long newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D3EC0-0x00000001800D3EF0
		public static decimal Encrypt(decimal value); // 0x0000000181BADFF0-0x0000000181BAE040
		[Obsolete] // 0x00000001800D41F0-0x00000001800D4220
		public static decimal Decrypt(decimal value); // 0x0000000181BADFA0-0x0000000181BADFF0
		[Obsolete] // 0x00000001800D43F0-0x00000001800D4420
		public static ObscuredDecimal FromEncrypted(decimal encrypted); // 0x0000000181BAE0A0-0x0000000181BAE0F0
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public decimal GetEncrypted(); // 0x00000001802DC8A0-0x00000001802DC8C0
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(decimal encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
