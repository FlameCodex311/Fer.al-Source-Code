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
	[AddComponentMenu] // 0x0000000180291FB0-0x0000000180292010
	[DocumentationSorting] // 0x0000000180291FB0-0x0000000180292010
	[SaveDuringPlay] // 0x0000000180291FB0-0x0000000180292010
	public class CinemachineSmoothPath : CinemachinePathBase // TypeDefIndex: 7456
	{
		// Fields
		[Tooltip] // 0x00000001802903E0-0x0000000180290410
		public bool m_Looped; // 0x48
		[Tooltip] // 0x0000000180290440-0x0000000180290470
		public Waypoint[] m_Waypoints; // 0x50
		private Waypoint[] m_ControlPoints1; // 0x58
		private Waypoint[] m_ControlPoints2; // 0x60
		private bool m_IsLoopedCache; // 0x68
	
		// Properties
		public override float MinPos { get; } // 0x000000018058C7E0-0x000000018058C7F0 
		public override float MaxPos { get; } // 0x0000000181391EF0-0x0000000181391F30 
		public override bool Looped { get; } // 0x00000001803C9D60-0x00000001803C9D70 
		public override int DistanceCacheSampleStepsPerSegment { get; } // 0x00000001803F46B0-0x00000001803F46C0 
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public struct Waypoint // TypeDefIndex: 7457
		{
			// Fields
			[Tooltip] // 0x00000001802908E0-0x0000000180290910
			public Vector3 position; // 0x00
			[Tooltip] // 0x0000000180290B10-0x0000000180290B40
			public float roll; // 0x0C
	
			// Properties
			internal Vector4 AsVector4 { get; } // 0x00000001800C15B0-0x00000001800C1690 
	
			// Methods
			internal static Waypoint FromVector4(Vector4 v); // 0x000000018139FE10-0x000000018139FED0
		}
	
		// Constructors
		public CinemachineSmoothPath(); // 0x0000000181392FB0-0x0000000181393000
	
		// Methods
		private void OnValidate(); // 0x0000000180876F80-0x0000000180876FA0
		public override void InvalidateDistanceCache(); // 0x0000000181392B20-0x0000000181392B40
		private void UpdateControlPoints(); // 0x0000000181392B40-0x0000000181392FB0
		private float GetBoundingIndices(float pos, out int indexA, out int indexB); // 0x0000000181392A00-0x0000000181392B20
		public override Vector3 EvaluatePosition(float pos); // 0x00000001813923D0-0x00000001813926A0
		public override Vector3 EvaluateTangent(float pos); // 0x00000001813926A0-0x0000000181392A00
		public override Quaternion EvaluateOrientation(float pos); // 0x0000000181392000-0x00000001813923D0
	}
}
