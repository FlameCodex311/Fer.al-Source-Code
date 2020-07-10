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

// Image 60: DOTween.Modules.dll - Assembly: DOTween.Modules, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 7420-7499

namespace DG.Tweening
{
	public static class DOTweenModuleUtils // TypeDefIndex: 7498
	{
		// Fields
		private static bool _initialized; // 0x00
	
		// Nested types
		public static class Physics // TypeDefIndex: 7499
		{
			// Methods
			public static void SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans); // 0x000000018227E850-0x000000018227E9B0
			public static bool HasRigidbody2D(Component target); // 0x000000018227E750-0x000000018227E7D0
			[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
			public static bool HasRigidbody(Component target); // 0x000000018227E7D0-0x000000018227E850
			[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
			public static TweenerCore<Vector3, Path, PathOptions> CreateDOTweenPathTween(UnityEngine.MonoBehaviour target, bool tweenRigidbody, bool isLocal, Path path, float duration, PathMode pathMode); // 0x000000018227E3A0-0x000000018227E750
		}
	
		// Methods
		[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
		public static void Init(); // 0x000000018227E280-0x000000018227E300
		[Preserve] // 0x00000001800B36B0-0x00000001800B36C0
		private static void Preserver(); // 0x000000018227E300-0x000000018227E3A0
	}
}
