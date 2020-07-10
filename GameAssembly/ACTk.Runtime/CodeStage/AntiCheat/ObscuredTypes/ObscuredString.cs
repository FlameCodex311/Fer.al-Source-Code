/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public sealed class ObscuredString : IObscuredType, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredString>, IComparable<string>, IComparable // TypeDefIndex: 7192
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string currentCryptoKey; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private byte[] hiddenValue; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private char[] cryptoKey; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private char[] hiddenChars; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string fakeValue; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValueActive; // 0x40
	
		// Properties
		public int Length { get; } // 0x0000000180708D50-0x0000000180708D70 
		public char this[int index] { get => default; } // 0x0000000181BB30B0-0x0000000181BB3160 
	
		// Constructors
		private ObscuredString(); // 0x000000018036B6C0-0x000000018036B6D0
		private ObscuredString(string value); // 0x0000000181BB3000-0x0000000181BB30B0
	
		// Methods
		public static char[] Encrypt(string value, string key); // 0x0000000181BB1FF0-0x0000000181BB2050
		public static char[] Encrypt(string value, char[] key); // 0x0000000181BB2050-0x0000000181BB2080
		public static char[] Encrypt(char[] value, char[] key); // 0x0000000181BB2080-0x0000000181BB2090
		public static string Decrypt(char[] value, string key); // 0x0000000181BB1DB0-0x0000000181BB1E00
		public static string Decrypt(char[] value, char[] key); // 0x0000000181BB1D90-0x0000000181BB1DB0
		public static ObscuredString FromEncrypted(char[] encrypted, char[] key); // 0x0000000181BB2570-0x0000000181BB2620
		[Obsolete] // 0x00000001800E19D0-0x00000001800E1A00
		public static ObscuredString FromEncrypted(string encrypted, string key = "4441" /* Metadata: 0x007412C4 */); // 0x0000000181BB2440-0x0000000181BB2570
		public static char[] GenerateKey(); // 0x0000000181BB2640-0x0000000181BB26A0
		public static void GenerateKey(ref char[] arrayToFill); // 0x0000000181BB26A0-0x0000000181BB26B0
		[Obsolete] // 0x00000001800E1AA0-0x00000001800E1AD0
		public static char[] GenerateKey(char[] arrayToFill); // 0x0000000181BB2620-0x0000000181BB2640
		internal static char[] InternalEncryptDecrypt(char[] value, char[] key); // 0x0000000181BB2B20-0x0000000181BB2C80
		internal static string EncryptDecryptObsolete(string value, string key); // 0x0000000181BB1E00-0x0000000181BB1F90
		public char[] GetEncrypted(out char[] key); // 0x0000000181BB2770-0x0000000181BB2780
		public void SetEncrypted(char[] encrypted, char[] key); // 0x0000000181BB2EB0-0x0000000181BB2F00
		[Obsolete] // 0x00000001800E1DE0-0x00000001800E1E10
		public void SetEncrypted(string encrypted, string key); // 0x0000000181BB2DC0-0x0000000181BB2EB0
		public string GetDecrypted(); // 0x0000000181BB2750-0x0000000181BB2770
		public char[] GetDecryptedToChars(); // 0x0000000181BB2740-0x0000000181BB2750
		public void RandomizeCryptoKey(); // 0x0000000181BB2D70-0x0000000181BB2DC0
		private string InternalDecryptToString(); // 0x0000000181BB2750-0x0000000181BB2770
		private char[] InternalDecrypt(); // 0x0000000181BB28A0-0x0000000181BB2B20
		private bool CompareCharsToString(char[] chars, string s); // 0x0000000181BB1BF0-0x0000000181BB1CA0
		internal void MigrateFromACTkV1(); // 0x0000000181BB2C80-0x0000000181BB2D70
		public static implicit operator ObscuredString(string value); // 0x0000000181BB32F0-0x0000000181BB33D0
		public static implicit operator string(ObscuredString value); // 0x0000000181BB32C0-0x0000000181BB32F0
		public static bool operator ==(ObscuredString a, ObscuredString b); // 0x0000000181BB3160-0x0000000181BB32C0
		public static bool operator !=(ObscuredString a, ObscuredString b); // 0x0000000181BB33D0-0x0000000181BB33F0
		public string Substring(int startIndex); // 0x0000000181BB2FA0-0x0000000181BB3000
		public string Substring(int startIndex, int length); // 0x0000000181BB2F50-0x0000000181BB2FA0
		public bool StartsWith(string value, StringComparison comparisonType = StringComparison.CurrentCulture /* Metadata: 0x007412CC */); // 0x0000000181BB2F00-0x0000000181BB2F50
		public bool EndsWith(string value, StringComparison comparisonType = StringComparison.CurrentCulture /* Metadata: 0x007412D0 */); // 0x0000000181BB2090-0x0000000181BB20E0
		public override int GetHashCode(); // 0x0000000181BB27D0-0x0000000181BB2810
		public override string ToString(); // 0x0000000181BB2750-0x0000000181BB2770
		public override bool Equals(object obj); // 0x0000000181BB20E0-0x0000000181BB2270
		public bool Equals(ObscuredString value); // 0x0000000181BB22F0-0x0000000181BB2440
		public bool Equals(ObscuredString value, StringComparison comparisonType); // 0x0000000181BB2270-0x0000000181BB22F0
		public int CompareTo(ObscuredString other); // 0x0000000181BB1CE0-0x0000000181BB1D50
		public int CompareTo(string other); // 0x0000000181BB1CA0-0x0000000181BB1CE0
		public int CompareTo(object obj); // 0x0000000181BB1D50-0x0000000181BB1D90
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(string newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D4DC0-0x00000001800D4DF0
		public static string EncryptDecrypt(string value); // 0x0000000181BB1FA0-0x0000000181BB1FF0
		[Obsolete] // 0x00000001800D5120-0x00000001800D5150
		public static string EncryptDecrypt(string value, string key); // 0x0000000181BB1F90-0x0000000181BB1FA0
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public string GetEncrypted(); // 0x0000000181BB2780-0x0000000181BB27D0
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(string encrypted); // 0x00000001803581E0-0x00000001803581F0
		internal static string GetStringObsolete(byte[] bytes); // 0x0000000181BB2810-0x0000000181BB28A0
		internal static byte[] GetBytesObsolete(string str); // 0x0000000181BB26B0-0x0000000181BB2740
		private static bool ArraysEquals(char[] a1, char[] a2); // 0x0000000181BB1B60-0x0000000181BB1BF0
	}
}
