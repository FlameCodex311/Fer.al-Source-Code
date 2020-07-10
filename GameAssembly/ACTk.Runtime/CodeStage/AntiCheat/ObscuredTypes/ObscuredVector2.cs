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
	public struct ObscuredVector2 : IObscuredType // TypeDefIndex: 7196
	{
		// Fields
		private static readonly Vector2 Zero; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RawEncryptedVector2 hiddenValue; // 0x04
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x0C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 fakeValue; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValueActive; // 0x18
	
		// Properties
		public float x { get; set; } // 0x00000001802E0250-0x00000001802E0260 0x00000001802E0320-0x00000001802E0330
		public float y { get; set; } // 0x00000001802E0260-0x00000001802E0270 0x00000001802E0330-0x00000001802E03B0
		public float this[int index] { get => default; set {} } // 0x00000001802E01C0-0x00000001802E0250 0x00000001802E0270-0x00000001802E0320
	
		// Nested types
		[Serializable]
		public struct RawEncryptedVector2 // TypeDefIndex: 7197
		{
			// Fields
			public int x; // 0x00
			public int y; // 0x04
		}
	
		// Constructors
		private ObscuredVector2(Vector2 value); // 0x00000001802E0060-0x00000001802E0070
		public ObscuredVector2(float x, float y); // 0x00000001802E0070-0x00000001802E01C0
		static ObscuredVector2(); // 0x0000000181BB5010-0x0000000181BB5400
	
		// Methods
		public static RawEncryptedVector2 Encrypt(Vector2 value, int key); // 0x0000000181BB4B60-0x0000000181BB4C10
		public static RawEncryptedVector2 Encrypt(float x, float y, int key); // 0x0000000181BB4B00-0x0000000181BB4B60
		public static Vector2 Decrypt(RawEncryptedVector2 value, int key); // 0x0000000181BB4AA0-0x0000000181BB4B00
		public static ObscuredVector2 FromEncrypted(RawEncryptedVector2 encrypted, int key); // 0x0000000181BB4C60-0x0000000181BB5010
		public static int GenerateKey(); // 0x0000000181BAF200-0x0000000181BAF260
		private static bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2); // 0x0000000181BB4940-0x0000000181BB4A50
		public RawEncryptedVector2 GetEncrypted(out int key); // 0x00000001802DF970-0x00000001802DF980
		public void SetEncrypted(RawEncryptedVector2 encrypted, int key); // 0x00000001802DFF90-0x00000001802DFFF0
		public Vector2 GetDecrypted(); // 0x00000001802DFEB0-0x00000001802DFEC0
		public void RandomizeCryptoKey(); // 0x00000001802DFF10-0x00000001802DFF90
		private Vector2 InternalDecrypt(); // 0x00000001802DFF00-0x00000001802DFF10
		public static implicit operator ObscuredVector2(Vector2 value); // 0x0000000181BB5450-0x0000000181BB5480
		public static implicit operator Vector2(ObscuredVector2 value); // 0x0000000181BB5480-0x0000000181BB55B0
		public static implicit operator Vector3(ObscuredVector2 value); // 0x0000000181BB5400-0x0000000181BB5450
		public override int GetHashCode(); // 0x00000001802DFED0-0x00000001802DFF00
		public override string ToString(); // 0x00000001802DFFF0-0x00000001802E0020
		public string ToString(string format); // 0x00000001802E0020-0x00000001802E0060
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(int newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D3EC0-0x00000001800D3EF0
		public static RawEncryptedVector2 Encrypt(Vector2 value); // 0x0000000181BB4C10-0x0000000181BB4C60
		[Obsolete] // 0x00000001800D41F0-0x00000001800D4220
		public static Vector2 Decrypt(RawEncryptedVector2 value); // 0x0000000181BB4A50-0x0000000181BB4AA0
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public RawEncryptedVector2 GetEncrypted(); // 0x00000001802DFEC0-0x00000001802DFED0
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(RawEncryptedVector2 encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
