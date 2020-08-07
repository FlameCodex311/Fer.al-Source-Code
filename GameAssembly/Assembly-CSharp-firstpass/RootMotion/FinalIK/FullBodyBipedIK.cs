/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	[AddComponentMenu] // 0x0000000180238EF0-0x0000000180238F50
	[HelpURL] // 0x0000000180238EF0-0x0000000180238F50
	public class FullBodyBipedIK : IK // TypeDefIndex: 9891
	{
		// Fields
		public BipedReferences references; // 0x38
		public IKSolverFullBodyBiped solver; // 0x40
	
		// Constructors
		public FullBodyBipedIK(); // 0x0000000181435280-0x0000000181435300
	
		// Methods
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		protected override void OpenUserManual(); // 0x0000000181434AB0-0x0000000181434AF0
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		protected override void OpenScriptReference(); // 0x0000000181434A30-0x0000000181434A70
		[ContextMenu] // 0x00000001802397C0-0x00000001802397F0
		private void OpenSetupTutorial(); // 0x0000000181434A70-0x0000000181434AB0
		[ContextMenu] // 0x0000000180239A60-0x0000000180239A90
		private void OpenInspectorTutorial(); // 0x00000001814349F0-0x0000000181434A30
		[ContextMenu] // 0x00000001802233A0-0x00000001802233D0
		private void SupportGroup(); // 0x0000000181435240-0x0000000181435280
		[ContextMenu] // 0x0000000180223520-0x0000000180223550
		private void ASThread(); // 0x00000001814348D0-0x0000000181434910
		public void SetReferences(BipedReferences references, Transform rootNode); // 0x0000000181435210-0x0000000181435240
		public override IKSolver GetIKSolver(); // 0x00000001803C7290-0x00000001803C72A0
		public bool ReferencesError(ref string errorMessage); // 0x0000000181434AF0-0x0000000181434D70
		public bool ReferencesWarning(ref string warningMessage); // 0x0000000181434D70-0x00000001814351E0
		[ContextMenu] // 0x0000000180239FF0-0x000000018023A020
		private void Reinitiate(); // 0x00000001814351E0-0x0000000181435210
		[ContextMenu] // 0x000000018023A280-0x000000018023A2B0
		private void AutoDetectReferences(); // 0x0000000181434910-0x00000001814349F0
	}
}
