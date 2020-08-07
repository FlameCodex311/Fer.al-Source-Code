/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class TabGroup // TypeDefIndex: 13797
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	public List<OldTab> tabs; // 0x10
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _defaultTabIndex; // 0x18
	public Action<int, OldTab, bool> onTabSelected; // 0x20
	private int _currentTabIndex; // 0x28

	// Properties
	public int CurrentTabIndex { get; } // 0x000000018043C680-0x000000018043C690 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 13798
	{
		// Fields
		public OldTab tab; // 0x10
		public TabGroup <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Setup>b__0(); // 0x0000000180962490-0x00000001809624C0
	}

	// Constructors
	public TabGroup(); // 0x0000000180959340-0x00000001809593B0

	// Methods
	public void Setup(Action<int, OldTab, bool> inOnTabSelected); // 0x0000000180958ED0-0x00000001809590E0
	public void SelectCurrentTab(); // 0x0000000180958CF0-0x0000000180958D10
	public void SelectDefaultTab(bool inSelectedFromSetup = false /* Metadata: 0x007BA50E */); // 0x0000000180958D10-0x0000000180958E20
	public void SelectTab(int inTabIndex, bool inSelectedFromSetup = false /* Metadata: 0x007BA50F */); // 0x0000000180958E20-0x0000000180958EC0
	public void SelectTab(OldTab inTab, bool inSelectedFromSetup = false /* Metadata: 0x007BA510 */); // 0x0000000180958EC0-0x0000000180958ED0
	public void TabLeft(); // 0x0000000180959210-0x00000001809592A0
	public void TabRight(); // 0x00000001809592A0-0x0000000180959340
	private void TabClicked(OldTab inTab, bool inSelectedFromSetup = false /* Metadata: 0x007BA511 */); // 0x00000001809590E0-0x0000000180959210
}

