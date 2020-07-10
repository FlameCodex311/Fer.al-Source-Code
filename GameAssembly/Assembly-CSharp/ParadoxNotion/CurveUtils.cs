/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace ParadoxNotion
{
	public static class CurveUtils // TypeDefIndex: 14693
	{
		// Fields
		private const float POS_CHECK_RES = 100f; // Metadata: 0x0078475A
		private const float POS_CHECK_DISTANCE = 10f; // Metadata: 0x0078475E
	
		// Methods
		public static Vector2 GetPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, float t); // 0x0000000180E8D580-0x0000000180E8D750
		public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition); // 0x0000000180E8DB00-0x0000000180E8DB40
		public static bool IsPosAlongCurve(Vector2 from, Vector2 to, Vector2 fromTangent, Vector2 toTangent, Vector2 targetPosition, out float norm); // 0x0000000180E8D750-0x0000000180E8DB00
		public static void ResolveTangents(Vector2 from, Vector2 to, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent); // 0x0000000180E8DB40-0x0000000180E8DC70
		public static void ResolveTangents(Vector2 from, Vector2 to, Rect fromRect, Rect toRect, float rigidMlt, PlanarDirection direction, out Vector2 fromTangent, out Vector2 toTangent); // 0x0000000180E8DC70-0x0000000180E8DF90
	}
}
