/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Framework.Internal
{
	[Serializable]
	public class GraphSerializationData // TypeDefIndex: 14619
	{
		// Fields
		public const float FRAMEWORK_VERSION = 2.91f; // Metadata: 0x00784644
		public float version; // 0x10
		public Type type; // 0x18
		public string name; // 0x20
		public string category; // 0x28
		public string comments; // 0x30
		public Vector2 translation; // 0x38
		public float zoomFactor; // 0x40
		public List<Node> nodes; // 0x48
		public List<Connection> connections; // 0x50
		public List<NodeCanvas.Framework.CanvasGroup> canvasGroups; // 0x58
		public BlackboardSource localBlackboard; // 0x60
		public object derivedData; // 0x68
	
		// Constructors
		public GraphSerializationData(); // 0x0000000181753DF0-0x0000000181753EC0
		public GraphSerializationData(Graph graph); // 0x0000000181753B60-0x0000000181753DF0
	
		// Methods
		public void Reconstruct(Graph graph); // 0x00000001817538A0-0x0000000181753B60
	}
}
