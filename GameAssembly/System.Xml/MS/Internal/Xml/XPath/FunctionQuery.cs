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

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal sealed class FunctionQuery : ExtensionQuery // TypeDefIndex: 1951
	{
		// Fields
		private IList<Query> args; // 0x38
		private IXsltContextFunction function; // 0x40
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x00000001819C0BA0-0x00000001819C0C00 
	
		// Constructors
		public FunctionQuery(string prefix, string name, List<Query> args); // 0x00000001819C0900-0x00000001819C0950
		private FunctionQuery(FunctionQuery other); // 0x00000001819C0950-0x00000001819C0BA0
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x00000001819C0490-0x00000001819C0900
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x00000001819C0060-0x00000001819C0490
		public override XPathNodeIterator Clone(); // 0x00000001819C0000-0x00000001819C0060
	}
}
