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

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal sealed class StringFunctions : ValueQuery // TypeDefIndex: 1979
	{
		// Fields
		private Function.FunctionType funcType; // 0x18
		private IList<Query> argList; // 0x20
		private static readonly CompareInfo compareInfo; // 0x00
	
		// Properties
		public override XPathResultType StaticType { get; } // 0x00000001819CBEA0-0x00000001819CBEC0 
	
		// Constructors
		public StringFunctions(Function.FunctionType funcType, IList<Query> argList); // 0x00000001819CBC10-0x00000001819CBC50
		private StringFunctions(StringFunctions other); // 0x00000001819CBC50-0x00000001819CBEA0
		static StringFunctions(); // 0x00000001819CBB90-0x00000001819CBC10
	
		// Methods
		public override void SetXsltContext(XsltContext context); // 0x00000001819CADE0-0x00000001819CAF90
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x00000001819CA620-0x00000001819CABB0
		internal static string toString(double num); // 0x00000001819CBF00-0x00000001819CBF50
		internal static string toString(bool b); // 0x00000001819CBEC0-0x00000001819CBF00
		private string toString(XPathNodeIterator nodeIterator); // 0x00000001819CBF50-0x00000001819CC290
		private string Concat(XPathNodeIterator nodeIterator); // 0x00000001819CA250-0x00000001819CA490
		private bool StartsWith(XPathNodeIterator nodeIterator); // 0x00000001819CAF90-0x00000001819CB100
		private bool Contains(XPathNodeIterator nodeIterator); // 0x00000001819CA490-0x00000001819CA620
		private string SubstringBefore(XPathNodeIterator nodeIterator); // 0x00000001819CB430-0x00000001819CB610
		private string SubstringAfter(XPathNodeIterator nodeIterator); // 0x00000001819CB230-0x00000001819CB430
		private string Substring(XPathNodeIterator nodeIterator); // 0x00000001819CB610-0x00000001819CB910
		private double StringLength(XPathNodeIterator nodeIterator); // 0x00000001819CB100-0x00000001819CB230
		private string Normalize(XPathNodeIterator nodeIterator); // 0x00000001819CABB0-0x00000001819CADE0
		private string Translate(XPathNodeIterator nodeIterator); // 0x00000001819CB910-0x00000001819CBB90
		public override XPathNodeIterator Clone(); // 0x00000001819CA1F0-0x00000001819CA250
	}
}
