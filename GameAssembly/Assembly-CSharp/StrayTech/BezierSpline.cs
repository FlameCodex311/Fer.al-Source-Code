/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace StrayTech
{
	public class BezierSpline : MonoBehaviour // TypeDefIndex: 14517
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector3[] _points; // 0x20
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private BezierControlPointMode[] _modes; // 0x28
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool _loop; // 0x30
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int _interpolationAccuracy; // 0x34
		private float _length; // 0x38
	
		// Properties
		public bool Loop { get; set; } // 0x0000000180455B90-0x0000000180455BA0 0x0000000180CA6810-0x0000000180CA68D0
		public float Length { get; } // 0x0000000180788790-0x00000001807887A0 
		public int CurveCount { get; } // 0x0000000180CA67E0-0x0000000180CA6810 
		public int ControlPointCount { get; } // 0x0000000180CA67C0-0x0000000180CA67E0 
	
		// Nested types
		public enum BezierControlPointMode // TypeDefIndex: 14518
		{
			Free = 0,
			Aligned = 1,
			Mirrored = 2
		}
	
		// Constructors
		public BezierSpline(); // 0x0000000180CA67B0-0x0000000180CA67C0
	
		// Methods
		private void Awake(); // 0x0000000180CA4A10-0x0000000180CA4BD0
		public Vector3 GetControlPoint(int index); // 0x0000000180CA5370-0x0000000180CA53C0
		public void SetControlPoint(int index, Vector3 point); // 0x0000000180CA60F0-0x0000000180CA67B0
		public BezierControlPointMode GetControlPointMode(int index); // 0x0000000180CA5320-0x0000000180CA5370
		public void SetControlPointMode(int index, BezierControlPointMode mode); // 0x0000000180CA6000-0x0000000180CA60F0
		private void EnforceMode(int index); // 0x0000000180CA4BD0-0x0000000180CA4FA0
		public Vector3 GetPosition(float t); // 0x0000000180CA5420-0x0000000180CA58C0
		public Vector3 GetVelocity(float t); // 0x0000000180CA58C0-0x0000000180CA5E30
		public Vector3 GetDirection(float t); // 0x0000000180CA53C0-0x0000000180CA5420
		public void AddCurve(); // 0x0000000180CA46B0-0x0000000180CA4A10
		public float GetClosestPointParam(Vector3 point, int iterations, float start = 0f /* Metadata: 0x007BAC80 */, float end = 1f /* Metadata: 0x007BAC84 */, float step = 0.01f /* Metadata: 0x007BAC88 */); // 0x0000000180CA5120-0x0000000180CA5320
		private float GetClosestPointParamOnSegmentIntern(Vector3 point, float start, float end, float step); // 0x0000000180CA4FA0-0x0000000180CA5120
		private void CalculateSplineLength(); // 0x0000000180CA4A10-0x0000000180CA4BD0
		public void Reset(); // 0x0000000180CA5E30-0x0000000180CA6000
	}
}
