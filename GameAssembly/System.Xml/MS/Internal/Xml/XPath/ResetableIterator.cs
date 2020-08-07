/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal abstract class ResetableIterator : XPathNodeIterator // TypeDefIndex: 1976
	{
		// Properties
		public abstract int CurrentPosition { get; }
	
		// Constructors
		public ResetableIterator(); // 0x00000001819BE2D0-0x00000001819BE2F0
		protected ResetableIterator(ResetableIterator other); // 0x00000001819CA000-0x00000001819CA040
	
		// Methods
		protected void ResetCount(); // 0x00000001819CA130-0x00000001819CA140
		public abstract void Reset();
	}
}
