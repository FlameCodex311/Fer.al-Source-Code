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
	internal abstract class BaseAxisQuery : Query // TypeDefIndex: 1822
	{
		// Fields
		internal Query qyInput; // 0x18
		private bool nameTest; // 0x20
		private string name; // 0x28
		private string prefix; // 0x30
		private string nsUri; // 0x38
		private XPathNodeType typeTest; // 0x40
		protected XPathNavigator currentNode; // 0x48
		protected int position; // 0x50
	
		// Properties
		protected string Name { get; } // 0x0000000180369B60-0x0000000180369B70 
		protected string Namespace { get; } // 0x0000000180369BB0-0x0000000180369BC0 
		protected bool NameTest { get; } // 0x00000001803C19E0-0x00000001803C19F0 
		protected XPathNodeType TypeTest { get; } // 0x000000018047AB20-0x000000018047AB30 
		public override int CurrentPosition { get; } // 0x0000000180369BA0-0x0000000180369BB0 
		public override XPathNavigator Current { get; } // 0x0000000180369C40-0x0000000180369C50 
		public override XPathResultType StaticType { get; } // 0x000000018038FAD0-0x000000018038FAE0 
	
		// Constructors
		protected BaseAxisQuery(Query qyInput); // 0x0000000180C83640-0x0000000180C836D0
		protected BaseAxisQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest); // 0x0000000180C832E0-0x0000000180C833A0
		protected BaseAxisQuery(BaseAxisQuery other); // 0x0000000180C836D0-0x0000000180C837E0
	
		// Methods
		public override void Reset(); // 0x0000000180C83590-0x0000000180C835D0
		public override void SetXsltContext(XsltContext context); // 0x0000000180C835D0-0x0000000180C83640
		public virtual bool matches(XPathNavigator e); // 0x0000000180C837E0-0x0000000180C83920
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x0000000180C83530-0x0000000180C83590
	}
}
