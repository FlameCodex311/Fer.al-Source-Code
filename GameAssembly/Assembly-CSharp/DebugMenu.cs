/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class DebugMenu : MonoBehaviour // TypeDefIndex: 13203
{
	// Fields
	public GameObject canvasPrefab; // 0x20
	public GameObject panelPrefab; // 0x28
	public GameObject tabsHolderPrefab; // 0x30
	public GameObject sectionPanelPrefab; // 0x38
	public GameObject collapseGroupPrefab; // 0x40
	public GameObject scrollViewPrefab; // 0x48
	public GameObject buttonPrefab; // 0x50
	public GameObject inputPrefab; // 0x58
	public GameObject togglePrefab; // 0x60
	public GameObject textPrefab; // 0x68
	public GameObject tabBarPrefab; // 0x70
	public GameObject tabButtonPrefab; // 0x78
	private GameObject eventSystem; // 0x80
	private GameObject panel; // 0x88
	private GameObject scrollView; // 0x90
	private GameObject content; // 0x98
	private GameObject tabBar; // 0xA0
	private GameObject tabsHolder; // 0xA8
	private List<GameObject> tabButtons; // 0xB0
	private List<GameObject> tabPanels; // 0xB8
	private List<DMInstruction> instructions; // 0xC0
	private List<List<DMInstruction>> tabInstructionMap; // 0xC8
	private List<TextPair> textPairs; // 0xD0
	private List<TogglePair> togglePairs; // 0xD8
	private List<InputPair> inputPairs; // 0xE0
	private List<CollapsePair> collapsePairs; // 0xE8
	private List<InstructionPair> identifiables; // 0xF0
	private List<string> parentIDs; // 0xF8
	private int tabIndex; // 0x100
	private bool invalidated; // 0x104
	private bool initialized; // 0x105
	private int idCount; // 0x108
	private static DebugMenu debugMenu; // 0x00

	// Properties
	public static DebugMenu Instance { get; } // 0x0000000180F4B790-0x0000000180F4B920 

	// Nested types
	private class TextPair // TypeDefIndex: 13204
	{
		// Fields
		public UnityEngine.UI.Text text; // 0x10
		public Func<string> getter; // 0x18

		// Constructors
		public TextPair(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public void UpdateText(); // 0x000000018119B0C0-0x000000018119B130
	}

	private class InputPair // TypeDefIndex: 13205
	{
		// Fields
		public InputField input; // 0x10
		public Func<string> getter; // 0x18
		public Action<string> setter; // 0x20

		// Constructors
		public InputPair(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public void UpdateText(); // 0x00000001811996F0-0x0000000181199760
		public void OnChange(string value); // 0x00000001811996A0-0x00000001811996F0
	}

	private class TogglePair // TypeDefIndex: 13206
	{
		// Fields
		public Toggle toggle; // 0x10
		public Func<bool> getter; // 0x18
		public Action<bool> setter; // 0x20

		// Constructors
		public TogglePair(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public void UpdateState(); // 0x000000018119B180-0x000000018119B1F0
		public void OnChange(bool value); // 0x000000018119B130-0x000000018119B180
	}

	private class CollapsePair // TypeDefIndex: 13207
	{
		// Fields
		public GameObject content; // 0x10
		public Toggle toggle; // 0x18

		// Constructors
		public CollapsePair(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public static CollapsePair Create(GameObject collapseGroup, string title = null, bool open = false /* Metadata: 0x00783967 */); // 0x00000001811828D0-0x0000000181182AD0
		public void UpdateState(); // 0x0000000181182AD0-0x0000000181182B10
	}

	private class InstructionPair // TypeDefIndex: 13208
	{
		// Fields
		public DMInstruction instruction; // 0x10
		public List<DMInstruction> parentList; // 0x18

		// Constructors
		public InstructionPair(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <FancyTabSwitch>d__56 : IEnumerator<object> // TypeDefIndex: 13209
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public DebugMenu <>4__this; // 0x20
		public int tab; // 0x28
		private CanvasGroup <group>5__2; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <FancyTabSwitch>d__56(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018119B620-0x000000018119B7B0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018119B7B0-0x000000018119B800
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <FadeCanvasGroup>d__67 : IEnumerator<object> // TypeDefIndex: 13210
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CanvasGroup group; // 0x20
		public float duration; // 0x28
		public float targetAlpha; // 0x2C
		private float <startAlpha>5__2; // 0x30
		private float <t>5__3; // 0x34

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <FadeCanvasGroup>d__67(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x000000018119B490-0x000000018119B5D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x000000018119B5D0-0x000000018119B620
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass69_0 // TypeDefIndex: 13211
	{
		// Fields
		public string id; // 0x10
		public InstructionPair toRemove; // 0x18

		// Constructors
		public <>c__DisplayClass69_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <RemoveElement>b__0(InstructionPair i); // 0x000000018119D8A0-0x000000018119D8E0
		internal bool <RemoveElement>b__1(DMInstruction i); // 0x000000018119D8E0-0x000000018119D940
	}

	// Constructors
	public DebugMenu(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	public static void Button(string text = null, Action onClick = null, string id = null); // 0x0000000180F48930-0x0000000180F48A40
	public static void Text(string text = null, Func<string> getter = null, string id = null); // 0x0000000180F4B130-0x0000000180F4B240
	public static void Input(Func<string> getter = null, Action<string> setter = null, string id = null); // 0x0000000180F4A690-0x0000000180F4A7A0
	public static void Toggle(string text = null, Func<bool> getter = null, Action<bool> setter = null, string id = null); // 0x0000000180F4B240-0x0000000180F4B350
	public static void BeginSection(string title = null, string id = null); // 0x0000000180F48710-0x0000000180F48800
	public static void EndSection(); // 0x0000000180F49FE0-0x0000000180F4A0B0
	public static void BeginHorizontal(string id = null); // 0x0000000180F485E0-0x0000000180F48710
	public static void BeginVertical(string id = null); // 0x0000000180F48800-0x0000000180F48930
	public static void EndHorizontal(); // 0x0000000180F49EC0-0x0000000180F49FE0
	public static void EndVertical(); // 0x0000000180F4A0B0-0x0000000180F4A1D0
	public static void BeginCollapse(string title = null, bool startOpen = false /* Metadata: 0x00783965 */, string id = null); // 0x0000000180F484E0-0x0000000180F485E0
	public static void EndCollapse(); // 0x0000000180F49DF0-0x0000000180F49EC0
	public static void CreateTab(string tabName); // 0x0000000180F49DC0-0x0000000180F49DF0
	public static void NavigateToTab(int tabIndex); // 0x0000000180F4A7A0-0x0000000180F4A7D0
	public static void ChangeTab(int tabIndex); // 0x0000000180F48A40-0x0000000180F48AD0
	public static void Remove(string id); // 0x0000000180F4AA30-0x0000000180F4AA60
	private void Update(); // 0x0000000180F4B350-0x0000000180F4B790
	public void Poke(); // 0x00000001803581E0-0x00000001803581F0
	public void Init(); // 0x0000000180F4A460-0x0000000180F4A690
	private void CreateTabPanel(string panelName); // 0x0000000180F49AE0-0x0000000180F49DC0
	public void TabChange(int tab); // 0x0000000180F4B0B0-0x0000000180F4B130
	[IteratorStateMachine] // 0x000000018010BFA0-0x000000018010BFF0
	public IEnumerator FancyTabSwitch(int tab); // 0x0000000180F4A260-0x0000000180F4A2E0
	public void SwitchTab(int tab); // 0x0000000180F4AB80-0x0000000180F4B0B0
	public void Add(DMInstruction instruction); // 0x0000000180F482E0-0x0000000180F484E0
	public void AddButton(string text = null, Action onClick = null, string id = null); // 0x0000000180F47F10-0x0000000180F48000
	public void AddText(string text = null, Func<string> getter = null, string id = null); // 0x0000000180F480F0-0x0000000180F481E0
	public void AddInput(Func<string> getter = null, Action<string> setter = null, string id = null); // 0x0000000180F48000-0x0000000180F480F0
	public void AddToggle(string text = null, Func<bool> getter = null, Action<bool> setter = null, string id = null); // 0x0000000180F481E0-0x0000000180F482E0
	public void Section(bool start, string title = null, string id = null); // 0x0000000180F4AA60-0x0000000180F4AB80
	public void Collapse(bool start, string title = null, bool open = false /* Metadata: 0x00783966 */, string id = null); // 0x0000000180F48AD0-0x0000000180F48BF0
	public void Group(bool start, int direction, string id = null); // 0x0000000180F4A340-0x0000000180F4A460
	public void Construct(); // 0x0000000180F48BF0-0x0000000180F49AE0
	[IteratorStateMachine] // 0x000000018010C150-0x000000018010C1A0
	private IEnumerator FadeCanvasGroup(CanvasGroup group, float targetAlpha, float duration); // 0x0000000180F4A1D0-0x0000000180F4A260
	public string GetNewID(); // 0x0000000180F4A2E0-0x0000000180F4A340
	public void RemoveElement(string id); // 0x0000000180F4A7D0-0x0000000180F4AA30
}

