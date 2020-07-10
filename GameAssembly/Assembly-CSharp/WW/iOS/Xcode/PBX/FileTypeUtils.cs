/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WW.iOS.Xcode;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode.PBX
{
	internal class FileTypeUtils // TypeDefIndex: 15839
	{
		// Fields
		private static readonly Dictionary<string, FileTypeDesc> types; // 0x00
		private static readonly Dictionary<PBXSourceTree, string> sourceTree; // 0x08
		private static readonly Dictionary<string, PBXSourceTree> stringToSourceTreeMap; // 0x10
	
		// Nested types
		internal class FileTypeDesc // TypeDefIndex: 15840
		{
			// Fields
			public string name; // 0x10
			public PBXFileType type; // 0x18
			public bool isExplicit; // 0x1C
	
			// Constructors
			public FileTypeDesc(string typeName, PBXFileType type); // 0x0000000181675C00-0x0000000181675C40
			public FileTypeDesc(string typeName, PBXFileType type, bool isExplicit); // 0x00000001814AE4A0-0x00000001814AE4F0
		}
	
		// Constructors
		public FileTypeUtils(); // 0x000000018036B6C0-0x000000018036B6D0
		static FileTypeUtils(); // 0x00000001816766F0-0x0000000181677230
	
		// Methods
		public static string TrimExtension(string ext); // 0x0000000181676660-0x00000001816766F0
		public static bool IsKnownExtension(string ext); // 0x0000000181676410-0x0000000181676500
		internal static bool IsFileTypeExplicit(string ext); // 0x00000001816762A0-0x0000000181676410
		public static PBXFileType GetFileType(string ext, bool isFolderRef); // 0x0000000181675D00-0x0000000181675EB0
		public static string GetTypeName(string ext); // 0x0000000181675EB0-0x0000000181676020
		public static bool IsBuildableFile(string ext); // 0x0000000181676020-0x0000000181676190
		public static bool IsBuildable(string ext, bool isFolderReference); // 0x0000000181676190-0x00000001816762A0
		internal static string SourceTreeDesc(PBXSourceTree tree); // 0x00000001816765E0-0x0000000181676660
		internal static PBXSourceTree ParseSourceTree(string tree); // 0x0000000181676500-0x00000001816765E0
		internal static List<PBXSourceTree> AllAbsoluteSourceTrees(); // 0x0000000181675C40-0x0000000181675D00
	}
}
