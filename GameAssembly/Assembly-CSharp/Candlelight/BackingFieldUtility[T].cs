/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Candlelight
{
	public static class BackingFieldUtility<T> // TypeDefIndex: 14475
		where T : IPropertyBackingFieldCompatible
	{
		// Fields
		private static CollectionComparer s_Comparer;
	
		// Properties
		public static CollectionComparer Comparer { get; }
	
		// Nested types
		public class CollectionComparer : IEqualityComparer<T> // TypeDefIndex: 14476
		{
			// Constructors
			public CollectionComparer();
	
			// Methods
			public bool Equals(T a, T b);
			public int GetHashCode(T obj);
		}
	
		// Constructors
		static BackingFieldUtility();
	}
}
