/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine
{
	[AddComponentMenu] // 0x00000001801DF1B0-0x00000001801DF210
	[DocumentationSorting] // 0x00000001801DF1B0-0x00000001801DF210
	[SaveDuringPlay] // 0x00000001801DF1B0-0x00000001801DF210
	public class CinemachineTrackedDolly : CinemachineComponentBase // TypeDefIndex: 7492
	{
		// Fields
		[Tooltip] // 0x00000001801E50F0-0x00000001801E5120
		public CinemachinePathBase m_Path; // 0x50
		[Tooltip] // 0x00000001801E5300-0x00000001801E5330
		public float m_PathPosition; // 0x58
		[Tooltip] // 0x00000001801E5590-0x00000001801E55C0
		public CinemachinePathBase.PositionUnits m_PositionUnits; // 0x5C
		[Tooltip] // 0x00000001801E5900-0x00000001801E5930
		public Vector3 m_PathOffset; // 0x60
		[Range] // 0x00000001801E5AB0-0x00000001801E5B00
		[Tooltip] // 0x00000001801E5AB0-0x00000001801E5B00
		public float m_XDamping; // 0x6C
		[Range] // 0x00000001801E5D20-0x00000001801E5D80
		[Tooltip] // 0x00000001801E5D20-0x00000001801E5D80
		public float m_YDamping; // 0x70
		[Range] // 0x00000001801E6150-0x00000001801E61A0
		[Tooltip] // 0x00000001801E6150-0x00000001801E61A0
		public float m_ZDamping; // 0x74
		[Tooltip] // 0x00000001801E6440-0x00000001801E6470
		public CameraUpMode m_CameraUp; // 0x78
		[Range] // 0x00000001801E66D0-0x00000001801E6720
		[Tooltip] // 0x00000001801E66D0-0x00000001801E6720
		public float m_PitchDamping; // 0x7C
		[Range] // 0x00000001801E6A90-0x00000001801E6AF0
		[Tooltip] // 0x00000001801E6A90-0x00000001801E6AF0
		public float m_YawDamping; // 0x80
		[Range] // 0x00000001801E6DA0-0x00000001801E6DF0
		[Tooltip] // 0x00000001801E6DA0-0x00000001801E6DF0
		public float m_RollDamping; // 0x84
		[Tooltip] // 0x00000001801E7220-0x00000001801E7250
		public AutoDolly m_AutoDolly; // 0x88
		private float m_PreviousPathPosition; // 0x98
		private Quaternion m_PreviousOrientation; // 0x9C
		private Vector3 m_PreviousCameraPosition; // 0xAC
	
		// Properties
		public override bool IsValid { get; } // 0x0000000181399E20-0x0000000181399E90 
		public override CinemachineCore.Stage Stage { get; } // 0x000000018037DDC0-0x000000018037DDD0 
		private Vector3 AngularDamping { get; } // 0x0000000181399D10-0x0000000181399E20 
	
		// Nested types
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public enum CameraUpMode // TypeDefIndex: 7493
		{
			Default = 0,
			Path = 1,
			PathNoRoll = 2,
			FollowTarget = 3,
			FollowTargetNoRoll = 4
		}
	
		[Serializable]
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public struct AutoDolly // TypeDefIndex: 7494
		{
			// Fields
			[Tooltip] // 0x00000001801E7820-0x00000001801E7850
			public bool m_Enabled; // 0x00
			[Tooltip] // 0x00000001801E8C60-0x00000001801E8C90
			public float m_PositionOffset; // 0x04
			[Tooltip] // 0x00000001801E8EB0-0x00000001801E8EE0
			public int m_SearchRadius; // 0x08
			[FormerlySerializedAs] // 0x00000001801E9130-0x00000001801E9190
			[Tooltip] // 0x00000001801E9130-0x00000001801E9190
			public int m_SearchResolution; // 0x0C
	
			// Constructors
			public AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment); // 0x00000001800C13E0-0x00000001800C1400
		}
	
		// Constructors
		public CinemachineTrackedDolly(); // 0x0000000181399C00-0x0000000181399D10
	
		// Methods
		public override void MutateCameraState(ref CameraState curState, float deltaTime); // 0x00000001813990D0-0x0000000181399C00
		private Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up); // 0x0000000181398D90-0x00000001813990D0
	}
}
