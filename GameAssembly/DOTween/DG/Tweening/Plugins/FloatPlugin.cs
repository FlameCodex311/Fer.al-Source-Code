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

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening.Plugins
{
	public class FloatPlugin : ABSTweenPlugin<float, float, FloatOptions> // TypeDefIndex: 5634
	{
		// Constructors
		public FloatPlugin(); // 0x0000000180BCD860-0x0000000180BCD8A0
	
		// Methods
		public override void Reset(TweenerCore<float, float, FloatOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, bool isRelative); // 0x0000000180BCD660-0x0000000180BCD770
		public override void SetFrom(TweenerCore<float, float, FloatOptions> t, float fromValue, bool setImmediately); // 0x0000000180BCD770-0x0000000180BCD830
		public override float ConvertToStartValue(TweenerCore<float, float, FloatOptions> t, float value); // 0x0000000180BC9DB0-0x0000000180BC9DC0
		public override void SetRelativeEndValue(TweenerCore<float, float, FloatOptions> t); // 0x0000000180BCD830-0x0000000180BCD860
		public override void SetChangeValue(TweenerCore<float, float, FloatOptions> t); // 0x0000000180BCD630-0x0000000180BCD660
		public override float GetSpeedBasedDuration(FloatOptions options, float unitsXSecond, float changeValue); // 0x0000000180BCD610-0x0000000180BCD630
		public override void EvaluateAndApply(FloatOptions options, Tween t, bool isRelative, DOGetter<float> getter, DOSetter<float> setter, float elapsed, float startValue, float changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180BCD400-0x0000000180BCD610
	}
}
