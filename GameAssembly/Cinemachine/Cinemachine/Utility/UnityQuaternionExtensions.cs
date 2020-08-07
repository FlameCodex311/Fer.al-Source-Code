/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7418-7580

namespace Cinemachine.Utility
{
	public static class UnityQuaternionExtensions // TypeDefIndex: 7578
	{
		// Methods
		public static Quaternion SlerpWithReferenceUp(Quaternion qA, Quaternion qB, float t, Vector3 up); // 0x0000000181FFA190-0x0000000181FFA6A0
	
		// Extension methods
		public static Quaternion Normalized(this Quaternion q); // 0x0000000181FFA0F0-0x0000000181FFA190
		public static Vector2 GetCameraRotationToTarget(this Quaternion orient, Vector3 lookAtDir, Vector3 worldUp); // 0x0000000181FF9B70-0x0000000181FFA0F0
		public static Quaternion ApplyCameraRotation(this Quaternion orient, Vector2 rot, Vector3 worldUp); // 0x0000000181FF9A20-0x0000000181FF9B70
	}
}
