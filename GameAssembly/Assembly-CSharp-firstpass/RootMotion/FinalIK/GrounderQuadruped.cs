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
	[AddComponentMenu] // 0x0000000180127390-0x00000001801273F0
	[HelpURL] // 0x0000000180127390-0x00000001801273F0
	public class GrounderQuadruped : Grounder // TypeDefIndex: 9345
	{
		// Fields
		[Tooltip] // 0x00000001801276A0-0x00000001801276D0
		public Grounding forelegSolver; // 0x40
		[Range] // 0x0000000180127860-0x00000001801278C0
		[Tooltip] // 0x0000000180127860-0x00000001801278C0
		public float rootRotationWeight; // 0x48
		[Range] // 0x0000000180127A90-0x0000000180127AF0
		[Tooltip] // 0x0000000180127A90-0x0000000180127AF0
		public float minRootRotation; // 0x4C
		[Range] // 0x0000000180127E00-0x0000000180127E60
		[Tooltip] // 0x0000000180127E00-0x0000000180127E60
		public float maxRootRotation; // 0x50
		[Tooltip] // 0x0000000180128000-0x0000000180128030
		public float rootRotationSpeed; // 0x54
		[Tooltip] // 0x0000000180128120-0x0000000180128150
		public float maxLegOffset; // 0x58
		[Tooltip] // 0x00000001801281C0-0x00000001801281F0
		public float maxForeLegOffset; // 0x5C
		[Range] // 0x0000000180128310-0x0000000180128370
		[Tooltip] // 0x0000000180128310-0x0000000180128370
		public float maintainHeadRotationWeight; // 0x60
		[Tooltip] // 0x0000000180125A40-0x0000000180125A70
		public Transform characterRoot; // 0x68
		[Tooltip] // 0x0000000180128600-0x0000000180128630
		public Transform pelvis; // 0x70
		[Tooltip] // 0x0000000180128740-0x0000000180128770
		public Transform lastSpineBone; // 0x78
		[Tooltip] // 0x0000000180128990-0x00000001801289C0
		public Transform head; // 0x80
		[Tooltip] // 0x0000000180128990-0x00000001801289C0
		public Transform tail; // 0x88
		public IK[] legs; // 0x90
		public IK[] forelegs; // 0x98
		[HideInInspector] // 0x00000001800B36B0-0x00000001800B36C0
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
		public struct Foot // TypeDefIndex: 9346
		{
			// Fields
			public IKSolver solver; // 0x00
			public Transform transform; // 0x08
			public Quaternion rotation; // 0x10
			public Grounding.Leg leg; // 0x20
	
			// Constructors
			public Foot(IKSolver solver, Transform transform); // 0x00000001802EC0B0-0x00000001802EC180
		}
	
		// Constructors
		public GrounderQuadruped(); // 0x0000000181C1F020-0x0000000181C1F150
	
		// Methods
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		protected override void OpenUserManual(); // 0x0000000181C1E1C0-0x0000000181C1E200
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		protected override void OpenScriptReference(); // 0x0000000181C1E180-0x0000000181C1E1C0
		public override void ResetPosition(); // 0x0000000181C1E200-0x0000000181C1E240
		private bool IsReadyToInitiate(); // 0x0000000181C1CB90-0x0000000181C1CCE0
		private bool IsReadyToInitiateLegs(IK[] ikComponents); // 0x0000000181C1C9B0-0x0000000181C1CB90
		private void OnDisable(); // 0x0000000181C1CE60-0x0000000181C1CF30
		private void Update(); // 0x0000000181C1EE40-0x0000000181C1F020
		private void Initiate(); // 0x0000000181C1C500-0x0000000181C1C9B0
		private Transform[] InitiateFeet(IK[] ikComponents, ref Foot[] f, int indexOffset); // 0x0000000181C1C0B0-0x0000000181C1C500
		private void LateUpdate(); // 0x0000000181C1CCE0-0x0000000181C1CE20
		private void RootRotation(); // 0x0000000181C1E240-0x0000000181C1E860
		private void OnSolverUpdate(); // 0x0000000181C1D4D0-0x0000000181C1E180
		private void UpdateForefeetRoot(); // 0x0000000181C1EA60-0x0000000181C1EE40
		private void SetFootIK(Foot foot, float maxOffset); // 0x0000000181C1E860-0x0000000181C1EA60
		private void OnPostSolverUpdate(); // 0x0000000181C1CF30-0x0000000181C1D4D0
		private void OnDestroy(); // 0x0000000181C1CE20-0x0000000181C1CE60
		private void DestroyLegs(IK[] ikComponents); // 0x0000000181C1BEA0-0x0000000181C1C0B0
	}
}
