/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion
{
	public class HierarchyTree // TypeDefIndex: 14680
	{
		// Nested types
		public class Element // TypeDefIndex: 14681
		{
			// Fields
			public object reference; // 0x10
			public Element parent; // 0x18
			public List<Element> children; // 0x20
	
			// Constructors
			public Element(object reference); // 0x000000018037D3F0-0x000000018037D420
	
			// Methods
			public void AddChild(Element child); // 0x0000000180E8DFA0-0x0000000180E8E040
			public void RemoveChild(Element child); // 0x0000000180E8E160-0x0000000180E8E1B0
			public Element GetRoot(); // 0x0000000180E8E140-0x0000000180E8E160
			public Element FindReferenceElement(object target); // 0x0000000180E8E040-0x0000000180E8E140
			public T GetFirstParentReferenceOfType<T>();
			public List<T> GetAllChildrenReferencesOfType<T>();
		}
	
		// Constructors
		public HierarchyTree(); // 0x000000018036B6C0-0x000000018036B6D0
	}
}
