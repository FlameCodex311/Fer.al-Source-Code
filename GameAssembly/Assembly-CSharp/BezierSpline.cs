/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class BezierSpline : MonoBehaviour // TypeDefIndex: 11386
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector3[] points; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private BezierControlPointMode[] modes; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool loop; // 0x30

	// Properties
	public bool Loop { get; set; } // 0x0000000180455B90-0x0000000180455BA0 0x000000018212E290-0x000000018212E350
	public int ControlPointCount { get; } // 0x0000000180CA67C0-0x0000000180CA67E0 
	public int CurveCount { get; } // 0x0000000180CA67E0-0x0000000180CA6810 

	// Constructors
	public BezierSpline(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public Vector3 GetControlPoint(int index); // 0x0000000180CA5370-0x0000000180CA53C0
	public void SetControlPoint(int index, Vector3 point); // 0x000000018212DBD0-0x000000018212E290
	public BezierControlPointMode GetControlPointMode(int index); // 0x0000000180CA5320-0x0000000180CA5370
	public void SetControlPointMode(int index, BezierControlPointMode mode); // 0x000000018212DAE0-0x000000018212DBD0
	private void EnforceMode(int index); // 0x000000018212C970-0x000000018212CD40
	public Vector3 GetPoint(float t); // 0x000000018212D320-0x000000018212D5E0
	public Vector3 GetVelocity(float t); // 0x000000018212D5E0-0x000000018212D910
	public Vector3 GetDirection(float t); // 0x000000018212D2C0-0x000000018212D320
	public Vector3 FindClosest(Vector3 worldPoint, int numPoints, float threshold = -1f /* Metadata: 0x0077CA8F */); // 0x000000018212D0C0-0x000000018212D2C0
	public Vector3[] FindClosestGroup(Vector3 worldPoint, int numPoints, int groupSize, float gapSize, float threshold = -1f /* Metadata: 0x0077CA93 */); // 0x000000018212CD40-0x000000018212D0C0
	public void AddCurve(); // 0x000000018212C610-0x000000018212C970
	public void Reset(); // 0x000000018212D910-0x000000018212DAE0
}

