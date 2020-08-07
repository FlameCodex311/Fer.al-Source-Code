/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ParadoxNotion.Serialization.FullSerializer;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	[Serializable]
	[fsAutoInstance] // 0x0000000180218900-0x0000000180218950
	[fsForward] // 0x0000000180218900-0x0000000180218950
	public class NodeReference<T> : INodeReference // TypeDefIndex: 15716
		where T : Node
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string _targetNodeUID;
		[NonSerialized]
		private WeakReference<T> _targetNodeRef;
	
		// Properties
		Type INodeReference.type { get; }
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass8_0 // TypeDefIndex: 15717
		{
			// Fields
			public NodeReference<T> _this;
	
			// Constructors
			public <>c__DisplayClass8_0();
	
			// Methods
			internal bool <Get>b__0(T x);
		}
	
		// Constructors
		public NodeReference();
		public NodeReference(T target);
	
		// Methods
		Node INodeReference.Get(Graph graph);
		void INodeReference.Set(Node target);
		public T Get(Graph graph);
		public void Set(T target);
	}
}
