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
	[AddComponentMenu] // 0x0000000180266E10-0x0000000180266E70
	[HelpURL] // 0x0000000180266E10-0x0000000180266E70
	public class InteractionTarget : UnityEngine.MonoBehaviour // TypeDefIndex: 9963
	{
		// Fields
		[Tooltip] // 0x0000000180266FF0-0x0000000180267020
		public FullBodyBipedEffector effectorType; // 0x18
		[Tooltip] // 0x0000000180267180-0x00000001802671B0
		public Multiplier[] multipliers; // 0x20
		[Tooltip] // 0x0000000180267260-0x0000000180267290
		public float interactionSpeedMlp; // 0x28
		[Tooltip] // 0x0000000180267440-0x0000000180267470
		public Transform pivot; // 0x30
		[Tooltip] // 0x0000000180267500-0x0000000180267530
		public Vector3 twistAxis; // 0x38
		[Tooltip] // 0x0000000180267600-0x0000000180267630
		public float twistWeight; // 0x44
		[Tooltip] // 0x0000000180267670-0x00000001802676A0
		public float swingWeight; // 0x48
		[Tooltip] // 0x0000000180267860-0x0000000180267890
		public bool rotateOnce; // 0x4C
		private Quaternion defaultLocalRotation; // 0x50
		private Transform lastPivot; // 0x60
	
		// Nested types
		[Serializable]
		public class Multiplier // TypeDefIndex: 9964
		{
			// Fields
			[Tooltip] // 0x0000000180268330-0x0000000180268360
			public InteractionObject.WeightCurve.Type curve; // 0x10
			[Tooltip] // 0x0000000180268440-0x0000000180268470
			public float multiplier; // 0x14
	
			// Constructors
			public Multiplier(); // 0x0000000180373240-0x0000000180373250
		}
	
		// Constructors
		public InteractionTarget(); // 0x0000000181638EF0-0x0000000181638F70
	
		// Methods
		[ContextMenu] // 0x000000018025DB00-0x000000018025DB30
		private void OpenTutorial1(); // 0x00000001816386D0-0x0000000181638710
		[ContextMenu] // 0x000000018025DD40-0x000000018025DD70
		private void OpenTutorial2(); // 0x0000000181638710-0x0000000181638750
		[ContextMenu] // 0x000000018025DE30-0x000000018025DE60
		private void OpenTutorial3(); // 0x0000000181638750-0x0000000181638790
		[ContextMenu] // 0x000000018025DFF0-0x000000018025E020
		private void OpenTutorial4(); // 0x0000000181638790-0x00000001816387D0
		[ContextMenu] // 0x00000001802233A0-0x00000001802233D0
		private void SupportGroup(); // 0x0000000181638EB0-0x0000000181638EF0
		[ContextMenu] // 0x0000000180223520-0x0000000180223550
		private void ASThread(); // 0x0000000181638580-0x00000001816385C0
		public float GetValue(InteractionObject.WeightCurve.Type curveType); // 0x00000001816385C0-0x0000000181638690
		public void ResetRotation(); // 0x0000000181638810-0x00000001816388A0
		public void RotateTo(Vector3 position); // 0x00000001816388A0-0x0000000181638EB0
		[ContextMenu] // 0x00000001801E9920-0x00000001801E9950
		private void OpenUserManual(); // 0x00000001816387D0-0x0000000181638810
		[ContextMenu] // 0x00000001801E9B90-0x00000001801E9BC0
		private void OpenScriptReference(); // 0x0000000181638690-0x00000001816386D0
	}
}
