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
	[AddComponentMenu] // 0x0000000180142F00-0x0000000180142F80
	[RequireComponent] // 0x0000000180142F00-0x0000000180142F80
	public class TMP_Dropdown : Selectable, IPointerClickHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 8769
	{
		// Fields
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private RectTransform m_Template; // 0xE8
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private TMP_Text m_CaptionText; // 0xF0
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Image m_CaptionImage; // 0xF8
		[SerializeField] // 0x00000001800D52A0-0x00000001800D52D0
		[Space] // 0x00000001800D52A0-0x00000001800D52D0
		private TMP_Text m_ItemText; // 0x100
		[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
		private Image m_ItemImage; // 0x108
		[SerializeField] // 0x00000001800D52A0-0x00000001800D52D0
		[Space] // 0x00000001800D52A0-0x00000001800D52D0
		private int m_Value; // 0x110
		[SerializeField] // 0x00000001800D52A0-0x00000001800D52D0
		[Space] // 0x00000001800D52A0-0x00000001800D52D0
		private OptionDataList m_Options; // 0x118
		[SerializeField] // 0x00000001800D52A0-0x00000001800D52D0
		[Space] // 0x00000001800D52A0-0x00000001800D52D0
		private DropdownEvent m_OnValueChanged; // 0x120
		private GameObject m_Dropdown; // 0x128
		private GameObject m_Blocker; // 0x130
		private List<DropdownItem> m_Items; // 0x138
		private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x140
		private bool validTemplate; // 0x148
		private static OptionData s_NoOptionData; // 0x00
	
		// Properties
		public RectTransform template { get; set; } // 0x000000018037A250-0x000000018037A260 0x00000001810C9980-0x00000001810C9990
		public TMP_Text captionText { get; set; } // 0x00000001803BD320-0x00000001803BD330 0x00000001810C9920-0x00000001810C9930
		public Image captionImage { get; set; } // 0x00000001803BD310-0x00000001803BD320 0x00000001810C9910-0x00000001810C9920
		public TMP_Text itemText { get; set; } // 0x00000001803BD370-0x00000001803BD380 0x00000001810C9940-0x00000001810C9950
		public Image itemImage { get; set; } // 0x00000001803BD3C0-0x00000001803BD3D0 0x00000001810C9930-0x00000001810C9940
		public List<OptionData> options { get; set; } // 0x00000001810C98D0-0x00000001810C9900 0x00000001810C9950-0x00000001810C9980
		public DropdownEvent onValueChanged { get; set; } // 0x00000001803BD3D0-0x00000001803BD3E0 0x00000001803BE5F0-0x00000001803BE600
		public int value { get; set; } // 0x00000001810C9900-0x00000001810C9910 0x00000001810C9990-0x00000001810C99A0
		public bool IsExpanded { get; } // 0x00000001810C9870-0x00000001810C98D0 
	
		// Nested types
		protected internal class DropdownItem : UnityEngine.MonoBehaviour, IPointerEnterHandler, ICancelHandler // TypeDefIndex: 8770
		{
			// Fields
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private TMP_Text m_Text; // 0x18
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private Image m_Image; // 0x20
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private RectTransform m_RectTransform; // 0x28
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private Toggle m_Toggle; // 0x30
	
			// Properties
			public TMP_Text text { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
			public Image image { get; set; } // 0x000000018036AC70-0x000000018036AC80 0x000000018036AC90-0x000000018036ACA0
			public RectTransform rectTransform { get; set; } // 0x0000000180369B60-0x0000000180369B70 0x0000000180422D30-0x0000000180422D40
			public Toggle toggle { get; set; } // 0x0000000180397720-0x0000000180397730 0x00000001803A2800-0x00000001803A2810
	
			// Constructors
			public DropdownItem(); // 0x0000000180407560-0x0000000180407570
	
			// Methods
			public virtual void OnPointerEnter(PointerEventData eventData); // 0x00000001810BDF60-0x00000001810BE3D0
			public virtual void OnCancel(BaseEventData eventData); // 0x00000001810BDED0-0x00000001810BDF60
		}
	
		[Serializable]
		public class OptionData // TypeDefIndex: 8771
		{
			// Fields
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private string m_Text; // 0x10
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private Sprite m_Image; // 0x18
	
			// Properties
			public string text { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
			public Sprite image { get; set; } // 0x000000018038B150-0x000000018038B160 0x000000018038B160-0x000000018038B170
	
			// Constructors
			public OptionData(); // 0x000000018036B6C0-0x000000018036B6D0
			public OptionData(string text); // 0x000000018037D3F0-0x000000018037D420
			public OptionData(Sprite image); // 0x0000000180626C40-0x0000000180626C70
			public OptionData(string text, Sprite image); // 0x00000001803DA900-0x00000001803DA940
		}
	
		[Serializable]
		public class OptionDataList // TypeDefIndex: 8772
		{
			// Fields
			[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
			private List<OptionData> m_Options; // 0x10
	
			// Properties
			public List<OptionData> options { get; set; } // 0x000000018036AC80-0x000000018036AC90 0x000000018036B1E0-0x000000018036B1F0
	
			// Constructors
			public OptionDataList(); // 0x00000001810C08E0-0x00000001810C0940
		}
	
		[Serializable]
		public class DropdownEvent : UnityEvent<int> // TypeDefIndex: 8773
		{
			// Constructors
			public DropdownEvent(); // 0x00000001810BDE90-0x00000001810BDED0
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <>c__DisplayClass60_0 // TypeDefIndex: 8774
		{
			// Fields
			public DropdownItem item; // 0x10
			public TMP_Dropdown <>4__this; // 0x18
	
			// Constructors
			public <>c__DisplayClass60_0(); // 0x000000018036B6C0-0x000000018036B6D0
	
			// Methods
			internal void <Show>b__0(bool x); // 0x00000001810E40D0-0x00000001810E4230
		}
	
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <DelayedDestroyDropdownList>d__72 : IEnumerator<object> // TypeDefIndex: 8775
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public float delay; // 0x20
			public TMP_Dropdown <>4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
	
			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <DelayedDestroyDropdownList>d__72(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50
	
			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x00000001810E3E90-0x00000001810E3F40
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x00000001810E3F40-0x00000001810E3F90
		}
	
		// Constructors
		protected TMP_Dropdown(); // 0x00000001810C9740-0x00000001810C9870
		static TMP_Dropdown(); // 0x00000001810C96E0-0x00000001810C9740
	
		// Methods
		public void SetValueWithoutNotify(int input); // 0x00000001810C7F30-0x00000001810C7F40
		private void SetValue(int value, bool sendCallback = true /* Metadata: 0x00743462 */); // 0x00000001810C7F40-0x00000001810C8080
		protected override void Awake(); // 0x00000001810C6FB0-0x00000001810C7130
		protected override void Start(); // 0x00000001810C96C0-0x00000001810C96E0
		protected override void OnDisable(); // 0x00000001810C7A00-0x00000001810C7AA0
		public void RefreshShownValue(); // 0x00000001810C7BF0-0x00000001810C7E80
		public void AddOptions(List<OptionData> options); // 0x00000001810C6CB0-0x00000001810C6D30
		public void AddOptions(List<string> options); // 0x00000001810C6AB0-0x00000001810C6BB0
		public void AddOptions(List<Sprite> options); // 0x00000001810C6BB0-0x00000001810C6CB0
		public void ClearOptions(); // 0x00000001810C7130-0x00000001810C71A0
		private void SetupTemplate(); // 0x00000001810C8080-0x00000001810C85C0
		private static T GetOrAddComponent<T>(GameObject go)
			where T : Component;
		public virtual void OnPointerClick(PointerEventData eventData); // 0x00000001810C7AA0-0x00000001810C7AB0
		public virtual void OnSubmit(BaseEventData eventData); // 0x00000001810C7AA0-0x00000001810C7AB0
		public virtual void OnCancel(BaseEventData eventData); // 0x00000001810C79F0-0x00000001810C7A00
		public void Show(); // 0x00000001810C85C0-0x00000001810C96C0
		protected virtual GameObject CreateBlocker(Canvas rootCanvas); // 0x00000001810C71A0-0x00000001810C7490
		protected virtual void DestroyBlocker(GameObject blocker); // 0x00000001810C75C0-0x00000001810C7620
		protected virtual GameObject CreateDropdownList(GameObject template); // 0x00000001810C7490-0x00000001810C74F0
		protected virtual void DestroyDropdownList(GameObject dropdownList); // 0x00000001810C7620-0x00000001810C7680
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate); // 0x00000001810C74F0-0x00000001810C7550
		protected virtual void DestroyItem(DropdownItem item); // 0x00000001803581E0-0x00000001803581F0
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items); // 0x00000001810C67A0-0x00000001810C6AB0
		private void AlphaFadeList(float duration, float alpha); // 0x00000001810C6D30-0x00000001810C6DD0
		private void AlphaFadeList(float duration, float start, float end); // 0x00000001810C6DD0-0x00000001810C6FB0
		private void SetAlpha(float alpha); // 0x00000001810C7E80-0x00000001810C7F30
		public void Hide(); // 0x00000001810C7680-0x00000001810C7840
		[IteratorStateMachine] // 0x0000000180143D60-0x0000000180143DB0
		private IEnumerator DelayedDestroyDropdownList(float delay); // 0x00000001810C7550-0x00000001810C75C0
		private void ImmediateDestroyDropdownList(); // 0x00000001810C7840-0x00000001810C79F0
		private void OnSelectItem(Toggle toggle); // 0x00000001810C7AB0-0x00000001810C7BF0
	}
}
