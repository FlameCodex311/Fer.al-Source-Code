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

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CodeBreakerLevelSelect : MonoBehaviour // TypeDefIndex: 10558
{
	// Fields
	public GameObject buttonHolder; // 0x20
	public ScrollRect levelScrollRect; // 0x28
	public GameObject levelInfoContainer; // 0x30
	public WWTextMeshProUGUI levelHeaderText; // 0x38
	public WWImage levelScoreFillbar; // 0x40
	public Color starColorFilled; // 0x48
	public Color starColorUnfilled; // 0x58
	public float scoreFillDuration; // 0x68
	public WWTextMeshProUGUI levelScoreText; // 0x70
	public ScoreStar star1; // 0x78
	public ScoreStar star2; // 0x80
	public ScoreStar star3; // 0x88
	public GameObject ruleDuplicateIngredients; // 0x90
	public GameObject ruleNoDuplicateIngredients; // 0x98
	public WWTextMeshProUGUI ruleIngredientCountText; // 0xA0
	public CodeBreakerLevelButton levelButton; // 0xA8
	private List<CodeBreakerLevelButton> _buttons; // 0xB0
	private int _currentLevelIndex; // 0xB8

	// Properties
	private CodeBreakerDefComponent LevelData { get; } // 0x000000018052B6C0-0x000000018052B720 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass21_0 // TypeDefIndex: 10559
	{
		// Fields
		public int levelCount; // 0x10
		public CodeBreakerLevelSelect <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass21_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <OnEnable>b__0(); // 0x0000000180538420-0x00000001805385E0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DoScoreRevealRoutine>d__29 : IEnumerator<object> // TypeDefIndex: 10560
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DoScoreRevealRoutine>d__29(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x0000000180535290-0x0000000180535550
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180535550-0x0000000180538170
	}

	// Constructors
	public CodeBreakerLevelSelect(); // 0x000000018052B6B0-0x000000018052B6C0

	// Methods
	private void Start(); // 0x000000018052B4D0-0x000000018052B560
	private void OnEnable(); // 0x000000018052A9D0-0x000000018052AC40
	private void OnDisable(); // 0x000000018052A840-0x000000018052A9D0
	private void OnDestroy(); // 0x000000018052A7B0-0x000000018052A840
	private void OnLevelSelected(CodeBreakerLevelSelectedMessage inMessage); // 0x000000018052AC40-0x000000018052ADA0
	private void HideLevelInfo(); // 0x000000018052A690-0x000000018052A7B0
	private void SetScoreText(int inScore); // 0x000000018052B0A0-0x000000018052B140
	private void SetLevelHeaderText(int inLevel); // 0x000000018052AFE0-0x000000018052B0A0
	private void SetupLevelInfo(int inLevelIndex); // 0x000000018052B140-0x000000018052B480
	[IteratorStateMachine] // 0x00000001802207D0-0x0000000180220820
	private IEnumerator DoScoreRevealRoutine(long inBestScore, CodeBreakerLevel inLevel); // 0x000000018052A610-0x000000018052A690
	public void BtnClicked_LevelStart(); // 0x000000018052A550-0x000000018052A5E0
	private void UpdateStars(float inFillAmount, float inLastFillAmount); // 0x000000018052B560-0x000000018052B6B0
	private bool CheckFillThreshold(ScoreStar inStar, float inFillAmount, float inLastFillAmount); // 0x000000018052A5E0-0x000000018052A610
	private void ShowStarFilled(ScoreStar inStar); // 0x000000018052B480-0x000000018052B4D0
	private float SetFillAmount(float inScore, CodeBreakerLevel inLevel); // 0x000000018052ADA0-0x000000018052AFE0
}

