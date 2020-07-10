/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class TimelineEventInvocationInfo // TypeDefIndex: 11904
{
	// Fields
	public Behaviour TargetBehaviour; // 0x10
	public MethodInfo MethodInfo; // 0x18
	public static Type[] SupportedTypes; // 0x00
	public string Key; // 0x20

	// Constructors
	public TimelineEventInvocationInfo(string key, Behaviour targetBehaviour, MethodInfo methodInfo); // 0x0000000181A0E490-0x0000000181A0E4E0
	static TimelineEventInvocationInfo(); // 0x0000000181A0E280-0x0000000181A0E490

	// Methods
	public void Invoke(object value); // 0x0000000181A0D810-0x0000000181A0D900
	public void InvokEnum(int value); // 0x0000000181A0D620-0x0000000181A0D7C0
	public void InvokeNoArgs(); // 0x0000000181A0D7C0-0x0000000181A0D810
	public void Invoke(bool isSingleArg, string value); // 0x0000000181A0D900-0x0000000181A0E280
}

