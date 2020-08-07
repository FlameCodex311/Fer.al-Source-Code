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
	public struct ObscuredVector2 : IObscuredType // TypeDefIndex: 7362
	{
		// Fields
		private static readonly Vector2 Zero; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RawEncryptedVector2 hiddenValue; // 0x04
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x0C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector2 fakeValue; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValueActive; // 0x18
	
		// Properties
		public float x { get; set; } // 0x000000018013DB80-0x000000018013DB90 0x000000018013DCA0-0x000000018013DD10
		public float y { get; set; } // 0x000000018013DB90-0x000000018013DBA0 0x000000018013DD10-0x000000018013DDF0
		public float this[int index] { get => default; set {} } // 0x000000018013DAF0-0x000000018013DB80 0x000000018013DBA0-0x000000018013DCA0
	
		// Nested types
		[Serializable]
		public struct RawEncryptedVector2 // TypeDefIndex: 7363
		{
			// Fields
			public int x; // 0x00
			public int y; // 0x04
		}
	
		// Constructors
		private ObscuredVector2(Vector2 value); // 0x000000018013D960-0x000000018013D970
		public ObscuredVector2(float x, float y); // 0x000000018013D970-0x000000018013DAF0
		static ObscuredVector2(); // 0x0000000182004A40-0x0000000182004E50
	
		// Methods
		public static RawEncryptedVector2 Encrypt(Vector2 value, int key); // 0x0000000182004580-0x0000000182004610
		public static RawEncryptedVector2 Encrypt(float x, float y, int key); // 0x0000000182004530-0x0000000182004580
		public static Vector2 Decrypt(RawEncryptedVector2 value, int key); // 0x00000001820044E0-0x0000000182004530
		public static ObscuredVector2 FromEncrypted(RawEncryptedVector2 encrypted, int key); // 0x0000000182004660-0x0000000182004A40
		public static int GenerateKey(); // 0x0000000182003C50-0x0000000182003EF0
		private static bool CompareVectorsWithTolerance(Vector2 vector1, Vector2 vector2); // 0x0000000182004380-0x0000000182004490
		public RawEncryptedVector2 GetEncrypted(out int key); // 0x000000018013D290-0x000000018013D2A0
		public void SetEncrypted(RawEncryptedVector2 encrypted, int key); // 0x000000018013D890-0x000000018013D8F0
		public Vector2 GetDecrypted(); // 0x000000018013D760-0x000000018013D770
		public void RandomizeCryptoKey(); // 0x000000018013D7C0-0x000000018013D890
		private Vector2 InternalDecrypt(); // 0x000000018013D7B0-0x000000018013D7C0
		public static implicit operator ObscuredVector2(Vector2 value); // 0x0000000182004EA0-0x0000000182004ED0
		public static implicit operator Vector2(ObscuredVector2 value); // 0x0000000182004ED0-0x0000000182004EE0
		public static implicit operator Vector3(ObscuredVector2 value); // 0x0000000182004E50-0x0000000182004EA0
		public override int GetHashCode(); // 0x000000018013D780-0x000000018013D7B0
		public override string ToString(); // 0x000000018013D8F0-0x000000018013D920
		public string ToString(string format); // 0x000000018013D920-0x000000018013D960
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(int newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180234A80-0x0000000180234AB0
		public static RawEncryptedVector2 Encrypt(Vector2 value); // 0x0000000182004610-0x0000000182004660
		[Obsolete] // 0x0000000180234BB0-0x0000000180234BE0
		public static Vector2 Decrypt(RawEncryptedVector2 value); // 0x0000000182004490-0x00000001820044E0
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public RawEncryptedVector2 GetEncrypted(); // 0x000000018013D770-0x000000018013D780
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(RawEncryptedVector2 encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
