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
	public struct ObscuredUInt : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUInt>, IComparable<uint>, IComparable // TypeDefIndex: 7359
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private uint currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private uint hiddenValue; // 0x04
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x08
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private uint fakeValue; // 0x0C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValueActive; // 0x10
	
		// Constructors
		private ObscuredUInt(uint value); // 0x00000001800F2720-0x00000001800F27C0
	
		// Methods
		public static uint Encrypt(uint value, uint key); // 0x0000000181880EC0-0x0000000181880ED0
		public static uint Decrypt(uint value, uint key); // 0x0000000181880EC0-0x0000000181880ED0
		public static ObscuredUInt FromEncrypted(uint encrypted, uint key); // 0x0000000181884CE0-0x0000000181884D80
		public static uint GenerateKey(); // 0x0000000181880A70-0x0000000181880AD0
		public uint GetEncrypted(out uint key); // 0x00000001800F2010-0x00000001800F2020
		public void SetEncrypted(uint encrypted, uint key); // 0x00000001800F3D40-0x00000001800F3D80
		public uint GetDecrypted(); // 0x00000001800F3CA0-0x00000001800F3CB0
		public void RandomizeCryptoKey(); // 0x00000001800F3D00-0x00000001800F3D40
		private uint InternalDecrypt(); // 0x00000001800F3CF0-0x00000001800F3D00
		public static implicit operator ObscuredUInt(uint value); // 0x0000000181881610-0x0000000181881660
		public static implicit operator uint(ObscuredUInt value); // 0x0000000181885010-0x0000000181885020
		public static explicit operator ObscuredInt(ObscuredUInt value); // 0x0000000181884F90-0x0000000181885010
		public static ObscuredUInt operator ++(ObscuredUInt input); // 0x0000000181885020-0x0000000181885110
		public static ObscuredUInt operator --(ObscuredUInt input); // 0x0000000181884EA0-0x0000000181884F90
		private static ObscuredUInt Increment(ObscuredUInt input, int increment); // 0x0000000181884D80-0x0000000181884EA0
		public override int GetHashCode(); // 0x00000001800F3CC0-0x00000001800F3CF0
		public override string ToString(); // 0x00000001800F3DC0-0x00000001800F3DF0
		public string ToString(string format); // 0x00000001800F3D80-0x00000001800F3DC0
		public string ToString(IFormatProvider provider); // 0x00000001800F3DF0-0x00000001800F3E30
		public string ToString(string format, IFormatProvider provider); // 0x00000001800F3E30-0x00000001800F3E80
		public override bool Equals(object obj); // 0x00000001800F3BD0-0x00000001800F3CA0
		public bool Equals(ObscuredUInt obj); // 0x00000001800F2420-0x00000001800F2480
		public int CompareTo(ObscuredUInt other); // 0x00000001800F3A90-0x00000001800F3B50
		public int CompareTo(uint other); // 0x00000001800F3B50-0x00000001800F3B90
		public int CompareTo(object obj); // 0x00000001800F3B90-0x00000001800F3BD0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(uint newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180234A80-0x0000000180234AB0
		public static int Encrypt(uint value); // 0x0000000181884C40-0x0000000181884C90
		[Obsolete] // 0x0000000180234BB0-0x0000000180234BE0
		public static int Decrypt(uint value); // 0x0000000181884BF0-0x0000000181884C40
		[Obsolete] // 0x0000000180234D70-0x0000000180234DA0
		public static ObscuredUInt FromEncrypted(uint encrypted); // 0x0000000181884C90-0x0000000181884CE0
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public uint GetEncrypted(); // 0x00000001800F3CB0-0x00000001800F3CC0
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(uint encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
