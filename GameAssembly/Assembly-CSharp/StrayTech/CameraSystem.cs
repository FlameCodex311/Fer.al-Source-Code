/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	[RenderHierarchyIcon] // 0x000000018025CCE0-0x000000018025CD10
	public class CameraSystem : MonoBehaviourSingleton<StrayTech.CameraSystem> // TypeDefIndex: 14548
	{
		// Fields
		[SerializeField] // 0x000000018025CF00-0x000000018025CF40
		[Tooltip] // 0x000000018025CF00-0x000000018025CF40
		private Transform _cameraTarget; // 0x20
		[SerializeField] // 0x000000018025D120-0x000000018025D160
		[Tooltip] // 0x000000018025D120-0x000000018025D160
		private CameraStateDefinition _defaultCameraState; // 0x28
		[SerializeField] // 0x000000018025D3E0-0x000000018025D420
		[Tooltip] // 0x000000018025D3E0-0x000000018025D420
		private bool _useFixedUpdate; // 0x30
		[SerializeField] // 0x000000018025D540-0x000000018025D580
		[Tooltip] // 0x000000018025D540-0x000000018025D580
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
		public CameraSystemStatus SystemStatus { get; } // 0x0000000180379F10-0x0000000180379F20 
		public CameraStateDefinition CurrentCameraStateDefinition { get; } // 0x0000000180476CE0-0x0000000180476CF0 
		public CameraStateDefinition NextCameraStateDefinition { get; } // 0x00000001803D6D80-0x00000001803D6D90 
		public StateTransitionTypeInternal CurrentTransitionType { get; } // 0x00000001804C5F20-0x00000001804C5F30 
		public Camera CurrentCamera { get; } // 0x0000000180378320-0x0000000180378330 
		public Camera NextCamera { get; } // 0x00000001803A1580-0x00000001803A1590 
		public AnimationCurve CameraInterpolationCurve { get; } // 0x000000018037DDD0-0x000000018037DDE0 
		public float CurrentInterpolationCurveSample { get; } // 0x0000000180CAE2F0-0x0000000180CAE380 
		public RenderTexture CameraRenderTexture { get; } // 0x000000018067DD20-0x000000018067DD30 
		public List<CameraStateModifierBase> CameraStateModifiers { get; } // 0x0000000180431310-0x0000000180431320 
		public float CameraTargetVelocity { get; } // 0x00000001804405C0-0x00000001804405D0 
		public bool ShouldUpdate { get; set; } // 0x00000001804AF410-0x00000001804AF420 0x00000001804AF530-0x00000001804AF540
		public Transform CameraTarget { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
	
		// Nested types
		public enum CameraStateEnum // TypeDefIndex: 14549
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
	
		public enum StateTransitionType // TypeDefIndex: 14550
		{
			Interpolation = 0,
			Crossfade = 1,
			Instant = 2
		}
	
		public enum StateTransitionTypeInternal // TypeDefIndex: 14551
		{
			Interpolation = 0,
			Crossfade = 1,
			Instant = 2,
			InterpolatedCrossfade = 3
		}
	
		public enum CameraSystemStatus // TypeDefIndex: 14552
		{
			Active = 0,
			Transitioning = 1,
			Inactive = 2
		}
	
		[Serializable]
		public class UserDefinedFlag // TypeDefIndex: 14553
		{
			// Fields
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private string _name; // 0x10
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private bool _value; // 0x18
	
			// Properties
			public string Name { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
			public bool Value { get; set; } // 0x00000001803F6D30-0x00000001803F6D40 0x00000001803F6D40-0x00000001803F6D50
	
			// Constructors
			public UserDefinedFlag(); // 0x0000000180373240-0x0000000180373250
		}
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 14554
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Func<CameraStateModifierBase, int> <>9__78_0; // 0x08
	
			// Constructors
			static <>c(); // 0x0000000180CBE170-0x0000000180CBE1D0
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal int <AddModifier>b__78_0(CameraStateModifierBase m); // 0x0000000180CBE150-0x0000000180CBE170
		}
	
		// Constructors
		public CameraSystem(); // 0x0000000180CAE180-0x0000000180CAE2F0
	
		// Methods
		protected override void Awake(); // 0x0000000180CAAE70-0x0000000180CAAFF0
		private void LateUpdate(); // 0x0000000180CAD670-0x0000000180CAD6B0
		private void FixedUpdate(); // 0x0000000180CABB70-0x0000000180CABBA0
		private void DoCameraUpdate(float deltaTime); // 0x0000000180CAB1A0-0x0000000180CAB770
		private void OnLateUpdate(); // 0x0000000180CADB00-0x0000000180CADE00
		public void OnEnable(); // 0x0000000180CADA90-0x0000000180CADB00
		public void OnDisable(); // 0x0000000180CADA20-0x0000000180CADA90
		public void SetCameraStateTempOverride(CameraStateDefinition newState); // 0x0000000180CADFB0-0x0000000180CADFD0
		public void RegisterCameraState(CameraStateDefinition newState); // 0x0000000180CADE00-0x0000000180CADF30
		public void UnregisterCameraState(CameraStateDefinition oldState); // 0x0000000180CAE100-0x0000000180CAE180
		private void ManageQueuedTransitions(); // 0x0000000180CAD6B0-0x0000000180CADA20
		private void ActivateTransition(CameraStateDefinition toState, CameraStateDefinition transitionHost); // 0x0000000180CAA7A0-0x0000000180CAAC40
		private void HandleInstantTransition(); // 0x0000000180CAC410-0x0000000180CAC420
		private void HandleInterpolationTransition(); // 0x0000000180CACDA0-0x0000000180CAD670
		private void HandleCrossfadeTransition(); // 0x0000000180CABC10-0x0000000180CAC410
		private void HandleInterpolatedCrossfadeTransition(); // 0x0000000180CAC420-0x0000000180CACDA0
		private void FinalizeTransition(); // 0x0000000180CAB770-0x0000000180CABB70
		public void AddModifier(CameraStateModifierBase modifier); // 0x0000000180CAAC40-0x0000000180CAAE70
		public void RemoveModifier(CameraStateModifierBase modifier); // 0x0000000180CADF30-0x0000000180CADFB0
		public void ChangeCameraFOV(float fov); // 0x0000000180CAB180-0x0000000180CAB1A0
		public void ChangeCameraClipping(Vector2 inClipping); // 0x0000000180CAB130-0x0000000180CAB180
		private void CacheUserDefinedFlags(); // 0x0000000180CAAFF0-0x0000000180CAB130
		public bool GetUserDefinedFlagValue(string flagName); // 0x0000000180CABBA0-0x0000000180CABC10
		public void SetUserDefinedFlagValue(string flagName, bool flagValue); // 0x0000000180CADFD0-0x0000000180CAE100
	}
}
