/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	internal class CompiledXpathExpr : XPathExpression // TypeDefIndex: 1830
	{
		// Fields
		private Query query; // 0x10
		private string expr; // 0x18
		private bool needContext; // 0x20
	
		// Properties
		internal Query QueryTree { get; } // 0x0000000180C859B0-0x0000000180C85A10 
	
		// Nested types
		private class UndefinedXsltContext : XsltContext // TypeDefIndex: 1831
		{
			// Fields
			private IXmlNamespaceResolver nsResolver; // 0x50
	
			// Properties
			public override string DefaultNamespace { get; } // 0x0000000180C94780-0x0000000180C947C0 
			public override bool Whitespace { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
			// Constructors
			public UndefinedXsltContext(IXmlNamespaceResolver nsResolver); // 0x0000000180C94750-0x0000000180C94780
	
			// Methods
			public override string LookupNamespace(string prefix); // 0x0000000180C945B0-0x0000000180C946D0
			public override IXsltContextVariable ResolveVariable(string prefix, string name); // 0x0000000180C94710-0x0000000180C94750
			public override IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes); // 0x0000000180C946D0-0x0000000180C94710
			public override bool PreserveWhitespace(XPathNavigator node); // 0x00000001803C28F0-0x00000001803C2900
		}
	
		// Constructors
		internal CompiledXpathExpr(Query query, string expression, bool needContext); // 0x0000000180C85960-0x0000000180C859B0
	
		// Methods
		public override void SetContext(IXmlNamespaceResolver nsResolver); // 0x0000000180C85850-0x0000000180C85960
	}
}
