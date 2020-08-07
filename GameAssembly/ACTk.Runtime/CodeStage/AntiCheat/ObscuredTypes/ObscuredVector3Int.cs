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
	public struct ObscuredVector3Int : IObscuredType // TypeDefIndex: 7368
	{
		// Fields
		private static readonly Vector3Int Zero; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RawEncryptedVector3Int hiddenValue; // 0x04
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3Int fakeValue; // 0x14
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValueActive; // 0x20
	
		// Properties
		public int x { get; set; } // 0x000000018013E440-0x000000018013E450 0x000000018013E540-0x000000018013E550
		public int y { get; set; } // 0x000000018013E450-0x000000018013E460 0x000000018013E550-0x000000018013E560
		public int z { get; set; } // 0x000000018013E460-0x000000018013E470 0x000000018013E560-0x000000018013E5F0
		public int this[int index] { get => default; set {} } // 0x000000018013E390-0x000000018013E440 0x000000018013E470-0x000000018013E540
	
		// Nested types
		[Serializable]
		public struct RawEncryptedVector3Int // TypeDefIndex: 7369
		{
			// Fields
			public int x; // 0x00
			public int y; // 0x04
			public int z; // 0x08
		}
	
		// Constructors
		private ObscuredVector3Int(Vector3Int value); // 0x000000018013E1B0-0x000000018013E1E0
		public ObscuredVector3Int(int x, int y, int z); // 0x000000018013E1E0-0x000000018013E390
		static ObscuredVector3Int(); // 0x0000000182005540-0x00000001820059C0
	
		// Methods
		public static RawEncryptedVector3Int Encrypt(Vector3Int value, int key); // 0x0000000182005080-0x0000000182005160
		public static RawEncryptedVector3Int Encrypt(int x, int y, int z, int key); // 0x0000000182004FC0-0x0000000182005030
		public static Vector3Int Decrypt(RawEncryptedVector3Int value, int key); // 0x0000000182004F30-0x0000000182004FC0
		public static ObscuredVector3Int FromEncrypted(RawEncryptedVector3Int encrypted, int key); // 0x0000000182005160-0x0000000182005540
		public static int GenerateKey(); // 0x0000000182003C50-0x0000000182003EF0
		public RawEncryptedVector3Int GetEncrypted(out int key); // 0x000000018013DE80-0x000000018013DEA0
		public void SetEncrypted(RawEncryptedVector3Int encrypted, int key); // 0x000000018013E0B0-0x000000018013E110
		public Vector3Int GetDecrypted(); // 0x000000018013DE40-0x000000018013DE80
		public void RandomizeCryptoKey(); // 0x000000018013DF30-0x000000018013E0B0
		private Vector3Int InternalDecrypt(); // 0x000000018013DF10-0x000000018013DF30
		public static implicit operator ObscuredVector3Int(Vector3Int value); // 0x0000000182006020-0x0000000182006060
		public static implicit operator Vector3Int(ObscuredVector3Int value); // 0x0000000182005FF0-0x0000000182006020
		public static implicit operator Vector3(ObscuredVector3Int value); // 0x0000000182006060-0x0000000182006110
		public static ObscuredVector3Int operator +(ObscuredVector3Int a, ObscuredVector3Int b); // 0x0000000182005C60-0x0000000182005DD0
		public static ObscuredVector3Int operator +(Vector3Int a, ObscuredVector3Int b); // 0x0000000182005B10-0x0000000182005C60
		public static ObscuredVector3Int operator +(ObscuredVector3Int a, Vector3Int b); // 0x00000001820059C0-0x0000000182005B10
		public static ObscuredVector3Int operator -(ObscuredVector3Int a, ObscuredVector3Int b); // 0x0000000182006700-0x0000000182006A50
		public static ObscuredVector3Int operator -(Vector3Int a, ObscuredVector3Int b); // 0x00000001820065B0-0x0000000182006700
		public static ObscuredVector3Int operator -(ObscuredVector3Int a, Vector3Int b); // 0x0000000182006460-0x00000001820065B0
		public static ObscuredVector3Int operator *(ObscuredVector3Int a, int d); // 0x0000000182006330-0x0000000182006460
		public static bool operator ==(ObscuredVector3Int lhs, ObscuredVector3Int rhs); // 0x0000000182005F30-0x0000000182005FF0
		public static bool operator ==(Vector3Int lhs, ObscuredVector3Int rhs); // 0x0000000182005E80-0x0000000182005F30
		public static bool operator ==(ObscuredVector3Int lhs, Vector3Int rhs); // 0x0000000182005DD0-0x0000000182005E80
		public static bool operator !=(ObscuredVector3Int lhs, ObscuredVector3Int rhs); // 0x0000000182006110-0x00000001820061D0
		public static bool operator !=(Vector3Int lhs, ObscuredVector3Int rhs); // 0x0000000182006280-0x0000000182006330
		public static bool operator !=(ObscuredVector3Int lhs, Vector3Int rhs); // 0x00000001820061D0-0x0000000182006280
		public override bool Equals(object other); // 0x000000018013DDF0-0x000000018013DE40
		public override int GetHashCode(); // 0x000000018013DEC0-0x000000018013DF10
		public override string ToString(); // 0x000000018013E160-0x000000018013E1B0
		public string ToString(string format); // 0x000000018013E110-0x000000018013E160
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(int newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180234A80-0x0000000180234AB0
		public static RawEncryptedVector3Int Encrypt(Vector3Int value); // 0x0000000182005030-0x0000000182005080
		[Obsolete] // 0x0000000180234BB0-0x0000000180234BE0
		public static Vector3Int Decrypt(RawEncryptedVector3Int value); // 0x0000000182004EE0-0x0000000182004F30
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public RawEncryptedVector3Int GetEncrypted(); // 0x000000018013DEA0-0x000000018013DEC0
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(RawEncryptedVector3Int encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
