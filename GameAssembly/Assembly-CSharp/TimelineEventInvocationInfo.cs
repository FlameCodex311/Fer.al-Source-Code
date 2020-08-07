/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class TimelineEventInvocationInfo // TypeDefIndex: 13440
{
	// Fields
	public Behaviour TargetBehaviour; // 0x10
	public MethodInfo MethodInfo; // 0x18
	public static Type[] SupportedTypes; // 0x00
	public string Key; // 0x20

	// Constructors
	public TimelineEventInvocationInfo(string key, Behaviour targetBehaviour, MethodInfo methodInfo); // 0x0000000180F8F840-0x0000000180F8F890
	static TimelineEventInvocationInfo(); // 0x0000000180F8F640-0x0000000180F8F840

	// Methods
	public void Invoke(object value); // 0x0000000180F8EC30-0x0000000180F8ED20
	public void InvokEnum(int value); // 0x0000000180F8EA50-0x0000000180F8EBE0
	public void InvokeNoArgs(); // 0x0000000180F8EBE0-0x0000000180F8EC30
	public void Invoke(bool isSingleArg, string value); // 0x0000000180F8ED20-0x0000000180F8F640
}

