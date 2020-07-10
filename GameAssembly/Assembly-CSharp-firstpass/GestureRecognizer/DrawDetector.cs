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

// Image 80: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9274-9976

namespace GestureRecognizer
{
	public class DrawDetector : UnityEngine.MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler // TypeDefIndex: 9575
	{
		// Fields
		public Recognizer recognizer; // 0x18
		public UILineRenderer line; // 0x20
		private List<UILineRenderer> lines; // 0x28
		[Range] // 0x00000001800C20E0-0x00000001800C2100
		public float scoreToAccept; // 0x30
		[Range] // 0x00000001800E88E0-0x00000001800E8900
		public int minLines; // 0x34
		[Range] // 0x00000001800E88E0-0x00000001800E8900
		public int maxLines; // 0x38
		public RemoveStrategy removeStrategy; // 0x3C
		public bool clearNotRecognizedLines; // 0x40
		public bool fixedArea; // 0x41
		public Image controllerCursor; // 0x48
		public float cursorSpeed; // 0x50
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private DrawDetectorMode <DrawMode>k__BackingField; // 0x54
		private GestureData data; // 0x58
		public ResultEvent OnRecognize; // 0x60
		private RectTransform rectTransform; // 0x68
	
		// Properties
		public int MinLines { set; } // 0x000000018164EE20-0x000000018164EE90
		public int MaxLines { set; } // 0x000000018164EDB0-0x000000018164EE20
		public DrawDetectorMode DrawMode { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180369C60-0x0000000180369C70 0x00000001804D0B80-0x00000001804D0B90
	
		// Nested types
		public enum DrawDetectorMode // TypeDefIndex: 9576
		{
			Touch = 0,
			Controller = 1
		}
	
		public enum RemoveStrategy // TypeDefIndex: 9577
		{
			RemoveOld = 0,
			ClearAll = 1
		}
	
		[Serializable]
		public class ResultEvent : UnityEvent<RecognitionResult> // TypeDefIndex: 9578
		{
			// Constructors
			public ResultEvent(); // 0x00000001816585E0-0x0000000181658620
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass39_0 // TypeDefIndex: 9579
		{
			// Fields
			public RecognitionResult result; // 0x10
			public GestureData sizedNormalizedData; // 0x18
			public DrawDetector <>4__this; // 0x20
	
			// Constructors
			public <>c__DisplayClass39_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <OnEndDragCoroutine>b__0(); // 0x000000018165AD10-0x000000018165AE60
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass39_1 // TypeDefIndex: 9580
		{
			// Fields
			public Rect rect; // 0x10
			public <>c__DisplayClass39_0 CS$<>8__locals1; // 0x20
			public Func<Vector2, Vector2> <>9__2; // 0x28
	
			// Constructors
			public <>c__DisplayClass39_1(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal GestureLine <OnEndDragCoroutine>b__1(GestureLine line); // 0x000000018165AE60-0x000000018165AF80
			internal Vector2 <OnEndDragCoroutine>b__2(Vector2 p); // 0x000000018165AF80-0x000000018165B090
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <OnEndDragCoroutine>d__39 : IEnumerator<object> // TypeDefIndex: 9581
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
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <OnEndDragCoroutine>d__39(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x000000018165A3B0-0x000000018165A980
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x000000018165A980-0x000000018165A9D0
		}
	
		// Constructors
		public DrawDetector(); // 0x000000018164ECF0-0x000000018164EDB0
	
		// Methods
		private void Start(); // 0x000000018164E0D0-0x000000018164E1B0
		private void OnValidate(); // 0x000000018164DF50-0x000000018164DFC0
		private void Update(); // 0x000000018164E6D0-0x000000018164ECF0
		public void UpdateLines(); // 0x000000018164E2D0-0x000000018164E6D0
		private Vector2 RealToLine(Vector2 position); // 0x000000018164DFC0-0x000000018164E0D0
		private Vector2 FixedPosition(Vector2 position); // 0x00000001804DE840-0x00000001804DE850
		public void ClearLines(); // 0x000000018164D560-0x000000018164D5C0
		public void OnPointerClick(PointerEventData eventData); // 0x00000001803581E0-0x00000001803581F0
		public void OnBeginDrag(PointerEventData eventData); // 0x000000018164DC10-0x000000018164DC50
		private void LineStart(Vector2 inPos); // 0x000000018164D880-0x000000018164DC10
		public void OnDrag(PointerEventData eventData); // 0x000000018164DC50-0x000000018164DC90
		private void LineMove(Vector2 inPos); // 0x000000018164D640-0x000000018164D880
		public void OnEndDrag(PointerEventData eventData); // 0x000000018164DD10-0x000000018164DD50
		private void LineEnd(Vector2 inPos); // 0x000000018164D5C0-0x000000018164D640
		[IteratorStateMachine] // 0x00000001800E8E20-0x00000001800E8E70
		private IEnumerator OnEndDragCoroutine(Vector2 inPos); // 0x000000018164DC90-0x000000018164DD10
		public void OnGestureSelected(List<GesturePattern> inGestures); // 0x000000018164DD50-0x000000018164DF50
		public void ChangeDrawMode(DrawDetectorMode inMode); // 0x000000018164D490-0x000000018164D560
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private Vector2 <UpdateLines>b__28_0(Vector2 p); // 0x000000018164E1B0-0x000000018164E2D0
	}
}
