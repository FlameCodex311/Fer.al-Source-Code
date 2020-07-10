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
	[Category] // 0x00000001800FEE30-0x00000001800FEE90
	[Name] // 0x00000001800FEE30-0x00000001800FEE90
	public class MoveToGameObject : ActionTask<NavMeshAgent> // TypeDefIndex: 14297
	{
		// Fields
		[RequiredField] // 0x00000001800B36B0-0x00000001800B36C0
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> keepDistance; // 0x78
		private Vector3? lastRequest; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000181551D80-0x0000000181551DC0 
	
		// Constructors
		public MoveToGameObject(); // 0x0000000181551D10-0x0000000181551D80
	
		// Methods
		protected override void OnExecute(); // 0x00000001815517E0-0x00000001815519E0
		protected override void OnUpdate(); // 0x0000000181551A90-0x0000000181551D10
		protected override void OnStop(); // 0x00000001815519E0-0x0000000181551A90
		protected override void OnPause(); // 0x000000018090E380-0x000000018090E3A0
		public override void OnDrawGizmosSelected(); // 0x00000001815516C0-0x00000001815517E0
	}
}
