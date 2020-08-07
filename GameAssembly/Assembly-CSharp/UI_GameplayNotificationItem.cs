/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_GameplayNotificationItem : MonoBehaviour // TypeDefIndex: 13734
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _iconImage; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _iconRawImage; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nameText; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _countText; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _audioInfo; // 0x48
	private Notification _notification; // 0x50
	private bool _isFirstSetup; // 0x58

	// Properties
	public Notification Notification { get; } // 0x0000000180378320-0x0000000180378330 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 13735
	{
		// Fields
		public UI_GameplayNotificationItem <>4__this; // 0x10
		public Action inOnHideComplete; // 0x18

		// Constructors
		public <>c__DisplayClass13_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Hide>b__0(); // 0x0000000180373250-0x00000001803732F0
	}

	// Constructors
	public UI_GameplayNotificationItem(); // 0x0000000180378310-0x0000000180378320

	// Methods
	public void Setup(Notification inNotification, UI_Window_GameplayNotifications inWindow); // 0x0000000180377FC0-0x0000000180378240
	public void RefreshText(bool inAnimate); // 0x0000000180377D40-0x0000000180377FC0
	public void Show(); // 0x0000000180378240-0x0000000180378310
	public void Hide(Action inOnHideComplete); // 0x0000000180377C80-0x0000000180377D40
}

