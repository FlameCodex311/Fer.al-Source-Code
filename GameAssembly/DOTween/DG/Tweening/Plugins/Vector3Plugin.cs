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
	public class Vector3Plugin : ABSTweenPlugin<Vector3, Vector3, VectorOptions> // TypeDefIndex: 5635
	{
		// Constructors
		public Vector3Plugin(); // 0x0000000180C4D3B0-0x0000000180C4D3F0
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Vector3, VectorOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, bool isRelative); // 0x0000000180C4CE00-0x0000000180C4D040
		public override void SetFrom(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 fromValue, bool setImmediately); // 0x0000000180C4D040-0x0000000180C4D2C0
		public override Vector3 ConvertToStartValue(TweenerCore<Vector3, Vector3, VectorOptions> t, Vector3 value); // 0x0000000180C4C5A0-0x0000000180C4C5C0
		public override void SetRelativeEndValue(TweenerCore<Vector3, Vector3, VectorOptions> t); // 0x0000000180C4D2C0-0x0000000180C4D3B0
		public override void SetChangeValue(TweenerCore<Vector3, Vector3, VectorOptions> t); // 0x0000000180C4CC70-0x0000000180C4CE00
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector3 changeValue); // 0x0000000180C3AAE0-0x0000000180C3AB10
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Vector3 startValue, Vector3 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180C4C5C0-0x0000000180C4CC70
	}
}
