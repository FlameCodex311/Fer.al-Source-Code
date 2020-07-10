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

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening
{
	public static class TweenSettingsExtensions // TypeDefIndex: 5612
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
		public static Sequence Append(this Sequence s, Tween t); // 0x0000000180DD0E00-0x0000000180DD0E50
		public static Sequence Prepend(this Sequence s, Tween t); // 0x0000000180DD1130-0x0000000180DD1180
		public static Sequence Join(this Sequence s, Tween t); // 0x0000000180DD1060-0x0000000180DD10B0
		public static Sequence Insert(this Sequence s, float atPosition, Tween t); // 0x0000000180DD1010-0x0000000180DD1060
		public static Sequence AppendInterval(this Sequence s, float interval); // 0x0000000180DD0DC0-0x0000000180DD0E00
		public static Sequence PrependInterval(this Sequence s, float interval); // 0x0000000180DD10F0-0x0000000180DD1130
		public static Sequence AppendCallback(this Sequence s, TweenCallback callback); // 0x0000000180DD0D80-0x0000000180DD0DC0
		public static Sequence PrependCallback(this Sequence s, TweenCallback callback); // 0x0000000180DD10B0-0x0000000180DD10F0
		public static Sequence InsertCallback(this Sequence s, float atPosition, TweenCallback callback); // 0x0000000180DD0FD0-0x0000000180DD1010
		public static T From<T>(this T t)
			where T : Tweener;
		public static T From<T>(this T t, bool isRelative)
			where T : Tweener;
		public static TweenerCore<T1, T2, TPlugOptions> From<T1, T2, TPlugOptions>(this TweenerCore<T1, T2, TPlugOptions> t, T2 fromValue, bool setImmediately = true /* Metadata: 0x0072E7AB */)
			where TPlugOptions : struct, IPlugOptions;
		public static TweenerCore<Color, Color, ColorOptions> From(this TweenerCore<Color, Color, ColorOptions> t, float fromAlphaValue, bool setImmediately = true /* Metadata: 0x0072E7AC */); // 0x0000000180DD0E50-0x0000000180DD0F10
		public static TweenerCore<Vector3, Vector3, VectorOptions> From(this TweenerCore<Vector3, Vector3, VectorOptions> t, float fromValue, bool setImmediately = true /* Metadata: 0x0072E7AD */); // 0x0000000180DD0F10-0x0000000180DD0FD0
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
		public static Tweener SetOptions(this TweenerCore<float, float, FloatOptions> t, bool snapping); // 0x0000000180DD13A0-0x0000000180DD13C0
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, bool snapping); // 0x0000000180DD1340-0x0000000180DD1360
		public static Tweener SetOptions(this TweenerCore<Vector2, Vector2, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0072E7AE */); // 0x0000000180DD1300-0x0000000180DD1320
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, bool snapping); // 0x0000000180DD12E0-0x0000000180DD1300
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0072E7AF */); // 0x0000000180DD1320-0x0000000180DD1340
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, bool snapping); // 0x0000000180DD1420-0x0000000180DD1440
		public static Tweener SetOptions(this TweenerCore<Vector4, Vector4, VectorOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0072E7B0 */); // 0x0000000180DD1380-0x0000000180DD13A0
		public static Tweener SetOptions(this TweenerCore<Quaternion, Vector3, QuaternionOptions> t, bool useShortest360Route = true /* Metadata: 0x0072E7B1 */); // 0x0000000180DD12C0-0x0000000180DD12E0
		public static Tweener SetOptions(this TweenerCore<Color, Color, ColorOptions> t, bool alphaOnly); // 0x0000000180DD1360-0x0000000180DD1380
		public static Tweener SetOptions(this TweenerCore<Rect, Rect, RectOptions> t, bool snapping); // 0x0000000180DD1360-0x0000000180DD1380
		public static Tweener SetOptions(this TweenerCore<string, string, StringOptions> t, bool richTextEnabled, ScrambleMode scrambleMode = ScrambleMode.None /* Metadata: 0x0072E7B2 */, string scrambleChars = null); // 0x0000000180DD1440-0x0000000180DD1530
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, bool snapping); // 0x0000000180DD1340-0x0000000180DD1360
		public static Tweener SetOptions(this TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> t, AxisConstraint axisConstraint, bool snapping = false /* Metadata: 0x0072E7B6 */); // 0x0000000180DD1300-0x0000000180DD1320
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, AxisConstraint lockPosition, AxisConstraint lockRotation = AxisConstraint.None /* Metadata: 0x0072E7B7 */); // 0x0000000180DD13C0-0x0000000180DD13F0
		public static TweenerCore<Vector3, Path, PathOptions> SetOptions(this TweenerCore<Vector3, Path, PathOptions> t, bool closePath, AxisConstraint lockPosition = AxisConstraint.None /* Metadata: 0x0072E7BB */, AxisConstraint lockRotation = AxisConstraint.None /* Metadata: 0x0072E7BF */); // 0x0000000180DD13F0-0x0000000180DD1420
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Vector3 lookAtPosition, Vector3? forwardDirection = default, Vector3? up = default); // 0x0000000180DD11F0-0x0000000180DD1260
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, Transform lookAtTransform, Vector3? forwardDirection = default, Vector3? up = default); // 0x0000000180DD1260-0x0000000180DD12C0
		public static TweenerCore<Vector3, Path, PathOptions> SetLookAt(this TweenerCore<Vector3, Path, PathOptions> t, float lookAhead, Vector3? forwardDirection = default, Vector3? up = default); // 0x0000000180DD1180-0x0000000180DD11F0
		private static void SetPathForwardDirection(this TweenerCore<Vector3, Path, PathOptions> t, Vector3? forwardDirection = default, Vector3? up = default); // 0x0000000180DD1530-0x0000000180DD1910
	}
}
