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

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180280130-0x00000001802801B0
	[DisallowMultipleComponent] // 0x0000000180280130-0x00000001802801B0
	[DocumentationSorting] // 0x0000000180280130-0x00000001802801B0
	[ExecuteAlways] // 0x0000000180280130-0x00000001802801B0
	[SaveDuringPlay] // 0x0000000180280130-0x00000001802801B0
	public class CinemachineBrain : UnityEngine.MonoBehaviour // TypeDefIndex: 7428
	{
		// Fields
		[Tooltip] // 0x00000001802804D0-0x0000000180280500
		public bool m_ShowDebugText; // 0x18
		[Tooltip] // 0x0000000180280610-0x0000000180280640
		public bool m_ShowCameraFrustum; // 0x19
		[Tooltip] // 0x0000000180280700-0x0000000180280730
		public bool m_IgnoreTimeScale; // 0x1A
		[Tooltip] // 0x00000001802808D0-0x0000000180280900
		public Transform m_WorldUpOverride; // 0x20
		[Tooltip] // 0x0000000180280AE0-0x0000000180280B10
		public UpdateMethod m_UpdateMethod; // 0x28
		[CinemachineBlendDefinitionProperty] // 0x0000000180280BE0-0x0000000180280C30
		[Tooltip] // 0x0000000180280BE0-0x0000000180280C30
		public CinemachineBlendDefinition m_DefaultBlend; // 0x30
		[Tooltip] // 0x0000000180280DD0-0x0000000180280E00
		public CinemachineBlenderSettings m_CustomBlends; // 0x40
		private Camera m_OutputCamera; // 0x48
		[Tooltip] // 0x0000000180280E30-0x0000000180280E60
		public BrainEvent m_CameraCutEvent; // 0x50
		[Tooltip] // 0x0000000180280F30-0x0000000180280F60
		public VcamActivatedEvent m_CameraActivatedEvent; // 0x58
		private static ICinemachineCamera mSoloCamera; // 0x00
		private Coroutine mPhysicsCoroutine; // 0x60
		private WaitForFixedUpdate mWaitForFixedUpdate; // 0x68
		private List<BrainFrame> mFrameStack; // 0x70
		private int mNextFrameId; // 0x78
		private CinemachineBlend mCurrentLiveCameras; // 0x80
		private ICinemachineCamera mActiveCameraPreviousFrame; // 0x88
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CameraState <CurrentCameraState>k__BackingField; // 0x90
	
		// Properties
		public Camera OutputCamera { get; } // 0x0000000181350ED0-0x0000000181350F60 
		public static ICinemachineCamera SoloCamera { get; set; } // 0x0000000181350F60-0x0000000181350FA0 0x0000000181351020-0x0000000181351130
		public Vector3 DefaultWorldUp { get; } // 0x0000000181350DC0-0x0000000181350EB0 
		public ICinemachineCamera ActiveVirtualCamera { get; } // 0x0000000181350BE0-0x0000000181350D30 
		public bool IsBlending { get; } // 0x0000000181350EB0-0x0000000181350ED0 
		public CinemachineBlend ActiveBlend { get; } // 0x0000000181350B50-0x0000000181350BE0 
		public CameraState CurrentCameraState { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000181350D30-0x0000000181350DC0 0x0000000181350FA0-0x0000000181351020
	
		// Nested types
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public enum UpdateMethod // TypeDefIndex: 7429
		{
			FixedUpdate = 0,
			LateUpdate = 1,
			SmartUpdate = 2
		}
	
		[Serializable]
		public class BrainEvent : UnityEvent<CinemachineBrain> // TypeDefIndex: 7430
		{
			// Constructors
			public BrainEvent(); // 0x0000000181348700-0x0000000181348740
		}
	
		[Serializable]
		public class VcamActivatedEvent : UnityEvent<ICinemachineCamera, ICinemachineCamera> // TypeDefIndex: 7431
		{
			// Constructors
			public VcamActivatedEvent(); // 0x0000000181364BB0-0x0000000181364BF0
		}
	
		private class BrainFrame // TypeDefIndex: 7432
		{
			// Fields
			public int id; // 0x10
			public CinemachineBlend blend; // 0x18
			public CinemachineBlend workingBlend; // 0x20
			public BlendSourceVirtualCamera workingBlendSource; // 0x28
			public float deltaTimeOverride; // 0x30
			public float timeOfOverride; // 0x34
	
			// Properties
			public bool Active { get; } // 0x0000000181348810-0x0000000181348830 
			public bool TimeOverrideExpired { get; } // 0x0000000181348830-0x00000001813489E0 
	
			// Constructors
			public BrainFrame(); // 0x0000000181348740-0x0000000181348810
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <AfterPhysics>d__28 : IEnumerator<object> // TypeDefIndex: 7433
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public CinemachineBrain <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <AfterPhysics>d__28(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001813649C0-0x0000000181364AB0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000181364AB0-0x0000000181364B00
		}
	
		// Constructors
		public CinemachineBrain(); // 0x00000001813509E0-0x0000000181350B50
	
		// Methods
		public static Color GetSoloGUIColor(); // 0x000000018134E1F0-0x000000018134E260
		private void OnEnable(); // 0x000000018134E9A0-0x000000018134EC50
		private void OnDisable(); // 0x000000018134E840-0x000000018134E9A0
		private void Start(); // 0x000000018134F8E0-0x000000018134F900
		private void OnGuiHandler(); // 0x000000018134EC50-0x000000018134EFA0
		[IteratorStateMachine] // 0x00000001802812F0-0x0000000180281340
		private IEnumerator AfterPhysics(); // 0x000000018134DE00-0x000000018134DE60
		private void LateUpdate(); // 0x000000018134E470-0x000000018134E660
		private float GetEffectiveDeltaTime(bool fixedDelta); // 0x000000018134E060-0x000000018134E1F0
		private void UpdateVirtualCameras(CinemachineCore.UpdateFilter updateFilter, float deltaTime); // 0x0000000181350760-0x00000001813509E0
		private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend); // 0x000000018134DE60-0x000000018134DF30
		private int GetBrainFrame(int withId); // 0x000000018134DF30-0x000000018134E060
		internal int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime); // 0x000000018134F680-0x000000018134F8E0
		internal void ReleaseCameraOverride(int overrideId); // 0x000000018134F5A0-0x000000018134F680
		private void ProcessActiveCamera(float deltaTime); // 0x000000018134EFA0-0x000000018134F2C0
		private void UpdateFrame0(float deltaTime); // 0x00000001813500D0-0x0000000181350760
		private void UpdateCurrentLiveCameras(); // 0x000000018134FB40-0x00000001813500D0
		public bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = false /* Metadata: 0x00776499 */); // 0x000000018134E260-0x000000018134E470
		private ICinemachineCamera TopCameraFromPriorityQueue(); // 0x000000018134F900-0x000000018134FB40
		private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey); // 0x000000018134E660-0x000000018134E840
		private void PushStateToUnityCamera(CameraState state); // 0x000000018134F2C0-0x000000018134F5A0
	}
}
