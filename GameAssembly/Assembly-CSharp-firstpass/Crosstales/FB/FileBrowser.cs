/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crosstales.FB.Wrapper;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.FB
{
	public static class FileBrowser // TypeDefIndex: 9923
	{
		// Fields
		private static readonly IFileBrowser platformWrapper; // 0x00
	
		// Properties
		public static bool canOpenMultipleFiles { get; } // 0x00000001815E87F0-0x00000001815E8860 
		public static bool canOpenMultipleFolders { get; } // 0x00000001815E8860-0x00000001815E88E0 
		public static bool isPlatformSupported { get; } // 0x00000001815E88E0-0x00000001815E8960 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 9924
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ExtensionFilter, IEnumerable<string>> <>9__30_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001815ED8F0-0x00000001815ED950
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal IEnumerable<string> <GetFiles>b__30_0(ExtensionFilter extensionFilter); // 0x00000001815ED4C0-0x00000001815ED4D0
		}
	
		// Constructors
		static FileBrowser(); // 0x00000001815E82F0-0x00000001815E8430
	
		// Methods
		public static string OpenSingleFile(string extension = "*" /* Metadata: 0x00746053 */); // 0x00000001815E78A0-0x00000001815E79D0
		public static string OpenSingleFile(string title, string directory, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] extensions); // 0x00000001815E7710-0x00000001815E7790
		public static string OpenSingleFile(string title, string directory, params /* 0x00000001800B36B0-0x00000001800B36C0 */ ExtensionFilter[] extensions); // 0x00000001815E7790-0x00000001815E78A0
		public static string[] OpenFiles(string extension = "*" /* Metadata: 0x00746058 */); // 0x00000001815E70A0-0x00000001815E71D0
		public static string[] OpenFiles(string title, string directory, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] extensions); // 0x00000001815E6F10-0x00000001815E6F90
		public static string[] OpenFiles(string title, string directory, params /* 0x00000001800B36B0-0x00000001800B36C0 */ ExtensionFilter[] extensions); // 0x00000001815E6F90-0x00000001815E70A0
		public static string OpenSingleFolder(); // 0x00000001815E7AD0-0x00000001815E7C40
		public static string OpenSingleFolder(string title, string directory = "" /* Metadata: 0x0074605D */); // 0x00000001815E79D0-0x00000001815E7AD0
		public static string[] OpenFolders(); // 0x00000001815E7590-0x00000001815E7710
		public static string[] OpenFolders(string title, string directory = "" /* Metadata: 0x00746061 */); // 0x00000001815E7490-0x00000001815E7590
		public static string SaveFile(string defaultName = "" /* Metadata: 0x00746065 */, string extension = "*" /* Metadata: 0x00746069 */); // 0x00000001815E81A0-0x00000001815E82F0
		public static string SaveFile(string title, string directory, string defaultName, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] extensions); // 0x00000001815E8100-0x00000001815E81A0
		public static string SaveFile(string title, string directory, string defaultName, params /* 0x00000001800B36B0-0x00000001800B36C0 */ ExtensionFilter[] extensions); // 0x00000001815E7FA0-0x00000001815E8100
		public static void OpenFilesAsync(Action<string[]> cb, bool multiselect = true /* Metadata: 0x0074606E */, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] extensions); // 0x00000001815E6DF0-0x00000001815E6F10
		public static void OpenFilesAsync(Action<string[]> cb, string title, string directory, bool multiselect = true /* Metadata: 0x0074606F */, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] extensions); // 0x00000001815E6D50-0x00000001815E6DF0
		public static void OpenFilesAsync(Action<string[]> cb, string title, string directory, bool multiselect = true /* Metadata: 0x00746070 */, params /* 0x00000001800B36B0-0x00000001800B36C0 */ ExtensionFilter[] extensions); // 0x00000001815E6C20-0x00000001815E6D50
		public static void OpenFoldersAsync(Action<string[]> cb, bool multiselect = true /* Metadata: 0x00746071 */); // 0x00000001815E71D0-0x00000001815E7370
		public static void OpenFoldersAsync(Action<string[]> cb, string title, string directory = "" /* Metadata: 0x00746072 */, bool multiselect = true /* Metadata: 0x00746076 */); // 0x00000001815E7370-0x00000001815E7490
		public static void SaveFileAsync(Action<string> cb, string defaultName = "" /* Metadata: 0x00746077 */, string extension = "*" /* Metadata: 0x0074607B */); // 0x00000001815E7C40-0x00000001815E7D90
		public static void SaveFileAsync(Action<string> cb, string title, string directory, string defaultName, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] extensions); // 0x00000001815E7D90-0x00000001815E7E30
		public static void SaveFileAsync(Action<string> cb, string title, string directory, string defaultName, params /* 0x00000001800B36B0-0x00000001800B36C0 */ ExtensionFilter[] extensions); // 0x00000001815E7E30-0x00000001815E7FA0
		public static string[] GetFiles(string path, bool isRecursive = false /* Metadata: 0x00746080 */, params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] extensions); // 0x00000001815E6A20-0x00000001815E6AA0
		public static string[] GetFiles(string path, bool isRecursive, params /* 0x00000001800B36B0-0x00000001800B36C0 */ ExtensionFilter[] extensions); // 0x00000001815E6AA0-0x00000001815E6C20
		public static string[] GetDirectories(string path, bool isRecursive = false /* Metadata: 0x00746081 */); // 0x00000001815E69B0-0x00000001815E6A20
		private static ExtensionFilter[] getFilter(params /* 0x00000001800B36B0-0x00000001800B36C0 */ string[] extensions); // 0x00000001815E8430-0x00000001815E87F0
	}
}
