/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion.Serialization.FullSerializer.Internal
{
	public class fsCyclicReferenceManager // TypeDefIndex: 15332
	{
		// Fields
		private Dictionary<object, int> _objectIds; // 0x10
		private int _nextId; // 0x18
		private Dictionary<int, object> _marked; // 0x20
		private int _depth; // 0x28
	
		// Nested types
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object> // TypeDefIndex: 15333
		{
			// Fields
			public static readonly IEqualityComparer<object> Instance; // 0x00
	
			// Constructors
			public ObjectReferenceEqualityComparator(); // 0x000000018036B6C0-0x000000018036B6D0
			static ObjectReferenceEqualityComparator(); // 0x0000000181381A10-0x0000000181381A70
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y); // 0x00000001804F7880-0x00000001804F7890
			int IEqualityComparer<object>.GetHashCode(object obj); // 0x00000001804F7890-0x00000001804F7A10
		}
	
		// Constructors
		public fsCyclicReferenceManager(); // 0x000000018138C5F0-0x000000018138C6B0
	
		// Methods
		public void Enter(); // 0x0000000180861010-0x0000000180861020
		public bool Exit(); // 0x000000018138C270-0x000000018138C330
		public object GetReferenceObject(int id); // 0x000000018138C3D0-0x000000018138C4A0
		public void AddReferenceWithId(int id, object reference); // 0x000000018138C200-0x000000018138C270
		public int GetReferenceId(object item); // 0x000000018138C330-0x000000018138C3D0
		public bool IsReference(object item); // 0x000000018138C4A0-0x000000018138C510
		public void MarkSerialized(object item); // 0x000000018138C510-0x000000018138C5F0
	}
}
