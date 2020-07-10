/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_LoadingBlocker : MonoBehaviour // TypeDefIndex: 13630
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static UI_LoadingBlocker <instance>k__BackingField; // 0x00
	public CanvasGroup mainCanvasGroup; // 0x20
	public UnityEvent OnShowEvent; // 0x28
	public UnityEvent OnHideEvent; // 0x30
	public UnityEvent OnShowCompleteEvent; // 0x38
	public UnityEvent OnHideCompleteEvent; // 0x40
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsFading>k__BackingField; // 0x48
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsVisible>k__BackingField; // 0x49
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RectTransform _loadingSpiral; // 0x50
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Camera _uiCamera; // 0x58

	// Properties
	public static UI_LoadingBlocker instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180E80400-0x0000000180E80480 0x0000000180E80480-0x0000000180E804C0
	public bool IsFading { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001805E3A60-0x00000001805E3A70 0x000000018082AC70-0x000000018082AC80
	public bool IsVisible { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x00000001805E3A70-0x00000001805E3A80 0x000000018081E340-0x000000018081E350
	public bool IsVisibleOrFading { get; } // 0x0000000180E803F0-0x0000000180E80400 

	// Constructors
	public UI_LoadingBlocker(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public void Start(); // 0x0000000180E80250-0x0000000180E80390
	private void Update(); // 0x00000001803581E0-0x00000001803581F0
	public void Show(Vector2 inViewportPosition = default); // 0x0000000180E7FE40-0x0000000180E80250
	public void Hide(); // 0x0000000180E7FB60-0x0000000180E7FCA0
	public void HideAndDestroy(); // 0x0000000180E7FAE0-0x0000000180E7FB60
	private void ResetToHidden(); // 0x0000000180E7FD60-0x0000000180E7FE40
	private void OnDestroy(); // 0x0000000180E7FCA0-0x0000000180E7FD60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Show>b__23_0(); // 0x0000000180E803C0-0x0000000180E803F0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Hide>b__24_0(); // 0x0000000180E80390-0x0000000180E803C0
}

