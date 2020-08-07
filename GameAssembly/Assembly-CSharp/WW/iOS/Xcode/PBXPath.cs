/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.iOS.Xcode
{
	internal class PBXPath // TypeDefIndex: 16132
	{
		// Constructors
		public PBXPath(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static string FixSlashes(string path); // 0x00000001814B7420-0x00000001814B7440
		public static void Combine(string path1, PBXSourceTree tree1, string path2, PBXSourceTree tree2, out string resPath, out PBXSourceTree resTree); // 0x00000001814B72D0-0x00000001814B7320
		public static string Combine(string path1, string path2); // 0x00000001814B7320-0x00000001814B7420
		public static string GetDirectory(string path); // 0x00000001814B7540-0x00000001814B7610
		public static string GetCurrentDirectory(); // 0x00000001814B7440-0x00000001814B7540
		public static string GetFilename(string path); // 0x00000001814B7610-0x00000001814B7660
		public static bool IsPathRooted(string path); // 0x00000001814B77A0-0x00000001814B77D0
		public static string GetFullPath(string path); // 0x00000001814B7660-0x00000001814B77A0
		public static string[] Split(string path); // 0x00000001814B77D0-0x00000001814B7880
	}
}
