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
	internal sealed class FilterQuery : BaseAxisQuery // TypeDefIndex: 1840
	{
		// Fields
		private Query cond; // 0x58
		private bool noPosition; // 0x60
	
		// Properties
		public Query Condition { get; } // 0x0000000180357120-0x0000000180357130 
		public override QueryProps Properties { get; } // 0x0000000180C874F0-0x0000000180C87520 
	
		// Constructors
		public FilterQuery(Query qyParent, Query cond, bool noPosition); // 0x0000000180C873D0-0x0000000180C87410
		private FilterQuery(FilterQuery other); // 0x0000000180C87410-0x0000000180C874F0
	
		// Methods
		public override void Reset(); // 0x0000000180C87240-0x0000000180C872A0
		public override void SetXsltContext(XsltContext input); // 0x0000000180C872A0-0x0000000180C873D0
		public override XPathNavigator Advance(); // 0x0000000180C86ED0-0x0000000180C86F30
		internal bool EvaluatePredicate(); // 0x0000000180C87040-0x0000000180C87240
		public override XPathNodeIterator Clone(); // 0x0000000180C86F30-0x0000000180C87040
	}
}
