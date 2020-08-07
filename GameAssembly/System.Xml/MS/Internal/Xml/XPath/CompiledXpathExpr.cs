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

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal class CompiledXpathExpr : XPathExpression // TypeDefIndex: 1935
	{
		// Fields
		private Query query; // 0x10
		private string expr; // 0x18
		private bool needContext; // 0x20
	
		// Properties
		internal Query QueryTree { get; } // 0x00000001819BD790-0x00000001819BD7F0 
	
		// Nested types
		private class UndefinedXsltContext : XsltContext // TypeDefIndex: 1936
		{
			// Fields
			private IXmlNamespaceResolver nsResolver; // 0x50
	
			// Properties
			public override string DefaultNamespace { get; } // 0x00000001819CC450-0x00000001819CC490 
			public override bool Whitespace { get; } // 0x0000000180380950-0x0000000180380960 
	
			// Constructors
			public UndefinedXsltContext(IXmlNamespaceResolver nsResolver); // 0x00000001819CC420-0x00000001819CC450
	
			// Methods
			public override string LookupNamespace(string prefix); // 0x00000001819CC290-0x00000001819CC3A0
			public override IXsltContextVariable ResolveVariable(string prefix, string name); // 0x00000001819CC3E0-0x00000001819CC420
			public override IXsltContextFunction ResolveFunction(string prefix, string name, XPathResultType[] ArgTypes); // 0x00000001819CC3A0-0x00000001819CC3E0
			public override bool PreserveWhitespace(XPathNavigator node); // 0x0000000180380950-0x0000000180380960
		}
	
		// Constructors
		internal CompiledXpathExpr(Query query, string expression, bool needContext); // 0x00000001819BD740-0x00000001819BD790
	
		// Methods
		public override void SetContext(IXmlNamespaceResolver nsResolver); // 0x00000001819BD630-0x00000001819BD740
	}
}
