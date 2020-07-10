/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredUShort : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort>, IComparable<ushort>, IComparable // TypeDefIndex: 7195
	{
		// Fields
		private ushort currentCryptoKey; // 0x00
		private ushort hiddenValue; // 0x02
		private bool inited; // 0x04
		private ushort fakeValue; // 0x06
		private bool fakeValueActive; // 0x08
	
		// Constructors
		private ObscuredUShort(ushort value); // 0x00000001802DF900-0x00000001802DF950
	
		// Methods
		public static ushort Encrypt(ushort value, ushort key); // 0x0000000181BAD400-0x0000000181BAD410
		public static ushort Decrypt(ushort value, ushort key); // 0x0000000181BAD400-0x0000000181BAD410
		public static ObscuredUShort FromEncrypted(ushort encrypted, ushort key); // 0x0000000181BB3D60-0x0000000181BB3DB0
		public static ushort GenerateKey(); // 0x0000000181BB3E00-0x0000000181BB3E60
		public ushort GetEncrypted(out ushort key); // 0x00000001802DC3C0-0x00000001802DC3D0
		public void SetEncrypted(ushort encrypted, ushort key); // 0x00000001802DF7C0-0x00000001802DF800
		public ushort GetDecrypted(); // 0x00000001802DF720-0x00000001802DF730
		public void RandomizeCryptoKey(); // 0x00000001802DF780-0x00000001802DF7C0
		private ushort InternalDecrypt(); // 0x00000001802DF770-0x00000001802DF780
		public static implicit operator ObscuredUShort(ushort value); // 0x0000000181BB40A0-0x0000000181BB4100
		public static implicit operator ushort(ObscuredUShort value); // 0x0000000181BB4100-0x0000000181BB4110
		public static ObscuredUShort operator ++(ObscuredUShort input); // 0x0000000181BB4110-0x0000000181BB4220
		public static ObscuredUShort operator --(ObscuredUShort input); // 0x0000000181BB3F90-0x0000000181BB40A0
		private static ObscuredUShort Increment(ObscuredUShort input, int increment); // 0x0000000181BB3E60-0x0000000181BB3F90
		public override int GetHashCode(); // 0x00000001802DF740-0x00000001802DF770
		public override string ToString(); // 0x00000001802DF8D0-0x00000001802DF900
		public string ToString(string format); // 0x00000001802DF850-0x00000001802DF890
		public string ToString(IFormatProvider provider); // 0x00000001802DF890-0x00000001802DF8D0
		public string ToString(string format, IFormatProvider provider); // 0x00000001802DF800-0x00000001802DF850
		public override bool Equals(object obj); // 0x00000001802DF610-0x00000001802DF720
		public bool Equals(ObscuredUShort obj); // 0x00000001802DC220-0x00000001802DC2A0
		public int CompareTo(ObscuredUShort other); // 0x00000001802DF510-0x00000001802DF5D0
		public int CompareTo(ushort other); // 0x00000001802DF5D0-0x00000001802DF610
		public int CompareTo(object obj); // 0x00000001802DF4D0-0x00000001802DF510
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(ushort newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D4DC0-0x00000001800D4DF0
		public static ushort EncryptDecrypt(ushort value); // 0x0000000181BB3D10-0x0000000181BB3D60
		[Obsolete] // 0x00000001800D5120-0x00000001800D5150
		public static ushort EncryptDecrypt(ushort value, ushort key); // 0x0000000181BAD400-0x0000000181BAD410
		[Obsolete] // 0x00000001800D43F0-0x00000001800D4420
		public static ObscuredUShort FromEncrypted(ushort encrypted); // 0x0000000181BB3DB0-0x0000000181BB3E00
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public ushort GetEncrypted(); // 0x00000001802DF730-0x00000001802DF740
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(ushort encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
