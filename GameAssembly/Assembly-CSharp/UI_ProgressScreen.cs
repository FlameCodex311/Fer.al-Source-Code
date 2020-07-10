/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_ProgressScreen : MonoBehaviour // TypeDefIndex: 13632
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static UI_ProgressScreen <instance>k__BackingField; // 0x00
	public GameObject groupBlocker; // 0x20
	public CanvasGroup mainCanvasGroup; // 0x28
	[Header] // 0x00000001800E0F40-0x00000001800E0F70
	public GameObject progressBarGroup; // 0x30
	public Slider progressBarSlider; // 0x38
	public List<UnityEngine.UI.Text> labelListProgressBar; // 0x40
	private float _toProgressBarValue; // 0x48
	private float _lastToProgressBarValue; // 0x4C
	[Header] // 0x00000001800E1200-0x00000001800E1230
	public CanvasGroup spinnerCanvasGroup; // 0x50
	public List<UnityEngine.UI.Text> labelListSpinner; // 0x58
	public UnityEvent OnShowEvent; // 0x60
	public UnityEvent OnHideEvent; // 0x68
	public UnityEvent OnShowCompleteEvent; // 0x70
	public UnityEvent OnHideCompleteEvent; // 0x78
	private Coroutine _switchStateToProgressRoutine; // 0x80
	private Coroutine _internetConnectionTesterRoutine; // 0x88
	private float _toProgressFailureTime; // 0x90
	private float _toProgressFailureTimer; // 0x94
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsFading>k__BackingField; // 0x98
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <IsVisible>k__BackingField; // 0x99
	[Header] // 0x00000001800E17E0-0x00000001800E1830
	[SerializeField] // 0x00000001800E17E0-0x00000001800E1830
	private Sprite _loadingExpanse; // 0xA0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite _loadingCityFera; // 0xA8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite _loadingTradersPort; // 0xB0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite _loadingSanctuary; // 0xB8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Image _backgroundImage; // 0xC0
	private Color _transparent; // 0xC8
	private Color _opaque; // 0xD8
	private UI_ProgressState _state; // 0xE8

	// Properties
	public static UI_ProgressScreen instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180EE4B80-0x0000000180EE4BC0 0x0000000180EE4D70-0x0000000180EE4DB0
	public bool IsFading { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x000000018081DF30-0x000000018081DF40 0x000000018081F000-0x000000018081F010
	public bool IsVisible { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180EE4B60-0x0000000180EE4B70 0x0000000180EE4BC0-0x0000000180EE4BD0
	public bool IsVisibleOrFading { get; } // 0x0000000180EE4B40-0x0000000180EE4B60 
	public UI_ProgressState State { get; set; } // 0x0000000180EE4B70-0x0000000180EE4B80 0x0000000180EE4BD0-0x0000000180EE4D70

	// Nested types
	public enum UI_ProgressState // TypeDefIndex: 13633
	{
		Spinner = 0,
		ProgressBar = 1
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SwitchStateToProgress>d__51 : IEnumerator<object> // TypeDefIndex: 13634
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_ProgressScreen <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SwitchStateToProgress>d__51(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000180EE16F0-0x0000000180EE17D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180EE17D0-0x0000000180EE1820
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass55_0 // TypeDefIndex: 13635
	{
		// Fields
		public UnityEngine.UI.Text inLabel; // 0x10

		// Constructors
		public <>c__DisplayClass55_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <SetLabel>b__0(); // 0x0000000180EE1980-0x0000000180EE19F0
	}

	// Constructors
	public UI_ProgressScreen(); // 0x0000000180EE4A30-0x0000000180EE4B40

	// Methods
	public void Start(); // 0x0000000180EE4230-0x0000000180EE4380
	private void Update(); // 0x0000000180EE4820-0x0000000180EE4A30
	public void UpdateLevel(); // 0x0000000180EE4550-0x0000000180EE4820
	public void Show(); // 0x0000000180EE4070-0x0000000180EE4230
	public void Hide(); // 0x0000000180EE34B0-0x0000000180EE35A0
	public void HideAndDestroy(); // 0x0000000180EE3360-0x0000000180EE34B0
	private void ResetToHidden(); // 0x0000000180EE3660-0x0000000180EE3850
	public void SetProgressBar(float inProgress); // 0x0000000180EE3A60-0x0000000180EE3B70
	[IteratorStateMachine] // 0x00000001800E2820-0x00000001800E2870
	private IEnumerator SwitchStateToProgress(); // 0x0000000180EE4380-0x0000000180EE43E0
	public void ClearLabels(); // 0x0000000180EE2F60-0x0000000180EE3360
	public void SetProgressLabelWithIndex(int inIndex, string inString); // 0x0000000180EE3B70-0x0000000180EE3DF0
	public void SetSpinnerLabelWithIndex(int inIndex, string inString); // 0x0000000180EE3DF0-0x0000000180EE4070
	private void SetLabel(UnityEngine.UI.Text inLabel, string inString); // 0x0000000180EE3850-0x0000000180EE3A60
	private void OnDestroy(); // 0x0000000180EE35A0-0x0000000180EE3660
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <set_State>b__42_0(); // 0x0000000180EE44E0-0x0000000180EE4510
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <set_State>b__42_1(); // 0x0000000180EE4510-0x0000000180EE4550
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private Color <UpdateLevel>b__45_0(); // 0x0000000180EE4450-0x0000000180EE44A0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <UpdateLevel>b__45_1(Color color); // 0x0000000180EE44A0-0x0000000180EE44E0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Show>b__46_0(); // 0x0000000180EE4420-0x0000000180EE4450
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Hide>b__47_0(); // 0x0000000180EE43E0-0x0000000180EE4420
}

