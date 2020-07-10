/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_GameplayNotificationItem : MonoBehaviour // TypeDefIndex: 12187
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _iconImage; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private RawImage _iconRawImage; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nameText; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _countText; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _audioInfo; // 0x48
	private Notification _notification; // 0x50
	private bool _isFirstSetup; // 0x58

	// Properties
	public Notification Notification { get; } // 0x00000001803A27A0-0x00000001803A27B0 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 12188
	{
		// Fields
		public UI_GameplayNotificationItem <>4__this; // 0x10
		public Action inOnHideComplete; // 0x18

		// Constructors
		public <>c__DisplayClass13_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Hide>b__0(); // 0x0000000180E3E080-0x0000000180E3E120
	}

	// Constructors
	public UI_GameplayNotificationItem(); // 0x0000000180E40B10-0x0000000180E40B20

	// Methods
	public void Setup(Notification inNotification, UI_Window_GameplayNotifications inWindow); // 0x0000000180E407B0-0x0000000180E40A40
	public void RefreshText(bool inAnimate); // 0x0000000180E40520-0x0000000180E407B0
	public void Show(); // 0x0000000180E40A40-0x0000000180E40B10
	public void Hide(Action inOnHideComplete); // 0x0000000180E40460-0x0000000180E40520
}

