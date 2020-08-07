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
	public struct ObscuredULong : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredULong>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredULong>, IComparable<ulong>, IComparable // TypeDefIndex: 7360
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ulong currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ulong hiddenValue; // 0x08
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ulong fakeValue; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValueActive; // 0x20
	
		// Constructors
		private ObscuredULong(ulong value); // 0x00000001800F2C50-0x00000001800F2D00
	
		// Methods
		public static ulong Encrypt(ulong value, ulong key); // 0x0000000181881750-0x0000000181881760
		public static ulong Decrypt(ulong value, ulong key); // 0x0000000181881750-0x0000000181881760
		public static ObscuredULong FromEncrypted(ulong encrypted, ulong key); // 0x00000001818851B0-0x0000000181885200
		public static ulong GenerateKey(); // 0x000000018187F960-0x000000018187F9C0
		public ulong GetEncrypted(out ulong key); // 0x00000001800F1B60-0x00000001800F1B70
		public void SetEncrypted(ulong encrypted, ulong key); // 0x00000001800F4160-0x00000001800F41A0
		public ulong GetDecrypted(); // 0x00000001800F40C0-0x00000001800F40D0
		public void RandomizeCryptoKey(); // 0x00000001800F4120-0x00000001800F4160
		private ulong InternalDecrypt(); // 0x00000001800F4110-0x00000001800F4120
		public static implicit operator ObscuredULong(ulong value); // 0x0000000181881D10-0x0000000181881D70
		public static implicit operator ulong(ObscuredULong value); // 0x0000000181885470-0x0000000181885480
		public static ObscuredULong operator ++(ObscuredULong input); // 0x0000000181885480-0x0000000181885510
		public static ObscuredULong operator --(ObscuredULong input); // 0x00000001818853E0-0x0000000181885470
		private static ObscuredULong Increment(ObscuredULong input, int increment); // 0x00000001818852A0-0x00000001818853E0
		public override int GetHashCode(); // 0x00000001800F40E0-0x00000001800F4110
		public override string ToString(); // 0x00000001800F4270-0x00000001800F42A0
		public string ToString(string format); // 0x00000001800F41F0-0x00000001800F4230
		public string ToString(IFormatProvider provider); // 0x00000001800F4230-0x00000001800F4270
		public string ToString(string format, IFormatProvider provider); // 0x00000001800F41A0-0x00000001800F41F0
		public override bool Equals(object obj); // 0x00000001800F3FD0-0x00000001800F40C0
		public bool Equals(ObscuredULong obj); // 0x00000001800F2A00-0x00000001800F2A70
		public int CompareTo(ObscuredULong other); // 0x00000001800F3EC0-0x00000001800F3F90
		public int CompareTo(ulong other); // 0x00000001800F3F90-0x00000001800F3FD0
		public int CompareTo(object obj); // 0x00000001800F3E80-0x00000001800F3EC0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(ulong newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180234A80-0x0000000180234AB0
		public static ulong Encrypt(ulong value); // 0x0000000181885160-0x00000001818851B0
		[Obsolete] // 0x0000000180234BB0-0x0000000180234BE0
		public static ulong Decrypt(ulong value); // 0x0000000181885110-0x0000000181885160
		[Obsolete] // 0x0000000180234D70-0x0000000180234DA0
		public static ObscuredULong FromEncrypted(ulong encrypted); // 0x0000000181885200-0x00000001818852A0
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public ulong GetEncrypted(); // 0x00000001800F40D0-0x00000001800F40E0
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(ulong encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
