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
	public abstract class FileBrowserBase : IFileBrowser // TypeDefIndex: 9926
	{
		// Properties
		public abstract bool canOpenMultipleFiles { get; }
		public abstract bool canOpenMultipleFolders { get; }
		public abstract bool isPlatformSupported { get; }
	
		// Constructors
		protected FileBrowserBase(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public string OpenSingleFile(string title, string directory, ExtensionFilter[] extensions); // 0x00000001815E4A50-0x00000001815E4B10
		public abstract string[] OpenFiles(string title, string directory, ExtensionFilter[] extensions, bool multiselect);
		public string OpenSingleFolder(string title, string directory); // 0x00000001815E4B10-0x00000001815E4BD0
		public abstract string[] OpenFolders(string title, string directory, bool multiselect);
		public abstract string SaveFile(string title, string directory, string defaultName, ExtensionFilter[] extensions);
		public abstract void OpenFilesAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb);
		public abstract void OpenFoldersAsync(string title, string directory, bool multiselect, Action<string[]> cb);
		public abstract void SaveFileAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb);
	}
}
