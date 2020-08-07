/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x0000000180222F90-0x0000000180222FF0
	[HelpURL] // 0x0000000180222F90-0x0000000180222FF0
	public class BipedIK : SolverManager // TypeDefIndex: 9862
	{
		// Fields
		public BipedReferences references; // 0x38
		public BipedIKSolvers solvers; // 0x40
	
		// Constructors
		public BipedIK(); // 0x0000000181424920-0x0000000181424AC0
	
		// Methods
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		private void OpenUserManual(); // 0x0000000181424100-0x0000000181424140
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		private void OpenScriptReference(); // 0x00000001814240C0-0x0000000181424100
		[ContextMenu] // 0x00000001802233A0-0x00000001802233D0
		private void SupportGroup(); // 0x0000000181424600-0x0000000181424640
		[ContextMenu] // 0x0000000180223520-0x0000000180223550
		private void ASThread(); // 0x0000000181423AF0-0x0000000181423B30
		public float GetIKPositionWeight(AvatarIKGoal goal); // 0x0000000181423CB0-0x0000000181423CE0
		public float GetIKRotationWeight(AvatarIKGoal goal); // 0x0000000181423D40-0x0000000181423D70
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight); // 0x0000000181424140-0x0000000181424180
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight); // 0x00000001814241C0-0x0000000181424200
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition); // 0x0000000181424180-0x00000001814241C0
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation); // 0x0000000181424200-0x0000000181424230
		public Vector3 GetIKPosition(AvatarIKGoal goal); // 0x0000000181423CE0-0x0000000181423D40
		public Quaternion GetIKRotation(AvatarIKGoal goal); // 0x0000000181423D70-0x0000000181423DB0
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes); // 0x0000000181424270-0x00000001814242C0
		public void SetLookAtPosition(Vector3 lookAtPosition); // 0x0000000181424230-0x0000000181424270
		public void SetSpinePosition(Vector3 spinePosition); // 0x00000001814242C0-0x0000000181424300
		public void SetSpineWeight(float weight); // 0x0000000181424300-0x0000000181424330
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal); // 0x0000000181423C30-0x0000000181423CB0
		public void InitiateBipedIK(); // 0x0000000181423DB0-0x0000000181423DD0
		public void UpdateBipedIK(); // 0x0000000180C8B3F0-0x0000000180C8B410
		public void SetToDefaults(); // 0x0000000181424330-0x0000000181424600
		protected override void FixTransforms(); // 0x0000000181423B30-0x0000000181423C30
		protected override void InitiateSolver(); // 0x0000000181423DD0-0x0000000181424090
		protected override void UpdateSolver(); // 0x0000000181424640-0x0000000181424920
		public void LogWarning(string message); // 0x0000000181424090-0x00000001814240C0
	}
}
