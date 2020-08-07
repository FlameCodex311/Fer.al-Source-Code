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
	public class RectPlugin : ABSTweenPlugin<Rect, Rect, RectOptions> // TypeDefIndex: 5787
	{
		// Constructors
		public RectPlugin(); // 0x00000001818BF330-0x00000001818BF370
	
		// Methods
		public override void Reset(TweenerCore<Rect, Rect, RectOptions> t); // 0x00000001803774A0-0x00000001803774B0
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, bool isRelative); // 0x00000001818BEE50-0x00000001818BF0C0
		public override void SetFrom(TweenerCore<Rect, Rect, RectOptions> t, Rect fromValue, bool setImmediately); // 0x00000001818BF0C0-0x00000001818BF240
		public override Rect ConvertToStartValue(TweenerCore<Rect, Rect, RectOptions> t, Rect value); // 0x0000000181784430-0x0000000181784440
		public override void SetRelativeEndValue(TweenerCore<Rect, Rect, RectOptions> t); // 0x00000001818BF240-0x00000001818BF330
		public override void SetChangeValue(TweenerCore<Rect, Rect, RectOptions> t); // 0x00000001818BECE0-0x00000001818BEE50
		public override float GetSpeedBasedDuration(RectOptions options, float unitsXSecond, Rect changeValue); // 0x00000001818BEC30-0x00000001818BECE0
		public override void EvaluateAndApply(RectOptions options, Tween t, bool isRelative, DOGetter<Rect> getter, DOSetter<Rect> setter, float elapsed, Rect startValue, Rect changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x00000001818BE780-0x00000001818BEC30
	}
}
