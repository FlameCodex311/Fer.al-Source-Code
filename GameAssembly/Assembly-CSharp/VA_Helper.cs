/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FMODUnity;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class VA_Helper // TypeDefIndex: 10908
{
	// Fields
	public static int MeshVertexLimit; // 0x00
	private static StudioListener audioListener; // 0x08

	// Properties
	public static StudioListener AudioListener { get; } // 0x0000000180671740-0x00000001806718C0 

	// Constructors
	static VA_Helper(); // 0x0000000180671700-0x0000000180671740

	// Methods
	public static Vector2 SinCos(float a); // 0x0000000180671330-0x00000001806713C0
	public static void Destroy(UnityEngine.Object o); // 0x0000000180670760-0x00000001806707C0
	public static void StealthSet(MeshFilter mf, Mesh m); // 0x00000001806713C0-0x0000000180671490
	public static void SetPosition(Transform t, Vector3 v); // 0x0000000180671200-0x00000001806712A0
	public static void SetRotation(Transform t, Quaternion q); // 0x00000001806712A0-0x0000000180671330
	public static bool Enabled(Behaviour b); // 0x0000000180670880-0x0000000180670920
	public static float Divide(float a, float b); // 0x00000001806707C0-0x0000000180670880
	public static float Reciprocal(float v); // 0x0000000180670DE0-0x0000000180670EA0
	public static bool Zero(float v); // 0x00000001806716A0-0x0000000180671700
	public static Matrix4x4 RotationMatrix(Quaternion q); // 0x0000000180670EA0-0x0000000180670FD0
	public static Matrix4x4 TranslationMatrix(Vector3 xyz); // 0x0000000180671490-0x00000001806715A0
	public static Matrix4x4 TranslationMatrix(float x, float y, float z); // 0x00000001806715A0-0x0000000180671670
	public static Matrix4x4 ScalingMatrix(float xyz); // 0x0000000180671160-0x0000000180671200
	public static Matrix4x4 ScalingMatrix(Vector3 xyz); // 0x0000000180670FD0-0x0000000180671090
	public static Matrix4x4 ScalingMatrix(float x, float y, float z); // 0x0000000180671090-0x0000000180671160
	public static float DampenFactor(float dampening, float elapsed); // 0x00000001806703B0-0x0000000180670440
	public static Quaternion Dampen(Quaternion current, Quaternion target, float dampening, float elapsed, float minStep = 0f /* Metadata: 0x0077C481 */); // 0x0000000180670440-0x0000000180670600
	public static float Dampen(float current, float target, float dampening, float elapsed, float minStep = 0f /* Metadata: 0x0077C485 */); // 0x0000000180670600-0x0000000180670760
	public static Vector3 Dampen3(Vector3 current, Vector3 target, float dampening, float elapsed, float minStep = 0f /* Metadata: 0x0077C489 */); // 0x0000000180670200-0x00000001806703B0
	public static Quaternion MoveTowards(Quaternion current, Quaternion target, float maxDelta); // 0x0000000180670B60-0x0000000180670C70
	public static float MoveTowards(float current, float target, float maxDelta); // 0x0000000180670C70-0x0000000180670D20
	public static Vector3 ClosestPointToLineSegment(Vector3 a, Vector3 b, Vector3 point); // 0x000000018066F8B0-0x000000018066FAF0
	public static Vector3 ClosestPointToTriangle(Vector3 a, Vector3 b, Vector3 c, Vector3 p); // 0x000000018066FAF0-0x0000000180670200
	public static Vector3 GetBarycentric(Vector2 a, Vector2 b, Vector2 c, Vector2 p); // 0x0000000180670920-0x0000000180670B60
	public static bool PointLeftOfLine(Vector2 a, Vector2 b, Vector2 p); // 0x0000000180670D20-0x0000000180670D80
	public static bool PointRightOfLine(Vector2 a, Vector2 b, Vector2 p); // 0x0000000180670D80-0x0000000180670DE0
	public static Vector2 VectorXY(Vector3 xyz); // 0x0000000180671670-0x00000001806716A0
}

