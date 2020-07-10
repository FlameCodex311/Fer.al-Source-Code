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
	public class QuaternionPlugin : ABSTweenPlugin<Quaternion, Vector3, QuaternionOptions> // TypeDefIndex: 5626
	{
		// Constructors
		public QuaternionPlugin(); // 0x0000000180C3B360-0x0000000180C3B3A0
	
		// Methods
		public override void Reset(TweenerCore<Quaternion, Vector3, QuaternionOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool isRelative); // 0x0000000180C3ADB0-0x0000000180C3B190
		public override void SetFrom(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Vector3 fromValue, bool setImmediately); // 0x0000000180C3B190-0x0000000180C3B270
		public override Vector3 ConvertToStartValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t, Quaternion value); // 0x0000000180C3A4D0-0x0000000180C3A500
		public override void SetRelativeEndValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t); // 0x0000000180C3B270-0x0000000180C3B360
		public override void SetChangeValue(TweenerCore<Quaternion, Vector3, QuaternionOptions> t); // 0x0000000180C3AB10-0x0000000180C3ADB0
		public override float GetSpeedBasedDuration(QuaternionOptions options, float unitsXSecond, Vector3 changeValue); // 0x0000000180C3AAE0-0x0000000180C3AB10
		public override void EvaluateAndApply(QuaternionOptions options, Tween t, bool isRelative, DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180C3A500-0x0000000180C3AAE0
	}
}
