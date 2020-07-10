/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_MaxDecalsWarning : MonoBehaviour // TypeDefIndex: 11991
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _canvasGroup; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private CanvasGroup _tabWarningCanvasGroup; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _text; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _redColor; // 0x38
	private UI_Window_CreatureCustomization _window; // 0x48
	private string _baseWarningText; // 0x50
	private bool _isShowing; // 0x58

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 11992
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__7_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180E72520-0x0000000180E72580
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__7_0(); // 0x0000000180E721F0-0x0000000180E72270
	}

	// Constructors
	public UI_MaxDecalsWarning(); // 0x0000000180E81720-0x0000000180E81750

	// Methods
	private void Start(); // 0x0000000180E81570-0x0000000180E816A0
	private void Setup(); // 0x0000000180E81360-0x0000000180E81570
	private void OnDecalCountChanged(int inDecalCount); // 0x0000000180E81040-0x0000000180E81360
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__7_1(); // 0x0000000180E81710-0x0000000180E81720
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnDecalCountChanged>b__9_0(); // 0x0000000180E816A0-0x0000000180E816D0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnDecalCountChanged>b__9_1(); // 0x0000000180E816D0-0x0000000180E81710
}

