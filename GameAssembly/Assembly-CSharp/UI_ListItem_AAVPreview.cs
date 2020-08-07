/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_ListItem_AAVPreview : MonoBehaviour // TypeDefIndex: 13462
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private RawImage _rawImage; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private LayoutElement _layoutElement; // 0x28
	private ActorInfo _actorInfo; // 0x30
	private Item _attachedClothingItem; // 0x38
	private Vector3? _baseOffset; // 0x40

	// Properties
	private ActorBase Actor { get; } // 0x00000001803C9320-0x00000001803C9390 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass13_0 // TypeDefIndex: 13463
	{
		// Fields
		public ActorClothingDefComponent inClothingToRemove; // 0x10

		// Constructors
		public <>c__DisplayClass13_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <RemoveClothing>b__0(ActorInfoClothingItem item); // 0x00000001803C6500-0x00000001803C6530
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetIsAnimating>d__14 : IAsyncStateMachine // TypeDefIndex: 13464
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ListItem_AAVPreview <>4__this; // 0x28
		public bool inIsAnimating; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180002530-0x0000000180002540
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <SetAction>d__15 : IAsyncStateMachine // TypeDefIndex: 13465
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		public UI_ListItem_AAVPreview <>4__this; // 0x28
		public ActorActionType inAction; // 0x30
		private UniTask.Awaiter <>u__1; // 0x38

		// Methods
		private void MoveNext(); // 0x0000000180002520-0x0000000180002530
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public UI_ListItem_AAVPreview(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	public void Setup(ActorInfo inInfo); // 0x00000001803C8DA0-0x00000001803C8EB0
	public void UpdateRotation(Vector2 inRotateAmount); // 0x00000001803C9200-0x00000001803C9320
	public void UpdateOffset(Vector3 inOffsetAmount); // 0x00000001803C9030-0x00000001803C9200
	public void SetSize(float inSize); // 0x00000001803C8D40-0x00000001803C8DA0
	public void SetClothing(ActorClothingDefComponent inClothingDef); // 0x00000001803C8C20-0x00000001803C8C80
	public void RemoveClothing(); // 0x00000001803C8990-0x00000001803C8A60
	public void RemoveClothing(ActorClothingDefComponent inClothingToRemove); // 0x00000001803C8A60-0x00000001803C8B60
	[AsyncStateMachine] // 0x0000000180241060-0x00000001802410B0
	public void SetIsAnimating(bool inIsAnimating); // 0x00000001803C8C80-0x00000001803C8D40
	[AsyncStateMachine] // 0x0000000180241350-0x00000001802413A0
	public void SetAction(ActorActionType inAction); // 0x00000001803C8B60-0x00000001803C8C20
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <SetIsAnimating>b__14_0(); // 0x00000001803C8F70-0x00000001803C9030
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private bool <SetAction>b__15_0(); // 0x00000001803C8EB0-0x00000001803C8F70
}

