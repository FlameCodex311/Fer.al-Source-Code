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
	public struct ObscuredVector2Int : IObscuredType // TypeDefIndex: 7364
	{
		// Fields
		private static readonly Vector2Int Zero; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RawEncryptedVector2Int hiddenValue; // 0x04
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x0C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector2Int fakeValue; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValueActive; // 0x18
	
		// Properties
		public int x { get; set; } // 0x000000018013D610-0x000000018013D620 0x000000018013D6E0-0x000000018013D6F0
		public int y { get; set; } // 0x000000018013D620-0x000000018013D630 0x000000018013D6F0-0x000000018013D760
		public int this[int index] { get => default; set {} } // 0x000000018013D580-0x000000018013D610 0x000000018013D630-0x000000018013D6E0
	
		// Nested types
		[Serializable]
		public struct RawEncryptedVector2Int // TypeDefIndex: 7365
		{
			// Fields
			public int x; // 0x00
			public int y; // 0x04
		}
	
		// Constructors
		private ObscuredVector2Int(Vector2Int value); // 0x000000018013D570-0x000000018013D580
		public ObscuredVector2Int(int x, int y); // 0x000000018013D410-0x000000018013D570
		static ObscuredVector2Int(); // 0x0000000182003EF0-0x00000001820041E0
	
		// Methods
		public static RawEncryptedVector2Int Encrypt(Vector2Int value, int key); // 0x0000000182003AB0-0x0000000182003B60
		public static RawEncryptedVector2Int Encrypt(int x, int y, int key); // 0x0000000182003B60-0x0000000182003BB0
		public static Vector2Int Decrypt(RawEncryptedVector2Int value, int key); // 0x0000000182003A50-0x0000000182003AB0
		public static ObscuredVector2Int FromEncrypted(RawEncryptedVector2Int encrypted, int key); // 0x0000000182003C00-0x0000000182003C50
		public static int GenerateKey(); // 0x0000000182003C50-0x0000000182003EF0
		public RawEncryptedVector2Int GetEncrypted(out int key); // 0x000000018013D290-0x000000018013D2A0
		public void SetEncrypted(RawEncryptedVector2Int encrypted, int key); // 0x000000018013D3A0-0x000000018013D3E0
		public Vector2Int GetDecrypted(); // 0x000000018013D270-0x000000018013D280
		public void RandomizeCryptoKey(); // 0x000000018013D2E0-0x000000018013D3A0
		private Vector2Int InternalDecrypt(); // 0x000000018013D2D0-0x000000018013D2E0
		public static implicit operator ObscuredVector2Int(Vector2Int value); // 0x0000000182004240-0x0000000182004270
		public static implicit operator Vector2Int(ObscuredVector2Int value); // 0x0000000182004270-0x0000000182004380
		public static implicit operator Vector2(ObscuredVector2Int value); // 0x00000001820041E0-0x0000000182004240
		public override int GetHashCode(); // 0x000000018013D2A0-0x000000018013D2D0
		public override string ToString(); // 0x000000018013D3E0-0x000000018013D410
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(int newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180234A80-0x0000000180234AB0
		public static RawEncryptedVector2Int Encrypt(Vector2Int value); // 0x0000000182003BB0-0x0000000182003C00
		[Obsolete] // 0x0000000180234BB0-0x0000000180234BE0
		public static Vector2Int Decrypt(RawEncryptedVector2Int value); // 0x0000000182003A00-0x0000000182003A50
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public RawEncryptedVector2Int GetEncrypted(); // 0x000000018013D280-0x000000018013D290
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(RawEncryptedVector2Int encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
