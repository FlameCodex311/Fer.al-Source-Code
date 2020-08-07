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
	public struct ObscuredVector3 : IObscuredType // TypeDefIndex: 7366
	{
		// Fields
		private static readonly Vector3 Zero; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RawEncryptedVector3 hiddenValue; // 0x04
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3 fakeValue; // 0x14
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValueActive; // 0x20
	
		// Properties
		public float x { get; set; } // 0x000000018013EBE0-0x000000018013EBF0 0x000000018013ECE0-0x000000018013ECF0
		public float y { get; set; } // 0x000000018013EBF0-0x000000018013EC00 0x000000018013ECF0-0x000000018013ED00
		public float z { get; set; } // 0x000000018013EC00-0x000000018013EC10 0x000000018013ED00-0x000000018013ED10
		public float this[int index] { get => default; set {} } // 0x000000018013EB30-0x000000018013EBE0 0x000000018013EC10-0x000000018013ECE0
	
		// Nested types
		[Serializable]
		public struct RawEncryptedVector3 // TypeDefIndex: 7367
		{
			// Fields
			public int x; // 0x00
			public int y; // 0x04
			public int z; // 0x08
		}
	
		// Constructors
		private ObscuredVector3(Vector3 value); // 0x000000018013E960-0x000000018013E990
		public ObscuredVector3(float x, float y, float z); // 0x000000018013E990-0x000000018013EB30
		static ObscuredVector3(); // 0x00000001820073F0-0x00000001820079A0
	
		// Methods
		public static RawEncryptedVector3 Encrypt(Vector3 value, int key); // 0x0000000182006D80-0x0000000182006E90
		public static RawEncryptedVector3 Encrypt(float x, float y, float z, int key); // 0x0000000182006D10-0x0000000182006D80
		public static Vector3 Decrypt(RawEncryptedVector3 value, int key); // 0x0000000182006C40-0x0000000182006CC0
		public static ObscuredVector3 FromEncrypted(RawEncryptedVector3 encrypted, int key); // 0x0000000182006E90-0x00000001820073F0
		public static int GenerateKey(); // 0x0000000182003C50-0x0000000182003EF0
		private static bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2); // 0x0000000182006A50-0x0000000182006BF0
		public RawEncryptedVector3 GetEncrypted(out int key); // 0x000000018013DE80-0x000000018013DEA0
		public void SetEncrypted(RawEncryptedVector3 encrypted, int key); // 0x000000018013E860-0x000000018013E8C0
		public Vector3 GetDecrypted(); // 0x000000018013E640-0x000000018013E680
		public void RandomizeCryptoKey(); // 0x000000018013E710-0x000000018013E860
		private Vector3 InternalDecrypt(); // 0x000000018013E6F0-0x000000018013E710
		public static implicit operator ObscuredVector3(Vector3 value); // 0x0000000182008120-0x0000000182008160
		public static implicit operator Vector3(ObscuredVector3 value); // 0x00000001820080F0-0x0000000182008120
		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b); // 0x0000000182007AF0-0x0000000182007C60
		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b); // 0x00000001820079A0-0x0000000182007AF0
		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b); // 0x0000000182007C60-0x0000000182007DB0
		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b); // 0x0000000182008860-0x00000001820089D0
		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b); // 0x0000000182008710-0x0000000182008860
		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b); // 0x00000001820085C0-0x0000000182008710
		public static ObscuredVector3 operator -(ObscuredVector3 a); // 0x00000001820089D0-0x0000000182008C70
		public static ObscuredVector3 operator *(ObscuredVector3 a, float d); // 0x00000001820084A0-0x00000001820085C0
		public static ObscuredVector3 operator *(float d, ObscuredVector3 a); // 0x0000000182008380-0x00000001820084A0
		public static ObscuredVector3 operator /(ObscuredVector3 a, float d); // 0x0000000182007DB0-0x0000000182007ED0
		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs); // 0x0000000182007ED0-0x0000000182007F90
		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs); // 0x0000000182007F90-0x0000000182008040
		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs); // 0x0000000182008040-0x00000001820080F0
		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs); // 0x0000000182008210-0x00000001820082D0
		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs); // 0x0000000182008160-0x0000000182008210
		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs); // 0x00000001820082D0-0x0000000182008380
		public override bool Equals(object other); // 0x000000018013E5F0-0x000000018013E640
		public override int GetHashCode(); // 0x000000018013E6A0-0x000000018013E6F0
		public override string ToString(); // 0x000000018013E910-0x000000018013E960
		public string ToString(string format); // 0x000000018013E8C0-0x000000018013E910
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(int newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180234A80-0x0000000180234AB0
		public static RawEncryptedVector3 Encrypt(Vector3 value); // 0x0000000182006CC0-0x0000000182006D10
		[Obsolete] // 0x0000000180234BB0-0x0000000180234BE0
		public static Vector3 Decrypt(RawEncryptedVector3 value); // 0x0000000182006BF0-0x0000000182006C40
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public RawEncryptedVector3 GetEncrypted(); // 0x000000018013E680-0x000000018013E6A0
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(RawEncryptedVector3 encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
