/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredBool : IObscuredType, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredBool>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredBool>, IComparable<bool>, IComparable // TypeDefIndex: 7343
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private byte currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int hiddenValue; // 0x04
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x08
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValue; // 0x09
		[FormerlySerializedAs] // 0x0000000180234560-0x00000001802345A0
		[SerializeField] // 0x0000000180234560-0x00000001802345A0
		private bool fakeValueActive; // 0x0A
	
		// Constructors
		private ObscuredBool(bool value); // 0x00000001800F08B0-0x00000001800F0980
	
		// Methods
		public static int Encrypt(bool value, byte key); // 0x000000018187E490-0x000000018187E4B0
		public static bool Decrypt(int value, byte key); // 0x000000018187E430-0x000000018187E440
		public static ObscuredBool FromEncrypted(int encrypted, byte key); // 0x000000018187E550-0x000000018187E5A0
		public static byte GenerateKey(); // 0x000000018187E5A0-0x000000018187E6C0
		public int GetEncrypted(out byte key); // 0x00000001800F07A0-0x00000001800F07B0
		public void SetEncrypted(int encrypted, byte key); // 0x00000001800F0840-0x00000001800F0880
		public bool GetDecrypted(); // 0x00000001800F0780-0x00000001800F0790
		public void RandomizeCryptoKey(); // 0x00000001800F07F0-0x00000001800F0840
		private bool InternalDecrypt(); // 0x00000001800F07E0-0x00000001800F07F0
		public static implicit operator ObscuredBool(bool value); // 0x000000018187E6C0-0x000000018187E730
		public static implicit operator bool(ObscuredBool value); // 0x000000018187E730-0x000000018187E740
		public override int GetHashCode(); // 0x00000001800F07B0-0x00000001800F07E0
		public override string ToString(); // 0x00000001800F0880-0x00000001800F08B0
		public override bool Equals(object obj); // 0x00000001800F0600-0x00000001800F0700
		public bool Equals(ObscuredBool obj); // 0x00000001800F0700-0x00000001800F0780
		public int CompareTo(ObscuredBool other); // 0x00000001800F0530-0x00000001800F0580
		public int CompareTo(bool other); // 0x00000001800F0580-0x00000001800F05C0
		public int CompareTo(object obj); // 0x00000001800F05C0-0x00000001800F0600
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(byte newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180234A80-0x0000000180234AB0
		public static int Encrypt(bool value); // 0x000000018187E4B0-0x000000018187E500
		[Obsolete] // 0x0000000180234BB0-0x0000000180234BE0
		public static bool Decrypt(int value); // 0x000000018187E440-0x000000018187E490
		[Obsolete] // 0x0000000180234D70-0x0000000180234DA0
		public static ObscuredBool FromEncrypted(int encrypted); // 0x000000018187E500-0x000000018187E550
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public int GetEncrypted(); // 0x00000001800F0790-0x00000001800F07A0
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(int encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
