/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine.Utility;
using UnityEngine;
using UnityEngine.Serialization;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180140DF0-0x0000000180140E50
	[DocumentationSorting] // 0x0000000180140DF0-0x0000000180140E50
	[SaveDuringPlay] // 0x0000000180140DF0-0x0000000180140E50
	public class CinemachineOrbitalTransposer : CinemachineTransposer // TypeDefIndex: 7319
	{
		// Fields
		[OrbitalTransposerHeadingProperty] // 0x0000000180141020-0x0000000180141080
		[Space] // 0x0000000180141020-0x0000000180141080
		[Tooltip] // 0x0000000180141020-0x0000000180141080
		public Heading m_Heading; // 0xB8
		[Tooltip] // 0x0000000180142550-0x0000000180142580
		public AxisState.Recentering m_RecenterToTargetHeading; // 0xC4
		[AxisStateProperty] // 0x00000001801427A0-0x00000001801427F0
		[Tooltip] // 0x00000001801427A0-0x00000001801427F0
		public AxisState m_XAxis; // 0xE0
		[FormerlySerializedAs] // 0x0000000180142980-0x00000001801429E0
		[HideInInspector] // 0x0000000180142980-0x00000001801429E0
		[SerializeField] // 0x0000000180142980-0x00000001801429E0
		private float m_LegacyRadius; // 0x130
		[FormerlySerializedAs] // 0x0000000180142FB0-0x0000000180143010
		[HideInInspector] // 0x0000000180142FB0-0x0000000180143010
		[SerializeField] // 0x0000000180142FB0-0x0000000180143010
		private float m_LegacyHeightOffset; // 0x134
		[FormerlySerializedAs] // 0x0000000180143200-0x0000000180143260
		[HideInInspector] // 0x0000000180143200-0x0000000180143260
		[SerializeField] // 0x0000000180143200-0x0000000180143260
		private float m_LegacyHeadingBias; // 0x138
		[HideInInspector] // 0x00000001800CF4E0-0x00000001800CF510
		[NoSaveDuringPlay] // 0x00000001800CF4E0-0x00000001800CF510
		public bool m_HeadingIsSlave; // 0x13C
		internal UpdateHeadingDelegate HeadingUpdater; // 0x140
		private Vector3 mLastTargetPosition; // 0x148
		private HeadingTracker mHeadingTracker; // 0x158
		private Rigidbody mTargetRigidBody; // 0x160
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Transform <PreviousTarget>k__BackingField; // 0x168
		private Quaternion mHeadingPrevFrame; // 0x170
		private Vector3 mOffsetPrevFrame; // 0x180
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private float <LastHeading>k__BackingField; // 0x18C
	
		// Properties
		private Transform PreviousTarget { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001810E2310-0x00000001810E2320 0x00000001817D35D0-0x00000001817D35E0
		private float LastHeading { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001811C66A0-0x00000001811C66B0 0x00000001817D35C0-0x00000001817D35D0
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public struct Heading // TypeDefIndex: 7320
		{
			// Fields
			[FormerlySerializedAs] // 0x0000000180143F80-0x0000000180143FE0
			[Tooltip] // 0x0000000180143F80-0x0000000180143FE0
			public HeadingDefinition m_Definition; // 0x00
			[Range] // 0x00000001801454A0-0x00000001801454F0
			[Tooltip] // 0x00000001801454A0-0x00000001801454F0
			public int m_VelocityFilterStrength; // 0x04
			[FormerlySerializedAs] // 0x0000000180145650-0x00000001801456D0
			[Range] // 0x0000000180145650-0x00000001801456D0
			[Tooltip] // 0x0000000180145650-0x00000001801456D0
			public float m_Bias; // 0x08
	
			// Nested types
			[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
			public enum HeadingDefinition // TypeDefIndex: 7321
			{
				PositionDelta = 0,
				Velocity = 1,
				TargetForward = 2,
				WorldForward = 3
			}
	
			// Constructors
			public Heading(HeadingDefinition def, int filterStrength, float bias); // 0x0000000180006720-0x0000000180006730
		}
	
		internal delegate float UpdateHeadingDelegate(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // TypeDefIndex: 7322; 0x00000001817E9520-0x00000001817E9B10
	
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 7323
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static UpdateHeadingDelegate <>9__33_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001817E93C0-0x00000001817E9420
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal float <.ctor>b__33_0(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // 0x00000001817E9230-0x00000001817E93C0
		}
	
		// Constructors
		public CinemachineOrbitalTransposer(); // 0x00000001817D3200-0x00000001817D35C0
	
		// Methods
		protected override void OnValidate(); // 0x00000001817D2EC0-0x00000001817D3090
		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis); // 0x00000001817D3090-0x00000001817D3200
		private void OnEnable(); // 0x00000001817D2AD0-0x00000001817D2B50
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001817D2B50-0x00000001817D2D60
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams); // 0x00000001817D2D60-0x00000001817D2EC0
		public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up); // 0x00000001817D1450-0x00000001817D1880
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001817D2450-0x00000001817D2AD0
		public override Vector3 GetTargetCameraPosition(Vector3 worldUp); // 0x00000001817D19F0-0x00000001817D1C60
		private static string GetFullName(GameObject current); // 0x00000001817D1880-0x00000001817D19F0
		private float GetTargetHeading(float currentHeading, Quaternion targetOrientation, float deltaTime); // 0x00000001817D1C60-0x00000001817D2450
	}
}
