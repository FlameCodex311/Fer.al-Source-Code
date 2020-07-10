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
using System.Xml.Linq;

// Image 21: System.Xml.Linq.dll - Assembly: System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35 - Types 4994-5056

namespace MS.Internal.Xml.Linq.ComponentModel
{
	internal class XElementElementsPropertyDescriptor : XPropertyDescriptor<XElement, IEnumerable<XElement>> // TypeDefIndex: 5047
	{
		// Fields
		private XDeferredAxis<XElement> value; // 0x88
		private object changeState; // 0x90
	
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 5048
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<XElement, XName, IEnumerable<XElement>> <>9__3_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180D6DB40-0x0000000180D6DBA0
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal IEnumerable<XElement> <GetValue>b__3_0(XElement e, XName n); // 0x0000000180D6D920-0x0000000180D6D9D0
		}
	
		// Constructors
		public XElementElementsPropertyDescriptor(); // 0x0000000180D75C60-0x0000000180D75CA0
	
		// Methods
		public override object GetValue(object component); // 0x0000000180D75720-0x0000000180D75890
		protected override void OnChanged(object sender, XObjectChangeEventArgs args); // 0x0000000180D75890-0x0000000180D75B50
		protected override void OnChanging(object sender, XObjectChangeEventArgs args); // 0x0000000180D75B50-0x0000000180D75C60
	}
}
