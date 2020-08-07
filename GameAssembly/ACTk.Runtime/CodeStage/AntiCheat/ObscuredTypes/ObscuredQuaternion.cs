/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredQuaternion : IObscuredType // TypeDefIndex: 7354
	{
		// Fields
		private static readonly Quaternion Identity; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RawEncryptedQuaternion hiddenValue; // 0x04
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x14
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Quaternion fakeValue; // 0x18
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValueActive; // 0x28
	
		// Nested types
		[Serializable]
		public struct RawEncryptedQuaternion // TypeDefIndex: 7355
		{
			// Fields
			public int x; // 0x00
			public int y; // 0x04
			public int z; // 0x08
			public int w; // 0x0C
		}
	
		// Constructors
		private ObscuredQuaternion(Quaternion value); // 0x00000001800F2F40-0x00000001800F2F60
		public ObscuredQuaternion(float x, float y, float z, float w); // 0x00000001800F2F60-0x00000001800F3160
		static ObscuredQuaternion(); // 0x0000000181882840-0x0000000181882990
	
		// Methods
		public static RawEncryptedQuaternion Encrypt(Quaternion value, int key); // 0x00000001818822B0-0x00000001818823D0
		public static RawEncryptedQuaternion Encrypt(float x, float y, float z, float w, int key); // 0x0000000181882210-0x00000001818822B0
		public static Quaternion Decrypt(RawEncryptedQuaternion value, int key); // 0x00000001818820E0-0x00000001818821C0
		public static ObscuredQuaternion FromEncrypted(RawEncryptedQuaternion encrypted, int key); // 0x00000001818823D0-0x0000000181882840
		public static int GenerateKey(); // 0x0000000181880A70-0x0000000181880AD0
		private static bool CompareQuaternionsWithTolerance(Quaternion q1, Quaternion q2); // 0x0000000181881EC0-0x0000000181882090
		public RawEncryptedQuaternion GetEncrypted(out int key); // 0x00000001800F2D50-0x00000001800F2D70
		public void SetEncrypted(RawEncryptedQuaternion encrypted, int key); // 0x00000001800F2E70-0x00000001800F2EC0
		public Quaternion GetDecrypted(); // 0x00000001800F2D00-0x00000001800F2D30
		public void RandomizeCryptoKey(); // 0x00000001800F2DD0-0x00000001800F2E70
		private Quaternion InternalDecrypt(); // 0x00000001800F2DB0-0x00000001800F2DD0
		public static implicit operator ObscuredQuaternion(Quaternion value); // 0x00000001818829C0-0x0000000181882A00
		public static implicit operator Quaternion(ObscuredQuaternion value); // 0x0000000181882990-0x00000001818829C0
		public override int GetHashCode(); // 0x00000001800F2D70-0x00000001800F2DB0
		public override string ToString(); // 0x00000001800F2EC0-0x00000001800F2F00
		public string ToString(string format); // 0x00000001800F2F00-0x00000001800F2F40
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(int newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180234A80-0x0000000180234AB0
		public static RawEncryptedQuaternion Encrypt(Quaternion value); // 0x00000001818821C0-0x0000000181882210
		[Obsolete] // 0x0000000180234BB0-0x0000000180234BE0
		public static Quaternion Decrypt(RawEncryptedQuaternion value); // 0x0000000181882090-0x00000001818820E0
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public RawEncryptedQuaternion GetEncrypted(); // 0x00000001800F2D30-0x00000001800F2D50
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(RawEncryptedQuaternion encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
