/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class UIGradientUtils // TypeDefIndex: 12012
{
	// Fields
	private static Vector2[] ms_verticesPositions; // 0x00

	// Properties
	public static Vector2[] VerticePositions { get; } // 0x0000000180FB3D50-0x0000000180FB3E10 

	// Nested types
	public struct Matrix2x3 // TypeDefIndex: 12013
	{
		// Fields
		public float m00; // 0x00
		public float m01; // 0x04
		public float m02; // 0x08
		public float m10; // 0x0C
		public float m11; // 0x10
		public float m12; // 0x14

		// Constructors
		public Matrix2x3(float m00, float m01, float m02, float m10, float m11, float m12); // 0x00000001801F1970-0x00000001801F19B0

		// Methods
		public static Vector2 operator *(Matrix2x3 m, Vector2 v); // 0x0000000180FA19E0-0x0000000180FA1A80
	}

	// Constructors
	static UIGradientUtils(); // 0x0000000180FB3BD0-0x0000000180FB3D50

	// Methods
	public static Matrix2x3 LocalPositionMatrix(Rect rect, Vector2 dir); // 0x0000000180FB3A00-0x0000000180FB3B30
	public static Vector2 RotationDir(float angle); // 0x0000000180FB3B30-0x0000000180FB3BD0
	public static Vector2 CompensateAspectRatio(Rect rect, Vector2 dir); // 0x0000000180FB3540-0x0000000180FB3590
	public static float InverseLerp(float a, float b, float v); // 0x0000000180FB3590-0x0000000180FB35B0
	public static Color Bilerp(Color a1, Color a2, Color b1, Color b2, Vector2 t); // 0x0000000180FB3460-0x0000000180FB3540
	public static void Lerp(UIVertex a, UIVertex b, float t, ref UIVertex c); // 0x0000000180FB35B0-0x0000000180FB3A00
}

