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

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Plugins
{
	public class FloatPlugin : ABSTweenPlugin<float, float, FloatOptions> // TypeDefIndex: 5793
	{
		// Constructors
		public FloatPlugin(); // 0x0000000181790AC0-0x0000000181790B00
	
		// Methods
		public override void Reset(TweenerCore<float, float, FloatOptions> t); // 0x00000001803774A0-0x00000001803774B0
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, bool isRelative); // 0x00000001817908C0-0x00000001817909D0
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, float fromValue, bool setImmediately); // 0x00000001817909D0-0x0000000181790A90
		public override float ConvertToStartValue(TweenerCore<float, float, FloatOptions> t, float value); // 0x000000018178D330-0x000000018178D340
		public override void SetRelativeEndValue(TweenerCore<float, float, FloatOptions> t); // 0x0000000181790A90-0x0000000181790AC0
		public override void SetChangeValue(TweenerCore<float, float, FloatOptions> t); // 0x0000000181790890-0x00000001817908C0
		public override float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue); // 0x0000000181790870-0x0000000181790890
		public override void EvaluateAndApply(FloatOptions options, Tween t, bool isRelative, DOGetter<float> getter, DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000181790660-0x0000000181790870
	}
}
