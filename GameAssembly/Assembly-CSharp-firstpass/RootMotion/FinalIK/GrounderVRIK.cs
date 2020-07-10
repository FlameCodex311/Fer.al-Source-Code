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
	[AddComponentMenu] // 0x0000000180129280-0x00000001801292B0
	public class GrounderVRIK : Grounder // TypeDefIndex: 9347
	{
		// Fields
		[Tooltip] // 0x0000000180129420-0x0000000180129450
		public VRIK ik; // 0x40
		private Transform[] feet; // 0x48
	
		// Constructors
		public GrounderVRIK(); // 0x0000000181C201F0-0x0000000181C20240
	
		// Methods
		[ContextMenu] // 0x0000000180124A10-0x0000000180124A40
		private void OpenTutorial(); // 0x00000001803581E0-0x00000001803581F0
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		protected override void OpenUserManual(); // 0x00000001803581E0-0x00000001803581F0
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		protected override void OpenScriptReference(); // 0x00000001803581E0-0x00000001803581F0
		public override void ResetPosition(); // 0x0000000181C1B2F0-0x0000000181C1B310
		private bool IsReadyToInitiate(); // 0x0000000181C1F440-0x0000000181C1F4E0
		private void Update(); // 0x0000000181C200D0-0x0000000181C201F0
		private void Initiate(); // 0x0000000181C1F150-0x0000000181C1F440
		private void OnSolverUpdate(); // 0x0000000181C1FAC0-0x0000000181C1FF50
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg); // 0x0000000181C1FF50-0x0000000181C200D0
		private void OnPostSolverUpdate(); // 0x0000000181C1F790-0x0000000181C1FAC0
		private void OnDrawGizmosSelected(); // 0x0000000181C1F680-0x0000000181C1F790
		private void OnDestroy(); // 0x0000000181C1F4E0-0x0000000181C1F680
	}
}
