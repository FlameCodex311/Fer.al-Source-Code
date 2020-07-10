/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace RootMotion
{
	public class AxisTools // TypeDefIndex: 9305
	{
		// Constructors
		public AxisTools(); // 0x000000018036B6C0-0x000000018036B6D0
	
		// Methods
		public static Vector3 ToVector3(Axis axis); // 0x000000018163B140-0x000000018163B210
		public static Axis ToAxis(Vector3 v); // 0x000000018163B0A0-0x000000018163B140
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition); // 0x000000018163AAC0-0x000000018163AC90
		public static Axis GetAxisToDirection(Transform t, Vector3 direction); // 0x000000018163A970-0x000000018163AAC0
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition); // 0x000000018163AF90-0x000000018163B0A0
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction); // 0x000000018163AC90-0x000000018163AF90
	}
}
