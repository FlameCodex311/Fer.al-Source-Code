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
	public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions> // TypeDefIndex: 5789
	{
		// Constructors
		public Vector2Plugin(); // 0x00000001818CD4F0-0x00000001818CD540
	
		// Methods
		public override void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t); // 0x00000001803774A0-0x00000001803774B0
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, bool isRelative); // 0x00000001818CD0E0-0x00000001818CD2B0
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 fromValue, bool setImmediately); // 0x00000001818CD2B0-0x00000001818CD420
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value); // 0x0000000180766BD0-0x0000000180766BE0
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t); // 0x00000001818CD420-0x00000001818CD4F0
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t); // 0x00000001818CCFC0-0x00000001818CD0E0
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue); // 0x00000001818CCF90-0x00000001818CCFC0
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x00000001818CCB40-0x00000001818CCF90
	}
}
