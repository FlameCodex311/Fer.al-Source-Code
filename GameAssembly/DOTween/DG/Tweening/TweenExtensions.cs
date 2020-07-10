/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 48: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5511-5701

namespace DG.Tweening
{
	public static class TweenExtensions // TypeDefIndex: 5531
	{
		// Extension methods
		public static void Complete(this Tween t); // 0x0000000180DCDF30-0x0000000180DCE0B0
		public static void Complete(this Tween t, bool withCallbacks); // 0x0000000180DCE0B0-0x0000000180DCE250
		public static void Flip(this Tween t); // 0x0000000180DCE640-0x0000000180DCE770
		public static void ForceInit(this Tween t); // 0x0000000180DCE770-0x0000000180DCE8B0
		public static void Goto(this Tween t, float to, bool andPlay = false /* Metadata: 0x0072E6AE */); // 0x0000000180DCEC50-0x0000000180DCEDE0
		public static void Kill(this Tween t, bool complete = false /* Metadata: 0x0072E6AF */); // 0x0000000180DCEFC0-0x0000000180DCF1C0
		public static T Pause<T>(this T t)
			where T : Tween;
		public static T Play<T>(this T t)
			where T : Tween;
		public static void PlayBackwards(this Tween t); // 0x0000000180DCF840-0x0000000180DCF970
		public static void PlayForward(this Tween t); // 0x0000000180DCF970-0x0000000180DCFAA0
		public static void Restart(this Tween t, bool includeDelay = true /* Metadata: 0x0072E6B0 */, float changeDelayTo = -1f /* Metadata: 0x0072E6B1 */); // 0x0000000180DCFAA0-0x0000000180DCFC10
		public static void Rewind(this Tween t, bool includeDelay = true /* Metadata: 0x0072E6B5 */); // 0x0000000180DCFC10-0x0000000180DCFD60
		public static void SmoothRewind(this Tween t); // 0x0000000180DCFD60-0x0000000180DCFE90
		public static void TogglePause(this Tween t); // 0x0000000180DCFE90-0x0000000180DCFFC0
		public static void GotoWaypoint(this Tween t, int waypointIndex, bool andPlay = false /* Metadata: 0x0072E6B6 */); // 0x0000000180DCE8B0-0x0000000180DCEC50
		public static YieldInstruction WaitForCompletion(this Tween t); // 0x0000000180DCFFC0-0x0000000180DD00C0
		public static YieldInstruction WaitForRewind(this Tween t); // 0x0000000180DD03E0-0x0000000180DD04E0
		public static YieldInstruction WaitForKill(this Tween t); // 0x0000000180DD01D0-0x0000000180DD02D0
		public static YieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops); // 0x0000000180DD00C0-0x0000000180DD01D0
		public static YieldInstruction WaitForPosition(this Tween t, float position); // 0x0000000180DD02D0-0x0000000180DD03E0
		public static Coroutine WaitForStart(this Tween t); // 0x0000000180DD04E0-0x0000000180DD05E0
		public static int CompletedLoops(this Tween t); // 0x0000000180DCE250-0x0000000180DCE2C0
		public static float Delay(this Tween t); // 0x0000000180DCE2C0-0x0000000180DCE330
		public static float Duration(this Tween t, bool includeLoops = true /* Metadata: 0x0072E6B7 */); // 0x0000000180DCE330-0x0000000180DCE3E0
		public static float Elapsed(this Tween t, bool includeLoops = true /* Metadata: 0x0072E6B8 */); // 0x0000000180DCE590-0x0000000180DCE640
		public static float ElapsedPercentage(this Tween t, bool includeLoops = true /* Metadata: 0x0072E6B9 */); // 0x0000000180DCE4C0-0x0000000180DCE590
		public static float ElapsedDirectionalPercentage(this Tween t); // 0x0000000180DCE3E0-0x0000000180DCE4C0
		public static bool IsActive(this Tween t); // 0x0000000180DCEDE0-0x0000000180DCEE00
		public static bool IsBackwards(this Tween t); // 0x0000000180DCEE00-0x0000000180DCEE70
		public static bool IsComplete(this Tween t); // 0x0000000180DCEE70-0x0000000180DCEEE0
		public static bool IsInitialized(this Tween t); // 0x0000000180DCEEE0-0x0000000180DCEF50
		public static bool IsPlaying(this Tween t); // 0x0000000180DCEF50-0x0000000180DCEFC0
		public static int Loops(this Tween t); // 0x0000000180DCF1C0-0x0000000180DCF230
		public static Vector3 PathGetPoint(this Tween t, float pathPercentage); // 0x0000000180DCF410-0x0000000180DCF650
		public static Vector3[] PathGetDrawPoints(this Tween t, int subdivisionsXSegment = 10 /* Metadata: 0x0072E6BA */); // 0x0000000180DCF230-0x0000000180DCF410
		public static float PathLength(this Tween t); // 0x0000000180DCF650-0x0000000180DCF840
	}
}
