/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine.AI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace NodeCanvas.Tasks.Actions
{
	[Category] // 0x00000001802662F0-0x0000000180266350
	[Description] // 0x00000001802662F0-0x0000000180266350
	public class Wander : ActionTask<NavMeshAgent> // TypeDefIndex: 15404
	{
		// Fields
		public BBParameter<float> speed; // 0x68
		public BBParameter<float> keepDistance; // 0x70
		public BBParameter<float> minWanderDistance; // 0x78
		public BBParameter<float> maxWanderDistance; // 0x80
		public bool repeat; // 0x88
	
		// Constructors
		public Wander(); // 0x00000001807ADBC0-0x00000001807ADC70
	
		// Methods
		protected override void OnExecute(); // 0x00000001807AD940-0x00000001807AD9D0
		protected override void OnUpdate(); // 0x00000001807ADAB0-0x00000001807ADBC0
		private void DoWander(); // 0x00000001807AD530-0x00000001807AD940
		protected override void OnPause(); // 0x00000001804F1140-0x00000001804F1160
		protected override void OnStop(); // 0x00000001807AD9D0-0x00000001807ADAB0
	}
}
