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
	[RenderHierarchyIcon] // 0x0000000180252280-0x00000001802522B0
	public class CameraStateDefinition : MonoBehaviour // TypeDefIndex: 14529
	{
		// Fields
		[SerializeField] // 0x0000000180252680-0x00000001802526C0
		[Tooltip] // 0x0000000180252680-0x00000001802526C0
		private CameraSystem.CameraStateEnum _cameraState; // 0x20
		[SerializeField] // 0x0000000180252910-0x0000000180252950
		[Tooltip] // 0x0000000180252910-0x0000000180252950
		private CameraSystem.StateTransitionType _transitionType; // 0x24
		[SerializeField] // 0x0000000180252CB0-0x0000000180252CF0
		[Tooltip] // 0x0000000180252CB0-0x0000000180252CF0
		private float _transitionDuration; // 0x28
		[SerializeField] // 0x0000000180252FF0-0x0000000180253030
		[Tooltip] // 0x0000000180252FF0-0x0000000180253030
		private Camera _camera; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private FirstPersonCameraStateSettings _firstPersonStateSettings; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private IsometricCameraStateSettings _isometricStateSettings; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SplineCameraStateSettings _splineStateSettings; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ThirdPersonCameraStateSettings _thirdPersonStateSettings; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private FeralCameraStateSettings _feralStateSettings; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private AnimatedCameraStateSettings _animatedCameraStateSettings; // 0x60
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private PivotCameraStateSettings _pivotCameraStateSettings; // 0x68
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ParentedCameraStateSettings _parentedCameraStateSettings; // 0x70
		private ICameraState _state; // 0x78
	
		// Properties
		public ICameraState State { get; } // 0x0000000180418A40-0x0000000180418A50 
		public CameraSystem.StateTransitionType TransitionType { get; } // 0x0000000180491DB0-0x0000000180491DC0 
		public float TransitionDuration { get; } // 0x0000000180491DA0-0x0000000180491DB0 
		public Camera Camera { get; } // 0x00000001803745C0-0x00000001803745D0 
	
		// Constructors
		public CameraStateDefinition(); // 0x0000000180858780-0x0000000180858790
	
		// Methods
		private void Start(); // 0x0000000180CA8D10-0x0000000180CA8DB0
		public void InitializeState(); // 0x0000000180CA86E0-0x0000000180CA8D10
		public void AddCameraStateTriggerChild(); // 0x0000000180CA83D0-0x0000000180CA86E0
		public void AddCameraSplineChild(); // 0x0000000180CA8180-0x0000000180CA83D0
	}
}
