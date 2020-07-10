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
	public class IKSolverFABRIKRoot : IKSolver // TypeDefIndex: 9391
	{
		// Fields
		public int iterations; // 0x58
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float rootPin; // 0x5C
		public FABRIKChain[] chains; // 0x60
		private bool zeroWeightApplied; // 0x68
		private bool[] isRoot; // 0x70
		private Vector3 rootDefaultPosition; // 0x78
	
		// Constructors
		public IKSolverFABRIKRoot(); // 0x0000000181D65BF0-0x0000000181D65C40
	
		// Methods
		public override bool IsValid(ref string message); // 0x0000000181D64490-0x0000000181D65560
		public override void StoreDefaultLocalState(); // 0x0000000181D65B10-0x0000000181D65BF0
		public override void FixTransforms(); // 0x0000000181D63BC0-0x0000000181D63CB0
		protected override void OnInitiate(); // 0x0000000181D65560-0x0000000181D657D0
		private bool IsRoot(int index); // 0x0000000181D64370-0x0000000181D64490
		protected override void OnUpdate(); // 0x0000000181D657D0-0x0000000181D65B10
		public override Point[] GetPoints(); // 0x0000000181D642B0-0x0000000181D64370
		public override Point GetPoint(Transform transform); // 0x0000000181D641E0-0x0000000181D642B0
		private void AddPointsToArray(ref Point[] array, FABRIKChain chain); // 0x0000000181D63A10-0x0000000181D63BC0
		private Vector3 GetCentroid(); // 0x0000000181D63CB0-0x0000000181D641E0
	}
}
