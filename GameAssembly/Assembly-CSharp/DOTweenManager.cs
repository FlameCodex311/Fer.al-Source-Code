/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class DOTweenManager : SingletonManagerBase<DOTweenManager> // TypeDefIndex: 12182
{
	// Fields
	[Range] // 0x0000000180248CE0-0x0000000180248D20
	[SerializeField] // 0x0000000180248CE0-0x0000000180248D20
	private int _tweenersCapacity; // 0x60
	[Range] // 0x0000000180248CE0-0x0000000180248D20
	[SerializeField] // 0x0000000180248CE0-0x0000000180248D20
	private int _sequencesCapacity; // 0x64

	// Properties
	public int TweenersCapacity { get; } // 0x00000001804ADA80-0x00000001804ADA90 
	public int SequencesCapacity { get; } // 0x00000001804C5F20-0x00000001804C5F30 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <RuntimeInitializeOnLoad>d__6 : IAsyncStateMachine // TypeDefIndex: 12183
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncVoidMethodBuilder <>t__builder; // 0x08
		private TaskAwaiter <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180006980-0x0000000180006A50
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002050-0x0000000180002060
	}

	// Constructors
	public DOTweenManager(); // 0x0000000180559230-0x0000000180559280

	// Methods
	[AsyncStateMachine] // 0x0000000180249170-0x00000001802491E0
	[RuntimeInitializeOnLoadMethod] // 0x0000000180249170-0x00000001802491E0
	private static void RuntimeInitializeOnLoad(); // 0x00000001805590B0-0x0000000180559140
	public void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity); // 0x0000000180559140-0x0000000180559230
}

