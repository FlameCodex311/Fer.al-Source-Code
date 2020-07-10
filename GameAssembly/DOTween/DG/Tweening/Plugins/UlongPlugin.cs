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
	public class UlongPlugin : ABSTweenPlugin<ulong, ulong, NoOptions> // TypeDefIndex: 5621
	{
		// Constructors
		public UlongPlugin(); // 0x0000000180C4A8C0-0x0000000180C4A900
	
		// Methods
		public override void Reset(TweenerCore<ulong, ulong, NoOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, bool isRelative); // 0x0000000180C4A810-0x0000000180C4A8C0
		public override void SetFrom(TweenerCore<ulong, ulong, NoOptions> t, ulong fromValue, bool setImmediately); // 0x0000000180C4A790-0x0000000180C4A810
		public override ulong ConvertToStartValue(TweenerCore<ulong, ulong, NoOptions> t, ulong value); // 0x0000000180BCE250-0x0000000180BCE260
		public override void SetRelativeEndValue(TweenerCore<ulong, ulong, NoOptions> t); // 0x0000000180BCE5C0-0x0000000180BCE5F0
		public override void SetChangeValue(TweenerCore<ulong, ulong, NoOptions> t); // 0x0000000180BCE460-0x0000000180BCE490
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, ulong changeValue); // 0x0000000180C4A750-0x0000000180C4A790
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<ulong> getter, DOSetter<ulong> setter, float elapsed, ulong startValue, ulong changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180C4A4D0-0x0000000180C4A750
	}
}
