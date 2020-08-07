/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion
{
	public static class V3Tools // TypeDefIndex: 9779
	{
		// Methods
		public static Vector3 Lerp(Vector3 fromVector, Vector3 toVector, float weight); // 0x0000000182024550-0x0000000182024640
		public static Vector3 Slerp(Vector3 fromVector, Vector3 toVector, float weight); // 0x0000000182024A90-0x0000000182024B80
		public static Vector3 ExtractVertical(Vector3 v, Vector3 verticalAxis, float weight); // 0x0000000182024430-0x0000000182024550
		public static Vector3 ExtractHorizontal(Vector3 v, Vector3 normal, float weight); // 0x00000001820242E0-0x0000000182024430
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out bool changed); // 0x0000000182023FE0-0x00000001820242E0
		public static Vector3 ClampDirection(Vector3 direction, Vector3 normalDirection, float clampWeight, int clampSmoothing, out float clampValue); // 0x0000000182023CD0-0x0000000182023FE0
		public static Vector3 LineToPlane(Vector3 origin, Vector3 direction, Vector3 planeNormal, Vector3 planePoint); // 0x0000000182024640-0x0000000182024850
		public static Vector3 PointToPlane(Vector3 point, Vector3 planePosition, Vector3 planeNormal); // 0x0000000182024850-0x0000000182024A90
	}
}
