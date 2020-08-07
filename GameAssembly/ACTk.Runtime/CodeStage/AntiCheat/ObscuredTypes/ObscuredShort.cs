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
	public struct ObscuredShort : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredShort>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredShort>, IComparable<short>, IComparable // TypeDefIndex: 7357
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private short currentCryptoKey; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private short hiddenValue; // 0x02
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool inited; // 0x04
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private short fakeValue; // 0x06
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool fakeValueActive; // 0x08
	
		// Constructors
		private ObscuredShort(short value); // 0x00000001800F39E0-0x00000001800F3A90
	
		// Methods
		public static short Encrypt(short value, short key); // 0x000000018187EC90-0x000000018187ECA0
		public static short Decrypt(short value, short key); // 0x000000018187EC90-0x000000018187ECA0
		public static ObscuredShort FromEncrypted(short encrypted, short key); // 0x0000000181882F00-0x0000000181882F50
		public static short GenerateKey(); // 0x0000000181882FA0-0x0000000181883000
		public short GetEncrypted(out short key); // 0x00000001800F1190-0x00000001800F11A0
		public void SetEncrypted(short encrypted, short key); // 0x00000001800F38A0-0x00000001800F38E0
		public short GetDecrypted(); // 0x00000001800F3800-0x00000001800F3810
		public void RandomizeCryptoKey(); // 0x00000001800F3860-0x00000001800F38A0
		private short InternalDecrypt(); // 0x00000001800F3850-0x00000001800F3860
		public static implicit operator ObscuredShort(short value); // 0x0000000181883240-0x00000001818832A0
		public static implicit operator short(ObscuredShort value); // 0x0000000181883230-0x0000000181883240
		public static ObscuredShort operator ++(ObscuredShort input); // 0x00000001818832A0-0x00000001818833A0
		public static ObscuredShort operator --(ObscuredShort input); // 0x0000000181883130-0x0000000181883230
		private static ObscuredShort Increment(ObscuredShort input, int increment); // 0x0000000181883000-0x0000000181883130
		public override int GetHashCode(); // 0x00000001800F3820-0x00000001800F3850
		public override string ToString(); // 0x00000001800F3970-0x00000001800F39A0
		public string ToString(string format); // 0x00000001800F39A0-0x00000001800F39E0
		public string ToString(IFormatProvider provider); // 0x00000001800F38E0-0x00000001800F3920
		public string ToString(string format, IFormatProvider provider); // 0x00000001800F3920-0x00000001800F3970
		public override bool Equals(object obj); // 0x00000001800F36F0-0x00000001800F3800
		public bool Equals(ObscuredShort obj); // 0x00000001800F0FF0-0x00000001800F1070
		public int CompareTo(ObscuredShort other); // 0x00000001800F35B0-0x00000001800F3670
		public int CompareTo(short other); // 0x00000001800F3670-0x00000001800F36B0
		public int CompareTo(object obj); // 0x00000001800F36B0-0x00000001800F36F0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(short newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180235560-0x0000000180235590
		public static short EncryptDecrypt(short value); // 0x0000000181882EB0-0x0000000181882F00
		[Obsolete] // 0x0000000180235940-0x0000000180235970
		public static short EncryptDecrypt(short value, short key); // 0x000000018187EC90-0x000000018187ECA0
		[Obsolete] // 0x0000000180234D70-0x0000000180234DA0
		public static ObscuredShort FromEncrypted(short encrypted); // 0x0000000181882F50-0x0000000181882FA0
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public short GetEncrypted(); // 0x00000001800F3810-0x00000001800F3820
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(short encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
