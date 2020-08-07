/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x00000001801E9460-0x00000001801E94C0
	[DocumentationSorting] // 0x00000001801E9460-0x00000001801E94C0
	[SaveDuringPlay] // 0x00000001801E9460-0x00000001801E94C0
	public class CinemachineTransposer : CinemachineComponentBase // TypeDefIndex: 7495
	{
		// Fields
		[Tooltip] // 0x00000001801E96B0-0x00000001801E96E0
		public BindingMode m_BindingMode; // 0x50
		[Tooltip] // 0x00000001801E9790-0x00000001801E97C0
		public Vector3 m_FollowOffset; // 0x54
		[Range] // 0x00000001801E9AA0-0x00000001801E9AF0
		[Tooltip] // 0x00000001801E9AA0-0x00000001801E9AF0
		public float m_XDamping; // 0x60
		[Range] // 0x00000001801E9CE0-0x00000001801E9D30
		[Tooltip] // 0x00000001801E9CE0-0x00000001801E9D30
		public float m_YDamping; // 0x64
		[Range] // 0x00000001801EA000-0x00000001801EA050
		[Tooltip] // 0x00000001801EA000-0x00000001801EA050
		public float m_ZDamping; // 0x68
		public AngularDampingMode m_AngularDampingMode; // 0x6C
		[Range] // 0x00000001801EA3A0-0x00000001801EA400
		[Tooltip] // 0x00000001801EA3A0-0x00000001801EA400
		public float m_PitchDamping; // 0x70
		[Range] // 0x00000001801EA560-0x00000001801EA5B0
		[Tooltip] // 0x00000001801EA560-0x00000001801EA5B0
		public float m_YawDamping; // 0x74
		[Range] // 0x00000001801E6DA0-0x00000001801E6DF0
		[Tooltip] // 0x00000001801E6DA0-0x00000001801E6DF0
		public float m_RollDamping; // 0x78
		[Range] // 0x00000001801EA990-0x00000001801EA9F0
		[Tooltip] // 0x00000001801EA990-0x00000001801EA9F0
		public float m_AngularDamping; // 0x7C
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool <HideOffsetInInspector>k__BackingField; // 0x80
		private Vector3 m_PreviousTargetPosition; // 0x84
		private Quaternion m_PreviousReferenceOrientation; // 0x90
		private Quaternion m_targetOrientationOnAssign; // 0xA0
		private Transform m_previousTarget; // 0xB0
	
		// Properties
		public bool HideOffsetInInspector { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ set; } // 0x0000000180CCD970-0x0000000180CCD980 0x0000000180CCDB50-0x0000000180CCDB60
		public Vector3 EffectiveOffset { get; } // 0x000000018139B670-0x000000018139B700 
		public override bool IsValid { get; } // 0x000000018139B700-0x000000018139B780 
		public override CinemachineCore.Stage Stage { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		protected Vector3 Damping { get; } // 0x000000018139B630-0x000000018139B670 
		protected Vector3 AngularDamping { get; } // 0x000000018139B540-0x000000018139B630 
	
		// Nested types
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public enum BindingMode // TypeDefIndex: 7496
		{
			LockToTargetOnAssign = 0,
			LockToTargetWithWorldUp = 1,
			LockToTargetNoRoll = 2,
			LockToTarget = 3,
			WorldSpace = 4,
			SimpleFollowWithWorldUp = 5
		}
	
		public enum AngularDampingMode // TypeDefIndex: 7497
		{
			Euler = 0,
			Quaternion = 1
		}
	
		// Constructors
		public CinemachineTransposer(); // 0x000000018139B420-0x000000018139B540
	
		// Methods
		protected virtual void OnValidate(); // 0x000000018139AAE0-0x000000018139AB80
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x000000018139A750-0x000000018139A9B0
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x000000018139A9B0-0x000000018139AAE0
		protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime); // 0x000000018139A5B0-0x000000018139A750
		protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient); // 0x000000018139AB80-0x000000018139B2E0
		public virtual Vector3 GetTargetCameraPosition(Vector3 worldUp); // 0x000000018139A390-0x000000018139A5B0
		public Quaternion GetReferenceOrientation(Vector3 worldUp); // 0x0000000181399E90-0x000000018139A390
		private static Quaternion Uppify(Quaternion q, Vector3 up); // 0x000000018139B2E0-0x000000018139B420
	}
}
