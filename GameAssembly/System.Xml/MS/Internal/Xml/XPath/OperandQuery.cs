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
	internal sealed class OperandQuery : ValueQuery // TypeDefIndex: 1965
	{
		// Fields
		internal object val; // 0x18
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x00000001819C6BF0-0x00000001819C6C00 
	
		// Constructors
		public OperandQuery(object val); // 0x00000001819C6BC0-0x00000001819C6BF0
	
		// Methods
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x0000000180372430-0x0000000180372440
		public override XPathNodeIterator Clone(); // 0x0000000180411160-0x0000000180411170
	}
}
