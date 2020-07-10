/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;
using UnityEngine;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening
{
	public class DOTween // TypeDefIndex: 5518
	{
		// Fields
		public static readonly string Version; // 0x00
		public static bool useSafeMode; // 0x08
		public static NestedTweenFailureBehaviour nestedTweenFailureBehaviour; // 0x0C
		public static bool showUnityEditorReport; // 0x10
		public static float timeScale; // 0x14
		public static bool useSmoothDeltaTime; // 0x18
		public static float maxSmoothUnscaledTime; // 0x1C
		internal static RewindCallbackMode rewindCallbackMode; // 0x20
		private static LogBehaviour _logBehaviour; // 0x24
		public static Func<LogType, object, bool> onWillLog; // 0x28
		public static bool drawGizmos; // 0x30
		public static UpdateType defaultUpdateType; // 0x34
		public static bool defaultTimeScaleIndependent; // 0x38
		public static AutoPlay defaultAutoPlay; // 0x3C
		public static bool defaultAutoKill; // 0x40
		public static LoopType defaultLoopType; // 0x44
		public static bool defaultRecyclable; // 0x48
		public static Ease defaultEaseType; // 0x4C
		public static float defaultEaseOvershootOrAmplitude; // 0x50
		public static float defaultEasePeriod; // 0x54
		public static DOTweenComponent instance; // 0x58
		internal static int maxActiveTweenersReached; // 0x60
		internal static int maxActiveSequencesReached; // 0x64
		internal static SafeModeReport safeModeReport; // 0x68
		internal static readonly List<TweenCallback> GizmosDelegates; // 0x78
		internal static bool initialized; // 0x80
		internal static bool isQuitting; // 0x81
	
		// Properties
		public static LogBehaviour logBehaviour { get; set; } // 0x0000000180BC8E40-0x0000000180BC8EA0 0x0000000180BC8EA0-0x0000000180BC8F60
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass55_0 // TypeDefIndex: 5519
		{
			// Fields
			public float v; // 0x10
			public DOSetter<float> setter; // 0x18
	
			// Constructors
			public <>c__DisplayClass55_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal float <To>b__0(); // 0x0000000180493360-0x0000000180493370
			internal void <To>b__1(float x); // 0x0000000180BD7FF0-0x0000000180BD8050
		}
	
		// Constructors
		public DOTween(); // 0x000000018036B6C0-0x000000018036B6D0
		static DOTween(); // 0x0000000180BC8CA0-0x0000000180BC8E40
	
		// Methods
		public static IDOTweenInit Init(bool? recycleAllByDefault = default, bool? useSafeMode = default, LogBehaviour? logBehaviour = default); // 0x0000000180BC5960-0x0000000180BC5B10
		private static void AutoInit(); // 0x0000000180BC4330-0x0000000180BC43F0
		private static IDOTweenInit Init(DOTweenSettings settings, bool? recycleAllByDefault, bool? useSafeMode, LogBehaviour? logBehaviour); // 0x0000000180BC4EF0-0x0000000180BC5960
		public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity); // 0x0000000180BC6EA0-0x0000000180BC6F00
		public static void Clear(bool destroy = false /* Metadata: 0x0072E56B */); // 0x0000000180BC4440-0x0000000180BC4890
		public static void ClearCachedTweens(); // 0x0000000180BC43F0-0x0000000180BC4440
		public static int Validate(); // 0x0000000180BC8C50-0x0000000180BC8CA0
		public static void ManualUpdate(float deltaTime, float unscaledDeltaTime); // 0x0000000180BC5EF0-0x0000000180BC6000
		public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration); // 0x0000000180BC85F0-0x0000000180BC8690
		public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration); // 0x0000000180BC84A0-0x0000000180BC8540
		public static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration); // 0x0000000180BC8180-0x0000000180BC8220
		public static TweenerCore<uint, uint, UintOptions> To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration); // 0x0000000180BC8400-0x0000000180BC84A0
		public static TweenerCore<long, long, NoOptions> To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration); // 0x0000000180BC82C0-0x0000000180BC8360
		public static TweenerCore<ulong, ulong, NoOptions> To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration); // 0x0000000180BC87D0-0x0000000180BC8870
		public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration); // 0x0000000180BC8220-0x0000000180BC82C0
		public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration); // 0x0000000180BC8360-0x0000000180BC8400
		public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration); // 0x0000000180BC7E40-0x0000000180BC7EF0
		public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration); // 0x0000000180BC8040-0x0000000180BC80E0
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration); // 0x0000000180BC8540-0x0000000180BC85F0
		public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration); // 0x0000000180BC80E0-0x0000000180BC8180
		public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration); // 0x0000000180BC7FA0-0x0000000180BC8040
		public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration); // 0x0000000180BC7DA0-0x0000000180BC7E40
		public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration)
			where TPlugOptions : struct, IPlugOptions;
		public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = AxisConstraint.None | AxisConstraint.X /* Metadata: 0x0072E56C */); // 0x0000000180BC7CB0-0x0000000180BC7DA0
		public static TweenerCore<Color, Color, ColorOptions> ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration); // 0x0000000180BC7970-0x0000000180BC7A60
		public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration); // 0x0000000180BC8690-0x0000000180BC87D0
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10 /* Metadata: 0x0072E570 */, float elasticity = 1f /* Metadata: 0x0072E574 */); // 0x0000000180BC6680-0x0000000180BC6B10
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3f /* Metadata: 0x0072E578 */, int vibrato = 10 /* Metadata: 0x0072E57C */, float randomness = 90f /* Metadata: 0x0072E580 */, bool ignoreZAxis = true /* Metadata: 0x0072E584 */, bool fadeOut = true /* Metadata: 0x0072E585 */); // 0x0000000180BC7770-0x0000000180BC7880
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x0072E586 */, float randomness = 90f /* Metadata: 0x0072E58A */, bool fadeOut = true /* Metadata: 0x0072E58E */); // 0x0000000180BC76A0-0x0000000180BC7770
		private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut); // 0x0000000180BC6F00-0x0000000180BC76A0
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations); // 0x0000000180BC7A60-0x0000000180BC7CB0
		internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration); // 0x0000000180BC7EF0-0x0000000180BC7FA0
		public static Sequence Sequence(); // 0x0000000180BC6E10-0x0000000180BC6EA0
		public static int CompleteAll(bool withCallbacks = false /* Metadata: 0x0072E58F */); // 0x0000000180BC4890-0x0000000180BC4920
		public static int Complete(object targetOrId, bool withCallbacks = false /* Metadata: 0x0072E590 */); // 0x0000000180BC4A90-0x0000000180BC4B50
		internal static int CompleteAndReturnKilledTot(); // 0x0000000180BC49A0-0x0000000180BC4A10
		internal static int CompleteAndReturnKilledTot(object targetOrId); // 0x0000000180BC4A10-0x0000000180BC4A90
		internal static int CompleteAndReturnKilledTotExceptFor(params /* 0x00000001800B36B0-0x00000001800B36C0 */ object[] excludeTargetsOrIds); // 0x0000000180BC4920-0x0000000180BC49A0
		public static int FlipAll(); // 0x0000000180BC4B50-0x0000000180BC4BC0
		public static int Flip(object targetOrId); // 0x0000000180BC4BC0-0x0000000180BC4C40
		public static int GotoAll(float to, bool andPlay = false /* Metadata: 0x0072E591 */); // 0x0000000180BC4C40-0x0000000180BC4CC0
		public static int Goto(object targetOrId, float to, bool andPlay = false /* Metadata: 0x0072E592 */); // 0x0000000180BC4CC0-0x0000000180BC4D70
		public static int KillAll(bool complete = false /* Metadata: 0x0072E593 */); // 0x0000000180BC5D30-0x0000000180BC5DB0
		public static int KillAll(bool complete, params /* 0x00000001800B36B0-0x00000001800B36C0 */ object[] idsOrTargetsToExclude); // 0x0000000180BC5BA0-0x0000000180BC5D30
		public static int Kill(object targetOrId, bool complete = false /* Metadata: 0x0072E594 */); // 0x0000000180BC5DB0-0x0000000180BC5EF0
		public static int PauseAll(); // 0x0000000180BC6000-0x0000000180BC6070
		public static int Pause(object targetOrId); // 0x0000000180BC6070-0x0000000180BC60F0
		public static int PlayAll(); // 0x0000000180BC6160-0x0000000180BC61D0
		public static int Play(object targetOrId); // 0x0000000180BC64F0-0x0000000180BC6570
		public static int Play(object target, object id); // 0x0000000180BC6570-0x0000000180BC6610
		public static int PlayBackwardsAll(); // 0x0000000180BC61D0-0x0000000180BC6240
		public static int PlayBackwards(object targetOrId); // 0x0000000180BC62E0-0x0000000180BC6360
		public static int PlayBackwards(object target, object id); // 0x0000000180BC6240-0x0000000180BC62E0
		public static int PlayForwardAll(); // 0x0000000180BC6360-0x0000000180BC63D0
		public static int PlayForward(object targetOrId); // 0x0000000180BC63D0-0x0000000180BC6450
		public static int PlayForward(object target, object id); // 0x0000000180BC6450-0x0000000180BC64F0
		public static int RestartAll(bool includeDelay = true /* Metadata: 0x0072E595 */); // 0x0000000180BC6B10-0x0000000180BC6B90
		public static int Restart(object targetOrId, bool includeDelay = true /* Metadata: 0x0072E596 */, float changeDelayTo = -1f /* Metadata: 0x0072E597 */); // 0x0000000180BC6B90-0x0000000180BC6C40
		public static int Restart(object target, object id, bool includeDelay = true /* Metadata: 0x0072E59B */, float changeDelayTo = -1f /* Metadata: 0x0072E59C */); // 0x0000000180BC6C40-0x0000000180BC6CF0
		public static int RewindAll(bool includeDelay = true /* Metadata: 0x0072E5A0 */); // 0x0000000180BC6CF0-0x0000000180BC6D70
		public static int Rewind(object targetOrId, bool includeDelay = true /* Metadata: 0x0072E5A1 */); // 0x0000000180BC6D70-0x0000000180BC6E10
		public static int SmoothRewindAll(); // 0x0000000180BC7880-0x0000000180BC78F0
		public static int SmoothRewind(object targetOrId); // 0x0000000180BC78F0-0x0000000180BC7970
		public static int TogglePauseAll(); // 0x0000000180BC8870-0x0000000180BC88E0
		public static int TogglePause(object targetOrId); // 0x0000000180BC88E0-0x0000000180BC8960
		public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = false /* Metadata: 0x0072E5A2 */); // 0x0000000180BC5B10-0x0000000180BC5BA0
		public static int TotalPlayingTweens(); // 0x0000000180BC8960-0x0000000180BC8B20
		public static List<Tween> PlayingTweens(List<Tween> fillableList = null); // 0x0000000180BC6610-0x0000000180BC6680
		public static List<Tween> PausedTweens(List<Tween> fillableList = null); // 0x0000000180BC60F0-0x0000000180BC6160
		public static List<Tween> TweensById(object id, bool playingOnly = false /* Metadata: 0x0072E5A3 */, List<Tween> fillableList = null); // 0x0000000180BC8B20-0x0000000180BC8BC0
		public static List<Tween> TweensByTarget(object target, bool playingOnly = false /* Metadata: 0x0072E5A4 */, List<Tween> fillableList = null); // 0x0000000180BC8BC0-0x0000000180BC8C50
		private static void InitCheck(); // 0x0000000180BC4D70-0x0000000180BC4EF0
		private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
			where TPlugOptions : struct, IPlugOptions;
	}
}
