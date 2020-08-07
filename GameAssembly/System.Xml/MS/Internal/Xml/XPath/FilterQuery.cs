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
	internal sealed class FilterQuery : BaseAxisQuery // TypeDefIndex: 1945
	{
		// Fields
		private Query cond; // 0x58
		private bool noPosition; // 0x60
	
		// Properties
		public Query Condition { get; } // 0x00000001803A1580-0x00000001803A1590 
		public override QueryProps Properties { get; } // 0x00000001819BF2A0-0x00000001819BF2D0 
	
		// Constructors
		public FilterQuery(Query qyParent, Query cond, bool noPosition); // 0x00000001819BF180-0x00000001819BF1C0
		private FilterQuery(FilterQuery other); // 0x00000001819BF1C0-0x00000001819BF2A0
	
		// Methods
		public override void Reset(); // 0x00000001819BF000-0x00000001819BF060
		public override void SetXsltContext(XsltContext input); // 0x00000001819BF060-0x00000001819BF180
		public override XPathNavigator Advance(); // 0x00000001819BEC90-0x00000001819BECF0
		internal bool EvaluatePredicate(); // 0x00000001819BEE00-0x00000001819BF000
		public override XPathNodeIterator Clone(); // 0x00000001819BECF0-0x00000001819BEE00
	}
}
