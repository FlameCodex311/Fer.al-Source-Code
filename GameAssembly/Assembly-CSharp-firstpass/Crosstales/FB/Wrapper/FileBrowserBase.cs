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
	public abstract class FileBrowserBase : IFileBrowser // TypeDefIndex: 9712
	{
		// Properties
		public abstract bool canOpenMultipleFiles { get; }
		public abstract bool canOpenMultipleFolders { get; }
		public abstract bool isPlatformSupported { get; }
	
		// Constructors
		protected FileBrowserBase(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public string OpenSingleFile(string title, string directory, ExtensionFilter[] extensions); // 0x0000000181084680-0x0000000181084740
		public abstract string[] OpenFiles(string title, string directory, ExtensionFilter[] extensions, bool multiselect);
		public string OpenSingleFolder(string title, string directory); // 0x0000000181084740-0x0000000181084800
		public abstract string[] OpenFolders(string title, string directory, bool multiselect);
		public abstract string SaveFile(string title, string directory, string defaultName, ExtensionFilter[] extensions);
		public abstract void OpenFilesAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb);
		public abstract void OpenFoldersAsync(string title, string directory, bool multiselect, Action<string[]> cb);
		public abstract void SaveFileAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb);
	}
}
