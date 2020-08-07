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
	public interface IFileBrowser // TypeDefIndex: 9722
	{
		// Properties
		bool canOpenMultipleFiles { get; }
		bool canOpenMultipleFolders { get; }
		bool isPlatformSupported { get; }
	
		// Methods
		string OpenSingleFile(string title, string directory, ExtensionFilter[] extensions);
		string[] OpenFiles(string title, string directory, ExtensionFilter[] extensions, bool multiselect);
		string OpenSingleFolder(string title, string directory);
		string[] OpenFolders(string title, string directory, bool multiselect);
		string SaveFile(string title, string directory, string defaultName, ExtensionFilter[] extensions);
		void OpenFilesAsync(string title, string directory, ExtensionFilter[] extensions, bool multiselect, Action<string[]> cb);
		void OpenFoldersAsync(string title, string directory, bool multiselect, Action<string[]> cb);
		void SaveFileAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb);
	}
}
