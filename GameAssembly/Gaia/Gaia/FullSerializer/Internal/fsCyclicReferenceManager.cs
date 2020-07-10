/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 77: Gaia.dll - Assembly: Gaia, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8983-9188

namespace Gaia.FullSerializer.Internal
{
	public class fsCyclicReferenceManager // TypeDefIndex: 9155
	{
		// Fields
		private Dictionary<object, int> _objectIds; // 0x10
		private int _nextId; // 0x18
		private Dictionary<int, object> _marked; // 0x20
		private int _depth; // 0x28
	
		// Nested types
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object> // TypeDefIndex: 9156
		{
			// Fields
			public static readonly IEqualityComparer<object> Instance; // 0x00
	
			// Constructors
			public ObjectReferenceEqualityComparator(); // 0x000000018036B6C0-0x000000018036B6D0
			static ObjectReferenceEqualityComparator(); // 0x00000001818E7DE0-0x00000001818E7E40
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y); // 0x00000001804F7880-0x00000001804F7890
			int IEqualityComparer<object>.GetHashCode(object obj); // 0x00000001804F7890-0x00000001804F7A10
		}
	
		// Constructors
		public fsCyclicReferenceManager(); // 0x00000001818ED440-0x00000001818ED500
	
		// Methods
		public void Enter(); // 0x0000000180861010-0x0000000180861020
		public bool Exit(); // 0x00000001818ED060-0x00000001818ED170
		public object GetReferenceObject(int id); // 0x00000001818ED210-0x00000001818ED2F0
		public void AddReferenceWithId(int id, object reference); // 0x00000001818ECFF0-0x00000001818ED060
		public int GetReferenceId(object item); // 0x00000001818ED170-0x00000001818ED210
		public bool IsReference(object item); // 0x00000001818ED2F0-0x00000001818ED360
		public void MarkSerialized(object item); // 0x00000001818ED360-0x00000001818ED440
	}
}
