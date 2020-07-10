/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Cinemachine.dll - Assembly: Cinemachine, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7252-7414

namespace Cinemachine.Utility
{
	public static class UnityQuaternionExtensions // TypeDefIndex: 7412
	{
		// Methods
		public static Quaternion SlerpWithReferenceUp(Quaternion qA, Quaternion qB, float t, Vector3 up); // 0x00000001822C40C0-0x00000001822C45D0
	
		// Extension methods
		public static Quaternion Normalized(this Quaternion q); // 0x00000001822C4020-0x00000001822C40C0
		public static Vector2 GetCameraRotationToTarget(this Quaternion orient, Vector3 lookAtDir, Vector3 worldUp); // 0x00000001822C3AA0-0x00000001822C4020
		public static Quaternion ApplyCameraRotation(this Quaternion orient, Vector2 rot, Vector3 worldUp); // 0x00000001822C3950-0x00000001822C3AA0
	}
}
