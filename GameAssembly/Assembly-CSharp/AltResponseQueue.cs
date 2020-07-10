/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class AltResponseQueue // TypeDefIndex: 12730
{
	// Fields
	private Queue<SendResponse> ResponseQueue; // 0x10
	private object _queueLock; // 0x18

	// Constructors
	public AltResponseQueue(); // 0x00000001810350A0-0x0000000181035120

	// Methods
	public void Cycle(); // 0x0000000181034EA0-0x0000000181034FA0
	public void ScheduleResponse(SendResponse newResponse); // 0x0000000181034FA0-0x00000001810350A0
}

