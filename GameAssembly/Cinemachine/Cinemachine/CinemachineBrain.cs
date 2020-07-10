/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180115400-0x0000000180115480
	[DisallowMultipleComponent] // 0x0000000180115400-0x0000000180115480
	[DocumentationSorting] // 0x0000000180115400-0x0000000180115480
	[ExecuteAlways] // 0x0000000180115400-0x0000000180115480
	[SaveDuringPlay] // 0x0000000180115400-0x0000000180115480
	public class CinemachineBrain : UnityEngine.MonoBehaviour // TypeDefIndex: 7262
	{
		// Fields
		[Tooltip] // 0x0000000180115920-0x0000000180115950
		public bool m_ShowDebugText; // 0x18
		[Tooltip] // 0x0000000180115A70-0x0000000180115AA0
		public bool m_ShowCameraFrustum; // 0x19
		[Tooltip] // 0x0000000180115BE0-0x0000000180115C10
		public bool m_IgnoreTimeScale; // 0x1A
		[Tooltip] // 0x0000000180116FB0-0x0000000180116FE0
		public Transform m_WorldUpOverride; // 0x20
		[Tooltip] // 0x0000000180117260-0x0000000180117290
		public UpdateMethod m_UpdateMethod; // 0x28
		[CinemachineBlendDefinitionProperty] // 0x0000000180117430-0x0000000180117480
		[Tooltip] // 0x0000000180117430-0x0000000180117480
		public CinemachineBlendDefinition m_DefaultBlend; // 0x30
		[Tooltip] // 0x0000000180117740-0x0000000180117770
		public CinemachineBlenderSettings m_CustomBlends; // 0x40
		private Camera m_OutputCamera; // 0x48
		[Tooltip] // 0x0000000180117860-0x0000000180117890
		public BrainEvent m_CameraCutEvent; // 0x50
		[Tooltip] // 0x0000000180117B40-0x0000000180117B70
		public VcamActivatedEvent m_CameraActivatedEvent; // 0x58
		private static ICinemachineCamera mSoloCamera; // 0x00
		private Coroutine mPhysicsCoroutine; // 0x60
		private WaitForFixedUpdate mWaitForFixedUpdate; // 0x68
		private List<BrainFrame> mFrameStack; // 0x70
		private int mNextFrameId; // 0x78
		private CinemachineBlend mCurrentLiveCameras; // 0x80
		private ICinemachineCamera mActiveCameraPreviousFrame; // 0x88
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private CameraState <CurrentCameraState>k__BackingField; // 0x90
	
		// Properties
		public Camera OutputCamera { get; } // 0x00000001818AAB20-0x00000001818AABB0 
		public static ICinemachineCamera SoloCamera { get; set; } // 0x00000001818AABB0-0x00000001818AABF0 0x00000001818AAC70-0x00000001818AAD80
		public Vector3 DefaultWorldUp { get; } // 0x00000001818AAA10-0x00000001818AAB00 
		public ICinemachineCamera ActiveVirtualCamera { get; } // 0x00000001818AA830-0x00000001818AA980 
		public bool IsBlending { get; } // 0x00000001818AAB00-0x00000001818AAB20 
		public CinemachineBlend ActiveBlend { get; } // 0x00000001818AA7A0-0x00000001818AA830 
		public CameraState CurrentCameraState { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001818AA980-0x00000001818AAA10 0x00000001818AABF0-0x00000001818AAC70
	
		// Nested types
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public enum UpdateMethod // TypeDefIndex: 7263
		{
			FixedUpdate = 0,
			LateUpdate = 1,
			SmartUpdate = 2
		}
	
		[Serializable]
		public class BrainEvent : UnityEvent<CinemachineBrain> // TypeDefIndex: 7264
		{
			// Constructors
			public BrainEvent(); // 0x00000001818A21B0-0x00000001818A21F0
		}
	
		[Serializable]
		public class VcamActivatedEvent : UnityEvent<ICinemachineCamera, ICinemachineCamera> // TypeDefIndex: 7265
		{
			// Constructors
			public VcamActivatedEvent(); // 0x00000001818C3860-0x00000001818C38A0
		}
	
		private class BrainFrame // TypeDefIndex: 7266
		{
			// Fields
			public int id; // 0x10
			public CinemachineBlend blend; // 0x18
			public CinemachineBlend workingBlend; // 0x20
			public BlendSourceVirtualCamera workingBlendSource; // 0x28
			public float deltaTimeOverride; // 0x30
			public float timeOfOverride; // 0x34
	
			// Properties
			public bool Active { get; } // 0x00000001818A22C0-0x00000001818A22E0 
			public bool TimeOverrideExpired { get; } // 0x00000001818A22E0-0x00000001818A2490 
	
			// Constructors
			public BrainFrame(); // 0x00000001818A21F0-0x00000001818A22C0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <AfterPhysics>d__28 : IEnumerator<object> // TypeDefIndex: 7267
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CinemachineBrain <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <AfterPhysics>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001818C3660-0x00000001818C3760
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001818C3760-0x00000001818C37B0
		}
	
		// Constructors
		public CinemachineBrain(); // 0x00000001818AA630-0x00000001818AA7A0
	
		// Methods
		public static Color GetSoloGUIColor(); // 0x00000001818A7D50-0x00000001818A7DC0
		private void OnEnable(); // 0x00000001818A8510-0x00000001818A87C0
		private void OnDisable(); // 0x00000001818A83B0-0x00000001818A8510
		private void Start(); // 0x00000001818A94A0-0x00000001818A94C0
		private void OnGuiHandler(); // 0x00000001818A87C0-0x00000001818A8B20
		[IteratorStateMachine] // 0x0000000180117DE0-0x0000000180117E30
		private IEnumerator AfterPhysics(); // 0x00000001818A7950-0x00000001818A79B0
		private void LateUpdate(); // 0x00000001818A7FD0-0x00000001818A81D0
		private float GetEffectiveDeltaTime(bool fixedDelta); // 0x00000001818A7BC0-0x00000001818A7D50
		private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime); // 0x00000001818AA3A0-0x00000001818AA630
		private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend); // 0x00000001818A79B0-0x00000001818A7A80
		private int GetBrainFrame(int withId); // 0x00000001818A7A80-0x00000001818A7BC0
		internal int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime); // 0x00000001818A9230-0x00000001818A94A0
		internal void ReleaseCameraOverride(int overrideId); // 0x00000001818A9140-0x00000001818A9230
		private void ProcessActiveCamera(float deltaTime); // 0x00000001818A8B20-0x00000001818A8E50
		private void UpdateFrame0(float deltaTime); // 0x00000001818A9CE0-0x00000001818AA3A0
		private void UpdateCurrentLiveCameras(); // 0x00000001818A9710-0x00000001818A9CE0
		public bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x007417AB */); // 0x00000001818A7DC0-0x00000001818A7FD0
		private ICinemachineCamera TopCameraFromPriorityQueue(); // 0x00000001818A94C0-0x00000001818A9710
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey); // 0x00000001818A81D0-0x00000001818A83B0
		private void PushStateToUnityCamera(CameraState state); // 0x00000001818A8E50-0x00000001818A9140
	}
}
