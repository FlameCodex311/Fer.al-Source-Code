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
	public class LongPlugin : ABSTweenPlugin<long, long, NoOptions> // TypeDefIndex: 5620
	{
		// Constructors
		public LongPlugin(); // 0x0000000180BCE5F0-0x0000000180BCE630
	
		// Methods
		public override void Reset(TweenerCore<long, long, NoOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, bool isRelative); // 0x0000000180BCE510-0x0000000180BCE5C0
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, long fromValue, bool setImmediately); // 0x0000000180BCE490-0x0000000180BCE510
		public override long ConvertToStartValue(TweenerCore<long, long, NoOptions> t, long value); // 0x0000000180BCE250-0x0000000180BCE260
		public override void SetRelativeEndValue(TweenerCore<long, long, NoOptions> t); // 0x0000000180BCE5C0-0x0000000180BCE5F0
		public override void SetChangeValue(TweenerCore<long, long, NoOptions> t); // 0x0000000180BCE460-0x0000000180BCE490
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue); // 0x0000000180BCE440-0x0000000180BCE460
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<long> getter, DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180BCE260-0x0000000180BCE440
	}
}
