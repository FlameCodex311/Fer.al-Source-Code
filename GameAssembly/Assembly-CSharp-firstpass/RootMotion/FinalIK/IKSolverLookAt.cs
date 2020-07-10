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
	public class IKSolverLookAt : IKSolver // TypeDefIndex: 9401
	{
		// Fields
		public Transform target; // 0x58
		public LookAtBone[] spine; // 0x60
		public LookAtBone head; // 0x68
		public LookAtBone[] eyes; // 0x70
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float bodyWeight; // 0x78
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float headWeight; // 0x7C
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float eyesWeight; // 0x80
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float clampWeight; // 0x84
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float clampWeightHead; // 0x88
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float clampWeightEyes; // 0x8C
		[Range] // 0x000000018010BD70-0x000000018010BD90
		public int clampSmoothing; // 0x90
		public AnimationCurve spineWeightCurve; // 0x98
		public Vector3 spineTargetOffset; // 0xA0
		private Vector3[] spineForwards; // 0xB0
		private Vector3[] headForwards; // 0xB8
		private Vector3[] eyeForward; // 0xC0
	
		// Properties
		private bool spineIsValid { get; } // 0x0000000181D79C10-0x0000000181D79D70 
		private bool spineIsEmpty { get; } // 0x0000000181D79BE0-0x0000000181D79C10 
		private bool headIsValid { get; } // 0x0000000181D79BD0-0x0000000181D79BE0 
		private bool headIsEmpty { get; } // 0x0000000181D79B60-0x0000000181D79BD0 
		private bool eyesIsValid { get; } // 0x0000000181D79A00-0x0000000181D79B60 
		private bool eyesIsEmpty { get; } // 0x0000000181D799D0-0x0000000181D79A00 
	
		// Nested types
		[Serializable]
		public class LookAtBone : IKSolver.Bone // TypeDefIndex: 9402
		{
			// Properties
			public Vector3 forward { get; } // 0x0000000181D836D0-0x0000000181D837A0 
	
			// Constructors
			public LookAtBone(); // 0x0000000181D83690-0x0000000181D836A0
			public LookAtBone(Transform transform); // 0x0000000181D836A0-0x0000000181D836D0
	
			// Methods
			public void Initiate(Transform root); // 0x0000000181D833D0-0x0000000181D83510
			public void LookAt(Vector3 direction, float weight); // 0x0000000181D83510-0x0000000181D83690
		}
	
		// Constructors
		public IKSolverLookAt(); // 0x0000000181D797B0-0x0000000181D799D0
	
		// Methods
		public void SetLookAtWeight(float weight); // 0x0000000181D78980-0x0000000181D789F0
		public void SetLookAtWeight(float weight, float bodyWeight); // 0x0000000181D786F0-0x0000000181D78790
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight); // 0x0000000181D788B0-0x0000000181D78980
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight); // 0x0000000181D78600-0x0000000181D786F0
		public void SetLookAtWeight(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight); // 0x0000000181D78790-0x0000000181D788B0
		public void SetLookAtWeight(float weight, float bodyWeight = 0f /* Metadata: 0x00745130 */, float headWeight = 1f /* Metadata: 0x00745134 */, float eyesWeight = 0.5f /* Metadata: 0x00745138 */, float clampWeight = 0.5f /* Metadata: 0x0074513C */, float clampWeightHead = 0.5f /* Metadata: 0x00745140 */, float clampWeightEyes = 0.3f /* Metadata: 0x00745144 */); // 0x0000000181D789F0-0x0000000181D78B40
		public override void StoreDefaultLocalState(); // 0x0000000181D79610-0x0000000181D797B0
		public override void FixTransforms(); // 0x0000000181D76D60-0x0000000181D76F10
		public override bool IsValid(ref string message); // 0x0000000181D778F0-0x0000000181D77CB0
		public override Point[] GetPoints(); // 0x0000000181D775C0-0x0000000181D778F0
		public override Point GetPoint(Transform transform); // 0x0000000181D773E0-0x0000000181D775C0
		public bool SetChain(Transform[] spine, Transform head, Transform[] eyes, Transform root); // 0x0000000181D78550-0x0000000181D78600
		protected override void OnInitiate(); // 0x0000000181D77CB0-0x0000000181D78220
		protected override void OnUpdate(); // 0x0000000181D78220-0x0000000181D78330
		private void SolveSpine(); // 0x0000000181D792B0-0x0000000181D79610
		private void SolveHead(); // 0x0000000181D78F10-0x0000000181D792B0
		private void SolveEyes(); // 0x0000000181D78B40-0x0000000181D78F10
		private Vector3[] GetForwards(ref Vector3[] forwards, Vector3 baseForward, Vector3 targetForward, int bones, float clamp); // 0x0000000181D76F10-0x0000000181D773E0
		private void SetBones(Transform[] array, ref LookAtBone[] bones); // 0x0000000181D78330-0x0000000181D78550
	}
}
