﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class ItemComponentRef<T> : SoftRef<T> // TypeDefIndex: 12012
	where T : ItemComponent
{
	// Fields
	public readonly string ItemId;

	// Constructors
	public ItemComponentRef(string itemId);

	// Methods
	protected override void UpdateRef();
	public static implicit operator T(ItemComponentRef<T> r);
	public static implicit operator ItemComponentRef<T>(T i);
}

