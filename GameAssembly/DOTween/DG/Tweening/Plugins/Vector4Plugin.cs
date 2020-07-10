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
	public class Vector4Plugin : ABSTweenPlugin<Vector4, Vector4, VectorOptions> // TypeDefIndex: 5631
	{
		// Constructors
		public Vector4Plugin(); // 0x0000000180C4E1B0-0x0000000180C4E200
	
		// Methods
		public override void Reset(TweenerCore<Vector4, Vector4, VectorOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, bool isRelative); // 0x0000000180C4DEA0-0x0000000180C4E100
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 fromValue, bool setImmediately); // 0x0000000180C4DC10-0x0000000180C4DEA0
		public override Vector4 ConvertToStartValue(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 value); // 0x0000000180BC0D10-0x0000000180BC0D20
		public override void SetRelativeEndValue(TweenerCore<Vector4, Vector4, VectorOptions> t); // 0x0000000180C4E100-0x0000000180C4E1B0
		public override void SetChangeValue(TweenerCore<Vector4, Vector4, VectorOptions> t); // 0x0000000180C4DA80-0x0000000180C4DC10
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue); // 0x0000000180C4DA50-0x0000000180C4DA80
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector4> getter, DOSetter<Vector4> setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180C4D3F0-0x0000000180C4DA50
	}
}
