/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_TutorialPopup : UI_Window // TypeDefIndex: 12624
{
	// Fields
	[Header] // 0x00000001800F7190-0x00000001800F71E0
	[SerializeField] // 0x00000001800F7190-0x00000001800F71E0
	private WWTextMeshProUGUI _headerText; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _footer; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TabGroup _tabGroup; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _nextBtnText; // 0x120
	[Header] // 0x00000001800F7900-0x00000001800F7950
	[SerializeField] // 0x00000001800F7900-0x00000001800F7950
	private CanvasGroup _pageGroup; // 0x128
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _pageImage; // 0x130
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _pageText; // 0x138
	private List<TutorialPageData> _pageDatas; // 0x140
	private TutorialPageData _currentPageData; // 0x148
	private QRoutine _setupRoutine; // 0x150
	private Sequence _pageTransitionSequence; // 0x158

	// Nested types
	private class TutorialPageData // TypeDefIndex: 12625
	{
		// Fields
		public string imageDefId; // 0x10
		private Sprite _sprite; // 0x18
		public string localizationDefId; // 0x20
		private string _localizedText; // 0x28

		// Properties
		public Sprite Sprite { get; } // 0x000000018038B150-0x000000018038B160 
		public string LocalizedText { get; } // 0x0000000180369B60-0x0000000180369B70 

		// Nested types
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private sealed class <Init>d__10 : IEnumerator<object> // TypeDefIndex: 12626
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TutorialPageData <>4__this; // 0x20
			public GameObject inReferenceGo; // 0x28

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

			// Constructors
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			public <Init>d__10(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

			// Methods
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
			private bool MoveNext(); // 0x0000000180F781F0-0x0000000180F78420
			[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
			void IEnumerator.Reset(); // 0x0000000180F78420-0x0000000180F78470
		}

		// Constructors
		public TutorialPageData(TutorialPageInfo inPageInfo); // 0x0000000180F77FF0-0x0000000180F78030
		public TutorialPageData(string inImageDefId, string inLocalizationDefId); // 0x0000000180F78030-0x0000000180F781F0

		// Methods
		[IteratorStateMachine] // 0x00000001800F8320-0x00000001800F8370
		public IEnumerator Init(GameObject inReferenceGo); // 0x0000000180F77F80-0x0000000180F77FF0
		[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
		private void <Init>b__10_0(Sprite sprite); // 0x000000018038B160-0x000000018038B170
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 12627
	{
		// Fields
		public BaseDef inTutorialDef; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OpenWindow>b__0(UI_Window_TutorialPopup window); // 0x0000000180F7A300-0x0000000180F7A330
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 12628
	{
		// Fields
		public BaseDef inTutorialDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180F7AE70-0x0000000180F7AF40
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <SetupPages>d__17 : IEnumerator<object> // TypeDefIndex: 12629
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_Window_TutorialPopup <>4__this; // 0x20
		private List<TutorialPageData> <>7__wrap1; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <SetupPages>d__17(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x0000000180F78D40-0x0000000180F78DF0
		private bool MoveNext(); // 0x0000000180F78AB0-0x0000000180F78CF0
		private void <>m__Finally1(); // 0x0000000180F78DF0-0x0000000180F796C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000180F78CF0-0x0000000180F78D40
	}

	// Constructors
	public UI_Window_TutorialPopup(); // 0x0000000180F85C30-0x0000000180F85CA0

	// Methods
	public static void OpenWindow(BaseDef inTutorialDef); // 0x0000000180F85440-0x0000000180F85500
	public static void QueueWindow(BaseDef inTutorialDef); // 0x0000000180F85500-0x0000000180F855C0
	public static void CloseWindow(); // 0x0000000180F84CF0-0x0000000180F84D40
	public void BtnClicked_NextPage(); // 0x0000000180F84C10-0x0000000180F84CF0
	protected override void DoDelayedOpenAnimation(); // 0x0000000180F84D40-0x0000000180F84DE0
	private void Setup(BaseDef inTutorialDef); // 0x0000000180F85620-0x0000000180F85B00
	[IteratorStateMachine] // 0x00000001800F7EA0-0x00000001800F7EF0
	private IEnumerator SetupPages(); // 0x0000000180F855C0-0x0000000180F85620
	private void OnPageSelected(int inPageIndex); // 0x0000000180F851F0-0x0000000180F85440
	private void DoPageTransition(TutorialPageData inPageData); // 0x0000000180F84DE0-0x0000000180F84F20
	private void LoadPage(TutorialPageData inPageData); // 0x0000000180F84F20-0x0000000180F85020
	protected override void OnOpen(); // 0x0000000180F85110-0x0000000180F851F0
	protected override void OnClose(bool inAnimate); // 0x0000000180F85020-0x0000000180F85110
	public override void MOnDestroy(); // 0x0000000180E9F680-0x0000000180E9F690
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private bool <DoDelayedOpenAnimation>b__15_0(); // 0x0000000180F85B00-0x0000000180F85B20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <DoDelayedOpenAnimation>b__15_1(); // 0x00000001809E8060-0x00000001809E8080
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <DoPageTransition>b__19_0(); // 0x0000000180F85B20-0x0000000180F85C30
}

