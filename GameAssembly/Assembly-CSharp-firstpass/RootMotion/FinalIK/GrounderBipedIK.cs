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
	[AddComponentMenu] // 0x00000001802273F0-0x0000000180227450
	[HelpURL] // 0x00000001802273F0-0x0000000180227450
	public class GrounderBipedIK : Grounder // TypeDefIndex: 9875
	{
		// Fields
		[Tooltip] // 0x0000000180228990-0x00000001802289C0
		public BipedIK ik; // 0x40
		[Tooltip] // 0x0000000180228AF0-0x0000000180228B20
		public float spineBend; // 0x48
		[Tooltip] // 0x0000000180228D10-0x0000000180228D40
		public float spineSpeed; // 0x4C
		private Transform[] feet; // 0x50
		private Quaternion[] footRotations; // 0x58
		private Vector3 animatedPelvisLocalPosition; // 0x60
		private Vector3 solvedPelvisLocalPosition; // 0x6C
		private Vector3 spineOffset; // 0x78
		private float lastWeight; // 0x84
	
		// Constructors
		public GrounderBipedIK(); // 0x0000000181436FD0-0x0000000181437090
	
		// Methods
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		protected override void OpenUserManual(); // 0x0000000181436C80-0x0000000181436CC0
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		protected override void OpenScriptReference(); // 0x0000000181436C40-0x0000000181436C80
		public override void ResetPosition(); // 0x0000000181436CC0-0x0000000181436D40
		private bool IsReadyToInitiate(); // 0x0000000181435E00-0x0000000181435EE0
		private void Update(); // 0x0000000181436E70-0x0000000181436FD0
		private void Initiate(); // 0x0000000181435A00-0x0000000181435E00
		private void OnDisable(); // 0x00000001814360A0-0x0000000181436120
		private void OnSolverUpdate(); // 0x00000001814363A0-0x0000000181436C40
		private void SetLegIK(IKSolverLimb limb, int index); // 0x0000000181436D40-0x0000000181436E70
		private void OnPostSolverUpdate(); // 0x0000000181436120-0x00000001814363A0
		private void OnDestroy(); // 0x0000000181435EE0-0x00000001814360A0
	}
}
