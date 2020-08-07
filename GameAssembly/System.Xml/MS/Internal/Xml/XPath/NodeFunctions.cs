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
using System.Xml.Xsl;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal sealed class NodeFunctions : ValueQuery // TypeDefIndex: 1961
	{
		// Fields
		private Query arg; // 0x18
		private Function.FunctionType funcType; // 0x20
		private XsltContext xsltContext; // 0x28
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x00000001819C5DB0-0x00000001819C5E40 
	
		// Constructors
		public NodeFunctions(Function.FunctionType funcType, Query arg); // 0x00000001819C5D70-0x00000001819C5DB0
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x00000001819C5D00-0x00000001819C5D70
		private XPathNavigator EvaluateArg(XPathNodeIterator context); // 0x00000001819C59D0-0x00000001819C5A40
		public override object Evaluate(XPathNodeIterator context); // 0x00000001819C5A40-0x00000001819C5D00
		public override XPathNodeIterator Clone(); // 0x00000001819C58C0-0x00000001819C59D0
	}
}
