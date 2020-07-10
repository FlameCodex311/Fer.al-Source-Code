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
	internal sealed class BooleanFunctions : ValueQuery // TypeDefIndex: 1824
	{
		// Fields
		private Query arg; // 0x18
		private Function.FunctionType funcType; // 0x20
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x0000000180362180-0x0000000180362190 
	
		// Constructors
		public BooleanFunctions(Function.FunctionType funcType, Query arg); // 0x0000000180C84390-0x0000000180C843D0
		private BooleanFunctions(BooleanFunctions other); // 0x0000000180C842B0-0x0000000180C84390
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x0000000180C84290-0x0000000180C842B0
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x0000000180C83E90-0x0000000180C840E0
		internal static bool toBoolean(double number); // 0x0000000180C845A0-0x0000000180C84620
		internal static bool toBoolean(string str); // 0x0000000180C84580-0x0000000180C845A0
		internal bool toBoolean(XPathNodeIterator nodeIterator); // 0x0000000180C843D0-0x0000000180C84580
		private bool Not(XPathNodeIterator nodeIterator); // 0x0000000180C84200-0x0000000180C84290
		private bool Lang(XPathNodeIterator nodeIterator); // 0x0000000180C840E0-0x0000000180C84200
		public override XPathNodeIterator Clone(); // 0x0000000180C83D80-0x0000000180C83E90
	}
}
