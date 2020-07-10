/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Serialization;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredDouble : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredDouble>, IComparable<double>, IComparable // TypeDefIndex: 7182
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private long currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private long hiddenValue; // 0x08
		[FormerlySerializedAs] // 0x00000001800D7B70-0x00000001800D7BB0
		[SerializeField] // 0x00000001800D7B70-0x00000001800D7BB0
		private ACTkByte8 hiddenValueOldByte8; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private double fakeValue; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValueActive; // 0x28
	
		// Nested types
		private struct DoubleLongBytesUnion // TypeDefIndex: 7183
		{
			// Fields
			internal double d; // 0x00
			internal long l; // 0x00
			internal ACTkByte8 b8; // 0x00
	
			// Methods
			internal static long Migrate(long value, byte fromVersion, byte toVersion); // 0x0000000181BABF10-0x0000000181BABF60
			internal static long XorDoubleToLong(double value, long key); // 0x0000000181BABF60-0x0000000181BABFA0
			internal static double XorLongToDouble(long value, long key); // 0x0000000181BABFA0-0x0000000181BABFF0
			private static DoubleLongBytesUnion FromDouble(double value); // 0x00000001805ABC10-0x00000001805ABC20
			private static DoubleLongBytesUnion FromLong(long value); // 0x0000000180362190-0x00000001803621A0
			private DoubleLongBytesUnion Shuffle(long key); // 0x00000001802DB6B0-0x00000001802DB6E0
			private DoubleLongBytesUnion UnShuffle(long key); // 0x00000001802DB6E0-0x00000001802DB720
		}
	
		// Constructors
		private ObscuredDouble(double value); // 0x00000001802DCFA0-0x00000001802DD020
	
		// Methods
		public static long Encrypt(double value, long key); // 0x0000000181BABF60-0x0000000181BABFA0
		public static double Decrypt(long value, long key); // 0x0000000181BABFA0-0x0000000181BABFF0
		public static long MigrateEncrypted(long encrypted, byte fromVersion = 0 /* Metadata: 0x007412C0 */, byte toVersion = 2 /* Metadata: 0x007412C1 */); // 0x0000000181BABF10-0x0000000181BABF60
		public static ObscuredDouble FromEncrypted(long encrypted, long key); // 0x0000000181BAEA90-0x0000000181BAEB30
		public static long GenerateKey(); // 0x0000000181BAE0F0-0x0000000181BAE150
		public long GetEncrypted(out long key); // 0x00000001802DCD90-0x00000001802DCDA0
		public void SetEncrypted(long encrypted, long key); // 0x00000001802DCE60-0x00000001802DCEA0
		public double GetDecrypted(); // 0x00000001802DCD70-0x00000001802DCD80
		public void RandomizeCryptoKey(); // 0x00000001802DCDE0-0x00000001802DCE60
		private double InternalDecrypt(); // 0x00000001802DCDD0-0x00000001802DCDE0
		public static implicit operator ObscuredDouble(double value); // 0x0000000181BAEFD0-0x0000000181BAF000
		public static implicit operator double(ObscuredDouble value); // 0x0000000181BAEFC0-0x0000000181BAEFD0
		public static explicit operator ObscuredDouble(ObscuredFloat f); // 0x0000000181BAEEF0-0x0000000181BAEFC0
		public static ObscuredDouble operator ++(ObscuredDouble input); // 0x0000000181BAF000-0x0000000181BAF0C0
		public static ObscuredDouble operator --(ObscuredDouble input); // 0x0000000181BAEE30-0x0000000181BAEEF0
		private static ObscuredDouble Increment(ObscuredDouble input, double increment); // 0x0000000181BAEB30-0x0000000181BAEE30
		public override int GetHashCode(); // 0x00000001802DCDA0-0x00000001802DCDD0
		public override string ToString(); // 0x00000001802DCEA0-0x00000001802DCED0
		public string ToString(string format); // 0x00000001802DCF10-0x00000001802DCF50
		public string ToString(IFormatProvider provider); // 0x00000001802DCED0-0x00000001802DCF10
		public string ToString(string format, IFormatProvider provider); // 0x00000001802DCF50-0x00000001802DCFA0
		public override bool Equals(object obj); // 0x00000001802DCC40-0x00000001802DCD10
		public bool Equals(ObscuredDouble obj); // 0x00000001802DCD10-0x00000001802DCD70
		public int CompareTo(ObscuredDouble other); // 0x00000001802DCBE0-0x00000001802DCC40
		public int CompareTo(double other); // 0x00000001802DCBA0-0x00000001802DCBE0
		public int CompareTo(object obj); // 0x00000001802DCB60-0x00000001802DCBA0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(long newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D3EC0-0x00000001800D3EF0
		public static long Encrypt(double value); // 0x0000000181BAE9F0-0x0000000181BAEA40
		[Obsolete] // 0x00000001800D41F0-0x00000001800D4220
		public static double Decrypt(long value); // 0x0000000181BAE9A0-0x0000000181BAE9F0
		[Obsolete] // 0x00000001800D43F0-0x00000001800D4420
		public static ObscuredDouble FromEncrypted(long encrypted); // 0x0000000181BAEA40-0x0000000181BAEA90
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public long GetEncrypted(); // 0x00000001802DCD80-0x00000001802DCD90
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(long encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
