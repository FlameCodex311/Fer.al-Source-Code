/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ICSharpCode.SharpZipLib.Core;

// Image 62: ICSharpCode.SharpZipLib.dll - Assembly: ICSharpCode.SharpZipLib, Version=0.86.0.518, Culture=neutral, PublicKeyToken=1b03e6acf1164f73 - Types 7518-7576

namespace ICSharpCode.SharpZipLib.Zip
{
	public class ZipNameTransform : INameTransform // TypeDefIndex: 7569
	{
		// Fields
		private static readonly char[] InvalidEntryChars; // 0x00
		private static readonly char[] InvalidEntryCharsRelaxed; // 0x08
	
		// Constructors
		public ZipNameTransform(); // 0x000000018036B6C0-0x000000018036B6D0
		static ZipNameTransform(); // 0x0000000180D69C10-0x0000000180D6AB80
	
		// Methods
		public static bool IsValidName(string name, bool relaxed); // 0x0000000180D69AF0-0x0000000180D69C10
	}
}
