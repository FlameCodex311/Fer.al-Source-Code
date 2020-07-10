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
	[AddComponentMenu] // 0x0000000180129DE0-0x0000000180129E40
	[DocumentationSorting] // 0x0000000180129DE0-0x0000000180129E40
	[SaveDuringPlay] // 0x0000000180129DE0-0x0000000180129E40
	public class CinemachinePath : CinemachinePathBase // TypeDefIndex: 7287
	{
		// Fields
		[Tooltip] // 0x000000018012A110-0x000000018012A140
		public bool m_Looped; // 0x48
		[Tooltip] // 0x000000018012A390-0x000000018012A3C0
		public Waypoint[] m_Waypoints; // 0x50
	
		// Properties
		public override float MinPos { get; } // 0x0000000180DD1F20-0x0000000180DD1F30 
		public override float MaxPos { get; } // 0x00000001817D6240-0x00000001817D6280 
		public override bool Looped { get; } // 0x00000001805E3A60-0x00000001805E3A70 
		public override int DistanceCacheSampleStepsPerSegment { get; } // 0x0000000180367710-0x0000000180367720 
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public struct Waypoint // TypeDefIndex: 7288
		{
			// Fields
			[Tooltip] // 0x000000018012A780-0x000000018012A7B0
			public Vector3 position; // 0x00
			[Tooltip] // 0x000000018012A8B0-0x000000018012A8E0
			public Vector3 tangent; // 0x0C
			[Tooltip] // 0x000000018012AB70-0x000000018012ABA0
			public float roll; // 0x18
		}
	
		// Constructors
		public CinemachinePath(); // 0x00000001817D61F0-0x00000001817D6240
	
		// Methods
		private float GetBoundingIndices(float pos, out int indexA, out int indexB); // 0x00000001817D6060-0x00000001817D61F0
		public override Vector3 EvaluatePosition(float pos); // 0x00000001817D58B0-0x00000001817D5C40
		public override Vector3 EvaluateTangent(float pos); // 0x00000001817D5C40-0x00000001817D6060
		public override Quaternion EvaluateOrientation(float pos); // 0x00000001817D5500-0x00000001817D58B0
		private void OnValidate(); // 0x0000000180B4E4C0-0x0000000180B4E4E0
	}
}
