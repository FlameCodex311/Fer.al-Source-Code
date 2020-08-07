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
	[AddComponentMenu] // 0x0000000180268550-0x00000001802685B0
	[HelpURL] // 0x0000000180268550-0x00000001802685B0
	public class InteractionTrigger : UnityEngine.MonoBehaviour // TypeDefIndex: 9965
	{
		// Fields
		[Tooltip] // 0x00000001802686F0-0x0000000180268720
		public Range[] ranges; // 0x18
	
		// Nested types
		[Serializable]
		public class CharacterPosition // TypeDefIndex: 9966
		{
			// Fields
			[Tooltip] // 0x0000000180268BD0-0x0000000180268C00
			public bool use; // 0x10
			[Tooltip] // 0x0000000180268DC0-0x0000000180268DF0
			public Vector2 offset; // 0x14
			[Range] // 0x0000000180268EC0-0x0000000180268F20
			[Tooltip] // 0x0000000180268EC0-0x0000000180268F20
			public float angleOffset; // 0x1C
			[Range] // 0x0000000180269380-0x00000001802693E0
			[Tooltip] // 0x0000000180269380-0x00000001802693E0
			public float maxAngle; // 0x20
			[Tooltip] // 0x00000001802695C0-0x00000001802695F0
			public float radius; // 0x24
			[Tooltip] // 0x0000000180269860-0x0000000180269890
			public bool orbit; // 0x28
			[Tooltip] // 0x00000001802699F0-0x0000000180269A20
			public bool fixYAxis; // 0x29
	
			// Properties
			public Vector3 offset3D { get; } // 0x000000018162C9E0-0x000000018162CA20 
			public Vector3 direction3D { get; } // 0x000000018162C8D0-0x000000018162C9E0 
	
			// Constructors
			public CharacterPosition(); // 0x000000018162C8B0-0x000000018162C8D0
	
			// Methods
			public bool IsInRange(Transform character, Transform trigger, out float error); // 0x000000018162BF50-0x000000018162C8B0
		}
	
		[Serializable]
		public class CameraPosition // TypeDefIndex: 9967
		{
			// Fields
			[Tooltip] // 0x0000000180269B50-0x0000000180269B80
			public Collider lookAtTarget; // 0x10
			[Tooltip] // 0x0000000180269E20-0x0000000180269E50
			public Vector3 direction; // 0x18
			[Tooltip] // 0x000000018026A0D0-0x000000018026A100
			public float maxDistance; // 0x24
			[Range] // 0x000000018026A320-0x000000018026A380
			[Tooltip] // 0x000000018026A320-0x000000018026A380
			public float maxAngle; // 0x28
			[Tooltip] // 0x000000018026A4F0-0x000000018026A520
			public bool fixYAxis; // 0x2C
	
			// Constructors
			public CameraPosition(); // 0x000000018162BEB0-0x000000018162BF50
	
			// Methods
			public Quaternion GetRotation(); // 0x000000018162B970-0x000000018162BB90
			public bool IsInRange(Transform raycastFrom, RaycastHit hit, Transform trigger, out float error); // 0x000000018162BB90-0x000000018162BEB0
		}
	
		[Serializable]
		public class Range // TypeDefIndex: 9968
		{
			// Fields
			[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
			[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
			public string name; // 0x10
			[HideInInspector] // 0x00000001801CDDD0-0x00000001801CDE00
			[SerializeField] // 0x00000001801CDDD0-0x00000001801CDE00
			public bool show; // 0x18
			[Tooltip] // 0x000000018026ABB0-0x000000018026ABE0
			public CharacterPosition characterPosition; // 0x20
			[Tooltip] // 0x000000018026AD90-0x000000018026ADC0
			public CameraPosition cameraPosition; // 0x28
			[Tooltip] // 0x000000018026AF30-0x000000018026AF60
			public Interaction[] interactions; // 0x30
	
			// Nested types
			[Serializable]
			public class Interaction // TypeDefIndex: 9969
			{
				// Fields
				[Tooltip] // 0x000000018026B100-0x000000018026B130
				public InteractionObject interactionObject; // 0x10
				[Tooltip] // 0x000000018026B250-0x000000018026B280
				public FullBodyBipedEffector[] effectors; // 0x18
	
				// Constructors
				public Interaction(); // 0x0000000180373240-0x0000000180373250
			}
	
			// Constructors
			public Range(); // 0x0000000180632850-0x0000000180632860
	
			// Methods
			public bool IsInRange(Transform character, Transform raycastFrom, RaycastHit raycastHit, Transform trigger, out float maxError); // 0x000000018163D300-0x000000018163D460
		}
	
		// Constructors
		public InteractionTrigger(); // 0x00000001816392C0-0x0000000181639310
	
		// Methods
		[ContextMenu] // 0x0000000180229D00-0x0000000180229D30
		private void OpenTutorial4(); // 0x0000000181639240-0x0000000181639280
		[ContextMenu] // 0x00000001802233A0-0x00000001802233D0
		private void SupportGroup(); // 0x0000000181639280-0x00000001816392C0
		[ContextMenu] // 0x0000000180223520-0x0000000180223550
		private void ASThread(); // 0x0000000181638F70-0x0000000181638FB0
		private void Start(); // 0x00000001803774A0-0x00000001803774B0
		public int GetBestRangeIndex(Transform character, Transform raycastFrom, RaycastHit raycastHit); // 0x0000000181638FB0-0x0000000181639240
	}
}
