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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class DebugMenu : MonoBehaviour // TypeDefIndex: 10869
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
	public static DebugMenu Instance { get; } // 0x000000018055EDA0-0x000000018055EF30 

	// Nested types
	private class TextPair // TypeDefIndex: 10870
	{
		// Fields
		public UnityEngine.UI.Text text; // 0x10
		public Func<string> getter; // 0x18

		// Constructors
		public TextPair(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public void UpdateText(); // 0x00000001805634F0-0x0000000180563560
	}

	private class InputPair // TypeDefIndex: 10871
	{
		// Fields
		public InputField input; // 0x10
		public Func<string> getter; // 0x18
		public Action<string> setter; // 0x20

		// Constructors
		public InputPair(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public void UpdateText(); // 0x0000000180562190-0x0000000180562200
		public void OnChange(string value); // 0x0000000180562140-0x0000000180562190
	}

	private class TogglePair // TypeDefIndex: 10872
	{
		// Fields
		public Toggle toggle; // 0x10
		public Func<bool> getter; // 0x18
		public Action<bool> setter; // 0x20

		// Constructors
		public TogglePair(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public void UpdateState(); // 0x00000001805635B0-0x0000000180563620
		public void OnChange(bool value); // 0x0000000180563560-0x00000001805635B0
	}

	private class CollapsePair // TypeDefIndex: 10873
	{
		// Fields
		public GameObject content; // 0x10
		public Toggle toggle; // 0x18

		// Constructors
		public CollapsePair(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public static CollapsePair Create(GameObject collapseGroup, string title = null, bool open = false /* Metadata: 0x0077C422 */); // 0x0000000180550300-0x00000001805504F0
		public void UpdateState(); // 0x00000001805504F0-0x0000000180550530
	}

	private class InstructionPair // TypeDefIndex: 10874
	{
		// Fields
		public DMInstruction instruction; // 0x10
		public List<DMInstruction> parentList; // 0x18

		// Constructors
		public InstructionPair(); // 0x0000000180373240-0x0000000180373250
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <FancyTabSwitch>d__56 : IEnumerator<object> // TypeDefIndex: 10875
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public DebugMenu <>4__this; // 0x20
		public int tab; // 0x28
		private CanvasGroup <group>5__2; // 0x30

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <FancyTabSwitch>d__56(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180564210-0x00000001805643A0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001805643A0-0x00000001805643F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <FadeCanvasGroup>d__67 : IEnumerator<object> // TypeDefIndex: 10876
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <FadeCanvasGroup>d__67(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180564080-0x00000001805641C0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001805641C0-0x0000000180564210
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass69_0 // TypeDefIndex: 10877
	{
		// Fields
		public string id; // 0x10
		public InstructionPair toRemove; // 0x18

		// Constructors
		public <>c__DisplayClass69_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <RemoveElement>b__0(InstructionPair i); // 0x00000001805687A0-0x00000001805687E0
		internal bool <RemoveElement>b__1(DMInstruction i); // 0x00000001805687E0-0x0000000180568840
	}

	// Constructors
	public DebugMenu(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public static void Button(string text = null, Action onClick = null, string id = null); // 0x000000018055BF00-0x000000018055C000
	public static void Text(string text = null, Func<string> getter = null, string id = null); // 0x000000018055E620-0x000000018055E720
	public static void Input(Func<string> getter = null, Action<string> setter = null, string id = null); // 0x000000018055DBC0-0x000000018055DCC0
	public static void Toggle(string text = null, Func<bool> getter = null, Action<bool> setter = null, string id = null); // 0x000000018055E720-0x000000018055E830
	public static void BeginSection(string title = null, string id = null); // 0x000000018055BCF0-0x000000018055BDD0
	public static void EndSection(); // 0x000000018055D530-0x000000018055D600
	public static void BeginHorizontal(string id = null); // 0x000000018055BBC0-0x000000018055BCF0
	public static void BeginVertical(string id = null); // 0x000000018055BDD0-0x000000018055BF00
	public static void EndHorizontal(); // 0x000000018055D410-0x000000018055D530
	public static void EndVertical(); // 0x000000018055D600-0x000000018055D720
	public static void BeginCollapse(string title = null, bool startOpen = false /* Metadata: 0x0077C420 */, string id = null); // 0x000000018055BAC0-0x000000018055BBC0
	public static void EndCollapse(); // 0x000000018055D340-0x000000018055D410
	public static void CreateTab(string tabName); // 0x000000018055D310-0x000000018055D340
	public static void NavigateToTab(int tabIndex); // 0x000000018055DCC0-0x000000018055DCF0
	public static void ChangeTab(int tabIndex); // 0x000000018055C000-0x000000018055C090
	public static void Remove(string id); // 0x000000018055DF40-0x000000018055DF70
	private void Update(); // 0x000000018055E830-0x000000018055EDA0
	public void Poke(); // 0x00000001803774A0-0x00000001803774B0
	public void Init(); // 0x000000018055D990-0x000000018055DBC0
	private void CreateTabPanel(string panelName); // 0x000000018055D040-0x000000018055D310
	public void TabChange(int tab); // 0x000000018055E5A0-0x000000018055E620
	[IteratorStateMachine] // 0x00000001801E0B10-0x00000001801E0B60
	public IEnumerator FancyTabSwitch(int tab); // 0x000000018055D7A0-0x000000018055D810
	public void SwitchTab(int tab); // 0x000000018055E090-0x000000018055E5A0
	public void Add(DMInstruction instruction); // 0x000000018055B8C0-0x000000018055BAC0
	public void AddButton(string text = null, Action onClick = null, string id = null); // 0x000000018055B4F0-0x000000018055B5E0
	public void AddText(string text = null, Func<string> getter = null, string id = null); // 0x000000018055B6D0-0x000000018055B7C0
	public void AddInput(Func<string> getter = null, Action<string> setter = null, string id = null); // 0x000000018055B5E0-0x000000018055B6D0
	public void AddToggle(string text = null, Func<bool> getter = null, Action<bool> setter = null, string id = null); // 0x000000018055B7C0-0x000000018055B8C0
	public void Section(bool start, string title = null, string id = null); // 0x000000018055DF70-0x000000018055E090
	public void Collapse(bool start, string title = null, bool open = false /* Metadata: 0x0077C421 */, string id = null); // 0x000000018055C090-0x000000018055C1B0
	public void Group(bool start, int direction, string id = null); // 0x000000018055D870-0x000000018055D990
	public void Construct(); // 0x000000018055C1B0-0x000000018055D040
	[IteratorStateMachine] // 0x00000001801E0EC0-0x00000001801E0F10
	private IEnumerator FadeCanvasGroup(CanvasGroup group, float targetAlpha, float duration); // 0x000000018055D720-0x000000018055D7A0
	public string GetNewID(); // 0x000000018055D810-0x000000018055D870
	public void RemoveElement(string id); // 0x000000018055DCF0-0x000000018055DF40
}

