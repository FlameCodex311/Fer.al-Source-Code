/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180149AA0-0x0000000180149B00
	[DocumentationSorting] // 0x0000000180149AA0-0x0000000180149B00
	[SaveDuringPlay] // 0x0000000180149AA0-0x0000000180149B00
	public class CinemachineTransposer : CinemachineComponentBase // TypeDefIndex: 7329
	{
		// Fields
		[Tooltip] // 0x0000000180149DE0-0x0000000180149E10
		public BindingMode m_BindingMode; // 0x50
		[Tooltip] // 0x0000000180149F90-0x0000000180149FC0
		public Vector3 m_FollowOffset; // 0x54
		[Range] // 0x000000018014A080-0x000000018014A0D0
		[Tooltip] // 0x000000018014A080-0x000000018014A0D0
		public float m_XDamping; // 0x60
		[Range] // 0x000000018014A390-0x000000018014A3E0
		[Tooltip] // 0x000000018014A390-0x000000018014A3E0
		public float m_YDamping; // 0x64
		[Range] // 0x000000018014A4F0-0x000000018014A540
		[Tooltip] // 0x000000018014A4F0-0x000000018014A540
		public float m_ZDamping; // 0x68
		public AngularDampingMode m_AngularDampingMode; // 0x6C
		[Range] // 0x000000018014A710-0x000000018014A770
		[Tooltip] // 0x000000018014A710-0x000000018014A770
		public float m_PitchDamping; // 0x70
		[Range] // 0x000000018014A960-0x000000018014A9B0
		[Tooltip] // 0x000000018014A960-0x000000018014A9B0
		public float m_YawDamping; // 0x74
		[Range] // 0x00000001801486B0-0x0000000180148700
		[Tooltip] // 0x00000001801486B0-0x0000000180148700
		public float m_RollDamping; // 0x78
		[Range] // 0x000000018014ACD0-0x000000018014AD30
		[Tooltip] // 0x000000018014ACD0-0x000000018014AD30
		public float m_AngularDamping; // 0x7C
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private bool <HideOffsetInInspector>k__BackingField; // 0x80
		private Vector3 m_PreviousTargetPosition; // 0x84
		private Quaternion m_PreviousReferenceOrientation; // 0x90
		private Quaternion m_targetOrientationOnAssign; // 0xA0
		private Transform m_previousTarget; // 0xB0
	
		// Properties
		public bool HideOffsetInInspector { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ set; } // 0x00000001805CC280-0x00000001805CC290 0x00000001817E1220-0x00000001817E1230
		public Vector3 EffectiveOffset { get; } // 0x00000001817E1110-0x00000001817E11A0 
		public override bool IsValid { get; } // 0x00000001817E11A0-0x00000001817E1220 
		public override CinemachineCore.Stage Stage { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		protected Vector3 Damping { get; } // 0x00000001817E10D0-0x00000001817E1110 
		protected Vector3 AngularDamping { get; } // 0x00000001817E0FE0-0x00000001817E10D0 
	
		// Nested types
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public enum BindingMode // TypeDefIndex: 7330
		{
			LockToTargetOnAssign = 0,
			LockToTargetWithWorldUp = 1,
			LockToTargetNoRoll = 2,
			LockToTarget = 3,
			WorldSpace = 4,
			SimpleFollowWithWorldUp = 5
		}
	
		public enum AngularDampingMode // TypeDefIndex: 7331
		{
			Euler = 0,
			Quaternion = 1
		}
	
		// Constructors
		public CinemachineTransposer(); // 0x00000001817E0EC0-0x00000001817E0FE0
	
		// Methods
		protected virtual void OnValidate(); // 0x00000001817E0580-0x00000001817E0620
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001817E01F0-0x00000001817E0450
		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta); // 0x00000001817E0450-0x00000001817E0580
		protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime); // 0x00000001817E0050-0x00000001817E01F0
		protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient); // 0x00000001817E0620-0x00000001817E0D80
		public virtual Vector3 GetTargetCameraPosition(Vector3 worldUp); // 0x00000001817DFE30-0x00000001817E0050
		public Quaternion GetReferenceOrientation(Vector3 worldUp); // 0x00000001817DF930-0x00000001817DFE30
		private static Quaternion Uppify(Quaternion q, Vector3 up); // 0x00000001817E0D80-0x00000001817E0EC0
	}
}
