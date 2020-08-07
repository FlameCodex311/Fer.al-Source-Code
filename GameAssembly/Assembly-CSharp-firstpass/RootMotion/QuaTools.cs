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
	public static class QuaTools // TypeDefIndex: 9775
	{
		// Methods
		public static Quaternion Lerp(Quaternion fromRotation, Quaternion toRotation, float weight); // 0x000000018201F3E0-0x000000018201F4B0
		public static Quaternion Slerp(Quaternion fromRotation, Quaternion toRotation, float weight); // 0x000000018201F7E0-0x000000018201F8B0
		public static Quaternion LinearBlend(Quaternion q, float weight); // 0x000000018201F4B0-0x000000018201F5A0
		public static Quaternion SphericalBlend(Quaternion q, float weight); // 0x000000018201F8B0-0x000000018201F9A0
		public static Quaternion FromToAroundAxis(Vector3 fromDirection, Vector3 toDirection, Vector3 axis); // 0x000000018201EDF0-0x000000018201EFB0
		public static Quaternion RotationToLocalSpace(Quaternion space, Quaternion rotation); // 0x000000018201F710-0x000000018201F7E0
		public static Quaternion FromToRotation(Quaternion from, Quaternion to); // 0x000000018201EFB0-0x000000018201F0D0
		public static Vector3 GetAxis(Vector3 v); // 0x000000018201F0D0-0x000000018201F3E0
		public static Quaternion ClampRotation(Quaternion rotation, float clampWeight, int clampSmoothing); // 0x000000018201EB60-0x000000018201EDF0
		public static float ClampAngle(float angle, float clampWeight, int clampSmoothing); // 0x000000018201E980-0x000000018201EB60
		public static Quaternion MatchRotation(Quaternion targetRotation, Vector3 targetforwardAxis, Vector3 targetUpAxis, Vector3 forwardAxis, Vector3 upAxis); // 0x000000018201F5A0-0x000000018201F710
	}
}
