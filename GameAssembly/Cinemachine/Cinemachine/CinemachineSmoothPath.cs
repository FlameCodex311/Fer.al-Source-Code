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
	[AddComponentMenu] // 0x000000018012C1E0-0x000000018012C240
	[DocumentationSorting] // 0x000000018012C1E0-0x000000018012C240
	[SaveDuringPlay] // 0x000000018012C1E0-0x000000018012C240
	public class CinemachineSmoothPath : CinemachinePathBase // TypeDefIndex: 7290
	{
		// Fields
		[Tooltip] // 0x000000018012A110-0x000000018012A140
		public bool m_Looped; // 0x48
		[Tooltip] // 0x000000018012A390-0x000000018012A3C0
		public Waypoint[] m_Waypoints; // 0x50
		private Waypoint[] m_ControlPoints1; // 0x58
		private Waypoint[] m_ControlPoints2; // 0x60
		private bool m_IsLoopedCache; // 0x68
	
		// Properties
		public override float MinPos { get; } // 0x0000000180DD1F20-0x0000000180DD1F30 
		public override float MaxPos { get; } // 0x00000001817D6240-0x00000001817D6280 
		public override bool Looped { get; } // 0x00000001805E3A60-0x00000001805E3A70 
		public override int DistanceCacheSampleStepsPerSegment { get; } // 0x0000000180367710-0x0000000180367720 
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public struct Waypoint // TypeDefIndex: 7291
		{
			// Fields
			[Tooltip] // 0x000000018012A780-0x000000018012A7B0
			public Vector3 position; // 0x00
			[Tooltip] // 0x000000018012AB70-0x000000018012ABA0
			public float roll; // 0x0C
	
			// Properties
			internal Vector4 AsVector4 { get; } // 0x0000000180299420-0x0000000180299460 
	
			// Methods
			internal static Waypoint FromVector4(Vector4 v); // 0x00000001817EA430-0x00000001817EA4F0
		}
	
		// Constructors
		public CinemachineSmoothPath(); // 0x00000001817D8700-0x00000001817D8750
	
		// Methods
		private void OnValidate(); // 0x0000000180B4E4C0-0x0000000180B4E4E0
		public override void InvalidateDistanceCache(); // 0x00000001817D8250-0x00000001817D8270
		private void UpdateControlPoints(); // 0x00000001817D8270-0x00000001817D8700
		private float GetBoundingIndices(float pos, out int indexA, out int indexB); // 0x00000001817D8130-0x00000001817D8250
		public override Vector3 EvaluatePosition(float pos); // 0x00000001817D7AD0-0x00000001817D7DB0
		public override Vector3 EvaluateTangent(float pos); // 0x00000001817D7DB0-0x00000001817D8130
		public override Quaternion EvaluateOrientation(float pos); // 0x00000001817D76E0-0x00000001817D7AD0
	}
}
