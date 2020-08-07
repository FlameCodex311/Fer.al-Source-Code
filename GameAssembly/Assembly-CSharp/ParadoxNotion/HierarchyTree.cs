/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion
{
	public class HierarchyTree // TypeDefIndex: 15821
	{
		// Nested types
		public class Element // TypeDefIndex: 15822
		{
			// Fields
			private object _reference; // 0x10
			private Element _parent; // 0x18
			private List<Element> _children; // 0x20
	
			// Properties
			public object reference { get; } // 0x0000000180372440-0x0000000180372450 
			public Element parent { get; } // 0x0000000180372430-0x0000000180372440 
			public IEnumerable<Element> children { get; } // 0x0000000180374AF0-0x0000000180374B00 
	
			// Nested types
			[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
			private sealed class <GetAllChildrenReferencesOfType>d__15<T> : IEnumerable<T>, IEnumerator<T> // TypeDefIndex: 15823
			{
				// Fields
				private int <>1__state;
				private T <>2__current;
				private int <>l__initialThreadId;
				public Element <>4__this;
				private int <i>5__2;
				private Element <element>5__3;
				private IEnumerator<T> <>7__wrap3;
	
				// Properties
				T IEnumerator<T>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
				object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; }
	
				// Constructors
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				public <GetAllChildrenReferencesOfType>d__15(int <>1__state);
	
				// Methods
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IDisposable.Dispose();
				private bool MoveNext();
				private void <>m__Finally1();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				void IEnumerator.Reset();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator<T> IEnumerable<T>.GetEnumerator();
				[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
				IEnumerator IEnumerable.GetEnumerator();
			}
	
			// Constructors
			public Element(object reference); // 0x0000000180400150-0x0000000180400180
	
			// Methods
			public Element AddChild(Element child); // 0x00000001806C9970-0x00000001806C9A10
			public void RemoveChild(Element child); // 0x00000001806C9B30-0x00000001806C9BA0
			public Element GetRoot(); // 0x00000001806C9B10-0x00000001806C9B30
			public Element FindReferenceElement(object target); // 0x00000001806C9A10-0x00000001806C9B10
			public T GetFirstParentReferenceOfType<T>();
			[IteratorStateMachine] // 0x0000000180235970-0x00000001802359C0
			public IEnumerable<T> GetAllChildrenReferencesOfType<T>();
		}
	
		// Constructors
		public HierarchyTree(); // 0x0000000180373240-0x0000000180373250
	}
}
