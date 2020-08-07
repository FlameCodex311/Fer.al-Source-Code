/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crosstales.FB;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace Crosstales.FB.Wrapper
{
	public class FileBrowserGeneric : FileBrowserBase // TypeDefIndex: 9713
	{
		// Properties
		public override bool canOpenMultipleFiles { get; } // 0x0000000180380950-0x0000000180380960 
		public override bool canOpenMultipleFolders { get; } // 0x0000000180380950-0x0000000180380960 
		public override bool isPlatformSupported { get; } // 0x0000000180380950-0x0000000180380960 
	
		// Constructors
		public FileBrowserGeneric(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public override string[] OpenFiles(string title, string directory, ExtensionFilter[] extensions, bool multiselect); // 0x00000001810848A0-0x0000000181084900
		public override string[] OpenFolders(string title, string directory, bool multiselect); // 0x00000001810849A0-0x0000000181084A00
		public override string SaveFile(string title, string directory, string defaultName, ExtensionFilter[] extensions); // 0x0000000181084AA0-0x0000000181084B10
		public override void OpenFilesAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb); // 0x0000000181084800-0x00000001810848A0
		public override void OpenFoldersAsync(string title, string directory, bool multiselect, Action<string[]> cb); // 0x0000000181084900-0x00000001810849A0
		public override void SaveFileAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb); // 0x0000000181084A00-0x0000000181084AA0
	}
}
