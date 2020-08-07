/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class WorldObjectInfo : BaseInfo // TypeDefIndex: 12972
{
	// Fields
	[NonSerialized]
	private List<WorldObject> _registeredWorldObjects; // 0x10

	// Properties
	public List<WorldObject> RegisteredWorldObjects { get; } // 0x0000000180372440-0x0000000180372450 

	// Constructors
	public WorldObjectInfo(); // 0x00000001805E7B40-0x00000001805E7BA0

	// Methods
	public void RegisterWorldObject(WorldObject inWorldObject); // 0x00000001805E7A90-0x00000001805E7AE0
	public void UnregisterWorldObject(WorldObject inWorldObject); // 0x00000001805E7AE0-0x00000001805E7B40
}

