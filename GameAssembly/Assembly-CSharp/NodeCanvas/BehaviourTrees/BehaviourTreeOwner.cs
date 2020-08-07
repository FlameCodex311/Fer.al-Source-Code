/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.BehaviourTrees
{
	[AddComponentMenu] // 0x000000018020FBD0-0x000000018020FC00
	public class BehaviourTreeOwner : GraphOwner<NodeCanvas.BehaviourTrees.BehaviourTree> // TypeDefIndex: 15145
	{
		// Properties
		public bool repeat { get; set; } // 0x00000001807C44D0-0x00000001807C4580 0x00000001807C46E0-0x00000001807C4790
		public float updateInterval { get; set; } // 0x00000001807C4630-0x00000001807C46E0 0x00000001807C4790-0x00000001807C4840
		public Status rootStatus { get; } // 0x00000001807C4580-0x00000001807C4630 
	
		// Constructors
		public BehaviourTreeOwner(); // 0x00000001807C4490-0x00000001807C44D0
	
		// Methods
		public Status Tick(); // 0x00000001807C43E0-0x00000001807C4490
	}
}
