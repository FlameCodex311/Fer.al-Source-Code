/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public sealed class ObscuredString : IObscuredType, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredString>, IComparable<string>, IComparable // TypeDefIndex: 7358
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string currentCryptoKey; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private byte[] hiddenValue; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private char[] cryptoKey; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private char[] hiddenChars; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string fakeValue; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValueActive; // 0x40
	
		// Properties
		public int Length { get; } // 0x0000000180F78570-0x0000000180F78590 
		public char this[int index] { get => default; } // 0x00000001818848B0-0x0000000181884960 
	
		// Constructors
		private ObscuredString(); // 0x0000000180373240-0x0000000180373250
		private ObscuredString(string value); // 0x0000000181884800-0x00000001818848B0
	
		// Methods
		public static char[] Encrypt(string value, string key); // 0x0000000181883810-0x0000000181883870
		public static char[] Encrypt(string value, char[] key); // 0x0000000181883870-0x00000001818838A0
		public static char[] Encrypt(char[] value, char[] key); // 0x00000001818838A0-0x00000001818838B0
		public static string Decrypt(char[] value, string key); // 0x00000001818835E0-0x0000000181883630
		public static string Decrypt(char[] value, char[] key); // 0x00000001818835C0-0x00000001818835E0
		public static ObscuredString FromEncrypted(char[] encrypted, char[] key); // 0x0000000181883D80-0x0000000181883E30
		[Obsolete] // 0x0000000180242480-0x00000001802424B0
		public static ObscuredString FromEncrypted(string encrypted, string key = "4441" /* Metadata: 0x00775FB2 */); // 0x0000000181883C50-0x0000000181883D80
		public static char[] GenerateKey(); // 0x0000000181883E50-0x0000000181883EB0
		public static void GenerateKey(ref char[] arrayToFill); // 0x0000000181883EB0-0x0000000181883EC0
		[Obsolete] // 0x0000000180242650-0x0000000180242680
		public static char[] GenerateKey(char[] arrayToFill); // 0x0000000181883E30-0x0000000181883E50
		internal static char[] InternalEncryptDecrypt(char[] value, char[] key); // 0x0000000181884320-0x0000000181884480
		internal static string EncryptDecryptObsolete(string value, string key); // 0x0000000181883630-0x00000001818837B0
		public char[] GetEncrypted(out char[] key); // 0x0000000181883F80-0x0000000181883F90
		public void SetEncrypted(char[] encrypted, char[] key); // 0x00000001818846B0-0x0000000181884700
		[Obsolete] // 0x0000000180242970-0x00000001802429A0
		public void SetEncrypted(string encrypted, string key); // 0x00000001818845C0-0x00000001818846B0
		public string GetDecrypted(); // 0x0000000181883F60-0x0000000181883F80
		public char[] GetDecryptedToChars(); // 0x0000000181883F50-0x0000000181883F60
		public void RandomizeCryptoKey(); // 0x0000000181884570-0x00000001818845C0
		private string InternalDecryptToString(); // 0x0000000181883F60-0x0000000181883F80
		private char[] InternalDecrypt(); // 0x00000001818840B0-0x0000000181884320
		private bool CompareCharsToString(char[] chars, string s); // 0x0000000181883430-0x00000001818834D0
		internal void MigrateFromACTkV1(); // 0x0000000181884480-0x0000000181884570
		public static implicit operator ObscuredString(string value); // 0x0000000181884AF0-0x0000000181884BD0
		public static implicit operator string(ObscuredString value); // 0x0000000181884AC0-0x0000000181884AF0
		public static bool operator ==(ObscuredString a, ObscuredString b); // 0x0000000181884960-0x0000000181884AC0
		public static bool operator !=(ObscuredString a, ObscuredString b); // 0x0000000181884BD0-0x0000000181884BF0
		public string Substring(int startIndex); // 0x00000001818847A0-0x0000000181884800
		public string Substring(int startIndex, int length); // 0x0000000181884750-0x00000001818847A0
		public bool StartsWith(string value, StringComparison comparisonType = StringComparison.CurrentCulture /* Metadata: 0x00775FBA */); // 0x0000000181884700-0x0000000181884750
		public bool EndsWith(string value, StringComparison comparisonType = StringComparison.CurrentCulture /* Metadata: 0x00775FBE */); // 0x00000001818838B0-0x0000000181883900
		public override int GetHashCode(); // 0x0000000181883FE0-0x0000000181884020
		public override string ToString(); // 0x0000000181883F60-0x0000000181883F80
		public override bool Equals(object obj); // 0x0000000181883900-0x0000000181883A80
		public bool Equals(ObscuredString value); // 0x0000000181883B00-0x0000000181883C50
		public bool Equals(ObscuredString value, StringComparison comparisonType); // 0x0000000181883A80-0x0000000181883B00
		public int CompareTo(ObscuredString other); // 0x0000000181883510-0x0000000181883580
		public int CompareTo(string other); // 0x00000001818834D0-0x0000000181883510
		public int CompareTo(object obj); // 0x0000000181883580-0x00000001818835C0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(string newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180235560-0x0000000180235590
		public static string EncryptDecrypt(string value); // 0x00000001818837C0-0x0000000181883810
		[Obsolete] // 0x0000000180235940-0x0000000180235970
		public static string EncryptDecrypt(string value, string key); // 0x00000001818837B0-0x00000001818837C0
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public string GetEncrypted(); // 0x0000000181883F90-0x0000000181883FE0
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(string encrypted); // 0x00000001803774A0-0x00000001803774B0
		internal static string GetStringObsolete(byte[] bytes); // 0x0000000181884020-0x00000001818840B0
		internal static byte[] GetBytesObsolete(string str); // 0x0000000181883EC0-0x0000000181883F50
		private static bool ArraysEquals(char[] a1, char[] a2); // 0x00000001818833A0-0x0000000181883430
	}
}
