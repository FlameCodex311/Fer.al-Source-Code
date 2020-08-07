/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cinemachine.Utility;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x00000001801DFA50-0x00000001801DFAB0
	[DocumentationSorting] // 0x00000001801DFA50-0x00000001801DFAB0
	[SaveDuringPlay] // 0x00000001801DFA50-0x00000001801DFAB0
	public class CinemachineOrbitalTransposer : CinemachineTransposer // TypeDefIndex: 7485
	{
		// Fields
		[OrbitalTransposerHeadingProperty] // 0x00000001801DFE30-0x00000001801DFE90
		[Space] // 0x00000001801DFE30-0x00000001801DFE90
		[Tooltip] // 0x00000001801DFE30-0x00000001801DFE90
		public Heading m_Heading; // 0xB8
		[Tooltip] // 0x00000001801E00A0-0x00000001801E00D0
		public AxisState.Recentering m_RecenterToTargetHeading; // 0xC4
		[AxisStateProperty] // 0x00000001801E0230-0x00000001801E0280
		[Tooltip] // 0x00000001801E0230-0x00000001801E0280
		public AxisState m_XAxis; // 0xE0
		[FormerlySerializedAs] // 0x00000001801E04B0-0x00000001801E0510
		[HideInInspector] // 0x00000001801E04B0-0x00000001801E0510
		[SerializeField] // 0x00000001801E04B0-0x00000001801E0510
		private float m_LegacyRadius; // 0x130
		[FormerlySerializedAs] // 0x00000001801E0670-0x00000001801E06D0
		[HideInInspector] // 0x00000001801E0670-0x00000001801E06D0
		[SerializeField] // 0x00000001801E0670-0x00000001801E06D0
		private float m_LegacyHeightOffset; // 0x134
		[FormerlySerializedAs] // 0x00000001801E09C0-0x00000001801E0A20
		[HideInInspector] // 0x00000001801E09C0-0x00000001801E0A20
		[SerializeField] // 0x00000001801E09C0-0x00000001801E0A20
		private float m_LegacyHeadingBias; // 0x138
		[HideInInspector] // 0x00000001801E0E00-0x00000001801E0E30
		[NoSaveDuringPlay] // 0x00000001801E0E00-0x00000001801E0E30
		public bool m_HeadingIsSlave; // 0x13C
		internal UpdateHeadingDelegate HeadingUpdater; // 0x140
		private Vector3 mLastTargetPosition; // 0x148
		private HeadingTracker mHeadingTracker; // 0x158
		private Rigidbody mTargetRigidBody; // 0x160
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Transform <PreviousTarget>k__BackingField; // 0x168
		private Quaternion mHeadingPrevFrame; // 0x170
		private Vector3 mOffsetPrevFrame; // 0x180
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float <LastHeading>k__BackingField; // 0x18C
	
		// Properties
		private Transform PreviousTarget { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x000000018058C840-0x000000018058C850 0x0000000180652BD0-0x0000000180652BE0
		private float LastHeading { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x00000001805CB390-0x00000001805CB3A0 0x000000018138F310-0x000000018138F320
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public struct Heading // TypeDefIndex: 7486
		{
			// Fields
			[FormerlySerializedAs] // 0x00000001801E2EA0-0x00000001801E2F00
			[Tooltip] // 0x00000001801E2EA0-0x00000001801E2F00
			public HeadingDefinition m_Definition; // 0x00
			[Range] // 0x00000001801E30F0-0x00000001801E3140
			[Tooltip] // 0x00000001801E30F0-0x00000001801E3140
			public int m_VelocityFilterStrength; // 0x04
			[FormerlySerializedAs] // 0x00000001801E3410-0x00000001801E3490
			[Range] // 0x00000001801E3410-0x00000001801E3490
			[Tooltip] // 0x00000001801E3410-0x00000001801E3490
			public float m_Bias; // 0x08
	
			// Nested types
			[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
			public enum HeadingDefinition // TypeDefIndex: 7487
			{
				PositionDelta = 0,
				Velocity = 1,
				TargetForward = 2,
				WorldForward = 3
			}
	
			// Constructors
			public Heading(HeadingDefinition def, int filterStrength, float bias); // 0x0000000180022490-0x00000001800224A0
		}
	
		internal delegate float UpdateHeadingDelegate(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // TypeDefIndex: 7488; 0x000000018139F740-0x000000018139FE10
	
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 7489
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static UpdateHeadingDelegate <>9__33_0; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018139F5E0-0x000000018139F640
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal float <.ctor>b__33_0(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up); // 0x000000018139F590-0x000000018139F5E0
		}
	
		// Constructors
		public CinemachineOrbitalTransposer(); // 0x000000018138EF50-0x000000018138F310
	
		// Methods
		protected override void OnValidate(); // 0x000000018138EC10-0x000000018138EDE0
		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis); // 0x000000018138EDE0-0x000000018138EF50
		private void OnEnable(); // 0x000000018138E820-0x000000018138E8A0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x000000018138E8A0-0x000000018138EAB0
		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams); // 0x000000018138EAB0-0x000000018138EC10
		public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up); // 0x000000018138D4B0-0x000000018138D8E0
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x000000018138E1A0-0x000000018138E820
		public override Vector3 GetTargetCameraPosition(Vector3 worldUp); // 0x000000018138DA40-0x000000018138DCB0
		private static string GetFullName(GameObject current); // 0x000000018138D8E0-0x000000018138DA40
		private float GetTargetHeading(float currentHeading, Quaternion targetOrientation, float deltaTime); // 0x000000018138DCB0-0x000000018138E1A0
	}
}
