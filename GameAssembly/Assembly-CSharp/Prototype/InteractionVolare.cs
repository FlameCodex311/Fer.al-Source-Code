/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace Prototype
{
	public class InteractionVolare : Interactable // TypeDefIndex: 14831
	{
		// Fields
		public static List<InteractionVolare> activeVolares; // 0x00
		private Rigidbody _rigidbody; // 0x1A0
		private NavMeshAgent _agent; // 0x1A8
		private Transform _followTarget; // 0x1B0
	
		// Properties
		public Rigidbody m_rigidbody { get; } // 0x0000000180ADC900-0x0000000180ADC990 
	
		// Constructors
		public InteractionVolare(); // 0x00000001804EF080-0x00000001804EF090
		static InteractionVolare(); // 0x0000000180ADC8A0-0x0000000180ADC900
	}
}
