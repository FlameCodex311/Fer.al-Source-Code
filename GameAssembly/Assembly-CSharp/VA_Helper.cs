/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMODUnity;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class VA_Helper // TypeDefIndex: 13242
{
	// Fields
	public static int MeshVertexLimit; // 0x00
	private static StudioListener audioListener; // 0x08

	// Properties
	public static StudioListener AudioListener { get; } // 0x0000000181225AB0-0x0000000181225C30 

	// Constructors
	static VA_Helper(); // 0x0000000181225A70-0x0000000181225AB0

	// Methods
	public static Vector2 SinCos(float a); // 0x00000001812256A0-0x0000000181225730
	public static void Destroy(UnityEngine.Object o); // 0x0000000181224A50-0x0000000181224AB0
	public static void StealthSet(MeshFilter mf, Mesh m); // 0x0000000181225730-0x0000000181225800
	public static void SetPosition(Transform t, Vector3 v); // 0x0000000181225570-0x0000000181225610
	public static void SetRotation(Transform t, Quaternion q); // 0x0000000181225610-0x00000001812256A0
	public static bool Enabled(Behaviour b); // 0x0000000181224B70-0x0000000181224C10
	public static float Divide(float a, float b); // 0x0000000181224AB0-0x0000000181224B70
	public static float Reciprocal(float v); // 0x0000000181225150-0x0000000181225210
	public static bool Zero(float v); // 0x0000000181225A10-0x0000000181225A70
	public static Matrix4x4 RotationMatrix(Quaternion q); // 0x0000000181225210-0x0000000181225340
	public static Matrix4x4 TranslationMatrix(Vector3 xyz); // 0x0000000181225800-0x0000000181225910
	public static Matrix4x4 TranslationMatrix(float x, float y, float z); // 0x0000000181225910-0x00000001812259E0
	public static Matrix4x4 ScalingMatrix(float xyz); // 0x00000001812254D0-0x0000000181225570
	public static Matrix4x4 ScalingMatrix(Vector3 xyz); // 0x0000000181225340-0x0000000181225400
	public static Matrix4x4 ScalingMatrix(float x, float y, float z); // 0x0000000181225400-0x00000001812254D0
	public static float DampenFactor(float dampening, float elapsed); // 0x0000000181224610-0x00000001812246A0
	public static Quaternion Dampen(Quaternion current, Quaternion target, float dampening, float elapsed, float minStep = 0f /* Metadata: 0x007839C6 */); // 0x00000001812246A0-0x00000001812248F0
	public static float Dampen(float current, float target, float dampening, float elapsed, float minStep = 0f /* Metadata: 0x007839CA */); // 0x00000001812248F0-0x0000000181224A50
	public static Vector3 Dampen3(Vector3 current, Vector3 target, float dampening, float elapsed, float minStep = 0f /* Metadata: 0x007839CE */); // 0x0000000181224460-0x0000000181224610
	public static Quaternion MoveTowards(Quaternion current, Quaternion target, float maxDelta); // 0x0000000181224E50-0x0000000181224FE0
	public static float MoveTowards(float current, float target, float maxDelta); // 0x0000000181224FE0-0x0000000181225090
	public static Vector3 ClosestPointToLineSegment(Vector3 a, Vector3 b, Vector3 point); // 0x0000000181223B10-0x0000000181223D50
	public static Vector3 ClosestPointToTriangle(Vector3 a, Vector3 b, Vector3 c, Vector3 p); // 0x0000000181223D50-0x0000000181224460
	public static Vector3 GetBarycentric(Vector2 a, Vector2 b, Vector2 c, Vector2 p); // 0x0000000181224C10-0x0000000181224E50
	public static bool PointLeftOfLine(Vector2 a, Vector2 b, Vector2 p); // 0x0000000181225090-0x00000001812250F0
	public static bool PointRightOfLine(Vector2 a, Vector2 b, Vector2 p); // 0x00000001812250F0-0x0000000181225150
	public static Vector2 VectorXY(Vector3 xyz); // 0x00000001812259E0-0x0000000181225A10
}

