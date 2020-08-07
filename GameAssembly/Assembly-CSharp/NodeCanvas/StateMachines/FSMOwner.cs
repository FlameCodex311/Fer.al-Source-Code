/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.StateMachines
{
	[AddComponentMenu] // 0x00000001801EEDF0-0x00000001801EEE20
	public class FSMOwner : GraphOwner<NodeCanvas.StateMachines.FSM> // TypeDefIndex: 15076
	{
		// Properties
		public string currentRootStateName { get; } // 0x0000000180CC3C80-0x0000000180CC3D40 
		public string previousRootStateName { get; } // 0x0000000180CC3DA0-0x0000000180CC3E60 
		public string currentDeepStateName { get; } // 0x0000000180CC3C20-0x0000000180CC3C80 
		public string previousDeepStateName { get; } // 0x0000000180CC3D40-0x0000000180CC3DA0 
	
		// Constructors
		public FSMOwner(); // 0x0000000180CC3BE0-0x0000000180CC3C20
	
		// Methods
		public IState GetCurrentState(bool includeSubFSMs = true /* Metadata: 0x007BB145 */); // 0x0000000180CC33B0-0x0000000180CC3570
		public IState GetPreviousState(bool includeSubFSMs = true /* Metadata: 0x007BB146 */); // 0x0000000180CC3570-0x0000000180CC37B0
		public IState TriggerState(string stateName); // 0x0000000180CC3A00-0x0000000180CC3A10
		public IState TriggerState(string stateName, FSM.TransitionCallMode callMode); // 0x0000000180CC3A10-0x0000000180CC3BE0
		public string[] GetStateNames(); // 0x0000000180CC37B0-0x0000000180CC3A00
	}
}
