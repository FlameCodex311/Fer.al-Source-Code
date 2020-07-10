/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001800FF930-0x00000001800FF990
	[Description] // 0x00000001800FF930-0x00000001800FF990
	public class Wander : ActionTask<NavMeshAgent> // TypeDefIndex: 14301
	{
		// Fields
		public BBParameter<float> speed; // 0x68
		public BBParameter<float> keepDistance; // 0x70
		public BBParameter<float> minWanderDistance; // 0x78
		public BBParameter<float> maxWanderDistance; // 0x80
		public bool repeat; // 0x88
	
		// Constructors
		public Wander(); // 0x00000001812698A0-0x0000000181269950
	
		// Methods
		protected override void OnExecute(); // 0x0000000181269620-0x00000001812696B0
		protected override void OnUpdate(); // 0x0000000181269790-0x00000001812698A0
		private void DoWander(); // 0x0000000181269200-0x0000000181269620
		protected override void OnPause(); // 0x000000018090E380-0x000000018090E3A0
		protected override void OnStop(); // 0x00000001812696B0-0x0000000181269790
	}
}
