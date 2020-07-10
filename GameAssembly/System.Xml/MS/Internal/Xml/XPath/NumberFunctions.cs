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
	internal sealed class NumberFunctions : ValueQuery // TypeDefIndex: 1857
	{
		// Fields
		private Query arg; // 0x18
		private Function.FunctionType ftype; // 0x20
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x000000018035FCC0-0x000000018035FCD0 
	
		// Constructors
		public NumberFunctions(Function.FunctionType ftype, Query arg); // 0x0000000180C84390-0x0000000180C843D0
		private NumberFunctions(NumberFunctions other); // 0x0000000180C842B0-0x0000000180C84390
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x0000000180C84290-0x0000000180C842B0
		internal static double Number(bool arg); // 0x0000000180C8EAF0-0x0000000180C8EB10
		internal static double Number(string arg); // 0x0000000180C8EB10-0x0000000180C8EB70
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x0000000180C8E400-0x0000000180C8E750
		private double Number(XPathNodeIterator nodeIterator); // 0x0000000180C8E800-0x0000000180C8EAF0
		private double Sum(XPathNodeIterator nodeIterator); // 0x0000000180C8EC00-0x0000000180C8ECE0
		private double Floor(XPathNodeIterator nodeIterator); // 0x0000000180C8E750-0x0000000180C8E800
		private double Ceiling(XPathNodeIterator nodeIterator); // 0x0000000180C8E240-0x0000000180C8E2F0
		private double Round(XPathNodeIterator nodeIterator); // 0x0000000180C8EB70-0x0000000180C8EC00
		public override XPathNodeIterator Clone(); // 0x0000000180C8E2F0-0x0000000180C8E400
	}
}
