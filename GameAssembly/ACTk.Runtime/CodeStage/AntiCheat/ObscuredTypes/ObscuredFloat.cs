/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.Serialization;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredFloat : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredFloat>, IComparable<float>, IComparable // TypeDefIndex: 7350
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int hiddenValue; // 0x04
		[FormerlySerializedAs] // 0x0000000180238F50-0x0000000180238F90
		[SerializeField] // 0x0000000180238F50-0x0000000180238F90
		private ACTkByte4 hiddenValueOldByte4; // 0x08
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x0C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float fakeValue; // 0x10
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValueActive; // 0x14
	
		// Nested types
		internal struct FloatIntBytesUnion // TypeDefIndex: 7351
		{
			// Fields
			internal float f; // 0x00
			internal int i; // 0x00
			internal ACTkByte4 b4; // 0x00
	
			// Methods
			public static int Migrate(int value, byte fromVersion, byte toVersion); // 0x000000018187DFE0-0x000000018187E010
			internal static int XorFloatToInt(float value, int key); // 0x000000018187E010-0x000000018187E040
			internal static float XorIntToFloat(int value, int key); // 0x000000018187E040-0x000000018187E070
			private static FloatIntBytesUnion FromFloat(float value); // 0x0000000180B6AFA0-0x0000000180B6AFB0
			private static FloatIntBytesUnion FromInt(int value); // 0x0000000180831220-0x0000000180831570
			private FloatIntBytesUnion Shuffle(int key); // 0x00000001800F04F0-0x00000001800F0510
			private FloatIntBytesUnion UnShuffle(int key); // 0x00000001800F0510-0x00000001800F0530
		}
	
		// Constructors
		private ObscuredFloat(float value); // 0x00000001800F2210-0x00000001800F22E0
	
		// Methods
		public static int Encrypt(float value, int key); // 0x000000018187E010-0x000000018187E040
		public static float Decrypt(int value, int key); // 0x000000018187E040-0x000000018187E070
		public static int MigrateEncrypted(int encrypted, byte fromVersion = 0 /* Metadata: 0x00775FB0 */, byte toVersion = 2 /* Metadata: 0x00775FB1 */); // 0x000000018187DFE0-0x000000018187E010
		public static ObscuredFloat FromEncrypted(int encrypted, int key); // 0x00000001818809D0-0x0000000181880A20
		public static int GenerateKey(); // 0x0000000181880A70-0x0000000181880AD0
		public int GetEncrypted(out int key); // 0x00000001800F2010-0x00000001800F2020
		public void SetEncrypted(int encrypted, int key); // 0x00000001800F20D0-0x00000001800F2110
		public float GetDecrypted(); // 0x00000001800F2000-0x00000001800F2010
		public void RandomizeCryptoKey(); // 0x00000001800F2070-0x00000001800F20D0
		private float InternalDecrypt(); // 0x00000001800F2060-0x00000001800F2070
		public static implicit operator ObscuredFloat(float value); // 0x0000000181880D60-0x0000000181880DE0
		public static implicit operator float(ObscuredFloat value); // 0x0000000181880D50-0x0000000181880D60
		public static ObscuredFloat operator ++(ObscuredFloat input); // 0x0000000181880DE0-0x0000000181880EC0
		public static ObscuredFloat operator --(ObscuredFloat input); // 0x0000000181880CB0-0x0000000181880D50
		private static ObscuredFloat Increment(ObscuredFloat input, int increment); // 0x0000000181880AD0-0x0000000181880CB0
		public override int GetHashCode(); // 0x00000001800F2030-0x00000001800F2060
		public override string ToString(); // 0x00000001800F21A0-0x00000001800F21D0
		public string ToString(string format); // 0x00000001800F21D0-0x00000001800F2210
		public string ToString(IFormatProvider provider); // 0x00000001800F2160-0x00000001800F21A0
		public string ToString(string format, IFormatProvider provider); // 0x00000001800F2110-0x00000001800F2160
		public override bool Equals(object obj); // 0x00000001800F1ED0-0x00000001800F1FA0
		public bool Equals(ObscuredFloat obj); // 0x00000001800F1FA0-0x00000001800F2000
		public int CompareTo(ObscuredFloat other); // 0x00000001800F1E30-0x00000001800F1E90
		public int CompareTo(float other); // 0x00000001800F1E90-0x00000001800F1ED0
		public int CompareTo(object obj); // 0x00000001800F1DF0-0x00000001800F1E30
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(int newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180234A80-0x0000000180234AB0
		public static int Encrypt(float value); // 0x0000000181880980-0x00000001818809D0
		[Obsolete] // 0x0000000180234BB0-0x0000000180234BE0
		public static float Decrypt(int value); // 0x0000000181880930-0x0000000181880980
		[Obsolete] // 0x0000000180234D70-0x0000000180234DA0
		public static ObscuredFloat FromEncrypted(int encrypted); // 0x0000000181880A20-0x0000000181880A70
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public int GetEncrypted(); // 0x00000001800F2020-0x00000001800F2030
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(int encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
