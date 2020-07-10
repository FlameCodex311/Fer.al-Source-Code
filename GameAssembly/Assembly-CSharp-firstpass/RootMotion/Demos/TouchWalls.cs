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
	public class TouchWalls : UnityEngine.MonoBehaviour // TypeDefIndex: 9544
	{
		// Fields
		public InteractionSystem interactionSystem; // 0x18
		public EffectorLink[] effectorLinks; // 0x20
	
		// Nested types
		[Serializable]
		public class EffectorLink // TypeDefIndex: 9545
		{
			// Fields
			public bool enabled; // 0x10
			public FullBodyBipedEffector effectorType; // 0x14
			public InteractionObject interactionObject; // 0x18
			public Transform spherecastFrom; // 0x20
			public float spherecastRadius; // 0x28
			public float minDistance; // 0x2C
			public LayerMask touchLayers; // 0x30
			public float lerpSpeed; // 0x34
			public float minSwitchTime; // 0x38
			public float releaseDistance; // 0x3C
			public bool sliding; // 0x40
			private Vector3 raycastDirectionLocal; // 0x44
			private float raycastDistance; // 0x50
			private bool inTouch; // 0x54
			private RaycastHit hit; // 0x58
			private Vector3 targetPosition; // 0x84
			private Quaternion targetRotation; // 0x90
			private bool initiated; // 0xA0
			private float nextSwitchTime; // 0xA4
			private float speedF; // 0xA8
	
			// Constructors
			public EffectorLink(); // 0x0000000181822300-0x0000000181822330
	
			// Methods
			public void Initiate(InteractionSystem interactionSystem); // 0x0000000181821200-0x0000000181821600
			private bool FindWalls(Vector3 direction); // 0x00000001818210E0-0x0000000181821200
			public void Update(InteractionSystem interactionSystem); // 0x0000000181821940-0x0000000181822300
			private void StopTouch(InteractionSystem interactionSystem); // 0x0000000181821780-0x0000000181821940
			private void OnInteractionStart(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x0000000181821680-0x0000000181821700
			private void OnInteractionResume(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x0000000181821600-0x0000000181821680
			private void OnInteractionStop(FullBodyBipedEffector effectorType, InteractionObject interactionObject); // 0x0000000181821700-0x0000000181821780
			public void Destroy(InteractionSystem interactionSystem); // 0x0000000181820F40-0x00000001818210E0
		}
	
		// Constructors
		public TouchWalls(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void Start(); // 0x000000018183DA60-0x000000018183DAE0
		private void FixedUpdate(); // 0x000000018183D8F0-0x000000018183D980
		private void OnDestroy(); // 0x000000018183D980-0x000000018183DA60
	}
}
