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
	public class ColorPlugin : ABSTweenPlugin<Color, Color, ColorOptions> // TypeDefIndex: 5783
	{
		// Constructors
		public ColorPlugin(); // 0x0000000181784A00-0x0000000181784C70
	
		// Methods
		public override void Reset(TweenerCore<Color, Color, ColorOptions> t); // 0x00000001803774A0-0x00000001803774B0
		public override void SetFrom(TweenerCore<Color, Color, ColorOptions> t, bool isRelative); // 0x0000000181784880-0x00000001817849A0
		public override void SetFrom(TweenerCore<Color, Color, ColorOptions> t, Color fromValue, bool setImmediately); // 0x00000001817847A0-0x0000000181784880
		public override Color ConvertToStartValue(TweenerCore<Color, Color, ColorOptions> t, Color value); // 0x0000000181784430-0x0000000181784440
		public override void SetRelativeEndValue(TweenerCore<Color, Color, ColorOptions> t); // 0x00000001817849A0-0x0000000181784A00
		public override void SetChangeValue(TweenerCore<Color, Color, ColorOptions> t); // 0x0000000181784740-0x00000001817847A0
		public override float GetSpeedBasedDuration(ColorOptions options, float unitsXSecond, Color changeValue); // 0x0000000181783CF0-0x0000000181783D00
		public override void EvaluateAndApply(ColorOptions options, Tween t, bool isRelative, DOGetter<Color> getter, DOSetter<Color> setter, float elapsed, Color startValue, Color changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000181784440-0x0000000181784740
	}
}
