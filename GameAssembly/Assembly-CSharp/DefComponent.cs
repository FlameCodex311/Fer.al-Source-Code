/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public abstract class DefComponent : ComponentBase // TypeDefIndex: 10981
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private BaseDef <def>k__BackingField; // 0x10

	// Properties
	public BaseDef def { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
	public string defID { get; } // 0x000000018055F600-0x000000018055F620 
	public string defName { get; } // 0x000000018055F620-0x000000018055F640 

	// Constructors
	protected DefComponent(); // 0x00000001803F46D0-0x00000001803F46E0

	// Methods
	public void LoadEntry(BaseDef inDef); // 0x000000018055F5E0-0x000000018055F600
	protected virtual void LoadEntry(); // 0x00000001803774A0-0x00000001803774B0
	public virtual void OnLoaded(); // 0x00000001803774A0-0x00000001803774B0
	public T GetComponent<T>()
		where T : DefComponent;
	public T AddComponent<T>()
		where T : DefComponent;
	public void RemoveComponent<T>()
		where T : DefComponent;
	public void ForeachComponent<T>(Action<T> action)
		where T : class;
}

