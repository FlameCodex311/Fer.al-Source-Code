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

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	internal sealed class NodeFunctions : ValueQuery // TypeDefIndex: 1856
	{
		// Fields
		private Query arg; // 0x18
		private Function.FunctionType funcType; // 0x20
		private XsltContext xsltContext; // 0x28
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x0000000180C8E1B0-0x0000000180C8E240 
	
		// Constructors
		public NodeFunctions(Function.FunctionType funcType, Query arg); // 0x0000000180C8E170-0x0000000180C8E1B0
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x0000000180C8E100-0x0000000180C8E170
		private XPathNavigator EvaluateArg(XPathNodeIterator context); // 0x0000000180C8DDD0-0x0000000180C8DE40
		public override object Evaluate(XPathNodeIterator context); // 0x0000000180C8DE40-0x0000000180C8E100
		public override XPathNodeIterator Clone(); // 0x0000000180C8DCC0-0x0000000180C8DDD0
	}
}
