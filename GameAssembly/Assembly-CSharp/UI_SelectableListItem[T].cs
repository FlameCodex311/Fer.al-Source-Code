/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public abstract class UI_SelectableListItem<T> : MonoBehaviour // TypeDefIndex: 13740
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected GameObject _groupSelected;
	private T _data;
	protected bool _isSelected;
	private Action<UI_SelectableListItem<T>> _onClicked;
	private Action<UI_SelectableListItem<T>> _onLongPressed;

	// Properties
	public T Data { get; }

	// Constructors
	protected UI_SelectableListItem();

	// Methods
	public virtual void Setup(T inData, Action<UI_SelectableListItem<T>> inOnClicked, Action<UI_SelectableListItem<T>> inOnLongPressed);
	public void BtnClicked_Select();
	public void BtnLongClicked_Select();
	public virtual void MarkAsSelected(bool inSelected, bool inMultiSelectMode);
}

