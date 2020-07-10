/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Xml.Linq;

// Image 21: System.Xml.Linq.dll - Assembly: System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35 - Types 4994-5056

namespace MS.Internal.Xml.Linq.ComponentModel
{
	internal abstract class XPropertyDescriptor<T, TProperty> : PropertyDescriptor // TypeDefIndex: 5040
		where T : XObject
	{
		// Properties
		public override Type ComponentType { get; }
		public override bool IsReadOnly { get; }
		public override Type PropertyType { get; }
		public override bool SupportsChangeEvents { get; }
	
		// Constructors
		public XPropertyDescriptor(string name);
	
		// Methods
		public override void AddValueChanged(object component, EventHandler handler);
		public override bool CanResetValue(object component);
		public override void RemoveValueChanged(object component, EventHandler handler);
		public override void ResetValue(object component);
		public override void SetValue(object component, object value);
		public override bool ShouldSerializeValue(object component);
		protected virtual void OnChanged(object sender, XObjectChangeEventArgs args);
		protected virtual void OnChanging(object sender, XObjectChangeEventArgs args);
	}
}
