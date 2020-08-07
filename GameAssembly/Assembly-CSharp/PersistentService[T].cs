/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class PersistentService<T> : SingletonManagedBehaviour<T> // TypeDefIndex: 12643
	where T : PersistentService<T>
{
	// Fields
	private bool _dirty;

	// Properties
	public bool Dirty { get; }

	// Constructors
	public PersistentService();

	// Methods
	public override void SetInstanceInternal();
	public override void UnsetInstanceInternal();
	public bool SetClean();
	public bool SetDirty();
	private void OnConnectionLost(PersistentServiceConnectionLostMessage msg);
}

