/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.iOS.Xcode;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode.PBX
{
	internal class FileTypeUtils // TypeDefIndex: 16219
	{
		// Fields
		private static readonly Dictionary<string, FileTypeDesc> types; // 0x00
		private static readonly Dictionary<PBXSourceTree, string> sourceTree; // 0x08
		private static readonly Dictionary<string, PBXSourceTree> stringToSourceTreeMap; // 0x10
	
		// Nested types
		internal class FileTypeDesc // TypeDefIndex: 16220
		{
			// Fields
			public string name; // 0x10
			public PBXFileType type; // 0x18
			public bool isExplicit; // 0x1C
	
			// Constructors
			public FileTypeDesc(string typeName, PBXFileType type); // 0x000000018096F480-0x000000018096F4C0
			public FileTypeDesc(string typeName, PBXFileType type, bool isExplicit); // 0x000000018096F430-0x000000018096F480
		}
	
		// Constructors
		public FileTypeUtils(); // 0x0000000180373240-0x0000000180373250
		static FileTypeUtils(); // 0x0000000180970080-0x0000000180970BB0
	
		// Methods
		public static string TrimExtension(string ext); // 0x0000000180970000-0x0000000180970080
		public static bool IsKnownExtension(string ext); // 0x000000018096FDB0-0x000000018096FEA0
		internal static bool IsFileTypeExplicit(string ext); // 0x000000018096FC50-0x000000018096FDB0
		public static PBXFileType GetFileType(string ext, bool isFolderRef); // 0x000000018096F580-0x000000018096F720
		public static string GetTypeName(string ext); // 0x000000018096F720-0x000000018096F890
		public static bool IsBuildableFile(string ext); // 0x000000018096F890-0x000000018096F9F0
		public static bool IsBuildable(string ext, bool isFolderReference); // 0x000000018096F9F0-0x000000018096FC50
		internal static string SourceTreeDesc(PBXSourceTree tree); // 0x000000018096FF80-0x0000000180970000
		internal static PBXSourceTree ParseSourceTree(string tree); // 0x000000018096FEA0-0x000000018096FF80
		internal static List<PBXSourceTree> AllAbsoluteSourceTrees(); // 0x000000018096F4C0-0x000000018096F580
	}
}
