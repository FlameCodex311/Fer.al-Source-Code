/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 82: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9678-10380

namespace GestureRecognizer
{
	public class DrawDetector : UnityEngine.MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler // TypeDefIndex: 10029
	{
		// Fields
		public Recognizer recognizer; // 0x18
		public UILineRenderer line; // 0x20
		private List<UILineRenderer> lines; // 0x28
		[Range] // 0x00000001801D3630-0x00000001801D3650
		public float scoreToAccept; // 0x30
		[Range] // 0x000000018028DE80-0x000000018028DEA0
		public int minLines; // 0x34
		[Range] // 0x000000018028DE80-0x000000018028DEA0
		public int maxLines; // 0x38
		public RemoveStrategy removeStrategy; // 0x3C
		public bool clearNotRecognizedLines; // 0x40
		public bool fixedArea; // 0x41
		public Image controllerCursor; // 0x48
		public float cursorSpeed; // 0x50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private DrawDetectorMode <DrawMode>k__BackingField; // 0x54
		private GestureData data; // 0x58
		public ResultEvent OnRecognize; // 0x60
		private RectTransform rectTransform; // 0x68
	
		// Properties
		public int MinLines { set; } // 0x0000000180D215F0-0x0000000180D21660
		public int MaxLines { set; } // 0x0000000180D21580-0x0000000180D215F0
		public DrawDetectorMode DrawMode { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x0000000180379EE0-0x0000000180379EF0 0x00000001807E3290-0x00000001807E32A0
	
		// Nested types
		public enum DrawDetectorMode // TypeDefIndex: 10030
		{
			Touch = 0,
			Controller = 1
		}
	
		public enum RemoveStrategy // TypeDefIndex: 10031
		{
			RemoveOld = 0,
			ClearAll = 1
		}
	
		[Serializable]
		public class ResultEvent : UnityEvent<RecognitionResult> // TypeDefIndex: 10032
		{
			// Constructors
			public ResultEvent(); // 0x0000000180D2C240-0x0000000180D2C280
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass39_0 // TypeDefIndex: 10033
		{
			// Fields
			public RecognitionResult result; // 0x10
			public GestureData sizedNormalizedData; // 0x18
			public DrawDetector <>4__this; // 0x20
	
			// Constructors
			public <>c__DisplayClass39_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <OnEndDragCoroutine>b__0(); // 0x0000000180D360B0-0x0000000180D361F0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass39_1 // TypeDefIndex: 10034
		{
			// Fields
			public Rect rect; // 0x10
			public <>c__DisplayClass39_0 CS$<>8__locals1; // 0x20
			public Func<Vector2, Vector2> <>9__2; // 0x28
	
			// Constructors
			public <>c__DisplayClass39_1(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal GestureLine <OnEndDragCoroutine>b__1(GestureLine line); // 0x0000000180D361F0-0x0000000180D36310
			internal Vector2 <OnEndDragCoroutine>b__2(Vector2 p); // 0x0000000180D36310-0x0000000180D36420
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <OnEndDragCoroutine>d__39 : IEnumerator<object> // TypeDefIndex: 10035
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public DrawDetector <>4__this; // 0x20
			public Vector2 inPos; // 0x28
			private <>c__DisplayClass39_0 <>8__1; // 0x30
			private int <size>5__2; // 0x38
			private GestureData <sizedData>5__3; // 0x40
			private Thread <thread>5__4; // 0x48
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <OnEndDragCoroutine>d__39(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180D35780-0x0000000180D35D30
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180D35D30-0x0000000180D35D80
		}
	
		// Constructors
		public DrawDetector(); // 0x0000000180D214C0-0x0000000180D21580
	
		// Methods
		private void Start(); // 0x0000000180D208E0-0x0000000180D209C0
		private void OnValidate(); // 0x0000000180D20760-0x0000000180D207D0
		private void Update(); // 0x0000000180D20EB0-0x0000000180D214C0
		public void UpdateLines(); // 0x0000000180D20AD0-0x0000000180D20EB0
		private Vector2 RealToLine(Vector2 position); // 0x0000000180D207D0-0x0000000180D208E0
		private Vector2 FixedPosition(Vector2 position); // 0x00000001804EC160-0x00000001804EC170
		public void ClearLines(); // 0x0000000180D1FDA0-0x0000000180D1FE00
		public void OnPointerClick(PointerEventData eventData); // 0x00000001803774A0-0x00000001803774B0
		public void OnBeginDrag(PointerEventData eventData); // 0x0000000180D20420-0x0000000180D20460
		private void LineStart(Vector2 inPos); // 0x0000000180D200B0-0x0000000180D20420
		public void OnDrag(PointerEventData eventData); // 0x0000000180D20460-0x0000000180D204A0
		private void LineMove(Vector2 inPos); // 0x0000000180D1FE80-0x0000000180D200B0
		public void OnEndDrag(PointerEventData eventData); // 0x0000000180D20520-0x0000000180D20560
		private void LineEnd(Vector2 inPos); // 0x0000000180D1FE00-0x0000000180D1FE80
		[IteratorStateMachine] // 0x000000018028E630-0x000000018028E680
		private IEnumerator OnEndDragCoroutine(Vector2 inPos); // 0x0000000180D204A0-0x0000000180D20520
		public void OnGestureSelected(List<GesturePattern> inGestures); // 0x0000000180D20560-0x0000000180D20760
		public void ChangeDrawMode(DrawDetectorMode inMode); // 0x0000000180D1FCD0-0x0000000180D1FDA0
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Vector2 <UpdateLines>b__28_0(Vector2 p); // 0x0000000180D209C0-0x0000000180D20AD0
	}
}
