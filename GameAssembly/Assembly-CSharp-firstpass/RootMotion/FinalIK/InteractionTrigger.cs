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
	[AddComponentMenu] // 0x00000001801683B0-0x0000000180168410
	[HelpURL] // 0x00000001801683B0-0x0000000180168410
	public class InteractionTrigger : UnityEngine.MonoBehaviour // TypeDefIndex: 9431
	{
		// Fields
		[Tooltip] // 0x0000000180168690-0x00000001801686C0
		public Range[] ranges; // 0x18
	
		// Nested types
		[Serializable]
		public class CharacterPosition // TypeDefIndex: 9432
		{
			// Fields
			[Tooltip] // 0x0000000180168BE0-0x0000000180168C10
			public bool use; // 0x10
			[Tooltip] // 0x0000000180168D90-0x0000000180168DC0
			public Vector2 offset; // 0x14
			[Range] // 0x0000000180169020-0x0000000180169080
			[Tooltip] // 0x0000000180169020-0x0000000180169080
			public float angleOffset; // 0x1C
			[Range] // 0x00000001801691D0-0x0000000180169230
			[Tooltip] // 0x00000001801691D0-0x0000000180169230
			public float maxAngle; // 0x20
			[Tooltip] // 0x000000018016A900-0x000000018016A930
			public float radius; // 0x24
			[Tooltip] // 0x000000018016AAC0-0x000000018016AAF0
			public bool orbit; // 0x28
			[Tooltip] // 0x000000018016AB80-0x000000018016ABB0
			public bool fixYAxis; // 0x29
	
			// Properties
			public Vector3 offset3D { get; } // 0x0000000181AF3E40-0x0000000181AF3E80 
			public Vector3 direction3D { get; } // 0x0000000181AF3D30-0x0000000181AF3E40 
	
			// Constructors
			public CharacterPosition(); // 0x0000000181AF3D10-0x0000000181AF3D30
	
			// Methods
			public bool IsInRange(Transform character, Transform trigger, out float error); // 0x0000000181AF33A0-0x0000000181AF3D10
		}
	
		[Serializable]
		public class CameraPosition // TypeDefIndex: 9433
		{
			// Fields
			[Tooltip] // 0x000000018016AD60-0x000000018016AD90
			public Collider lookAtTarget; // 0x10
			[Tooltip] // 0x000000018016AEE0-0x000000018016AF10
			public Vector3 direction; // 0x18
			[Tooltip] // 0x000000018016B0B0-0x000000018016B0E0
			public float maxDistance; // 0x24
			[Range] // 0x000000018016B240-0x000000018016B2A0
			[Tooltip] // 0x000000018016B240-0x000000018016B2A0
			public float maxAngle; // 0x28
			[Tooltip] // 0x000000018016B4C0-0x000000018016B4F0
			public bool fixYAxis; // 0x2C
	
			// Constructors
			public CameraPosition(); // 0x0000000181AF3300-0x0000000181AF33A0
	
			// Methods
			public Quaternion GetRotation(); // 0x0000000181AF2DB0-0x0000000181AF2FD0
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error); // 0x0000000181AF2FD0-0x0000000181AF3300
		}
	
		[Serializable]
		public class Range // TypeDefIndex: 9434
		{
			// Fields
			[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
			[SerializeField] // 0x00000001800B4050-0x00000001800B4080
			public string name; // 0x10
			[HideInInspector] // 0x00000001800B4050-0x00000001800B4080
			[SerializeField] // 0x00000001800B4050-0x00000001800B4080
			public bool show; // 0x18
			[Tooltip] // 0x000000018016B910-0x000000018016B940
			public CharacterPosition characterPosition; // 0x20
			[Tooltip] // 0x000000018016BB10-0x000000018016BB40
			public CameraPosition cameraPosition; // 0x28
			[Tooltip] // 0x000000018016BCA0-0x000000018016BCD0
			public Interaction[] interactions; // 0x30
	
			// Nested types
			[Serializable]
			public class Interaction // TypeDefIndex: 9435
			{
				// Fields
				[Tooltip] // 0x000000018016BF40-0x000000018016BF70
				public InteractionObject interactionObject; // 0x10
				[Tooltip] // 0x000000018016C1F0-0x000000018016C220
				public FullBodyBipedEffector[] effectors; // 0x18
	
				// Constructors
				public Interaction(); // 0x000000018036B6C0-0x000000018036B6D0
			}
	
			// Constructors
			public Range(); // 0x0000000180F8A820-0x0000000180F8A830
	
			// Methods
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError); // 0x0000000181B0C510-0x0000000181B0C670
		}
	
		// Constructors
		public InteractionTrigger(); // 0x0000000181B00D10-0x0000000181B00D60
	
		// Methods
		[ContextMenu] // 0x0000000180124A10-0x0000000180124A40
		private void OpenTutorial4(); // 0x0000000181B00C90-0x0000000181B00CD0
		[ContextMenu] // 0x000000018011E390-0x000000018011E3C0
		private void SupportGroup(); // 0x0000000181B00CD0-0x0000000181B00D10
		[ContextMenu] // 0x000000018011E5A0-0x000000018011E5D0
		private void ASThread(); // 0x0000000181B009C0-0x0000000181B00A00
		private void Start(); // 0x00000001803581E0-0x00000001803581F0
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit); // 0x0000000181B00A00-0x0000000181B00C90
	}
}
