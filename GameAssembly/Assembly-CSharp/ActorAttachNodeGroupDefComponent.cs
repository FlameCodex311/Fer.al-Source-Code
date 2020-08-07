/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
[ChartComponent] // 0x0000000180225C30-0x0000000180225C60
public class ActorAttachNodeGroupDefComponent : DefComponent // TypeDefIndex: 11595
{
	// Fields
	[ChartDef] // 0x0000000180225EE0-0x0000000180225F60
	[ChartList] // 0x0000000180225EE0-0x0000000180225F60
	public ChartDefList attachNodes; // 0x18

	// Properties
	public List<BaseDef> AttachNodes { get; } // 0x0000000180C58780-0x0000000180C587A0 

	// Constructors
	public ActorAttachNodeGroupDefComponent(); // 0x0000000182164850-0x00000001821648B0

	// Methods
	public bool Contains(BaseDef inAttachNode); // 0x0000000182164690-0x0000000182164850
}

