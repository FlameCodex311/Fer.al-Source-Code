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
	public struct ObscuredVector3 : IObscuredType // TypeDefIndex: 7200
	{
		// Fields
		private static readonly Vector3 Zero; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RawEncryptedVector3 hiddenValue; // 0x04
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3 fakeValue; // 0x14
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValueActive; // 0x20
	
		// Properties
		public float x { get; set; } // 0x0000000180324A60-0x0000000180324A70 0x0000000180324B60-0x0000000180324B70
		public float y { get; set; } // 0x0000000180324A70-0x0000000180324A80 0x0000000180324B70-0x0000000180324B80
		public float z { get; set; } // 0x0000000180324A80-0x0000000180324A90 0x0000000180324B80-0x0000000180324D20
		public float this[int index] { get => default; set {} } // 0x00000001803249B0-0x0000000180324A60 0x0000000180324A90-0x0000000180324B60
	
		// Nested types
		[Serializable]
		public struct RawEncryptedVector3 // TypeDefIndex: 7201
		{
			// Fields
			public int x; // 0x00
			public int y; // 0x04
			public int z; // 0x08
		}
	
		// Constructors
		private ObscuredVector3(Vector3 value); // 0x00000001803247E0-0x0000000180324810
		public ObscuredVector3(float x, float y, float z); // 0x0000000180324810-0x00000001803249B0
		static ObscuredVector3(); // 0x000000018229BE60-0x000000018229C410
	
		// Methods
		public static RawEncryptedVector3 Encrypt(Vector3 value, int key); // 0x000000018229B8E0-0x000000018229B9A0
		public static RawEncryptedVector3 Encrypt(float x, float y, float z, int key); // 0x000000018229B870-0x000000018229B8E0
		public static Vector3 Decrypt(RawEncryptedVector3 value, int key); // 0x000000018229B7A0-0x000000018229B820
		public static ObscuredVector3 FromEncrypted(RawEncryptedVector3 encrypted, int key); // 0x000000018229B9A0-0x000000018229BE60
		public static int GenerateKey(); // 0x0000000182299CD0-0x000000018229A0A0
		private static bool CompareVectorsWithTolerance(Vector3 vector1, Vector3 vector2); // 0x000000018229B5B0-0x000000018229B750
		public RawEncryptedVector3 GetEncrypted(out int key); // 0x0000000180323D00-0x0000000180323D20
		public void SetEncrypted(RawEncryptedVector3 encrypted, int key); // 0x00000001803246E0-0x0000000180324740
		public Vector3 GetDecrypted(); // 0x00000001803244C0-0x0000000180324500
		public void RandomizeCryptoKey(); // 0x0000000180324590-0x00000001803246E0
		private Vector3 InternalDecrypt(); // 0x0000000180324570-0x0000000180324590
		public static implicit operator ObscuredVector3(Vector3 value); // 0x000000018229CB90-0x000000018229CBD0
		public static implicit operator Vector3(ObscuredVector3 value); // 0x000000018229CB60-0x000000018229CB90
		public static ObscuredVector3 operator +(ObscuredVector3 a, ObscuredVector3 b); // 0x000000018229C560-0x000000018229C6D0
		public static ObscuredVector3 operator +(Vector3 a, ObscuredVector3 b); // 0x000000018229C410-0x000000018229C560
		public static ObscuredVector3 operator +(ObscuredVector3 a, Vector3 b); // 0x000000018229C6D0-0x000000018229C820
		public static ObscuredVector3 operator -(ObscuredVector3 a, ObscuredVector3 b); // 0x000000018229D2D0-0x000000018229D440
		public static ObscuredVector3 operator -(Vector3 a, ObscuredVector3 b); // 0x000000018229D180-0x000000018229D2D0
		public static ObscuredVector3 operator -(ObscuredVector3 a, Vector3 b); // 0x000000018229D030-0x000000018229D180
		public static ObscuredVector3 operator -(ObscuredVector3 a); // 0x000000018229D440-0x000000018229D6E0
		public static ObscuredVector3 operator *(ObscuredVector3 a, float d); // 0x000000018229CF10-0x000000018229D030
		public static ObscuredVector3 operator *(float d, ObscuredVector3 a); // 0x000000018229CDF0-0x000000018229CF10
		public static ObscuredVector3 operator /(ObscuredVector3 a, float d); // 0x000000018229C820-0x000000018229C940
		public static bool operator ==(ObscuredVector3 lhs, ObscuredVector3 rhs); // 0x000000018229C940-0x000000018229CA00
		public static bool operator ==(Vector3 lhs, ObscuredVector3 rhs); // 0x000000018229CA00-0x000000018229CAB0
		public static bool operator ==(ObscuredVector3 lhs, Vector3 rhs); // 0x000000018229CAB0-0x000000018229CB60
		public static bool operator !=(ObscuredVector3 lhs, ObscuredVector3 rhs); // 0x000000018229CC80-0x000000018229CD40
		public static bool operator !=(Vector3 lhs, ObscuredVector3 rhs); // 0x000000018229CBD0-0x000000018229CC80
		public static bool operator !=(ObscuredVector3 lhs, Vector3 rhs); // 0x000000018229CD40-0x000000018229CDF0
		public override bool Equals(object other); // 0x0000000180324470-0x00000001803244C0
		public override int GetHashCode(); // 0x0000000180324520-0x0000000180324570
		public override string ToString(); // 0x0000000180324790-0x00000001803247E0
		public string ToString(string format); // 0x0000000180324740-0x0000000180324790
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(int newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D3EC0-0x00000001800D3EF0
		public static RawEncryptedVector3 Encrypt(Vector3 value); // 0x000000018229B820-0x000000018229B870
		[Obsolete] // 0x00000001800D41F0-0x00000001800D4220
		public static Vector3 Decrypt(RawEncryptedVector3 value); // 0x000000018229B750-0x000000018229B7A0
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public RawEncryptedVector3 GetEncrypted(); // 0x0000000180324500-0x0000000180324520
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(RawEncryptedVector3 encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
