/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDecimal : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDecimal>, IComparable<decimal>, IComparable // TypeDefIndex: 7346
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private long currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ACTkByte16 hiddenValue; // 0x08
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x18
		private decimal fakeValue; // 0x1C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValueActive; // 0x2C
	
		// Nested types
		private struct DecimalLongBytesUnion // TypeDefIndex: 7347
		{
			// Fields
			private decimal d; // 0x00
			private long l1; // 0x00
			private long l2; // 0x08
			private ACTkByte16 b16; // 0x00
	
			// Methods
			internal static decimal XorDecimalToDecimal(decimal value, long key); // 0x000000018187D7E0-0x000000018187D810
			internal static ACTkByte16 XorDecimalToB16(decimal value, long key); // 0x000000018187D7E0-0x000000018187D810
			internal static decimal XorB16ToDecimal(ACTkByte16 value, long key); // 0x000000018187D7E0-0x000000018187D810
			internal static decimal ConvertB16ToDecimal(ACTkByte16 value); // 0x00000001810D35D0-0x00000001810D35E0
			internal static ACTkByte16 ConvertDecimalToB16(decimal value); // 0x00000001810D35D0-0x00000001810D35E0
			private static DecimalLongBytesUnion FromDecimal(decimal value); // 0x00000001810D35D0-0x00000001810D35E0
			private static DecimalLongBytesUnion FromB16(ACTkByte16 value); // 0x00000001810D35D0-0x00000001810D35E0
			private DecimalLongBytesUnion XorLongs(long key); // 0x00000001800F03C0-0x00000001800F0480
		}
	
		// Constructors
		private ObscuredDecimal(decimal value); // 0x00000001800F18B0-0x00000001800F1930
	
		// Methods
		public static decimal Encrypt(decimal value, long key); // 0x000000018187D7E0-0x000000018187D810
		public static decimal Decrypt(decimal value, long key); // 0x000000018187D7E0-0x000000018187D810
		public static ObscuredDecimal FromEncrypted(decimal encrypted, long key); // 0x000000018187F8B0-0x000000018187F910
		public static long GenerateKey(); // 0x000000018187F960-0x000000018187F9C0
		public decimal GetEncrypted(out long key); // 0x00000001800F1650-0x00000001800F1670
		public void SetEncrypted(decimal encrypted, long key); // 0x00000001800F1750-0x00000001800F17A0
		public decimal GetDecrypted(); // 0x00000001800F1620-0x00000001800F1650
		public void RandomizeCryptoKey(); // 0x00000001800F16F0-0x00000001800F1750
		private static ACTkByte16 InternalEncrypt(decimal value, long key); // 0x000000018187D7E0-0x000000018187D810
		private decimal InternalDecrypt(); // 0x00000001800F16D0-0x00000001800F16F0
		public static implicit operator ObscuredDecimal(decimal value); // 0x0000000181880020-0x0000000181880060
		public static implicit operator decimal(ObscuredDecimal value); // 0x0000000181880060-0x0000000181880090
		public static explicit operator ObscuredDecimal(ObscuredFloat f); // 0x000000018187FEB0-0x0000000181880020
		public static ObscuredDecimal operator ++(ObscuredDecimal input); // 0x0000000181880090-0x0000000181880210
		public static ObscuredDecimal operator --(ObscuredDecimal input); // 0x000000018187FD30-0x000000018187FEB0
		private static ObscuredDecimal Increment(ObscuredDecimal input, decimal increment); // 0x000000018187F9C0-0x000000018187FD30
		public override int GetHashCode(); // 0x00000001800F1690-0x00000001800F16D0
		public override string ToString(); // 0x00000001800F17F0-0x00000001800F1830
		public string ToString(string format); // 0x00000001800F1870-0x00000001800F18B0
		public string ToString(IFormatProvider provider); // 0x00000001800F1830-0x00000001800F1870
		public string ToString(string format, IFormatProvider provider); // 0x00000001800F17A0-0x00000001800F17F0
		public override bool Equals(object obj); // 0x00000001800F14A0-0x00000001800F15A0
		public bool Equals(ObscuredDecimal obj); // 0x00000001800F15A0-0x00000001800F1620
		public int CompareTo(ObscuredDecimal other); // 0x00000001800F1390-0x00000001800F1410
		public int CompareTo(decimal other); // 0x00000001800F1450-0x00000001800F14A0
		public int CompareTo(object obj); // 0x00000001800F1410-0x00000001800F1450
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(long newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180234A80-0x0000000180234AB0
		public static decimal Encrypt(decimal value); // 0x000000018187F860-0x000000018187F8B0
		[Obsolete] // 0x0000000180234BB0-0x0000000180234BE0
		public static decimal Decrypt(decimal value); // 0x000000018187F810-0x000000018187F860
		[Obsolete] // 0x0000000180234D70-0x0000000180234DA0
		public static ObscuredDecimal FromEncrypted(decimal encrypted); // 0x000000018187F910-0x000000018187F960
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public decimal GetEncrypted(); // 0x00000001800F1670-0x00000001800F1690
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(decimal encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
