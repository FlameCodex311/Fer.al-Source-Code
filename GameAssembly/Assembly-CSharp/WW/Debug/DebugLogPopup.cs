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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

namespace WW.Debug
{
	public class DebugLogPopup : MonoBehaviour, IPointerClickHandler, IBeginDragHandler, IDragHandler, IEndDragHandler // TypeDefIndex: 16267
	{
		// Fields
		private RectTransform popupTransform; // 0x20
		private Vector2 halfSize; // 0x28
		private Image backgroundImage; // 0x30
		private CanvasGroup canvasGroup; // 0x38
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DebugConsoleWindow _console; // 0x40
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text newInfoCountText; // 0x48
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text newWarningCountText; // 0x50
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private UnityEngine.UI.Text newErrorCountText; // 0x58
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextMeshProUGUI _fpsText; // 0x60
		private int newInfoCount; // 0x68
		private int newWarningCount; // 0x6C
		private int newErrorCount; // 0x70
		private Color normalColor; // 0x74
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color alertColorInfo; // 0x84
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color alertColorWarning; // 0x94
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
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
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <MoveToPosAnimation>d__33 : IEnumerator<object> // TypeDefIndex: 16268
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DebugLogPopup <>4__this; // 0x20
			public Vector3 targetPos; // 0x28
			private float <modifier>5__2; // 0x34
			private Vector3 <initialPos>5__3; // 0x38
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <MoveToPosAnimation>d__33(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018097BE50-0x000000018097C040
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018097C040-0x000000018097C090
		}
	
		// Constructors
		public DebugLogPopup(); // 0x000000018096CC70-0x000000018096CCE0
	
		// Methods
		private void Awake(); // 0x000000018096BDE0-0x000000018096BE90
		private void Start(); // 0x000000018096C9B0-0x000000018096CAA0
		private void Update(); // 0x000000018096CC60-0x000000018096CC70
		public void OnViewportDimensionsChanged(); // 0x000000018096C690-0x000000018096C790
		public void NewInfoLogArrived(); // 0x000000018096C040-0x000000018096C120
		public void NewWarningLogArrived(); // 0x000000018096C120-0x000000018096C200
		public void NewErrorLogArrived(); // 0x000000018096BF70-0x000000018096C040
		private void Reset(); // 0x000000018096C790-0x000000018096C870
		[IteratorStateMachine] // 0x00000001801D6D90-0x00000001801D6DE0
		private IEnumerator MoveToPosAnimation(Vector3 targetPos); // 0x000000018096BEF0-0x000000018096BF70
		public void OnPointerClick(PointerEventData data); // 0x000000018096C610-0x000000018096C690
		public void Show(); // 0x000000018096C870-0x000000018096C9B0
		public void Hide(); // 0x000000018096BE90-0x000000018096BEF0
		public void OnBeginDrag(PointerEventData data); // 0x000000018096C200-0x000000018096C240
		public void OnDrag(PointerEventData data); // 0x000000018096C240-0x000000018096C300
		public void OnEndDrag(PointerEventData data); // 0x000000018096C300-0x000000018096C610
		private void UpdateFPS(); // 0x000000018096CAA0-0x000000018096CC60
	}
}
