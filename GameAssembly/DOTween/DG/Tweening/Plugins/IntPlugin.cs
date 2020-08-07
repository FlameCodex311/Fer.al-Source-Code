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
	public class IntPlugin : ABSTweenPlugin<int, int, NoOptions> // TypeDefIndex: 5784
	{
		// Constructors
		public IntPlugin(); // 0x0000000181790E80-0x0000000181790EC0
	
		// Methods
		public override void Reset(TweenerCore<int, int, NoOptions> t); // 0x00000001803774A0-0x00000001803774B0
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, bool isRelative); // 0x0000000181790DB0-0x0000000181790E60
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, int fromValue, bool setImmediately); // 0x0000000181790D30-0x0000000181790DB0
		public override int ConvertToStartValue(TweenerCore<int, int, NoOptions> t, int value); // 0x0000000181790B00-0x0000000181790B10
		public override void SetRelativeEndValue(TweenerCore<int, int, NoOptions> t); // 0x0000000181790E60-0x0000000181790E80
		public override void SetChangeValue(TweenerCore<int, int, NoOptions> t); // 0x0000000181790D00-0x0000000181790D30
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue); // 0x0000000181790CE0-0x0000000181790D00
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<int> getter, DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000181790B10-0x0000000181790CE0
	}
}
