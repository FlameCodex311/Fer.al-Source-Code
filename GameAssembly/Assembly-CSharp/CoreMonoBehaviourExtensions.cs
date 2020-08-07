/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using WW.Waiters;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public static class CoreMonoBehaviourExtensions // TypeDefIndex: 11077
{
	// Extension methods
	public static Waiter DoNextFrame(this MonoBehaviour me, Action a); // 0x0000000180A96840-0x0000000180A96880
	public static Waiter DoAfterThreeFrames(this MonoBehaviour me, Action a); // 0x0000000180A96780-0x0000000180A967C0
	public static Waiter DoAfterFrames(this MonoBehaviour me, int count, Action a); // 0x0000000180A96740-0x0000000180A96780
	public static Waiter DoAfterWait(this MonoBehaviour me, float seconds, Action a); // 0x0000000180A967C0-0x0000000180A96800
	public static Waiter DoAfter(this MonoBehaviour me, Func<bool> inCompletionCheck, Action a); // 0x0000000180A96800-0x0000000180A96840
	public static void AddDebugButtons(this MonoBehaviour me); // 0x0000000180A966E0-0x0000000180A96740
	public static void RemoveDebugButtons(this MonoBehaviour me); // 0x0000000180A96880-0x0000000180A968E0
	public static void SetEnabled(this Behaviour me, bool value); // 0x0000000180A968E0-0x0000000180A96900
}

