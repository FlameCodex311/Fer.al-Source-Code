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
	[AddComponentMenu] // 0x0000000180290120-0x0000000180290180
	[DocumentationSorting] // 0x0000000180290120-0x0000000180290180
	[SaveDuringPlay] // 0x0000000180290120-0x0000000180290180
	public class CinemachinePath : CinemachinePathBase // TypeDefIndex: 7453
	{
		// Fields
		[Tooltip] // 0x00000001802903E0-0x0000000180290410
		public bool m_Looped; // 0x48
		[Tooltip] // 0x0000000180290440-0x0000000180290470
		public Waypoint[] m_Waypoints; // 0x50
	
		// Properties
		public override float MinPos { get; } // 0x000000018058C7E0-0x000000018058C7F0 
		public override float MaxPos { get; } // 0x0000000181391EF0-0x0000000181391F30 
		public override bool Looped { get; } // 0x00000001803C9D60-0x00000001803C9D70 
		public override int DistanceCacheSampleStepsPerSegment { get; } // 0x00000001803F46B0-0x00000001803F46C0 
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public struct Waypoint // TypeDefIndex: 7454
		{
			// Fields
			[Tooltip] // 0x00000001802908E0-0x0000000180290910
			public Vector3 position; // 0x00
			[Tooltip] // 0x0000000180290A60-0x0000000180290A90
			public Vector3 tangent; // 0x0C
			[Tooltip] // 0x0000000180290B10-0x0000000180290B40
			public float roll; // 0x18
		}
	
		// Constructors
		public CinemachinePath(); // 0x0000000181391EA0-0x0000000181391EF0
	
		// Methods
		private float GetBoundingIndices(float pos, out int indexA, out int indexB); // 0x0000000181391D10-0x0000000181391EA0
		public override Vector3 EvaluatePosition(float pos); // 0x0000000181391580-0x0000000181391900
		public override Vector3 EvaluateTangent(float pos); // 0x0000000181391900-0x0000000181391D10
		public override Quaternion EvaluateOrientation(float pos); // 0x00000001813911F0-0x0000000181391580
		private void OnValidate(); // 0x0000000180876F80-0x0000000180876FA0
	}
}
