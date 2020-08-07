/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class FourCrowsDeckManager : MonoBehaviour // TypeDefIndex: 10694
{
	// Fields
	public int numCardsPerPlayer; // 0x20
	public float dealMoveTime; // 0x24
	[Tooltip] // 0x00000001802569D0-0x0000000180256A00
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
	internal FourCrowsCard SelectedCard { get; set; } // 0x00000001803D6D90-0x00000001803D6DA0 0x00000001804A0450-0x00000001804A0460

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <MoveCard>d__33 : IEnumerator<object> // TypeDefIndex: 10695
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <MoveCard>d__33(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A9270-0x00000001806A9580
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A9580-0x00000001806A95D0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <RotateCard>d__34 : IEnumerator<object> // TypeDefIndex: 10696
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
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <RotateCard>d__34(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A96B0-0x00000001806A98E0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A98E0-0x00000001806A9930
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <CollectDeck>d__40 : IEnumerator<object> // TypeDefIndex: 10697
	{
		// Fields
		private int <>1__state; // 0x10
		private object <>2__current; // 0x18
		public FourCrowsDeckManager <>4__this; // 0x20

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 
		object IEnumerator.Current { [DebuggerHidden] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; } // 0x0000000180372430-0x0000000180372440 

		// Constructors
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		public <CollectDeck>d__40(int <>1__state); // 0x00000001803C5B50-0x00000001803C5D60

		// Methods
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IDisposable.Dispose(); // 0x00000001803774A0-0x00000001803774B0
		private bool MoveNext(); // 0x00000001806A6940-0x00000001806A6AD0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		void IEnumerator.Reset(); // 0x00000001806A6AD0-0x00000001806A6B20
	}

	// Constructors
	public FourCrowsDeckManager(); // 0x00000001806A43F0-0x00000001806A4440

	// Methods
	private void Start(); // 0x00000001806A4070-0x00000001806A4210
	internal void DealCardsResponse(ParlorGameCommand parlorGameCommand); // 0x00000001806A2C60-0x00000001806A30B0
	internal void PickupCard(FourCrowsCard inCard); // 0x00000001806A3C10-0x00000001806A3E10
	[IteratorStateMachine] // 0x0000000180256BC0-0x0000000180256C10
	private IEnumerator MoveCard(Transform inTrans, Vector3 inEndPosition, bool inUseLocal); // 0x00000001806A3B70-0x00000001806A3C10
	[IteratorStateMachine] // 0x0000000180256DD0-0x0000000180256E20
	private IEnumerator RotateCard(Transform inTrans, Vector3 inEndRotation); // 0x00000001806A3FE0-0x00000001806A4070
	internal void DropCard(); // 0x00000001806A30B0-0x00000001806A36F0
	internal void Init(); // 0x00000001806A3A20-0x00000001806A3B70
	internal void CardMoved(); // 0x00000001806A25C0-0x00000001806A25F0
	private FourCrowsCard DealCard(bool inPlayerCard, int inDeckIndex, int inHandIndex, float inDelay); // 0x00000001806A2B70-0x00000001806A2C60
	internal void ReturnCard(FourCrowsCard inCard); // 0x00000001806A3F20-0x00000001806A3FE0
	[IteratorStateMachine] // 0x00000001802570E0-0x0000000180257130
	internal IEnumerator CollectDeck(); // 0x00000001806A2B10-0x00000001806A2B70
	private bool CloseToSpotPosition(Transform inTrans1, Transform inTrans2); // 0x00000001806A2A10-0x00000001806A2B10
	internal void PlayerMoveCard(Vector3 inPoint); // 0x00000001806A3E10-0x00000001806A3EA0
	private void ValidSpotChq(); // 0x00000001806A4210-0x00000001806A43F0
	private List<FourCrowsCard> InitSuit(int inNumCard, FourCrowsCard.ECardType inCardType); // 0x00000001806A36F0-0x00000001806A3A20
	internal void Cleanup(); // 0x00000001806A25F0-0x00000001806A2A10
	internal void ResetCardIndicators(); // 0x00000001806A3EA0-0x00000001806A3F20
}

