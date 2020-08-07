/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Framework
{
	public abstract class GraphOwner<T> : GraphOwner // TypeDefIndex: 15694
		where T : Graph
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private T _graph;
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.Object _blackboard;
	
		// Properties
		public sealed override Graph graph { get; set; }
		public T behaviour { get; set; }
		public sealed override IBlackboard blackboard { get; set; }
		public sealed override Type graphType { get; }
	
		// Constructors
		protected GraphOwner();
	
		// Methods
		public void StartBehaviour(T newGraph);
		public void StartBehaviour(T newGraph, Action<bool> callback);
		public void StartBehaviour(T newGraph, Graph.UpdateMode updateMode, Action<bool> callback = null);
		public void SwitchBehaviour(T newGraph);
		public void SwitchBehaviour(T newGraph, Action<bool> callback);
		public void SwitchBehaviour(T newGraph, Graph.UpdateMode updateMode, Action<bool> callback = null);
	}
}
