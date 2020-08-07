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
	public class Vector4Plugin : ABSTweenPlugin<Vector4, Vector4, VectorOptions> // TypeDefIndex: 5790
	{
		// Constructors
		public Vector4Plugin(); // 0x00000001818D02E0-0x00000001818D0330
	
		// Methods
		public override void Reset(TweenerCore<Vector4, Vector4, VectorOptions> t); // 0x00000001803774A0-0x00000001803774B0
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, bool isRelative); // 0x00000001818CFFD0-0x00000001818D0230
		public override void SetFrom(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 fromValue, bool setImmediately); // 0x00000001818CFD50-0x00000001818CFFD0
		public override Vector4 ConvertToStartValue(TweenerCore<Vector4, Vector4, VectorOptions> t, Vector4 value); // 0x0000000181784430-0x0000000181784440
		public override void SetRelativeEndValue(TweenerCore<Vector4, Vector4, VectorOptions> t); // 0x00000001818D0230-0x00000001818D02E0
		public override void SetChangeValue(TweenerCore<Vector4, Vector4, VectorOptions> t); // 0x00000001818CFBC0-0x00000001818CFD50
		public override float GetSpeedBasedDuration(VectorOptions options, float unitsXSecond, Vector4 changeValue); // 0x00000001818CFB90-0x00000001818CFBC0
		public override void EvaluateAndApply(VectorOptions options, Tween t, bool isRelative, DOGetter<Vector4> getter, DOSetter<Vector4> setter, float elapsed, Vector4 startValue, Vector4 changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x00000001818CF530-0x00000001818CFB90
	}
}
