/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class DefComponent : ComponentBase // TypeDefIndex: 13310
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private BaseDef <def>k__BackingField; // 0x10

	// Properties
	public BaseDef def { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
	public string defID { get; } // 0x0000000181183D40-0x0000000181183D60 
	public string defName { get; } // 0x00000001809759E0-0x0000000180975A00 

	// Constructors
	protected DefComponent(); // 0x000000018037E800-0x000000018037E810

	// Methods
	public void LoadEntry(BaseDef inDef); // 0x0000000181183D20-0x0000000181183D40
	protected virtual void LoadEntry(); // 0x00000001803581E0-0x00000001803581F0
	public virtual void OnLoaded(); // 0x00000001803581E0-0x00000001803581F0
	public T GetComponent<T>()
		where T : DefComponent;
	public T AddComponent<T>()
		where T : DefComponent;
	public void RemoveComponent<T>()
		where T : DefComponent;
	public void ForeachComponent<T>(Action<T> action)
		where T : class;
}

