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
	public class Vector2Plugin : ABSTweenPlugin<Vector2, Vector2, VectorOptions> // TypeDefIndex: 5630
	{
		// Constructors
		public Vector2Plugin(); // 0x0000000180C4B2D0-0x0000000180C4B320
	
		// Methods
		public override void Reset(TweenerCore<Vector2, Vector2, VectorOptions> t); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, bool isRelative); // 0x0000000180C4AEC0-0x0000000180C4B090
		public override void SetFrom(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 fromValue, bool setImmediately); // 0x0000000180C4B090-0x0000000180C4B200
		public override Vector2 ConvertToStartValue(TweenerCore<Vector2, Vector2, VectorOptions> t, Vector2 value); // 0x0000000180BCE250-0x0000000180BCE260
		public override void SetRelativeEndValue(TweenerCore<Vector2, Vector2, VectorOptions> t); // 0x0000000180C4B200-0x0000000180C4B2D0
		public override void SetChangeValue(TweenerCore<Vector2, Vector2, VectorOptions> t); // 0x0000000180C4AD90-0x0000000180C4AEC0
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector2 changeValue); // 0x0000000180C4AD60-0x0000000180C4AD90
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector2> getter, DOSetter<Vector2> setter, float elapsed, Vector2 startValue, Vector2 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180C4A900-0x0000000180C4AD60
	}
}
