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
	public struct ObscuredULong : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredULong>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredULong>, IComparable<ulong>, IComparable // TypeDefIndex: 7194
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ulong currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ulong hiddenValue; // 0x08
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ulong fakeValue; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValueActive; // 0x20
	
		// Constructors
		private ObscuredULong(ulong value); // 0x00000001802DDE80-0x00000001802DDF30
	
		// Methods
		public static ulong Encrypt(ulong value, ulong key); // 0x0000000181BAFEE0-0x0000000181BAFEF0
		public static ulong Decrypt(ulong value, ulong key); // 0x0000000181BAFEE0-0x0000000181BAFEF0
		public static ObscuredULong FromEncrypted(ulong encrypted, ulong key); // 0x0000000181BB39B0-0x0000000181BB3A00
		public static ulong GenerateKey(); // 0x0000000181BAE0F0-0x0000000181BAE150
		public ulong GetEncrypted(out ulong key); // 0x00000001802DCD90-0x00000001802DCDA0
		public void SetEncrypted(ulong encrypted, ulong key); // 0x00000001802DF390-0x00000001802DF3D0
		public ulong GetDecrypted(); // 0x00000001802DF2F0-0x00000001802DF300
		public void RandomizeCryptoKey(); // 0x00000001802DF350-0x00000001802DF390
		private ulong InternalDecrypt(); // 0x00000001802DF340-0x00000001802DF350
		public static implicit operator ObscuredULong(ulong value); // 0x0000000181BB04A0-0x0000000181BB0500
		public static implicit operator ulong(ObscuredULong value); // 0x0000000181BB3C70-0x0000000181BB3C80
		public static ObscuredULong operator ++(ObscuredULong input); // 0x0000000181BB3C80-0x0000000181BB3D10
		public static ObscuredULong operator --(ObscuredULong input); // 0x0000000181BB3BE0-0x0000000181BB3C70
		private static ObscuredULong Increment(ObscuredULong input, int increment); // 0x0000000181BB3AA0-0x0000000181BB3BE0
		public override int GetHashCode(); // 0x00000001802DF310-0x00000001802DF340
		public override string ToString(); // 0x00000001802DF4A0-0x00000001802DF4D0
		public string ToString(string format); // 0x00000001802DF420-0x00000001802DF460
		public string ToString(IFormatProvider provider); // 0x00000001802DF460-0x00000001802DF4A0
		public string ToString(string format, IFormatProvider provider); // 0x00000001802DF3D0-0x00000001802DF420
		public override bool Equals(object obj); // 0x00000001802DF200-0x00000001802DF2F0
		public bool Equals(ObscuredULong obj); // 0x00000001802DDC30-0x00000001802DDCA0
		public int CompareTo(ObscuredULong other); // 0x00000001802DF0F0-0x00000001802DF1C0
		public int CompareTo(ulong other); // 0x00000001802DF1C0-0x00000001802DF200
		public int CompareTo(object obj); // 0x00000001802DF0B0-0x00000001802DF0F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(ulong newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D3EC0-0x00000001800D3EF0
		public static ulong Encrypt(ulong value); // 0x0000000181BB3960-0x0000000181BB39B0
		[Obsolete] // 0x00000001800D41F0-0x00000001800D4220
		public static ulong Decrypt(ulong value); // 0x0000000181BB3910-0x0000000181BB3960
		[Obsolete] // 0x00000001800D43F0-0x00000001800D4420
		public static ObscuredULong FromEncrypted(ulong encrypted); // 0x0000000181BB3A00-0x0000000181BB3AA0
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public ulong GetEncrypted(); // 0x00000001802DF300-0x00000001802DF310
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(ulong encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
