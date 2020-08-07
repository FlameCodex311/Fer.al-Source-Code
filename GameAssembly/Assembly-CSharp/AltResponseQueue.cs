/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class AltResponseQueue // TypeDefIndex: 10387
{
	// Fields
	private Queue<SendResponse> ResponseQueue; // 0x10
	private object _queueLock; // 0x18

	// Constructors
	public AltResponseQueue(); // 0x000000018214E500-0x000000018214E580

	// Methods
	public void Cycle(); // 0x000000018214E300-0x000000018214E400
	public void ScheduleResponse(SendResponse newResponse); // 0x000000018214E400-0x000000018214E500
}

