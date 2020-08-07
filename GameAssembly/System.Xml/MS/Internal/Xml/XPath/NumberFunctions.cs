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
	internal sealed class NumberFunctions : ValueQuery // TypeDefIndex: 1962
	{
		// Fields
		private Query arg; // 0x18
		private Function.FunctionType ftype; // 0x20
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x000000018037DDC0-0x000000018037DDD0 
	
		// Constructors
		public NumberFunctions(Function.FunctionType ftype, Query arg); // 0x00000001819BC1C0-0x00000001819BC200
		private NumberFunctions(NumberFunctions other); // 0x00000001819BC0E0-0x00000001819BC1C0
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x00000001819BC0C0-0x00000001819BC0E0
		internal static double Number(bool arg); // 0x00000001819C66D0-0x00000001819C66F0
		internal static double Number(string arg); // 0x00000001819C66F0-0x00000001819C6750
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x00000001819C6000-0x00000001819C6340
		private double Number(XPathNodeIterator nodeIterator); // 0x00000001819C63F0-0x00000001819C66D0
		private double Sum(XPathNodeIterator nodeIterator); // 0x00000001819C67E0-0x00000001819C68C0
		private double Floor(XPathNodeIterator nodeIterator); // 0x00000001819C6340-0x00000001819C63F0
		private double Ceiling(XPathNodeIterator nodeIterator); // 0x00000001819C5E40-0x00000001819C5EF0
		private double Round(XPathNodeIterator nodeIterator); // 0x00000001819C6750-0x00000001819C67E0
		public override XPathNodeIterator Clone(); // 0x00000001819C5EF0-0x00000001819C6000
	}
}
