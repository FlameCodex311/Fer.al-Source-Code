/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Serialization;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredFloat : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat>, IComparable<float>, IComparable // TypeDefIndex: 7184
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int hiddenValue; // 0x04
		[FormerlySerializedAs] // 0x00000001800D7B70-0x00000001800D7BB0
		[SerializeField] // 0x00000001800D7B70-0x00000001800D7BB0
		private ACTkByte4 hiddenValueOldByte4; // 0x08
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x0C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float fakeValue; // 0x10
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValueActive; // 0x14
	
		// Nested types
		internal struct FloatIntBytesUnion // TypeDefIndex: 7185
		{
			// Fields
			internal float f; // 0x00
			internal int i; // 0x00
			internal ACTkByte4 b4; // 0x00
	
			// Methods
			public static int Migrate(int value, byte fromVersion, byte toVersion); // 0x0000000181BAC730-0x0000000181BAC760
			internal static int XorFloatToInt(float value, int key); // 0x0000000181BAC760-0x0000000181BAC790
			internal static float XorIntToFloat(int value, int key); // 0x0000000181BAC790-0x0000000181BAC7C0
			private static FloatIntBytesUnion FromFloat(float value); // 0x000000018051D960-0x000000018051D970
			private static FloatIntBytesUnion FromInt(int value); // 0x00000001804259C0-0x0000000180425D40
			private FloatIntBytesUnion Shuffle(int key); // 0x00000001802DB720-0x00000001802DB740
			private FloatIntBytesUnion UnShuffle(int key); // 0x00000001802DB740-0x00000001802DB760
		}
	
		// Constructors
		private ObscuredFloat(float value); // 0x00000001802DD440-0x00000001802DD510
	
		// Methods
		public static int Encrypt(float value, int key); // 0x0000000181BAC760-0x0000000181BAC790
		public static float Decrypt(int value, int key); // 0x0000000181BAC790-0x0000000181BAC7C0
		public static int MigrateEncrypted(int encrypted, byte fromVersion = 0 /* Metadata: 0x007412C2 */, byte toVersion = 2 /* Metadata: 0x007412C3 */); // 0x0000000181BAC730-0x0000000181BAC760
		public static ObscuredFloat FromEncrypted(int encrypted, int key); // 0x0000000181BAF160-0x0000000181BAF1B0
		public static int GenerateKey(); // 0x0000000181BAF200-0x0000000181BAF260
		public int GetEncrypted(out int key); // 0x00000001802DD240-0x00000001802DD250
		public void SetEncrypted(int encrypted, int key); // 0x00000001802DD300-0x00000001802DD340
		public float GetDecrypted(); // 0x00000001802DD230-0x00000001802DD240
		public void RandomizeCryptoKey(); // 0x00000001802DD2A0-0x00000001802DD300
		private float InternalDecrypt(); // 0x00000001802DD290-0x00000001802DD2A0
		public static implicit operator ObscuredFloat(float value); // 0x0000000181BAF4F0-0x0000000181BAF570
		public static implicit operator float(ObscuredFloat value); // 0x0000000181BAF4E0-0x0000000181BAF4F0
		public static ObscuredFloat operator ++(ObscuredFloat input); // 0x0000000181BAF570-0x0000000181BAF650
		public static ObscuredFloat operator --(ObscuredFloat input); // 0x0000000181BAF440-0x0000000181BAF4E0
		private static ObscuredFloat Increment(ObscuredFloat input, int increment); // 0x0000000181BAF260-0x0000000181BAF440
		public override int GetHashCode(); // 0x00000001802DD260-0x00000001802DD290
		public override string ToString(); // 0x00000001802DD3D0-0x00000001802DD400
		public string ToString(string format); // 0x00000001802DD400-0x00000001802DD440
		public string ToString(IFormatProvider provider); // 0x00000001802DD390-0x00000001802DD3D0
		public string ToString(string format, IFormatProvider provider); // 0x00000001802DD340-0x00000001802DD390
		public override bool Equals(object obj); // 0x00000001802DD100-0x00000001802DD1D0
		public bool Equals(ObscuredFloat obj); // 0x00000001802DD1D0-0x00000001802DD230
		public int CompareTo(ObscuredFloat other); // 0x00000001802DD060-0x00000001802DD0C0
		public int CompareTo(float other); // 0x00000001802DD0C0-0x00000001802DD100
		public int CompareTo(object obj); // 0x00000001802DD020-0x00000001802DD060
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(int newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D3EC0-0x00000001800D3EF0
		public static int Encrypt(float value); // 0x0000000181BAF110-0x0000000181BAF160
		[Obsolete] // 0x00000001800D41F0-0x00000001800D4220
		public static float Decrypt(int value); // 0x0000000181BAF0C0-0x0000000181BAF110
		[Obsolete] // 0x00000001800D43F0-0x00000001800D4420
		public static ObscuredFloat FromEncrypted(int encrypted); // 0x0000000181BAF1B0-0x0000000181BAF200
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public int GetEncrypted(); // 0x00000001802DD250-0x00000001802DD260
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(int encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
