/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public abstract class UI_LazyListItemDetailPanel<T> : MonoBehaviour // TypeDefIndex: 12178
	where T : class
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected CanvasGroup _canvasGroup;
	protected UI_LazyListItem<T> _dataSrc;
	private bool _isSearchMode;

	// Constructors
	protected UI_LazyListItemDetailPanel();

	// Methods
	public virtual void Setup(UI_LazyListItem<T> inDataSrc);
	public virtual void Refresh();
	public virtual void SetSearchMode(bool inIsSearchMode);
	public virtual void CalculateUINavigation(List<UI_LazyListItem<T>> inItemsAbove, List<UI_LazyListItem<T>> inItemsBelow);
	public virtual List<Selectable> GetSelectables();
	protected virtual void OnEnable();
	protected virtual void OnDisable();
	protected virtual void Reset();
}

