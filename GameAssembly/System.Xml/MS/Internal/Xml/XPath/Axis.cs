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

// Image 2: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1812-2538

namespace MS.Internal.Xml.XPath
{
	internal class Axis : AstNode // TypeDefIndex: 1820
	{
		// Fields
		private AxisType axisType; // 0x10
		private AstNode input; // 0x18
		private string prefix; // 0x20
		private string name; // 0x28
		private XPathNodeType nodeType; // 0x30
		protected bool abbrAxis; // 0x34
		private string urn; // 0x38
	
		// Properties
		public override AstType Type { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		public override XPathResultType ReturnType { get; } // 0x000000018038FAD0-0x000000018038FAE0 
		public AstNode Input { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public string Prefix { get; } // 0x000000018036AC70-0x000000018036AC80 
		public string Name { get; } // 0x0000000180369B60-0x0000000180369B70 
		public XPathNodeType NodeType { get; } // 0x000000018043DDC0-0x000000018043DDD0 
		public AxisType TypeOfAxis { get; } // 0x000000018036CFF0-0x000000018036D000 
		public bool AbbrAxis { get; } // 0x0000000180357070-0x0000000180357080 
		public string Urn { get; set; } // 0x0000000180369BB0-0x0000000180369BC0 0x00000001803A2820-0x00000001803A2830
	
		// Nested types
		public enum AxisType // TypeDefIndex: 1821
		{
			Ancestor = 0,
			AncestorOrSelf = 1,
			Attribute = 2,
			Child = 3,
			Descendant = 4,
			DescendantOrSelf = 5,
			Following = 6,
			FollowingSibling = 7,
			Namespace = 8,
			Parent = 9,
			Preceding = 10,
			PrecedingSibling = 11,
			Self = 12,
			None = 13
		}
	
		// Constructors
		public Axis(AxisType axisType, AstNode input, string prefix, string name, XPathNodeType nodetype); // 0x0000000180C833E0-0x0000000180C83470
		public Axis(AxisType axisType, AstNode input); // 0x0000000180C83470-0x0000000180C83530
	}
}
