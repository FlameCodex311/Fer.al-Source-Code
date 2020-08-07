/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 49: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5670-5860

namespace DG.Tweening
{
	public static class TweenExtensions // TypeDefIndex: 5690
	{
		// Extension methods
		public static void Complete(this Tween t); // 0x0000000182098A80-0x0000000182098C00
		public static void Complete(this Tween t, bool withCallbacks); // 0x0000000182098C00-0x0000000182098DA0
		public static void Flip(this Tween t); // 0x0000000182099190-0x00000001820992C0
		public static void ForceInit(this Tween t); // 0x00000001820992C0-0x0000000182099400
		public static void Goto(this Tween t, float to, bool andPlay = false /* Metadata: 0x0076334B */); // 0x0000000182099790-0x0000000182099920
		public static void Kill(this Tween t, bool complete = false /* Metadata: 0x0076334C */); // 0x0000000182099B00-0x0000000182099D00
		public static T Pause<T>(this T t)
			where T : Tween;
		public static T Play<T>(this T t)
			where T : Tween;
		public static void PlayBackwards(this Tween t); // 0x000000018209A380-0x000000018209A4B0
		public static void PlayForward(this Tween t); // 0x000000018209A4B0-0x000000018209A5E0
		public static void Restart(this Tween t, bool includeDelay = true /* Metadata: 0x0076334D */, float changeDelayTo = -1f /* Metadata: 0x0076334E */); // 0x000000018209A5E0-0x000000018209A750
		public static void Rewind(this Tween t, bool includeDelay = true /* Metadata: 0x00763352 */); // 0x000000018209A750-0x000000018209A8A0
		public static void SmoothRewind(this Tween t); // 0x000000018209A8A0-0x000000018209A9D0
		public static void TogglePause(this Tween t); // 0x000000018209A9D0-0x000000018209AB00
		public static void GotoWaypoint(this Tween t, int waypointIndex, bool andPlay = false /* Metadata: 0x00763353 */); // 0x0000000182099400-0x0000000182099790
		public static YieldInstruction WaitForCompletion(this Tween t); // 0x000000018209AB00-0x000000018209ABF0
		public static YieldInstruction WaitForRewind(this Tween t); // 0x000000018209AF00-0x000000018209AFF0
		public static YieldInstruction WaitForKill(this Tween t); // 0x000000018209AD00-0x000000018209ADF0
		public static YieldInstruction WaitForElapsedLoops(this Tween t, int elapsedLoops); // 0x000000018209ABF0-0x000000018209AD00
		public static YieldInstruction WaitForPosition(this Tween t, float position); // 0x000000018209ADF0-0x000000018209AF00
		public static Coroutine WaitForStart(this Tween t); // 0x000000018209AFF0-0x000000018209B0E0
		public static int CompletedLoops(this Tween t); // 0x0000000182098DA0-0x0000000182098E10
		public static float Delay(this Tween t); // 0x0000000182098E10-0x0000000182098E80
		public static float Duration(this Tween t, bool includeLoops = true /* Metadata: 0x00763354 */); // 0x0000000182098E80-0x0000000182098F30
		public static float Elapsed(this Tween t, bool includeLoops = true /* Metadata: 0x00763355 */); // 0x00000001820990E0-0x0000000182099190
		public static float ElapsedPercentage(this Tween t, bool includeLoops = true /* Metadata: 0x00763356 */); // 0x0000000182099010-0x00000001820990E0
		public static float ElapsedDirectionalPercentage(this Tween t); // 0x0000000182098F30-0x0000000182099010
		public static bool IsActive(this Tween t); // 0x0000000182099920-0x0000000182099940
		public static bool IsBackwards(this Tween t); // 0x0000000182099940-0x00000001820999B0
		public static bool IsComplete(this Tween t); // 0x00000001820999B0-0x0000000182099A20
		public static bool IsInitialized(this Tween t); // 0x0000000182099A20-0x0000000182099A90
		public static bool IsPlaying(this Tween t); // 0x0000000182099A90-0x0000000182099B00
		public static int Loops(this Tween t); // 0x0000000182099D00-0x0000000182099D70
		public static Vector3 PathGetPoint(this Tween t, float pathPercentage); // 0x0000000182099F50-0x000000018209A190
		public static Vector3[] PathGetDrawPoints(this Tween t, int subdivisionsXSegment = 10 /* Metadata: 0x00763357 */); // 0x0000000182099D70-0x0000000182099F50
		public static float PathLength(this Tween t); // 0x000000018209A190-0x000000018209A380
	}
}
