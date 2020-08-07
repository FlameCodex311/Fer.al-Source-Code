/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.DeInspektor.Attributes;
using DG.Tweening;
using NodeCanvas.DialogueTrees;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using WW.TextAnimation;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_Window_Dialog : UI_Window // TypeDefIndex: 14043
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWSmoothContentSizeFitter _smoothContentSizeFitter; // 0x108
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _tweenTime; // 0x110
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioInfo _showDialogueSound; // 0x118
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_TextAnimator _textAnimator; // 0x120
	private AudioSource _localSource; // 0x128
	public CanvasGroup nextButton; // 0x130
	public GameObject nextScrim; // 0x138
	public WWImage imageNfcIcon; // 0x140
	private string _npcImageDefId; // 0x148
	public WWTextMeshProUGUI dialogText; // 0x150
	public WWTextMeshProUGUI dialogTextForCalculation; // 0x158
	public WWTextMeshProUGUI npcNameText; // 0x160
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _dialogGroup; // 0x168
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _choiceGroup; // 0x170
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private CanvasGroup _nameBarGroup; // 0x178
	public DialogOption[] dialogOptions; // 0x180
	private SubtitleDelays _subtitleDelays; // 0x188
	private MultipleChoiceRequestInfo _choiceRequestInfo; // 0x190
	private bool _isRemovingOldDialogue; // 0x198
	private bool _textIsAnimating; // 0x199
	private bool _windowIsFresh; // 0x19A
	private bool _hasDialogue; // 0x19B
	private bool _hasChoices; // 0x19C
	private bool _isThought; // 0x19D
	private bool _isNarration; // 0x19E
	private bool _allowNextScrim; // 0x19F
	private bool _allowNextButton; // 0x1A0
	private Transform _actorDialoging; // 0x1A8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float _visibleCharacters; // 0x1B0
	private int _flip; // 0x1B4
	private string _lastParse; // 0x1B8

	// Properties
	private AudioSource localSource { get; } // 0x000000018048E710-0x000000018048E7F0 
	public float VisibleCharacters { get; private set; } // 0x000000018048DC40-0x000000018048DC50 0x000000018048DC50-0x000000018048DC60
	public static bool IsInstantiatedAndOpen { get; } // 0x000000018048E670-0x000000018048E710 

	// Nested types
	[Serializable]
	public class DialogOption // TypeDefIndex: 14044
	{
		// Fields
		public CanvasGroup group; // 0x10
		public WWTextMeshProUGUI text; // 0x18
		public LayoutElement layoutElement; // 0x20

		// Constructors
		public DialogOption(); // 0x0000000180373240-0x0000000180373250
	}

	[Serializable]
	public class SubtitleDelays // TypeDefIndex: 14045
	{
		// Fields
		public float characterDelay; // 0x10
		public float sentenceDelay; // 0x14
		public float commaDelay; // 0x18
		public float finalDelay; // 0x1C

		// Constructors
		public SubtitleDelays(); // 0x000000018047B490-0x000000018047B4B0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass49_0 // TypeDefIndex: 14046
	{
		// Fields
		public int index; // 0x10
		public UI_Window_Dialog <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass49_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <ShowOptions>b__1(); // 0x000000018047F220-0x000000018047F290
	}

	// Constructors
	public UI_Window_Dialog(); // 0x000000018048E5D0-0x000000018048E670

	// Methods
	public static void CloseWindow(); // 0x000000018048BAA0-0x000000018048BAF0
	protected override void OnOpen(); // 0x000000018048C680-0x000000018048C7B0
	protected override void OnOpenComplete(); // 0x000000018048C650-0x000000018048C680
	protected override void OnClose(bool inAnimate); // 0x000000018048C180-0x000000018048C250
	public void Setup(string inNPCLocalizedNameDefId, string inNPCImageDefId, Transform inActorDialoging, bool inIsShopMode = false /* Metadata: 0x007BA5F5 */); // 0x000000018048CB90-0x000000018048CCF0
	private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo inInfo); // 0x000000018048C250-0x000000018048C650
	private void SetDialogText(string inString); // 0x000000018048C8C0-0x000000018048C9A0
	private Sequence ShowDialogue(); // 0x000000018048CCF0-0x000000018048D8B0
	private Sequence FadeInText(string inText); // 0x000000018048BAF0-0x000000018048BEC0
	private Sequence ShowOptions(); // 0x000000018048D8B0-0x000000018048DAE0
	public void BtnClicked_NextDialog(); // 0x000000018048B810-0x000000018048BAA0
	public void BtnClicked_DialogOption(int inIdx); // 0x000000018048B7A0-0x000000018048B810
	public void NextButtonActive(bool inActive); // 0x000000018048BEE0-0x000000018048C180
	private void SkipTextFade(); // 0x000000018048DAE0-0x000000018048DC30
	private void SetImage(string inNpcImageDefID); // 0x000000018048C9A0-0x000000018048CB90
	private void Update(); // 0x000000018048E5A0-0x000000018048E5D0
	[DeMethodButton] // 0x0000000180267E80-0x0000000180267EE0
	private void Flip(); // 0x000000018048BEC0-0x000000018048BEE0
	private void RefreshFlip(); // 0x000000018048C7B0-0x000000018048C8C0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <OnMultipleChoiceRequest>b__44_0(); // 0x000000018048DD20-0x000000018048DD30
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ShowDialogue>b__47_0(); // 0x000000018048DEA0-0x000000018048DED0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ShowDialogue>b__47_1(); // 0x000000018048DED0-0x000000018048E0D0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ShowDialogue>b__47_2(); // 0x000000018048E0D0-0x000000018048E110
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ShowDialogue>b__47_3(); // 0x000000018048E110-0x000000018048E150
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ShowDialogue>b__47_4(); // 0x000000018048E150-0x000000018048E520
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <ShowDialogue>b__47_5(); // 0x000000018048E520-0x000000018048E540
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ShowDialogue>b__47_6(float strength); // 0x000000018048E540-0x000000018048E570
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ShowDialogue>b__47_7(); // 0x000000018048E570-0x000000018048E590
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <FadeInText>b__48_0(); // 0x000000018048DC30-0x000000018048DC40
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private float <FadeInText>b__48_1(); // 0x000000018048DC40-0x000000018048DC50
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <FadeInText>b__48_2(float x); // 0x000000018048DC50-0x000000018048DC60
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <FadeInText>b__48_3(); // 0x000000018048DC60-0x000000018048DCA0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ShowOptions>b__49_0(); // 0x000000018048E590-0x000000018048E5A0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <NextButtonActive>b__52_0(); // 0x000000018048DCA0-0x000000018048DCE0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <NextButtonActive>b__52_1(); // 0x000000018048DCE0-0x000000018048DD20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <NextButtonActive>b__52_2(); // 0x000000018048DCE0-0x000000018048DD20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetImage>b__54_0(Sprite inSprite); // 0x000000018048DD30-0x000000018048DEA0
}

