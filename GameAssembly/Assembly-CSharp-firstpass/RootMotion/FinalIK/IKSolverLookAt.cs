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
	public class IKSolverLookAt : IKSolver // TypeDefIndex: 9935
	{
		// Fields
		public Transform target; // 0x58
		public LookAtBone[] spine; // 0x60
		public LookAtBone head; // 0x68
		public LookAtBone[] eyes; // 0x70
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float bodyWeight; // 0x78
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float headWeight; // 0x7C
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float eyesWeight; // 0x80
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float clampWeight; // 0x84
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float clampWeightHead; // 0x88
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float clampWeightEyes; // 0x8C
		[Range] // 0x0000000180247A20-0x0000000180247A40
		public int clampSmoothing; // 0x90
		public AnimationCurve spineWeightCurve; // 0x98
		public Vector3 spineTargetOffset; // 0xA0
		private Vector3[] spineForwards; // 0xB0
		private Vector3[] headForwards; // 0xB8
		private Vector3[] eyeForward; // 0xC0
	
		// Properties
		private bool spineIsValid { get; } // 0x0000000181AA82F0-0x0000000181AA8440 
		private bool spineIsEmpty { get; } // 0x0000000181AA82D0-0x0000000181AA82F0 
		private bool headIsValid { get; } // 0x0000000181AA82C0-0x0000000181AA82D0 
		private bool headIsEmpty { get; } // 0x0000000181AA8250-0x0000000181AA82C0 
		private bool eyesIsValid { get; } // 0x0000000181AA8100-0x0000000181AA8250 
		private bool eyesIsEmpty { get; } // 0x0000000181AA80E0-0x0000000181AA8100 
	
		// Nested types
		[Serializable]
		public class LookAtBone : IKSolver.Bone // TypeDefIndex: 9936
		{
			// Properties
			public Vector3 forward { get; } // 0x0000000181AB9030-0x0000000181AB9100 
	
			// Constructors
			public LookAtBone(); // 0x0000000181AB8FF0-0x0000000181AB9000
			public LookAtBone(Transform transform); // 0x0000000181AB9000-0x0000000181AB9030
	
			// Methods
			public void Initiate(Transform root); // 0x0000000181AB8D40-0x0000000181AB8E80
			public void LookAt(Vector3 direction, float weight); // 0x0000000181AB8E80-0x0000000181AB8FF0
		}
	
		// Constructors
		public IKSolverLookAt(); // 0x0000000181AA7EC0-0x0000000181AA80E0
	
		// Methods
		public void SetLookAtWeight(float weight); // 0x0000000181AA7090-0x0000000181AA7100
		public void SetLookAtWeight(float weight, float bodyWeight); // 0x0000000181AA6E00-0x0000000181AA6EA0
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight); // 0x0000000181AA6FC0-0x0000000181AA7090
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight); // 0x0000000181AA6D10-0x0000000181AA6E00
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight); // 0x0000000181AA6EA0-0x0000000181AA6FC0
		public void SetLookAtWeight(float weight, float bodyWeight = 0f /* Metadata: 0x0077AC3D */, float headWeight = 1f /* Metadata: 0x0077AC41 */, float eyesWeight = 0.5f /* Metadata: 0x0077AC45 */, float clampWeight = 0.5f /* Metadata: 0x0077AC49 */, float clampWeightHead = 0.5f /* Metadata: 0x0077AC4D */, float clampWeightEyes = 0.3f /* Metadata: 0x0077AC51 */); // 0x0000000181AA7100-0x0000000181AA7250
		public override void StoreDefaultLocalState(); // 0x0000000181AA7D30-0x0000000181AA7EC0
		public override void FixTransforms(); // 0x0000000181AA5540-0x0000000181AA56F0
		public override bool IsValid(ref string message); // 0x0000000181AA6080-0x0000000181AA6410
		public override Point[] GetPoints(); // 0x0000000181AA5D80-0x0000000181AA6080
		public override Point GetPoint(Transform transform); // 0x0000000181AA5BB0-0x0000000181AA5D80
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root); // 0x0000000181AA6C60-0x0000000181AA6D10
		protected override void OnInitiate(); // 0x0000000181AA6410-0x0000000181AA6950
		protected override void OnUpdate(); // 0x0000000181AA6950-0x0000000181AA6A60
		private void SolveSpine(); // 0x0000000181AA79E0-0x0000000181AA7D30
		private void SolveHead(); // 0x0000000181AA7600-0x0000000181AA79E0
		private void SolveEyes(); // 0x0000000181AA7250-0x0000000181AA7600
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp); // 0x0000000181AA56F0-0x0000000181AA5BB0
		private void SetBones(Transform[] array, ref LookAtBone[] bones); // 0x0000000181AA6A60-0x0000000181AA6C60
	}
}
