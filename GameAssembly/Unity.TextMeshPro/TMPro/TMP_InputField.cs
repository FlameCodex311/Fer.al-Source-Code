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

// Image 71: Unity.TextMeshPro.dll - Assembly: Unity.TextMeshPro, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 8908-9067

namespace TMPro
{
	[AddComponentMenu] // 0x00000001801E57B0-0x00000001801E57E0
	public class TMP_InputField : Selectable, IUpdateSelectedHandler, IBeginDragHandler, IDragHandler, IEndDragHandler, IPointerClickHandler, ISubmitHandler, ICanvasElement, ILayoutElement, IScrollHandler // TypeDefIndex: 8962
	{
		// Fields
		protected TouchScreenKeyboard m_SoftKeyboard; // 0xF0
		private static readonly char[] kSeparators; // 0x00
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected RectTransform m_TextViewport; // 0xF8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TMP_Text m_TextComponent; // 0x100
		protected RectTransform m_TextComponentRectTransform; // 0x108
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Graphic m_Placeholder; // 0x110
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected Scrollbar m_VerticalScrollbar; // 0x118
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TMP_ScrollbarEventHandler m_VerticalScrollbarEventHandler; // 0x120
		private bool m_IsDrivenByLayoutComponents; // 0x128
		private float m_ScrollPosition; // 0x12C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected float m_ScrollSensitivity; // 0x130
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private ContentType m_ContentType; // 0x134
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private InputType m_InputType; // 0x138
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private char m_AsteriskChar; // 0x13C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TouchScreenKeyboardType m_KeyboardType; // 0x140
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private LineType m_LineType; // 0x144
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_HideMobileInput; // 0x148
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_HideSoftKeyboard; // 0x149
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private CharacterValidation m_CharacterValidation; // 0x14C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private string m_RegexValue; // 0x150
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private float m_GlobalPointSize; // 0x158
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private int m_CharacterLimit; // 0x15C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SubmitEvent m_OnEndEdit; // 0x160
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SubmitEvent m_OnSubmit; // 0x168
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SelectionEvent m_OnSelect; // 0x170
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private SelectionEvent m_OnDeselect; // 0x178
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextSelectionEvent m_OnTextSelection; // 0x180
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TextSelectionEvent m_OnEndTextSelection; // 0x188
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private OnChangeEvent m_OnValueChanged; // 0x190
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TouchScreenKeyboardEvent m_OnTouchScreenKeyboardStatusChanged; // 0x198
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private OnValidateInput m_OnValidateInput; // 0x1A0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color m_CaretColor; // 0x1A8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_CustomCaretColor; // 0x1B8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Color m_SelectionColor; // 0x1BC
		[SerializeField] // 0x00000001801EA4B0-0x00000001801EA4F0
		[TextArea] // 0x00000001801EA4B0-0x00000001801EA4F0
		protected string m_Text; // 0x1D0
		[Range] // 0x00000001801EA720-0x00000001801EA760
		[SerializeField] // 0x00000001801EA720-0x00000001801EA760
		private float m_CaretBlinkRate; // 0x1D8
		[Range] // 0x00000001801EA900-0x00000001801EA940
		[SerializeField] // 0x00000001801EA900-0x00000001801EA940
		private int m_CaretWidth; // 0x1DC
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_ReadOnly; // 0x1E0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_RichText; // 0x1E1
		protected int m_StringPosition; // 0x1E4
		protected int m_StringSelectPosition; // 0x1E8
		protected int m_CaretPosition; // 0x1EC
		protected int m_CaretSelectPosition; // 0x1F0
		private RectTransform caretRectTrans; // 0x1F8
		protected UIVertex[] m_CursorVerts; // 0x200
		private CanvasRenderer m_CachedInputRenderer; // 0x208
		private Vector2 m_LastPosition; // 0x210
		[NonSerialized]
		protected Mesh m_Mesh; // 0x218
		private bool m_AllowInput; // 0x220
		private bool m_ShouldActivateNextUpdate; // 0x221
		private bool m_UpdateDrag; // 0x222
		private bool m_DragPositionOutOfBounds; // 0x223
		private const float kHScrollSpeed = 0.05f; // Metadata: 0x00778140
		private const float kVScrollSpeed = 0.1f; // Metadata: 0x00778144
		protected bool m_CaretVisible; // 0x224
		private Coroutine m_BlinkCoroutine; // 0x228
		private float m_BlinkStartTime; // 0x230
		private Coroutine m_DragCoroutine; // 0x238
		private string m_OriginalText; // 0x240
		private bool m_WasCanceled; // 0x248
		private bool m_HasDoneFocusTransition; // 0x249
		private WaitForSecondsRealtime m_WaitForSecondsRealtime; // 0x250
		private bool m_PreventCallback; // 0x258
		private bool m_TouchKeyboardAllowsInPlaceEditing; // 0x259
		private bool m_IsTextComponentUpdateRequired; // 0x25A
		private bool m_IsScrollbarUpdateRequired; // 0x25B
		private bool m_IsUpdatingScrollbarValues; // 0x25C
		private bool m_isLastKeyBackspace; // 0x25D
		private float m_PointerDownClickStartTime; // 0x260
		private float m_KeyDownStartTime; // 0x264
		private float m_DoubleClickDelay; // 0x268
		private const string kEmailSpecialCharacters = "!#$%&\'*+-/=?^_`{|}~"; // Metadata: 0x00778148
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TMP_FontAsset m_GlobalFontAsset; // 0x270
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_OnFocusSelectAll; // 0x278
		protected bool m_isSelectAll; // 0x279
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_ResetOnDeActivation; // 0x27A
		private bool m_SelectionStillActive; // 0x27B
		private bool m_ReleaseSelection; // 0x27C
		private GameObject m_SelectedObject; // 0x280
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private bool m_RestoreOriginalTextOnEscape; // 0x288
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected bool m_isRichTextEditingAllowed; // 0x289
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected int m_LineLimit; // 0x28C
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		protected TMP_InputValidator m_InputValidator; // 0x290
		private bool m_isSelected; // 0x298
		private bool m_IsStringPositionDirty; // 0x299
		private bool m_IsCaretPositionDirty; // 0x29A
		private bool m_forceRectTransformAdjustment; // 0x29B
		private Event m_ProcessingEvent; // 0x2A0
	
		// Properties
		private BaseInput inputSystem { get; } // 0x000000018058C590-0x000000018058C6C0 
		private string compositionString { get; } // 0x000000018058C430-0x000000018058C4E0 
		protected Mesh mesh { get; } // 0x000000018058C740-0x000000018058C7E0 
		public bool shouldHideMobileInput { get; set; } // 0x000000018058CAB0-0x000000018058CAE0 0x000000018058DED0-0x000000018058DF50
		public bool shouldHideSoftKeyboard { get; set; } // 0x000000018058CAE0-0x000000018058CB30 0x000000018058DF50-0x000000018058E050
		public string text { get; set; } // 0x0000000180488910-0x0000000180488920 0x000000018058E290-0x000000018058E2A0
		public bool isFocused { get; } // 0x000000018058C6E0-0x000000018058C6F0 
		public float caretBlinkRate { get; set; } // 0x000000018058C330-0x000000018058C340 0x000000018058CBD0-0x000000018058CC40
		public int caretWidth { get; set; } // 0x000000018058C400-0x000000018058C410 0x000000018058CE70-0x000000018058CF10
		public RectTransform textViewport { get; set; } // 0x000000018037E230-0x000000018037E240 0x000000018058E240-0x000000018058E290
		public TMP_Text textComponent { get; set; } // 0x000000018037F030-0x000000018037F040 0x000000018058E1E0-0x000000018058E240
		public Graphic placeholder { get; set; } // 0x0000000180385320-0x0000000180385330 0x000000018058D940-0x000000018058D990
		public Scrollbar verticalScrollbar { get; set; } // 0x00000001803916B0-0x00000001803916C0 0x000000018058E2A0-0x000000018058E440
		public float scrollSensitivity { get; set; } // 0x000000018058CA30-0x000000018058CA40 0x000000018058DBC0-0x000000018058DC60
		public Color caretColor { get; set; } // 0x000000018058C340-0x000000018058C3A0 0x000000018058CC40-0x000000018058CCF0
		public bool customCaretColor { get; set; } // 0x000000018058C4F0-0x000000018058C500 0x000000018058D1F0-0x000000018058D260
		public Color selectionColor { get; set; } // 0x000000018058CA40-0x000000018058CA50 0x000000018058DCB0-0x000000018058DD60
		public SubmitEvent onEndEdit { get; set; } // 0x00000001803EF190-0x00000001803EF1A0 0x000000018058D6B0-0x000000018058D700
		public SubmitEvent onSubmit { get; set; } // 0x000000018058C840-0x000000018058C850 0x000000018058D7B0-0x000000018058D800
		public SelectionEvent onSelect { get; set; } // 0x000000018058C830-0x000000018058C840 0x000000018058D760-0x000000018058D7B0
		public SelectionEvent onDeselect { get; set; } // 0x00000001803EF200-0x00000001803EF210 0x000000018058D660-0x000000018058D6B0
		public TextSelectionEvent onTextSelection { get; set; } // 0x00000001803EF210-0x00000001803EF220 0x000000018058D800-0x000000018058D850
		public TextSelectionEvent onEndTextSelection { get; set; } // 0x000000018058C810-0x000000018058C820 0x000000018058D700-0x000000018058D750
		public OnChangeEvent onValueChanged { get; set; } // 0x000000018057C490-0x000000018057C4A0 0x000000018058D8F0-0x000000018058D940
		public TouchScreenKeyboardEvent onTouchScreenKeyboardStatusChanged { get; set; } // 0x000000018058C850-0x000000018058C860 0x000000018058D850-0x000000018058D8A0
		public OnValidateInput onValidateInput { get; set; } // 0x000000018058C860-0x000000018058C870 0x000000018058D8A0-0x000000018058D8F0
		public int characterLimit { get; set; } // 0x000000018058C410-0x000000018058C420 0x000000018058CF10-0x000000018058CFC0
		public float pointSize { get; set; } // 0x000000018058C870-0x000000018058C880 0x000000018058D990-0x000000018058DB00
		public TMP_FontAsset fontAsset { get; set; } // 0x000000018058C510-0x000000018058C520 0x000000018058D260-0x000000018058D3A0
		public bool onFocusSelectAll { get; set; } // 0x000000018058C820-0x000000018058C830 0x000000018058D750-0x000000018058D760
		public bool resetOnDeActivation { get; set; } // 0x000000018058CA00-0x000000018058CA10 0x000000018058DB10-0x000000018058DB20
		public bool restoreOriginalTextOnEscape { get; set; } // 0x000000018058CA10-0x000000018058CA20 0x000000018058DB20-0x000000018058DB30
		public bool isRichTextEditingAllowed { get; set; } // 0x000000018058C6F0-0x000000018058C700 0x000000018058D480-0x000000018058D490
		public ContentType contentType { get; set; } // 0x000000018058C4E0-0x000000018058C4F0 0x000000018058D040-0x000000018058D1F0
		public LineType lineType { get; set; } // 0x000000018058C730-0x000000018058C740 0x000000018058D570-0x000000018058D660
		public int lineLimit { get; set; } // 0x000000018058C720-0x000000018058C730 0x000000018058D500-0x000000018058D570
		public InputType inputType { get; set; } // 0x000000018058C6C0-0x000000018058C6D0 0x000000018058D3A0-0x000000018058D410
		public TouchScreenKeyboardType keyboardType { get; set; } // 0x000000018058C700-0x000000018058C710 0x000000018058D490-0x000000018058D500
		public CharacterValidation characterValidation { get; set; } // 0x000000018044F710-0x000000018044F720 0x000000018058CFC0-0x000000018058D030
		public TMP_InputValidator inputValidator { get; set; } // 0x000000018058C6D0-0x000000018058C6E0 0x000000018058D410-0x000000018058D480
		public bool readOnly { get; set; } // 0x000000018058C9F0-0x000000018058CA00 0x000000018058DB00-0x000000018058DB10
		public bool richText { get; set; } // 0x000000018058CA20-0x000000018058CA30 0x000000018058DB30-0x000000018058DBC0
		public bool multiLine { get; } // 0x000000018058C7F0-0x000000018058C810 
		public char asteriskChar { get; set; } // 0x000000018058C320-0x000000018058C330 0x000000018058CB70-0x000000018058CBD0
		public bool wasCanceled { get; } // 0x000000018058CB30-0x000000018058CB40 
		protected int caretPositionInternal { get; set; } // 0x000000018058C3A0-0x000000018058C3D0 0x000000018058CCF0-0x000000018058CD70
		protected int stringPositionInternal { get; set; } // 0x000000018058CA50-0x000000018058CA80 0x000000018058E050-0x000000018058E0A0
		protected int caretSelectPositionInternal { get; set; } // 0x000000018058C3D0-0x000000018058C400 0x000000018058CDF0-0x000000018058CE70
		protected int stringSelectPositionInternal { get; set; } // 0x000000018058CA80-0x000000018058CAB0 0x000000018058E190-0x000000018058E1E0
		private new bool hasSelection { get; } // 0x000000018058C520-0x000000018058C590 
		public int caretPosition { get; set; } // 0x000000018058C3D0-0x000000018058C400 0x000000018058CD70-0x000000018058CDF0
		public int selectionAnchorPosition { get; set; } // 0x000000018058C3A0-0x000000018058C3D0 0x000000018058DC60-0x000000018058DCB0
		public int selectionFocusPosition { get; set; } // 0x000000018058C3D0-0x000000018058C400 0x000000018058DD60-0x000000018058DDB0
		public int stringPosition { get; set; } // 0x000000018058CA80-0x000000018058CAB0 0x000000018058E0A0-0x000000018058E190
		public int selectionStringAnchorPosition { get; set; } // 0x000000018058CA50-0x000000018058CA80 0x000000018058DDB0-0x000000018058DE40
		public int selectionStringFocusPosition { get; set; } // 0x000000018058CA80-0x000000018058CAB0 0x000000018058DE40-0x000000018058DED0
		private static string clipboard { get; set; } // 0x000000018058C420-0x000000018058C430 0x000000018058D030-0x000000018058D040
		public virtual float minWidth { get; } // 0x000000018058C7E0-0x000000018058C7F0 
		public virtual float preferredWidth { get; } // 0x000000018058C930-0x000000018058C9F0 
		public virtual float flexibleWidth { get; } // 0x000000018058C500-0x000000018058C510 
		public virtual float minHeight { get; } // 0x000000018058C7E0-0x000000018058C7F0 
		public virtual float preferredHeight { get; } // 0x000000018058C880-0x000000018058C930 
		public virtual float flexibleHeight { get; } // 0x000000018058C500-0x000000018058C510 
		public virtual int layoutPriority { get; } // 0x000000018058C710-0x000000018058C720 
		Transform ICanvasElement.transform { get; } // 0x000000018058AF20-0x000000018058AF30 
	
		// Nested types
		public enum ContentType // TypeDefIndex: 8963
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
	
		public enum InputType // TypeDefIndex: 8964
		{
			Standard = 0,
			AutoCorrect = 1,
			Password = 2
		}
	
		public enum CharacterValidation // TypeDefIndex: 8965
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
	
		public enum LineType // TypeDefIndex: 8966
		{
			SingleLine = 0,
			MultiLineSubmit = 1,
			MultiLineNewline = 2
		}
	
		public delegate char OnValidateInput(string text, int charIndex, char addedChar); // TypeDefIndex: 8967; 0x00000001805A35D0-0x00000001805A3B50
	
		[Serializable]
		public class SubmitEvent : UnityEvent<string> // TypeDefIndex: 8968
		{
			// Constructors
			public SubmitEvent(); // 0x00000001805A3B90-0x00000001805A3D50
		}
	
		[Serializable]
		public class OnChangeEvent : UnityEvent<string> // TypeDefIndex: 8969
		{
			// Constructors
			public OnChangeEvent(); // 0x00000001805A34C0-0x00000001805A3500
		}
	
		[Serializable]
		public class SelectionEvent : UnityEvent<string> // TypeDefIndex: 8970
		{
			// Constructors
			public SelectionEvent(); // 0x00000001805A3B50-0x00000001805A3B90
		}
	
		[Serializable]
		public class TextSelectionEvent : UnityEvent<string, int, int> // TypeDefIndex: 8971
		{
			// Constructors
			public TextSelectionEvent(); // 0x00000001805CD750-0x00000001805CD790
		}
	
		[Serializable]
		public class TouchScreenKeyboardEvent : UnityEvent<TouchScreenKeyboard.Status> // TypeDefIndex: 8972
		{
			// Constructors
			public TouchScreenKeyboardEvent(); // 0x00000001805CD790-0x00000001805CD7D0
		}
	
		protected enum EditState // TypeDefIndex: 8973
		{
			Continue = 0,
			Finish = 1
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <CaretBlink>d__267 : IEnumerator<object> // TypeDefIndex: 8974
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TMP_InputField <>4__this; // 0x20
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <CaretBlink>d__267(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001805CD7D0-0x00000001805CD900
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001805CD900-0x00000001805CD950
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <MouseDragOutsideRect>d__285 : IEnumerator<object> // TypeDefIndex: 8975
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TMP_InputField <>4__this; // 0x20
			public PointerEventData eventData; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <MouseDragOutsideRect>d__285(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x00000001805CE720-0x00000001805CE9C0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x00000001805CE9C0-0x00000001805CEA10
		}
	
		// Constructors
		protected TMP_InputField(); // 0x000000018058C070-0x000000018058C320
		static TMP_InputField(); // 0x000000018058C010-0x000000018058C070
	
		// Methods
		private bool isKeyboardUsingEvents(); // 0x000000018058CB40-0x000000018058CB70
		public void SetTextWithoutNotify(string input); // 0x000000018058ACF0-0x000000018058AD00
		private void SetText(string value, bool sendCallback = true /* Metadata: 0x0077813E */); // 0x000000018058AD00-0x000000018058AE90
		protected void ClampStringPos(ref int pos); // 0x000000018057F810-0x000000018057F860
		protected void ClampCaretPos(ref int pos); // 0x000000018057F7A0-0x000000018057F810
		protected override void OnEnable(); // 0x0000000180587A30-0x00000001805880D0
		protected override void OnDisable(); // 0x00000001805870F0-0x0000000180587420
		private void ON_TEXT_CHANGED(UnityEngine.Object obj); // 0x0000000180586F30-0x0000000180587050
		[IteratorStateMachine] // 0x00000001801EBAA0-0x00000001801EBAF0
		private IEnumerator CaretBlink(); // 0x000000018057F730-0x000000018057F7A0
		private void SetCaretVisible(); // 0x000000018058A980-0x000000018058A9C0
		private void SetCaretActive(); // 0x000000018058A8D0-0x000000018058A980
		protected void OnFocus(); // 0x0000000180588540-0x0000000180588560
		protected void SelectAll(); // 0x000000018058A3F0-0x000000018058A490
		public void MoveTextEnd(bool shift); // 0x0000000180586140-0x00000001805863C0
		public void MoveTextStart(bool shift); // 0x00000001805863C0-0x00000001805865F0
		public void MoveToEndOfLine(bool shift, bool ctrl); // 0x00000001805865F0-0x00000001805868E0
		public void MoveToStartOfLine(bool shift, bool ctrl); // 0x00000001805868E0-0x0000000180586C30
		private bool InPlaceEditing(); // 0x0000000180582B30-0x0000000180582C20
		private void UpdateStringPositionFromKeyboard(); // 0x000000018058B670-0x000000018058B880
		protected virtual void LateUpdate(); // 0x0000000180583310-0x0000000180583A40
		private bool MayDrag(PointerEventData eventData); // 0x00000001805841E0-0x00000001805842F0
		public virtual void OnBeginDrag(PointerEventData eventData); // 0x0000000180587050-0x0000000180587080
		public virtual void OnDrag(PointerEventData eventData); // 0x0000000180587420-0x0000000180587A30
		[IteratorStateMachine] // 0x00000001801EBD60-0x00000001801EBDB0
		private IEnumerator MouseDragOutsideRect(PointerEventData eventData); // 0x00000001805842F0-0x0000000180584370
		public virtual void OnEndDrag(PointerEventData eventData); // 0x00000001805880D0-0x0000000180588100
		public override void OnPointerDown(PointerEventData eventData); // 0x0000000180588590-0x00000001805893F0
		protected EditState KeyPressed(Event evt); // 0x0000000180582E80-0x0000000180583310
		protected virtual bool IsValidChar(char c); // 0x0000000180582E70-0x0000000180582E80
		public void ProcessEvent(Event e); // 0x000000018058A2B0-0x000000018058A2C0
		public virtual void OnUpdateSelected(BaseEventData eventData); // 0x0000000180589710-0x0000000180589890
		public virtual void OnScroll(PointerEventData eventData); // 0x00000001805893F0-0x00000001805895C0
		private string GetSelectedString(); // 0x0000000180582960-0x0000000180582A70
		private int FindNextWordBegin(); // 0x0000000180580A40-0x0000000180580B80
		private void MoveRight(bool shift, bool ctrl); // 0x0000000180585940-0x0000000180586140
		private int FindPrevWordBegin(); // 0x0000000180580B80-0x0000000180580C90
		private void MoveLeft(bool shift, bool ctrl); // 0x00000001805846A0-0x0000000180584E70
		private int LineUpCharacterPosition(int originalPos, bool goToFirstChar); // 0x0000000180583E10-0x0000000180584180
		private int LineDownCharacterPosition(int originalPos, bool goToLastChar); // 0x0000000180583A40-0x0000000180583E10
		private int PageUpCharacterPosition(int originalPos, bool goToFirstChar); // 0x0000000180589DF0-0x000000018058A2B0
		private int PageDownCharacterPosition(int originalPos, bool goToLastChar); // 0x0000000180589890-0x0000000180589DF0
		private void MoveDown(bool shift); // 0x0000000180584690-0x00000001805846A0
		private void MoveDown(bool shift, bool goToLastChar); // 0x0000000180584370-0x0000000180584690
		private void MoveUp(bool shift); // 0x0000000180586F20-0x0000000180586F30
		private void MoveUp(bool shift, bool goToFirstChar); // 0x0000000180586C30-0x0000000180586F20
		private void MovePageUp(bool shift); // 0x0000000180585930-0x0000000180585940
		private void MovePageUp(bool shift, bool goToFirstChar); // 0x00000001805853F0-0x0000000180585930
		private void MovePageDown(bool shift); // 0x00000001805853E0-0x00000001805853F0
		private void MovePageDown(bool shift, bool goToLastChar); // 0x0000000180584E70-0x00000001805853E0
		private void Delete(); // 0x0000000180580030-0x00000001805808A0
		private void DeleteKey(); // 0x000000018057FC40-0x0000000180580030
		private void Backspace(); // 0x000000018057F110-0x000000018057F730
		protected virtual void Append(string input); // 0x000000018057E790-0x000000018057E840
		protected virtual void Append(char input); // 0x000000018057E600-0x000000018057E790
		private void Insert(char c); // 0x0000000180582C20-0x0000000180582E70
		private void UpdateTouchKeyboardFromEditChanges(); // 0x000000018058B880-0x000000018058B8D0
		private void SendOnValueChangedAndUpdateLabel(); // 0x000000018058A7A0-0x000000018058A800
		private void SendOnValueChanged(); // 0x000000018058A800-0x000000018058A850
		protected void SendOnEndEdit(); // 0x000000018058A490-0x000000018058A4E0
		protected void SendOnSubmit(); // 0x000000018058A670-0x000000018058A6C0
		protected void SendOnFocus(); // 0x000000018058A620-0x000000018058A670
		protected void SendOnFocusLost(); // 0x000000018058A5D0-0x000000018058A620
		protected void SendOnTextSelection(); // 0x000000018058A6C0-0x000000018058A7A0
		protected void SendOnEndTextSelection(); // 0x000000018058A4E0-0x000000018058A5D0
		protected void SendTouchScreenKeyboardStatusChanged(); // 0x000000018058A850-0x000000018058A8D0
		protected void UpdateLabel(); // 0x000000018058AFF0-0x000000018058B490
		private void UpdateScrollbar(); // 0x000000018058B490-0x000000018058B670
		private void OnScrollbarValueChange(float value); // 0x00000001805895C0-0x0000000180589620
		private void AdjustTextPositionRelativeToViewport(float relativePosition); // 0x000000018057E420-0x000000018057E600
		private int GetCaretPositionFromStringIndex(int stringIndex); // 0x00000001805827B0-0x0000000180582860
		private int GetMinCaretPositionFromStringIndex(int stringIndex); // 0x0000000180582860-0x0000000180582960
		private int GetMaxCaretPositionFromStringIndex(int stringIndex); // 0x00000001805827B0-0x0000000180582860
		private int GetStringIndexFromCaretPosition(int caretPosition); // 0x0000000180582A70-0x0000000180582B30
		public void ForceLabelUpdate(); // 0x0000000180580C90-0x0000000180580CA0
		private void MarkGeometryAsDirty(); // 0x0000000180584180-0x00000001805841E0
		public virtual void Rebuild(CanvasUpdate update); // 0x000000018058A2C0-0x000000018058A390
		public virtual void LayoutComplete(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void GraphicUpdateComplete(); // 0x00000001803774A0-0x00000001803774B0
		private void UpdateGeometry(); // 0x000000018058AF30-0x000000018058AFF0
		private void AssignPositioningIfNeeded(); // 0x000000018057E840-0x000000018057F110
		private void OnFillVBO(Mesh vbo); // 0x0000000180588100-0x0000000180588540
		private void GenerateCaret(VertexHelper vbo, Vector2 roundingOffset); // 0x0000000180580CA0-0x0000000180581860
		private void CreateCursorVerts(); // 0x000000018057F860-0x000000018057FA00
		private void GenerateHightlight(VertexHelper vbo, Vector2 roundingOffset); // 0x0000000180581860-0x00000001805827B0
		private void AdjustRectTransformRelativeToViewport(Vector2 startPosition, float height, bool isCharVisible); // 0x000000018057DA00-0x000000018057E420
		protected char Validate(string text, int pos, char ch); // 0x000000018058B8D0-0x000000018058C010
		public void ActivateInputField(); // 0x000000018057D8B0-0x000000018057DA00
		private void ActivateInputFieldInternal(); // 0x000000018057D2F0-0x000000018057D8B0
		public override void OnSelect(BaseEventData eventData); // 0x0000000180589620-0x0000000180589680
		public virtual void OnPointerClick(PointerEventData eventData); // 0x0000000180588560-0x0000000180588590
		public void OnControlClick(); // 0x00000001803774A0-0x00000001803774B0
		public void ReleaseSelection(); // 0x000000018058A390-0x000000018058A3F0
		public void DeactivateInputField(bool clearSelection = false /* Metadata: 0x0077813F */); // 0x000000018057FA00-0x000000018057FC40
		public override void OnDeselect(BaseEventData eventData); // 0x0000000180587080-0x00000001805870F0
		public virtual void OnSubmit(BaseEventData eventData); // 0x0000000180589680-0x0000000180589710
		private void EnforceContentType(); // 0x00000001805808D0-0x0000000180580A40
		private void SetTextComponentWrapMode(); // 0x000000018058AC30-0x000000018058ACF0
		private void SetTextComponentRichTextMode(); // 0x000000018058ABA0-0x000000018058AC30
		private void SetToCustomIfContentTypeIsNot(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ ContentType[] allowedContentTypes); // 0x000000018058AE90-0x000000018058AF00
		private void SetToCustom(); // 0x000000018058AF00-0x000000018058AF20
		private void SetToCustom(CharacterValidation characterValidation); // 0x000000018058AF00-0x000000018058AF20
		protected override void DoStateTransition(SelectionState state, bool instant); // 0x00000001805808A0-0x00000001805808D0
		public virtual void CalculateLayoutInputHorizontal(); // 0x00000001803774A0-0x00000001803774B0
		public virtual void CalculateLayoutInputVertical(); // 0x00000001803774A0-0x00000001803774B0
		public void SetGlobalPointSize(float pointSize); // 0x000000018058AAB0-0x000000018058ABA0
		public void SetGlobalFontAsset(TMP_FontAsset fontAsset); // 0x000000018058A9C0-0x000000018058AAB0
	}
}
