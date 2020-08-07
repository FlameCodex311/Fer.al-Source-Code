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
	[AddComponentMenu] // 0x000000018022B620-0x000000018022B680
	[HelpURL] // 0x000000018022B620-0x000000018022B680
	public class GrounderQuadruped : Grounder // TypeDefIndex: 9879
	{
		// Fields
		[Tooltip] // 0x000000018022B7C0-0x000000018022B7F0
		public Grounding forelegSolver; // 0x40
		[Range] // 0x000000018022BA20-0x000000018022BA80
		[Tooltip] // 0x000000018022BA20-0x000000018022BA80
		public float rootRotationWeight; // 0x48
		[Range] // 0x000000018022BDB0-0x000000018022BE10
		[Tooltip] // 0x000000018022BDB0-0x000000018022BE10
		public float minRootRotation; // 0x4C
		[Range] // 0x000000018022C160-0x000000018022C1C0
		[Tooltip] // 0x000000018022C160-0x000000018022C1C0
		public float maxRootRotation; // 0x50
		[Tooltip] // 0x000000018022C430-0x000000018022C460
		public float rootRotationSpeed; // 0x54
		[Tooltip] // 0x000000018022C820-0x000000018022C850
		public float maxLegOffset; // 0x58
		[Tooltip] // 0x000000018022C920-0x000000018022C950
		public float maxForeLegOffset; // 0x5C
		[Range] // 0x000000018022CB60-0x000000018022CBC0
		[Tooltip] // 0x000000018022CB60-0x000000018022CBC0
		public float maintainHeadRotationWeight; // 0x60
		[Tooltip] // 0x000000018022ADA0-0x000000018022ADD0
		public Transform characterRoot; // 0x68
		[Tooltip] // 0x000000018022D1E0-0x000000018022D210
		public Transform pelvis; // 0x70
		[Tooltip] // 0x000000018022D2D0-0x000000018022D300
		public Transform lastSpineBone; // 0x78
		[Tooltip] // 0x000000018022D4E0-0x000000018022D510
		public Transform head; // 0x80
		[Tooltip] // 0x000000018022D4E0-0x000000018022D510
		public Transform tail; // 0x88
		public IK[] legs; // 0x90
		public IK[] forelegs; // 0x98
		[HideInInspector] // 0x00000001801CDAD0-0x00000001801CDAE0
		public Vector3 gravity; // 0xA0
		private Foot[] feet; // 0xB0
		private Vector3 animatedPelvisLocalPosition; // 0xB8
		private Quaternion animatedPelvisLocalRotation; // 0xC4
		private Quaternion animatedHeadLocalRotation; // 0xD4
		private Quaternion animatedTailLocalRotation; // 0xE4
		private Vector3 solvedPelvisLocalPosition; // 0xF4
		private Quaternion solvedPelvisLocalRotation; // 0x100
		private Quaternion solvedHeadLocalRotation; // 0x110
		private Quaternion solvedTailLocalRotation; // 0x120
		private int solvedFeet; // 0x130
		private bool solved; // 0x134
		private float angle; // 0x138
		private Transform forefeetRoot; // 0x140
		private Quaternion headRotation; // 0x148
		private Quaternion tailRotation; // 0x158
		private float lastWeight; // 0x168
		private Rigidbody characterRootRigidbody; // 0x170
	
		// Nested types
		public struct Foot // TypeDefIndex: 9880
		{
			// Fields
			public IKSolver solver; // 0x00
			public Transform transform; // 0x08
			public Quaternion rotation; // 0x10
			public Grounding.Leg leg; // 0x20
	
			// Constructors
			public Foot(IKSolver solver, Transform transform); // 0x00000001800C2100-0x00000001800C21F0
		}
	
		// Constructors
		public GrounderQuadruped(); // 0x000000018143D4C0-0x000000018143D5E0
	
		// Methods
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		protected override void OpenUserManual(); // 0x000000018143C690-0x000000018143C6D0
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		protected override void OpenScriptReference(); // 0x000000018143C650-0x000000018143C690
		public override void ResetPosition(); // 0x000000018143C6D0-0x000000018143C710
		private bool IsReadyToInitiate(); // 0x000000018143B0E0-0x000000018143B230
		private bool IsReadyToInitiateLegs(IK[] ikComponents); // 0x000000018143AF00-0x000000018143B0E0
		private void OnDisable(); // 0x000000018143B3B0-0x000000018143B470
		private void Update(); // 0x000000018143D2E0-0x000000018143D4C0
		private void Initiate(); // 0x000000018143AA70-0x000000018143AF00
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset); // 0x000000018143A630-0x000000018143AA70
		private void LateUpdate(); // 0x000000018143B230-0x000000018143B370
		private void RootRotation(); // 0x000000018143C710-0x000000018143CD20
		private void OnSolverUpdate(); // 0x000000018143B9F0-0x000000018143C650
		private void UpdateForefeetRoot(); // 0x000000018143CF20-0x000000018143D2E0
		private void SetFootIK(Foot foot, float maxOffset); // 0x000000018143CD20-0x000000018143CF20
		private void OnPostSolverUpdate(); // 0x000000018143B470-0x000000018143B9F0
		private void OnDestroy(); // 0x000000018143B370-0x000000018143B3B0
		private void DestroyLegs(IK[] ikComponents); // 0x000000018143A420-0x000000018143A630
	}
}
