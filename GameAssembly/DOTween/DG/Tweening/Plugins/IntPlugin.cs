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
	public class IntPlugin : ABSTweenPlugin<int, int, NoOptions> // TypeDefIndex: 5625
	{
		// Constructors
		public IntPlugin(); // 0x0000000180BCDC30-0x0000000180BCDC70
	
		// Methods
		public override void Reset(TweenerCore<int, int, NoOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, bool isRelative); // 0x0000000180BCDB50-0x0000000180BCDC00
		public override void SetFrom(TweenerCore<int, int, NoOptions> t, int fromValue, bool setImmediately); // 0x0000000180BCDAD0-0x0000000180BCDB50
		public override int ConvertToStartValue(TweenerCore<int, int, NoOptions> t, int value); // 0x0000000180BCD8A0-0x0000000180BCD8B0
		public override void SetRelativeEndValue(TweenerCore<int, int, NoOptions> t); // 0x0000000180BCDC00-0x0000000180BCDC30
		public override void SetChangeValue(TweenerCore<int, int, NoOptions> t); // 0x0000000180BCDAA0-0x0000000180BCDAD0
		public override float GetSpeedBasedDuration(NoOptions options, float unitsXSecond, int changeValue); // 0x0000000180BCDA80-0x0000000180BCDAA0
		public override void EvaluateAndApply(NoOptions options, Tween t, bool isRelative, DOGetter<int> getter, DOSetter<int> setter, float elapsed, int startValue, int changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180BCD8B0-0x0000000180BCDA80
	}
}
