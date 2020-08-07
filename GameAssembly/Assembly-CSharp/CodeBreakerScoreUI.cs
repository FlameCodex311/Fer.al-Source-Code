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

public class CodeBreakerScoreUI : MonoBehaviour // TypeDefIndex: 10568
{
	// Fields
	public CodeBreakerScoreLineUI scoreLinePrefab; // 0x20
	public Transform scoreLineContainer; // 0x28
	public ScoreLine totalScoreLine; // 0x30
	public RectTransform totalScoreContainer; // 0x38
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public ScoreStar star1; // 0x40
	public ScoreStar star2; // 0x48
	public ScoreStar star3; // 0x50
	[Space] // 0x00000001801D3D10-0x00000001801D3D30
	public WWImage scoreFillbar; // 0x58
	public Color starColorFilled; // 0x60
	public Color starColorUnfilled; // 0x70
	public float scoreFillDuration; // 0x80
	private bool _showingScore; // 0x84
	private bool _showingScoreSkip; // 0x85
	private List<CodeBreakerScoreLineUI> _scoreItems; // 0x88

	// Nested types
	[Serializable]
	public class ScoreLine // TypeDefIndex: 10569
	{
		// Fields
		public WWTextMeshProUGUI scoreLabel; // 0x10
		public WWTextMeshProUGUI scoreText; // 0x18

		// Constructors
		public ScoreLine(); // 0x0000000180373240-0x0000000180373250

		// Methods
		public void Reset(); // 0x00000001805342F0-0x0000000180534380
		public void SetScore(int inScore); // 0x0000000180534380-0x00000001805345A0
		public void PunchScoreText(); // 0x00000001805341D0-0x00000001805342F0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <DoScoreRevealRoutine>d__19 : IEnumerator<object> // TypeDefIndex: 10570
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <DoScoreRevealRoutine>d__19(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001805345A0-0x0000000180535240
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x0000000180535240-0x0000000180535290
	}

	// Constructors
	public CodeBreakerScoreUI(); // 0x000000018052C920-0x000000018052C940

	// Methods
	private void Update(); // 0x000000018052C8F0-0x000000018052C920
	public void ShowScore(int timeScore, int ingredientScore, int inBonusFirstGuess, int inBonusLastIngredient, CodeBreakerLevel inLevelData); // 0x000000018052C640-0x000000018052C760
	private void ResetScore(); // 0x000000018052C0C0-0x000000018052C410
	private void ResetScoreFillbar(); // 0x000000018052BFD0-0x000000018052C0C0
	[IteratorStateMachine] // 0x00000001802235F0-0x0000000180223640
	private IEnumerator DoScoreRevealRoutine(int inTimeScore, int inIngredientScore, int inBonusFirstGuess, int inBonusLastIngredient, CodeBreakerLevel inLevelData); // 0x000000018052BF30-0x000000018052BFD0
	private void UpdateStars(float inFillAmount, float inLastFillAmount); // 0x000000018052C7B0-0x000000018052C8F0
	private bool CheckFillThreshold(ScoreStar inStar, float inFillAmount, float inLastFillAmount); // 0x000000018052A5E0-0x000000018052A610
	private void ShowStarFilled(ScoreStar inStar); // 0x000000018052C760-0x000000018052C7B0
	private float SetFillAmount(float inScore, CodeBreakerLevel inLevel); // 0x000000018052C410-0x000000018052C640
}

