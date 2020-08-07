/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unitilities.Tuples;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public abstract class UI_ThemeApplier : MonoBehaviour, ISerializationCallbackReceiver // TypeDefIndex: 11263
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected string _dataId; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected bool _editMode; // 0x28

	// Constructors
	protected UI_ThemeApplier(); // 0x00000001806359F0-0x0000000180635A30

	// Methods
	public abstract List<StringTuple> GetDataOptions();
	public void OnAfterDeserialize(); // 0x00000001803774A0-0x00000001803774B0
	public void OnBeforeSerialize(); // 0x00000001803774A0-0x00000001803774B0
	public abstract bool AddThemeDataFromTarget(string inName);
	public abstract bool UpdateThemeDataFromTarget(string inId, string inName);
	protected abstract void ApplyTheme();
	protected abstract void DereferenceAssets();
	private void OnEnable(); // 0x0000000180635940-0x00000001806359F0
	private void OnDisable(); // 0x00000001806358A0-0x0000000180635940
	private void OnThemeChanged(ThemeChangedMessage inMessage); // 0x000000018037F800-0x000000018037F820
}

