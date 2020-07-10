/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion
{
	public static class V3Tools // TypeDefIndex: 9325
	{
		// Methods
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight); // 0x000000018228BEA0-0x000000018228BF90
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight); // 0x000000018228C3E0-0x000000018228C4D0
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight); // 0x000000018228BD80-0x000000018228BEA0
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight); // 0x000000018228BC30-0x000000018228BD80
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed); // 0x000000018228B930-0x000000018228BC30
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue); // 0x000000018228B620-0x000000018228B930
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint); // 0x000000018228BF90-0x000000018228C1A0
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal); // 0x000000018228C1A0-0x000000018228C3E0
	}
}
