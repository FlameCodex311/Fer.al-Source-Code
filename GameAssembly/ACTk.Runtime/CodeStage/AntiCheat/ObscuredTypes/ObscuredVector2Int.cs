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
	public struct ObscuredVector2Int : IObscuredType // TypeDefIndex: 7198
	{
		// Fields
		private static readonly Vector2Int Zero; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RawEncryptedVector2Int hiddenValue; // 0x04
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x0C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2Int fakeValue; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValueActive; // 0x18
	
		// Properties
		public int x { get; set; } // 0x00000001802DFC50-0x00000001802DFC60 0x00000001802DFD70-0x00000001802DFDE0
		public int y { get; set; } // 0x00000001802DFC60-0x00000001802DFC70 0x00000001802DFDE0-0x00000001802DFEB0
		public int this[int index] { get => default; set {} } // 0x00000001802DFBC0-0x00000001802DFC50 0x00000001802DFC70-0x00000001802DFD70
	
		// Nested types
		[Serializable]
		public struct RawEncryptedVector2Int // TypeDefIndex: 7199
		{
			// Fields
			public int x; // 0x00
			public int y; // 0x04
		}
	
		// Constructors
		private ObscuredVector2Int(Vector2Int value); // 0x00000001802DFBB0-0x00000001802DFBC0
		public ObscuredVector2Int(int x, int y); // 0x00000001802DFAB0-0x00000001802DFBB0
		static ObscuredVector2Int(); // 0x0000000181BB4610-0x0000000181BB48A0
	
		// Methods
		public static RawEncryptedVector2Int Encrypt(Vector2Int value, int key); // 0x0000000181BB42C0-0x0000000181BB4360
		public static RawEncryptedVector2Int Encrypt(int x, int y, int key); // 0x0000000181BB4360-0x0000000181BB4390
		public static Vector2Int Decrypt(RawEncryptedVector2Int value, int key); // 0x0000000181BB4270-0x0000000181BB42C0
		public static ObscuredVector2Int FromEncrypted(RawEncryptedVector2Int encrypted, int key); // 0x0000000181BB43E0-0x0000000181BB4610
		public static int GenerateKey(); // 0x0000000181BAF200-0x0000000181BAF260
		public RawEncryptedVector2Int GetEncrypted(out int key); // 0x00000001802DF970-0x00000001802DF980
		public void SetEncrypted(RawEncryptedVector2Int encrypted, int key); // 0x00000001802DFA40-0x00000001802DFA80
		public Vector2Int GetDecrypted(); // 0x00000001802DF950-0x00000001802DF960
		public void RandomizeCryptoKey(); // 0x00000001802DF9C0-0x00000001802DFA40
		private Vector2Int InternalDecrypt(); // 0x00000001802DF9B0-0x00000001802DF9C0
		public static implicit operator ObscuredVector2Int(Vector2Int value); // 0x0000000181BB4900-0x0000000181BB4930
		public static implicit operator Vector2Int(ObscuredVector2Int value); // 0x0000000181BB4930-0x0000000181BB4940
		public static implicit operator Vector2(ObscuredVector2Int value); // 0x0000000181BB48A0-0x0000000181BB4900
		public override int GetHashCode(); // 0x00000001802DF980-0x00000001802DF9B0
		public override string ToString(); // 0x00000001802DFA80-0x00000001802DFAB0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(int newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D3EC0-0x00000001800D3EF0
		public static RawEncryptedVector2Int Encrypt(Vector2Int value); // 0x0000000181BB4390-0x0000000181BB43E0
		[Obsolete] // 0x00000001800D41F0-0x00000001800D4220
		public static Vector2Int Decrypt(RawEncryptedVector2Int value); // 0x0000000181BB4220-0x0000000181BB4270
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public RawEncryptedVector2Int GetEncrypted(); // 0x00000001802DF960-0x00000001802DF970
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(RawEncryptedVector2Int encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
