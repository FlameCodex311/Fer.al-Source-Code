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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ProgressScreen : MonoBehaviour // TypeDefIndex: 11299
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static UI_ProgressScreen <instance>k__BackingField; // 0x00
	public GameObject groupBlocker; // 0x20
	public CanvasGroup mainCanvasGroup; // 0x28
	[Header] // 0x000000018027DA50-0x000000018027DA80
	public GameObject progressBarGroup; // 0x30
	public Slider progressBarSlider; // 0x38
	public List<UnityEngine.UI.Text> labelListProgressBar; // 0x40
	private float _toProgressBarValue; // 0x48
	private float _lastToProgressBarValue; // 0x4C
	[Header] // 0x000000018027DC10-0x000000018027DC40
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
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsFading>k__BackingField; // 0x98
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <IsVisible>k__BackingField; // 0x99
	[Header] // 0x00000001801D1670-0x00000001801D16C0
	[SerializeField] // 0x00000001801D1670-0x00000001801D16C0
	private Sprite _loadingExpanse; // 0xA0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite _loadingCityFera; // 0xA8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite _loadingTradersPort; // 0xB0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite _loadingSanctuary; // 0xB8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Image _backgroundImage; // 0xC0
	private Color _transparent; // 0xC8
	private Color _opaque; // 0xD8
	private UI_ProgressState _state; // 0xE8

	// Properties
	public static UI_ProgressScreen instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803D3EE0-0x00000001803D3F20 0x00000001803D40E0-0x00000001803D4120
	public bool IsFading { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803D3E90-0x00000001803D3EA0 0x00000001803D3F20-0x00000001803D3F30
	public bool IsVisible { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001803D3EC0-0x00000001803D3ED0 0x00000001803D3F30-0x00000001803D3F40
	public bool IsVisibleOrFading { get; } // 0x00000001803D3EA0-0x00000001803D3EC0 
	public UI_ProgressState State { get; set; } // 0x00000001803D3ED0-0x00000001803D3EE0 0x00000001803D3F40-0x00000001803D40E0

	// Nested types
	public enum UI_ProgressState // TypeDefIndex: 11300
	{
		Spinner = 0,
		ProgressBar = 1
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SwitchStateToProgress>d__51 : IEnumerator<object> // TypeDefIndex: 11301
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_ProgressScreen <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SwitchStateToProgress>d__51(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001803C62E0-0x00000001803C63B0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001803C63B0-0x00000001803C6400
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass55_0 // TypeDefIndex: 11302
	{
		// Fields
		public UnityEngine.UI.Text inLabel; // 0x10

		// Constructors
		public <>c__DisplayClass55_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <SetLabel>b__0(); // 0x00000001803C6710-0x00000001803C6780
	}

	// Constructors
	public UI_ProgressScreen(); // 0x00000001803D3D80-0x00000001803D3E90

	// Methods
	public void Start(); // 0x00000001803D35A0-0x00000001803D36F0
	private void Update(); // 0x00000001803D3B70-0x00000001803D3D80
	public void UpdateLevel(); // 0x00000001803D38B0-0x00000001803D3B70
	public void Show(); // 0x00000001803D33E0-0x00000001803D35A0
	public void Hide(); // 0x00000001803D2880-0x00000001803D2970
	public void HideAndDestroy(); // 0x00000001803D2730-0x00000001803D2880
	private void ResetToHidden(); // 0x00000001803D2A30-0x00000001803D2C10
	public void SetProgressBar(float inProgress); // 0x00000001803D2E10-0x00000001803D2F20
	[IteratorStateMachine] // 0x0000000180280530-0x0000000180280580
	private IEnumerator SwitchStateToProgress(); // 0x00000001803D36F0-0x00000001803D3750
	public void ClearLabels(); // 0x00000001803D2350-0x00000001803D2730
	public void SetProgressLabelWithIndex(int inIndex, string inString); // 0x00000001803D2F20-0x00000001803D3180
	public void SetSpinnerLabelWithIndex(int inIndex, string inString); // 0x00000001803D3180-0x00000001803D33E0
	private void SetLabel(UnityEngine.UI.Text inLabel, string inString); // 0x00000001803D2C10-0x00000001803D2E10
	private void OnDestroy(); // 0x00000001803D2970-0x00000001803D2A30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <set_State>b__42_0(); // 0x00000001803D3840-0x00000001803D3870
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <set_State>b__42_1(); // 0x00000001803D3870-0x00000001803D38B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color <UpdateLevel>b__45_0(); // 0x00000001803D37C0-0x00000001803D3800
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <UpdateLevel>b__45_1(Color color); // 0x00000001803D3800-0x00000001803D3840
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Show>b__46_0(); // 0x00000001803D3790-0x00000001803D37C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Hide>b__47_0(); // 0x00000001803D3750-0x00000001803D3790
}

