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
	public struct ObscuredQuaternion : IObscuredType // TypeDefIndex: 7188
	{
		// Fields
		private static readonly Quaternion Identity; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RawEncryptedQuaternion hiddenValue; // 0x04
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x14
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Quaternion fakeValue; // 0x18
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValueActive; // 0x28
	
		// Nested types
		[Serializable]
		public struct RawEncryptedQuaternion // TypeDefIndex: 7189
		{
			// Fields
			public int x; // 0x00
			public int y; // 0x04
			public int z; // 0x08
			public int w; // 0x0C
		}
	
		// Constructors
		private ObscuredQuaternion(Quaternion value); // 0x00000001802DE170-0x00000001802DE190
		public ObscuredQuaternion(float x, float y, float z, float w); // 0x00000001802DE190-0x00000001802DE390
		static ObscuredQuaternion(); // 0x0000000181BB0FE0-0x0000000181BB1130
	
		// Methods
		public static RawEncryptedQuaternion Encrypt(Quaternion value, int key); // 0x0000000181BB0A40-0x0000000181BB0B60
		public static RawEncryptedQuaternion Encrypt(float x, float y, float z, float w, int key); // 0x0000000181BB09A0-0x0000000181BB0A40
		public static Quaternion Decrypt(RawEncryptedQuaternion value, int key); // 0x0000000181BB0870-0x0000000181BB0950
		public static ObscuredQuaternion FromEncrypted(RawEncryptedQuaternion encrypted, int key); // 0x0000000181BB0B60-0x0000000181BB0FE0
		public static int GenerateKey(); // 0x0000000181BAF200-0x0000000181BAF260
		private static bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2); // 0x0000000181BB0650-0x0000000181BB0820
		public RawEncryptedQuaternion GetEncrypted(out int key); // 0x00000001802DDF80-0x00000001802DDFA0
		public void SetEncrypted(RawEncryptedQuaternion encrypted, int key); // 0x00000001802DE0A0-0x00000001802DE0F0
		public Quaternion GetDecrypted(); // 0x00000001802DDF30-0x00000001802DDF60
		public void RandomizeCryptoKey(); // 0x00000001802DE000-0x00000001802DE0A0
		private Quaternion InternalDecrypt(); // 0x00000001802DDFE0-0x00000001802DE000
		public static implicit operator ObscuredQuaternion(Quaternion value); // 0x0000000181BB1160-0x0000000181BB11A0
		public static implicit operator Quaternion(ObscuredQuaternion value); // 0x0000000181BB1130-0x0000000181BB1160
		public override int GetHashCode(); // 0x00000001802DDFA0-0x00000001802DDFE0
		public override string ToString(); // 0x00000001802DE0F0-0x00000001802DE130
		public string ToString(string format); // 0x00000001802DE130-0x00000001802DE170
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(int newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D3EC0-0x00000001800D3EF0
		public static RawEncryptedQuaternion Encrypt(Quaternion value); // 0x0000000181BB0950-0x0000000181BB09A0
		[Obsolete] // 0x00000001800D41F0-0x00000001800D4220
		public static Quaternion Decrypt(RawEncryptedQuaternion value); // 0x0000000181BB0820-0x0000000181BB0870
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public RawEncryptedQuaternion GetEncrypted(); // 0x00000001802DDF60-0x00000001802DDF80
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(RawEncryptedQuaternion encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
