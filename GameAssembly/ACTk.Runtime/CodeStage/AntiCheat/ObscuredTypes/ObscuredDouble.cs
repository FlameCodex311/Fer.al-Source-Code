/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Serialization;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDouble : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble>, IComparable<double>, IComparable // TypeDefIndex: 7348
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private long currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private long hiddenValue; // 0x08
		[FormerlySerializedAs] // 0x0000000180238F50-0x0000000180238F90
		[SerializeField] // 0x0000000180238F50-0x0000000180238F90
		private ACTkByte8 hiddenValueOldByte8; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private double fakeValue; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValueActive; // 0x28
	
		// Nested types
		private struct DoubleLongBytesUnion // TypeDefIndex: 7349
		{
			// Fields
			internal double d; // 0x00
			internal long l; // 0x00
			internal ACTkByte8 b8; // 0x00
	
			// Methods
			internal static long Migrate(long value, byte fromVersion, byte toVersion); // 0x000000018187D810-0x000000018187D860
			internal static long XorDoubleToLong(double value, long key); // 0x000000018187D860-0x000000018187D8A0
			internal static double XorLongToDouble(long value, long key); // 0x000000018187D8A0-0x000000018187D8F0
			private static DoubleLongBytesUnion FromDouble(double value); // 0x0000000180C96020-0x0000000180C96030
			private static DoubleLongBytesUnion FromLong(long value); // 0x0000000180411160-0x0000000180411170
			private DoubleLongBytesUnion Shuffle(long key); // 0x00000001800F0480-0x00000001800F04B0
			private DoubleLongBytesUnion UnShuffle(long key); // 0x00000001800F04B0-0x00000001800F04F0
		}
	
		// Constructors
		private ObscuredDouble(double value); // 0x00000001800F1D70-0x00000001800F1DF0
	
		// Methods
		public static long Encrypt(double value, long key); // 0x000000018187D860-0x000000018187D8A0
		public static double Decrypt(long value, long key); // 0x000000018187D8A0-0x000000018187D8F0
		public static long MigrateEncrypted(long encrypted, byte fromVersion = 0 /* Metadata: 0x00775FAE */, byte toVersion = 2 /* Metadata: 0x00775FAF */); // 0x000000018187D810-0x000000018187D860
		public static ObscuredDouble FromEncrypted(long encrypted, long key); // 0x0000000181880300-0x00000001818803A0
		public static long GenerateKey(); // 0x000000018187F960-0x000000018187F9C0
		public long GetEncrypted(out long key); // 0x00000001800F1B60-0x00000001800F1B70
		public void SetEncrypted(long encrypted, long key); // 0x00000001800F1C30-0x00000001800F1C70
		public double GetDecrypted(); // 0x00000001800F1B40-0x00000001800F1B50
		public void RandomizeCryptoKey(); // 0x00000001800F1BB0-0x00000001800F1C30
		private double InternalDecrypt(); // 0x00000001800F1BA0-0x00000001800F1BB0
		public static implicit operator ObscuredDouble(double value); // 0x0000000181880840-0x0000000181880870
		public static implicit operator double(ObscuredDouble value); // 0x0000000181880830-0x0000000181880840
		public static explicit operator ObscuredDouble(ObscuredFloat f); // 0x0000000181880760-0x0000000181880830
		public static ObscuredDouble operator ++(ObscuredDouble input); // 0x0000000181880870-0x0000000181880930
		public static ObscuredDouble operator --(ObscuredDouble input); // 0x00000001818806A0-0x0000000181880760
		private static ObscuredDouble Increment(ObscuredDouble input, double increment); // 0x00000001818803A0-0x00000001818806A0
		public override int GetHashCode(); // 0x00000001800F1B70-0x00000001800F1BA0
		public override string ToString(); // 0x00000001800F1C70-0x00000001800F1CA0
		public string ToString(string format); // 0x00000001800F1CE0-0x00000001800F1D20
		public string ToString(IFormatProvider provider); // 0x00000001800F1CA0-0x00000001800F1CE0
		public string ToString(string format, IFormatProvider provider); // 0x00000001800F1D20-0x00000001800F1D70
		public override bool Equals(object obj); // 0x00000001800F1A10-0x00000001800F1AE0
		public bool Equals(ObscuredDouble obj); // 0x00000001800F1AE0-0x00000001800F1B40
		public int CompareTo(ObscuredDouble other); // 0x00000001800F19B0-0x00000001800F1A10
		public int CompareTo(double other); // 0x00000001800F1970-0x00000001800F19B0
		public int CompareTo(object obj); // 0x00000001800F1930-0x00000001800F1970
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(long newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180234A80-0x0000000180234AB0
		public static long Encrypt(double value); // 0x0000000181880260-0x00000001818802B0
		[Obsolete] // 0x0000000180234BB0-0x0000000180234BE0
		public static double Decrypt(long value); // 0x0000000181880210-0x0000000181880260
		[Obsolete] // 0x0000000180234D70-0x0000000180234DA0
		public static ObscuredDouble FromEncrypted(long encrypted); // 0x00000001818802B0-0x0000000181880300
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public long GetEncrypted(); // 0x00000001800F1B50-0x00000001800F1B60
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(long encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
