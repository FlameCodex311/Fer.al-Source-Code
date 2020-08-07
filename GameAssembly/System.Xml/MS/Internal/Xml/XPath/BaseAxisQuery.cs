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
	internal abstract class BaseAxisQuery : Query // TypeDefIndex: 1927
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
		protected string Name { get; } // 0x00000001803745B0-0x00000001803745C0 
		protected string Namespace { get; } // 0x00000001803743D0-0x00000001803743E0 
		protected bool NameTest { get; } // 0x00000001803FA090-0x00000001803FA0A0 
		protected XPathNodeType TypeTest { get; } // 0x0000000180379F10-0x0000000180379F20 
		public override int CurrentPosition { get; } // 0x00000001803F8270-0x00000001803F8280 
		public override XPathNavigator Current { get; } // 0x00000001803743E0-0x00000001803743F0 
		public override XPathResultType StaticType { get; } // 0x000000018043E010-0x000000018043E020 
	
		// Constructors
		protected BaseAxisQuery(Query qyInput); // 0x00000001819BB4A0-0x00000001819BB530
		protected BaseAxisQuery(Query qyInput, string name, string prefix, XPathNodeType typeTest); // 0x00000001819BB140-0x00000001819BB200
		protected BaseAxisQuery(BaseAxisQuery other); // 0x00000001819BB530-0x00000001819BB640
	
		// Methods
		public override void Reset(); // 0x00000001819BB3F0-0x00000001819BB430
		public override void SetXsltContext(XsltContext context); // 0x00000001819BB430-0x00000001819BB4A0
		public virtual bool matches(XPathNavigator e); // 0x00000001819BB640-0x00000001819BB770
		public override object Evaluate(XPathNodeIterator nodeIterator); // 0x00000001819BB390-0x00000001819BB3F0
	}
}
