/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine.Utility
{
	public static class SplineHelpers // TypeDefIndex: 7410
	{
		// Methods
		public static Vector3 Bezier3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3); // 0x00000001822C20A0-0x00000001822C22F0
		public static Vector3 BezierTangent3(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3); // 0x00000001822C22F0-0x00000001822C2750
		public static float Bezier1(float t, float p0, float p1, float p2, float p3); // 0x00000001822C1FB0-0x00000001822C20A0
		public static void ComputeSmoothControlPoints(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2); // 0x00000001822C2BE0-0x00000001822C3950
		public static void ComputeSmoothControlPointsLooped(ref Vector4[] knot, ref Vector4[] ctrl1, ref Vector4[] ctrl2); // 0x00000001822C2750-0x00000001822C2BE0
	}
}
