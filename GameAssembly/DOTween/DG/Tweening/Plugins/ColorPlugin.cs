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
	public class ColorPlugin : ABSTweenPlugin<Color, Color, ColorOptions> // TypeDefIndex: 5624
	{
		// Constructors
		public ColorPlugin(); // 0x0000000180BC12E0-0x0000000180BC1570
	
		// Methods
		public override void Reset(TweenerCore<Color, Color, ColorOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<Color, Color, ColorOptions> t, bool isRelative); // 0x0000000180BC1160-0x0000000180BC1280
		public override void SetFrom(TweenerCore<Color, Color, ColorOptions> t, Color fromValue, bool setImmediately); // 0x0000000180BC1080-0x0000000180BC1160
		public override Color ConvertToStartValue(TweenerCore<Color, Color, ColorOptions> t, Color value); // 0x0000000180BC0D10-0x0000000180BC0D20
		public override void SetRelativeEndValue(TweenerCore<Color, Color, ColorOptions> t); // 0x0000000180BC1280-0x0000000180BC12E0
		public override void SetChangeValue(TweenerCore<Color, Color, ColorOptions> t); // 0x0000000180BC1020-0x0000000180BC1080
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color changeValue); // 0x0000000180BC05D0-0x0000000180BC05E0
		public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color> getter, DOSetter<Color> setter, float elapsed, Color startValue, Color changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180BC0D20-0x0000000180BC1020
	}
}
