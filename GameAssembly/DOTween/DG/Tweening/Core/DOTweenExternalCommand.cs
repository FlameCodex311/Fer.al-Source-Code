/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening.Core
{
	public static class DOTweenExternalCommand // TypeDefIndex: 5677
	{
		// Fields
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private static Action<PathOptions, Tween, Quaternion, Transform> SetOrientationOnPath; // 0x00
	
		// Events
		public static event Action<PathOptions, Tween, Quaternion, Transform> SetOrientationOnPath {
			add; // 0x0000000180BC4110-0x0000000180BC41C0
			remove; // 0x0000000180BC41C0-0x0000000180BC4270
		}
	
		// Methods
		internal static void Dispatch_SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans); // 0x0000000180BC4030-0x0000000180BC4110
	}
}
