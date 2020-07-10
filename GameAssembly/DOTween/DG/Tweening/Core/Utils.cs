/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening.Core
{
	internal static class Utils // TypeDefIndex: 5684
	{
		// Fields
		private static Assembly[] _loadedAssemblies; // 0x00
		private static readonly string[] _defAssembliesToQuery; // 0x08
	
		// Constructors
		static Utils(); // 0x0000000180BD8D00-0x0000000180BD8E80
	
		// Methods
		internal static Vector3 Vector3FromAngle(float degrees, float magnitude); // 0x0000000180BD8C40-0x0000000180BD8D00
		internal static float Angle2D(Vector3 from, Vector3 to); // 0x0000000180BD8540-0x0000000180BD86C0
		internal static Vector3 RotateAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation); // 0x0000000180BD89E0-0x0000000180BD8B30
		internal static bool Vector3AreApproximatelyEqual(Vector3 a, Vector3 b); // 0x0000000180BD8B30-0x0000000180BD8C40
		internal static Type GetLooseScriptType(string typeName); // 0x0000000180BD86C0-0x0000000180BD89E0
	}
}
