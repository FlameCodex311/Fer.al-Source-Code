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
	public class IKSolverHeuristic : IKSolver // TypeDefIndex: 9930
	{
		// Fields
		public Transform target; // 0x58
		public float tolerance; // 0x60
		public int maxIterations; // 0x64
		public bool useRotationLimits; // 0x68
		public bool XY; // 0x69
		public Bone[] bones; // 0x70
		protected Vector3 lastLocalDirection; // 0x78
		protected float chainLength; // 0x84
	
		// Properties
		protected virtual int minBones { get; } // 0x0000000180411150-0x0000000180411160 
		protected virtual bool boneLengthCanBeZero { get; } // 0x0000000180380B60-0x0000000180380B70 
		protected virtual bool allowCommonParent { get; } // 0x0000000180380950-0x0000000180380960 
		protected virtual Vector3 localDirection { get; } // 0x0000000181AA1E20-0x0000000181AA2030 
		protected float positionOffset { get; } // 0x0000000181AA2030-0x0000000181AA2110 
	
		// Constructors
		public IKSolverHeuristic(); // 0x0000000181AA1DD0-0x0000000181AA1E20
	
		// Methods
		public bool SetChain(Transform[] hierarchy, Transform root); // 0x0000000181AA1790-0x0000000181AA1970
		public void AddBone(Transform bone); // 0x0000000181AA0110-0x0000000181AA02E0
		public override void StoreDefaultLocalState(); // 0x0000000181AA1D40-0x0000000181AA1DD0
		public override void FixTransforms(); // 0x0000000181AA02E0-0x0000000181AA0380
		public override bool IsValid(ref string message); // 0x0000000181AA1300-0x0000000181AA1790
		public override Point[] GetPoints(); // 0x0000000180418980-0x0000000180418990
		public override Point GetPoint(Transform transform); // 0x0000000181AA0380-0x0000000181AA04B0
		protected override void OnInitiate(); // 0x00000001803774A0-0x00000001803774B0
		protected override void OnUpdate(); // 0x00000001803774A0-0x00000001803774B0
		protected void InitiateBones(); // 0x0000000181AA0A10-0x0000000181AA1300
		protected Vector3 GetSingularityOffset(); // 0x0000000181AA04B0-0x0000000181AA0A10
		private bool SingularityDetected(); // 0x0000000181AA1970-0x0000000181AA1D40
	}
}
