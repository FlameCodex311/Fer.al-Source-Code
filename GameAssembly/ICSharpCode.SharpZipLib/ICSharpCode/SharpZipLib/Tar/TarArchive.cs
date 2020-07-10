/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Tar
{
	public class TarArchive : IDisposable // TypeDefIndex: 7537
	{
		// Fields
		private ProgressMessageHandler ProgressMessageEvent; // 0x10
		private bool keepOldFiles; // 0x18
		private bool asciiTranslate; // 0x19
		private string userName; // 0x20
		private string groupName; // 0x28
		private TarInputStream tarIn; // 0x30
		private TarOutputStream tarOut; // 0x38
		private bool isDisposed; // 0x40
	
		// Constructors
		protected TarArchive(TarInputStream stream); // 0x0000000180D5F760-0x0000000180D5F810
	
		// Methods
		protected virtual void OnProgressMessageEvent(TarEntry entry, string message); // 0x0000000180D5F730-0x0000000180D5F760
		public static TarArchive CreateInputTarArchive(Stream inputStream); // 0x0000000180D5ECD0-0x0000000180D5EDC0
		public static TarArchive CreateInputTarArchive(Stream inputStream, int blockFactor); // 0x0000000180D5EA20-0x0000000180D5ECD0
		public void ExtractContents(string destinationDirectory); // 0x0000000180D5EF90-0x0000000180D5F050
		private void ExtractEntry(string destDir, TarEntry entry); // 0x0000000180D5F050-0x0000000180D5F540
		public void Dispose(); // 0x0000000180D5EDC0-0x0000000180D5EE30
		protected virtual void Dispose(bool disposing); // 0x0000000180D5EE30-0x0000000180D5EEB0
		public virtual void Close(); // 0x0000000180709860-0x0000000180709880
		~TarArchive(); // 0x000000018072E430-0x000000018072E4D0
		private static void EnsureDirectoryExists(string directoryName); // 0x0000000180D5EEB0-0x0000000180D5EF90
		private static bool IsBinary(string filename); // 0x0000000180D5F540-0x0000000180D5F730
	}
}
