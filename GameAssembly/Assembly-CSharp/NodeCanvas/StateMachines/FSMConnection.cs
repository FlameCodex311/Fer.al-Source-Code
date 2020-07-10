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
	public class FSMConnection : Connection, ITaskAssignable<ConditionTask> // TypeDefIndex: 14007
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ConditionTask _condition; // 0x28
	
		// Properties
		public ConditionTask condition { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
		public Task task { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x000000018174ED80-0x000000018174EE10
	
		// Constructors
		public FSMConnection(); // 0x000000018174C600-0x000000018174C610
	
		// Methods
		public void PerformTransition(); // 0x000000018174EC30-0x000000018174ED80
	}
}
