/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[Serializable]
public class UI_TabGroup : MonoBehaviour // TypeDefIndex: 13954
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private int _defaultIndex; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _autoSetup; // 0x24
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _allowSelectCurrent; // 0x25
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _allowNoneSelected; // 0x26
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _selectNoneBeforeSwitching; // 0x27
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _controlGameObjectActivation; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWSmoothLayout _smoothLayout; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWSmoothLayout _rootSmoothLayout; // 0x38
	[SerializeField] // 0x000000018024A8A0-0x000000018024A8F0
	[Tooltip] // 0x000000018024A8A0-0x000000018024A8F0
	private WWTextMeshProUGUI _headerText; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private List<UI_Tab> _tabs; // 0x48
	private Action<int> _onTabSelected; // 0x50
	private bool _isSetup; // 0x58
	private int _currentSelected; // 0x5C

	// Properties
	public bool AllowSelectCurrent { get; } // 0x00000001804D2E30-0x00000001804D2E40 
	public bool AllowNoneSelected { get; } // 0x00000001804D2E20-0x00000001804D2E30 
	public bool ControlGameObjectActivation { get; } // 0x00000001804C6790-0x00000001804C67A0 
	public WWSmoothLayout SmoothLayout { get; } // 0x00000001803745C0-0x00000001803745D0 
	public WWSmoothLayout RootSmoothLayout { get; } // 0x00000001803743D0-0x00000001803743E0 
	public WWTextMeshProUGUI HeaderText { get; } // 0x00000001803C7290-0x00000001803C72A0 
	public List<UI_Tab> Tabs { get; } // 0x00000001803743E0-0x00000001803743F0 
	public int CurrentSelected { get; } // 0x00000001804D2E40-0x00000001804D2E50 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass31_0 // TypeDefIndex: 13955
	{
		// Fields
		public UI_TabGroup <>4__this; // 0x10
		public UI_Tab inClickedTab; // 0x18
		public int tabIndex; // 0x20

		// Constructors
		public <>c__DisplayClass31_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnTabClicked>b__0(); // 0x00000001804C2F50-0x00000001804C3130
	}

	// Constructors
	public UI_TabGroup(); // 0x00000001804D2DA0-0x00000001804D2E20

	// Methods
	private void OnEnable(); // 0x00000001804D25D0-0x00000001804D25F0
	public void Setup(int inSelectedIndex = -1 /* Metadata: 0x007BA5A8 */, Action<int> inOnTabSelected = null); // 0x00000001804D2BF0-0x00000001804D2DA0
	public void OnTabClicked(UI_Tab inClickedTab); // 0x00000001804D25F0-0x00000001804D29E0
	public void ClickTab(int inTabIndex); // 0x00000001804D2470-0x00000001804D25D0
	public void SetTabEnabled(int inTabIndex, bool inEnabled); // 0x00000001804D29E0-0x00000001804D2BF0
}

