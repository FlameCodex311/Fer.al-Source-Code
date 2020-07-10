/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion.FinalIK
{
	[Serializable]
	public class InteractionEffector // TypeDefIndex: 9417
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private FullBodyBipedEffector <effectorType>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <isPaused>k__BackingField; // 0x14
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private InteractionObject <interactionObject>k__BackingField; // 0x18
		private Poser poser; // 0x20
		private IKEffector effector; // 0x28
		private float timer; // 0x30
		private float length; // 0x34
		private float weight; // 0x38
		private float fadeInSpeed; // 0x3C
		private float defaultPositionWeight; // 0x40
		private float defaultRotationWeight; // 0x44
		private float defaultPull; // 0x48
		private float defaultReach; // 0x4C
		private float defaultPush; // 0x50
		private float defaultPushParent; // 0x54
		private float resetTimer; // 0x58
		private bool positionWeightUsed; // 0x5C
		private bool rotationWeightUsed; // 0x5D
		private bool pullUsed; // 0x5E
		private bool reachUsed; // 0x5F
		private bool pushUsed; // 0x60
		private bool pushParentUsed; // 0x61
		private bool pickedUp; // 0x62
		private bool defaults; // 0x63
		private bool pickUpOnPostFBBIK; // 0x64
		private Vector3 pickUpPosition; // 0x68
		private Vector3 pausePositionRelative; // 0x74
		private Quaternion pickUpRotation; // 0x80
		private Quaternion pauseRotationRelative; // 0x90
		private InteractionTarget interactionTarget; // 0xA0
		private Transform target; // 0xA8
		private List<bool> triggered; // 0xB0
		private InteractionSystem interactionSystem; // 0xB8
		private bool started; // 0xC0
	
		// Properties
		public FullBodyBipedEffector effectorType { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036CFF0-0x000000018036D000 0x000000018037AA40-0x000000018037AA50
		public bool isPaused { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180491CD0-0x0000000180491CE0 0x00000001805F6220-0x00000001805F6230
		public InteractionObject interactionObject { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
		public bool inInteraction { get; } // 0x0000000181AF7270-0x0000000181AF72D0 
		public float progress { get; } // 0x0000000181AF72D0-0x0000000181AF7350 
	
		// Constructors
		public InteractionEffector(FullBodyBipedEffector effectorType); // 0x0000000181AF71F0-0x0000000181AF7270
	
		// Methods
		public void Initiate(InteractionSystem interactionSystem); // 0x0000000181AF4890-0x0000000181AF4950
		private void StoreDefaults(); // 0x0000000181AF60B0-0x0000000181AF6310
		public bool ResetToDefaults(float speed); // 0x0000000181AF5150-0x0000000181AF57C0
		public bool Pause(); // 0x0000000181AF4CD0-0x0000000181AF4EC0
		public bool Resume(); // 0x0000000181AF57C0-0x0000000181AF5880
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt); // 0x0000000181AF5880-0x0000000181AF5E50
		public void Update(Transform root, float speed); // 0x0000000181AF67D0-0x0000000181AF71F0
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause); // 0x0000000181AF6310-0x0000000181AF67D0
		private void PickUp(Transform root); // 0x0000000181AF4EC0-0x0000000181AF5150
		public bool Stop(); // 0x0000000181AF5E50-0x0000000181AF60B0
		public void OnPostFBBIK(); // 0x0000000181AF4950-0x0000000181AF4CD0
	}
}
