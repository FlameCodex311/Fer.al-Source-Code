/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.Demos
{
	public abstract class PickUp2Handed : UnityEngine.MonoBehaviour // TypeDefIndex: 9822
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		private bool holding { get; } // 0x0000000181380DB0-0x0000000181380DE0 
	
		// Constructors
		protected PickUp2Handed(); // 0x0000000181380DA0-0x0000000181380DB0
	
		// Methods
		private void OnGUI(); // 0x00000001813807A0-0x0000000181380930
		protected abstract void RotatePivot();
		private void Start(); // 0x0000000181380BF0-0x0000000181380DA0
		private void OnPause(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x0000000181380930-0x0000000181380B00
		private void OnStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x0000000181380B00-0x0000000181380BF0
		private void OnDrop(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x0000000181380660-0x00000001813807A0
		private void LateUpdate(); // 0x00000001813801F0-0x0000000181380480
		private void OnDestroy(); // 0x0000000181380480-0x0000000181380660
	}
}
