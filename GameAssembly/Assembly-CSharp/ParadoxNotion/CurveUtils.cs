/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace ParadoxNotion
{
	public static class CurveUtils // TypeDefIndex: 15840
	{
		// Fields
		private const float POS_CHECK_RES = 100f; // Metadata: 0x007BB5E6
		private const float POS_CHECK_DISTANCE = 10f; // Metadata: 0x007BB5EA
	
		// Methods
		public static Vector2 GetPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, float t); // 0x00000001806C48E0-0x00000001806C4AB0
		public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition); // 0x00000001806C5000-0x00000001806C5040
		public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition, out float norm); // 0x00000001806C4AB0-0x00000001806C5000
		public static void ResolveTangents(Vector2 from, Vector2 to, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent); // 0x00000001806C5040-0x00000001806C5170
		public static void ResolveTangents(Vector2 from, Vector2 to, Rect fromRect, Rect toRect, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent); // 0x00000001806C5170-0x00000001806C5490
	}
}
