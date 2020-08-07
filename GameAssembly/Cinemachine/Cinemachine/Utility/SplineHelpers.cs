/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine.Utility
{
	public static class SplineHelpers // TypeDefIndex: 7576
	{
		// Methods
		public static Vector3 Bezier3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3); // 0x0000000181FF80E0-0x0000000181FF8330
		public static Vector3 BezierTangent3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3); // 0x0000000181FF8330-0x0000000181FF8790
		public static float Bezier1(float t, float p0, float p1, float p2, float p3); // 0x0000000181FF7FF0-0x0000000181FF80E0
		public static void ComputeSmoothControlPoints(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2); // 0x0000000181FF8BE0-0x0000000181FF9890
		public static void ComputeSmoothControlPointsLooped(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2); // 0x0000000181FF8790-0x0000000181FF8BE0
	}
}
