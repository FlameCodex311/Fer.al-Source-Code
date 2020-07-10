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
	internal class Color2Plugin : ABSTweenPlugin<Color2, Color2, ColorOptions> // TypeDefIndex: 5618
	{
		// Constructors
		public Color2Plugin(); // 0x0000000180BC0AB0-0x0000000180BC0B00
	
		// Methods
		public override void Reset(TweenerCore<Color2, Color2, ColorOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, bool isRelative); // 0x0000000180BC06D0-0x0000000180BC08A0
		public override void SetFrom(TweenerCore<Color2, Color2, ColorOptions> t, Color2 fromValue, bool setImmediately); // 0x0000000180BC08A0-0x0000000180BC09C0
		public override Color2 ConvertToStartValue(TweenerCore<Color2, Color2, ColorOptions> t, Color2 value); // 0x0000000180BC0080-0x0000000180BC00A0
		public override void SetRelativeEndValue(TweenerCore<Color2, Color2, ColorOptions> t); // 0x0000000180BC09C0-0x0000000180BC0AB0
		public override void SetChangeValue(TweenerCore<Color2, Color2, ColorOptions> t); // 0x0000000180BC05E0-0x0000000180BC06D0
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color2 changeValue); // 0x0000000180BC05D0-0x0000000180BC05E0
		public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color2> getter, DOSetter<Color2> setter, float elapsed, Color2 startValue, Color2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180BC00A0-0x0000000180BC05D0
	}
}
