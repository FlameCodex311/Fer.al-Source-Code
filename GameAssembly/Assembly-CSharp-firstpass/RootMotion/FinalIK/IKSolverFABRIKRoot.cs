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
	public class IKSolverFABRIKRoot : IKSolver // TypeDefIndex: 9925
	{
		// Fields
		public int iterations; // 0x58
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float rootPin; // 0x5C
		public FABRIKChain[] chains; // 0x60
		private bool zeroWeightApplied; // 0x68
		private bool[] isRoot; // 0x70
		private Vector3 rootDefaultPosition; // 0x78
	
		// Constructors
		public IKSolverFABRIKRoot(); // 0x00000001819EE9F0-0x00000001819EEA50
	
		// Methods
		public override bool IsValid(ref string message); // 0x00000001819ED3C0-0x00000001819EE3A0
		public override void StoreDefaultLocalState(); // 0x00000001819EE910-0x00000001819EE9F0
		public override void FixTransforms(); // 0x00000001819ECB20-0x00000001819ECC10
		protected override void OnInitiate(); // 0x00000001819EE3A0-0x00000001819EE5F0
		private bool IsRoot(int index); // 0x00000001819ED2B0-0x00000001819ED3C0
		protected override void OnUpdate(); // 0x00000001819EE5F0-0x00000001819EE910
		public override Point[] GetPoints(); // 0x00000001819ED1F0-0x00000001819ED2B0
		public override Point GetPoint(Transform transform); // 0x00000001819ED120-0x00000001819ED1F0
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain); // 0x00000001819EC990-0x00000001819ECB20
		private Vector3 GetCentroid(); // 0x00000001819ECC10-0x00000001819ED120
	}
}
