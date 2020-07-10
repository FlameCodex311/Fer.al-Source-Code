/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class DebugMenuBuilder // TypeDefIndex: 13213
{
	// Fields
	private List<DMI> instructions; // 0x10

	// Nested types
	private enum DMC // TypeDefIndex: 13214
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

	private class DMI // TypeDefIndex: 13215
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
		public DMI(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	// Constructors
	public DebugMenuBuilder(); // 0x000000018036B6C0-0x000000018036B6D0

	// Methods
	public DebugMenuBuilder Begin(); // 0x0000000181182B10-0x0000000181182B70
	public void Complete(); // 0x0000000181182D80-0x0000000181183000
	public DebugMenuBuilder Tab(string title); // 0x00000001811833F0-0x00000001811834A0
	public DebugMenuBuilder SwitchTab(int tabIndex); // 0x0000000181183350-0x00000001811833F0
	public DebugMenuBuilder Section(string title, string id = null); // 0x0000000181183290-0x0000000181183350
	public DebugMenuBuilder SectionEnd(); // 0x0000000181183200-0x0000000181183290
	public DebugMenuBuilder HGroup(string id = null); // 0x0000000181183090-0x0000000181183140
	public DebugMenuBuilder HGroupEnd(); // 0x0000000181183000-0x0000000181183090
	public DebugMenuBuilder VGroup(string id = null); // 0x00000001811836B0-0x0000000181183760
	public DebugMenuBuilder VGroupEnd(); // 0x0000000181183620-0x00000001811836B0
	public DebugMenuBuilder Collapse(string title, bool startOpen = false /* Metadata: 0x00783968 */, string id = null); // 0x0000000181182CC0-0x0000000181182D80
	public DebugMenuBuilder CollapseEnd(); // 0x0000000181182C30-0x0000000181182CC0
	public DebugMenuBuilder Text(string text, Func<string> getter = null, string id = null); // 0x00000001811834A0-0x0000000181183560
	public DebugMenuBuilder Input(Func<string> getter = null, Action<string> setter = null, string id = null); // 0x0000000181183140-0x0000000181183200
	public DebugMenuBuilder Button(string text = null, Action action = null, string id = null); // 0x0000000181182B70-0x0000000181182C30
	public DebugMenuBuilder Toggle(string text = null, Func<bool> getter = null, Action<bool> setter = null, string id = null); // 0x0000000181183560-0x0000000181183620
}

