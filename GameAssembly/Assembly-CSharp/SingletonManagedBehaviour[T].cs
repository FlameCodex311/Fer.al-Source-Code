/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class SingletonManagedBehaviour<T> : ManagedBehaviour // TypeDefIndex: 13430
	where T : SingletonManagedBehaviour<T>
{
	// Fields
	protected static T _instance;

	// Properties
	public static T instance { get; }

	// Constructors
	public SingletonManagedBehaviour();
	static SingletonManagedBehaviour();

	// Methods
	public override void SetInstanceInternal();
	public override void UnsetInstanceInternal();
}

