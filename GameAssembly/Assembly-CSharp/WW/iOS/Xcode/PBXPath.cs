/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.iOS.Xcode
{
	internal class PBXPath // TypeDefIndex: 15752
	{
		// Constructors
		public PBXPath(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static string FixSlashes(string path); // 0x00000001816811F0-0x0000000181681210
		public static void Combine(string path1, PBXSourceTree tree1, string path2, PBXSourceTree tree2, out string resPath, out PBXSourceTree resTree); // 0x00000001816810A0-0x00000001816810F0
		public static string Combine(string path1, string path2); // 0x00000001816810F0-0x00000001816811F0
		public static string GetDirectory(string path); // 0x0000000181681320-0x0000000181681400
		public static string GetCurrentDirectory(); // 0x0000000181681210-0x0000000181681320
		public static string GetFilename(string path); // 0x0000000181681400-0x0000000181681450
		public static bool IsPathRooted(string path); // 0x0000000181681590-0x00000001816815C0
		public static string GetFullPath(string path); // 0x0000000181681450-0x0000000181681590
		public static string[] Split(string path); // 0x00000001816815C0-0x0000000181681670
	}
}
