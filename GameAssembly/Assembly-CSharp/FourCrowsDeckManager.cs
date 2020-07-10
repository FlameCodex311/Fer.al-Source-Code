/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class FourCrowsDeckManager : MonoBehaviour // TypeDefIndex: 13029
{
	// Fields
	public int numCardsPerPlayer; // 0x20
	public float dealMoveTime; // 0x24
	[Tooltip] // 0x00000001800BF160-0x00000001800BF190
	public float dealDelay; // 0x28
	public float dealerPlayTime; // 0x2C
	public float dealerFlipTime; // 0x30
	public float cardCompareTime; // 0x34
	public FourCrowsCard cardPrefab; // 0x38
	public Transform dealPosition; // 0x40
	public Transform[] playerHandPositions; // 0x48
	public Transform[] dealerHandPositions; // 0x50
	public Transform[] playerPlayPositions; // 0x58
	public Transform[] dealerPlayPositions; // 0x60
	public float validSpotDistance; // 0x68
	public float cardDropTime; // 0x6C
	public float rotateTime; // 0x70
	public float dealerFlipRiseHeight; // 0x74
	internal int numCardsPositive2; // 0x78
	internal int numCardsPositive1; // 0x7C
	internal int numCardsNegative1; // 0x80
	internal int numCardsNegative2; // 0x84
	internal int numCardsSkip; // 0x88
	internal Renderer[] playerPlayIndictors; // 0x90
	internal FourCrowsCard[] allDeckCards; // 0x98
	private FourCrowsCard _selectedCard; // 0xA0
	private int _numCardsInMotion; // 0xA8
	private Vector3 _cardMover; // 0xAC
	private FourCrowsGame _game; // 0xB8

	// Properties
	internal FourCrowsCard SelectedCard { get; set; } // 0x0000000180382AA0-0x0000000180382AB0 0x00000001803D8EE0-0x00000001803D8EF0

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <MoveCard>d__33 : IEnumerator<object> // TypeDefIndex: 13030
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public bool inUseLocal; // 0x20
		public Transform inTrans; // 0x28
		public FourCrowsDeckManager <>4__this; // 0x30
		public Vector3 inEndPosition; // 0x38
		private Vector3 <startPos>5__2; // 0x44
		private float <t>5__3; // 0x50

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <MoveCard>d__33(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x00000001811144F0-0x0000000181114810
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181114810-0x0000000181114860
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <RotateCard>d__34 : IEnumerator<object> // TypeDefIndex: 13031
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public Transform inTrans; // 0x20
		public Vector3 inEndRotation; // 0x28
		public FourCrowsDeckManager <>4__this; // 0x38
		private Quaternion <startQ>5__2; // 0x40
		private Quaternion <endQ>5__3; // 0x50
		private float <t>5__4; // 0x60

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <RotateCard>d__34(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181114DF0-0x0000000181115020
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181115020-0x0000000181115070
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <CollectDeck>d__40 : IEnumerator<object> // TypeDefIndex: 13032
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsDeckManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; } // 0x000000018038B150-0x000000018038B160 

		// Constructors
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		public <CollectDeck>d__40(int <>1__state); // 0x00000001805C1F20-0x00000001805C1F50

		// Methods
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IDisposable.Dispose(); // 0x00000001803581E0-0x00000001803581F0
		private bool MoveNext(); // 0x0000000181110FF0-0x0000000181111190
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		void IEnumerator.Reset(); // 0x0000000181111190-0x00000001811111E0
	}

	// Constructors
	public FourCrowsDeckManager(); // 0x000000018110E710-0x000000018110E760

	// Methods
	private void Start(); // 0x000000018110E360-0x000000018110E520
	internal void DealCardsResponse(ParlorGameCommand parlorGameCommand); // 0x000000018110CEC0-0x000000018110D340
	internal void PickupCard(FourCrowsCard inCard); // 0x000000018110DEF0-0x000000018110E0F0
	[IteratorStateMachine] // 0x00000001800BF370-0x00000001800BF3C0
	private IEnumerator MoveCard(Transform inTrans, Vector3 inEndPosition, bool inUseLocal); // 0x000000018110DE50-0x000000018110DEF0
	[IteratorStateMachine] // 0x00000001800BF6D0-0x00000001800BF720
	private IEnumerator RotateCard(Transform inTrans, Vector3 inEndRotation); // 0x000000018110E2D0-0x000000018110E360
	internal void DropCard(); // 0x000000018110D340-0x000000018110D9A0
	internal void Init(); // 0x000000018110DD00-0x000000018110DE50
	internal void CardMoved(); // 0x000000018110C650-0x000000018110C800
	private FourCrowsCard DealCard(bool inPlayerCard, int inDeckIndex, int inHandIndex, float inDelay); // 0x000000018110CDC0-0x000000018110CEC0
	internal void ReturnCard(FourCrowsCard inCard); // 0x000000018110E210-0x000000018110E2D0
	[IteratorStateMachine] // 0x00000001800BF8E0-0x00000001800BF930
	internal IEnumerator CollectDeck(); // 0x000000018110CD60-0x000000018110CDC0
	private bool CloseToSpotPosition(Transform inTrans1, Transform inTrans2); // 0x000000018110CC60-0x000000018110CD60
	internal void PlayerMoveCard(Vector3 inPoint); // 0x000000018110E0F0-0x000000018110E180
	private void ValidSpotChq(); // 0x000000018110E520-0x000000018110E710
	private List<FourCrowsCard> InitSuit(int inNumCard, FourCrowsCard.ECardType inCardType); // 0x000000018110D9A0-0x000000018110DD00
	internal void Cleanup(); // 0x000000018110C800-0x000000018110CC60
	internal void ResetCardIndicators(); // 0x000000018110E180-0x000000018110E210
}

