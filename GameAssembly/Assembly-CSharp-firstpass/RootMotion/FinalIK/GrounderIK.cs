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
	[AddComponentMenu] // 0x000000018022A8E0-0x000000018022A940
	[HelpURL] // 0x000000018022A8E0-0x000000018022A940
	public class GrounderIK : Grounder // TypeDefIndex: 9878
	{
		// Fields
		public IK[] legs; // 0x40
		[Tooltip] // 0x000000018022AB10-0x000000018022AB40
		public Transform pelvis; // 0x48
		[Tooltip] // 0x000000018022ADA0-0x000000018022ADD0
		public Transform characterRoot; // 0x50
		[Range] // 0x00000001801E92A0-0x00000001801E9300
		[Tooltip] // 0x00000001801E92A0-0x00000001801E9300
		public float rootRotationWeight; // 0x58
		[Tooltip] // 0x00000001801E9500-0x00000001801E9530
		public float rootRotationSpeed; // 0x5C
		[Tooltip] // 0x00000001801E96E0-0x00000001801E9710
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
		public GrounderIK(); // 0x000000018143A370-0x000000018143A420
	
		// Methods
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		protected override void OpenUserManual(); // 0x0000000181439840-0x0000000181439880
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		protected override void OpenScriptReference(); // 0x0000000181439800-0x0000000181439840
		public override void ResetPosition(); // 0x0000000181439880-0x00000001814398A0
		private bool IsReadyToInitiate(); // 0x0000000181438B60-0x0000000181438DB0
		private void OnDisable(); // 0x0000000181438FD0-0x0000000181439120
		private void Update(); // 0x0000000181439DE0-0x000000018143A370
		private void Initiate(); // 0x0000000181438560-0x0000000181438B60
		private void OnSolverUpdate(); // 0x00000001814393B0-0x0000000181439800
		private void SetLegIK(int index); // 0x00000001814398A0-0x0000000181439DE0
		private void OnPostSolverUpdate(); // 0x0000000181439120-0x00000001814393B0
		private void OnDestroy(); // 0x0000000181438DB0-0x0000000181438FD0
	}
}
