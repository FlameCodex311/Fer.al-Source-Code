/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion.FinalIK
{
	[Serializable]
	public class InteractionEffector // TypeDefIndex: 9951
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private FullBodyBipedEffector <effectorType>k__BackingField; // 0x10
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <isPaused>k__BackingField; // 0x14
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		public FullBodyBipedEffector effectorType { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180387590-0x0000000180387930 0x00000001803FEB70-0x00000001803FEB80
		public bool isPaused { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001809A8910-0x00000001809A8920 0x0000000180DE28E0-0x0000000180DE28F0
		public InteractionObject interactionObject { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
		public bool inInteraction { get; } // 0x000000018162FC90-0x000000018162FCF0 
		public float progress { get; } // 0x000000018162FCF0-0x000000018162FD70 
	
		// Constructors
		public InteractionEffector(FullBodyBipedEffector effectorType); // 0x000000018162FC10-0x000000018162FC90
	
		// Methods
		public void Initiate(InteractionSystem interactionSystem); // 0x000000018162D3F0-0x000000018162D4B0
		private void StoreDefaults(); // 0x000000018162EB80-0x000000018162EDC0
		public bool ResetToDefaults(float speed); // 0x000000018162DC70-0x000000018162E2C0
		public bool Pause(); // 0x000000018162D810-0x000000018162D9F0
		public bool Resume(); // 0x000000018162E2C0-0x000000018162E380
		public bool Start(InteractionObject interactionObject, string tag, float fadeInTime, bool interrupt); // 0x000000018162E380-0x000000018162E930
		public void Update(Transform root, float speed); // 0x000000018162F240-0x000000018162FC10
		private void TriggerUntriggeredEvents(bool checkTime, out bool pickUp, out bool pause); // 0x000000018162EDC0-0x000000018162F240
		private void PickUp(Transform root); // 0x000000018162D9F0-0x000000018162DC70
		public bool Stop(); // 0x000000018162E930-0x000000018162EB80
		public void OnPostFBBIK(); // 0x000000018162D4B0-0x000000018162D810
	}
}
