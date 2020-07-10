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
	public struct ObscuredInt : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredInt>, IComparable<int>, IComparable // TypeDefIndex: 7186
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int hiddenValue; // 0x04
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x08
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int fakeValue; // 0x0C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValueActive; // 0x10
	
		// Constructors
		private ObscuredInt(int value); // 0x00000001802DD950-0x00000001802DD9F0
	
		// Methods
		public static int Encrypt(int value, int key); // 0x0000000181BAF650-0x0000000181BAF660
		public static int Decrypt(int value, int key); // 0x0000000181BAF650-0x0000000181BAF660
		public static ObscuredInt FromEncrypted(int encrypted, int key); // 0x0000000181BAF830-0x0000000181BAF880
		public static int GenerateKey(); // 0x0000000181BAF200-0x0000000181BAF260
		public int GetEncrypted(out int key); // 0x00000001802DD240-0x00000001802DD250
		public void SetEncrypted(int encrypted, int key); // 0x00000001802DD810-0x00000001802DD850
		public int GetDecrypted(); // 0x00000001802DD780-0x00000001802DD790
		public void RandomizeCryptoKey(); // 0x00000001802DD7E0-0x00000001802DD810
		private int InternalDecrypt(); // 0x00000001802DD7D0-0x00000001802DD7E0
		public static implicit operator ObscuredInt(int value); // 0x0000000181BAFDA0-0x0000000181BAFDF0
		public static implicit operator int(ObscuredInt value); // 0x0000000181BAFCE0-0x0000000181BAFCF0
		public static implicit operator ObscuredFloat(ObscuredInt value); // 0x0000000181BAFCF0-0x0000000181BAFDA0
		public static implicit operator ObscuredDouble(ObscuredInt value); // 0x0000000181BAFC10-0x0000000181BAFCE0
		public static explicit operator ObscuredUInt(ObscuredInt value); // 0x0000000181BAFB90-0x0000000181BAFC10
		public static ObscuredInt operator ++(ObscuredInt input); // 0x0000000181BAFDF0-0x0000000181BAFEE0
		public static ObscuredInt operator --(ObscuredInt input); // 0x0000000181BAFAA0-0x0000000181BAFB90
		private static ObscuredInt Increment(ObscuredInt input, int increment); // 0x0000000181BAF950-0x0000000181BAFAA0
		public override int GetHashCode(); // 0x00000001802DD7A0-0x00000001802DD7D0
		public override string ToString(); // 0x00000001802DD8E0-0x00000001802DD910
		public string ToString(string format); // 0x00000001802DD850-0x00000001802DD890
		public string ToString(IFormatProvider provider); // 0x00000001802DD910-0x00000001802DD950
		public string ToString(string format, IFormatProvider provider); // 0x00000001802DD890-0x00000001802DD8E0
		public override bool Equals(object obj); // 0x00000001802DD6B0-0x00000001802DD780
		public bool Equals(ObscuredInt obj); // 0x00000001802DD650-0x00000001802DD6B0
		public int CompareTo(ObscuredInt other); // 0x00000001802DD590-0x00000001802DD650
		public int CompareTo(int other); // 0x00000001802DD550-0x00000001802DD590
		public int CompareTo(object obj); // 0x00000001802DD510-0x00000001802DD550
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(int newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D3EC0-0x00000001800D3EF0
		public static int Encrypt(int value); // 0x0000000181BAF6B0-0x0000000181BAF830
		[Obsolete] // 0x00000001800D41F0-0x00000001800D4220
		public static int Decrypt(int value); // 0x0000000181BAF660-0x0000000181BAF6B0
		[Obsolete] // 0x00000001800D43F0-0x00000001800D4420
		public static ObscuredInt FromEncrypted(int encrypted); // 0x0000000181BAF880-0x0000000181BAF950
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public int GetEncrypted(); // 0x00000001802DD790-0x00000001802DD7A0
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(int encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
