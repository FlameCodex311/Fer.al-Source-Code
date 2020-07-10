/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredBool : IObscuredType, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredBool>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredBool>, IComparable<bool>, IComparable // TypeDefIndex: 7177
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private byte currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int hiddenValue; // 0x04
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x08
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValue; // 0x09
		[FormerlySerializedAs] // 0x00000001800D36F0-0x00000001800D3730
		[SerializeField] // 0x00000001800D36F0-0x00000001800D3730
		private bool fakeValueActive; // 0x0A
	
		// Constructors
		private ObscuredBool(bool value); // 0x00000001802DBAE0-0x00000001802DBBB0
	
		// Methods
		public static int Encrypt(bool value, byte key); // 0x0000000181BACBF0-0x0000000181BACC10
		public static bool Decrypt(int value, byte key); // 0x0000000181BACB90-0x0000000181BACBA0
		public static ObscuredBool FromEncrypted(int encrypted, byte key); // 0x0000000181BACCB0-0x0000000181BACD00
		public static byte GenerateKey(); // 0x0000000181BACD00-0x0000000181BACE20
		public int GetEncrypted(out byte key); // 0x00000001802DB9D0-0x00000001802DB9E0
		public void SetEncrypted(int encrypted, byte key); // 0x00000001802DBA70-0x00000001802DBAB0
		public bool GetDecrypted(); // 0x00000001802DB9B0-0x00000001802DB9C0
		public void RandomizeCryptoKey(); // 0x00000001802DBA20-0x00000001802DBA70
		private bool InternalDecrypt(); // 0x00000001802DBA10-0x00000001802DBA20
		public static implicit operator ObscuredBool(bool value); // 0x0000000181BACE20-0x0000000181BACE90
		public static implicit operator bool(ObscuredBool value); // 0x0000000181BACE90-0x0000000181BACEA0
		public override int GetHashCode(); // 0x00000001802DB9E0-0x00000001802DBA10
		public override string ToString(); // 0x00000001802DBAB0-0x00000001802DBAE0
		public override bool Equals(object obj); // 0x00000001802DB830-0x00000001802DB930
		public bool Equals(ObscuredBool obj); // 0x00000001802DB930-0x00000001802DB9B0
		public int CompareTo(ObscuredBool other); // 0x00000001802DB760-0x00000001802DB7B0
		public int CompareTo(bool other); // 0x00000001802DB7B0-0x00000001802DB7F0
		public int CompareTo(object obj); // 0x00000001802DB7F0-0x00000001802DB830
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(byte newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D3EC0-0x00000001800D3EF0
		public static int Encrypt(bool value); // 0x0000000181BACC10-0x0000000181BACC60
		[Obsolete] // 0x00000001800D41F0-0x00000001800D4220
		public static bool Decrypt(int value); // 0x0000000181BACBA0-0x0000000181BACBF0
		[Obsolete] // 0x00000001800D43F0-0x00000001800D4420
		public static ObscuredBool FromEncrypted(int encrypted); // 0x0000000181BACC60-0x0000000181BACCB0
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public int GetEncrypted(); // 0x00000001802DB9C0-0x00000001802DB9D0
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(int encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
