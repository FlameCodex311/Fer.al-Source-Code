/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class DebugMenuBuilder // TypeDefIndex: 10879
{
	// Fields
	private List<DMI> instructions; // 0x10

	// Nested types
	private enum DMC // TypeDefIndex: 10880
	{
		BeginSection = 0,
		EndSection = 1,
		BeginVertical = 2,
		EndVertical = 3,
		BeginHorizontal = 4,
		EndHorizontal = 5,
		BeginCollapse = 6,
		EndCollapse = 7,
		CreateTab = 8,
		NavigateToTab = 9,
		Button = 10,
		Text = 11,
		Input = 12,
		Toggle = 13
	}

	private class DMI // TypeDefIndex: 10881
	{
		// Fields
		public DMC command; // 0x10
		public int iArg1; // 0x14
		public string sArg1; // 0x18
		public bool bArg1; // 0x20
		public Action actionArg1; // 0x28
		public Func<string> sGetterArg1; // 0x30
		public Action<string> sSetterArg1; // 0x38
		public Func<bool> bGetterArg1; // 0x40
		public Action<bool> bSetterArg1; // 0x48
		public string id; // 0x50

		// Constructors
		public DMI(); // 0x0000000180373240-0x0000000180373250
	}

	// Constructors
	public DebugMenuBuilder(); // 0x0000000180373240-0x0000000180373250

	// Methods
	public DebugMenuBuilder Begin(); // 0x000000018055A8A0-0x000000018055A900
	public void Complete(); // 0x000000018055AB10-0x000000018055ADD0
	public DebugMenuBuilder Tab(string title); // 0x000000018055B1A0-0x000000018055B240
	public DebugMenuBuilder SwitchTab(int tabIndex); // 0x000000018055B100-0x000000018055B1A0
	public DebugMenuBuilder Section(string title, string id = null); // 0x000000018055B050-0x000000018055B100
	public DebugMenuBuilder SectionEnd(); // 0x000000018055AFC0-0x000000018055B050
	public DebugMenuBuilder HGroup(string id = null); // 0x000000018055AE60-0x000000018055AF00
	public DebugMenuBuilder HGroupEnd(); // 0x000000018055ADD0-0x000000018055AE60
	public DebugMenuBuilder VGroup(string id = null); // 0x000000018055B450-0x000000018055B4F0
	public DebugMenuBuilder VGroupEnd(); // 0x000000018055B3C0-0x000000018055B450
	public DebugMenuBuilder Collapse(string title, bool startOpen = false /* Metadata: 0x0077C423 */, string id = null); // 0x000000018055AA50-0x000000018055AB10
	public DebugMenuBuilder CollapseEnd(); // 0x000000018055A9C0-0x000000018055AA50
	public DebugMenuBuilder Text(string text, Func<string> getter = null, string id = null); // 0x000000018055B240-0x000000018055B300
	public DebugMenuBuilder Input(Func<string> getter = null, Action<string> setter = null, string id = null); // 0x000000018055AF00-0x000000018055AFC0
	public DebugMenuBuilder Button(string text = null, Action action = null, string id = null); // 0x000000018055A900-0x000000018055A9C0
	public DebugMenuBuilder Toggle(string text = null, Func<bool> getter = null, Action<bool> setter = null, string id = null); // 0x000000018055B300-0x000000018055B3C0
}

