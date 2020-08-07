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
	[AddComponentMenu] // 0x0000000180229430-0x0000000180229490
	[HelpURL] // 0x0000000180229430-0x0000000180229490
	public class GrounderFBBIK : Grounder // TypeDefIndex: 9876
	{
		// Fields
		[Tooltip] // 0x0000000180229730-0x0000000180229760
		public FullBodyBipedIK ik; // 0x40
		[Tooltip] // 0x0000000180228AF0-0x0000000180228B20
		public float spineBend; // 0x48
		[Tooltip] // 0x0000000180228D10-0x0000000180228D40
		public float spineSpeed; // 0x4C
		public SpineEffector[] spine; // 0x50
		private Transform[] feet; // 0x58
		private Vector3 spineOffset; // 0x60
		private bool firstSolve; // 0x6C
	
		// Nested types
		[Serializable]
		public class SpineEffector // TypeDefIndex: 9877
		{
			// Fields
			[Tooltip] // 0x000000018022A440-0x000000018022A470
			public FullBodyBipedEffector effectorType; // 0x10
			[Tooltip] // 0x000000018022A600-0x000000018022A630
			public float horizontalWeight; // 0x14
			[Tooltip] // 0x000000018022A6C0-0x000000018022A6F0
			public float verticalWeight; // 0x18
	
			// Constructors
			public SpineEffector(); // 0x00000001807843A0-0x00000001807843B0
			public SpineEffector(FullBodyBipedEffector effectorType, float horizontalWeight, float verticalWeight); // 0x000000018143EAA0-0x000000018143EAF0
		}
	
		// Constructors
		public GrounderFBBIK(); // 0x00000001814384B0-0x0000000181438560
	
		// Methods
		[ContextMenu] // 0x0000000180229D00-0x0000000180229D30
		private void OpenTutorial(); // 0x0000000181438030-0x0000000181438070
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		protected override void OpenUserManual(); // 0x0000000181438070-0x00000001814380B0
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		protected override void OpenScriptReference(); // 0x0000000181437FF0-0x0000000181438030
		public override void ResetPosition(); // 0x00000001814380B0-0x0000000181438130
		private bool IsReadyToInitiate(); // 0x0000000181437600-0x00000001814376A0
		private void Update(); // 0x0000000181438390-0x00000001814384B0
		private void FixedUpdate(); // 0x0000000181437300-0x0000000181437310
		private void LateUpdate(); // 0x0000000181437300-0x0000000181437310
		private void Initiate(); // 0x0000000181437310-0x0000000181437600
		private void OnSolverUpdate(); // 0x00000001814378B0-0x0000000181437FF0
		private void SetLegIK(IKEffector effector, Grounding.Leg leg); // 0x0000000181438130-0x0000000181438390
		private void OnDrawGizmosSelected(); // 0x00000001814377A0-0x00000001814378B0
		private void OnDestroy(); // 0x00000001814376A0-0x00000001814377A0
	}
}
