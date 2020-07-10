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
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening.Plugins
{
	public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions> // TypeDefIndex: 5623
	{
		// Fields
		public const float MinLookAhead = 0.0001f; // Metadata: 0x0072E7F8
	
		// Constructors
		public PathPlugin(); // 0x0000000180C3A490-0x0000000180C3A4D0
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Path, PathOptions> t); // 0x0000000180C387C0-0x0000000180C38810
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative); // 0x00000001803581E0-0x00000001803581F0
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, Path fromValue, bool setImmediately); // 0x00000001803581E0-0x00000001803581F0
		public static ABSTweenPlugin<Vector3, Path, PathOptions> Get(); // 0x0000000180C38790-0x0000000180C387C0
		public override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value); // 0x0000000180C38340-0x0000000180C38360
		public override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t); // 0x0000000180C3A2A0-0x0000000180C3A490
		public override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t); // 0x0000000180C38810-0x0000000180C38E10
		public override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue); // 0x0000000180C38770-0x0000000180C38790
		public override void EvaluateAndApply(PathOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x0000000180C38360-0x0000000180C38770
		public void SetOrientation(PathOptions options, Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice); // 0x0000000180C38E10-0x0000000180C3A2A0
	}
}
