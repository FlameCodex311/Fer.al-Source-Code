/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Core.PathCore;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening
{
	public static class TweenSettingsExtensions // TypeDefIndex: 5771
	{
		// Extension methods
		public static T SetAutoKill<T>(this T t)
			where T : Tween;
		public static T SetAutoKill<T>(this T t, bool autoKillOnCompletion)
			where T : Tween;
		public static T SetId<T>(this T t, object objectId)
			where T : Tween;
		public static T SetId<T>(this T t, string stringId)
			where T : Tween;
		public static T SetId<T>(this T t, int intId)
			where T : Tween;
		public static T SetLink<T>(this T t, GameObject gameObject)
			where T : Tween;
		public static T SetLink<T>(this T t, GameObject gameObject, LinkBehaviour behaviour)
			where T : Tween;
		public static T SetTarget<T>(this T t, object target)
			where T : Tween;
		public static T SetLoops<T>(this T t, int loops)
			where T : Tween;
		public static T SetLoops<T>(this T t, int loops, LoopType loopType)
			where T : Tween;
		public static T SetEase<T>(this T t, Ease ease)
			where T : Tween;
		public static T SetEase<T>(this T t, Ease ease, float overshoot)
			where T : Tween;
		public static T SetEase<T>(this T t, Ease ease, float amplitude, float period)
			where T : Tween;
		public static T SetEase<T>(this T t, AnimationCurve animCurve)
			where T : Tween;
		public static T SetEase<T>(this T t, EaseFunction customEase)
			where T : Tween;
		public static T SetRecyclable<T>(this T t)
			where T : Tween;
		public static T SetRecyclable<T>(this T t, bool recyclable)
			where T : Tween;
		public static T SetUpdate<T>(this T t, bool isIndependentUpdate)
			where T : Tween;
		public static T SetUpdate<T>(this T t, UpdateType updateType)
			where T : Tween;
		public static T SetUpdate<T>(this T t, UpdateType updateType, bool isIndependentUpdate)
			where T : Tween;
		public static T OnStart<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnPlay<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnPause<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnRewind<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnUpdate<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnStepComplete<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnComplete<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnKill<T>(this T t, TweenCallback action)
			where T : Tween;
		public static T OnWaypointChange<T>(this T t, TweenCallback<int> action)
			where T : Tween;
		public static T SetAs<T>(this T t, Tween asTween)
			where T : Tween;
		public static T SetAs<T>(this T t, TweenParams tweenParams)
			where T : Tween;
		public static Sequence Append(this Sequence s, Tween t); // 0x000000018209B8F0-0x000000018209B940
		public static Sequence Prepend(this Sequence s, Tween t); // 0x000000018209BC20-0x000000018209BC70
		public static Sequence Join(this Sequence s, Tween t); // 0x000000018209BB50-0x000000018209BBA0
		public static Sequence Insert(this Sequence s, float atPosition, Tween t); // 0x000000018209BB00-0x000000018209BB50
		public static Sequence AppendInterval(this Sequence s, float interval); // 0x000000018209B8B0-0x000000018209B8F0
		public static Sequence PrependInterval(this Sequence s, float interval); // 0x000000018209BBE0-0x000000018209BC20
		public static Sequence AppendCallback(this Sequence s, TweenCallback callback); // 0x000000018209B870-0x000000018209B8B0
		public static Sequence PrependCallback(this Sequence s, TweenCallback callback); // 0x000000018209BBA0-0x000000018209BBE0
		public static Sequence InsertCallback(this Sequence s, float atPosition, TweenCallback callback); // 0x000000018209BAC0-0x000000018209BB00
		public static T From<T>(this T t)
			where T : Tweener;
		public static T From<T>(this T t, bool isRelative)
			where T : Tweener;
		public static TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately = true /* Metadata: 0x00763448 */)
			where TPlugOptions : struct, IPlugOptions;
		public static TweenerCore<Color, Color, ColorOptions> From(this TweenerCore<Color, Color, ColorOptions> t, float fromAlphaValue, bool setImmediately = true /* Metadata: 0x00763449 */); // 0x000000018209B940-0x000000018209BA00
		public static TweenerCore<Vector3, Vector3, VectorOptions> From(this TweenerCore<Vector3, Vector3, VectorOptions> t, float fromValue, bool setImmediately = true /* Metadata: 0x0076344A */); // 0x000000018209BA00-0x000000018209BAC0
		public static T SetDelay<T>(this T t, float delay)
			where T : Tween;
		public static T SetRelative<T>(this T t)
			where T : Tween;
		public static T SetRelative<T>(this T t, bool isRelative)
			where T : Tween;
		public static T SetSpeedBased<T>(this T t)
			where T : Tween;
		public static T SetSpeedBased<T>(this T t, bool isSpeedBased)
			where T : Tween;
		public static Tweener SetOptions(this TweenerCore<float, float, FloatOptions> t, bool snapping); // 0x000000018209BE90-0x000000018209BEB0
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping); // 0x000000018209BE30-0x000000018209BE50
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0076344B */); // 0x000000018209BDF0-0x000000018209BE10
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping); // 0x000000018209BDD0-0x000000018209BDF0
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0076344C */); // 0x000000018209BE10-0x000000018209BE30
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping); // 0x000000018209BF10-0x000000018209BF30
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0076344D */); // 0x000000018209BE70-0x000000018209BE90
		public static Tweener SetOptions(this TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true /* Metadata: 0x0076344E */); // 0x000000018209BDB0-0x000000018209BDD0
		public static Tweener SetOptions(this TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly); // 0x000000018209BE50-0x000000018209BE70
		public static Tweener SetOptions(this TweenerCore<Rect, Rect, RectOptions> t, bool snapping); // 0x000000018209BE50-0x000000018209BE70
		public static Tweener SetOptions(this TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = ScrambleMode.None /* Metadata: 0x0076344F */, string scrambleChars = null); // 0x000000018209BF30-0x000000018209C020
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping); // 0x000000018209BE30-0x000000018209BE50
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x00763453 */); // 0x000000018209BDF0-0x000000018209BE10
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = AxisConstraint.None /* Metadata: 0x00763454 */); // 0x000000018209BEB0-0x000000018209BEE0
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = AxisConstraint.None /* Metadata: 0x00763458 */, AxisConstraint lockRotation = AxisConstraint.None /* Metadata: 0x0076345C */); // 0x000000018209BEE0-0x000000018209BF10
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Vector3? forwardDirection = default, Vector3? up = default); // 0x000000018209BCE0-0x000000018209BD50
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Vector3? forwardDirection = default, Vector3? up = default); // 0x000000018209BD50-0x000000018209BDB0
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Vector3? forwardDirection = default, Vector3? up = default); // 0x000000018209BC70-0x000000018209BCE0
		private static void SetPathForwardDirection(this TweenerCore<Vector3, Path, PathOptions> t, Vector3? forwardDirection = default, Vector3? up = default); // 0x000000018209C020-0x000000018209C400
	}
}
