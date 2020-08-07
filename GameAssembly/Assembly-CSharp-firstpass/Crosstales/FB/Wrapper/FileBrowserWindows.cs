/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using AOT;
using Crosstales.FB;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.FB.Wrapper
{
	public class FileBrowserWindows : FileBrowserBase // TypeDefIndex: 9714
	{
		// Fields
		private static string _initialPath; // 0x00
		private const int OFN_NOCHANGEDIR = 8; // Metadata: 0x0077A34D
		private const int OFN_ALLOWMULTISELECT = 512; // Metadata: 0x0077A351
		private const int OFN_EXPLORER = 524288; // Metadata: 0x0077A355
		private const int OFN_FILEMUSTEXIST = 4096; // Metadata: 0x0077A359
		private const int OFN_PATHMUSTEXIST = 2048; // Metadata: 0x0077A35D
		private const int OFN_OVERWRITEPROMPT = 2; // Metadata: 0x0077A361
		private const int MAX_OPEN_FILE_LENGTH = 65536; // Metadata: 0x0077A365
		private const int MAX_SAVE_FILE_LENGTH = 4096; // Metadata: 0x0077A369
		private const int MAX_PATH_LENGTH = 4096; // Metadata: 0x0077A36D
		private const int WM_USER = 1024; // Metadata: 0x0077A371
		private const int BFFM_INITIALIZED = 1; // Metadata: 0x0077A375
		private const int BFFM_SELCHANGED = 2; // Metadata: 0x0077A379
		private const int BFFM_SETSELECTIONW = 1127; // Metadata: 0x0077A37D
		private const int BFFM_SETSTATUSTEXTW = 1128; // Metadata: 0x0077A381
		private const uint BIF_NEWDIALOGSTYLE = 64; // Metadata: 0x0077A385
		private const uint BIF_SHAREABLE = 32768; // Metadata: 0x0077A389
		private static readonly IntPtr currentWindow; // 0x08
		private static readonly char[] nullChar; // 0x10
	
		// Properties
		public override bool canOpenMultipleFiles { get; } // 0x0000000180380B60-0x0000000180380B70 
		public override bool canOpenMultipleFolders { get; } // 0x0000000180380950-0x0000000180380960 
		public override bool isPlatformSupported { get; } // 0x0000000181085D00-0x0000000181085D50 
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass28_0 // TypeDefIndex: 9715
		{
			// Fields
			public Action<string[]> cb; // 0x10
			public FileBrowserWindows <>4__this; // 0x18
			public string title; // 0x20
			public string directory; // 0x28
			public ExtensionFilter[] extensions; // 0x30
			public bool multiselect; // 0x38
	
			// Constructors
			public <>c__DisplayClass28_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <OpenFilesAsync>b__0(); // 0x000000018108D2D0-0x000000018108D360
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass29_0 // TypeDefIndex: 9716
		{
			// Fields
			public Action<string[]> cb; // 0x10
			public FileBrowserWindows <>4__this; // 0x18
			public string title; // 0x20
			public string directory; // 0x28
			public bool multiselect; // 0x30
	
			// Constructors
			public <>c__DisplayClass29_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <OpenFoldersAsync>b__0(); // 0x000000018108D360-0x000000018108D3F0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass30_0 // TypeDefIndex: 9717
		{
			// Fields
			public Action<string> cb; // 0x10
			public FileBrowserWindows <>4__this; // 0x18
			public string title; // 0x20
			public string directory; // 0x28
			public string defaultName; // 0x30
			public ExtensionFilter[] extensions; // 0x38
	
			// Constructors
			public <>c__DisplayClass30_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <SaveFileAsync>b__0(); // 0x000000018108D3F0-0x000000018108D480
		}
	
		// Constructors
		public FileBrowserWindows(); // 0x0000000180373240-0x0000000180373250
		static FileBrowserWindows(); // 0x0000000181085900-0x00000001810859E0
	
		// Methods
		public override string[] OpenFiles(string title, string directory, ExtensionFilter[] extensions, bool multiselect); // 0x0000000181084C10-0x00000001810851D0
		public override string[] OpenFolders(string title, string directory, bool multiselect); // 0x00000001810852D0-0x00000001810852F0
		public override string SaveFile(string title, string directory, string defaultName, ExtensionFilter[] extensions); // 0x00000001810853F0-0x0000000181085900
		public override void OpenFilesAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb); // 0x0000000181084B10-0x0000000181084C10
		public override void OpenFoldersAsync(string title, string directory, bool multiselect, Action<string[]> cb); // 0x00000001810851D0-0x00000001810852D0
		public override void SaveFileAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb); // 0x00000001810852F0-0x00000001810853F0
		private string[] openFolders(string title, string directory, bool multiselect, bool isAsync); // 0x0000000181085FA0-0x00000001810864F0
		[MonoPInvokeCallback] // 0x00000001801EEB60-0x00000001801EEBB0
		private static int onBrowseEvent(IntPtr hWnd, int msg, IntPtr lp, IntPtr lpData); // 0x0000000181085D50-0x0000000181085FA0
		private static string getDefaultExtension(ExtensionFilter[] extensions); // 0x00000001810859E0-0x0000000181085A80
		private static string getFilterFromFileExtensionList(ExtensionFilter[] extensions); // 0x0000000181085A80-0x0000000181085D00
	}
}
