/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SettingsControl_Privacy : MonoBehaviour // TypeDefIndex: 13748
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _tabGroup; // 0x20
	private Action<PrivacySetting.PrivacyLevel> _setter; // 0x28
	private Func<PrivacySetting.PrivacyLevel> _getter; // 0x30

	// Constructors
	public UI_SettingsControl_Privacy(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Setup(Action<PrivacySetting.PrivacyLevel> inSetter, Func<PrivacySetting.PrivacyLevel> inGetter); // 0x00000001804C7A20-0x00000001804C7AE0
	private void OnSettingChosen(int inChosenSetting); // 0x00000001804C79C0-0x00000001804C7A20
}

