/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[RequireComponent] // 0x00000001801E4B60-0x00000001801E4BE0
[RequireComponent] // 0x00000001801E4B60-0x00000001801E4BE0
public class UI_LazyListItem<T> : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, ISelectHandler // TypeDefIndex: 13723
	where T : class
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _useOnSelect;
	protected UI_LazyItemList<T> _itemList;
	private Action<UI_LazyListItem<T>> _onClicked;
	private Action<UI_LazyListItem<T>> _onSelected;
	private T _data;
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralButton _button;
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _rectTransform;
	private bool _pointerIsDown;
	private int _categoryIndex;
	private bool _isSearchMode;

	// Properties
	public T Data { get; }
	public FeralButton Button { get; }
	public RectTransform RectTransform { get; }
	public int CategoryIndex { get; set; }
	public bool HasCategory { get; }

	// Constructors
	public UI_LazyListItem();

	// Methods
	public virtual void Setup(Action<UI_LazyListItem<T>> inOnClicked, Action<UI_LazyListItem<T>> inOnSelected, T inData, UI_LazyItemList<T> inItemList);
	public virtual void ResetData();
	public virtual void Refresh();
	public virtual void MarkAsSelected(bool inIsSelected);
	public void OnPointerDown(PointerEventData eventData);
	public void OnPointerUp(PointerEventData eventData);
	public virtual void OnSelect(BaseEventData eventData);
	public void ClickItem();
	public virtual void SetSearchMode(bool inIsSearchMode);
	protected virtual void Start();
	protected virtual void OnClicked();
	private void Reset();
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnSelect>b__27_0();
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnSelect>b__27_1();
}

