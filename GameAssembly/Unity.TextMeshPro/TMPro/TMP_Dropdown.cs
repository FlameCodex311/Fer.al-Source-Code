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
	[AddComponentMenu] // 0x00000001801DAF80-0x00000001801DB000
	[RequireComponent] // 0x00000001801DAF80-0x00000001801DB000
	public class TMP_Dropdown : Selectable, IPointerClickHandler, ISubmitHandler, ICancelHandler // TypeDefIndex: 8931
	{
		// Fields
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private RectTransform m_Template; // 0xF0
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private TMP_Text m_CaptionText; // 0xF8
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Image m_CaptionImage; // 0x100
		[SerializeField] // 0x00000001801DB7F0-0x00000001801DB820
		[Space] // 0x00000001801DB7F0-0x00000001801DB820
		private TMP_Text m_ItemText; // 0x108
		[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
		private Image m_ItemImage; // 0x110
		[SerializeField] // 0x00000001801DB7F0-0x00000001801DB820
		[Space] // 0x00000001801DB7F0-0x00000001801DB820
		private int m_Value; // 0x118
		[SerializeField] // 0x00000001801DB7F0-0x00000001801DB820
		[Space] // 0x00000001801DB7F0-0x00000001801DB820
		private OptionDataList m_Options; // 0x120
		[SerializeField] // 0x00000001801DB7F0-0x00000001801DB820
		[Space] // 0x00000001801DB7F0-0x00000001801DB820
		private DropdownEvent m_OnValueChanged; // 0x128
		private GameObject m_Dropdown; // 0x130
		private GameObject m_Blocker; // 0x138
		private List<DropdownItem> m_Items; // 0x140
		private TweenRunner<FloatTween> m_AlphaTweenRunner; // 0x148
		private bool validTemplate; // 0x150
		private static OptionData s_NoOptionData; // 0x00
	
		// Properties
		public RectTransform template { get; set; } // 0x000000018037DDB0-0x000000018037DDC0 0x00000001805742E0-0x00000001805742F0
		public TMP_Text captionText { get; set; } // 0x000000018037E230-0x000000018037E240 0x0000000180574270-0x0000000180574280
		public Image captionImage { get; set; } // 0x000000018037F030-0x000000018037F040 0x0000000180574260-0x0000000180574270
		public TMP_Text itemText { get; set; } // 0x0000000180380B50-0x0000000180380B60 0x0000000180574290-0x00000001805742A0
		public Image itemImage { get; set; } // 0x0000000180385320-0x0000000180385330 0x0000000180574280-0x0000000180574290
		public List<OptionData> options { get; set; } // 0x0000000180574240-0x0000000180574260 0x00000001805742B0-0x00000001805742E0
		public DropdownEvent onValueChanged { get; set; } // 0x00000001803EF180-0x00000001803EF190 0x00000001805742A0-0x00000001805742B0
		public int value { get; set; } // 0x00000001803B7C30-0x00000001803B7C40 0x00000001805742F0-0x0000000180574300
		public bool IsExpanded { get; } // 0x00000001805741E0-0x0000000180574240 
	
		// Nested types
		protected internal class DropdownItem : UnityEngine.MonoBehaviour, IPointerEnterHandler, ICancelHandler // TypeDefIndex: 8932
		{
			// Fields
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private TMP_Text m_Text; // 0x18
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Image m_Image; // 0x20
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private RectTransform m_RectTransform; // 0x28
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Toggle m_Toggle; // 0x30
	
			// Properties
			public TMP_Text text { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
			public Image image { get; set; } // 0x0000000180374AF0-0x0000000180374B00 0x00000001803F70C0-0x00000001803F70D0
			public RectTransform rectTransform { get; set; } // 0x00000001803745B0-0x00000001803745C0 0x00000001803FA0C0-0x00000001803FA0D0
			public Toggle toggle { get; set; } // 0x00000001803745C0-0x00000001803745D0 0x00000001803FA0A0-0x00000001803FA0B0
	
			// Constructors
			public DropdownItem(); // 0x0000000180568C50-0x0000000180569020
	
			// Methods
			public virtual void OnPointerEnter(PointerEventData eventData); // 0x0000000180568BD0-0x0000000180568C50
			public virtual void OnCancel(BaseEventData eventData); // 0x0000000180568B40-0x0000000180568BD0
		}
	
		[Serializable]
		public class OptionData // TypeDefIndex: 8933
		{
			// Fields
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private string m_Text; // 0x10
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private Sprite m_Image; // 0x18
	
			// Properties
			public string text { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
			public Sprite image { get; set; } // 0x0000000180372430-0x0000000180372440 0x0000000180379F30-0x0000000180379F40
	
			// Constructors
			public OptionData(); // 0x0000000180373240-0x0000000180373250
			public OptionData(string text); // 0x0000000180400150-0x0000000180400180
			public OptionData(Sprite image); // 0x000000018056B4B0-0x000000018056B4E0
			public OptionData(string text, Sprite image); // 0x0000000180372010-0x00000001803720F0
		}
	
		[Serializable]
		public class OptionDataList // TypeDefIndex: 8934
		{
			// Fields
			[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
			private List<OptionData> m_Options; // 0x10
	
			// Properties
			public List<OptionData> options { get; set; } // 0x0000000180372440-0x0000000180372450 0x0000000180379F20-0x0000000180379F30
	
			// Constructors
			public OptionDataList(); // 0x000000018056B450-0x000000018056B4B0
		}
	
		[Serializable]
		public class DropdownEvent : UnityEvent<int> // TypeDefIndex: 8935
		{
			// Constructors
			public DropdownEvent(); // 0x0000000180568B00-0x0000000180568B40
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <>c__DisplayClass60_0 // TypeDefIndex: 8936
		{
			// Fields
			public DropdownItem item; // 0x10
			public TMP_Dropdown <>4__this; // 0x18
	
			// Constructors
			public <>c__DisplayClass60_0(); // 0x0000000180373240-0x0000000180373250
	
			// Methods
			internal void <Show>b__0(bool x); // 0x000000018058E670-0x000000018058E7C0
		}
	
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <DelayedDestroyDropdownList>d__72 : IEnumerator<object> // TypeDefIndex: 8937
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public float delay; // 0x20
			public TMP_Dropdown <>4__this; // 0x28
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
	
			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <DelayedDestroyDropdownList>d__72(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60
	
			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x000000018058E440-0x000000018058E4F0
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x000000018058E4F0-0x000000018058E540
		}
	
		// Constructors
		protected TMP_Dropdown(); // 0x00000001805740B0-0x00000001805741E0
		static TMP_Dropdown(); // 0x0000000180574050-0x00000001805740B0
	
		// Methods
		public void SetValueWithoutNotify(int input); // 0x0000000180572900-0x0000000180572910
		private void SetValue(int value, bool sendCallback = true /* Metadata: 0x00778128 */); // 0x0000000180572910-0x0000000180572A50
		protected override void Awake(); // 0x00000001805719D0-0x0000000180571B40
		protected override void Start(); // 0x0000000180574030-0x0000000180574050
		protected override void OnDisable(); // 0x00000001805723F0-0x0000000180572490
		public void RefreshShownValue(); // 0x00000001805725D0-0x0000000180572850
		public void AddOptions(List<OptionData> options); // 0x00000001805716E0-0x0000000180571750
		public void AddOptions(List<string> options); // 0x00000001805714E0-0x00000001805715E0
		public void AddOptions(List<Sprite> options); // 0x00000001805715E0-0x00000001805716E0
		public void ClearOptions(); // 0x0000000180571B40-0x0000000180571BB0
		private void SetupTemplate(); // 0x0000000180572A50-0x0000000180572F80
		private static T GetOrAddComponent<T>(GameObject go)
			where T : Component;
		public virtual void OnPointerClick(PointerEventData eventData); // 0x0000000180572490-0x00000001805724A0
		public virtual void OnSubmit(BaseEventData eventData); // 0x0000000180572490-0x00000001805724A0
		public virtual void OnCancel(BaseEventData eventData); // 0x00000001805723E0-0x00000001805723F0
		public void Show(); // 0x0000000180572F80-0x0000000180574030
		protected virtual GameObject CreateBlocker(Canvas rootCanvas); // 0x0000000180571BB0-0x0000000180571E90
		protected virtual void DestroyBlocker(GameObject blocker); // 0x0000000180571FC0-0x0000000180572020
		protected virtual GameObject CreateDropdownList(GameObject template); // 0x0000000180571E90-0x0000000180571EF0
		protected virtual void DestroyDropdownList(GameObject dropdownList); // 0x0000000180572020-0x0000000180572080
		protected virtual DropdownItem CreateItem(DropdownItem itemTemplate); // 0x0000000180571EF0-0x0000000180571F50
		protected virtual void DestroyItem(DropdownItem item); // 0x00000001803774A0-0x00000001803774B0
		private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items); // 0x00000001805711F0-0x00000001805714E0
		private void AlphaFadeList(float duration, float alpha); // 0x0000000180571750-0x00000001805717F0
		private void AlphaFadeList(float duration, float start, float end); // 0x00000001805717F0-0x00000001805719D0
		private void SetAlpha(float alpha); // 0x0000000180572850-0x0000000180572900
		public void Hide(); // 0x0000000180572080-0x0000000180572240
		[IteratorStateMachine] // 0x00000001801DD250-0x00000001801DD2A0
		private IEnumerator DelayedDestroyDropdownList(float delay); // 0x0000000180571F50-0x0000000180571FC0
		private void ImmediateDestroyDropdownList(); // 0x0000000180572240-0x00000001805723E0
		private void OnSelectItem(Toggle toggle); // 0x00000001805724A0-0x00000001805725D0
	}
}
