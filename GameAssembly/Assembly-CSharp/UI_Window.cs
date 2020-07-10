/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using WW.Waiters;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

[ManagedBehaviourManager] // 0x00000001800E6360-0x00000001800E63E0
[RequireComponent] // 0x00000001800E6360-0x00000001800E63E0
public class UI_Window : UI_Panel // TypeDefIndex: 13641
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected Canvas _canvas; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected GraphicRaycaster _raycaster; // 0x68
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected bool _focusOnOpen; // 0x70
	[SerializeField] // 0x00000001800E69A0-0x00000001800E69F0
	[Tooltip] // 0x00000001800E69A0-0x00000001800E69F0
	protected string _openTweenID; // 0x78
	[SerializeField] // 0x00000001800E6B60-0x00000001800E6BB0
	[Tooltip] // 0x00000001800E6B60-0x00000001800E6BB0
	protected string _closeTweenID; // 0x80
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private bool _delayOpenAnimation; // 0x88
	private bool _openAnimationIsDelaying; // 0x89
	public UIWindowEvent OnOpenEvent; // 0x90
	public UIWindowEvent OnOpenAnimationDelayCompleteEvent; // 0x98
	public UIWindowEvent OnOpenCompleteEvent; // 0xA0
	public UIWindowEvent OnCloseEvent; // 0xA8
	public UIWindowEvent OnCloseCompleteEvent; // 0xB0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected BackButtonBehavior _backButtonBehavior; // 0xB8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected UIWindowEvent _onBackButtonEvent; // 0xC0
	private bool _assetsCleared; // 0xC8
	private WindowState _currentState; // 0xCC
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected bool _clearAssetsOnClose; // 0xD0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	protected bool _destroyOnClose; // 0xD1
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CoreWindowManager.UILayer _uiLayer; // 0xD4
	private Tween _longestOpenTween; // 0xD8
	private Tween _longestCloseTween; // 0xE0
	private Waiter _openWaiter; // 0xE8
	private Waiter _closeWaiter; // 0xF0
	protected bool _useOpenAnimation; // 0xF8
	protected Canvas[] _subCanvases; // 0x100

	// Properties
	public Canvas canvas { get; } // 0x0000000180369B40-0x0000000180369B50 
	public GraphicRaycaster Raycaster { get; } // 0x0000000180358970-0x0000000180358980 
	public string OpenTweenID { get; } // 0x0000000180369C70-0x0000000180369C80 
	public string CloseTweenID { get; } // 0x000000018035FCB0-0x000000018035FCC0 
	public bool DelayOpenAnimation { get; } // 0x00000001804E88A0-0x00000001804E88B0 
	public bool OpenAnimationIsDelaying { get; } // 0x00000001804EB070-0x00000001804EB080 
	public WindowState CurrentState { get; } // 0x0000000180424130-0x0000000180424140 
	public bool IsOpenOrOpening { get; } // 0x0000000180FA19A0-0x0000000180FA19C0 
	public bool IsOpening { get; } // 0x0000000180FA19D0-0x0000000180FA19E0 
	public bool IsClosing { get; } // 0x0000000180FA1990-0x0000000180FA19A0 
	public bool IsOpen { get; } // 0x0000000180FA19C0-0x0000000180FA19D0 
	public bool CanOpen { get; } // 0x0000000180FA1970-0x0000000180FA1990 
	public bool CanClose { get; } // 0x0000000180FA1950-0x0000000180FA1970 
	public CoreWindowManager.UILayer UILayer { get; } // 0x0000000180F44090-0x0000000180F440A0 

	// Nested types
	public enum BackButtonBehavior // TypeDefIndex: 13642
	{
		None = 0,
		Close = 1,
		Custom = 2
	}

	public enum WindowState // TypeDefIndex: 13643
	{
		Open = 0,
		Opening = 1,
		Closed = 2,
		Closing = 3
	}

	// Constructors
	public UI_Window(); // 0x0000000180FA18D0-0x0000000180FA1950

	// Methods
	public override void MAwake(); // 0x0000000180FA00D0-0x0000000180FA0450
	public override void MOnDisable(); // 0x0000000180FA0540-0x0000000180FA05C0
	public override void MOnDestroy(); // 0x0000000180FA0450-0x0000000180FA0540
	public void Toggle(bool inAnimate = true /* Metadata: 0x00783F14 */); // 0x0000000180FA1890-0x0000000180FA18D0
	public void Open(bool force = false /* Metadata: 0x00783F15 */, bool inAnimate = true /* Metadata: 0x00783F16 */); // 0x0000000180FA1190-0x0000000180FA1280
	public void Close(bool inForceClose = false /* Metadata: 0x00783F17 */, bool inAnimate = true /* Metadata: 0x00783F18 */); // 0x0000000180F9FA40-0x0000000180F9FA80
	public void Close(bool inForceClose); // 0x0000000180F9FA80-0x0000000180F9FAB0
	public void CloseInstant(bool inForceClose); // 0x0000000180F9FA10-0x0000000180F9FA40
	public void Show(); // 0x0000000180FA15B0-0x0000000180FA1890
	public void Hide(); // 0x0000000180F9FB20-0x0000000180F9FCE0
	protected virtual void OnOpen(); // 0x0000000180FA0E70-0x0000000180FA1090
	protected virtual void OnOpen(bool inAnimate); // 0x0000000180FA1090-0x0000000180FA10B0
	protected virtual void DoDelayedOpenAnimation(); // 0x0000000180F9FAB0-0x0000000180F9FB20
	protected virtual void PlayOpenAnimation(); // 0x0000000180FA1400-0x0000000180FA1560
	protected virtual void OnOpenComplete(); // 0x0000000180FA0D00-0x0000000180FA0E70
	protected virtual void OnClose(bool inAnimate); // 0x0000000180FA0A80-0x0000000180FA0C00
	protected virtual void PlayCloseAnimation(); // 0x0000000180FA1280-0x0000000180FA1400
	protected virtual void OnCloseComplete(); // 0x0000000180FA0730-0x0000000180FA0A80
	protected virtual void OnShow(); // 0x0000000180FA10B0-0x0000000180FA1190
	protected virtual void OnHide(); // 0x0000000180FA0C00-0x0000000180FA0CE0
	private void OnTransformChildrenChanged(); // 0x00000001803581E0-0x00000001803581F0
	public override void MUpdate(); // 0x0000000180FA05C0-0x0000000180FA0710
	protected void BackButtonPressed(); // 0x0000000180F9F900-0x0000000180F9F9A0
	protected virtual void OnBackButton(); // 0x00000001803581E0-0x00000001803581F0
	private void Reset(); // 0x0000000180FA1560-0x0000000180FA15B0
	private void InitTweens(); // 0x0000000180F9FCE0-0x0000000180FA00D0
	private void OnOpenAnimComplete(); // 0x0000000180FA0CE0-0x0000000180FA0D00
	private void OnCloseAnimComplete(); // 0x0000000180FA0710-0x0000000180FA0730
	private void ClearAssets(); // 0x0000000180F9F9A0-0x0000000180F9FA10
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <DoDelayedOpenAnimation>b__67_0(); // 0x00000001809E8060-0x00000001809E8080
}

