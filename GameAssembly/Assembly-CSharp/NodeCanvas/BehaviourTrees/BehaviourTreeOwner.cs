/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.BehaviourTrees
{
	[AddComponentMenu] // 0x0000000180162450-0x0000000180162480
	public class BehaviourTreeOwner : GraphOwner<NodeCanvas.BehaviourTrees.BehaviourTree> // TypeDefIndex: 14025
	{
		// Properties
		public bool repeat { get; set; } // 0x00000001815602B0-0x0000000181560340 0x0000000181560460-0x00000001815604F0
		public float updateInterval { get; set; } // 0x00000001815603D0-0x0000000181560460 0x00000001815604F0-0x0000000181560580
		public Status rootStatus { get; } // 0x0000000181560340-0x00000001815603D0 
	
		// Constructors
		public BehaviourTreeOwner(); // 0x0000000181560270-0x00000001815602B0
	
		// Methods
		public Status Tick(); // 0x00000001815601A0-0x0000000181560270
	}
}
