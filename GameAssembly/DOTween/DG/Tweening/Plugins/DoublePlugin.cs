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
	public class DoublePlugin : ABSTweenPlugin<double, double, NoOptions> // TypeDefIndex: 5619
	{
		// Constructors
		public DoublePlugin(); // 0x0000000180BCA140-0x0000000180BCA180
	
		// Methods
		public override void Reset(TweenerCore<double, double, NoOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, bool isRelative); // 0x0000000180BCA050-0x0000000180BCA110
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, double fromValue, bool setImmediately); // 0x0000000180BC9FD0-0x0000000180BCA050
		public override double ConvertToStartValue(TweenerCore<double, double, NoOptions> t, double value); // 0x0000000180BC9DB0-0x0000000180BC9DC0
		public override void SetRelativeEndValue(TweenerCore<double, double, NoOptions> t); // 0x0000000180BCA110-0x0000000180BCA140
		public override void SetChangeValue(TweenerCore<double, double, NoOptions> t); // 0x0000000180BC9FA0-0x0000000180BC9FD0
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue); // 0x0000000180BC9F80-0x0000000180BC9FA0
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<double> getter, DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180BC9DC0-0x0000000180BC9F80
	}
}
