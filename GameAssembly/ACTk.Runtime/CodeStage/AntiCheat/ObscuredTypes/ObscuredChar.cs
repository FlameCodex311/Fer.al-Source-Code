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
	public struct ObscuredChar : IObscuredType, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredChar>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredChar>, IComparable<char>, IComparable // TypeDefIndex: 7345
	{
		// Fields
		private char currentCryptoKey; // 0x00
		private char hiddenValue; // 0x02
		private bool inited; // 0x04
		private char fakeValue; // 0x06
		private bool fakeValueActive; // 0x08
	
		// Constructors
		private ObscuredChar(char value); // 0x00000001800F12E0-0x00000001800F1390
	
		// Methods
		public static char Encrypt(char value, char key); // 0x000000018187EC90-0x000000018187ECA0
		public static char Decrypt(char value, char key); // 0x000000018187EC90-0x000000018187ECA0
		public static ObscuredChar FromEncrypted(char encrypted, char key); // 0x000000018187ED40-0x000000018187ED90
		public static char GenerateKey(); // 0x000000018187ED90-0x000000018187EDF0
		public char GetEncrypted(out char key); // 0x00000001800F1190-0x00000001800F11A0
		public void SetEncrypted(char encrypted, char key); // 0x00000001800F1230-0x00000001800F1270
		public char GetDecrypted(); // 0x00000001800F1180-0x00000001800F1190
		public void RandomizeCryptoKey(); // 0x00000001800F11F0-0x00000001800F1230
		private char InternalDecrypt(); // 0x00000001800F11E0-0x00000001800F11F0
		public static implicit operator ObscuredChar(char value); // 0x000000018187F030-0x000000018187F090
		public static implicit operator char(ObscuredChar value); // 0x000000018187F020-0x000000018187F030
		public static ObscuredChar operator ++(ObscuredChar input); // 0x000000018187F090-0x000000018187F190
		public static ObscuredChar operator --(ObscuredChar input); // 0x000000018187EF20-0x000000018187F020
		private static ObscuredChar Increment(ObscuredChar input, int increment); // 0x000000018187EDF0-0x000000018187EF20
		public override int GetHashCode(); // 0x00000001800F11B0-0x00000001800F11E0
		public override string ToString(); // 0x00000001800F1270-0x00000001800F12A0
		public string ToString(IFormatProvider provider); // 0x00000001800F12A0-0x00000001800F12E0
		public override bool Equals(object obj); // 0x00000001800F1070-0x00000001800F1180
		public bool Equals(ObscuredChar obj); // 0x00000001800F0FF0-0x00000001800F1070
		public int CompareTo(ObscuredChar other); // 0x00000001800F0EB0-0x00000001800F0F70
		public int CompareTo(char other); // 0x00000001800F0F70-0x00000001800F0FB0
		public int CompareTo(object obj); // 0x00000001800F0FB0-0x00000001800F0FF0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(char newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180235560-0x0000000180235590
		public static char EncryptDecrypt(char value); // 0x000000018187ECA0-0x000000018187ECF0
		[Obsolete] // 0x0000000180235940-0x0000000180235970
		public static char EncryptDecrypt(char value, char key); // 0x000000018187EC90-0x000000018187ECA0
		[Obsolete] // 0x0000000180234D70-0x0000000180234DA0
		public static ObscuredChar FromEncrypted(char encrypted); // 0x000000018187ECF0-0x000000018187ED40
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public char GetEncrypted(); // 0x00000001800F11A0-0x00000001800F11B0
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(char encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
