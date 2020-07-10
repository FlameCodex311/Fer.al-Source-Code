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
	public class UintPlugin : ABSTweenPlugin<uint, uint, UintOptions> // TypeDefIndex: 5629
	{
		// Constructors
		public UintPlugin(); // 0x0000000180C4A490-0x0000000180C4A4D0
	
		// Methods
		public override void Reset(TweenerCore<uint, uint, UintOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, bool isRelative); // 0x0000000180C4A360-0x0000000180C4A410
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, uint fromValue, bool setImmediately); // 0x0000000180C4A410-0x0000000180C4A490
		public override uint ConvertToStartValue(TweenerCore<uint, uint, UintOptions> t, uint value); // 0x0000000180BCD8A0-0x0000000180BCD8B0
		public override void SetRelativeEndValue(TweenerCore<uint, uint, UintOptions> t); // 0x0000000180BCDC00-0x0000000180BCDC30
		public override void SetChangeValue(TweenerCore<uint, uint, UintOptions> t); // 0x0000000180C4A300-0x0000000180C4A360
		public override float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue); // 0x0000000180C4A2D0-0x0000000180C4A300
		public override void EvaluateAndApply(UintOptions options, Tween t, bool isRelative, DOGetter<uint> getter, DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180C4A0B0-0x0000000180C4A2D0
	}
}
