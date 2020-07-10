/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Tar
{
	public class TarHeader : ICloneable // TypeDefIndex: 7540
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
		public string Name { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x0000000180D61BF0-0x0000000180D61C70
		public int UserId { get; set; } // 0x000000018037E420-0x000000018037E430 0x000000018037E600-0x000000018037E610
		public int GroupId { get; set; } // 0x00000001803C2700-0x00000001803C2710 0x00000001804886F0-0x0000000180488700
		public long Size { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180D61C70-0x0000000180D61CF0
		public DateTime ModTime { get; set; } // 0x0000000180397720-0x0000000180397730 0x0000000180D61A60-0x0000000180D61BF0
		public int Checksum { get; } // 0x00000001804999D0-0x00000001804999E0 
		public bool IsChecksumValid { get; } // 0x0000000180736E00-0x0000000180736E10 
		public byte TypeFlag { get; set; } // 0x0000000180D61900-0x0000000180D61910 0x0000000180D61CF0-0x0000000180D61D00
		public string LinkName { get; set; } // 0x0000000180369B30-0x0000000180369B40 0x0000000180D61960-0x0000000180D619E0
		public string Magic { get; set; } // 0x0000000180369C40-0x0000000180369C50 0x0000000180D619E0-0x0000000180D61A60
		public string Version { get; set; } // 0x00000001803A27A0-0x00000001803A27B0 0x0000000180D61DD0-0x0000000180D61E50
		public string UserName { get; set; } // 0x0000000180357120-0x0000000180357130 0x0000000180D61D00-0x0000000180D61DD0
		public string GroupName { get; set; } // 0x0000000180369B40-0x0000000180369B50 0x0000000180D61910-0x0000000180D61960
		public int DevMajor { get; set; } // 0x00000001803DAC60-0x00000001803DAC70 0x00000001803DAE50-0x00000001803DAE60
		public int DevMinor { get; set; } // 0x00000001803DAC70-0x00000001803DAC80 0x00000001803DAE60-0x00000001803DAE70
	
		// Constructors
		public TarHeader(); // 0x0000000180D615E0-0x0000000180D61900
		static TarHeader(); // 0x0000000180D61540-0x0000000180D615E0
	
		// Methods
		public object Clone(); // 0x0000000180781380-0x0000000180781390
		public void ParseBuffer(byte[] header); // 0x0000000180D60AE0-0x0000000180D611E0
		public override int GetHashCode(); // 0x000000018075E590-0x000000018075E5C0
		public override bool Equals(object obj); // 0x0000000180D607B0-0x0000000180D60970
		public static long ParseOctal(byte[] header, int offset, int length); // 0x0000000180D613E0-0x0000000180D61540
		public static StringBuilder ParseName(byte[] header, int offset, int length); // 0x0000000180D611E0-0x0000000180D613E0
		private static int MakeCheckSum(byte[] buffer); // 0x0000000180D60A50-0x0000000180D60AE0
		private static DateTime GetDateTimeFromCTime(long ticks); // 0x0000000180D60970-0x0000000180D60A50
	}
}
