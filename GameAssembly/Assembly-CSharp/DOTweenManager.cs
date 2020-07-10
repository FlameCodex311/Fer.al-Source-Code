/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class DOTweenManager : SingletonManagerBase<DOTweenManager> // TypeDefIndex: 10679
{
	// Fields
	[Range] // 0x000000018016BE10-0x000000018016BE50
	[SerializeField] // 0x000000018016BE10-0x000000018016BE50
	private int _tweenersCapacity; // 0x60
	[Range] // 0x000000018016BE10-0x000000018016BE50
	[SerializeField] // 0x000000018016BE10-0x000000018016BE50
	private int _sequencesCapacity; // 0x64

	// Properties
	public int TweenersCapacity { get; } // 0x00000001804A3730-0x00000001804A3740 
	public int SequencesCapacity { get; } // 0x00000001804D0650-0x00000001804D0660 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <RuntimeInitializeOnLoad>d__6 : IAsyncStateMachine // TypeDefIndex: 10680
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private TaskAwaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F1570-0x00000001801F1580
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0530-0x00000001801F0540
	}

	// Constructors
	public DOTweenManager(); // 0x0000000180F46870-0x0000000180F468C0

	// Methods
	[AsyncStateMachine] // 0x000000018016C3A0-0x000000018016C410
	[RuntimeInitializeOnLoadMethod] // 0x000000018016C3A0-0x000000018016C410
	private static void RuntimeInitializeOnLoad(); // 0x0000000180F466F0-0x0000000180F46780
	public void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity); // 0x0000000180F46780-0x0000000180F46870
}

