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
	public class DoublePlugin : ABSTweenPlugin<double, double, NoOptions> // TypeDefIndex: 5778
	{
		// Constructors
		public DoublePlugin(); // 0x000000018178D6A0-0x000000018178D6E0
	
		// Methods
		public override void Reset(TweenerCore<double, double, NoOptions> t); // 0x00000001803774A0-0x00000001803774B0
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, bool isRelative); // 0x000000018178D5C0-0x000000018178D670
		public override void SetFrom(TweenerCore<double, double, NoOptions> t, double fromValue, bool setImmediately); // 0x000000018178D540-0x000000018178D5C0
		public override double ConvertToStartValue(TweenerCore<double, double, NoOptions> t, double value); // 0x000000018178D330-0x000000018178D340
		public override void SetRelativeEndValue(TweenerCore<double, double, NoOptions> t); // 0x000000018178D670-0x000000018178D6A0
		public override void SetChangeValue(TweenerCore<double, double, NoOptions> t); // 0x000000018178D510-0x000000018178D540
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, double changeValue); // 0x000000018178D4F0-0x000000018178D510
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<double> getter, DOSetter<double> setter, float elapsed, double startValue, double changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x000000018178D340-0x000000018178D4F0
	}
}
