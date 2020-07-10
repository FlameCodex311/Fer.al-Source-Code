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

public class CodeBreakerScoreUI : MonoBehaviour // TypeDefIndex: 12903
{
	// Fields
	public CodeBreakerScoreLineUI scoreLinePrefab; // 0x20
	public Transform scoreLineContainer; // 0x28
	public ScoreLine totalScoreLine; // 0x30
	public RectTransform totalScoreContainer; // 0x38
	[Space] // 0x00000001800C6850-0x00000001800C6870
	public ScoreStar star1; // 0x40
	public ScoreStar star2; // 0x48
	public ScoreStar star3; // 0x50
	[Space] // 0x00000001800C6850-0x00000001800C6870
	public WWImage scoreFillbar; // 0x58
	public Color starColorFilled; // 0x60
	public Color starColorUnfilled; // 0x70
	public float scoreFillDuration; // 0x80
	private bool _showingScore; // 0x84
	private bool _showingScoreSkip; // 0x85
	private List<CodeBreakerScoreLineUI> _scoreItems; // 0x88

	// Nested types
	[Serializable]
	public class ScoreLine // TypeDefIndex: 12904
	{
		// Fields
		public WWTextMeshProUGUI scoreLabel; // 0x10
		public WWTextMeshProUGUI scoreText; // 0x18

		// Constructors
		public ScoreLine(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		public void Reset(); // 0x000000018127FBE0-0x000000018127FC70
		public void SetScore(int inScore); // 0x000000018127FC70-0x000000018127FD10
		public void PunchScoreText(); // 0x000000018127FAC0-0x000000018127FBE0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <DoScoreRevealRoutine>d__19 : IEnumerator<object> // TypeDefIndex: 12905
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public CodeBreakerScoreUI <>4__this; // 0x20
		public int inTimeScore; // 0x28
		public int inIngredientScore; // 0x2C
		public int inBonusFirstGuess; // 0x30
		public int inBonusLastIngredient; // 0x34
		public CodeBreakerLevel inLevelData; // 0x38
		private float <totalScore>5__2; // 0x40
		private float <scoringSpeed>5__3; // 0x44
		private float <score>5__4; // 0x48
		private float <prevFillAmount>5__5; // 0x4C
		private CodeBreakerScoreLineUI <ingredientScoreLine>5__6; // 0x50
		private float <ingredientScore>5__7; // 0x58

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <DoScoreRevealRoutine>d__19(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181280020-0x0000000181280CF0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181280CF0-0x0000000181280D40
	}

	// Constructors
	public CodeBreakerScoreUI(); // 0x0000000181274180-0x00000001812741A0

	// Methods
	private void Update(); // 0x0000000181274150-0x0000000181274180
	public void ShowScore(int timeScore, int ingredientScore, int inBonusFirstGuess, int inBonusLastIngredient, CodeBreakerLevel inLevelData); // 0x0000000181273E90-0x0000000181273FB0
	private void ResetScore(); // 0x0000000181273900-0x0000000181273C50
	private void ResetScoreFillbar(); // 0x0000000181273810-0x0000000181273900
	[IteratorStateMachine] // 0x0000000180143F30-0x0000000180143F80
	private IEnumerator DoScoreRevealRoutine(int inTimeScore, int inIngredientScore, int inBonusFirstGuess, int inBonusLastIngredient, CodeBreakerLevel inLevelData); // 0x0000000181273770-0x0000000181273810
	private void UpdateStars(float inFillAmount, float inLastFillAmount); // 0x0000000181274000-0x0000000181274150
	private bool CheckFillThreshold(ScoreStar inStar, float inFillAmount, float inLastFillAmount); // 0x0000000181271DE0-0x0000000181271E10
	private void ShowStarFilled(ScoreStar inStar); // 0x0000000181273FB0-0x0000000181274000
	private float SetFillAmount(float inScore, CodeBreakerLevel inLevel); // 0x0000000181273C50-0x0000000181273E90
}

