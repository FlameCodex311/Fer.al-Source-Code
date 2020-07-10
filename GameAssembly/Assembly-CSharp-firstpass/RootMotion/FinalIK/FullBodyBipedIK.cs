/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x0000000180133D50-0x0000000180133DB0
	[HelpURL] // 0x0000000180133D50-0x0000000180133DB0
	public class FullBodyBipedIK : IK // TypeDefIndex: 9357
	{
		// Fields
		public BipedReferences references; // 0x38
		public IKSolverFullBodyBiped solver; // 0x40
	
		// Constructors
		public FullBodyBipedIK(); // 0x0000000181C16E20-0x0000000181C16EA0
	
		// Methods
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		protected override void OpenUserManual(); // 0x0000000181C16620-0x0000000181C16660
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		protected override void OpenScriptReference(); // 0x0000000181C165A0-0x0000000181C165E0
		[ContextMenu] // 0x0000000180134190-0x00000001801341C0
		private void OpenSetupTutorial(); // 0x0000000181C165E0-0x0000000181C16620
		[ContextMenu] // 0x0000000180135580-0x00000001801355B0
		private void OpenInspectorTutorial(); // 0x0000000181C16560-0x0000000181C165A0
		[ContextMenu] // 0x000000018011E390-0x000000018011E3C0
		private void SupportGroup(); // 0x0000000181C16DE0-0x0000000181C16E20
		[ContextMenu] // 0x000000018011E5A0-0x000000018011E5D0
		private void ASThread(); // 0x0000000181C16440-0x0000000181C16480
		public void SetReferences(BipedReferences references, Transform rootNode); // 0x0000000181C16DB0-0x0000000181C16DE0
		public override IKSolver GetIKSolver(); // 0x0000000180369B30-0x0000000180369B40
		public bool ReferencesError(ref string errorMessage); // 0x0000000181C16660-0x0000000181C168F0
		public bool ReferencesWarning(ref string warningMessage); // 0x0000000181C168F0-0x0000000181C16D80
		[ContextMenu] // 0x0000000180135910-0x0000000180135940
		private void Reinitiate(); // 0x0000000181C16D80-0x0000000181C16DB0
		[ContextMenu] // 0x0000000180135970-0x00000001801359A0
		private void AutoDetectReferences(); // 0x0000000181C16480-0x0000000181C16560
	}
}
