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
	public abstract class CinemachinePathBase : UnityEngine.MonoBehaviour // TypeDefIndex: 7518
	{
		// Fields
		[Range] // 0x00000001801FD0F0-0x00000001801FD140
		[Tooltip] // 0x00000001801FD0F0-0x00000001801FD140
		public int m_Resolution; // 0x18
		[Tooltip] // 0x00000001801FD430-0x00000001801FD460
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
		public float PathLength { get; } // 0x0000000181391120-0x00000001813911F0 
	
		// Nested types
		[Serializable]
		[DocumentationSorting] // 0x00000001801D04D0-0x00000001801D04F0
		public class Appearance // TypeDefIndex: 7519
		{
			// Fields
			[Tooltip] // 0x00000001801FD940-0x00000001801FD970
			public Color pathColor; // 0x10
			[Tooltip] // 0x00000001801FDD10-0x00000001801FDD40
			public Color inactivePathColor; // 0x20
			[Range] // 0x00000001801FDEB0-0x00000001801FDF00
			[Tooltip] // 0x00000001801FDEB0-0x00000001801FDF00
			public float width; // 0x30
	
			// Constructors
			public Appearance(); // 0x0000000181384250-0x00000001813842A0
		}
	
		public enum PositionUnits // TypeDefIndex: 7520
		{
			PathUnits = 0,
			Distance = 1,
			Normalized = 2
		}
	
		// Constructors
		protected CinemachinePathBase(); // 0x0000000181391090-0x0000000181391120
	
		// Methods
		public virtual float StandardizePos(float pos); // 0x0000000181390C70-0x0000000181390DC0
		public abstract Vector3 EvaluatePosition(float pos);
		public abstract Vector3 EvaluateTangent(float pos);
		public abstract Quaternion EvaluateOrientation(float pos);
		public virtual float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment); // 0x00000001813900F0-0x0000000181390520
		public float MinUnit(PositionUnits units); // 0x0000000181390740-0x0000000181390760
		public float MaxUnit(PositionUnits units); // 0x0000000181390710-0x0000000181390740
		public virtual float StandardizeUnit(float pos, PositionUnits units); // 0x0000000181390DC0-0x0000000181390E60
		public Vector3 EvaluatePositionAtUnit(float pos, PositionUnits units); // 0x0000000181390030-0x0000000181390090
		public Vector3 EvaluateTangentAtUnit(float pos, PositionUnits units); // 0x0000000181390090-0x00000001813900F0
		public Quaternion EvaluateOrientationAtUnit(float pos, PositionUnits units); // 0x000000018138FFE0-0x0000000181390030
		public virtual void InvalidateDistanceCache(); // 0x0000000181390700-0x0000000181390710
		public bool DistanceCacheIsValid(); // 0x000000018138FF50-0x000000018138FFE0
		public float StandardizePathDistance(float distance); // 0x0000000181390B90-0x0000000181390C70
		public float ToNativePathUnits(float pos, PositionUnits units); // 0x0000000181390E60-0x0000000181391090
		public float FromPathNativeUnits(float pos, PositionUnits units); // 0x0000000181390520-0x0000000181390700
		private void ResamplePath(int stepsPerSegment); // 0x0000000181390760-0x0000000181390B90
	}
}
