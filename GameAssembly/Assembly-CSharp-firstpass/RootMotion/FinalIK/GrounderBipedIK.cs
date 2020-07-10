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
	[AddComponentMenu] // 0x0000000180122490-0x00000001801224F0
	[HelpURL] // 0x0000000180122490-0x00000001801224F0
	public class GrounderBipedIK : Grounder // TypeDefIndex: 9341
	{
		// Fields
		[Tooltip] // 0x00000001801227D0-0x0000000180122800
		public BipedIK ik; // 0x40
		[Tooltip] // 0x0000000180122A00-0x0000000180122A30
		public float spineBend; // 0x48
		[Tooltip] // 0x0000000180122C10-0x0000000180122C40
		public float spineSpeed; // 0x4C
		private Transform[] feet; // 0x50
		private Quaternion[] footRotations; // 0x58
		private Vector3 animatedPelvisLocalPosition; // 0x60
		private Vector3 solvedPelvisLocalPosition; // 0x6C
		private Vector3 spineOffset; // 0x78
		private float lastWeight; // 0x84
	
		// Constructors
		public GrounderBipedIK(); // 0x0000000181C18C60-0x0000000181C18CD0
	
		// Methods
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		protected override void OpenUserManual(); // 0x0000000181C188F0-0x0000000181C18930
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		protected override void OpenScriptReference(); // 0x0000000181C188B0-0x0000000181C188F0
		public override void ResetPosition(); // 0x0000000181C18930-0x0000000181C189B0
		private bool IsReadyToInitiate(); // 0x0000000181C17A00-0x0000000181C17AE0
		private void Update(); // 0x0000000181C18AF0-0x0000000181C18C60
		private void Initiate(); // 0x0000000181C175D0-0x0000000181C17A00
		private void OnDisable(); // 0x0000000181C17CA0-0x0000000181C17D20
		private void OnSolverUpdate(); // 0x0000000181C17FC0-0x0000000181C188B0
		private void SetLegIK(IKSolverLimb limb, int index); // 0x0000000181C189B0-0x0000000181C18AF0
		private void OnPostSolverUpdate(); // 0x0000000181C17D20-0x0000000181C17FC0
		private void OnDestroy(); // 0x0000000181C17AE0-0x0000000181C17CA0
	}
}
