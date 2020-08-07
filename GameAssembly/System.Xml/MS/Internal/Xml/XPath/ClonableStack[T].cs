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

// Image 3: System.Xml.dll - Assembly: System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e - Types 1917-2643

namespace MS.Internal.Xml.XPath
{
	internal sealed class ClonableStack<T> : List<T> // TypeDefIndex: 1934
	{
		// Constructors
		public ClonableStack();
		private ClonableStack(IEnumerable<T> collection);
	
		// Methods
		public void Push(T value);
		public T Pop();
		public T Peek();
		public ClonableStack<T> Clone();
	}
}
