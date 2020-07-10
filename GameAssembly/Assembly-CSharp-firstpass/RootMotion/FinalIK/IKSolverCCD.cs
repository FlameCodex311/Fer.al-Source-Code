/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	[Serializable]
	public class IKSolverCCD : IKSolverHeuristic // TypeDefIndex: 9389
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
	
		// Constructors
		public IKSolverCCD(); // 0x0000000181D639C0-0x0000000181D63A10
	
		// Methods
		public void FadeOutBoneWeights(); // 0x0000000181D62830-0x0000000181D62970
		protected override void OnInitiate(); // 0x0000000181D62970-0x0000000181D62A10
		protected override void OnUpdate(); // 0x0000000181D62A10-0x0000000181D62E00
		private void Solve(Vector3 targetPosition); // 0x0000000181D62E00-0x0000000181D639C0
	}
}
