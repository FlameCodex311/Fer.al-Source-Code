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
	public struct ObscuredUInt : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt>, IComparable<uint>, IComparable // TypeDefIndex: 7193
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private uint currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private uint hiddenValue; // 0x04
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x08
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private uint fakeValue; // 0x0C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValueActive; // 0x10
	
		// Constructors
		private ObscuredUInt(uint value); // 0x00000001802DD950-0x00000001802DD9F0
	
		// Methods
		public static uint Encrypt(uint value, uint key); // 0x0000000181BAF650-0x0000000181BAF660
		public static uint Decrypt(uint value, uint key); // 0x0000000181BAF650-0x0000000181BAF660
		public static ObscuredUInt FromEncrypted(uint encrypted, uint key); // 0x0000000181BB34E0-0x0000000181BB3580
		public static uint GenerateKey(); // 0x0000000181BAF200-0x0000000181BAF260
		public uint GetEncrypted(out uint key); // 0x00000001802DD240-0x00000001802DD250
		public void SetEncrypted(uint encrypted, uint key); // 0x00000001802DEF70-0x00000001802DEFB0
		public uint GetDecrypted(); // 0x00000001802DEED0-0x00000001802DEEE0
		public void RandomizeCryptoKey(); // 0x00000001802DEF30-0x00000001802DEF70
		private uint InternalDecrypt(); // 0x00000001802DEF20-0x00000001802DEF30
		public static implicit operator ObscuredUInt(uint value); // 0x0000000181BAFDA0-0x0000000181BAFDF0
		public static implicit operator uint(ObscuredUInt value); // 0x0000000181BB3810-0x0000000181BB3820
		public static explicit operator ObscuredInt(ObscuredUInt value); // 0x0000000181BB3790-0x0000000181BB3810
		public static ObscuredUInt operator ++(ObscuredUInt input); // 0x0000000181BB3820-0x0000000181BB3910
		public static ObscuredUInt operator --(ObscuredUInt input); // 0x0000000181BB36A0-0x0000000181BB3790
		private static ObscuredUInt Increment(ObscuredUInt input, int increment); // 0x0000000181BB3580-0x0000000181BB36A0
		public override int GetHashCode(); // 0x00000001802DEEF0-0x00000001802DEF20
		public override string ToString(); // 0x00000001802DEFF0-0x00000001802DF020
		public string ToString(string format); // 0x00000001802DEFB0-0x00000001802DEFF0
		public string ToString(IFormatProvider provider); // 0x00000001802DF020-0x00000001802DF060
		public string ToString(string format, IFormatProvider provider); // 0x00000001802DF060-0x00000001802DF0B0
		public override bool Equals(object obj); // 0x00000001802DEE00-0x00000001802DEED0
		public bool Equals(ObscuredUInt obj); // 0x00000001802DD650-0x00000001802DD6B0
		public int CompareTo(ObscuredUInt other); // 0x00000001802DECC0-0x00000001802DED80
		public int CompareTo(uint other); // 0x00000001802DED80-0x00000001802DEDC0
		public int CompareTo(object obj); // 0x00000001802DEDC0-0x00000001802DEE00
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(uint newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D3EC0-0x00000001800D3EF0
		public static int Encrypt(uint value); // 0x0000000181BB3440-0x0000000181BB3490
		[Obsolete] // 0x00000001800D41F0-0x00000001800D4220
		public static int Decrypt(uint value); // 0x0000000181BB33F0-0x0000000181BB3440
		[Obsolete] // 0x00000001800D43F0-0x00000001800D4420
		public static ObscuredUInt FromEncrypted(uint encrypted); // 0x0000000181BB3490-0x0000000181BB34E0
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public uint GetEncrypted(); // 0x00000001802DEEE0-0x00000001802DEEF0
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(uint encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
