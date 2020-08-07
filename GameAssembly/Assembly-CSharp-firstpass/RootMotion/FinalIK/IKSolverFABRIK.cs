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
	public class IKSolverFABRIK : IKSolverHeuristic // TypeDefIndex: 9924
	{
		// Fields
		public IterationDelegate OnPreIteration; // 0x88
		private bool[] limitedBones; // 0x90
		private Vector3[] solverLocalPositions; // 0x98
	
		// Properties
		protected override bool boneLengthCanBeZero { get; } // 0x0000000180380950-0x0000000180380960 
	
		// Constructors
		public IKSolverFABRIK(); // 0x00000001819F2B40-0x00000001819F2BA0
	
		// Methods
		public void SolveForward(Vector3 position); // 0x00000001819F2190-0x00000001819F2230
		public void SolveBackward(Vector3 position); // 0x00000001819F20B0-0x00000001819F2190
		public override Vector3 GetIKPosition(); // 0x00000001819EFBB0-0x00000001819EFC60
		protected override void OnInitiate(); // 0x00000001819F0F90-0x00000001819F1480
		protected override void OnUpdate(); // 0x00000001819F1CB0-0x00000001819F20B0
		private Vector3 SolveJoint(Vector3 pos1, Vector3 pos2, float length); // 0x00000001819F2230-0x00000001819F2390
		private void OnPreSolve(); // 0x00000001819F14D0-0x00000001819F1CB0
		private void OnPostSolve(); // 0x00000001819F1480-0x00000001819F14D0
		private void Solve(Vector3 targetPosition); // 0x00000001819F2390-0x00000001819F2440
		private void ForwardReach(Vector3 position); // 0x00000001819EF720-0x00000001819EFBB0
		private void SolverMove(int index, Vector3 offset); // 0x00000001819F2740-0x00000001819F2880
		private void SolverRotate(int index, Quaternion rotation, bool recursive); // 0x00000001819F29D0-0x00000001819F2B40
		private void SolverRotateChildren(int index, Quaternion rotation); // 0x00000001819F2880-0x00000001819F29D0
		private void SolverMoveChildrenAroundPoint(int index, Quaternion rotation); // 0x00000001819F2440-0x00000001819F2740
		private Quaternion GetParentSolverRotation(int index); // 0x00000001819F0010-0x00000001819F01E0
		private Vector3 GetParentSolverPosition(int index); // 0x00000001819EFE30-0x00000001819F0010
		private Quaternion GetLimitedRotation(int index, Quaternion q, out bool changed); // 0x00000001819EFC60-0x00000001819EFE30
		private void LimitForward(int rotateBone, int limitBone); // 0x00000001819F01E0-0x00000001819F0B70
		private void BackwardReach(Vector3 position); // 0x00000001819EF6E0-0x00000001819EF720
		private void BackwardReachUnlimited(Vector3 position); // 0x00000001819EF3C0-0x00000001819EF6E0
		private void BackwardReachLimited(Vector3 position); // 0x00000001819EEA50-0x00000001819EF3C0
		private void MapToSolverPositions(); // 0x00000001819F0D20-0x00000001819F0F90
		private void MapToSolverPositionsLimited(); // 0x00000001819F0B70-0x00000001819F0D20
	}
}
