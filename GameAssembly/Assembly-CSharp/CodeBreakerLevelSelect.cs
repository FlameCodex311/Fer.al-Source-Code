/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CodeBreakerLevelSelect : MonoBehaviour // TypeDefIndex: 12896
{
	// Fields
	public CodeBreakerLevels levelData; // 0x20
	public GameObject buttonHolder; // 0x28
	public ScrollRect levelScrollRect; // 0x30
	public GameObject levelInfoContainer; // 0x38
	public WWTextMeshProUGUI levelHeaderText; // 0x40
	public WWImage levelScoreFillbar; // 0x48
	public Color starColorFilled; // 0x50
	public Color starColorUnfilled; // 0x60
	public float scoreFillDuration; // 0x70
	public WWTextMeshProUGUI levelScoreText; // 0x78
	public ScoreStar star1; // 0x80
	public ScoreStar star2; // 0x88
	public ScoreStar star3; // 0x90
	public GameObject ruleDuplicateIngredients; // 0x98
	public GameObject ruleNoDuplicateIngredients; // 0xA0
	public WWTextMeshProUGUI ruleIngredientCountText; // 0xA8
	public CodeBreakerLevelButton levelButton; // 0xB0
	private List<CodeBreakerLevelButton> _buttons; // 0xB8
	private int _currentLevelIndex; // 0xC0

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass20_0 // TypeDefIndex: 12897
	{
		// Fields
		public int levelCount; // 0x10
		public CodeBreakerLevelSelect <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass20_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <OnEnable>b__0(); // 0x0000000181281C40-0x0000000181281E00
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DoScoreRevealRoutine>d__28 : IEnumerator<object> // TypeDefIndex: 12898
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public long inBestScore; // 0x20
		public CodeBreakerLevelSelect <>4__this; // 0x28
		public CodeBreakerLevel inLevel; // 0x30
		private float <scoringSpeed>5__2; // 0x38
		private float <score>5__3; // 0x3C
		private float <prevFillAmount>5__4; // 0x40

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DoScoreRevealRoutine>d__28(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181280D40-0x0000000181281000
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181281000-0x0000000181281050
	}

	// Constructors
	public CodeBreakerLevelSelect(); // 0x0000000181272E40-0x0000000181272E50

	// Methods
	private void Start(); // 0x0000000181272C60-0x0000000181272CF0
	private void OnEnable(); // 0x00000001812721E0-0x0000000181272410
	private void OnDisable(); // 0x0000000181272050-0x00000001812721E0
	private void OnDestroy(); // 0x0000000181271FC0-0x0000000181272050
	private void OnLevelSelected(CodeBreakerLevelSelectedMessage inMessage); // 0x0000000181272410-0x0000000181272570
	private void HideLevelInfo(); // 0x0000000181271E90-0x0000000181271FC0
	private void SetScoreText(int inScore); // 0x0000000181272880-0x0000000181272920
	private void SetLevelHeaderText(int inLevel); // 0x00000001812727C0-0x0000000181272880
	private void SetupLevelInfo(int inLevelIndex); // 0x0000000181272920-0x0000000181272C10
	[IteratorStateMachine] // 0x00000001801430C0-0x0000000180143110
	private IEnumerator DoScoreRevealRoutine(long inBestScore, CodeBreakerLevel inLevel); // 0x0000000181271E10-0x0000000181271E90
	public void BtnClicked_LevelStart(); // 0x0000000181271D50-0x0000000181271DE0
	private void UpdateStars(float inFillAmount, float inLastFillAmount); // 0x0000000181272CF0-0x0000000181272E40
	private bool CheckFillThreshold(ScoreStar inStar, float inFillAmount, float inLastFillAmount); // 0x0000000181271DE0-0x0000000181271E10
	private void ShowStarFilled(ScoreStar inStar); // 0x0000000181272C10-0x0000000181272C60
	private float SetFillAmount(float inScore, CodeBreakerLevel inLevel); // 0x0000000181272570-0x00000001812727C0
}

