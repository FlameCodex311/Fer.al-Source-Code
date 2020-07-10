/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unitilities.Tuples;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class UI_ThemeApplier : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 13596
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected string _dataId; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected bool _editMode; // 0x28

	// Constructors
	protected UI_ThemeApplier(); // 0x0000000180F94D80-0x0000000180F94DC0

	// Methods
	public abstract List<StringTuple> GetDataOptions();
	public void OnAfterDeserialize(); // 0x00000001803581E0-0x00000001803581F0
	public void OnBeforeSerialize(); // 0x00000001803581E0-0x00000001803581F0
	public abstract bool AddThemeDataFromTarget(string inName);
	public abstract bool UpdateThemeDataFromTarget(string inId, string inName);
	protected abstract void ApplyTheme();
	protected abstract void DereferenceAssets();
	private void OnEnable(); // 0x0000000180F94CD0-0x0000000180F94D80
	private void OnDisable(); // 0x0000000180F94C30-0x0000000180F94CD0
	private void OnThemeChanged(ThemeChangedMessage inMessage); // 0x00000001806A3950-0x00000001806A3970
}

