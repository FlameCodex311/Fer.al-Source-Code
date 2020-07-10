/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Waiters;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public static class CoreMonoBehaviourExtensions // TypeDefIndex: 13406
{
	// Extension methods
	public static Waiter DoNextFrame(this MonoBehaviour me, Action a); // 0x00000001813181C0-0x0000000181318200
	public static Waiter DoAfterThreeFrames(this MonoBehaviour me, Action a); // 0x0000000181318100-0x0000000181318140
	public static Waiter DoAfterFrames(this MonoBehaviour me, int count, Action a); // 0x00000001813180C0-0x0000000181318100
	public static Waiter DoAfterWait(this MonoBehaviour me, float seconds, Action a); // 0x0000000181318140-0x0000000181318180
	public static Waiter DoAfter(this MonoBehaviour me, Func<bool> inCompletionCheck, Action a); // 0x0000000181318180-0x00000001813181C0
	public static void AddDebugButtons(this MonoBehaviour me); // 0x0000000181318060-0x00000001813180C0
	public static void RemoveDebugButtons(this MonoBehaviour me); // 0x0000000181318200-0x0000000181318260
	public static void SetEnabled(this Behaviour me, bool value); // 0x0000000181318260-0x0000000181318280
}

