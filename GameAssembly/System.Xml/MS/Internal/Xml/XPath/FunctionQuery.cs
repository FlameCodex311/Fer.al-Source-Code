/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;
using System.Xml.Xsl;

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	internal sealed class FunctionQuery : ExtensionQuery // TypeDefIndex: 1846
	{
		// Fields
		private IList<Query> args; // 0x38
		private IXsltContextFunction function; // 0x40
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x0000000180C88E50-0x0000000180C88EB0 
	
		// Constructors
		public FunctionQuery(string prefix, string name, List<Query> args); // 0x0000000180C88BA0-0x0000000180C88BF0
		private FunctionQuery(FunctionQuery other); // 0x0000000180C88BF0-0x0000000180C88E50
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x0000000180C88720-0x0000000180C88BA0
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x0000000180C882C0-0x0000000180C88720
		public override XPathNodeIterator Clone(); // 0x0000000180C88260-0x0000000180C882C0
	}
}
