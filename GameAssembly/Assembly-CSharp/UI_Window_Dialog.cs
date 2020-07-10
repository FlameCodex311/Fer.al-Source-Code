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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_Window_Dialog : UI_Window // TypeDefIndex: 12444
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWSmoothContentSizeFitter _smoothContentSizeFitter; // 0x108
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _tweenTime; // 0x110
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioInfo _showDialogueSound; // 0x118
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_TextAnimator _textAnimator; // 0x120
	private AudioSource _localSource; // 0x128
	public CanvasGroup nextButton; // 0x130
	public GameObject nextScrim; // 0x138
	public WWImage imageNfcIcon; // 0x140
	private string _npcImageDefId; // 0x148
	public WWTextMeshProUGUI dialogText; // 0x150
	public WWTextMeshProUGUI dialogTextForCalculation; // 0x158
	public WWTextMeshProUGUI npcNameText; // 0x160
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _dialogGroup; // 0x168
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _choiceGroup; // 0x170
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
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
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private float _visibleCharacters; // 0x1B0
	private int _flip; // 0x1B4
	private string _lastParse; // 0x1B8

	// Properties
	private AudioSource localSource { get; } // 0x0000000180F10640-0x0000000180F10720 
	public float VisibleCharacters { get; private set; } // 0x0000000180F0FB80-0x0000000180F0FB90 0x0000000180F0FB90-0x0000000180F0FBA0
	public static bool IsInstantiatedAndOpen { get; } // 0x0000000180F105A0-0x0000000180F10640 

	// Nested types
	[Serializable]
	public class DialogOption // TypeDefIndex: 12445
	{
		// Fields
		public CanvasGroup group; // 0x10
		public WWTextMeshProUGUI text; // 0x18
		public LayoutElement layoutElement; // 0x20

		// Constructors
		public DialogOption(); // 0x000000018036B6C0-0x000000018036B6D0
	}

	[Serializable]
	public class SubtitleDelays // TypeDefIndex: 12446
	{
		// Fields
		public float characterDelay; // 0x10
		public float sentenceDelay; // 0x14
		public float commaDelay; // 0x18
		public float finalDelay; // 0x1C

		// Constructors
		public SubtitleDelays(); // 0x0000000180EFB550-0x0000000180EFB570
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass49_0 // TypeDefIndex: 12447
	{
		// Fields
		public int index; // 0x10
		public UI_Window_Dialog <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass49_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <ShowOptions>b__1(); // 0x0000000180EFFA80-0x0000000180EFFB00
	}

	// Constructors
	public UI_Window_Dialog(); // 0x0000000180F10500-0x0000000180F105A0

	// Methods
	public static void CloseWindow(); // 0x0000000180F0D950-0x0000000180F0D9A0
	protected override void OnOpen(); // 0x0000000180F0E550-0x0000000180F0E690
	protected override void OnOpenComplete(); // 0x0000000180F0E520-0x0000000180F0E550
	protected override void OnClose(bool inAnimate); // 0x0000000180F0E040-0x0000000180F0E110
	public void Setup(string inNPCLocalizedNameDefId, string inNPCImageDefId, Transform inActorDialoging, bool inIsShopMode = false /* Metadata: 0x00782EDD */); // 0x0000000180F0EA80-0x0000000180F0EBE0
	private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo inInfo); // 0x0000000180F0E110-0x0000000180F0E520
	private void SetDialogText(string inString); // 0x0000000180F0E7B0-0x0000000180F0E890
	private Sequence ShowDialogue(); // 0x0000000180F0EBE0-0x0000000180F0F7F0
	private Sequence FadeInText(string inText); // 0x0000000180F0D9A0-0x0000000180F0DD80
	private Sequence ShowOptions(); // 0x0000000180F0F7F0-0x0000000180F0FA20
	public void BtnClicked_NextDialog(); // 0x0000000180F0D6B0-0x0000000180F0D950
	public void BtnClicked_DialogOption(int inIdx); // 0x0000000180F0D640-0x0000000180F0D6B0
	public void NextButtonActive(bool inActive); // 0x0000000180F0DDA0-0x0000000180F0E040
	private void SkipTextFade(); // 0x0000000180F0FA20-0x0000000180F0FB70
	private void SetImage(string inNpcImageDefID); // 0x0000000180F0E890-0x0000000180F0EA80
	private void Update(); // 0x0000000180F104D0-0x0000000180F10500
	[DeMethodButton] // 0x0000000180170590-0x00000001801705F0
	private void Flip(); // 0x0000000180F0DD80-0x0000000180F0DDA0
	private void RefreshFlip(); // 0x0000000180F0E690-0x0000000180F0E7B0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <OnMultipleChoiceRequest>b__44_0(); // 0x0000000180F0FC60-0x0000000180F0FC70
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ShowDialogue>b__47_0(); // 0x0000000180F0FDA0-0x0000000180F0FDD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ShowDialogue>b__47_1(); // 0x0000000180F0FDD0-0x0000000180F0FFD0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ShowDialogue>b__47_2(); // 0x0000000180F0FFD0-0x0000000180F10010
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ShowDialogue>b__47_3(); // 0x0000000180F10010-0x0000000180F10050
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ShowDialogue>b__47_4(); // 0x0000000180F10050-0x0000000180F10440
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <ShowDialogue>b__47_5(); // 0x0000000180F10440-0x0000000180F10470
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ShowDialogue>b__47_6(float strength); // 0x0000000180F10470-0x0000000180F104A0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ShowDialogue>b__47_7(); // 0x0000000180F104A0-0x0000000180F104C0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <FadeInText>b__48_0(); // 0x0000000180F0FB70-0x0000000180F0FB80
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private float <FadeInText>b__48_1(); // 0x0000000180F0FB80-0x0000000180F0FB90
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <FadeInText>b__48_2(float x); // 0x0000000180F0FB90-0x0000000180F0FBA0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <FadeInText>b__48_3(); // 0x0000000180F0FBA0-0x0000000180F0FBE0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ShowOptions>b__49_0(); // 0x0000000180F104C0-0x0000000180F104D0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <NextButtonActive>b__52_0(); // 0x0000000180F0FBE0-0x0000000180F0FC20
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <NextButtonActive>b__52_1(); // 0x0000000180F0FC20-0x0000000180F0FC60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <NextButtonActive>b__52_2(); // 0x0000000180F0FC20-0x0000000180F0FC60
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetImage>b__54_0(Sprite inSprite); // 0x0000000180F0FC70-0x0000000180F0FDA0
}

