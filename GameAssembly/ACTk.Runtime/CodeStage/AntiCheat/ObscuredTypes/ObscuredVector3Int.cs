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
	public struct ObscuredVector3Int : IObscuredType // TypeDefIndex: 7202
	{
		// Fields
		private static readonly Vector3Int Zero; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RawEncryptedVector3Int hiddenValue; // 0x04
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3Int fakeValue; // 0x14
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValueActive; // 0x20
	
		// Properties
		public int x { get; set; } // 0x00000001803242C0-0x00000001803242D0 0x00000001803243C0-0x00000001803243D0
		public int y { get; set; } // 0x00000001803242D0-0x00000001803242E0 0x00000001803243D0-0x00000001803243E0
		public int z { get; set; } // 0x00000001803242E0-0x00000001803242F0 0x00000001803243E0-0x0000000180324470
		public int this[int index] { get => default; set {} } // 0x0000000180324210-0x00000001803242C0 0x00000001803242F0-0x00000001803243C0
	
		// Nested types
		[Serializable]
		public struct RawEncryptedVector3Int // TypeDefIndex: 7203
		{
			// Fields
			public int x; // 0x00
			public int y; // 0x04
			public int z; // 0x08
		}
	
		// Constructors
		private ObscuredVector3Int(Vector3Int value); // 0x0000000180324030-0x0000000180324060
		public ObscuredVector3Int(int x, int y, int z); // 0x0000000180324060-0x0000000180324210
		static ObscuredVector3Int(); // 0x000000018229A0A0-0x000000018229A520
	
		// Methods
		public static RawEncryptedVector3Int Encrypt(Vector3Int value, int key); // 0x0000000182299B80-0x0000000182299C60
		public static RawEncryptedVector3Int Encrypt(int x, int y, int z, int key); // 0x0000000182299AC0-0x0000000182299B30
		public static Vector3Int Decrypt(RawEncryptedVector3Int value, int key); // 0x0000000182299A30-0x0000000182299AC0
		public static ObscuredVector3Int FromEncrypted(RawEncryptedVector3Int encrypted, int key); // 0x0000000182299C60-0x0000000182299CD0
		public static int GenerateKey(); // 0x0000000182299CD0-0x000000018229A0A0
		public RawEncryptedVector3Int GetEncrypted(out int key); // 0x0000000180323D00-0x0000000180323D20
		public void SetEncrypted(RawEncryptedVector3Int encrypted, int key); // 0x0000000180323F30-0x0000000180323F90
		public Vector3Int GetDecrypted(); // 0x0000000180323CC0-0x0000000180323D00
		public void RandomizeCryptoKey(); // 0x0000000180323DB0-0x0000000180323F30
		private Vector3Int InternalDecrypt(); // 0x0000000180323D90-0x0000000180323DB0
		public static implicit operator ObscuredVector3Int(Vector3Int value); // 0x000000018229AB80-0x000000018229ABC0
		public static implicit operator Vector3Int(ObscuredVector3Int value); // 0x000000018229AB50-0x000000018229AB80
		public static implicit operator Vector3(ObscuredVector3Int value); // 0x000000018229ABC0-0x000000018229AC70
		public static ObscuredVector3Int operator +(ObscuredVector3Int a, ObscuredVector3Int b); // 0x000000018229A7C0-0x000000018229A930
		public static ObscuredVector3Int operator +(Vector3Int a, ObscuredVector3Int b); // 0x000000018229A670-0x000000018229A7C0
		public static ObscuredVector3Int operator +(ObscuredVector3Int a, Vector3Int b); // 0x000000018229A520-0x000000018229A670
		public static ObscuredVector3Int operator -(ObscuredVector3Int a, ObscuredVector3Int b); // 0x000000018229B260-0x000000018229B5B0
		public static ObscuredVector3Int operator -(Vector3Int a, ObscuredVector3Int b); // 0x000000018229B110-0x000000018229B260
		public static ObscuredVector3Int operator -(ObscuredVector3Int a, Vector3Int b); // 0x000000018229AFC0-0x000000018229B110
		public static ObscuredVector3Int operator *(ObscuredVector3Int a, int d); // 0x000000018229AE90-0x000000018229AFC0
		public static bool operator ==(ObscuredVector3Int lhs, ObscuredVector3Int rhs); // 0x000000018229AA90-0x000000018229AB50
		public static bool operator ==(Vector3Int lhs, ObscuredVector3Int rhs); // 0x000000018229A9E0-0x000000018229AA90
		public static bool operator ==(ObscuredVector3Int lhs, Vector3Int rhs); // 0x000000018229A930-0x000000018229A9E0
		public static bool operator !=(ObscuredVector3Int lhs, ObscuredVector3Int rhs); // 0x000000018229AC70-0x000000018229AD30
		public static bool operator !=(Vector3Int lhs, ObscuredVector3Int rhs); // 0x000000018229ADE0-0x000000018229AE90
		public static bool operator !=(ObscuredVector3Int lhs, Vector3Int rhs); // 0x000000018229AD30-0x000000018229ADE0
		public override bool Equals(object other); // 0x0000000180323C70-0x0000000180323CC0
		public override int GetHashCode(); // 0x0000000180323D40-0x0000000180323D90
		public override string ToString(); // 0x0000000180323FE0-0x0000000180324030
		public string ToString(string format); // 0x0000000180323F90-0x0000000180323FE0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(int newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D3EC0-0x00000001800D3EF0
		public static RawEncryptedVector3Int Encrypt(Vector3Int value); // 0x0000000182299B30-0x0000000182299B80
		[Obsolete] // 0x00000001800D41F0-0x00000001800D4220
		public static Vector3Int Decrypt(RawEncryptedVector3Int value); // 0x00000001822999E0-0x0000000182299A30
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public RawEncryptedVector3Int GetEncrypted(); // 0x0000000180323D20-0x0000000180323D40
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(RawEncryptedVector3Int encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
