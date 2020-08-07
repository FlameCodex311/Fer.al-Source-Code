/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Core
{
	internal static class Utils // TypeDefIndex: 5843
	{
		// Fields
		private static Assembly[] _loadedAssemblies; // 0x00
		private static readonly string[] _defAssembliesToQuery; // 0x08
	
		// Constructors
		static Utils(); // 0x000000018179BCF0-0x00000001817BD970
	
		// Methods
		internal static Vector3 Vector3FromAngle(float degrees, float magnitude); // 0x000000018179BC30-0x000000018179BCF0
		internal static float Angle2D(Vector3 from, Vector3 to); // 0x000000018179B540-0x000000018179B6C0
		internal static Vector3 RotateAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation); // 0x000000018179B9D0-0x000000018179BB20
		internal static bool Vector3AreApproximatelyEqual(Vector3 a, Vector3 b); // 0x000000018179BB20-0x000000018179BC30
		internal static Type GetLooseScriptType(string typeName); // 0x000000018179B6C0-0x000000018179B9D0
	}
}
