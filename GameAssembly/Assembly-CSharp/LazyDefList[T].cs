/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class LazyDefList<T> // TypeDefIndex: 11007
	where T : BaseDef
{
	// Fields
	private Func<List<string>, List<T>> _getFunc;
	private List<string> _defIDs;
	private List<T> _defs;

	// Properties
	public List<string> DefIDs { get; }
	public List<T> Defs { get; }

	// Constructors
	public LazyDefList(List<string> inDefIDs, Func<List<string>, List<T>> inGetFunc);

	// Methods
	public static implicit operator List<T>(LazyDefList<T> inDef);
	public static implicit operator List<string>(LazyDefList<T> inDef);
}

