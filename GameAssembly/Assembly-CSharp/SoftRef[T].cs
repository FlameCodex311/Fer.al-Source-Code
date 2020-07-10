/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class SoftRef<T> // TypeDefIndex: 10522
	where T : ISoftReferable
{
	// Fields
	private T _ref;

	// Properties
	public T Ref { get; protected set; }

	// Constructors
	protected SoftRef();

	// Methods
	protected abstract void UpdateRef();
}

