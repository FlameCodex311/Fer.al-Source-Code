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
	public class LongPlugin : ABSTweenPlugin<long, long, NoOptions> // TypeDefIndex: 5779
	{
		// Constructors
		public LongPlugin(); // 0x00000001817917E0-0x0000000181791820
	
		// Methods
		public override void Reset(TweenerCore<long, long, NoOptions> t); // 0x00000001803774A0-0x00000001803774B0
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, bool isRelative); // 0x0000000181791700-0x00000001817917B0
		public override void SetFrom(TweenerCore<long, long, NoOptions> t, long fromValue, bool setImmediately); // 0x0000000181791680-0x0000000181791700
		public override long ConvertToStartValue(TweenerCore<long, long, NoOptions> t, long value); // 0x0000000180766BD0-0x0000000180766BE0
		public override void SetRelativeEndValue(TweenerCore<long, long, NoOptions> t); // 0x00000001817917B0-0x00000001817917E0
		public override void SetChangeValue(TweenerCore<long, long, NoOptions> t); // 0x0000000181791650-0x0000000181791680
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, long changeValue); // 0x0000000181791630-0x0000000181791650
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<long> getter, DOSetter<long> setter, float elapsed, long startValue, long changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000181791450-0x0000000181791630
	}
}
