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
	internal sealed class OperandQuery : ValueQuery // TypeDefIndex: 1860
	{
		// Fields
		internal object val; // 0x18
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x0000000180C8F010-0x0000000180C8F020 
	
		// Constructors
		public OperandQuery(object val); // 0x0000000180C8EFE0-0x0000000180C8F010
	
		// Methods
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x000000018038B150-0x000000018038B160
		public override XPathNodeIterator Clone(); // 0x0000000180362190-0x00000001803621A0
	}
}
