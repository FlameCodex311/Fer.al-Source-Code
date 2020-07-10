/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace StrayTech
{
	public class BezierSpline : MonoBehaviour // TypeDefIndex: 13850
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector3[] _points; // 0x20
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private BezierControlPointMode[] _modes; // 0x28
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool _loop; // 0x30
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int _interpolationAccuracy; // 0x34
		private float _length; // 0x38
	
		// Properties
		public bool Loop { get; set; } // 0x000000018048B840-0x000000018048B850 0x0000000181348020-0x00000001813480E0
		public float Length { get; } // 0x0000000180487DD0-0x0000000180487DE0 
		public int CurveCount { get; } // 0x00000001810470D0-0x0000000181047100 
		public int ControlPointCount { get; } // 0x00000001810470B0-0x00000001810470D0 
	
		// Nested types
		public enum BezierControlPointMode // TypeDefIndex: 13851
		{
			Free = 0,
			Aligned = 1,
			Mirrored = 2
		}
	
		// Constructors
		public BezierSpline(); // 0x0000000181348010-0x0000000181348020
	
		// Methods
		private void Awake(); // 0x0000000181346290-0x0000000181346450
		public Vector3 GetControlPoint(int index); // 0x0000000181046030-0x0000000181046080
		public void SetControlPoint(int index, Vector3 point); // 0x0000000181347920-0x0000000181348010
		public BezierControlPointMode GetControlPointMode(int index); // 0x0000000181045FE0-0x0000000181046030
		public void SetControlPointMode(int index, BezierControlPointMode mode); // 0x0000000181347830-0x0000000181347920
		private void EnforceMode(int index); // 0x0000000181346450-0x0000000181346830
		public Vector3 GetPosition(float t); // 0x0000000181346C10-0x00000001813470D0
		public Vector3 GetVelocity(float t); // 0x00000001813470D0-0x0000000181347650
		public Vector3 GetDirection(float t); // 0x0000000181346BB0-0x0000000181346C10
		public void AddCurve(); // 0x0000000181345F00-0x0000000181346290
		public float GetClosestPointParam(Vector3 point, int iterations, float start = 0f /* Metadata: 0x007841BD */, float end = 1f /* Metadata: 0x007841C1 */, float step = 0.01f /* Metadata: 0x007841C5 */); // 0x00000001813469B0-0x0000000181346BB0
		private float GetClosestPointParamOnSegmentIntern(Vector3 point, float start, float end, float step); // 0x0000000181346830-0x00000001813469B0
		private void CalculateSplineLength(); // 0x0000000181346290-0x0000000181346450
		public void Reset(); // 0x0000000181347650-0x0000000181347830
	}
}
