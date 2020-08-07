/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Tar
{
	public class TarHeader : ICloneable // TypeDefIndex: 7706
	{
		// Fields
		private static readonly DateTime dateTime1970; // 0x00
		private string name; // 0x10
		private int mode; // 0x18
		private int userId; // 0x1C
		private int groupId; // 0x20
		private long size; // 0x28
		private DateTime modTime; // 0x30
		private int checksum; // 0x38
		private bool isChecksumValid; // 0x3C
		private byte typeFlag; // 0x3D
		private string linkName; // 0x40
		private string magic; // 0x48
		private string version; // 0x50
		private string userName; // 0x58
		private string groupName; // 0x60
		private int devMajor; // 0x68
		private int devMinor; // 0x6C
		internal static string groupNameAsSet; // 0x08
		internal static int defaultUserId; // 0x10
		internal static int defaultGroupId; // 0x14
		internal static string defaultGroupName; // 0x18
		internal static string defaultUser; // 0x20
	
		// Properties
		public string Name { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000181EA9230-0x0000000181EA92A0
		public int UserId { get; set; } // 0x00000001803FB770-0x00000001803FB780 0x000000018042D0F0-0x000000018042D100
		public int GroupId { get; set; } // 0x00000001803FB670-0x00000001803FB680 0x00000001804556D0-0x00000001804556E0
		public long Size { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x0000000181EA92A0-0x0000000181EA9320
		public DateTime ModTime { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x0000000181EA90A0-0x0000000181EA9230
		public int Checksum { get; } // 0x000000018057D1C0-0x000000018057D1D0 
		public bool IsChecksumValid { get; } // 0x00000001804F1630-0x00000001804F1640 
		public byte TypeFlag { get; set; } // 0x00000001804F1620-0x00000001804F1630 0x00000001804F1670-0x00000001804F1680
		public string LinkName { get; set; } // 0x00000001803C7290-0x00000001803C72A0 0x0000000181EA8FC0-0x0000000181EA9030
		public string Magic { get; set; } // 0x00000001803743E0-0x00000001803743F0 0x0000000181EA9030-0x0000000181EA90A0
		public string Version { get; set; } // 0x0000000180378320-0x0000000180378330 0x0000000181EA93E0-0x0000000181EA9450
		public string UserName { get; set; } // 0x00000001803A1580-0x00000001803A1590 0x0000000181EA9320-0x0000000181EA93E0
		public string GroupName { get; set; } // 0x0000000180418970-0x0000000180418980 0x0000000181EA8F70-0x0000000181EA8FC0
		public int DevMajor { get; set; } // 0x00000001806F4980-0x00000001806F4990 0x00000001806F4B40-0x00000001806F4B50
		public int DevMinor { get; set; } // 0x00000001806F4990-0x00000001806F49A0 0x00000001806F4B50-0x00000001806F4B60
	
		// Constructors
		public TarHeader(); // 0x0000000181EA8C50-0x0000000181EA8F70
		static TarHeader(); // 0x0000000181EA8BB0-0x0000000181EA8C50
	
		// Methods
		public object Clone(); // 0x0000000180A14990-0x0000000180A149A0
		public void ParseBuffer(byte[] header); // 0x0000000181EA81A0-0x0000000181EA8880
		public override int GetHashCode(); // 0x000000018076A540-0x000000018076A570
		public override bool Equals(object obj); // 0x0000000181EA7E70-0x0000000181EA8030
		public static long ParseOctal(byte[] header, int offset, int length); // 0x0000000181EA8A70-0x0000000181EA8BB0
		public static StringBuilder ParseName(byte[] header, int offset, int length); // 0x0000000181EA8880-0x0000000181EA8A70
		private static int MakeCheckSum(byte[] buffer); // 0x0000000181EA8110-0x0000000181EA81A0
		private static DateTime GetDateTimeFromCTime(long ticks); // 0x0000000181EA8030-0x0000000181EA8110
	}
}
