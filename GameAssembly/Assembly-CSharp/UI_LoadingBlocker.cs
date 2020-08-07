/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_LoadingBlocker : MonoBehaviour // TypeDefIndex: 11297
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static UI_LoadingBlocker <instance>k__BackingField; // 0x00
	public CanvasGroup mainCanvasGroup; // 0x20
	public UnityEvent OnShowEvent; // 0x28
	public UnityEvent OnHideEvent; // 0x30
	public UnityEvent OnShowCompleteEvent; // 0x38
	public UnityEvent OnHideCompleteEvent; // 0x40
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsFading>k__BackingField; // 0x48
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsVisible>k__BackingField; // 0x49
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RectTransform _loadingSpiral; // 0x50
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Camera _uiCamera; // 0x58

	// Properties
	public static UI_LoadingBlocker instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803C9D90-0x00000001803C9DD0 0x00000001803C9DF0-0x00000001803C9E30
	public bool IsFading { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803C9D60-0x00000001803C9D70 0x00000001803C9DD0-0x00000001803C9DE0
	public bool IsVisible { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803C9D80-0x00000001803C9D90 0x00000001803C9DE0-0x00000001803C9DF0
	public bool IsVisibleOrFading { get; } // 0x00000001803C9D70-0x00000001803C9D80 

	// Constructors
	public UI_LoadingBlocker(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Start(); // 0x00000001803C9BC0-0x00000001803C9D00
	private void Update(); // 0x00000001803774A0-0x00000001803774B0
	public void Show(Vector2 inViewportPosition = default); // 0x00000001803C97C0-0x00000001803C9BC0
	public void Hide(); // 0x00000001803C94F0-0x00000001803C9630
	public void HideAndDestroy(); // 0x00000001803C9470-0x00000001803C94F0
	private void ResetToHidden(); // 0x00000001803C96F0-0x00000001803C97C0
	private void OnDestroy(); // 0x00000001803C9630-0x00000001803C96F0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Show>b__23_0(); // 0x00000001803C9D30-0x00000001803C9D60
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Hide>b__24_0(); // 0x00000001803C9D00-0x00000001803C9D30
}

