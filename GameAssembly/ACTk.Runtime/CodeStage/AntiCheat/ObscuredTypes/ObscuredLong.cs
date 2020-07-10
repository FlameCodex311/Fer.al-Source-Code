/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredLong : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredLong>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredLong>, IComparable<long>, IComparable // TypeDefIndex: 7187
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private long currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private long hiddenValue; // 0x08
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private long fakeValue; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValueActive; // 0x20
	
		// Constructors
		private ObscuredLong(long value); // 0x00000001802DDE80-0x00000001802DDF30
	
		// Methods
		public static long Encrypt(long value, long key); // 0x0000000181BAFEE0-0x0000000181BAFEF0
		public static long Decrypt(long value, long key); // 0x0000000181BAFEE0-0x0000000181BAFEF0
		public static ObscuredLong FromEncrypted(long encrypted, long key); // 0x0000000181BB0140-0x0000000181BB0210
		public static long GenerateKey(); // 0x0000000181BAE0F0-0x0000000181BAE150
		public long GetEncrypted(out long key); // 0x00000001802DCD90-0x00000001802DCDA0
		public void SetEncrypted(long encrypted, long key); // 0x00000001802DDD40-0x00000001802DDD80
		public long GetDecrypted(); // 0x00000001802DDCA0-0x00000001802DDCB0
		public void RandomizeCryptoKey(); // 0x00000001802DDD00-0x00000001802DDD40
		private long InternalDecrypt(); // 0x00000001802DDCF0-0x00000001802DDD00
		public static implicit operator ObscuredLong(long value); // 0x0000000181BB04A0-0x0000000181BB0500
		public static implicit operator long(ObscuredLong value); // 0x0000000181BB0490-0x0000000181BB04A0
		public static ObscuredLong operator ++(ObscuredLong input); // 0x0000000181BB0500-0x0000000181BB0650
		public static ObscuredLong operator --(ObscuredLong input); // 0x0000000181BB0340-0x0000000181BB0490
		private static ObscuredLong Increment(ObscuredLong input, int increment); // 0x0000000181BB0210-0x0000000181BB0340
		public override int GetHashCode(); // 0x00000001802DDCC0-0x00000001802DDCF0
		public override string ToString(); // 0x00000001802DDD80-0x00000001802DDDB0
		public string ToString(string format); // 0x00000001802DDDF0-0x00000001802DDE30
		public string ToString(IFormatProvider provider); // 0x00000001802DDDB0-0x00000001802DDDF0
		public string ToString(string format, IFormatProvider provider); // 0x00000001802DDE30-0x00000001802DDE80
		public override bool Equals(object obj); // 0x00000001802DDB40-0x00000001802DDC30
		public bool Equals(ObscuredLong obj); // 0x00000001802DDC30-0x00000001802DDCA0
		public int CompareTo(ObscuredLong other); // 0x00000001802DDA30-0x00000001802DDB00
		public int CompareTo(long other); // 0x00000001802DDB00-0x00000001802DDB40
		public int CompareTo(object obj); // 0x00000001802DD9F0-0x00000001802DDA30
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(long newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D3EC0-0x00000001800D3EF0
		public static long Encrypt(long value); // 0x0000000181BAFF40-0x0000000181BB00F0
		[Obsolete] // 0x00000001800D41F0-0x00000001800D4220
		public static long Decrypt(long value); // 0x0000000181BAFEF0-0x0000000181BAFF40
		[Obsolete] // 0x00000001800D43F0-0x00000001800D4420
		public static ObscuredLong FromEncrypted(long encrypted); // 0x0000000181BB00F0-0x0000000181BB0140
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public long GetEncrypted(); // 0x00000001802DDCB0-0x00000001802DDCC0
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(long encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
