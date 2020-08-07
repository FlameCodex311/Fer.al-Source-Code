/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion.Serialization.FullSerializer
{
	public class fsCyclicReferenceManager // TypeDefIndex: 15908
	{
		// Fields
		private Dictionary<object, int> _objectIds; // 0x10
		private int _nextId; // 0x18
		private Dictionary<int, object> _marked; // 0x20
		private int _depth; // 0x28
	
		// Nested types
		private class ObjectReferenceEqualityComparator : IEqualityComparer<object> // TypeDefIndex: 15909
		{
			// Fields
			public static readonly IEqualityComparer<object> Instance; // 0x00
	
			// Constructors
			public ObjectReferenceEqualityComparator(); // 0x0000000180373240-0x0000000180373250
			static ObjectReferenceEqualityComparator(); // 0x00000001811A9310-0x00000001811A9370
	
			// Methods
			bool IEqualityComparer<object>.Equals(object x, object y); // 0x0000000180442CA0-0x0000000180442CB0
			int IEqualityComparer<object>.GetHashCode(object obj); // 0x0000000180E9CB30-0x0000000180E9CCB0
		}
	
		// Constructors
		public fsCyclicReferenceManager(); // 0x00000001811AD470-0x00000001811AD530
	
		// Methods
		public void Clear(); // 0x00000001811AD070-0x00000001811AD0E0
		public bool Enter(); // 0x00000001811AD0E0-0x00000001811AD0F0
		public bool Exit(); // 0x00000001811AD0F0-0x00000001811AD1B0
		public object GetReferenceObject(int id); // 0x00000001811AD250-0x00000001811AD320
		public void AddReferenceWithId(int id, object reference); // 0x00000001811AD000-0x00000001811AD070
		public int GetReferenceId(object item); // 0x00000001811AD1B0-0x00000001811AD250
		public bool IsReference(object item); // 0x00000001811AD320-0x00000001811AD390
		public void MarkSerialized(object item); // 0x00000001811AD390-0x00000001811AD470
	}
}
