/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 57: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7331-7404

namespace CodeStage.AntiCheat.ObscuredTypes
{
	[Serializable]
	public struct ObscuredUShort : IObscuredType, IFormattable, IEquatable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort>, IComparable<CodeStage.AntiCheat.ObscuredTypes.ObscuredUShort>, IComparable<ushort>, IComparable // TypeDefIndex: 7361
	{
		// Fields
		private ushort currentCryptoKey; // 0x00
		private ushort hiddenValue; // 0x02
		private bool inited; // 0x04
		private ushort fakeValue; // 0x06
		private bool fakeValueActive; // 0x08
	
		// Constructors
		private ObscuredUShort(ushort value); // 0x00000001800F46D0-0x00000001800F4720
	
		// Methods
		public static ushort Encrypt(ushort value, ushort key); // 0x000000018187EC90-0x000000018187ECA0
		public static ushort Decrypt(ushort value, ushort key); // 0x000000018187EC90-0x000000018187ECA0
		public static ObscuredUShort FromEncrypted(ushort encrypted, ushort key); // 0x0000000181885560-0x00000001818855B0
		public static ushort GenerateKey(); // 0x0000000181885600-0x0000000181885660
		public ushort GetEncrypted(out ushort key); // 0x00000001800F1190-0x00000001800F11A0
		public void SetEncrypted(ushort encrypted, ushort key); // 0x00000001800F4590-0x00000001800F45D0
		public ushort GetDecrypted(); // 0x00000001800F44F0-0x00000001800F4500
		public void RandomizeCryptoKey(); // 0x00000001800F4550-0x00000001800F4590
		private ushort InternalDecrypt(); // 0x00000001800F4540-0x00000001800F4550
		public static implicit operator ObscuredUShort(ushort value); // 0x0000000181885890-0x00000001818858F0
		public static implicit operator ushort(ObscuredUShort value); // 0x00000001818858F0-0x0000000181885900
		public static ObscuredUShort operator ++(ObscuredUShort input); // 0x0000000181885900-0x0000000181885A00
		public static ObscuredUShort operator --(ObscuredUShort input); // 0x0000000181885790-0x0000000181885890
		private static ObscuredUShort Increment(ObscuredUShort input, int increment); // 0x0000000181885660-0x0000000181885790
		public override int GetHashCode(); // 0x00000001800F4510-0x00000001800F4540
		public override string ToString(); // 0x00000001800F46A0-0x00000001800F46D0
		public string ToString(string format); // 0x00000001800F4620-0x00000001800F4660
		public string ToString(IFormatProvider provider); // 0x00000001800F4660-0x00000001800F46A0
		public string ToString(string format, IFormatProvider provider); // 0x00000001800F45D0-0x00000001800F4620
		public override bool Equals(object obj); // 0x00000001800F43E0-0x00000001800F44F0
		public bool Equals(ObscuredUShort obj); // 0x00000001800F0FF0-0x00000001800F1070
		public int CompareTo(ObscuredUShort other); // 0x00000001800F42E0-0x00000001800F43A0
		public int CompareTo(ushort other); // 0x00000001800F43A0-0x00000001800F43E0
		public int CompareTo(object obj); // 0x00000001800F42A0-0x00000001800F42E0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public static void SetNewCryptoKey(ushort newKey); // 0x00000001803774A0-0x00000001803774B0
		[Obsolete] // 0x0000000180234750-0x0000000180234780
		public void ApplyNewCryptoKey(); // 0x0000000180003FD0-0x00000001800045A0
		[Obsolete] // 0x0000000180235560-0x0000000180235590
		public static ushort EncryptDecrypt(ushort value); // 0x0000000181885510-0x0000000181885560
		[Obsolete] // 0x0000000180235940-0x0000000180235970
		public static ushort EncryptDecrypt(ushort value, ushort key); // 0x000000018187EC90-0x000000018187ECA0
		[Obsolete] // 0x0000000180234D70-0x0000000180234DA0
		public static ObscuredUShort FromEncrypted(ushort encrypted); // 0x00000001818855B0-0x0000000181885600
		[Obsolete] // 0x0000000180234EA0-0x0000000180234ED0
		public ushort GetEncrypted(); // 0x00000001800F4500-0x00000001800F4510
		[Obsolete] // 0x0000000180234FE0-0x0000000180235010
		public void SetEncrypted(ushort encrypted); // 0x0000000180003FD0-0x00000001800045A0
	}
}
