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

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening.Plugins
{
	public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions> // TypeDefIndex: 5628
	{
		// Constructors
		public RectPlugin(); // 0x0000000180C3CF20-0x0000000180C3CF60
	
		// Methods
		public override void Reset(TweenerCore<Rect, Rect, RectOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative); // 0x0000000180C3CA30-0x0000000180C3CCA0
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, Rect fromValue, bool setImmediately); // 0x0000000180C3CCA0-0x0000000180C3CE30
		public override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value); // 0x0000000180BC0D10-0x0000000180BC0D20
		public override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t); // 0x0000000180C3CE30-0x0000000180C3CF20
		public override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t); // 0x0000000180C3C8C0-0x0000000180C3CA30
		public override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue); // 0x0000000180C3C810-0x0000000180C3C8C0
		public override void EvaluateAndApply(RectOptions options, Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180C3C350-0x0000000180C3C810
	}
}
