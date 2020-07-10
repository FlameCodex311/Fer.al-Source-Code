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
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 70: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8742-8901

namespace TMPro
{
	[AddComponentMenu] // 0x000000018014BF40-0x000000018014BF70
	public class TMP_InputField : Selectable, IUpdateSelectedHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler // TypeDefIndex: 8800
	{
		// Fields
		protected TouchScreenKeyboard m_SoftKeyboard; // 0xE8
		private static readonly char[] kSeparators; // 0x00
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected RectTransform m_TextViewport; // 0xF0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected TMP_Text m_TextComponent; // 0xF8
		protected RectTransform m_TextComponentRectTransform; // 0x100
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected Graphic m_Placeholder; // 0x108
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected Scrollbar m_VerticalScrollbar; // 0x110
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x118
		private bool m_IsDrivenByLayoutComponents; // 0x120
		private float m_ScrollPosition; // 0x124
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected float m_ScrollSensitivity; // 0x128
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private ContentType m_ContentType; // 0x12C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private InputType m_InputType; // 0x130
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private char m_AsteriskChar; // 0x134
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TouchScreenKeyboardType m_KeyboardType; // 0x138
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private LineType m_LineType; // 0x13C
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_HideMobileInput; // 0x140
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_HideSoftKeyboard; // 0x141
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private CharacterValidation m_CharacterValidation; // 0x144
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private string m_RegexValue; // 0x148
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private float m_GlobalPointSize; // 0x150
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private int m_CharacterLimit; // 0x154
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private SubmitEvent m_OnEndEdit; // 0x158
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private SubmitEvent m_OnSubmit; // 0x160
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private SelectionEvent m_OnSelect; // 0x168
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private SelectionEvent m_OnDeselect; // 0x170
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TextSelectionEvent m_OnTextSelection; // 0x178
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TextSelectionEvent m_OnEndTextSelection; // 0x180
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private OnChangeEvent m_OnValueChanged; // 0x188
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x190
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private OnValidateInput m_OnValidateInput; // 0x198
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color m_CaretColor; // 0x1A0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_CustomCaretColor; // 0x1B0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Color m_SelectionColor; // 0x1B4
		[SerializeField] // 0x0000000180151B00-0x0000000180151B40
		[TextArea] // 0x0000000180151B00-0x0000000180151B40
		protected string m_Text; // 0x1C8
		[Range] // 0x00000001800E0910-0x00000001800E0950
		[SerializeField] // 0x00000001800E0910-0x00000001800E0950
		private float m_CaretBlinkRate; // 0x1D0
		[Range] // 0x00000001800E0A30-0x00000001800E0A70
		[SerializeField] // 0x00000001800E0A30-0x00000001800E0A70
		private int m_CaretWidth; // 0x1D4
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_ReadOnly; // 0x1D8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_RichText; // 0x1D9
		protected int m_StringPosition; // 0x1DC
		protected int m_StringSelectPosition; // 0x1E0
		protected int m_CaretPosition; // 0x1E4
		protected int m_CaretSelectPosition; // 0x1E8
		private RectTransform caretRectTrans; // 0x1F0
		protected UIVertex[] m_CursorVerts; // 0x1F8
		private CanvasRenderer m_CachedInputRenderer; // 0x200
		private Vector2 m_LastPosition; // 0x208
		[NonSerialized]
		protected Mesh m_Mesh; // 0x210
		private bool m_AllowInput; // 0x218
		private bool m_ShouldActivateNextUpdate; // 0x219
		private bool m_UpdateDrag; // 0x21A
		private bool m_DragPositionOutOfBounds; // 0x21B
		private const float kHScrollSpeed = 0.05f; // Metadata: 0x0074347A
		private const float kVScrollSpeed = 0.1f; // Metadata: 0x0074347E
		protected bool m_CaretVisible; // 0x21C
		private Coroutine m_BlinkCoroutine; // 0x220
		private float m_BlinkStartTime; // 0x228
		private Coroutine m_DragCoroutine; // 0x230
		private string m_OriginalText; // 0x238
		private bool m_WasCanceled; // 0x240
		private bool m_HasDoneFocusTransition; // 0x241
		private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x248
		private bool m_PreventCallback; // 0x250
		private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x251
		private bool m_IsTextComponentUpdateRequired; // 0x252
		private bool m_IsScrollbarUpdateRequired; // 0x253
		private bool m_IsUpdatingScrollbarValues; // 0x254
		private bool m_isLastKeyBackspace; // 0x255
		private float m_PointerDownClickStartTime; // 0x258
		private float m_KeyDownStartTime; // 0x25C
		private float m_DoubleClickDelay; // 0x260
		private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~"; // Metadata: 0x00743482
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected TMP_FontAsset m_GlobalFontAsset; // 0x268
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected bool m_OnFocusSelectAll; // 0x270
		protected bool m_isSelectAll; // 0x271
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected bool m_ResetOnDeActivation; // 0x272
		private bool m_SelectionStillActive; // 0x273
		private bool m_ReleaseSelection; // 0x274
		private GameObject m_SelectedObject; // 0x278
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private bool m_RestoreOriginalTextOnEscape; // 0x280
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected bool m_isRichTextEditingAllowed; // 0x281
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected int m_LineLimit; // 0x284
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		protected TMP_InputValidator m_InputValidator; // 0x288
		private bool m_isSelected; // 0x290
		private bool m_IsStringPositionDirty; // 0x291
		private bool m_IsCaretPositionDirty; // 0x292
		private bool m_forceRectTransformAdjustment; // 0x293
		private Event m_ProcessingEvent; // 0x298
	
		// Properties
		private BaseInput inputSystem { get; } // 0x00000001810E2090-0x00000001810E21D0 
		private string compositionString { get; } // 0x00000001810E1F50-0x00000001810E2000 
		protected Mesh mesh { get; } // 0x00000001810E2240-0x00000001810E22E0 
		public bool shouldHideMobileInput { get; set; } // 0x00000001810E2570-0x00000001810E25A0 0x00000001810E38E0-0x00000001810E3960
		public bool shouldHideSoftKeyboard { get; set; } // 0x00000001810E25A0-0x00000001810E25F0 0x00000001810E3960-0x00000001810E3A60
		public string text { get; set; } // 0x00000001810B8240-0x00000001810B8250 0x00000001810E3CD0-0x00000001810E3CE0
		public bool isFocused { get; } // 0x00000001810E21F0-0x00000001810E2200 
		public float caretBlinkRate { get; set; } // 0x00000001810E1E40-0x00000001810E1E50 0x00000001810E2690-0x00000001810E2700
		public int caretWidth { get; set; } // 0x00000001810E1F10-0x00000001810E1F20 0x00000001810E2880-0x00000001810E2920
		public RectTransform textViewport { get; set; } // 0x00000001803BD320-0x00000001803BD330 0x00000001810E3C80-0x00000001810E3CD0
		public TMP_Text textComponent { get; set; } // 0x00000001803BD310-0x00000001803BD320 0x00000001810E3C20-0x00000001810E3C80
		public Graphic placeholder { get; set; } // 0x00000001803BD3C0-0x00000001803BD3D0 0x00000001810E3350-0x00000001810E33A0
		public Scrollbar verticalScrollbar { get; set; } // 0x00000001803BD380-0x00000001803BD390 0x00000001810E3CE0-0x00000001810E3E90
		public float scrollSensitivity { get; set; } // 0x00000001810E24F0-0x00000001810E2500 0x00000001810E35D0-0x00000001810E3670
		public Color caretColor { get; set; } // 0x00000001810E1E50-0x00000001810E1EB0 0x00000001810E2700-0x00000001810E27B0
		public bool customCaretColor { get; set; } // 0x0000000180F0A750-0x0000000180F0A760 0x00000001810E2C00-0x00000001810E2C70
		public Color selectionColor { get; set; } // 0x00000001810E2500-0x00000001810E2510 0x00000001810E36C0-0x00000001810E3770
		public SubmitEvent onEndEdit { get; set; } // 0x00000001803BD330-0x00000001803BD340 0x00000001810E30C0-0x00000001810E3110
		public SubmitEvent onSubmit { get; set; } // 0x0000000180CB7670-0x0000000180CB7680 0x00000001810E31C0-0x00000001810E3210
		public SelectionEvent onSelect { get; set; } // 0x00000001810E2310-0x00000001810E2320 0x00000001810E3170-0x00000001810E31C0
		public SelectionEvent onDeselect { get; set; } // 0x000000018081E140-0x000000018081E150 0x00000001810E3070-0x00000001810E30C0
		public TextSelectionEvent onTextSelection { get; set; } // 0x000000018081E150-0x000000018081E160 0x00000001810E3210-0x00000001810E3260
		public TextSelectionEvent onEndTextSelection { get; set; } // 0x000000018081E0E0-0x000000018081E0F0 0x00000001810E3110-0x00000001810E3160
		public OnChangeEvent onValueChanged { get; set; } // 0x00000001810E2330-0x00000001810E2340 0x00000001810E3300-0x00000001810E3350
		public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; } // 0x00000001810D1D90-0x00000001810D1DA0 0x00000001810E3260-0x00000001810E32B0
		public OnValidateInput onValidateInput { get; set; } // 0x00000001810E2320-0x00000001810E2330 0x00000001810E32B0-0x00000001810E3300
		public int characterLimit { get; set; } // 0x00000001810E1F20-0x00000001810E1F30 0x00000001810E2920-0x00000001810E29D0
		public float pointSize { get; set; } // 0x00000001810E2340-0x00000001810E2350 0x00000001810E33A0-0x00000001810E3510
		public TMP_FontAsset fontAsset { get; set; } // 0x00000001810E2000-0x00000001810E2010 0x00000001810E2C70-0x00000001810E2DB0
		public bool onFocusSelectAll { get; set; } // 0x00000001810E2300-0x00000001810E2310 0x00000001810E3160-0x00000001810E3170
		public bool resetOnDeActivation { get; set; } // 0x00000001810E24D0-0x00000001810E24E0 0x00000001810E3520-0x00000001810E3530
		public bool restoreOriginalTextOnEscape { get; set; } // 0x00000001810E24E0-0x00000001810E24F0 0x00000001810E3530-0x00000001810E3540
		public bool isRichTextEditingAllowed { get; set; } // 0x00000001810E2200-0x00000001810E2210 0x00000001810E2E90-0x00000001810E2EA0
		public ContentType contentType { get; set; } // 0x0000000180641660-0x0000000180641670 0x00000001810E2A50-0x00000001810E2C00
		public LineType lineType { get; set; } // 0x00000001810E2230-0x00000001810E2240 0x00000001810E2F80-0x00000001810E3070
		public int lineLimit { get; set; } // 0x00000001810E2220-0x00000001810E2230 0x00000001810E2F10-0x00000001810E2F80
		public InputType inputType { get; set; } // 0x00000001810E21D0-0x00000001810E21E0 0x00000001810E2DB0-0x00000001810E2E20
		public TouchScreenKeyboardType keyboardType { get; set; } // 0x00000001810E2210-0x00000001810E2220 0x00000001810E2EA0-0x00000001810E2F10
		public CharacterValidation characterValidation { get; set; } // 0x00000001810E1F30-0x00000001810E1F40 0x00000001810E29D0-0x00000001810E2A40
		public TMP_InputValidator inputValidator { get; set; } // 0x00000001810E21E0-0x00000001810E21F0 0x00000001810E2E20-0x00000001810E2E90
		public bool readOnly { get; set; } // 0x00000001810E24C0-0x00000001810E24D0 0x00000001810E3510-0x00000001810E3520
		public bool richText { get; set; } // 0x0000000180CB7BE0-0x0000000180CB7BF0 0x00000001810E3540-0x00000001810E35D0
		public bool multiLine { get; } // 0x00000001810E22E0-0x00000001810E2300 
		public char asteriskChar { get; set; } // 0x00000001810E1E30-0x00000001810E1E40 0x00000001810E2630-0x00000001810E2690
		public bool wasCanceled { get; } // 0x00000001810E25F0-0x00000001810E2600 
		protected int caretPositionInternal { get; set; } // 0x00000001810E1EB0-0x00000001810E1EE0 0x00000001810E27B0-0x00000001810E27D0
		protected int stringPositionInternal { get; set; } // 0x00000001810E2510-0x00000001810E2540 0x00000001810E3A60-0x00000001810E3AC0
		protected int caretSelectPositionInternal { get; set; } // 0x00000001810E1EE0-0x00000001810E1F10 0x00000001810E2860-0x00000001810E2880
		protected int stringSelectPositionInternal { get; set; } // 0x00000001810E2540-0x00000001810E2570 0x00000001810E3BC0-0x00000001810E3C20
		private new bool hasSelection { get; } // 0x00000001810E2010-0x00000001810E2090 
		public int caretPosition { get; set; } // 0x00000001810E1EE0-0x00000001810E1F10 0x00000001810E27D0-0x00000001810E2860
		public int selectionAnchorPosition { get; set; } // 0x00000001810E1EB0-0x00000001810E1EE0 0x00000001810E3670-0x00000001810E36C0
		public int selectionFocusPosition { get; set; } // 0x00000001810E1EE0-0x00000001810E1F10 0x00000001810E3770-0x00000001810E37C0
		public int stringPosition { get; set; } // 0x00000001810E2540-0x00000001810E2570 0x00000001810E3AC0-0x00000001810E3BC0
		public int selectionStringAnchorPosition { get; set; } // 0x00000001810E2510-0x00000001810E2540 0x00000001810E37C0-0x00000001810E3850
		public int selectionStringFocusPosition { get; set; } // 0x00000001810E2540-0x00000001810E2570 0x00000001810E3850-0x00000001810E38E0
		private static string clipboard { get; set; } // 0x00000001810E1F40-0x00000001810E1F50 0x00000001810E2A40-0x00000001810E2A50
		public virtual float minWidth { get; } // 0x0000000180DD1F20-0x0000000180DD1F30 
		public virtual float preferredWidth { get; } // 0x00000001810E2400-0x00000001810E24C0 
		public virtual float flexibleWidth { get; } // 0x0000000180F7F600-0x0000000180F7F610 
		public virtual float minHeight { get; } // 0x0000000180DD1F20-0x0000000180DD1F30 
		public virtual float preferredHeight { get; } // 0x00000001810E2350-0x00000001810E2400 
		public virtual float flexibleHeight { get; } // 0x0000000180F7F600-0x0000000180F7F610 
		public virtual int layoutPriority { get; } // 0x000000018042E670-0x000000018042E680 
		Transform ICanvasElement.transform { get; } // 0x00000001810E09D0-0x00000001810E09E0 
	
		// Nested types
		public enum ContentType // TypeDefIndex: 8801
		{
			Standard = 0,
			Autocorrected = 1,
			IntegerNumber = 2,
			DecimalNumber = 3,
			Alphanumeric = 4,
			Name = 5,
			EmailAddress = 6,
			Password = 7,
			Pin = 8,
			Custom = 9
		}
	
		public enum InputType // TypeDefIndex: 8802
		{
			Standard = 0,
			AutoCorrect = 1,
			Password = 2
		}
	
		public enum CharacterValidation // TypeDefIndex: 8803
		{
			None = 0,
			Digit = 1,
			Integer = 2,
			Decimal = 3,
			Alphanumeric = 4,
			Name = 5,
			Regex = 6,
			EmailAddress = 7,
			CustomValidator = 8
		}
	
		public enum LineType // TypeDefIndex: 8804
		{
			SingleLine = 0,
			MultiLineSubmit = 1,
			MultiLineNewline = 2
		}
	
		public delegate char OnValidateInput(string text, int charIndex, char addedChar); // TypeDefIndex: 8805; 0x000000018119DED0-0x000000018119E370
	
		[Serializable]
		public class SubmitEvent : UnityEvent<string> // TypeDefIndex: 8806
		{
			// Constructors
			public SubmitEvent(); // 0x000000018119E3B0-0x000000018119E580
		}
	
		[Serializable]
		public class OnChangeEvent : UnityEvent<string> // TypeDefIndex: 8807
		{
			// Constructors
			public OnChangeEvent(); // 0x000000018119DDC0-0x000000018119DE00
		}
	
		[Serializable]
		public class SelectionEvent : UnityEvent<string> // TypeDefIndex: 8808
		{
			// Constructors
			public SelectionEvent(); // 0x000000018119E370-0x000000018119E3B0
		}
	
		[Serializable]
		public class TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 8809
		{
			// Constructors
			public TextSelectionEvent(); // 0x00000001811C8A40-0x00000001811C8A80
		}
	
		[Serializable]
		public class TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 8810
		{
			// Constructors
			public TouchScreenKeyboardEvent(); // 0x00000001811C8A80-0x00000001811C8AC0
		}
	
		protected enum EditState // TypeDefIndex: 8811
		{
			Continue = 0,
			Finish = 1
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <CaretBlink>d__267 : IEnumerator<object> // TypeDefIndex: 8812
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TMP_InputField <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <CaretBlink>d__267(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001811C8AC0-0x00000001811C8C00
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001811C8C00-0x00000001811C8C50
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <MouseDragOutsideRect>d__285 : IEnumerator<object> // TypeDefIndex: 8813
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TMP_InputField <>4__this; // 0x20
			public PointerEventData eventData; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <MouseDragOutsideRect>d__285(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001811C9A80-0x00000001811C9D30
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001811C9D30-0x00000001811C9D80
		}
	
		// Constructors
		protected TMP_InputField(); // 0x00000001810E1B80-0x00000001810E1E30
		static TMP_InputField(); // 0x00000001810E1B20-0x00000001810E1B80
	
		// Methods
		private bool isKeyboardUsingEvents(); // 0x00000001810E2600-0x00000001810E2630
		public void SetTextWithoutNotify(string input); // 0x00000001810E07A0-0x00000001810E07B0
		private void SetText(string value, bool sendCallback = true /* Metadata: 0x00743478 */); // 0x00000001810E07B0-0x00000001810E0940
		protected void ClampStringPos(ref int pos); // 0x00000001810D5160-0x00000001810D51B0
		protected void ClampCaretPos(ref int pos); // 0x00000001810D50E0-0x00000001810D5160
		protected override void OnEnable(); // 0x00000001810DD540-0x00000001810DDC00
		protected override void OnDisable(); // 0x00000001810DCC30-0x00000001810DCF70
		private void ON_TEXT_CHANGED(UnityEngine.Object obj); // 0x00000001810DCA50-0x00000001810DCB90
		[IteratorStateMachine] // 0x0000000180153200-0x0000000180153250
		private IEnumerator CaretBlink(); // 0x00000001810D5070-0x00000001810D50E0
		private void SetCaretVisible(); // 0x00000001810E0430-0x00000001810E0470
		private void SetCaretActive(); // 0x00000001810E0380-0x00000001810E0430
		protected void OnFocus(); // 0x00000001810DE090-0x00000001810DE0B0
		protected void SelectAll(); // 0x00000001810DFE80-0x00000001810DFF30
		public void MoveTextEnd(bool shift); // 0x00000001810DBBB0-0x00000001810DBE50
		public void MoveTextStart(bool shift); // 0x00000001810DBE50-0x00000001810DC0B0
		public void MoveToEndOfLine(bool shift, bool ctrl); // 0x00000001810DC0B0-0x00000001810DC3D0
		public void MoveToStartOfLine(bool shift, bool ctrl); // 0x00000001810DC3D0-0x00000001810DC750
		private bool InPlaceEditing(); // 0x00000001810D8410-0x00000001810D8500
		private void UpdateStringPositionFromKeyboard(); // 0x00000001810E1130-0x00000001810E1370
		protected virtual void LateUpdate(); // 0x00000001810D8C20-0x00000001810D9350
		private bool MayDrag(PointerEventData eventData); // 0x00000001810D9B20-0x00000001810D9C40
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x00000001810DCB90-0x00000001810DCBC0
		public virtual void OnDrag(PointerEventData eventData); // 0x00000001810DCF70-0x00000001810DD540
		[IteratorStateMachine] // 0x00000001801533E0-0x0000000180153430
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData); // 0x00000001810D9C40-0x00000001810D9CC0
		public virtual void OnEndDrag(PointerEventData eventData); // 0x00000001810DDC00-0x00000001810DDC30
		public override void OnPointerDown(PointerEventData eventData); // 0x00000001810DE0E0-0x00000001810DEE20
		protected EditState KeyPressed(Event evt); // 0x00000001810D8790-0x00000001810D8C20
		protected virtual bool IsValidChar(char c); // 0x00000001810D8780-0x00000001810D8790
		public void ProcessEvent(Event e); // 0x00000001810DFD40-0x00000001810DFD50
		public virtual void OnUpdateSelected(BaseEventData eventData); // 0x00000001810DF150-0x00000001810DF2D0
		public virtual void OnScroll(PointerEventData eventData); // 0x00000001810DEE20-0x00000001810DF000
		private string GetSelectedString(); // 0x00000001810D8270-0x00000001810D8340
		private int FindNextWordBegin(); // 0x00000001810D6380-0x00000001810D64D0
		private void MoveRight(bool shift, bool ctrl); // 0x00000001810DB360-0x00000001810DBBB0
		private int FindPrevWordBegin(); // 0x00000001810D64D0-0x00000001810D65E0
		private void MoveLeft(bool shift, bool ctrl); // 0x00000001810DA000-0x00000001810DA810
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar); // 0x00000001810D9740-0x00000001810D9AC0
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar); // 0x00000001810D9350-0x00000001810D9740
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar); // 0x00000001810DF860-0x00000001810DFD40
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar); // 0x00000001810DF2D0-0x00000001810DF860
		private void MoveDown(bool shift); // 0x00000001810D9FF0-0x00000001810DA000
		private void MoveDown(bool shift, bool goToLastChar); // 0x00000001810D9CC0-0x00000001810D9FF0
		private void MoveUp(bool shift); // 0x00000001810DCA40-0x00000001810DCA50
		private void MoveUp(bool shift, bool goToFirstChar); // 0x00000001810DC750-0x00000001810DCA40
		private void MovePageUp(bool shift); // 0x00000001810DB350-0x00000001810DB360
		private void MovePageUp(bool shift, bool goToFirstChar); // 0x00000001810DADD0-0x00000001810DB350
		private void MovePageDown(bool shift); // 0x00000001810DADC0-0x00000001810DADD0
		private void MovePageDown(bool shift, bool goToLastChar); // 0x00000001810DA810-0x00000001810DADC0
		private void Delete(); // 0x00000001810D5980-0x00000001810D61E0
		private void DeleteKey(); // 0x00000001810D55A0-0x00000001810D5980
		private void Backspace(); // 0x00000001810D4A60-0x00000001810D5070
		protected virtual void Append(string input); // 0x00000001810D40B0-0x00000001810D4160
		protected virtual void Append(char input); // 0x00000001810D3F20-0x00000001810D40B0
		private void Insert(char c); // 0x00000001810D8500-0x00000001810D8780
		private void UpdateTouchKeyboardFromEditChanges(); // 0x00000001810E1370-0x00000001810E13C0
		private void SendOnValueChangedAndUpdateLabel(); // 0x00000001810E0250-0x00000001810E02B0
		private void SendOnValueChanged(); // 0x00000001810E02B0-0x00000001810E0300
		protected void SendOnEndEdit(); // 0x00000001810DFF30-0x00000001810DFF80
		protected void SendOnSubmit(); // 0x00000001810E0120-0x00000001810E0170
		protected void SendOnFocus(); // 0x00000001810E00D0-0x00000001810E0120
		protected void SendOnFocusLost(); // 0x00000001810E0080-0x00000001810E00D0
		protected void SendOnTextSelection(); // 0x00000001810E0170-0x00000001810E0250
		protected void SendOnEndTextSelection(); // 0x00000001810DFF80-0x00000001810E0080
		protected void SendTouchScreenKeyboardStatusChanged(); // 0x00000001810E0300-0x00000001810E0380
		protected void UpdateLabel(); // 0x00000001810E0AA0-0x00000001810E0F40
		private void UpdateScrollbar(); // 0x00000001810E0F40-0x00000001810E1130
		private void OnScrollbarValueChange(float value); // 0x00000001810DF000-0x00000001810DF060
		private void AdjustTextPositionRelativeToViewport(float relativePosition); // 0x00000001810D3D30-0x00000001810D3F20
		private int GetCaretPositionFromStringIndex(int stringIndex); // 0x00000001810D8090-0x00000001810D8150
		private int GetMinCaretPositionFromStringIndex(int stringIndex); // 0x00000001810D8150-0x00000001810D8270
		private int GetMaxCaretPositionFromStringIndex(int stringIndex); // 0x00000001810D8090-0x00000001810D8150
		private int GetStringIndexFromCaretPosition(int caretPosition); // 0x00000001810D8340-0x00000001810D8410
		public void ForceLabelUpdate(); // 0x00000001810D65E0-0x00000001810D65F0
		private void MarkGeometryAsDirty(); // 0x00000001810D9AC0-0x00000001810D9B20
		public virtual void Rebuild(CanvasUpdate update); // 0x00000001810DFD50-0x00000001810DFE20
		public virtual void LayoutComplete(); // 0x00000001803581E0-0x00000001803581F0
		public virtual void GraphicUpdateComplete(); // 0x00000001803581E0-0x00000001803581F0
		private void UpdateGeometry(); // 0x00000001810E09E0-0x00000001810E0AA0
		private void AssignPositioningIfNeeded(); // 0x00000001810D4160-0x00000001810D4A60
		private void OnFillVBO(Mesh vbo); // 0x00000001810DDC30-0x00000001810DE090
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset); // 0x00000001810D65F0-0x00000001810D7210
		private void CreateCursorVerts(); // 0x00000001810D51B0-0x00000001810D5360
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset); // 0x00000001810D7210-0x00000001810D8090
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible); // 0x00000001810D32E0-0x00000001810D3D30
		protected char Validate(string text, int pos, char ch); // 0x00000001810E13C0-0x00000001810E1B20
		public void ActivateInputField(); // 0x00000001810D3180-0x00000001810D32E0
		private void ActivateInputFieldInternal(); // 0x00000001810D2BA0-0x00000001810D3180
		public override void OnSelect(BaseEventData eventData); // 0x00000001810DF060-0x00000001810DF0C0
		public virtual void OnPointerClick(PointerEventData eventData); // 0x00000001810DE0B0-0x00000001810DE0E0
		public void OnControlClick(); // 0x00000001803581E0-0x00000001803581F0
		public void ReleaseSelection(); // 0x00000001810DFE20-0x00000001810DFE80
		public void DeactivateInputField(bool clearSelection = false /* Metadata: 0x00743479 */); // 0x00000001810D5360-0x00000001810D55A0
		public override void OnDeselect(BaseEventData eventData); // 0x00000001810DCBC0-0x00000001810DCC30
		public virtual void OnSubmit(BaseEventData eventData); // 0x00000001810DF0C0-0x00000001810DF150
		private void EnforceContentType(); // 0x00000001810D6210-0x00000001810D6380
		private void SetTextComponentWrapMode(); // 0x00000001810E06E0-0x00000001810E07A0
		private void SetTextComponentRichTextMode(); // 0x00000001810E0650-0x00000001810E06E0
		private void SetToCustomIfContentTypeIsNot(params /* 0x00000001800B36B0-0x00000001800B36C0 */ ContentType[] allowedContentTypes); // 0x00000001810E0940-0x00000001810E09B0
		private void SetToCustom(); // 0x00000001810E09B0-0x00000001810E09D0
		private void SetToCustom(CharacterValidation characterValidation); // 0x00000001810E09B0-0x00000001810E09D0
		protected override void DoStateTransition(SelectionState state, bool instant); // 0x00000001810D61E0-0x00000001810D6210
		public virtual void CalculateLayoutInputHorizontal(); // 0x00000001803581E0-0x00000001803581F0
		public virtual void CalculateLayoutInputVertical(); // 0x00000001803581E0-0x00000001803581F0
		public void SetGlobalPointSize(float pointSize); // 0x00000001810E0560-0x00000001810E0650
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset); // 0x00000001810E0470-0x00000001810E0560
	}
}
