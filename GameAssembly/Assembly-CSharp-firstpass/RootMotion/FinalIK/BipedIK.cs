/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x000000018011DD40-0x000000018011DDA0
	[HelpURL] // 0x000000018011DD40-0x000000018011DDA0
	public class BipedIK : SolverManager // TypeDefIndex: 9328
	{
		// Fields
		public BipedReferences references; // 0x38
		public BipedIKSolvers solvers; // 0x40
	
		// Constructors
		public BipedIK(); // 0x000000018181F210-0x000000018181F3B0
	
		// Methods
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		private void OpenUserManual(); // 0x000000018181E9B0-0x000000018181E9F0
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		private void OpenScriptReference(); // 0x000000018181E970-0x000000018181E9B0
		[ContextMenu] // 0x000000018011E390-0x000000018011E3C0
		private void SupportGroup(); // 0x000000018181EED0-0x000000018181EF10
		[ContextMenu] // 0x000000018011E5A0-0x000000018011E5D0
		private void ASThread(); // 0x000000018181E380-0x000000018181E3C0
		public float GetIKPositionWeight(AvatarIKGoal goal); // 0x000000018181E560-0x000000018181E590
		public float GetIKRotationWeight(AvatarIKGoal goal); // 0x000000018181E5F0-0x000000018181E620
		public void SetIKPositionWeight(AvatarIKGoal goal, float weight); // 0x000000018181E9F0-0x000000018181EA30
		public void SetIKRotationWeight(AvatarIKGoal goal, float weight); // 0x000000018181EA70-0x000000018181EAB0
		public void SetIKPosition(AvatarIKGoal goal, Vector3 IKPosition); // 0x000000018181EA30-0x000000018181EA70
		public void SetIKRotation(AvatarIKGoal goal, Quaternion IKRotation); // 0x000000018181EAB0-0x000000018181EAE0
		public Vector3 GetIKPosition(AvatarIKGoal goal); // 0x000000018181E590-0x000000018181E5F0
		public Quaternion GetIKRotation(AvatarIKGoal goal); // 0x000000018181E620-0x000000018181E660
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight, float clampWeightHead, float clampWeightEyes); // 0x000000018181EB20-0x000000018181EB70
		public void SetLookAtPosition(Vector3 lookAtPosition); // 0x000000018181EAE0-0x000000018181EB20
		public void SetSpinePosition(Vector3 spinePosition); // 0x000000018181EB70-0x000000018181EBB0
		public void SetSpineWeight(float weight); // 0x000000018181EBB0-0x000000018181EBE0
		public IKSolverLimb GetGoalIK(AvatarIKGoal goal); // 0x000000018181E4D0-0x000000018181E560
		public void InitiateBipedIK(); // 0x0000000180B2D770-0x0000000180B2D790
		public void UpdateBipedIK(); // 0x00000001805A0CC0-0x00000001805A0CE0
		public void SetToDefaults(); // 0x000000018181EBE0-0x000000018181EED0
		protected override void FixTransforms(); // 0x000000018181E3C0-0x000000018181E4D0
		protected override void InitiateSolver(); // 0x000000018181E660-0x000000018181E940
		protected override void UpdateSolver(); // 0x000000018181EF10-0x000000018181F210
		public void LogWarning(string message); // 0x000000018181E940-0x000000018181E970
	}
}
