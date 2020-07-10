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
	internal class XDeferredSingleton<T> // TypeDefIndex: 5053
		where T : XObject
	{
		// Fields
		private Func<XElement, XName, T> func;
		internal XElement element;
		internal XName name;
	
		// Constructors
		public XDeferredSingleton(Func<XElement, XName, T> func, XElement element, XName name);
	}
}
