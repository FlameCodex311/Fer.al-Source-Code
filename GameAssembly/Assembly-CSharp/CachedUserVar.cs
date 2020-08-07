/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class CachedUserVar // TypeDefIndex: 14239
{
	// Fields
	[RootSelector] // 0x00000001801F0500-0x00000001801F0570
	[SerializeField] // 0x00000001801F0500-0x00000001801F0570
	private string userVarDefId; // 0x10
	private Dictionary<int, ObscuredLong> _values; // 0x18
	private List<UserVarSetOperation> _pendingSetOperations; // 0x20

	// Properties
	public long Value { get; set; } // 0x000000018049C150-0x000000018049C160 0x000000018049C180-0x000000018049C1A0
	public long this[int key] { get => default; set {} } // 0x000000018049C140-0x000000018049C150 0x000000018049C160-0x000000018049C180

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 14240
	{
		// Fields
		public int inKey; // 0x10

		// Constructors
		public <>c__DisplayClass13_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <SetValueLazy>b__0(UserVarSetOperation existingOperation); // 0x00000001804A9240-0x00000001804A9250
		internal bool <SetValueLazy>b__1(UserVarSetOperation existingOperation); // 0x00000001804A9240-0x00000001804A9250
	}

	// Constructors
	public CachedUserVar(); // 0x000000018049C050-0x000000018049C0C0
	public CachedUserVar(string userVarDefId); // 0x000000018049C0C0-0x000000018049C140

	// Methods
	public long GetValue(int inKey); // 0x000000018049BC30-0x000000018049BDB0
	public void SetValue(int inKey, long inValue, int inValue2 = 0 /* Metadata: 0x007BA700 */); // 0x000000018049BFC0-0x000000018049C050
	public void SetValueLazy(int inKey, long inValue, int inValue2 = 0 /* Metadata: 0x007BA704 */); // 0x000000018049BDF0-0x000000018049BFC0
	public void ApplyPendingSetOperations(); // 0x000000018049BAF0-0x000000018049BB90
	public void RefreshCache(); // 0x000000018049BDB0-0x000000018049BDF0
	public long GetDefaultValue(); // 0x000000018049BB90-0x000000018049BC30
	public void ClearUserVarDebug(); // 0x00000001803774A0-0x00000001803774B0
}

