/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredSByte : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredSByte>, IComparable<sbyte>, IComparable // TypeDefIndex: 7356
	{
		// Fields
		private sbyte currentCryptoKey; // 0x00
		private sbyte hiddenValue; // 0x01
		private bool inited; // 0x02
		private sbyte fakeValue; // 0x03
		private bool fakeValueActive; // 0x04
	
		// Constructors
		private ObscuredSByte(sbyte value); // 0x00000001800F3560-0x00000001800F35B0
	
		// Methods
		public static sbyte Encrypt(sbyte value, sbyte key); // 0x000000018187E740-0x000000018187E750
		public static sbyte Decrypt(sbyte value, sbyte key); // 0x000000018187E740-0x000000018187E750
		public static ObscuredSByte FromEncrypted(sbyte encrypted, sbyte key); // 0x0000000181882AA0-0x0000000181882AF0
		public static sbyte GenerateKey(); // 0x0000000181882AF0-0x0000000181882B50
		public sbyte GetEncrypted(out sbyte key); // 0x00000001800F0C20-0x00000001800F0C30
		public void SetEncrypted(sbyte encrypted, sbyte key); // 0x00000001800F3420-0x00000001800F3460
		public sbyte GetDecrypted(); // 0x00000001800F3380-0x00000001800F3390
		public void RandomizeCryptoKey(); // 0x00000001800F33E0-0x00000001800F3420
		private sbyte InternalDecrypt(); // 0x00000001800F33D0-0x00000001800F33E0
		public static implicit operator ObscuredSByte(sbyte value); // 0x0000000181882D60-0x0000000181882DB0
		public static implicit operator sbyte(ObscuredSByte value); // 0x0000000181882DB0-0x0000000181882DC0
		public static ObscuredSByte operator ++(ObscuredSByte input); // 0x0000000181882DC0-0x0000000181882EB0
		public static ObscuredSByte operator --(ObscuredSByte input); // 0x0000000181882C70-0x0000000181882D60
		private static ObscuredSByte Increment(ObscuredSByte input, int increment); // 0x0000000181882B50-0x0000000181882C70
		public override int GetHashCode(); // 0x00000001800F33A0-0x00000001800F33D0
		public override string ToString(); // 0x00000001800F3530-0x00000001800F3560
		public string ToString(string format); // 0x00000001800F3460-0x00000001800F34A0
		public string ToString(IFormatProvider provider); // 0x00000001800F34A0-0x00000001800F34E0
		public string ToString(string format, IFormatProvider provider); // 0x00000001800F34E0-0x00000001800F3530
		public override bool Equals(object obj); // 0x00000001800F32A0-0x00000001800F3380
		public bool Equals(ObscuredSByte obj); // 0x00000001800F0AC0-0x00000001800F0B30
		public int CompareTo(ObscuredSByte other); // 0x00000001800F31A0-0x00000001800F3260
		public int CompareTo(sbyte other); // 0x00000001800F3160-0x00000001800F31A0
		public int CompareTo(object obj); // 0x00000001800F3260-0x00000001800F32A0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(sbyte newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180235560-0x0000000180235590
		public static sbyte EncryptDecrypt(sbyte value); // 0x0000000181882A00-0x0000000181882A50
		[Obsolete] // 0x0000000180235940-0x0000000180235970
		public static sbyte EncryptDecrypt(sbyte value, sbyte key); // 0x000000018187E740-0x000000018187E750
		[Obsolete] // 0x0000000180234D70-0x0000000180234DA0
		public static ObscuredSByte FromEncrypted(sbyte encrypted); // 0x0000000181882A50-0x0000000181882AA0
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public sbyte GetEncrypted(); // 0x00000001800F3390-0x00000001800F33A0
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(sbyte encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
