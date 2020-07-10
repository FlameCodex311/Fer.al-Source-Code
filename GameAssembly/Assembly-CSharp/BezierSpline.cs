/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class BezierSpline : MonoBehaviour // TypeDefIndex: 13713
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector3[] points; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private BezierControlPointMode[] modes; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool loop; // 0x30

	// Properties
	public bool Loop { get; set; } // 0x000000018048B840-0x000000018048B850 0x0000000181047100-0x00000001810471C0
	public int ControlPointCount { get; } // 0x00000001810470B0-0x00000001810470D0 
	public int CurveCount { get; } // 0x00000001810470D0-0x0000000181047100 

	// Constructors
	public BezierSpline(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public Vector3 GetControlPoint(int index); // 0x0000000181046030-0x0000000181046080
	public void SetControlPoint(int index, Vector3 point); // 0x00000001810469C0-0x00000001810470B0
	public BezierControlPointMode GetControlPointMode(int index); // 0x0000000181045FE0-0x0000000181046030
	public void SetControlPointMode(int index, BezierControlPointMode mode); // 0x00000001810468D0-0x00000001810469C0
	private void EnforceMode(int index); // 0x0000000181045670-0x0000000181045A50
	public Vector3 GetPoint(float t); // 0x00000001810460E0-0x00000001810463B0
	public Vector3 GetVelocity(float t); // 0x00000001810463B0-0x00000001810466F0
	public Vector3 GetDirection(float t); // 0x0000000181046080-0x00000001810460E0
	public Vector3 FindClosest(Vector3 worldPoint, int numPoints, float threshold = -1f /* Metadata: 0x00783FD0 */); // 0x0000000181045DE0-0x0000000181045FE0
	public Vector3[] FindClosestGroup(Vector3 worldPoint, int numPoints, int groupSize, float gapSize, float threshold = -1f /* Metadata: 0x00783FD4 */); // 0x0000000181045A50-0x0000000181045DE0
	public void AddCurve(); // 0x00000001810452E0-0x0000000181045670
	public void Reset(); // 0x00000001810466F0-0x00000001810468D0
}

