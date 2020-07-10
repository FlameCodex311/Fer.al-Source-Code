/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class TabGroup // TypeDefIndex: 12247
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	public List<OldTab> tabs; // 0x10
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _defaultTabIndex; // 0x18
	public Action<int, OldTab, bool> onTabSelected; // 0x20
	private int _currentTabIndex; // 0x28

	// Properties
	public int CurrentTabIndex { get; } // 0x000000018038E0E0-0x000000018038E0F0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass6_0 // TypeDefIndex: 12248
	{
		// Fields
		public OldTab tab; // 0x10
		public TabGroup <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass6_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Setup>b__0(); // 0x0000000181213300-0x0000000181213330
	}

	// Constructors
	public TabGroup(); // 0x0000000181209110-0x0000000181209180

	// Methods
	public void Setup(Action<int, OldTab, bool> inOnTabSelected); // 0x0000000181208C70-0x0000000181208E90
	public void SelectCurrentTab(); // 0x0000000181208A90-0x0000000181208AB0
	public void SelectDefaultTab(bool inSelectedFromSetup = false /* Metadata: 0x00782E00 */); // 0x0000000181208AB0-0x0000000181208BC0
	public void SelectTab(int inTabIndex, bool inSelectedFromSetup = false /* Metadata: 0x00782E01 */); // 0x0000000181208BC0-0x0000000181208C60
	public void SelectTab(OldTab inTab, bool inSelectedFromSetup = false /* Metadata: 0x00782E02 */); // 0x0000000181208C60-0x0000000181208C70
	public void TabLeft(); // 0x0000000181208FC0-0x0000000181209060
	public void TabRight(); // 0x0000000181209060-0x0000000181209110
	private void TabClicked(OldTab inTab, bool inSelectedFromSetup = false /* Metadata: 0x00782E03 */); // 0x0000000181208E90-0x0000000181208FC0
}

