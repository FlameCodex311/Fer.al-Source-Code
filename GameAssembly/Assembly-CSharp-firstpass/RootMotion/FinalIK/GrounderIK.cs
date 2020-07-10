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
	[AddComponentMenu] // 0x0000000180125500-0x0000000180125560
	[HelpURL] // 0x0000000180125500-0x0000000180125560
	public class GrounderIK : Grounder // TypeDefIndex: 9344
	{
		// Fields
		public IK[] legs; // 0x40
		[Tooltip] // 0x00000001801257B0-0x00000001801257E0
		public Transform pelvis; // 0x48
		[Tooltip] // 0x0000000180125A40-0x0000000180125A70
		public Transform characterRoot; // 0x50
		[Range] // 0x0000000180119860-0x00000001801198C0
		[Tooltip] // 0x0000000180119860-0x00000001801198C0
		public float rootRotationWeight; // 0x58
		[Tooltip] // 0x0000000180119AB0-0x0000000180119AE0
		public float rootRotationSpeed; // 0x5C
		[Tooltip] // 0x0000000180119C20-0x0000000180119C50
		public float maxRootRotationAngle; // 0x60
		private Transform[] feet; // 0x68
		private Quaternion[] footRotations; // 0x70
		private Vector3 animatedPelvisLocalPosition; // 0x78
		private Vector3 solvedPelvisLocalPosition; // 0x84
		private int solvedFeet; // 0x90
		private bool solved; // 0x94
		private float lastWeight; // 0x98
		private Rigidbody characterRootRigidbody; // 0xA0
	
		// Constructors
		public GrounderIK(); // 0x0000000181C1BE30-0x0000000181C1BEA0
	
		// Methods
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		protected override void OpenUserManual(); // 0x0000000181C1B2B0-0x0000000181C1B2F0
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		protected override void OpenScriptReference(); // 0x0000000181C1B270-0x0000000181C1B2B0
		public override void ResetPosition(); // 0x0000000181C1B2F0-0x0000000181C1B310
		private bool IsReadyToInitiate(); // 0x0000000181C1A590-0x0000000181C1A7E0
		private void OnDisable(); // 0x0000000181C1AA00-0x0000000181C1AB70
		private void Update(); // 0x0000000181C1B890-0x0000000181C1BE30
		private void Initiate(); // 0x0000000181C19F60-0x0000000181C1A590
		private void OnSolverUpdate(); // 0x0000000181C1AE10-0x0000000181C1B270
		private void SetLegIK(int index); // 0x0000000181C1B310-0x0000000181C1B890
		private void OnPostSolverUpdate(); // 0x0000000181C1AB70-0x0000000181C1AE10
		private void OnDestroy(); // 0x0000000181C1A7E0-0x0000000181C1AA00
	}
}
