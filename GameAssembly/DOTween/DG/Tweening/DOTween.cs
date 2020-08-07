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

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening
{
	public class DOTween // TypeDefIndex: 5677
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
		public static LogBehaviour logBehaviour { get; set; } // 0x000000018178C400-0x000000018178C460 0x000000018178C460-0x000000018178C520
	
		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass55_0 // TypeDefIndex: 5678
		{
			// Fields
			public float v; // 0x10
			public DOSetter<float> setter; // 0x18
	
			// Constructors
			public <>c__DisplayClass55_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal float <To>b__0(); // 0x0000000180373AA0-0x0000000180373AB0
			internal void <To>b__1(float x); // 0x000000018179B010-0x000000018179B070
		}
	
		// Constructors
		public DOTween(); // 0x0000000180373240-0x0000000180373250
		static DOTween(); // 0x000000018178C260-0x000000018178C400
	
		// Methods
		public static IDOTweenInit Init(bool? recycleAllByDefault = default, bool? useSafeMode = default, LogBehaviour? logBehaviour = default); // 0x0000000181788F90-0x0000000181789140
		private static void AutoInit(); // 0x00000001817879A0-0x0000000181787A60
		private static IDOTweenInit Init(DOTweenSettings settings, bool? recycleAllByDefault, bool? useSafeMode, LogBehaviour? logBehaviour); // 0x0000000181788560-0x0000000181788F90
		public static void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity); // 0x000000018178A4B0-0x000000018178A510
		public static void Clear(bool destroy = false /* Metadata: 0x00763208 */); // 0x0000000181787AB0-0x0000000181787F00
		public static void ClearCachedTweens(); // 0x0000000181787A60-0x0000000181787AB0
		public static int Validate(); // 0x000000018178C210-0x000000018178C260
		public static void ManualUpdate(float deltaTime, float unscaledDeltaTime); // 0x0000000181789520-0x0000000181789630
		public static TweenerCore<float, float, FloatOptions> To(DOGetter<float> getter, DOSetter<float> setter, float endValue, float duration); // 0x000000018178BBD0-0x000000018178BC70
		public static TweenerCore<double, double, NoOptions> To(DOGetter<double> getter, DOSetter<double> setter, double endValue, float duration); // 0x000000018178BA80-0x000000018178BB20
		public static TweenerCore<int, int, NoOptions> To(DOGetter<int> getter, DOSetter<int> setter, int endValue, float duration); // 0x000000018178B760-0x000000018178B800
		public static TweenerCore<uint, uint, UintOptions> To(DOGetter<uint> getter, DOSetter<uint> setter, uint endValue, float duration); // 0x000000018178B9E0-0x000000018178BA80
		public static TweenerCore<long, long, NoOptions> To(DOGetter<long> getter, DOSetter<long> setter, long endValue, float duration); // 0x000000018178B8A0-0x000000018178B940
		public static TweenerCore<ulong, ulong, NoOptions> To(DOGetter<ulong> getter, DOSetter<ulong> setter, ulong endValue, float duration); // 0x000000018178BDA0-0x000000018178BE40
		public static TweenerCore<string, string, StringOptions> To(DOGetter<string> getter, DOSetter<string> setter, string endValue, float duration); // 0x000000018178B800-0x000000018178B8A0
		public static TweenerCore<Vector2, Vector2, VectorOptions> To(DOGetter<Vector2> getter, DOSetter<Vector2> setter, Vector2 endValue, float duration); // 0x000000018178B940-0x000000018178B9E0
		public static TweenerCore<Vector3, Vector3, VectorOptions> To(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 endValue, float duration); // 0x000000018178B420-0x000000018178B4D0
		public static TweenerCore<Vector4, Vector4, VectorOptions> To(DOGetter<Vector4> getter, DOSetter<Vector4> setter, Vector4 endValue, float duration); // 0x000000018178B620-0x000000018178B6C0
		public static TweenerCore<Quaternion, Vector3, QuaternionOptions> To(DOGetter<Quaternion> getter, DOSetter<Quaternion> setter, Vector3 endValue, float duration); // 0x000000018178BB20-0x000000018178BBD0
		public static TweenerCore<Color, Color, ColorOptions> To(DOGetter<Color> getter, DOSetter<Color> setter, Color endValue, float duration); // 0x000000018178B6C0-0x000000018178B760
		public static TweenerCore<Rect, Rect, RectOptions> To(DOGetter<Rect> getter, DOSetter<Rect> setter, Rect endValue, float duration); // 0x000000018178B580-0x000000018178B620
		public static Tweener To(DOGetter<RectOffset> getter, DOSetter<RectOffset> setter, RectOffset endValue, float duration); // 0x000000018178B380-0x000000018178B420
		public static TweenerCore<T1, T2, TPlugOptions> To<T1, T2, TPlugOptions>(ABSTweenPlugin<T1, T2, TPlugOptions> plugin, DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration)
			where TPlugOptions : struct, IPlugOptions;
		public static TweenerCore<Vector3, Vector3, VectorOptions> ToAxis(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float endValue, float duration, AxisConstraint axisConstraint = AxisConstraint.None | AxisConstraint.X /* Metadata: 0x00763209 */); // 0x000000018178B290-0x000000018178B380
		public static TweenerCore<Color, Color, ColorOptions> ToAlpha(DOGetter<Color> getter, DOSetter<Color> setter, float endValue, float duration); // 0x000000018178AF60-0x000000018178B050
		public static Tweener To(DOSetter<float> setter, float startValue, float endValue, float duration); // 0x000000018178BC70-0x000000018178BDA0
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Punch(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3 direction, float duration, int vibrato = 10 /* Metadata: 0x0076320D */, float elasticity = 1f /* Metadata: 0x00763211 */); // 0x0000000181789CB0-0x000000018178A120
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, float strength = 3f /* Metadata: 0x00763215 */, int vibrato = 10 /* Metadata: 0x00763219 */, float randomness = 90f /* Metadata: 0x0076321D */, bool ignoreZAxis = true /* Metadata: 0x00763221 */, bool fadeOut = true /* Metadata: 0x00763222 */); // 0x000000018178AD60-0x000000018178AE70
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato = 10 /* Metadata: 0x00763223 */, float randomness = 90f /* Metadata: 0x00763227 */, bool fadeOut = true /* Metadata: 0x0076322B */); // 0x000000018178AC90-0x000000018178AD60
		private static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> Shake(DOGetter<Vector3> getter, DOSetter<Vector3> setter, float duration, Vector3 strength, int vibrato, float randomness, bool ignoreZAxis, bool vectorBased, bool fadeOut); // 0x000000018178A510-0x000000018178AC90
		public static TweenerCore<Vector3, Vector3[], Vector3ArrayOptions> ToArray(DOGetter<Vector3> getter, DOSetter<Vector3> setter, Vector3[] endValues, float[] durations); // 0x000000018178B050-0x000000018178B290
		internal static TweenerCore<Color2, Color2, ColorOptions> To(DOGetter<Color2> getter, DOSetter<Color2> setter, Color2 endValue, float duration); // 0x000000018178B4D0-0x000000018178B580
		public static Sequence Sequence(); // 0x000000018178A420-0x000000018178A4B0
		public static int CompleteAll(bool withCallbacks = false /* Metadata: 0x0076322C */); // 0x0000000181787F00-0x0000000181787F90
		public static int Complete(object targetOrId, bool withCallbacks = false /* Metadata: 0x0076322D */); // 0x0000000181788100-0x00000001817881C0
		internal static int CompleteAndReturnKilledTot(); // 0x0000000181788010-0x0000000181788080
		internal static int CompleteAndReturnKilledTot(object targetOrId); // 0x0000000181788080-0x0000000181788100
		internal static int CompleteAndReturnKilledTotExceptFor(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] excludeTargetsOrIds); // 0x0000000181787F90-0x0000000181788010
		public static int FlipAll(); // 0x00000001817881C0-0x0000000181788230
		public static int Flip(object targetOrId); // 0x0000000181788230-0x00000001817882B0
		public static int GotoAll(float to, bool andPlay = false /* Metadata: 0x0076322E */); // 0x00000001817882B0-0x0000000181788330
		public static int Goto(object targetOrId, float to, bool andPlay = false /* Metadata: 0x0076322F */); // 0x0000000181788330-0x00000001817883E0
		public static int KillAll(bool complete = false /* Metadata: 0x00763230 */); // 0x0000000181789360-0x00000001817893E0
		public static int KillAll(bool complete, params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ object[] idsOrTargetsToExclude); // 0x00000001817891D0-0x0000000181789360
		public static int Kill(object targetOrId, bool complete = false /* Metadata: 0x00763231 */); // 0x00000001817893E0-0x0000000181789520
		public static int PauseAll(); // 0x0000000181789630-0x00000001817896A0
		public static int Pause(object targetOrId); // 0x00000001817896A0-0x0000000181789720
		public static int PlayAll(); // 0x0000000181789790-0x0000000181789800
		public static int Play(object targetOrId); // 0x0000000181789B20-0x0000000181789BA0
		public static int Play(object target, object id); // 0x0000000181789BA0-0x0000000181789C40
		public static int PlayBackwardsAll(); // 0x0000000181789800-0x0000000181789870
		public static int PlayBackwards(object targetOrId); // 0x0000000181789910-0x0000000181789990
		public static int PlayBackwards(object target, object id); // 0x0000000181789870-0x0000000181789910
		public static int PlayForwardAll(); // 0x0000000181789990-0x0000000181789A00
		public static int PlayForward(object targetOrId); // 0x0000000181789A00-0x0000000181789A80
		public static int PlayForward(object target, object id); // 0x0000000181789A80-0x0000000181789B20
		public static int RestartAll(bool includeDelay = true /* Metadata: 0x00763232 */); // 0x000000018178A120-0x000000018178A1A0
		public static int Restart(object targetOrId, bool includeDelay = true /* Metadata: 0x00763233 */, float changeDelayTo = -1f /* Metadata: 0x00763234 */); // 0x000000018178A1A0-0x000000018178A250
		public static int Restart(object target, object id, bool includeDelay = true /* Metadata: 0x00763238 */, float changeDelayTo = -1f /* Metadata: 0x00763239 */); // 0x000000018178A250-0x000000018178A300
		public static int RewindAll(bool includeDelay = true /* Metadata: 0x0076323D */); // 0x000000018178A300-0x000000018178A380
		public static int Rewind(object targetOrId, bool includeDelay = true /* Metadata: 0x0076323E */); // 0x000000018178A380-0x000000018178A420
		public static int SmoothRewindAll(); // 0x000000018178AE70-0x000000018178AEE0
		public static int SmoothRewind(object targetOrId); // 0x000000018178AEE0-0x000000018178AF60
		public static int TogglePauseAll(); // 0x000000018178BE40-0x000000018178BEB0
		public static int TogglePause(object targetOrId); // 0x000000018178BEB0-0x000000018178BF30
		public static bool IsTweening(object targetOrId, bool alsoCheckIfIsPlaying = false /* Metadata: 0x0076323F */); // 0x0000000181789140-0x00000001817891D0
		public static int TotalPlayingTweens(); // 0x000000018178BF30-0x000000018178C0E0
		public static List<Tween> PlayingTweens(List<Tween> fillableList = null); // 0x0000000181789C40-0x0000000181789CB0
		public static List<Tween> PausedTweens(List<Tween> fillableList = null); // 0x0000000181789720-0x0000000181789790
		public static List<Tween> TweensById(object id, bool playingOnly = false /* Metadata: 0x00763240 */, List<Tween> fillableList = null); // 0x000000018178C0E0-0x000000018178C180
		public static List<Tween> TweensByTarget(object target, bool playingOnly = false /* Metadata: 0x00763241 */, List<Tween> fillableList = null); // 0x000000018178C180-0x000000018178C210
		private static void InitCheck(); // 0x00000001817883E0-0x0000000181788560
		private static TweenerCore<T1, T2, TPlugOptions> ApplyTo<T1, T2, TPlugOptions>(DOGetter<T1> getter, DOSetter<T1> setter, T2 endValue, float duration, ABSTweenPlugin<T1, T2, TPlugOptions> plugin = null)
			where TPlugOptions : struct, IPlugOptions;
	}
}
