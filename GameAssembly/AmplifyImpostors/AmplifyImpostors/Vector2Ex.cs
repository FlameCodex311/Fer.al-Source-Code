/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 74: AmplifyImpostors.dll - Assembly: AmplifyImpostors, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9076-9106

namespace AmplifyImpostors
{
	public static class Vector2Ex // TypeDefIndex: 9099
	{
		// Nested types
		[Serializable]
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c // TypeDefIndex: 9100
		{
			// Fields
			public static readonly <>c <>9; // 0x00
			public static Comparison<Vector2> <>9__3_0; // 0x08
	
			// Constructors
			static <>c(); // 0x000000018208B5E0-0x000000018208B640
			public <>c(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal int <ConvexHull>b__3_0(Vector2 a, Vector2 b); // 0x000000018208B530-0x000000018208B580
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 9101
		{
			// Fields
			public Vector2[] P; // 0x10
			public int smallestIndex; // 0x18
	
			// Constructors
			public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal bool <ReduceLeastSignificantVertice>b__0(Vector2 x); // 0x000000018208B580-0x000000018208B5E0
		}
	
		// Methods
		public static Vector2[] ConvexHull(Vector2[] P); // 0x000000018208B640-0x000000018208BA50
		public static Vector2[] ScaleAlongNormals(Vector2[] P, float scaleAmount); // 0x000000018208C6D0-0x000000018208CA40
		private static Vector2[] ReduceLeastSignificantVertice(Vector2[] P); // 0x000000018208BD60-0x000000018208C2C0
		public static Vector2[] ReduceVertices(Vector2[] P, int maxVertices); // 0x000000018208C2C0-0x000000018208C6D0
		private static Vector2 GetIntersectionPointCoordinates(Vector2 A1, Vector2 A2, Vector2 B1, Vector2 B2); // 0x000000018208BAA0-0x000000018208BC70
		private static float OutsideBounds(Vector2 P); // 0x000000018208BC70-0x000000018208BD60
	
		// Extension methods
		public static float Cross(this Vector2 O, Vector2 A, Vector2 B); // 0x000000018208BA50-0x000000018208BAA0
		public static float TriangleArea(this Vector2 O, Vector2 A, Vector2 B); // 0x000000018208CB20-0x000000018208CBC0
		public static float TriangleArea(this Vector3 O, Vector3 A, Vector3 B); // 0x000000018208CA40-0x000000018208CB20
	}
}
