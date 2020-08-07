/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace RootMotion
{
	public class AxisTools // TypeDefIndex: 9759
	{
		// Constructors
		public AxisTools(); // 0x0000000180373240-0x0000000180373250
	
		// Methods
		public static Vector3 ToVector3(Axis axis); // 0x0000000180D1A410-0x0000000180D1A4E0
		public static Axis ToAxis(Vector3 v); // 0x0000000180D1A370-0x0000000180D1A410
		public static Axis GetAxisToPoint(Transform t, Vector3 worldPosition); // 0x0000000180D19D90-0x0000000180D19F60
		public static Axis GetAxisToDirection(Transform t, Vector3 direction); // 0x0000000180D19C40-0x0000000180D19D90
		public static Vector3 GetAxisVectorToPoint(Transform t, Vector3 worldPosition); // 0x0000000180D1A260-0x0000000180D1A370
		public static Vector3 GetAxisVectorToDirection(Transform t, Vector3 direction); // 0x0000000180D19F60-0x0000000180D1A260
	}
}
