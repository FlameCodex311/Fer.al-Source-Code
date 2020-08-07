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
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	[DebuggerDisplay] // 0x0000000180280B70-0x0000000180280BA0
	internal abstract class Query : ResetableIterator // TypeDefIndex: 1972
	{
		// Properties
		public override int Count { get; } // 0x00000001819CA040-0x00000001819CA130 
		public abstract XPathResultType StaticType { get; }
		public virtual QueryProps Properties { get; } // 0x000000018144F420-0x000000018144F430 
	
		// Constructors
		public Query(); // 0x00000001819BE2D0-0x00000001819BE2F0
		protected Query(Query other); // 0x00000001819CA000-0x00000001819CA040
	
		// Methods
		public override bool MoveNext(); // 0x00000001819C9FE0-0x00000001819CA000
		public virtual void SetXsltContext(XsltContext context); // 0x00000001803774A0-0x00000001803774B0
		public abstract object Evaluate(XPathNodeIterator nodeIterator);
		public abstract XPathNavigator Advance();
		public static Query Clone(Query input); // 0x00000001819C9B60-0x00000001819C9C00
		protected static XPathNodeIterator Clone(XPathNodeIterator input); // 0x00000001819C9C00-0x00000001819C9C20
		protected static XPathNavigator Clone(XPathNavigator input); // 0x00000001819C9C20-0x00000001819C9C40
		public bool Insert(List<XPathNavigator> buffer, XPathNavigator nav); // 0x00000001819C9E80-0x00000001819C9FE0
		private static int GetMedian(int l, int r); // 0x00000001819C9D90-0x00000001819C9DA0
		public static XmlNodeOrder CompareNodes(XPathNavigator l, XPathNavigator r); // 0x00000001819C9C40-0x00000001819C9D90
		protected XPathResultType GetXPathType(object value); // 0x00000001819C9DA0-0x00000001819C9E80
	}
}
