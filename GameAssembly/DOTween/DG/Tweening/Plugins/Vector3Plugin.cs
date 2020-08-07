/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Plugins
{
	public class Vector3Plugin : ABSTweenPlugin<Vector3, Vector3, VectorOptions> // TypeDefIndex: 5794
	{
		// Constructors
		public Vector3Plugin(); // 0x00000001818CF4F0-0x00000001818CF530
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Vector3, VectorOptions> t); // 0x00000001803774A0-0x00000001803774B0
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, bool isRelative); // 0x00000001818CEF50-0x00000001818CF190
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 fromValue, bool setImmediately); // 0x00000001818CF190-0x00000001818CF410
		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 value); // 0x00000001818CE710-0x00000001818CE730
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, VectorOptions> t); // 0x00000001818CF410-0x00000001818CF4F0
		public override void SetChangeValue(TweenerCore<Vector3, Vector3, VectorOptions> t); // 0x00000001818CEDD0-0x00000001818CEF50
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue); // 0x00000001818BCF60-0x00000001818BCF90
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x00000001818CE730-0x00000001818CEDD0
	}
}
