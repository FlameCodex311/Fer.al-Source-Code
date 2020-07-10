/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;
using UnityEngine.AI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800FF200-0x00000001800FF260
	[Name] // 0x00000001800FF200-0x00000001800FF260
	public class MoveToPosition : ActionTask<NavMeshAgent> // TypeDefIndex: 14298
	{
		// Fields
		public BBParameter<Vector3> targetPosition; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> keepDistance; // 0x78
		private Vector3? lastRequest; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000181552320-0x0000000181552360 
	
		// Constructors
		public MoveToPosition(); // 0x00000001815522B0-0x0000000181552320
	
		// Methods
		protected override void OnExecute(); // 0x0000000181551DC0-0x0000000181551F80
		protected override void OnUpdate(); // 0x0000000181552030-0x00000001815522B0
		protected override void OnStop(); // 0x0000000181551F80-0x0000000181552030
		protected override void OnPause(); // 0x000000018090E380-0x000000018090E3A0
	}
}
