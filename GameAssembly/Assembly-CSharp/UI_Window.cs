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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

[ManagedBehaviourManager] // 0x0000000180283320-0x00000001802833A0
[RequireComponent] // 0x0000000180283320-0x00000001802833A0
public class UI_Window : UI_Panel // TypeDefIndex: 11308
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected Canvas _canvas; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected GraphicRaycaster _raycaster; // 0x68
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected bool _focusOnOpen; // 0x70
	[SerializeField] // 0x0000000180283A50-0x0000000180283AA0
	[Tooltip] // 0x0000000180283A50-0x0000000180283AA0
	protected string _openTweenID; // 0x78
	[SerializeField] // 0x0000000180283C50-0x0000000180283CA0
	[Tooltip] // 0x0000000180283C50-0x0000000180283CA0
	protected string _closeTweenID; // 0x80
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool _delayOpenAnimation; // 0x88
	private bool _openAnimationIsDelaying; // 0x89
	public UIWindowEvent OnOpenEvent; // 0x90
	public UIWindowEvent OnOpenAnimationDelayCompleteEvent; // 0x98
	public UIWindowEvent OnOpenCompleteEvent; // 0xA0
	public UIWindowEvent OnCloseEvent; // 0xA8
	public UIWindowEvent OnCloseCompleteEvent; // 0xB0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected BackButtonBehavior _backButtonBehavior; // 0xB8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected UIWindowEvent _onBackButtonEvent; // 0xC0
	private bool _assetsCleared; // 0xC8
	private WindowState _currentState; // 0xCC
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected bool _clearAssetsOnClose; // 0xD0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	protected bool _destroyOnClose; // 0xD1
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CoreWindowManager.UILayer _uiLayer; // 0xD4
	private Tween _longestOpenTween; // 0xD8
	private Tween _longestCloseTween; // 0xE0
	private Waiter _openWaiter; // 0xE8
	private Waiter _closeWaiter; // 0xF0
	protected bool _useOpenAnimation; // 0xF8
	protected Canvas[] _subCanvases; // 0x100

	// Properties
	public Canvas canvas { get; } // 0x0000000180418970-0x0000000180418980 
	public GraphicRaycaster Raycaster { get; } // 0x00000001803765E0-0x00000001803765F0 
	public string OpenTweenID { get; } // 0x0000000180418A40-0x0000000180418A50 
	public string CloseTweenID { get; } // 0x000000018040ED60-0x000000018040ED70 
	public bool DelayOpenAnimation { get; } // 0x00000001804A0200-0x00000001804A0210 
	public bool OpenAnimationIsDelaying { get; } // 0x0000000180647A40-0x0000000180647A50 
	public WindowState CurrentState { get; } // 0x00000001806479E0-0x00000001806479F0 
	public bool IsOpenOrOpening { get; } // 0x0000000180647A00-0x0000000180647A20 
	public bool IsOpening { get; } // 0x0000000180647A30-0x0000000180647A40 
	public bool IsClosing { get; } // 0x00000001806479F0-0x0000000180647A00 
	public bool IsOpen { get; } // 0x0000000180647A20-0x0000000180647A30 
	public bool CanOpen { get; } // 0x00000001806479C0-0x00000001806479E0 
	public bool CanClose { get; } // 0x00000001806479A0-0x00000001806479C0 
	public CoreWindowManager.UILayer UILayer { get; } // 0x0000000180556930-0x0000000180556940 

	// Nested types
	public enum BackButtonBehavior // TypeDefIndex: 11309
	{
		None = 0,
		Close = 1,
		Custom = 2
	}

	public enum WindowState // TypeDefIndex: 11310
	{
		Open = 0,
		Opening = 1,
		Closed = 2,
		Closing = 3
	}

	// Constructors
	public UI_Window(); // 0x0000000180647920-0x00000001806479A0

	// Methods
	public override void MAwake(); // 0x0000000180646150-0x00000001806464C0
	public override void MOnDisable(); // 0x00000001806465B0-0x0000000180646630
	public override void MOnDestroy(); // 0x00000001806464C0-0x00000001806465B0
	public void Toggle(bool inAnimate = true /* Metadata: 0x0077C9D3 */); // 0x00000001806478E0-0x0000000180647920
	public void Open(bool force = false /* Metadata: 0x0077C9D4 */, bool inAnimate = true /* Metadata: 0x0077C9D5 */); // 0x00000001806471F0-0x00000001806472E0
	public void Close(bool inForceClose = false /* Metadata: 0x0077C9D6 */, bool inAnimate = true /* Metadata: 0x0077C9D7 */); // 0x0000000180645AC0-0x0000000180645B00
	public void Close(bool inForceClose); // 0x0000000180645B00-0x0000000180645B30
	public void CloseInstant(bool inForceClose); // 0x0000000180645A90-0x0000000180645AC0
	public void Show(); // 0x0000000180647610-0x00000001806478E0
	public void Hide(); // 0x0000000180645BA0-0x0000000180645D60
	protected virtual void OnOpen(); // 0x0000000180646ED0-0x00000001806470F0
	protected virtual void OnOpen(bool inAnimate); // 0x00000001806470F0-0x0000000180647110
	protected virtual void DoDelayedOpenAnimation(); // 0x0000000180645B30-0x0000000180645BA0
	protected virtual void PlayOpenAnimation(); // 0x0000000180647460-0x00000001806475C0
	protected virtual void OnOpenComplete(); // 0x0000000180646D60-0x0000000180646ED0
	protected virtual void OnClose(bool inAnimate); // 0x0000000180646AE0-0x0000000180646C60
	protected virtual void PlayCloseAnimation(); // 0x00000001806472E0-0x0000000180647460
	protected virtual void OnCloseComplete(); // 0x00000001806467A0-0x0000000180646AE0
	protected virtual void OnShow(); // 0x0000000180647110-0x00000001806471F0
	protected virtual void OnHide(); // 0x0000000180646C60-0x0000000180646D40
	private void OnTransformChildrenChanged(); // 0x00000001803774A0-0x00000001803774B0
	public override void MUpdate(); // 0x0000000180646630-0x0000000180646780
	protected void BackButtonPressed(); // 0x0000000180645980-0x0000000180645A20
	protected virtual void OnBackButton(); // 0x00000001803774A0-0x00000001803774B0
	private void Reset(); // 0x00000001806475C0-0x0000000180647610
	private void InitTweens(); // 0x0000000180645D60-0x0000000180646150
	private void OnOpenAnimComplete(); // 0x0000000180646D40-0x0000000180646D60
	private void OnCloseAnimComplete(); // 0x0000000180646780-0x00000001806467A0
	private void ClearAssets(); // 0x0000000180645A20-0x0000000180645A90
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <DoDelayedOpenAnimation>b__67_0(); // 0x00000001803B6890-0x00000001803B68B0
}

