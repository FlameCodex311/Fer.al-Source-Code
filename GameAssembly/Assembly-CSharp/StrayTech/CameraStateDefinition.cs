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
	[RenderHierarchyIcon] // 0x0000000180127B90-0x0000000180127BC0
	public class CameraStateDefinition : MonoBehaviour // TypeDefIndex: 13862
	{
		// Fields
		[SerializeField] // 0x0000000180127D70-0x0000000180127DB0
		[Tooltip] // 0x0000000180127D70-0x0000000180127DB0
		private CameraSystem.CameraStateEnum _cameraState; // 0x20
		[SerializeField] // 0x0000000180127FC0-0x0000000180128000
		[Tooltip] // 0x0000000180127FC0-0x0000000180128000
		private CameraSystem.StateTransitionType _transitionType; // 0x24
		[SerializeField] // 0x0000000180128150-0x0000000180128190
		[Tooltip] // 0x0000000180128150-0x0000000180128190
		private float _transitionDuration; // 0x28
		[SerializeField] // 0x0000000180128240-0x0000000180128280
		[Tooltip] // 0x0000000180128240-0x0000000180128280
		private Camera _camera; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private FirstPersonCameraStateSettings _firstPersonStateSettings; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private IsometricCameraStateSettings _isometricStateSettings; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private SplineCameraStateSettings _splineStateSettings; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ThirdPersonCameraStateSettings _thirdPersonStateSettings; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private FeralCameraStateSettings _feralStateSettings; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private AnimatedCameraStateSettings _animatedCameraStateSettings; // 0x60
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private PivotCameraStateSettings _pivotCameraStateSettings; // 0x68
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ParentedCameraStateSettings _parentedCameraStateSettings; // 0x70
		private ICameraState _state; // 0x78
	
		// Properties
		public ICameraState State { get; } // 0x0000000180369C70-0x0000000180369C80 
		public CameraSystem.StateTransitionType TransitionType { get; } // 0x00000001803C26F0-0x00000001803C2700 
		public float TransitionDuration { get; } // 0x0000000180487D50-0x0000000180487D60 
		public Camera Camera { get; } // 0x0000000180397720-0x0000000180397730 
	
		// Constructors
		public CameraStateDefinition(); // 0x000000018118BAD0-0x000000018118BAE0
	
		// Methods
		private void Start(); // 0x000000018134A3D0-0x000000018134A470
		public void InitializeState(); // 0x0000000181349FF0-0x000000018134A3D0
		public void AddCameraStateTriggerChild(); // 0x0000000181349CC0-0x0000000181349FF0
		public void AddCameraSplineChild(); // 0x0000000181349A60-0x0000000181349CC0
	}
}
