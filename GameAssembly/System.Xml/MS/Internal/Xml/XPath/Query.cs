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

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	[DebuggerDisplay] // 0x0000000180143F00-0x0000000180143F30
	internal abstract class Query : ResetableIterator // TypeDefIndex: 1867
	{
		// Properties
		public override int Count { get; } // 0x0000000180C92530-0x0000000180C92620 
		public abstract XPathResultType StaticType { get; }
		public virtual QueryProps Properties { get; } // 0x00000001809EC1F0-0x00000001809EC200 
	
		// Constructors
		public Query(); // 0x0000000180C86500-0x0000000180C86520
		protected Query(Query other); // 0x0000000180C924F0-0x0000000180C92530
	
		// Methods
		public override bool MoveNext(); // 0x0000000180C924D0-0x0000000180C924F0
		public virtual void SetXsltContext(XsltContext context); // 0x00000001803581E0-0x00000001803581F0
		public abstract object Evaluate(XPathNodeIterator nodeIterator);
		public abstract XPathNavigator Advance();
		public static Query Clone(Query input); // 0x0000000180C92050-0x0000000180C920F0
		protected static XPathNodeIterator Clone(XPathNodeIterator input); // 0x0000000180C920F0-0x0000000180C92110
		protected static XPathNavigator Clone(XPathNavigator input); // 0x0000000180C92110-0x0000000180C92130
		public bool Insert(List<XPathNavigator> buffer, XPathNavigator nav); // 0x0000000180C92370-0x0000000180C924D0
		private static int GetMedian(int l, int r); // 0x0000000180C92280-0x0000000180C92290
		public static XmlNodeOrder CompareNodes(XPathNavigator l, XPathNavigator r); // 0x0000000180C92130-0x0000000180C92280
		protected XPathResultType GetXPathType(object value); // 0x0000000180C92290-0x0000000180C92370
	}
}
