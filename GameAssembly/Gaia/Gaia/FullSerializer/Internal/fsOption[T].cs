/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer.Internal
{
	public struct fsOption<T> // TypeDefIndex: 9157
	{
		// Fields
		private bool _hasValue;
		private T _value;
		public static fsOption<T> Empty;
	
		// Properties
		public bool HasValue { get; }
		public bool IsEmpty { get; }
		public T Value { get; }
	
		// Constructors
		public fsOption(T value);
	}
}
