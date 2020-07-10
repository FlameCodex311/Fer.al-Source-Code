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
	public class IKSolverFullBody : IKSolver // TypeDefIndex: 9392
	{
		// Fields
		[Range] // 0x000000018010C460-0x000000018010C480
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
		public IKSolverFullBody(); // 0x0000000181D71620-0x0000000181D716E0
	
		// Methods
		public IKEffector GetEffector(Transform t); // 0x0000000181D6FAD0-0x0000000181D6FC10
		public FBIKChain GetChain(Transform transform); // 0x0000000181D6FA70-0x0000000181D6FAD0
		public int GetChainIndex(Transform transform); // 0x0000000181D6F8A0-0x0000000181D6FA70
		public Node GetNode(int chainIndex, int nodeIndex); // 0x0000000181D6FC10-0x0000000181D6FC90
		public void GetChainAndNodeIndexes(Transform transform, out int chainIndex, out int nodeIndex); // 0x0000000181D6F800-0x0000000181D6F8A0
		public override Point[] GetPoints(); // 0x0000000181D6FED0-0x0000000181D70150
		public override Point GetPoint(Transform transform); // 0x0000000181D6FC90-0x0000000181D6FED0
		public override bool IsValid(ref string message); // 0x0000000181D70150-0x0000000181D70400
		public override void StoreDefaultLocalState(); // 0x0000000181D71370-0x0000000181D714C0
		public override void FixTransforms(); // 0x0000000181D6F690-0x0000000181D6F800
		protected override void OnInitiate(); // 0x0000000181D70400-0x0000000181D70620
		protected override void OnUpdate(); // 0x0000000181D70620-0x0000000181D70890
		protected virtual void ReadPose(); // 0x0000000181D70890-0x0000000181D70D60
		protected virtual void Solve(); // 0x0000000181D70D60-0x0000000181D71370
		protected virtual void ApplyBendConstraints(); // 0x0000000181D6F640-0x0000000181D6F690
		protected virtual void WritePose(); // 0x0000000181D714C0-0x0000000181D71620
	}
}
