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

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Core
{
	public static class DOTweenExternalCommand // TypeDefIndex: 5836
	{
		// Fields
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private static Action<PathOptions, Tween, Quaternion, Transform> SetOrientationOnPath; // 0x00
	
		// Events
		public static event Action<PathOptions, Tween, Quaternion, Transform> SetOrientationOnPath {
			add; // 0x0000000181787780-0x0000000181787830
			remove; // 0x0000000181787830-0x00000001817878E0
		}
	
		// Methods
		internal static void Dispatch_SetOrientationOnPath(PathOptions options, Tween t, Quaternion newRot, Transform trans); // 0x00000001817876A0-0x0000000181787780
	}
}
