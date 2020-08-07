/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// Image 63: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7684-7742

namespace ICSharpCode.SharpZipLib.Tar
{
	public class TarArchive : IDisposable // TypeDefIndex: 7703
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
		protected TarArchive(TarInputStream stream); // 0x0000000181EA6E60-0x0000000181EA6F10
	
		// Methods
		protected virtual void OnProgressMessageEvent(TarEntry entry, string message); // 0x0000000181EA6E30-0x0000000181EA6E60
		public static TarArchive CreateInputTarArchive(Stream inputStream); // 0x0000000181EA6410-0x0000000181EA6500
		public static TarArchive CreateInputTarArchive(Stream inputStream, int blockFactor); // 0x0000000181EA6170-0x0000000181EA6410
		public void ExtractContents(string destinationDirectory); // 0x0000000181EA66D0-0x0000000181EA6780
		private void ExtractEntry(string destDir, TarEntry entry); // 0x0000000181EA6780-0x0000000181EA6C50
		public void Dispose(); // 0x0000000181EA6500-0x0000000181EA6570
		protected virtual void Dispose(bool disposing); // 0x0000000181EA6570-0x0000000181EA65F0
		public virtual void Close(); // 0x0000000180F78F80-0x0000000180F78FA0
		~TarArchive(); // 0x00000001804575C0-0x0000000180457660
		private static void EnsureDirectoryExists(string directoryName); // 0x0000000181EA65F0-0x0000000181EA66D0
		private static bool IsBinary(string filename); // 0x0000000181EA6C50-0x0000000181EA6E30
	}
}
