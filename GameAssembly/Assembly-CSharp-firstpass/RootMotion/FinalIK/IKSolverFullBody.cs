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
	public class IKSolverFullBody : IKSolver // TypeDefIndex: 9926
	{
		// Fields
		[Range] // 0x0000000180247EA0-0x0000000180247EC0
		public int iterations; // 0x58
		public FBIKChain[] chain; // 0x60
		public IKEffector[] effectors; // 0x68
		public IKMappingSpine spineMapping; // 0x70
		public IKMappingBone[] boneMappings; // 0x78
		public IKMappingLimb[] limbMappings; // 0x80
		public bool FABRIKPass; // 0x88
		public UpdateDelegate OnPreRead; // 0x90
		public UpdateDelegate OnPreSolve; // 0x98
		public IterationDelegate OnPreIteration; // 0xA0
		public IterationDelegate OnPostIteration; // 0xA8
		public UpdateDelegate OnPreBend; // 0xB0
		public UpdateDelegate OnPostSolve; // 0xB8
		public UpdateDelegate OnStoreDefaultLocalState; // 0xC0
		public UpdateDelegate OnFixTransforms; // 0xC8
	
		// Constructors
		public IKSolverFullBody(); // 0x00000001819F4F80-0x00000001819F51A0
	
		// Methods
		public IKEffector GetEffector(Transform t); // 0x00000001819F3250-0x00000001819F3380
		public FBIKChain GetChain(Transform transform); // 0x00000001819F3200-0x00000001819F3250
		public int GetChainIndex(Transform transform); // 0x00000001819F3050-0x00000001819F3200
		public Node GetNode(int chainIndex, int nodeIndex); // 0x00000001819F3380-0x00000001819F33F0
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex); // 0x00000001819F2FC0-0x00000001819F3050
		public override Point[] GetPoints(); // 0x00000001819F3600-0x00000001819F3850
		public override Point GetPoint(Transform transform); // 0x00000001819F33F0-0x00000001819F3600
		public override bool IsValid(ref string message); // 0x00000001819F3850-0x00000001819F3AF0
		public override void StoreDefaultLocalState(); // 0x00000001819F4B60-0x00000001819F4E10
		public override void FixTransforms(); // 0x00000001819F2BF0-0x00000001819F2FC0
		protected override void OnInitiate(); // 0x00000001819F3AF0-0x00000001819F3D00
		protected override void OnUpdate(); // 0x00000001819F3D00-0x00000001819F3FB0
		protected virtual void ReadPose(); // 0x00000001819F3FB0-0x00000001819F45B0
		protected virtual void Solve(); // 0x00000001819F45B0-0x00000001819F4B60
		protected virtual void ApplyBendConstraints(); // 0x00000001819F2BA0-0x00000001819F2BF0
		protected virtual void WritePose(); // 0x00000001819F4E10-0x00000001819F4F80
	}
}
