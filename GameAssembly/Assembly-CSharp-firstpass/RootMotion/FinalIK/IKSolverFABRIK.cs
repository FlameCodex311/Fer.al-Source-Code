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
	public class IKSolverFABRIK : IKSolverHeuristic // TypeDefIndex: 9390
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
		private bool[] limitedBones; // 0x90
		private Vector3[] solverLocalPositions; // 0x98
	
		// Properties
		protected override bool boneLengthCanBeZero { get; } // 0x00000001803C28F0-0x00000001803C2900 
	
		// Constructors
		public IKSolverFABRIK(); // 0x0000000181D69FA0-0x0000000181D6A040
	
		// Methods
		public void SolveForward(Vector3 position); // 0x0000000181D695A0-0x0000000181D69640
		public void SolveBackward(Vector3 position); // 0x0000000181D694C0-0x0000000181D695A0
		public override Vector3 GetIKPosition(); // 0x0000000181D66E40-0x0000000181D66EF0
		protected override void OnInitiate(); // 0x0000000181D682F0-0x0000000181D68820
		protected override void OnUpdate(); // 0x0000000181D690B0-0x0000000181D694C0
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length); // 0x0000000181D69640-0x0000000181D697A0
		private void OnPreSolve(); // 0x0000000181D68870-0x0000000181D690B0
		private void OnPostSolve(); // 0x0000000181D68820-0x0000000181D68870
		private void Solve(Vector3 targetPosition); // 0x0000000181D697A0-0x0000000181D69860
		private void ForwardReach(Vector3 position); // 0x0000000181D66990-0x0000000181D66E40
		private void SolverMove(int index, Vector3 offset); // 0x0000000181D69B70-0x0000000181D69CC0
		private void SolverRotate(int index, Quaternion rotation, bool recursive); // 0x0000000181D69E20-0x0000000181D69FA0
		private void SolverRotateChildren(int index, Quaternion rotation); // 0x0000000181D69CC0-0x0000000181D69E20
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation); // 0x0000000181D69860-0x0000000181D69B70
		private Quaternion GetParentSolverRotation(int index); // 0x0000000181D672B0-0x0000000181D67490
		private Vector3 GetParentSolverPosition(int index); // 0x0000000181D670C0-0x0000000181D672B0
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed); // 0x0000000181D66EF0-0x0000000181D670C0
		private void LimitForward(int rotateBone, int limitBone); // 0x0000000181D67490-0x0000000181D67E90
		private void BackwardReach(Vector3 position); // 0x0000000181D66950-0x0000000181D66990
		private void BackwardReachUnlimited(Vector3 position); // 0x0000000181D66610-0x0000000181D66950
		private void BackwardReachLimited(Vector3 position); // 0x0000000181D65C40-0x0000000181D66610
		private void MapToSolverPositions(); // 0x0000000181D68060-0x0000000181D682F0
		private void MapToSolverPositionsLimited(); // 0x0000000181D67E90-0x0000000181D68060
	}
}
