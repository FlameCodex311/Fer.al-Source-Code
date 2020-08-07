/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;
using UnityEngine.Scripting;

// Image 61: DOTween.Modules.dll - Assembly: DOTween.Modules, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7586-7665

namespace DG.Tweening
{
	public static class DOTweenModuleUtils // TypeDefIndex: 7664
	{
		// Fields
		private static bool _initialized; // 0x00
	
		// Nested types
		public static class Physics // TypeDefIndex: 7665
		{
			// Methods
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans); // 0x0000000181FEFD70-0x0000000181FEFEC0
			public static bool HasRigidbody2D(Component target); // 0x0000000181FEFC70-0x0000000181FEFCF0
			[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
			public static bool HasRigidbody(Component target); // 0x0000000181FEFCF0-0x0000000181FEFD70
			[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(UnityEngine.MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode); // 0x0000000181FEF8D0-0x0000000181FEFC70
		}
	
		// Methods
		[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
		public static void Init(); // 0x0000000181FEF7B0-0x0000000181FEF830
		[Preserve] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static void Preserver(); // 0x0000000181FEF830-0x0000000181FEF8D0
	}
}
