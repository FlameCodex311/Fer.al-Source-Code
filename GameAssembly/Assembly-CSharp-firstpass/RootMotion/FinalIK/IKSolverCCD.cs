/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic // TypeDefIndex: 9923
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
	
		// Constructors
		public IKSolverCCD(); // 0x00000001819EC980-0x00000001819EC990
	
		// Methods
		public void FadeOutBoneWeights(); // 0x00000001819EB890-0x00000001819EB9C0
		protected override void OnInitiate(); // 0x00000001819EB9C0-0x00000001819EBA50
		protected override void OnUpdate(); // 0x00000001819EBA50-0x00000001819EBE40
		private void Solve(Vector3 targetPosition); // 0x00000001819EBE40-0x00000001819EC980
	}
}
