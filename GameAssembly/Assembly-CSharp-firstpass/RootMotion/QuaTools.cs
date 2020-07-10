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
	public static class QuaTools // TypeDefIndex: 9321
	{
		// Methods
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight); // 0x0000000182283B00-0x0000000182283BD0
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight); // 0x0000000182283F00-0x0000000182283FD0
		public static Quaternion LinearBlend(Quaternion q, float weight); // 0x0000000182283BD0-0x0000000182283CC0
		public static Quaternion SphericalBlend(Quaternion q, float weight); // 0x0000000182283FD0-0x00000001822840C0
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis); // 0x0000000182283510-0x00000001822836D0
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation); // 0x0000000182283E30-0x0000000182283F00
		public static Quaternion FromToRotation(Quaternion from, Quaternion to); // 0x00000001822836D0-0x00000001822837F0
		public static Vector3 GetAxis(Vector3 v); // 0x00000001822837F0-0x0000000182283B00
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing); // 0x0000000182283280-0x0000000182283510
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing); // 0x00000001822830A0-0x0000000182283280
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis); // 0x0000000182283CC0-0x0000000182283E30
	}
}
