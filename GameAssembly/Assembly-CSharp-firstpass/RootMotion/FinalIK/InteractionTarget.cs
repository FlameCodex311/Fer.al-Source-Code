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
	[AddComponentMenu] // 0x0000000180164C70-0x0000000180164CD0
	[HelpURL] // 0x0000000180164C70-0x0000000180164CD0
	public class InteractionTarget : UnityEngine.MonoBehaviour // TypeDefIndex: 9429
	{
		// Fields
		[Tooltip] // 0x0000000180164E90-0x0000000180164EC0
		public FullBodyBipedEffector effectorType; // 0x18
		[Tooltip] // 0x0000000180165010-0x0000000180165040
		public Multiplier[] multipliers; // 0x20
		[Tooltip] // 0x00000001801651F0-0x0000000180165220
		public float interactionSpeedMlp; // 0x28
		[Tooltip] // 0x0000000180165400-0x0000000180165430
		public Transform pivot; // 0x30
		[Tooltip] // 0x0000000180165650-0x0000000180165680
		public Vector3 twistAxis; // 0x38
		[Tooltip] // 0x0000000180165740-0x0000000180165770
		public float twistWeight; // 0x44
		[Tooltip] // 0x0000000180165A50-0x0000000180165A80
		public float swingWeight; // 0x48
		[Tooltip] // 0x0000000180165C60-0x0000000180165C90
		public bool rotateOnce; // 0x4C
		private Quaternion defaultLocalRotation; // 0x50
		private Transform lastPivot; // 0x60
	
		// Nested types
		[Serializable]
		public class Multiplier // TypeDefIndex: 9430
		{
			// Fields
			[Tooltip] // 0x0000000180167EA0-0x0000000180167ED0
			public InteractionObject.WeightCurve.Type curve; // 0x10
			[Tooltip] // 0x0000000180168130-0x0000000180168160
			public float multiplier; // 0x14
	
			// Constructors
			public Multiplier(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		// Constructors
		public InteractionTarget(); // 0x0000000181B00940-0x0000000181B009C0
	
		// Methods
		[ContextMenu] // 0x000000018015D0D0-0x000000018015D100
		private void OpenTutorial1(); // 0x0000000181B00100-0x0000000181B00140
		[ContextMenu] // 0x000000018015D1F0-0x000000018015D220
		private void OpenTutorial2(); // 0x0000000181B00140-0x0000000181B00180
		[ContextMenu] // 0x000000018015D480-0x000000018015D4B0
		private void OpenTutorial3(); // 0x0000000181B00180-0x0000000181B001C0
		[ContextMenu] // 0x000000018015D6A0-0x000000018015D6D0
		private void OpenTutorial4(); // 0x0000000181B001C0-0x0000000181B00200
		[ContextMenu] // 0x000000018011E390-0x000000018011E3C0
		private void SupportGroup(); // 0x0000000181B00900-0x0000000181B00940
		[ContextMenu] // 0x000000018011E5A0-0x000000018011E5D0
		private void ASThread(); // 0x0000000181AFFFA0-0x0000000181AFFFE0
		public float GetValue(InteractionObject.WeightCurve.Type curveType); // 0x0000000181AFFFE0-0x0000000181B000C0
		public void ResetRotation(); // 0x0000000181B00240-0x0000000181B002D0
		public void RotateTo(Vector3 position); // 0x0000000181B002D0-0x0000000181B00900
		[ContextMenu] // 0x0000000180119E00-0x0000000180119E30
		private void OpenUserManual(); // 0x0000000181B00200-0x0000000181B00240
		[ContextMenu] // 0x000000018011A010-0x000000018011A040
		private void OpenScriptReference(); // 0x0000000181B000C0-0x0000000181B00100
	}
}
