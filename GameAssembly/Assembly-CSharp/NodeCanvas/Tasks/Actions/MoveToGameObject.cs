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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x0000000180263330-0x0000000180263390
	[Name] // 0x0000000180263330-0x0000000180263390
	public class MoveToGameObject : ActionTask<NavMeshAgent> // TypeDefIndex: 15400
	{
		// Fields
		[RequiredField] // 0x00000001801CDAD0-0x00000001801CDAE0
		public BBParameter<GameObject> target; // 0x68
		public BBParameter<float> speed; // 0x70
		public BBParameter<float> keepDistance; // 0x78
		private Vector3? lastRequest; // 0x80
	
		// Properties
		protected override string info { get; } // 0x0000000180BB7EE0-0x0000000180BB7F20 
	
		// Constructors
		public MoveToGameObject(); // 0x0000000180BB7E70-0x0000000180BB7EE0
	
		// Methods
		protected override void OnExecute(); // 0x0000000180BB7880-0x0000000180BB7AE0
		protected override void OnUpdate(); // 0x0000000180BB7B80-0x0000000180BB7E70
		protected override void OnStop(); // 0x0000000180BB7AE0-0x0000000180BB7B80
		protected override void OnPause(); // 0x00000001804F1140-0x00000001804F1160
		public override void OnDrawGizmosSelected(); // 0x0000000180BB7760-0x0000000180BB7880
	}
}
