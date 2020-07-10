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
	public struct ObscuredShort : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredShort>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredShort>, IComparable<short>, IComparable // TypeDefIndex: 7191
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private short currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private short hiddenValue; // 0x02
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool inited; // 0x04
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private short fakeValue; // 0x06
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool fakeValueActive; // 0x08
	
		// Constructors
		private ObscuredShort(short value); // 0x00000001802DEC10-0x00000001802DECC0
	
		// Methods
		public static short Encrypt(short value, short key); // 0x0000000181BAD400-0x0000000181BAD410
		public static short Decrypt(short value, short key); // 0x0000000181BAD400-0x0000000181BAD410
		public static ObscuredShort FromEncrypted(short encrypted, short key); // 0x0000000181BB16A0-0x0000000181BB16F0
		public static short GenerateKey(); // 0x0000000181BB1740-0x0000000181BB17A0
		public short GetEncrypted(out short key); // 0x00000001802DC3C0-0x00000001802DC3D0
		public void SetEncrypted(short encrypted, short key); // 0x00000001802DEAD0-0x00000001802DEB10
		public short GetDecrypted(); // 0x00000001802DEA30-0x00000001802DEA40
		public void RandomizeCryptoKey(); // 0x00000001802DEA90-0x00000001802DEAD0
		private short InternalDecrypt(); // 0x00000001802DEA80-0x00000001802DEA90
		public static implicit operator ObscuredShort(short value); // 0x0000000181BB19F0-0x0000000181BB1A50
		public static implicit operator short(ObscuredShort value); // 0x0000000181BB19E0-0x0000000181BB19F0
		public static ObscuredShort operator ++(ObscuredShort input); // 0x0000000181BB1A50-0x0000000181BB1B60
		public static ObscuredShort operator --(ObscuredShort input); // 0x0000000181BB18D0-0x0000000181BB19E0
		private static ObscuredShort Increment(ObscuredShort input, int increment); // 0x0000000181BB17A0-0x0000000181BB18D0
		public override int GetHashCode(); // 0x00000001802DEA50-0x00000001802DEA80
		public override string ToString(); // 0x00000001802DEBA0-0x00000001802DEBD0
		public string ToString(string format); // 0x00000001802DEBD0-0x00000001802DEC10
		public string ToString(IFormatProvider provider); // 0x00000001802DEB10-0x00000001802DEB50
		public string ToString(string format, IFormatProvider provider); // 0x00000001802DEB50-0x00000001802DEBA0
		public override bool Equals(object obj); // 0x00000001802DE920-0x00000001802DEA30
		public bool Equals(ObscuredShort obj); // 0x00000001802DC220-0x00000001802DC2A0
		public int CompareTo(ObscuredShort other); // 0x00000001802DE7E0-0x00000001802DE8A0
		public int CompareTo(short other); // 0x00000001802DE8A0-0x00000001802DE8E0
		public int CompareTo(object obj); // 0x00000001802DE8E0-0x00000001802DE920
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public static void SetNewCryptoKey(short newKey); // 0x00000001803581E0-0x00000001803581F0
		[Obsolete] // 0x00000001800D39F0-0x00000001800D3A20
		public void ApplyNewCryptoKey(); // 0x0000000180003310-0x0000000180003870
		[Obsolete] // 0x00000001800D4DC0-0x00000001800D4DF0
		public static short EncryptDecrypt(short value); // 0x0000000181BB1650-0x0000000181BB16A0
		[Obsolete] // 0x00000001800D5120-0x00000001800D5150
		public static short EncryptDecrypt(short value, short key); // 0x0000000181BAD400-0x0000000181BAD410
		[Obsolete] // 0x00000001800D43F0-0x00000001800D4420
		public static ObscuredShort FromEncrypted(short encrypted); // 0x0000000181BB16F0-0x0000000181BB1740
		[Obsolete] // 0x00000001800D4620-0x00000001800D4650
		public short GetEncrypted(); // 0x00000001802DEA40-0x00000001802DEA50
		[Obsolete] // 0x00000001800D47C0-0x00000001800D47F0
		public void SetEncrypted(short encrypted); // 0x0000000180003310-0x0000000180003870
	}
}
