/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class WorldObjectInfo : BaseInfo // TypeDefIndex: 11451
{
	// Fields
	[NonSerialized]
	private List<WorldObject> _registeredWorldObjects; // 0x10

	// Properties
	public List<WorldObject> RegisteredWorldObjects { get; } // 0x000000018036AC80-0x000000018036AC90 

	// Constructors
	public WorldObjectInfo(); // 0x0000000181000840-0x00000001810008A0

	// Methods
	public void RegisterWorldObject(WorldObject inWorldObject); // 0x0000000181000790-0x00000001810007E0
	public void UnregisterWorldObject(WorldObject inWorldObject); // 0x00000001810007E0-0x0000000181000840
}

