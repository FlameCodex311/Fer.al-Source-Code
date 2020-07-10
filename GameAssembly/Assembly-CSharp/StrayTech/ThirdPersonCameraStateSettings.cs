/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using StrayTech.CustomAttributes;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	[Serializable]
	public class ThirdPersonCameraStateSettings : ICameraStateSettings // TypeDefIndex: 13860
	{
		// Fields
		[SerializeField] // 0x0000000180125770-0x00000001801257B0
		[Tooltip] // 0x0000000180125770-0x00000001801257B0
		private bool _mouseOrbit; // 0x10
		[SerializeField] // 0x0000000180125AF0-0x0000000180125B30
		[Tooltip] // 0x0000000180125AF0-0x0000000180125B30
		private Vector3 _targetOffset; // 0x14
		[SerializeField] // 0x0000000180126D70-0x0000000180126DB0
		[Tooltip] // 0x0000000180126D70-0x0000000180126DB0
		private Vector2 _mouseOrbitDistance; // 0x20
		[SerializeField] // 0x00000001801204A0-0x00000001801204E0
		[Tooltip] // 0x00000001801204A0-0x00000001801204E0
		private Vector2 _mousePitchRange; // 0x28
		[SerializeField] // 0x00000001801206D0-0x0000000180120710
		[Tooltip] // 0x00000001801206D0-0x0000000180120710
		private Vector2 _mouseSensitivity; // 0x30
		[SerializeField] // 0x0000000180127300-0x0000000180127340
		[Tooltip] // 0x0000000180127300-0x0000000180127340
		private bool _mouseInvertY; // 0x38
		[NonNegative] // 0x0000000180127600-0x0000000180127650
		[SerializeField] // 0x0000000180127600-0x0000000180127650
		[Tooltip] // 0x0000000180127600-0x0000000180127650
		private float _motionSmoothing; // 0x3C
		[SerializeField] // 0x0000000180122380-0x00000001801223C0
		[Tooltip] // 0x0000000180122380-0x00000001801223C0
		private bool _useCameraCollision; // 0x40
	
		// Properties
		public bool MouseOrbit { get; } // 0x0000000180375540-0x0000000180375550 
		public Vector3 TargetOffset { get; } // 0x0000000181210D80-0x0000000181210DA0 
		public Vector2 MouseOrbitDistance { get; } // 0x0000000180D26EB0-0x0000000180D26ED0 
		public Vector2 MousePitchRange { get; } // 0x0000000181210D40-0x0000000181210D60 
		public Vector2 MouseSensitivity { get; } // 0x0000000181210D60-0x0000000181210D80 
		public bool MouseInvertY { get; } // 0x00000001804AEAD0-0x00000001804AEAE0 
		public float MotionSmoothing { get; } // 0x0000000180E426C0-0x0000000180E426D0 
		public bool UseCameraCollision { get; } // 0x0000000180478660-0x0000000180478670 
		public CameraSystem.CameraStateEnum StateType { get; } // 0x000000018038FAD0-0x000000018038FAE0 
	
		// Constructors
		public ThirdPersonCameraStateSettings(Vector3 targetOffset, bool mouseOrbit, Vector2 mouseOrbitDistance, Vector2 mousePitchRange, Vector2 mouseSensitivity, bool mouseInvertY, float motionSmoothing); // 0x0000000181210BD0-0x0000000181210D40
	}
}
