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
	public class RectOffsetPlugin : ABSTweenPlugin<RectOffset, RectOffset, NoOptions> // TypeDefIndex: 5786
	{
		// Fields
		private static RectOffset _r; // 0x00
	
		// Constructors
		public RectOffsetPlugin(); // 0x00000001818BE740-0x00000001818BE780
		static RectOffsetPlugin(); // 0x00000001818BE6E0-0x00000001818BE740
	
		// Methods
		public override void Reset(TweenerCore<RectOffset, RectOffset, NoOptions> t); // 0x00000001818BE120-0x00000001818BE150
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, bool isRelative); // 0x00000001818BE3A0-0x00000001818BE580
		public override void SetFrom(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset fromValue, bool setImmediately); // 0x00000001818BE320-0x00000001818BE3A0
		public override RectOffset ConvertToStartValue(TweenerCore<RectOffset, RectOffset, NoOptions> t, RectOffset value); // 0x00000001818BD810-0x00000001818BD8E0
		public override void SetRelativeEndValue(TweenerCore<RectOffset, RectOffset, NoOptions> t); // 0x00000001818BE580-0x00000001818BE6E0
		public override void SetChangeValue(TweenerCore<RectOffset, RectOffset, NoOptions> t); // 0x00000001818BE150-0x00000001818BE320
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, RectOffset changeValue); // 0x00000001818BE030-0x00000001818BE120
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, float elapsed, RectOffset startValue, RectOffset changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x00000001818BD8E0-0x00000001818BE030
	}
}
