/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace Prototype
{
	public class InteractionVolare : Interactable // TypeDefIndex: 16061
	{
		// Fields
		public static List<InteractionVolare> activeVolares; // 0x00
		private Rigidbody _rigidbody; // 0x1A0
		private NavMeshAgent _agent; // 0x1A8
		private Transform _followTarget; // 0x1B0
	
		// Properties
		public Rigidbody m_rigidbody { get; } // 0x00000001813A58B0-0x00000001813A5940 
	
		// Constructors
		public InteractionVolare(); // 0x0000000180F5D120-0x0000000180F5D130
		static InteractionVolare(); // 0x00000001813A5850-0x00000001813A58B0
	}
}
