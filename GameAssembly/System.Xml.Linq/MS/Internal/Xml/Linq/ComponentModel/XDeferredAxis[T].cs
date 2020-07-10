/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
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
	internal class XDeferredAxis<T> : IEnumerable<T> // TypeDefIndex: 5052
		where T : XObject
	{
		// Fields
		private Func<XElement, XName, IEnumerable<T>> func;
		internal XElement element;
		internal XName name;
	
		// Constructors
		public XDeferredAxis(Func<XElement, XName, IEnumerable<T>> func, XElement element, XName name);
	
		// Methods
		public IEnumerator<T> GetEnumerator();
		IEnumerator IEnumerable.GetEnumerator();
	}
}
