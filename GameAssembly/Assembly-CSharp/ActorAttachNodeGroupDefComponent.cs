/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
[ChartComponent] // 0x000000018014BEB0-0x000000018014BEE0
public class ActorAttachNodeGroupDefComponent : DefComponent // TypeDefIndex: 10104
{
	// Fields
	[ChartDef] // 0x000000018014C0A0-0x000000018014C120
	[ChartList] // 0x000000018014C0A0-0x000000018014C120
	public ChartDefList attachNodes; // 0x18

	// Properties
	public List<BaseDef> AttachNodes { get; } // 0x000000018122F610-0x000000018122F630 

	// Constructors
	public ActorAttachNodeGroupDefComponent(); // 0x000000018122F5B0-0x000000018122F610

	// Methods
	public bool Contains(BaseDef inAttachNode); // 0x000000018122F3F0-0x000000018122F5B0
}

