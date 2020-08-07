/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredLong : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredLong>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredLong>, IComparable<long>, IComparable // TypeDefIndex: 7353
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private long currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private long hiddenValue; // 0x08
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private long fakeValue; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValueActive; // 0x20
	
		// Constructors
		private ObscuredLong(long value); // 0x00000001800F2C50-0x00000001800F2D00
	
		// Methods
		public static long Encrypt(long value, long key); // 0x0000000181881750-0x0000000181881760
		public static long Decrypt(long value, long key); // 0x0000000181881750-0x0000000181881760
		public static ObscuredLong FromEncrypted(long encrypted, long key); // 0x00000001818819B0-0x0000000181881A80
		public static long GenerateKey(); // 0x000000018187F960-0x000000018187F9C0
		public long GetEncrypted(out long key); // 0x00000001800F1B60-0x00000001800F1B70
		public void SetEncrypted(long encrypted, long key); // 0x00000001800F2B10-0x00000001800F2B50
		public long GetDecrypted(); // 0x00000001800F2A70-0x00000001800F2A80
		public void RandomizeCryptoKey(); // 0x00000001800F2AD0-0x00000001800F2B10
		private long InternalDecrypt(); // 0x00000001800F2AC0-0x00000001800F2AD0
		public static implicit operator ObscuredLong(long value); // 0x0000000181881D10-0x0000000181881D70
		public static implicit operator long(ObscuredLong value); // 0x0000000181881D00-0x0000000181881D10
		public static ObscuredLong operator ++(ObscuredLong input); // 0x0000000181881D70-0x0000000181881EC0
		public static ObscuredLong operator --(ObscuredLong input); // 0x0000000181881BB0-0x0000000181881D00
		private static ObscuredLong Increment(ObscuredLong input, int increment); // 0x0000000181881A80-0x0000000181881BB0
		public override int GetHashCode(); // 0x00000001800F2A90-0x00000001800F2AC0
		public override string ToString(); // 0x00000001800F2B50-0x00000001800F2B80
		public string ToString(string format); // 0x00000001800F2BC0-0x00000001800F2C00
		public string ToString(IFormatProvider provider); // 0x00000001800F2B80-0x00000001800F2BC0
		public string ToString(string format, IFormatProvider provider); // 0x00000001800F2C00-0x00000001800F2C50
		public override bool Equals(object obj); // 0x00000001800F2910-0x00000001800F2A00
		public bool Equals(ObscuredLong obj); // 0x00000001800F2A00-0x00000001800F2A70
		public int CompareTo(ObscuredLong other); // 0x00000001800F2800-0x00000001800F28D0
		public int CompareTo(long other); // 0x00000001800F28D0-0x00000001800F2910
		public int CompareTo(object obj); // 0x00000001800F27C0-0x00000001800F2800
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(long newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180234A80-0x0000000180234AB0
		public static long Encrypt(long value); // 0x00000001818817B0-0x0000000181881960
		[Obsolete] // 0x0000000180234BB0-0x0000000180234BE0
		public static long Decrypt(long value); // 0x0000000181881760-0x00000001818817B0
		[Obsolete] // 0x0000000180234D70-0x0000000180234DA0
		public static ObscuredLong FromEncrypted(long encrypted); // 0x0000000181881960-0x00000001818819B0
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public long GetEncrypted(); // 0x00000001800F2A80-0x00000001800F2A90
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(long encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
