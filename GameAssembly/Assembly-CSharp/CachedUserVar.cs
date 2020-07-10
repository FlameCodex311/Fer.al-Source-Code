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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class CachedUserVar // TypeDefIndex: 12670
{
	// Fields
	[RootSelector] // 0x0000000180108920-0x0000000180108990
	[SerializeField] // 0x0000000180108920-0x0000000180108990
	private string userVarDefId; // 0x10
	private Dictionary<int, ObscuredLong> _values; // 0x18
	private List<UserVarSetOperation> _pendingSetOperations; // 0x20

	// Properties
	public long Value { get; set; } // 0x0000000181023880-0x0000000181023890 0x00000001810238B0-0x00000001810238D0
	public long this[int key] { get => default; set {} } // 0x0000000181023870-0x0000000181023880 0x0000000181023890-0x00000001810238B0

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 12671
	{
		// Fields
		public int inKey; // 0x10

		// Constructors
		public <>c__DisplayClass13_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <SetValueLazy>b__0(UserVarSetOperation existingOperation); // 0x0000000181034530-0x0000000181034540
		internal bool <SetValueLazy>b__1(UserVarSetOperation existingOperation); // 0x0000000181034530-0x0000000181034540
	}

	// Constructors
	public CachedUserVar(); // 0x0000000181023780-0x00000001810237F0
	public CachedUserVar(string userVarDefId); // 0x00000001810237F0-0x0000000181023870

	// Methods
	public long GetValue(int inKey); // 0x0000000181023360-0x00000001810234E0
	public void SetValue(int inKey, long inValue, int inValue2 = 0 /* Metadata: 0x00782FE9 */); // 0x00000001810236F0-0x0000000181023780
	public void SetValueLazy(int inKey, long inValue, int inValue2 = 0 /* Metadata: 0x00782FED */); // 0x0000000181023520-0x00000001810236F0
	public void ApplyPendingSetOperations(); // 0x0000000181023220-0x00000001810232C0
	public void RefreshCache(); // 0x00000001810234E0-0x0000000181023520
	public long GetDefaultValue(); // 0x00000001810232C0-0x0000000181023360
	public void ClearUserVarDebug(); // 0x00000001803581E0-0x00000001803581F0
}

