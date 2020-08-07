/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using StrayTech.CustomAttributes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	[Serializable]
	public class ThirdPersonCameraStateSettings : ICameraStateSettings // TypeDefIndex: 14527
	{
		// Fields
		[SerializeField] // 0x000000018024F760-0x000000018024F7A0
		[Tooltip] // 0x000000018024F760-0x000000018024F7A0
		private bool _mouseOrbit; // 0x10
		[SerializeField] // 0x000000018024FAF0-0x000000018024FB30
		[Tooltip] // 0x000000018024FAF0-0x000000018024FB30
		private Vector3 _targetOffset; // 0x14
		[SerializeField] // 0x0000000180251050-0x0000000180251090
		[Tooltip] // 0x0000000180251050-0x0000000180251090
		private Vector2 _mouseOrbitDistance; // 0x20
		[SerializeField] // 0x000000018024C700-0x000000018024C740
		[Tooltip] // 0x000000018024C700-0x000000018024C740
		private Vector2 _mousePitchRange; // 0x28
		[SerializeField] // 0x000000018024C950-0x000000018024C990
		[Tooltip] // 0x000000018024C950-0x000000018024C990
		private Vector2 _mouseSensitivity; // 0x30
		[SerializeField] // 0x00000001802519F0-0x0000000180251A30
		[Tooltip] // 0x00000001802519F0-0x0000000180251A30
		private bool _mouseInvertY; // 0x38
		[NonNegative] // 0x0000000180251C70-0x0000000180251CC0
		[SerializeField] // 0x0000000180251C70-0x0000000180251CC0
		[Tooltip] // 0x0000000180251C70-0x0000000180251CC0
		private float _motionSmoothing; // 0x3C
		[SerializeField] // 0x000000018024D170-0x000000018024D1B0
		[Tooltip] // 0x000000018024D170-0x000000018024D1B0
		private bool _useCameraCollision; // 0x40
	
		// Properties
		public bool MouseOrbit { get; } // 0x00000001803FD450-0x00000001803FD460 
		public Vector3 TargetOffset { get; } // 0x0000000180CBC920-0x0000000180CBC940 
		public Vector2 MouseOrbitDistance { get; } // 0x0000000180CBC8C0-0x0000000180CBC8E0 
		public Vector2 MousePitchRange { get; } // 0x0000000180CBC8E0-0x0000000180CBC900 
		public Vector2 MouseSensitivity { get; } // 0x0000000180CBC900-0x0000000180CBC920 
		public bool MouseInvertY { get; } // 0x0000000180379B20-0x0000000180379B30 
		public float MotionSmoothing { get; } // 0x0000000180379EF0-0x0000000180379F00 
		public bool UseCameraCollision { get; } // 0x0000000180455BA0-0x0000000180455BB0 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018043E010-0x000000018043E020 
	
		// Constructors
		public ThirdPersonCameraStateSettings(Vector3 targetOffset, bool mouseOrbit, Vector2 mouseOrbitDistance, Vector2 mousePitchRange, Vector2 mouseSensitivity, bool mouseInvertY, float motionSmoothing); // 0x0000000180CBC750-0x0000000180CBC8C0
	}
}
