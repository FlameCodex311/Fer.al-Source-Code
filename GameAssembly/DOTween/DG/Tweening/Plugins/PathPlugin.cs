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

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening.Plugins
{
	public class PathPlugin : ABSTweenPlugin<Vector3, Path, PathOptions> // TypeDefIndex: 5782
	{
		// Fields
		public const float MinLookAhead = 0.0001f; // Metadata: 0x00763495
	
		// Constructors
		public PathPlugin(); // 0x00000001818BC910-0x00000001818BC950
	
		// Methods
		public override void Reset(TweenerCore<Vector3, Path, PathOptions> t); // 0x00000001818BACB0-0x00000001818BAD00
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, bool isRelative); // 0x00000001803774A0-0x00000001803774B0
		public override void SetFrom(TweenerCore<Vector3, Path, PathOptions> t, Path fromValue, bool setImmediately); // 0x00000001803774A0-0x00000001803774B0
		public static ABSTweenPlugin<Vector3, Path, PathOptions> Get(); // 0x00000001818BAC80-0x00000001818BACB0
		public override Path ConvertToStartValue(TweenerCore<Vector3, Path, PathOptions> t, Vector3 value); // 0x00000001818BA840-0x00000001818BA860
		public override void SetRelativeEndValue(TweenerCore<Vector3, Path, PathOptions> t); // 0x00000001818BC730-0x00000001818BC910
		public override void SetChangeValue(TweenerCore<Vector3, Path, PathOptions> t); // 0x00000001818BAD00-0x00000001818BB2D0
		public override float GetSpeedBasedDuration(PathOptions options, float unitsXSecond, Path changeValue); // 0x00000001818BAC60-0x00000001818BAC80
		public override void EvaluateAndApply(PathOptions options, Tween t, bool isRelative, DOGetter<Vector3> getter, DOSetter<Vector3> setter, float elapsed, Path startValue, Path changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice); // 0x00000001818BA860-0x00000001818BAC60
		public void SetOrientation(PathOptions options, Tween t, Path path, float pathPerc, Vector3 tPos, UpdateNotice updateNotice); // 0x00000001818BB2D0-0x00000001818BC730
	}
}
