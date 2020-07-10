/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.XPath;
using System.Xml.Xsl;

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	internal sealed class StringFunctions : ValueQuery // TypeDefIndex: 1874
	{
		// Fields
		private Function.FunctionType funcType; // 0x18
		private IList<Query> argList; // 0x20
		private static readonly CompareInfo compareInfo; // 0x00
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x0000000180C941B0-0x0000000180C941D0 
	
		// Constructors
		public StringFunctions(Function.FunctionType funcType, IList<Query> argList); // 0x0000000180C93F10-0x0000000180C93F50
		private StringFunctions(StringFunctions other); // 0x0000000180C93F50-0x0000000180C941B0
		static StringFunctions(); // 0x0000000180C93E90-0x0000000180C93F10
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x0000000180C93050-0x0000000180C93200
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x0000000180C92B20-0x0000000180C92E00
		internal static string toString(double num); // 0x0000000180C94210-0x0000000180C94260
		internal static string toString(bool b); // 0x0000000180C941D0-0x0000000180C94210
		private string toString(XPathNodeIterator nodeIterator); // 0x0000000180C94260-0x0000000180C945B0
		private string Concat(XPathNodeIterator nodeIterator); // 0x0000000180C92740-0x0000000180C92990
		private bool StartsWith(XPathNodeIterator nodeIterator); // 0x0000000180C93200-0x0000000180C93390
		private bool Contains(XPathNodeIterator nodeIterator); // 0x0000000180C92990-0x0000000180C92B20
		private string SubstringBefore(XPathNodeIterator nodeIterator); // 0x0000000180C936E0-0x0000000180C938D0
		private string SubstringAfter(XPathNodeIterator nodeIterator); // 0x0000000180C934D0-0x0000000180C936E0
		private string Substring(XPathNodeIterator nodeIterator); // 0x0000000180C938D0-0x0000000180C93BF0
		private double StringLength(XPathNodeIterator nodeIterator); // 0x0000000180C93390-0x0000000180C934D0
		private string Normalize(XPathNodeIterator nodeIterator); // 0x0000000180C92E00-0x0000000180C93050
		private string Translate(XPathNodeIterator nodeIterator); // 0x0000000180C93BF0-0x0000000180C93E90
		public override XPathNodeIterator Clone(); // 0x0000000180C926E0-0x0000000180C92740
	}
}
