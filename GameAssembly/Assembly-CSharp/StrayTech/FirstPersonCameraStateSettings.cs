/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	[Serializable]
	public class FirstPersonCameraStateSettings : ICameraStateSettings // TypeDefIndex: 13855
	{
		// Fields
		[SerializeField] // 0x000000018011FC70-0x000000018011FCB0
		[Tooltip] // 0x000000018011FC70-0x000000018011FCB0
		private Transform _positionRootTransform; // 0x10
		[SerializeField] // 0x000000018011FE30-0x000000018011FE70
		[Tooltip] // 0x000000018011FE30-0x000000018011FE70
		private Transform _characterTransform; // 0x18
		[SerializeField] // 0x00000001801200E0-0x0000000180120120
		[Tooltip] // 0x00000001801200E0-0x0000000180120120
		private Vector3 _positionOffset; // 0x20
		[SerializeField] // 0x00000001801204A0-0x00000001801204E0
		[Tooltip] // 0x00000001801204A0-0x00000001801204E0
		private Vector2 _pitchRange; // 0x2C
		[SerializeField] // 0x00000001801206D0-0x0000000180120710
		[Tooltip] // 0x00000001801206D0-0x0000000180120710
		private Vector2 _mouseLookSensitivity; // 0x34
		[SerializeField] // 0x0000000180121BA0-0x0000000180121BE0
		[Tooltip] // 0x0000000180121BA0-0x0000000180121BE0
		private float _mouseSmoothing; // 0x3C
	
		// Properties
		public Transform PositionRootTransform { get; } // 0x000000018036AC80-0x000000018036AC90 
		public Transform CharacterTransform { get; } // 0x000000018038B150-0x000000018038B160 
		public Vector3 PositionOffset { get; } // 0x0000000180F86DA0-0x0000000180F86DC0 
		public Vector2 PitchRange { get; } // 0x00000001811FDF60-0x00000001811FDF80 
		public Vector2 MouseLookSensitivity { get; } // 0x0000000180F2E340-0x0000000180F2E360 
		public float MouseSmoothing { get; } // 0x0000000180E426C0-0x0000000180E426D0 
		public bool UseCameraCollision { get; } // 0x00000001803C28F0-0x00000001803C2900 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x0000000180362180-0x0000000180362190 
	
		// Constructors
		public FirstPersonCameraStateSettings(Transform positionRoot, Transform characterTransform, Vector3 positionOffset, Vector2 pitchRange, Vector2 mouseLookSensitivity, float mouseSmoothing); // 0x00000001811FDE50-0x00000001811FDF60
	}
}
