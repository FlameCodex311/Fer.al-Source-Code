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
	public class IKSolverHeuristic : IKSolver // TypeDefIndex: 9396
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
		protected virtual int minBones { get; } // 0x0000000180362180-0x0000000180362190 
		protected virtual bool boneLengthCanBeZero { get; } // 0x00000001803C29F0-0x00000001803C2A00 
		protected virtual bool allowCommonParent { get; } // 0x00000001803C28F0-0x00000001803C2900 
		protected virtual Vector3 localDirection { get; } // 0x0000000181D73490-0x0000000181D736C0 
		protected float positionOffset { get; } // 0x0000000181D736C0-0x0000000181D737A0 
	
		// Constructors
		public IKSolverHeuristic(); // 0x0000000181D639C0-0x0000000181D63A10
	
		// Methods
		public bool SetChain(Transform[] hierarchy, Transform root); // 0x0000000181D72E20-0x0000000181D73020
		public void AddBone(Transform bone); // 0x0000000181D716E0-0x0000000181D718C0
		public override void StoreDefaultLocalState(); // 0x0000000181D73400-0x0000000181D73490
		public override void FixTransforms(); // 0x0000000181D718C0-0x0000000181D71960
		public override bool IsValid(ref string message); // 0x0000000181D72980-0x0000000181D72E20
		public override Point[] GetPoints(); // 0x0000000180369B50-0x0000000180369B60
		public override Point GetPoint(Transform transform); // 0x0000000181D71960-0x0000000181D71AA0
		protected override void OnInitiate(); // 0x00000001803581E0-0x00000001803581F0
		protected override void OnUpdate(); // 0x00000001803581E0-0x00000001803581F0
		protected void InitiateBones(); // 0x0000000181D72020-0x0000000181D72980
		protected Vector3 GetSingularityOffset(); // 0x0000000181D71AA0-0x0000000181D72020
		private bool SingularityDetected(); // 0x0000000181D73020-0x0000000181D73400
	}
}
