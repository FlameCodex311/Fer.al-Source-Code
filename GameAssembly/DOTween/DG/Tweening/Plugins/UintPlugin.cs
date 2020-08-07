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
	public class UintPlugin : ABSTweenPlugin<uint, uint, UintOptions> // TypeDefIndex: 5788
	{
		// Constructors
		public UintPlugin(); // 0x00000001818CC6D0-0x00000001818CC710
	
		// Methods
		public override void Reset(TweenerCore<uint, uint, UintOptions> t); // 0x00000001803774A0-0x00000001803774B0
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, bool isRelative); // 0x00000001818CC5A0-0x00000001818CC650
		public override void SetFrom(TweenerCore<uint, uint, UintOptions> t, uint fromValue, bool setImmediately); // 0x00000001818CC650-0x00000001818CC6D0
		public override uint ConvertToStartValue(TweenerCore<uint, uint, UintOptions> t, uint value); // 0x0000000181790B00-0x0000000181790B10
		public override void SetRelativeEndValue(TweenerCore<uint, uint, UintOptions> t); // 0x0000000181790E60-0x0000000181790E80
		public override void SetChangeValue(TweenerCore<uint, uint, UintOptions> t); // 0x00000001818CC540-0x00000001818CC5A0
		public override float GetSpeedBasedDuration(UintOptions options, float unitsXSecond, uint changeValue); // 0x00000001818CC510-0x00000001818CC540
		public override void EvaluateAndApply(UintOptions options, Tween t, bool isRelative, DOGetter<uint> getter, DOSetter<uint> setter, float elapsed, uint startValue, uint changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x00000001818CC300-0x00000001818CC510
	}
}
