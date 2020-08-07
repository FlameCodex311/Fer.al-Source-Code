/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class ActorInfoBodyPart // TypeDefIndex: 12406
{
	// Fields
	[ChartDef] // 0x000000018028F670-0x000000018028F710
	public string bodyPartDefID; // 0x10
	[ChartBool] // 0x00000001801CDBF0-0x00000001801CDC00
	public bool attached; // 0x18
	[NonSerialized]
	public bool decalsDirty; // 0x19
	[NonSerialized]
	private ActorBodyPartDefComponent _bodyPartDefComponent; // 0x20
	[ChartList] // 0x000000018028EE90-0x000000018028EEC0
	[SerializeField] // 0x000000018028EE90-0x000000018028EEC0
	private List<ActorInfoDecalEntry> _decalEntries; // 0x28
	private List<ActorInfoDecalEntry> _tempDecalEntries; // 0x30

	// Properties
	public BaseDef BodyPartDef { get; } // 0x00000001821D8130-0x00000001821D8190 
	public ActorBodyPartDefComponent BodyPartDefComponent { get; } // 0x00000001821D8090-0x00000001821D8130 
	public List<ActorInfoDecalEntry> EyeDecalEntries { get; } // 0x00000001821D8300-0x00000001821D8320 
	public List<ActorInfoDecalEntry> DecalEntries { get; } // 0x00000001803745B0-0x00000001803745C0 
	public List<ActorInfoDecalEntry> DecalEntriesWithoutDefaults { get; } // 0x00000001821D8190-0x00000001821D8300 

	// Constructors
	public ActorInfoBodyPart(); // 0x00000001821D8010-0x00000001821D8090

	// Methods
	public void ResetCaches(); // 0x00000001821D8000-0x00000001821D8010
}

