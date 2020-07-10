/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

// Image 21: System.Xml.Linq.dll - Assembly: System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35 - Types 4994-5056

namespace MS.Internal.Xml.Linq.ComponentModel
{
	internal class XElementValuePropertyDescriptor : XPropertyDescriptor<XElement, string> // TypeDefIndex: 5049
	{
		// Fields
		private XElement element; // 0x88
	
		// Properties
		public override bool IsReadOnly { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Constructors
		public XElementValuePropertyDescriptor(); // 0x0000000180D76010-0x0000000180D76050
	
		// Methods
		public override object GetValue(object component); // 0x0000000180D75CA0-0x0000000180D75D50
		public override void SetValue(object component, object value); // 0x0000000180D75EE0-0x0000000180D76010
		protected override void OnChanged(object sender, XObjectChangeEventArgs args); // 0x0000000180D75D50-0x0000000180D75EE0
	}
}
