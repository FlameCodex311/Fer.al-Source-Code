/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

namespace WW.Debug
{
	public class DebugLogPopup : MonoBehaviour, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 15715
	{
		// Fields
		private RectTransform popupTransform; // 0x20
		private Vector2 halfSize; // 0x28
		private Image backgroundImage; // 0x30
		private CanvasGroup canvasGroup; // 0x38
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private DebugConsoleWindow _console; // 0x40
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text newInfoCountText; // 0x48
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text newWarningCountText; // 0x50
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private UnityEngine.UI.Text newErrorCountText; // 0x58
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TextMeshProUGUI _fpsText; // 0x60
		private int newInfoCount; // 0x68
		private int newWarningCount; // 0x6C
		private int newErrorCount; // 0x70
		private Color normalColor; // 0x74
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color alertColorInfo; // 0x84
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color alertColorWarning; // 0x94
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color alertColorError; // 0xA4
		private bool isPopupBeingDragged; // 0xB4
		private IEnumerator moveToPosCoroutine; // 0xB8
		private float _fpsUpdateInterval; // 0xC0
		private float _fps; // 0xC4
		private float _fpsAccumulator; // 0xC8
		private int _fpsFrames; // 0xCC
		private float _fpsTimeleft; // 0xD0
		private float _fpsMin; // 0xD4
		private float _fpsMax; // 0xD8
		private float _lastFPS; // 0xDC
	
		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <MoveToPosAnimation>d__33 : IEnumerator<object> // TypeDefIndex: 15716
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DebugLogPopup <>4__this; // 0x20
			public Vector3 targetPos; // 0x28
			private float <modifier>5__2; // 0x34
			private Vector3 <initialPos>5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <MoveToPosAnimation>d__33(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018112C2A0-0x000000018112C490
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018112C490-0x000000018112C4E0
		}
	
		// Constructors
		public DebugLogPopup(); // 0x0000000181127A00-0x0000000181127A70
	
		// Methods
		private void Awake(); // 0x0000000181126B80-0x0000000181126C30
		private void Start(); // 0x0000000181127760-0x0000000181127850
		private void Update(); // 0x0000000181127850-0x0000000181127A00
		public void OnViewportDimensionsChanged(); // 0x0000000181127440-0x0000000181127540
		public void NewInfoLogArrived(); // 0x0000000181126DE0-0x0000000181126EC0
		public void NewWarningLogArrived(); // 0x0000000181126EC0-0x0000000181126FA0
		public void NewErrorLogArrived(); // 0x0000000181126D10-0x0000000181126DE0
		private void Reset(); // 0x0000000181127540-0x0000000181127620
		[IteratorStateMachine] // 0x0000000180164D80-0x0000000180164DD0
		private IEnumerator MoveToPosAnimation(Vector3 targetPos); // 0x0000000181126C90-0x0000000181126D10
		public void OnPointerClick(PointerEventData data); // 0x00000001811273C0-0x0000000181127440
		public void Show(); // 0x0000000181127620-0x0000000181127760
		public void Hide(); // 0x0000000181126C30-0x0000000181126C90
		public void OnBeginDrag(PointerEventData data); // 0x0000000181126FA0-0x0000000181126FE0
		public void OnDrag(PointerEventData data); // 0x0000000181126FE0-0x00000001811270B0
		public void OnEndDrag(PointerEventData data); // 0x00000001811270B0-0x00000001811273C0
		private void UpdateFPS(); // 0x0000000181127850-0x0000000181127A00
	}
}
