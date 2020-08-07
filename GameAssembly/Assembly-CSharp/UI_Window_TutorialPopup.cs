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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_TutorialPopup : UI_Window // TypeDefIndex: 14226
{
	// Fields
	[Header] // 0x00000001801EA940-0x00000001801EA990
	[SerializeField] // 0x00000001801EA940-0x00000001801EA990
	private WWTextMeshProUGUI _headerText; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _footer; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TabGroup _tabGroup; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _nextBtnText; // 0x120
	[Header] // 0x00000001801EB000-0x00000001801EB050
	[SerializeField] // 0x00000001801EB000-0x00000001801EB050
	private CanvasGroup _pageGroup; // 0x128
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _pageImage; // 0x130
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _pageText; // 0x138
	private List<TutorialPageData> _pageDatas; // 0x140
	private TutorialPageData _currentPageData; // 0x148
	private QRoutine _setupRoutine; // 0x150
	private Sequence _pageTransitionSequence; // 0x158

	// Nested types
	private class TutorialPageData // TypeDefIndex: 14227
	{
		// Fields
		public string imageDefId; // 0x10
		private Sprite _sprite; // 0x18
		public string localizationDefId; // 0x20
		private string _localizedText; // 0x28

		// Properties
		public Sprite Sprite { get; } // 0x0000000180372430-0x0000000180372440 
		public string LocalizedText { get; } // 0x00000001803745B0-0x00000001803745C0 

		// Nested types
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private sealed class <Init>d__10 : IEnumerator<object> // TypeDefIndex: 14228
		{
			// Fields
			private int <>1__state; // 0x10
			private object <>2__current; // 0x18
			public TutorialPageData <>4__this; // 0x20
			public GameObject inReferenceGo; // 0x28

			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
			object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

			// Constructors
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			public <Init>d__10(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

			// Methods
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
			private bool MoveNext(); // 0x0000000180444140-0x0000000180444370
			[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
			void IEnumerator.Reset(); // 0x0000000180444370-0x00000001804443C0
		}

		// Constructors
		public TutorialPageData(TutorialPageInfo inPageInfo); // 0x0000000180443F50-0x0000000180443F90
		public TutorialPageData(string inImageDefId, string inLocalizationDefId); // 0x0000000180443F90-0x0000000180444140

		// Methods
		[IteratorStateMachine] // 0x00000001801EC1B0-0x00000001801EC200
		public IEnumerator Init(GameObject inReferenceGo); // 0x0000000180443EE0-0x0000000180443F50
		[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void <Init>b__10_0(Sprite sprite); // 0x0000000180379F30-0x0000000180379F40
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass0_0 // TypeDefIndex: 14229
	{
		// Fields
		public BaseDef inTutorialDef; // 0x10

		// Constructors
		public <>c__DisplayClass0_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OpenWindow>b__0(UI_Window_TutorialPopup window); // 0x0000000180446BA0-0x0000000180446BD0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass1_0 // TypeDefIndex: 14230
	{
		// Fields
		public BaseDef inTutorialDef; // 0x10

		// Constructors
		public <>c__DisplayClass1_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <QueueWindow>b__0(UI_Window inWindow); // 0x0000000180447B50-0x0000000180447C20
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <SetupPages>d__17 : IEnumerator<object> // TypeDefIndex: 14231
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public UI_Window_TutorialPopup <>4__this; // 0x20
		private List<TutorialPageData> <>7__wrap1; // 0x28

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <SetupPages>d__17(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001804453D0-0x0000000180445470
		private bool MoveNext(); // 0x0000000180445150-0x0000000180445380
		private void <>m__Finally1(); // 0x0000000180445470-0x0000000180445F70
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180445380-0x00000001804453D0
	}

	// Constructors
	public UI_Window_TutorialPopup(); // 0x0000000180451A70-0x0000000180451AE0

	// Methods
	public static void OpenWindow(BaseDef inTutorialDef); // 0x00000001804512B0-0x0000000180451370
	public static void QueueWindow(BaseDef inTutorialDef); // 0x0000000180451370-0x0000000180451430
	public static void CloseWindow(); // 0x0000000180450B70-0x0000000180450BC0
	public void BtnClicked_NextPage(); // 0x0000000180450AA0-0x0000000180450B70
	protected override void DoDelayedOpenAnimation(); // 0x0000000180450BC0-0x0000000180450C60
	private void Setup(BaseDef inTutorialDef); // 0x0000000180451490-0x0000000180451950
	[IteratorStateMachine] // 0x00000001801EB790-0x00000001801EB7E0
	private IEnumerator SetupPages(); // 0x0000000180451430-0x0000000180451490
	private void OnPageSelected(int inPageIndex); // 0x0000000180451060-0x00000001804512B0
	private void DoPageTransition(TutorialPageData inPageData); // 0x0000000180450C60-0x0000000180450DA0
	private void LoadPage(TutorialPageData inPageData); // 0x0000000180450DA0-0x0000000180450EA0
	protected override void OnOpen(); // 0x0000000180450F80-0x0000000180451060
	protected override void OnClose(bool inAnimate); // 0x0000000180450EA0-0x0000000180450F80
	public override void MOnDestroy(); // 0x00000001803B4550-0x00000001803B4560
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <DoDelayedOpenAnimation>b__15_0(); // 0x0000000180451950-0x0000000180451970
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <DoDelayedOpenAnimation>b__15_1(); // 0x00000001803B6890-0x00000001803B68B0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <DoPageTransition>b__19_0(); // 0x0000000180451970-0x0000000180451A70
}

