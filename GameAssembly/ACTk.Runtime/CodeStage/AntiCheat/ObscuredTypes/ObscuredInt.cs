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
	public struct ObscuredInt : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>, IComparable<int>, IComparable // TypeDefIndex: 7352
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int hiddenValue; // 0x04
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x08
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int fakeValue; // 0x0C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValueActive; // 0x10
	
		// Constructors
		private ObscuredInt(int value); // 0x00000001800F2720-0x00000001800F27C0
	
		// Methods
		public static int Encrypt(int value, int key); // 0x0000000181880EC0-0x0000000181880ED0
		public static int Decrypt(int value, int key); // 0x0000000181880EC0-0x0000000181880ED0
		public static ObscuredInt FromEncrypted(int encrypted, int key); // 0x00000001818810A0-0x00000001818810F0
		public static int GenerateKey(); // 0x0000000181880A70-0x0000000181880AD0
		public int GetEncrypted(out int key); // 0x00000001800F2010-0x00000001800F2020
		public void SetEncrypted(int encrypted, int key); // 0x00000001800F25E0-0x00000001800F2620
		public int GetDecrypted(); // 0x00000001800F2550-0x00000001800F2560
		public void RandomizeCryptoKey(); // 0x00000001800F25B0-0x00000001800F25E0
		private int InternalDecrypt(); // 0x00000001800F25A0-0x00000001800F25B0
		public static implicit operator ObscuredInt(int value); // 0x0000000181881610-0x0000000181881660
		public static implicit operator int(ObscuredInt value); // 0x0000000181881550-0x0000000181881560
		public static implicit operator ObscuredFloat(ObscuredInt value); // 0x0000000181881560-0x0000000181881610
		public static implicit operator ObscuredDouble(ObscuredInt value); // 0x0000000181881480-0x0000000181881550
		public static explicit operator ObscuredUInt(ObscuredInt value); // 0x0000000181881400-0x0000000181881480
		public static ObscuredInt operator ++(ObscuredInt input); // 0x0000000181881660-0x0000000181881750
		public static ObscuredInt operator --(ObscuredInt input); // 0x0000000181881310-0x0000000181881400
		private static ObscuredInt Increment(ObscuredInt input, int increment); // 0x00000001818811C0-0x0000000181881310
		public override int GetHashCode(); // 0x00000001800F2570-0x00000001800F25A0
		public override string ToString(); // 0x00000001800F26B0-0x00000001800F26E0
		public string ToString(string format); // 0x00000001800F2620-0x00000001800F2660
		public string ToString(IFormatProvider provider); // 0x00000001800F26E0-0x00000001800F2720
		public string ToString(string format, IFormatProvider provider); // 0x00000001800F2660-0x00000001800F26B0
		public override bool Equals(object obj); // 0x00000001800F2480-0x00000001800F2550
		public bool Equals(ObscuredInt obj); // 0x00000001800F2420-0x00000001800F2480
		public int CompareTo(ObscuredInt other); // 0x00000001800F2360-0x00000001800F2420
		public int CompareTo(int other); // 0x00000001800F2320-0x00000001800F2360
		public int CompareTo(object obj); // 0x00000001800F22E0-0x00000001800F2320
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(int newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180234A80-0x0000000180234AB0
		public static int Encrypt(int value); // 0x0000000181880F20-0x00000001818810A0
		[Obsolete] // 0x0000000180234BB0-0x0000000180234BE0
		public static int Decrypt(int value); // 0x0000000181880ED0-0x0000000181880F20
		[Obsolete] // 0x0000000180234D70-0x0000000180234DA0
		public static ObscuredInt FromEncrypted(int encrypted); // 0x00000001818810F0-0x00000001818811C0
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public int GetEncrypted(); // 0x00000001800F2560-0x00000001800F2570
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(int encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
