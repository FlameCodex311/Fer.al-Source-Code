/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework
{
	public abstract class GraphOwner<T> : GraphOwner // TypeDefIndex: 14567
		where T : Graph
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private T _graph;
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
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
		public void StartBehaviour(T newGraph, bool autoUpdate, Action<bool> callback);
		public void SwitchBehaviour(T newGraph);
		public void SwitchBehaviour(T newGraph, Action<bool> callback);
		public void SwitchBehaviour(T newGraph, bool autoUpdate, Action<bool> callback);
	}
}
