/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine
{
	[AddComponentMenu] // 0x0000000180140960-0x00000001801409C0
	[DocumentationSorting] // 0x0000000180140960-0x00000001801409C0
	[SaveDuringPlay] // 0x0000000180140960-0x00000001801409C0
	public class CinemachineTrackedDolly : CinemachineComponentBase // TypeDefIndex: 7326
	{
		// Fields
		[Tooltip] // 0x0000000180146C40-0x0000000180146C70
		public CinemachinePathBase m_Path; // 0x50
		[Tooltip] // 0x0000000180146E40-0x0000000180146E70
		public float m_PathPosition; // 0x58
		[Tooltip] // 0x0000000180146FF0-0x0000000180147020
		public CinemachinePathBase.PositionUnits m_PositionUnits; // 0x5C
		[Tooltip] // 0x00000001801471B0-0x00000001801471E0
		public Vector3 m_PathOffset; // 0x60
		[Range] // 0x0000000180147430-0x0000000180147480
		[Tooltip] // 0x0000000180147430-0x0000000180147480
		public float m_XDamping; // 0x6C
		[Range] // 0x00000001801476F0-0x0000000180147750
		[Tooltip] // 0x00000001801476F0-0x0000000180147750
		public float m_YDamping; // 0x70
		[Range] // 0x0000000180147B80-0x0000000180147BD0
		[Tooltip] // 0x0000000180147B80-0x0000000180147BD0
		public float m_ZDamping; // 0x74
		[Tooltip] // 0x0000000180147DE0-0x0000000180147E10
		public CameraUpMode m_CameraUp; // 0x78
		[Range] // 0x0000000180147EF0-0x0000000180147F40
		[Tooltip] // 0x0000000180147EF0-0x0000000180147F40
		public float m_PitchDamping; // 0x7C
		[Range] // 0x0000000180148340-0x00000001801483A0
		[Tooltip] // 0x0000000180148340-0x00000001801483A0
		public float m_YawDamping; // 0x80
		[Range] // 0x00000001801486B0-0x0000000180148700
		[Tooltip] // 0x00000001801486B0-0x0000000180148700
		public float m_RollDamping; // 0x84
		[Tooltip] // 0x0000000180148A60-0x0000000180148A90
		public AutoDolly m_AutoDolly; // 0x88
		private float m_PreviousPathPosition; // 0x98
		private Quaternion m_PreviousOrientation; // 0x9C
		private Vector3 m_PreviousCameraPosition; // 0xAC
	
		// Properties
		public override bool IsValid { get; } // 0x00000001817DF8C0-0x00000001817DF930 
		public override CinemachineCore.Stage Stage { get; } // 0x000000018035FCC0-0x000000018035FCD0 
		private Vector3 AngularDamping { get; } // 0x00000001817DF7B0-0x00000001817DF8C0 
	
		// Nested types
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public enum CameraUpMode // TypeDefIndex: 7327
		{
			Default = 0,
			Path = 1,
			PathNoRoll = 2,
			FollowTarget = 3,
			FollowTargetNoRoll = 4
		}
	
		[Serializable]
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public struct AutoDolly // TypeDefIndex: 7328
		{
			// Fields
			[Tooltip] // 0x0000000180148EA0-0x0000000180148ED0
			public bool m_Enabled; // 0x00
			[Tooltip] // 0x00000001801490B0-0x00000001801490E0
			public float m_PositionOffset; // 0x04
			[Tooltip] // 0x0000000180149320-0x0000000180149350
			public int m_SearchRadius; // 0x08
			[FormerlySerializedAs] // 0x0000000180149520-0x0000000180149580
			[Tooltip] // 0x0000000180149520-0x0000000180149580
			public int m_SearchResolution; // 0x0C
	
			// Constructors
			public AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment); // 0x0000000180298F60-0x0000000180298F80
		}
	
		// Constructors
		public CinemachineTrackedDolly(); // 0x00000001817DF6A0-0x00000001817DF7B0
	
		// Methods
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001817DEB70-0x00000001817DF6A0
		private Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up); // 0x00000001817DE830-0x00000001817DEB70
	}
}
