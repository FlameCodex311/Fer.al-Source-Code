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

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	internal abstract class ResetableIterator : XPathNodeIterator // TypeDefIndex: 1871
	{
		// Properties
		public abstract int CurrentPosition { get; }
	
		// Constructors
		public ResetableIterator(); // 0x0000000180C86500-0x0000000180C86520
		protected ResetableIterator(ResetableIterator other); // 0x0000000180C924F0-0x0000000180C92530
	
		// Methods
		protected void ResetCount(); // 0x0000000180C92620-0x0000000180C92630
		public abstract void Reset();
	}
}
