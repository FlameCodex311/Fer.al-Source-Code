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
	public class IKSolverTrigonometric : IKSolver // TypeDefIndex: 9403
	{
		// Fields
		public Transform target; // 0x58
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float IKRotationWeight; // 0x60
		public Quaternion IKRotation; // 0x64
		public Vector3 bendNormal; // 0x74
		public TrigonometricBone bone1; // 0x80
		public TrigonometricBone bone2; // 0x88
		public TrigonometricBone bone3; // 0x90
		protected Vector3 weightIKPosition; // 0x98
		protected bool directHierarchy; // 0xA4
	
		// Nested types
		[Serializable]
		public class TrigonometricBone : IKSolver.Bone // TypeDefIndex: 9404
		{
			// Fields
			private Quaternion targetToLocalSpace; // 0x80
			private Vector3 defaultLocalBendNormal; // 0x90
	
			// Constructors
			public TrigonometricBone(); // 0x0000000181D83690-0x0000000181D836A0
	
			// Methods
			public void Initiate(Vector3 childPosition, Vector3 bendNormal); // 0x0000000181D83960-0x0000000181D83B50
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal); // 0x0000000181D83880-0x0000000181D83960
			public Vector3 GetBendNormalFromCurrentRotation(); // 0x0000000181D837A0-0x0000000181D83880
		}
	
		// Constructors
		public IKSolverTrigonometric(); // 0x0000000181D7CAB0-0x0000000181D7CBD0
	
		// Methods
		public void SetBendGoalPosition(Vector3 goalPosition, float weight); // 0x0000000181D7BDF0-0x0000000181D7C070
		public void SetBendPlaneToCurrent(); // 0x0000000181D7C070-0x0000000181D7C2E0
		public void SetIKRotation(Quaternion rotation); // 0x0000000181D7C3C0-0x0000000181D7C3D0
		public void SetIKRotationWeight(float weight); // 0x0000000181D7C350-0x0000000181D7C3C0
		public Quaternion GetIKRotation(); // 0x0000000181D7A3F0-0x0000000181D7A400
		public float GetIKRotationWeight(); // 0x0000000180487CD0-0x0000000180487CE0
		public override Point[] GetPoints(); // 0x0000000181D7A570-0x0000000181D7A6E0
		public override Point GetPoint(Transform transform); // 0x0000000181D7A400-0x0000000181D7A570
		public override void StoreDefaultLocalState(); // 0x0000000181D7CA50-0x0000000181D7CAB0
		public override void FixTransforms(); // 0x0000000181D79D70-0x0000000181D79DE0
		public override bool IsValid(ref string message); // 0x0000000181D7A960-0x0000000181D7AED0
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root); // 0x0000000181D7C2E0-0x0000000181D7C350
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight); // 0x0000000181D7C3D0-0x0000000181D7CA50
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2); // 0x0000000181D7A1A0-0x0000000181D7A3F0
		protected override void OnInitiate(); // 0x0000000181D7AED0-0x0000000181D7B280
		private bool IsDirectHierarchy(); // 0x0000000181D7A810-0x0000000181D7A960
		private void InitiateBones(); // 0x0000000181D7A6E0-0x0000000181D7A810
		protected override void OnUpdate(); // 0x0000000181D7B280-0x0000000181D7BDF0
		protected virtual void OnInitiateVirtual(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnUpdateVirtual(); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnPostSolveVirtual(); // 0x00000001803581E0-0x00000001803581F0
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal); // 0x0000000181D79DE0-0x0000000181D7A1A0
	}
}
