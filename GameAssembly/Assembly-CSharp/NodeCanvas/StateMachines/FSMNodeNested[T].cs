/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;
using ParadoxNotion.Design;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.StateMachines
{
	[Category] // 0x00000001801EE080-0x00000001801EE0E0
	[Color] // 0x00000001801EE080-0x00000001801EE0E0
	public abstract class FSMNodeNested<T> : FSMNode, IGraphAssignable<T> // TypeDefIndex: 15075
		where T : Graph
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private List<BBMappingParameter> _variablesMap;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private T <currentInstance>k__BackingField;
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Dictionary<Graph, Graph> <instances>k__BackingField;
	
		// Properties
		public abstract T subGraph { get; set; }
		public abstract BBParameter subGraphParameter { get; }
		public T currentInstance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; }
		public Dictionary<Graph, Graph> instances { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; }
		public List<BBMappingParameter> variablesMap { get; set; }
		Graph IGraphAssignable.subGraph { get; set; }
		Graph IGraphAssignable.currentInstance { get; set; }
	
		// Constructors
		protected FSMNodeNested();
	}
}
