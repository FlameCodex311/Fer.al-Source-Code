/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[Serializable]
public class UI_TabGroup : MonoBehaviour // TypeDefIndex: 12369
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private int _defaultIndex; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _autoSetup; // 0x24
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _allowSelectCurrent; // 0x25
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _allowNoneSelected; // 0x26
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _selectNoneBeforeSwitching; // 0x27
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _controlGameObjectActivation; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWSmoothLayout _smoothLayout; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWSmoothLayout _rootSmoothLayout; // 0x38
	[SerializeField] // 0x0000000180153780-0x00000001801537D0
	[Tooltip] // 0x0000000180153780-0x00000001801537D0
	private WWTextMeshProUGUI _headerText; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private List<UI_Tab> _tabs; // 0x48
	private Action<int> _onTabSelected; // 0x50
	private bool _isSetup; // 0x58
	private int _currentSelected; // 0x5C

	// Properties
	public bool AllowSelectCurrent { get; } // 0x0000000180487D90-0x0000000180487DA0 
	public bool AllowNoneSelected { get; } // 0x0000000180487D60-0x0000000180487D70 
	public bool ControlGameObjectActivation { get; } // 0x00000001803A2790-0x00000001803A27A0 
	public WWSmoothLayout SmoothLayout { get; } // 0x0000000180397720-0x0000000180397730 
	public WWSmoothLayout RootSmoothLayout { get; } // 0x0000000180369BB0-0x0000000180369BC0 
	public WWTextMeshProUGUI HeaderText { get; } // 0x0000000180369B30-0x0000000180369B40 
	public List<UI_Tab> Tabs { get; } // 0x0000000180369C40-0x0000000180369C50 
	public int CurrentSelected { get; } // 0x00000001804A3740-0x00000001804A3750 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass31_0 // TypeDefIndex: 12370
	{
		// Fields
		public UI_TabGroup <>4__this; // 0x10
		public UI_Tab inClickedTab; // 0x18
		public int tabIndex; // 0x20

		// Constructors
		public <>c__DisplayClass31_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnTabClicked>b__0(); // 0x0000000180F8F180-0x0000000180F8F370
	}

	// Constructors
	public UI_TabGroup(); // 0x0000000180F920F0-0x0000000180F92170

	// Methods
	private void OnEnable(); // 0x0000000180F91A50-0x0000000180F91A70
	public void Setup(int inSelectedIndex = -1 /* Metadata: 0x00782E91 */, Action<int> inOnTabSelected = null); // 0x0000000180F91F40-0x0000000180F920F0
	public void OnTabClicked(UI_Tab inClickedTab); // 0x0000000180F91A70-0x0000000180F91E70
	public void ClickTab(int inTabIndex); // 0x0000000180F918F0-0x0000000180F91A50
	public void SetTabEnabled(int inTabIndex, bool inEnabled); // 0x0000000180F91E70-0x0000000180F91F40
}

