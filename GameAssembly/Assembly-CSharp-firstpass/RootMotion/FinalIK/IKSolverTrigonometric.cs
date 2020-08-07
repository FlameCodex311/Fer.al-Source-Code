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
	public class IKSolverTrigonometric : IKSolver // TypeDefIndex: 9937
	{
		// Fields
		public Transform target; // 0x58
		[Range] // 0x00000001801D3630-0x00000001801D3650
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
		public class TrigonometricBone : IKSolver.Bone // TypeDefIndex: 9938
		{
			// Fields
			private Quaternion targetToLocalSpace; // 0x80
			private Vector3 defaultLocalBendNormal; // 0x90
	
			// Constructors
			public TrigonometricBone(); // 0x0000000181AB8FF0-0x0000000181AB9000
	
			// Methods
			public void Initiate(Vector3 childPosition, Vector3 bendNormal); // 0x0000000181AB92C0-0x0000000181AB94A0
			public Quaternion GetRotation(Vector3 direction, Vector3 bendNormal); // 0x0000000181AB91E0-0x0000000181AB92C0
			public Vector3 GetBendNormalFromCurrentRotation(); // 0x0000000181AB9100-0x0000000181AB91E0
		}
	
		// Constructors
		public IKSolverTrigonometric(); // 0x0000000181AAB090-0x0000000181AAB1B0
	
		// Methods
		public void SetBendGoalPosition(Vector3 goalPosition, float weight); // 0x0000000181AAA400-0x0000000181AAA670
		public void SetBendPlaneToCurrent(); // 0x0000000181AAA670-0x0000000181AAA8D0
		public void SetIKRotation(Quaternion rotation); // 0x0000000181AAA9B0-0x0000000181AAA9C0
		public void SetIKRotationWeight(float weight); // 0x0000000181AAA940-0x0000000181AAA9B0
		public Quaternion GetIKRotation(); // 0x0000000181AA8AC0-0x0000000181AA8AD0
		public float GetIKRotationWeight(); // 0x00000001804CD6D0-0x00000001804CD6E0
		public override Point[] GetPoints(); // 0x0000000181AA8C40-0x0000000181AA8D90
		public override Point GetPoint(Transform transform); // 0x0000000181AA8AD0-0x0000000181AA8C40
		public override void StoreDefaultLocalState(); // 0x0000000181AAB030-0x0000000181AAB090
		public override void FixTransforms(); // 0x0000000181AA8440-0x0000000181AA84B0
		public override bool IsValid(ref string message); // 0x0000000181AA9000-0x0000000181AA9540
		public bool SetChain(Transform bone1, Transform bone2, Transform bone3, Transform root); // 0x0000000181AAA8D0-0x0000000181AAA940
		public static void Solve(Transform bone1, Transform bone2, Transform bone3, Vector3 targetPosition, Vector3 bendNormal, float weight); // 0x0000000181AAA9C0-0x0000000181AAB030
		private static Vector3 GetDirectionToBendPoint(Vector3 direction, float directionMag, Vector3 bendDirection, float sqrMag1, float sqrMag2); // 0x0000000181AA8870-0x0000000181AA8AC0
		protected override void OnInitiate(); // 0x0000000181AA9540-0x0000000181AA98E0
		private bool IsDirectHierarchy(); // 0x0000000181AA8EB0-0x0000000181AA9000
		private void InitiateBones(); // 0x0000000181AA8D90-0x0000000181AA8EB0
		protected override void OnUpdate(); // 0x0000000181AA98E0-0x0000000181AAA400
		protected virtual void OnInitiateVirtual(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnUpdateVirtual(); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnPostSolveVirtual(); // 0x00000001803774A0-0x00000001803774B0
		protected Vector3 GetBendDirection(Vector3 IKPosition, Vector3 bendNormal); // 0x0000000181AA84B0-0x0000000181AA8870
	}
}
