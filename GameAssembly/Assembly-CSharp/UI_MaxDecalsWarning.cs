/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_MaxDecalsWarning : MonoBehaviour // TypeDefIndex: 13537
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _canvasGroup; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _tabWarningCanvasGroup; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _text; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _redColor; // 0x38
	private UI_Window_CreatureCustomization _window; // 0x48
	private string _baseWarningText; // 0x50
	private bool _isShowing; // 0x58

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13538
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__7_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001803C67E0-0x00000001803C6840
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__7_0(); // 0x00000001803C6440-0x00000001803C64C0
	}

	// Constructors
	public UI_MaxDecalsWarning(); // 0x00000001803CB060-0x00000001803CB090

	// Methods
	private void Start(); // 0x00000001803CAEB0-0x00000001803CAFE0
	private void Setup(); // 0x00000001803CACB0-0x00000001803CAEB0
	private void OnDecalCountChanged(int inDecalCount); // 0x00000001803CA990-0x00000001803CACB0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__7_1(); // 0x00000001803CB050-0x00000001803CB060
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnDecalCountChanged>b__9_0(); // 0x00000001803CAFE0-0x00000001803CB010
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnDecalCountChanged>b__9_1(); // 0x00000001803CB010-0x00000001803CB050
}

