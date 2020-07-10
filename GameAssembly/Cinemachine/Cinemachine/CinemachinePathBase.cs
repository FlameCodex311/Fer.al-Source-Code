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
	public abstract class CinemachinePathBase : UnityEngine.MonoBehaviour // TypeDefIndex: 7352
	{
		// Fields
		[Range] // 0x000000018015B600-0x000000018015B650
		[Tooltip] // 0x000000018015B600-0x000000018015B650
		public int m_Resolution; // 0x18
		[Tooltip] // 0x000000018015BA70-0x000000018015BAA0
		public Appearance m_Appearance; // 0x20
		private float[] m_DistanceToPos; // 0x28
		private float[] m_PosToDistance; // 0x30
		private int m_CachedSampleSteps; // 0x38
		private float m_PathLength; // 0x3C
		private float m_cachedPosStepSize; // 0x40
		private float m_cachedDistanceStepSize; // 0x44
	
		// Properties
		public abstract float MinPos { get; }
		public abstract float MaxPos { get; }
		public abstract bool Looped { get; }
		public abstract int DistanceCacheSampleStepsPerSegment { get; }
		public float PathLength { get; } // 0x00000001817D5430-0x00000001817D5500 
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001800B83F0-0x00000001800B8410
		public class Appearance // TypeDefIndex: 7353
		{
			// Fields
			[Tooltip] // 0x000000018015BF60-0x000000018015BF90
			public Color pathColor; // 0x10
			[Tooltip] // 0x000000018015C0F0-0x000000018015C120
			public Color inactivePathColor; // 0x20
			[Range] // 0x000000018015C2B0-0x000000018015C300
			[Tooltip] // 0x000000018015C2B0-0x000000018015C300
			public float width; // 0x30
	
			// Constructors
			public Appearance(); // 0x00000001817CCB20-0x00000001817CCB70
		}
	
		public enum PositionUnits // TypeDefIndex: 7354
		{
			PathUnits = 0,
			Distance = 1,
			Normalized = 2
		}
	
		// Constructors
		protected CinemachinePathBase(); // 0x00000001817D53A0-0x00000001817D5430
	
		// Methods
		public virtual float StandardizePos(float pos); // 0x00000001817D4F70-0x00000001817D50C0
		public abstract Vector3 EvaluatePosition(float pos);
		public abstract Vector3 EvaluateTangent(float pos);
		public abstract Quaternion EvaluateOrientation(float pos);
		public virtual float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment); // 0x00000001817D43C0-0x00000001817D47F0
		public float MinUnit(PositionUnits units); // 0x00000001817D4A20-0x00000001817D4A40
		public float MaxUnit(PositionUnits units); // 0x00000001817D49F0-0x00000001817D4A20
		public virtual float StandardizeUnit(float pos, PositionUnits units); // 0x00000001817D50C0-0x00000001817D5160
		public Vector3 EvaluatePositionAtUnit(float pos, PositionUnits units); // 0x00000001817D4300-0x00000001817D4360
		public Vector3 EvaluateTangentAtUnit(float pos, PositionUnits units); // 0x00000001817D4360-0x00000001817D43C0
		public Quaternion EvaluateOrientationAtUnit(float pos, PositionUnits units); // 0x00000001817D42B0-0x00000001817D4300
		public virtual void InvalidateDistanceCache(); // 0x00000001817D49E0-0x00000001817D49F0
		public bool DistanceCacheIsValid(); // 0x00000001817D4220-0x00000001817D42B0
		public float StandardizePathDistance(float distance); // 0x00000001817D4E90-0x00000001817D4F70
		public float ToNativePathUnits(float pos, PositionUnits units); // 0x00000001817D5160-0x00000001817D53A0
		public float FromPathNativeUnits(float pos, PositionUnits units); // 0x00000001817D47F0-0x00000001817D49E0
		private void ResamplePath(int stepsPerSegment); // 0x00000001817D4A40-0x00000001817D4E90
	}
}
