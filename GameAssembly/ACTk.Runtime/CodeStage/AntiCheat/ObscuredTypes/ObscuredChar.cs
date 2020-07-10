/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredChar : IObscuredType, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredChar>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredChar>, IComparable<char>, IComparable // TypeDefIndex: 7179
	{
		// Fields
		private char currentCryptoKey; // 0x00
		private char hiddenValue; // 0x02
		private bool inited; // 0x04
		private char fakeValue; // 0x06
		private bool fakeValueActive; // 0x08
	
		// Constructors
		private ObscuredChar(char value); // 0x00000001802DC510-0x00000001802DC5C0
	
		// Methods
		public static char Encrypt(char value, char key); // 0x0000000181BAD400-0x0000000181BAD410
		public static char Decrypt(char value, char key); // 0x0000000181BAD400-0x0000000181BAD410
		public static ObscuredChar FromEncrypted(char encrypted, char key); // 0x0000000181BAD4B0-0x0000000181BAD500
		public static char GenerateKey(); // 0x0000000181BAD500-0x0000000181BAD560
		public char GetEncrypted(out char key); // 0x00000001802DC3C0-0x00000001802DC3D0
		public void SetEncrypted(char encrypted, char key); // 0x00000001802DC460-0x00000001802DC4A0
		public char GetDecrypted(); // 0x00000001802DC3B0-0x00000001802DC3C0
		public void RandomizeCryptoKey(); // 0x00000001802DC420-0x00000001802DC460
		private char InternalDecrypt(); // 0x00000001802DC410-0x00000001802DC420
		public static implicit operator ObscuredChar(char value); // 0x0000000181BAD7B0-0x0000000181BAD810
		public static implicit operator char(ObscuredChar value); // 0x0000000181BAD7A0-0x0000000181BAD7B0
		public static ObscuredChar operator ++(ObscuredChar input); // 0x0000000181BAD810-0x0000000181BAD920
		public static ObscuredChar operator --(ObscuredChar input); // 0x0000000181BAD690-0x0000000181BAD7A0
		private static ObscuredChar Increment(ObscuredChar input, int increment); // 0x0000000181BAD560-0x0000000181BAD690
		public override int GetHashCode(); // 0x00000001802DC3E0-0x00000001802DC410
		public override string ToString(); // 0x00000001802DC4A0-0x00000001802DC4D0
		public string ToString(IFormatProvider provider); // 0x00000001802DC4D0-0x00000001802DC510
		public override bool Equals(object obj); // 0x00000001802DC2A0-0x00000001802DC3B0
		public bool Equals(ObscuredChar obj); // 0x00000001802DC220-0x00000001802DC2A0
		public int CompareTo(ObscuredChar other); // 0x00000001802DC0E0-0x00000001802DC1A0
		public int CompareTo(char other); // 0x00000001802DC1A0-0x00000001802DC1E0
		public int CompareTo(object obj); // 0x00000001802DC1E0-0x00000001802DC220
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(char newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D4DC0-0x00000001800D4DF0
		public static char EncryptDecrypt(char value); // 0x0000000181BAD410-0x0000000181BAD460
		[Obsolete] // 0x00000001800D5120-0x00000001800D5150
		public static char EncryptDecrypt(char value, char key); // 0x0000000181BAD400-0x0000000181BAD410
		[Obsolete] // 0x00000001800D43F0-0x00000001800D4420
		public static ObscuredChar FromEncrypted(char encrypted); // 0x0000000181BAD460-0x0000000181BAD4B0
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public char GetEncrypted(); // 0x00000001802DC3D0-0x00000001802DC3E0
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(char encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
