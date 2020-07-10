/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class ActorInfoBodyPart // TypeDefIndex: 10883
{
	// Fields
	[ChartDef] // 0x00000001800EDAF0-0x00000001800EDB90
	public string bodyPartDefID; // 0x10
	[ChartBool] // 0x00000001800B57C0-0x00000001800B57D0
	public bool attached; // 0x18
	[NonSerialized]
	public bool decalsDirty; // 0x19
	[NonSerialized]
	private ActorBodyPartDefComponent _bodyPartDefComponent; // 0x20
	[ChartList] // 0x00000001800ED580-0x00000001800ED5B0
	[SerializeField] // 0x00000001800ED580-0x00000001800ED5B0
	private List<ActorInfoDecalEntry> _decalEntries; // 0x28
	private List<ActorInfoDecalEntry> _tempDecalEntries; // 0x30

	// Properties
	public BaseDef BodyPartDef { get; } // 0x00000001814063F0-0x0000000181406450 
	public ActorBodyPartDefComponent BodyPartDefComponent { get; } // 0x0000000181406350-0x00000001814063F0 
	public List<ActorInfoDecalEntry> EyeDecalEntries { get; } // 0x00000001814065D0-0x0000000181406600 
	public List<ActorInfoDecalEntry> DecalEntries { get; } // 0x0000000180369B60-0x0000000180369B70 
	public List<ActorInfoDecalEntry> DecalEntriesWithoutDefaults { get; } // 0x0000000181406450-0x00000001814065D0 

	// Constructors
	public ActorInfoBodyPart(); // 0x00000001814062D0-0x0000000181406350

	// Methods
	public void ResetCaches(); // 0x00000001814062C0-0x00000001814062D0
}

