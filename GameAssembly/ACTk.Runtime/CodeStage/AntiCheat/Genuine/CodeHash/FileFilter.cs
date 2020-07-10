/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 56: ACTk.Runtime.dll - Assembly: ACTk.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7165-7238

namespace CodeStage.AntiCheat.Genuine.CodeHash
{
	internal class FileFilter // TypeDefIndex: 7208
	{
		// Fields
		public bool caseSensitive; // 0x10
		public bool folderRecursive; // 0x11
		public bool exactFileNameMatch; // 0x12
		public bool exactFolderMatch; // 0x13
		public string filterPath; // 0x18
		public string filterExtension; // 0x20
		public string filterFileName; // 0x28
	
		// Constructors
		public FileFilter(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public bool MatchesPath(string filePath, string root = null); // 0x0000000181BABFF0-0x0000000181BAC200
		public override string ToString(); // 0x0000000181BAC200-0x0000000181BAC730
	}
}
