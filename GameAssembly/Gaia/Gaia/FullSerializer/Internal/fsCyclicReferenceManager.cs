/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 78: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9149-9354

namespace Gaia.FullSerializer.Internal
{
	public class fsCyclicReferenceManager // TypeDefIndex: 9319
	{
		// Fields
		private Dictionary<object, int> _objectIds; // 0x10
		private int _nextId; // 0x18
		private Dictionary<int, object> _marked; // 0x20
		private int _depth; // 0x28
	
		// Nested types
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object> // TypeDefIndex: 9320
		{
			// Fields
			public static readonly IEqualityComparer<object> Instance; // 0x00
	
			// Constructors
			public ObjectReferenceEqualityComparator(); // 0x0000000180373240-0x0000000180373250
			static ObjectReferenceEqualityComparator(); // 0x000000018150E690-0x000000018150E6F0
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y); // 0x0000000180442CA0-0x0000000180442CB0
			int IEqualityComparer<object>.GetHashCode(object obj); // 0x0000000180E9CB30-0x0000000180E9CCB0
		}
	
		// Constructors
		public fsCyclicReferenceManager(); // 0x0000000181512F90-0x0000000181513050
	
		// Methods
		public void Enter(); // 0x0000000180B54400-0x0000000180B54410
		public bool Exit(); // 0x0000000181512BC0-0x0000000181512CD0
		public object GetReferenceObject(int id); // 0x0000000181512D70-0x0000000181512E40
		public void AddReferenceWithId(int id, object reference); // 0x0000000181512B50-0x0000000181512BC0
		public int GetReferenceId(object item); // 0x0000000181512CD0-0x0000000181512D70
		public bool IsReference(object item); // 0x0000000181512E40-0x0000000181512EB0
		public void MarkSerialized(object item); // 0x0000000181512EB0-0x0000000181512F90
	}
}
