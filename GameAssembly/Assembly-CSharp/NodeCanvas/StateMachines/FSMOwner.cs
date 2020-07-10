/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.StateMachines
{
	[AddComponentMenu] // 0x000000018015D670-0x000000018015D6A0
	public class FSMOwner : GraphOwner<NodeCanvas.StateMachines.FSM> // TypeDefIndex: 14008
	{
		// Properties
		public string currentRootStateName { get; } // 0x000000018174F5A0-0x000000018174F640 
		public string previousRootStateName { get; } // 0x000000018174F6A0-0x000000018174F740 
		public string currentDeepStateName { get; } // 0x000000018174F540-0x000000018174F5A0 
		public string previousDeepStateName { get; } // 0x000000018174F640-0x000000018174F6A0 
	
		// Constructors
		public FSMOwner(); // 0x000000018174F500-0x000000018174F540
	
		// Methods
		public IState GetCurrentState(bool includeSubFSMs = true /* Metadata: 0x0078437F */); // 0x000000018174EE10-0x000000018174EFF0
		public IState GetPreviousState(bool includeSubFSMs = true /* Metadata: 0x00784380 */); // 0x000000018174EFF0-0x000000018174F240
		public IState TriggerState(string stateName); // 0x000000018174F460-0x000000018174F500
		public string[] GetStateNames(); // 0x000000018174F240-0x000000018174F460
	}
}
