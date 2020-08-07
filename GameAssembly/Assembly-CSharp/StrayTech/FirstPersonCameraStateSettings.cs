/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	[Serializable]
	public class FirstPersonCameraStateSettings : ICameraStateSettings // TypeDefIndex: 14522
	{
		// Fields
		[SerializeField] // 0x000000018024C220-0x000000018024C260
		[Tooltip] // 0x000000018024C220-0x000000018024C260
		private Transform _positionRootTransform; // 0x10
		[SerializeField] // 0x000000018024C3E0-0x000000018024C420
		[Tooltip] // 0x000000018024C3E0-0x000000018024C420
		private Transform _characterTransform; // 0x18
		[SerializeField] // 0x000000018024C4F0-0x000000018024C530
		[Tooltip] // 0x000000018024C4F0-0x000000018024C530
		private Vector3 _positionOffset; // 0x20
		[SerializeField] // 0x000000018024C700-0x000000018024C740
		[Tooltip] // 0x000000018024C700-0x000000018024C740
		private Vector2 _pitchRange; // 0x2C
		[SerializeField] // 0x000000018024C950-0x000000018024C990
		[Tooltip] // 0x000000018024C950-0x000000018024C990
		private Vector2 _mouseLookSensitivity; // 0x34
		[SerializeField] // 0x000000018024CAF0-0x000000018024CB30
		[Tooltip] // 0x000000018024CAF0-0x000000018024CB30
		private float _mouseSmoothing; // 0x3C
	
		// Properties
		public Transform PositionRootTransform { get; } // 0x0000000180372440-0x0000000180372450 
		public Transform CharacterTransform { get; } // 0x0000000180372430-0x0000000180372440 
		public Vector3 PositionOffset { get; } // 0x0000000180452C20-0x0000000180452C40 
		public Vector2 PitchRange { get; } // 0x0000000180CB3510-0x0000000180CB3530 
		public Vector2 MouseLookSensitivity { get; } // 0x000000018054BAF0-0x000000018054BB10 
		public float MouseSmoothing { get; } // 0x0000000180379EF0-0x0000000180379F00 
		public bool UseCameraCollision { get; } // 0x0000000180380950-0x0000000180380960 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x0000000180411150-0x0000000180411160 
	
		// Constructors
		public FirstPersonCameraStateSettings(Transform positionRoot, Transform characterTransform, Vector3 positionOffset, Vector2 pitchRange, Vector2 mouseLookSensitivity, float mouseSmoothing); // 0x0000000180CB3400-0x0000000180CB3510
	}
}
