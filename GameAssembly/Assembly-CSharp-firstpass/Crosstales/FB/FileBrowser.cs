/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crosstales.FB.Wrapper;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.FB
{
	public static class FileBrowser // TypeDefIndex: 9709
	{
		// Fields
		private static readonly IFileBrowser platformWrapper; // 0x00
	
		// Properties
		public static bool canOpenMultipleFiles { get; } // 0x0000000181088300-0x0000000181088370 
		public static bool canOpenMultipleFolders { get; } // 0x0000000181088370-0x00000001810883F0 
		public static bool isPlatformSupported { get; } // 0x00000001810883F0-0x0000000181088470 
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 9710
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<ExtensionFilter, IEnumerable<string>> <>9__30_0; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018108D550-0x000000018108D5B0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal IEnumerable<string> <GetFiles>b__30_0(ExtensionFilter extensionFilter); // 0x000000018108D120-0x000000018108D130
		}
	
		// Constructors
		static FileBrowser(); // 0x0000000181087E20-0x0000000181087F60
	
		// Methods
		public static string OpenSingleFile(string extension = "*" /* Metadata: 0x0077A31E */); // 0x00000001810873D0-0x0000000181087500
		public static string OpenSingleFile(string title, string directory, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] extensions); // 0x0000000181087240-0x00000001810872C0
		public static string OpenSingleFile(string title, string directory, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ ExtensionFilter[] extensions); // 0x00000001810872C0-0x00000001810873D0
		public static string[] OpenFiles(string extension = "*" /* Metadata: 0x0077A323 */); // 0x0000000181086BE0-0x0000000181086D10
		public static string[] OpenFiles(string title, string directory, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] extensions); // 0x0000000181086A50-0x0000000181086AD0
		public static string[] OpenFiles(string title, string directory, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ ExtensionFilter[] extensions); // 0x0000000181086AD0-0x0000000181086BE0
		public static string OpenSingleFolder(); // 0x0000000181087600-0x0000000181087770
		public static string OpenSingleFolder(string title, string directory = "" /* Metadata: 0x0077A328 */); // 0x0000000181087500-0x0000000181087600
		public static string[] OpenFolders(); // 0x00000001810870D0-0x0000000181087240
		public static string[] OpenFolders(string title, string directory = "" /* Metadata: 0x0077A32C */); // 0x0000000181086FD0-0x00000001810870D0
		public static string SaveFile(string defaultName = "" /* Metadata: 0x0077A330 */, string extension = "*" /* Metadata: 0x0077A334 */); // 0x0000000181087CD0-0x0000000181087E20
		public static string SaveFile(string title, string directory, string defaultName, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] extensions); // 0x0000000181087C30-0x0000000181087CD0
		public static string SaveFile(string title, string directory, string defaultName, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ ExtensionFilter[] extensions); // 0x0000000181087AD0-0x0000000181087C30
		public static void OpenFilesAsync(Action<string[]> cb, bool multiselect = true /* Metadata: 0x0077A339 */, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] extensions); // 0x0000000181086930-0x0000000181086A50
		public static void OpenFilesAsync(Action<string[]> cb, string title, string directory, bool multiselect = true /* Metadata: 0x0077A33A */, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] extensions); // 0x0000000181086890-0x0000000181086930
		public static void OpenFilesAsync(Action<string[]> cb, string title, string directory, bool multiselect = true /* Metadata: 0x0077A33B */, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ ExtensionFilter[] extensions); // 0x0000000181086760-0x0000000181086890
		public static void OpenFoldersAsync(Action<string[]> cb, bool multiselect = true /* Metadata: 0x0077A33C */); // 0x0000000181086D10-0x0000000181086EB0
		public static void OpenFoldersAsync(Action<string[]> cb, string title, string directory = "" /* Metadata: 0x0077A33D */, bool multiselect = true /* Metadata: 0x0077A341 */); // 0x0000000181086EB0-0x0000000181086FD0
		public static void SaveFileAsync(Action<string> cb, string defaultName = "" /* Metadata: 0x0077A342 */, string extension = "*" /* Metadata: 0x0077A346 */); // 0x0000000181087770-0x00000001810878C0
		public static void SaveFileAsync(Action<string> cb, string title, string directory, string defaultName, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] extensions); // 0x00000001810878C0-0x0000000181087960
		public static void SaveFileAsync(Action<string> cb, string title, string directory, string defaultName, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ ExtensionFilter[] extensions); // 0x0000000181087960-0x0000000181087AD0
		public static string[] GetFiles(string path, bool isRecursive = false /* Metadata: 0x0077A34B */, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] extensions); // 0x0000000181086560-0x00000001810865E0
		public static string[] GetFiles(string path, bool isRecursive, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ ExtensionFilter[] extensions); // 0x00000001810865E0-0x0000000181086760
		public static string[] GetDirectories(string path, bool isRecursive = false /* Metadata: 0x0077A34C */); // 0x00000001810864F0-0x0000000181086560
		private static ExtensionFilter[] getFilter(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] extensions); // 0x0000000181087F60-0x0000000181088300
	}
}
