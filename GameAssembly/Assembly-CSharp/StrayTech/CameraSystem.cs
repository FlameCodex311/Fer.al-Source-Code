/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	[RenderHierarchyIcon] // 0x00000001801325C0-0x00000001801325F0
	public class CameraSystem : MonoBehaviourSingleton<StrayTech.CameraSystem> // TypeDefIndex: 13881
	{
		// Fields
		[SerializeField] // 0x0000000180132730-0x0000000180132770
		[Tooltip] // 0x0000000180132730-0x0000000180132770
		private Transform _cameraTarget; // 0x20
		[SerializeField] // 0x0000000180132A90-0x0000000180132AD0
		[Tooltip] // 0x0000000180132A90-0x0000000180132AD0
		private CameraStateDefinition _defaultCameraState; // 0x28
		[SerializeField] // 0x0000000180132D80-0x0000000180132DC0
		[Tooltip] // 0x0000000180132D80-0x0000000180132DC0
		private bool _useFixedUpdate; // 0x30
		[SerializeField] // 0x0000000180133040-0x0000000180133080
		[Tooltip] // 0x0000000180133040-0x0000000180133080
		private List<UserDefinedFlag> _userDefinedFlags; // 0x38
		private CameraSystemStatus _systemStatus; // 0x40
		private Camera _defaultCamera; // 0x48
		private Camera _currentCamera; // 0x50
		private Camera _nextCamera; // 0x58
		private float _stateTransitionRamp; // 0x60
		private StateTransitionTypeInternal _currentTransitionType; // 0x64
		private LinkedList<CameraStateDefinition> _stateDefinitionHistory; // 0x68
		private Queue<CameraStateDefinition> _stateDefinitionsToAdd; // 0x70
		private Queue<CameraStateDefinition> _stateDefinitionsToRemove; // 0x78
		private CameraStateDefinition _cameraStateOverride; // 0x80
		private CameraStateDefinition _currentCameraStateDefinition; // 0x88
		private CameraStateDefinition _nextCameraStateDefinition; // 0x90
		private CameraStateDefinition _currentTransitionHost; // 0x98
		private bool _transitionInteruptTransition; // 0xA0
		private List<CameraStateModifierBase> _cameraModifiers; // 0xA8
		private RenderTexture _cameraRenderTexture; // 0xB0
		private CrossfadePostProcess _crossfadePostProcess; // 0xB8
		private bool _shouldUpdate; // 0xC0
		private Vector3 _cachedCameraPosition; // 0xC4
		private Quaternion _cachedCameraRotation; // 0xD0
		private Dictionary<string, bool> _userDefinedFlagsLookup; // 0xE0
		private AnimationCurve _cameraInterpolationCurve; // 0xE8
		private float _cameraTargetVelocity; // 0xF0
		private Vector3 _cameraTargetLastPosition; // 0xF4
	
		// Properties
		public CameraSystemStatus SystemStatus { get; } // 0x000000018047AB20-0x000000018047AB30 
		public CameraStateDefinition CurrentCameraStateDefinition { get; } // 0x0000000180424200-0x0000000180424210 
		public CameraStateDefinition NextCameraStateDefinition { get; } // 0x0000000180382A80-0x0000000180382A90 
		public StateTransitionTypeInternal CurrentTransitionType { get; } // 0x00000001804D0650-0x00000001804D0660 
		public Camera CurrentCamera { get; } // 0x00000001803A27A0-0x00000001803A27B0 
		public Camera NextCamera { get; } // 0x0000000180357120-0x0000000180357130 
		public AnimationCurve CameraInterpolationCurve { get; } // 0x000000018037A250-0x000000018037A260 
		public float CurrentInterpolationCurveSample { get; } // 0x000000018134F750-0x000000018134F7E0 
		public RenderTexture CameraRenderTexture { get; } // 0x00000001803ED9D0-0x00000001803ED9E0 
		public List<CameraStateModifierBase> CameraStateModifiers { get; } // 0x0000000180382A90-0x0000000180382AA0 
		public float CameraTargetVelocity { get; } // 0x0000000180F70FD0-0x0000000180F70FE0 
		public bool ShouldUpdate { get; set; } // 0x0000000180FCDFC0-0x0000000180FCDFD0 0x0000000180FCE0C0-0x0000000180FCE0D0
		public Transform CameraTarget { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
	
		// Nested types
		public enum CameraStateEnum // TypeDefIndex: 13882
		{
			Isometric = 0,
			Spline = 1,
			FirstPerson = 2,
			ThirdPerson = 3,
			Animated = 4,
			Pivot = 5,
			Parented = 6,
			Feral = 7
		}
	
		public enum StateTransitionType // TypeDefIndex: 13883
		{
			Interpolation = 0,
			Crossfade = 1,
			Instant = 2
		}
	
		public enum StateTransitionTypeInternal // TypeDefIndex: 13884
		{
			Interpolation = 0,
			Crossfade = 1,
			Instant = 2,
			InterpolatedCrossfade = 3
		}
	
		public enum CameraSystemStatus // TypeDefIndex: 13885
		{
			Active = 0,
			Transitioning = 1,
			Inactive = 2
		}
	
		[Serializable]
		public class UserDefinedFlag // TypeDefIndex: 13886
		{
			// Fields
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private string _name; // 0x10
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private bool _value; // 0x18
	
			// Properties
			public string Name { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
			public bool Value { get; set; } // 0x000000018041BAC0-0x000000018041BAD0 0x000000018048F590-0x000000018048F5A0
	
			// Constructors
			public UserDefinedFlag(); // 0x000000018036B6C0-0x000000018036B6D0
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 13887
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<CameraStateModifierBase, int> <>9__78_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000181360A30-0x0000000181360A90
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal int <AddModifier>b__78_0(CameraStateModifierBase m); // 0x0000000181360420-0x0000000181360440
		}
	
		// Constructors
		public CameraSystem(); // 0x000000018134F5E0-0x000000018134F750
	
		// Methods
		protected override void Awake(); // 0x000000018134C1F0-0x000000018134C370
		private void LateUpdate(); // 0x000000018134EAC0-0x000000018134EB00
		private void FixedUpdate(); // 0x000000018134CF40-0x000000018134CF70
		private void DoCameraUpdate(float deltaTime); // 0x000000018134C530-0x000000018134CB30
		private void OnLateUpdate(); // 0x000000018134EF60-0x000000018134F260
		public void OnEnable(); // 0x000000018134EEF0-0x000000018134EF60
		public void OnDisable(); // 0x000000018134EE80-0x000000018134EEF0
		public void SetCameraStateTempOverride(CameraStateDefinition newState); // 0x000000018134F410-0x000000018134F430
		public void RegisterCameraState(CameraStateDefinition newState); // 0x000000018134F260-0x000000018134F390
		public void UnregisterCameraState(CameraStateDefinition oldState); // 0x000000018134F560-0x000000018134F5E0
		private void ManageQueuedTransitions(); // 0x000000018134EB00-0x000000018134EE80
		private void ActivateTransition(CameraStateDefinition toState, CameraStateDefinition transitionHost); // 0x000000018134BB10-0x000000018134BFC0
		private void HandleInstantTransition(); // 0x000000018134D810-0x000000018134D820
		private void HandleInterpolationTransition(); // 0x000000018134E1D0-0x000000018134EAC0
		private void HandleCrossfadeTransition(); // 0x000000018134CFE0-0x000000018134D810
		private void HandleInterpolatedCrossfadeTransition(); // 0x000000018134D820-0x000000018134E1D0
		private void FinalizeTransition(); // 0x000000018134CB30-0x000000018134CF40
		public void AddModifier(CameraStateModifierBase modifier); // 0x000000018134BFC0-0x000000018134C1F0
		public void RemoveModifier(CameraStateModifierBase modifier); // 0x000000018134F390-0x000000018134F410
		public void ChangeCameraFOV(float fov); // 0x000000018134C510-0x000000018134C530
		public void ChangeCameraClipping(Vector2 inClipping); // 0x000000018134C4C0-0x000000018134C510
		private void CacheUserDefinedFlags(); // 0x000000018134C370-0x000000018134C4C0
		public bool GetUserDefinedFlagValue(string flagName); // 0x000000018134CF70-0x000000018134CFE0
		public void SetUserDefinedFlagValue(string flagName, bool flagValue); // 0x000000018134F430-0x000000018134F560
	}
}
