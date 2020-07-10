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
	public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions> // TypeDefIndex: 5627
	{
		// Fields
		private static RectOffset _r; // 0x00
	
		// Constructors
		public RectOffsetPlugin(); // 0x0000000180C3C310-0x0000000180C3C350
		static RectOffsetPlugin(); // 0x0000000180C3C2B0-0x0000000180C3C310
	
		// Methods
		public override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t); // 0x0000000180C3BCD0-0x0000000180C3BD00
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, bool isRelative); // 0x0000000180C3BF50-0x0000000180C3C140
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset fromValue, bool setImmediately); // 0x0000000180C3BED0-0x0000000180C3BF50
		public override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value); // 0x0000000180C3B3A0-0x0000000180C3B470
		public override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t); // 0x0000000180C3C140-0x0000000180C3C2B0
		public override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t); // 0x0000000180C3BD00-0x0000000180C3BED0
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue); // 0x0000000180C3BBE0-0x0000000180C3BCD0
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180C3B470-0x0000000180C3BBE0
	}
}
