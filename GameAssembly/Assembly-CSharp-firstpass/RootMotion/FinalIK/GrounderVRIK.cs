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
	[AddComponentMenu] // 0x000000018022DD30-0x000000018022DD60
	public class GrounderVRIK : Grounder // TypeDefIndex: 9881
	{
		// Fields
		[Tooltip] // 0x000000018022E020-0x000000018022E050
		public VRIK ik; // 0x40
		private Transform[] feet; // 0x48
	
		// Constructors
		public GrounderVRIK(); // 0x00000001819DB360-0x00000001819DB3B0
	
		// Methods
		[ContextMenu] // 0x0000000180229D00-0x0000000180229D30
		private void OpenTutorial(); // 0x00000001803774A0-0x00000001803774B0
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		protected override void OpenUserManual(); // 0x00000001803774A0-0x00000001803774B0
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		protected override void OpenScriptReference(); // 0x00000001803774A0-0x00000001803774B0
		public override void ResetPosition(); // 0x0000000181439880-0x00000001814398A0
		private bool IsReadyToInitiate(); // 0x00000001819DA610-0x00000001819DA6B0
		private void Update(); // 0x00000001819DB240-0x00000001819DB360
		private void Initiate(); // 0x00000001819DA350-0x00000001819DA610
		private void OnSolverUpdate(); // 0x00000001819DAC60-0x00000001819DB0D0
		private void SetLegIK(IKSolverVR.PositionOffset positionOffset, Transform bone, Grounding.Leg leg); // 0x00000001819DB0D0-0x00000001819DB240
		private void OnPostSolverUpdate(); // 0x00000001819DA950-0x00000001819DAC60
		private void OnDrawGizmosSelected(); // 0x00000001819DA840-0x00000001819DA950
		private void OnDestroy(); // 0x00000001819DA6B0-0x00000001819DA840
	}
}
