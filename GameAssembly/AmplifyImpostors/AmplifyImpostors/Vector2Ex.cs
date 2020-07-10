/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 73: AmplifyImpostors.dll - Assembly: AmplifyImpostors, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8910-8940

namespace AmplifyImpostors
{
	public static class Vector2Ex // TypeDefIndex: 8933
	{
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c // TypeDefIndex: 8934
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<Vector2> <>9__3_0; // 0x08
	
			// Constructors
			static <>c(); // 0x00000001822B3E00-0x00000001822B3E60
			public <>c(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal int <ConvexHull>b__3_0(Vector2 a, Vector2 b); // 0x00000001822B3D50-0x00000001822B3DA0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 8935
		{
			// Fields
			public Vector2[] P; // 0x10
			public int smallestIndex; // 0x18
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal bool <ReduceLeastSignificantVertice>b__0(Vector2 x); // 0x00000001822B3DA0-0x00000001822B3E00
		}
	
		// Methods
		public static Vector2[] ConvexHull(Vector2[] P); // 0x00000001822B3E60-0x00000001822B4290
		public static Vector2[] ScaleAlongNormals(Vector2[] P, float scaleAmount); // 0x00000001822B4F60-0x00000001822B52E0
		private static Vector2[] ReduceLeastSignificantVertice(Vector2[] P); // 0x00000001822B45A0-0x00000001822B4B30
		public static Vector2[] ReduceVertices(Vector2[] P, int maxVertices); // 0x00000001822B4B30-0x00000001822B4F60
		private static Vector2 GetIntersectionPointCoordinates(Vector2 A1, Vector2 A2, Vector2 B1, Vector2 B2); // 0x00000001822B42E0-0x00000001822B44B0
		private static float OutsideBounds(Vector2 P); // 0x00000001822B44B0-0x00000001822B45A0
	
		// Extension methods
		public static float Cross(this Vector2 O, Vector2 A, Vector2 B); // 0x00000001822B4290-0x00000001822B42E0
		public static float TriangleArea(this Vector2 O, Vector2 A, Vector2 B); // 0x00000001822B53C0-0x00000001822B5460
		public static float TriangleArea(this Vector3 O, Vector3 A, Vector3 B); // 0x00000001822B52E0-0x00000001822B53C0
	}
}
