/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.Demos
{
	public abstract class PickUp2Handed : UnityEngine.MonoBehaviour // TypeDefIndex: 9535
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int GUIspace; // 0x18
		public InteractionSystem interactionSystem; // 0x20
		public InteractionObject obj; // 0x28
		public Transform pivot; // 0x30
		public Transform holdPoint; // 0x38
		public float pickUpTime; // 0x40
		private float holdWeight; // 0x44
		private float holdWeightVel; // 0x48
		private Vector3 pickUpPosition; // 0x4C
		private Quaternion pickUpRotation; // 0x58
	
		// Properties
		private bool holding { get; } // 0x000000018183A590-0x000000018183A5C0 
	
		// Constructors
		protected PickUp2Handed(); // 0x000000018183A580-0x000000018183A590
	
		// Methods
		private void OnGUI(); // 0x0000000181839F80-0x000000018183A110
		protected abstract void RotatePivot();
		private void Start(); // 0x000000018183A3D0-0x000000018183A580
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x000000018183A110-0x000000018183A2E0
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x000000018183A2E0-0x000000018183A3D0
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x0000000181839E30-0x0000000181839F80
		private void LateUpdate(); // 0x00000001818399B0-0x0000000181839C40
		private void OnDestroy(); // 0x0000000181839C40-0x0000000181839E30
	}
}
