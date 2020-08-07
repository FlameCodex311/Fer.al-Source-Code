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
	public class UlongPlugin : ABSTweenPlugin<ulong, ulong, NoOptions> // TypeDefIndex: 5780
	{
		// Constructors
		public UlongPlugin(); // 0x00000001818CCB00-0x00000001818CCB40
	
		// Methods
		public override void Reset(TweenerCore<ulong, ulong, NoOptions> t); // 0x00000001803774A0-0x00000001803774B0
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, bool isRelative); // 0x00000001818CCA50-0x00000001818CCB00
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, ulong fromValue, bool setImmediately); // 0x00000001818CC9D0-0x00000001818CCA50
		public override ulong ConvertToStartValue(TweenerCore<ulong, ulong, NoOptions> t, ulong value); // 0x0000000180766BD0-0x0000000180766BE0
		public override void SetRelativeEndValue(TweenerCore<ulong, ulong, NoOptions> t); // 0x00000001817917B0-0x00000001817917E0
		public override void SetChangeValue(TweenerCore<ulong, ulong, NoOptions> t); // 0x0000000181791650-0x0000000181791680
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, ulong changeValue); // 0x00000001818CC990-0x00000001818CC9D0
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<ulong> getter, DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x00000001818CC710-0x00000001818CC990
	}
}
