/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using Crosstales.FB;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.FB.Wrapper
{
	public class FileBrowserWindows : FileBrowserBase // TypeDefIndex: 9928
	{
		// Fields
		private static string _initialPath; // 0x00
		private const int OFN_NOCHANGEDIR = 8; // Metadata: 0x00746082
		private const int OFN_ALLOWMULTISELECT = 512; // Metadata: 0x00746086
		private const int OFN_EXPLORER = 524288; // Metadata: 0x0074608A
		private const int OFN_FILEMUSTEXIST = 4096; // Metadata: 0x0074608E
		private const int OFN_PATHMUSTEXIST = 2048; // Metadata: 0x00746092
		private const int OFN_OVERWRITEPROMPT = 2; // Metadata: 0x00746096
		private const int MAX_OPEN_FILE_LENGTH = 65536; // Metadata: 0x0074609A
		private const int MAX_SAVE_FILE_LENGTH = 4096; // Metadata: 0x0074609E
		private const int MAX_PATH_LENGTH = 4096; // Metadata: 0x007460A2
		private const int WM_USER = 1024; // Metadata: 0x007460A6
		private const int BFFM_INITIALIZED = 1; // Metadata: 0x007460AA
		private const int BFFM_SELCHANGED = 2; // Metadata: 0x007460AE
		private const int BFFM_SETSELECTIONW = 1127; // Metadata: 0x007460B2
		private const int BFFM_SETSTATUSTEXTW = 1128; // Metadata: 0x007460B6
		private const uint BIF_NEWDIALOGSTYLE = 64; // Metadata: 0x007460BA
		private const uint BIF_SHAREABLE = 32768; // Metadata: 0x007460BE
		private static readonly IntPtr currentWindow; // 0x08
		private static readonly char[] nullChar; // 0x10
	
		// Properties
		public override bool canOpenMultipleFiles { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		public override bool canOpenMultipleFolders { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public override bool isPlatformSupported { get; } // 0x00000001815E6150-0x00000001815E61A0 
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass28_0 // TypeDefIndex: 9929
		{
			// Fields
			public Action<string[]> cb; // 0x10
			public FileBrowserWindows <>4__this; // 0x18
			public string title; // 0x20
			public string directory; // 0x28
			public ExtensionFilter[] extensions; // 0x30
			public bool multiselect; // 0x38
	
			// Constructors
			public <>c__DisplayClass28_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <OpenFilesAsync>b__0(); // 0x00000001815ED670-0x00000001815ED700
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 9930
		{
			// Fields
			public Action<string[]> cb; // 0x10
			public FileBrowserWindows <>4__this; // 0x18
			public string title; // 0x20
			public string directory; // 0x28
			public bool multiselect; // 0x30
	
			// Constructors
			public <>c__DisplayClass29_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <OpenFoldersAsync>b__0(); // 0x00000001815ED700-0x00000001815ED790
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass30_0 // TypeDefIndex: 9931
		{
			// Fields
			public Action<string> cb; // 0x10
			public FileBrowserWindows <>4__this; // 0x18
			public string title; // 0x20
			public string directory; // 0x28
			public string defaultName; // 0x30
			public ExtensionFilter[] extensions; // 0x38
	
			// Constructors
			public <>c__DisplayClass30_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <SaveFileAsync>b__0(); // 0x00000001815ED790-0x00000001815ED820
		}
	
		// Constructors
		public FileBrowserWindows(); // 0x000000018036B6C0-0x000000018036B6D0
		static FileBrowserWindows(); // 0x00000001815E5D30-0x00000001815E5E30
	
		// Methods
		public override string[] OpenFiles(string title, string directory, ExtensionFilter[] extensions, bool multiselect); // 0x00000001815E4FE0-0x00000001815E55D0
		public override string[] OpenFolders(string title, string directory, bool multiselect); // 0x00000001815E56D0-0x00000001815E56F0
		public override string SaveFile(string title, string directory, string defaultName, ExtensionFilter[] extensions); // 0x00000001815E57F0-0x00000001815E5D30
		public override void OpenFilesAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb); // 0x00000001815E4EE0-0x00000001815E4FE0
		public override void OpenFoldersAsync(string title, string directory, bool multiselect, Action<string[]> cb); // 0x00000001815E55D0-0x00000001815E56D0
		public override void SaveFileAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb); // 0x00000001815E56F0-0x00000001815E57F0
		private string[] openFolders(string title, string directory, bool multiselect, bool isAsync); // 0x00000001815E6430-0x00000001815E69B0
		[MonoPInvokeCallback] // 0x000000018010D050-0x000000018010D0A0
		private static int onBrowseEvent(IntPtr hWnd, int msg, IntPtr lp, IntPtr lpData); // 0x00000001815E61A0-0x00000001815E6430
		private static string getDefaultExtension(ExtensionFilter[] extensions); // 0x00000001815E5E30-0x00000001815E5ED0
		private static string getFilterFromFileExtensionList(ExtensionFilter[] extensions); // 0x00000001815E5ED0-0x00000001815E6150
	}
}
