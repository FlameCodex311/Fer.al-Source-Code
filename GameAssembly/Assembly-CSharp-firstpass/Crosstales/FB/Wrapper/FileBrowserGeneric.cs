/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Crosstales.FB;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace Crosstales.FB.Wrapper
{
	public class FileBrowserGeneric : FileBrowserBase // TypeDefIndex: 9927
	{
		// Properties
		public override bool canOpenMultipleFiles { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public override bool canOpenMultipleFolders { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public override bool isPlatformSupported { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Constructors
		public FileBrowserGeneric(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public override string[] OpenFiles(string title, string directory, ExtensionFilter[] extensions, bool multiselect); // 0x00000001815E4C70-0x00000001815E4CD0
		public override string[] OpenFolders(string title, string directory, bool multiselect); // 0x00000001815E4D70-0x00000001815E4DD0
		public override string SaveFile(string title, string directory, string defaultName, ExtensionFilter[] extensions); // 0x00000001815E4E70-0x00000001815E4EE0
		public override void OpenFilesAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb); // 0x00000001815E4BD0-0x00000001815E4C70
		public override void OpenFoldersAsync(string title, string directory, bool multiselect, Action<string[]> cb); // 0x00000001815E4CD0-0x00000001815E4D70
		public override void SaveFileAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb); // 0x00000001815E4DD0-0x00000001815E4E70
	}
}
