/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using TMPro;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_SplashLogo : MonoBehaviour // TypeDefIndex: 13948
{
	// Fields
	public static string sponsorId; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _logoImage; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _sponsorImage; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWTextMeshProUGUI _descriptionText; // 0x30

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 13949
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__4_0; // 0x08

		// Constructors
		static <>c(); // 0x00000001804C33E0-0x00000001804C3440
		public <>c(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__4_0(); // 0x00000001804C2BF0-0x00000001804C2C40
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <Setup>d__6 : IAsyncStateMachine // TypeDefIndex: 13950
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncUniTaskMethodBuilder <>t__builder; // 0x08
		public UI_SplashLogo <>4__this; // 0x18
		public string inLongDescription; // 0x20
		public string inImageURL; // 0x28
		private bool <hasSponsorImage>5__2; // 0x30
		private bool <hasImage>5__3; // 0x31
		private Sprite <sprite>5__4; // 0x38
		private TaskAwaiter<Sprite> <>u__1; // 0x40

		// Methods
		private void MoveNext(); // 0x0000000180005A00-0x0000000180005A10
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180002020-0x0000000180002030
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <FetchIconAndSponsorId>d__7 : IAsyncStateMachine // TypeDefIndex: 13951
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<Sprite> <>t__builder; // 0x08
		public string inImageURL; // 0x20
		private TaskAwaiter<Sprite> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x0000000180005860-0x0000000180005870
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x0000000180005870-0x00000001800058C0
	}

	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private struct <FetchSponsorImage>d__8 : IAsyncStateMachine // TypeDefIndex: 13952
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<Sprite> <>t__builder; // 0x08
		public string inImageURL; // 0x20
		private TaskAwaiter<Sprite> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001800058C0-0x00000001800058D0
		[DebuggerHidden] // 0x00000001801CDAD0-0x00000001801CDAE0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001800058D0-0x0000000180005920
	}

	// Constructors
	public UI_SplashLogo(); // 0x00000001803743C0-0x00000001803743D0

	// Methods
	private void Start(); // 0x00000001804CC090-0x00000001804CC1A0
	public void Setup(string inLongDescription); // 0x00000001804CBF10-0x00000001804CBFC0
	[AsyncStateMachine] // 0x00000001802476C0-0x0000000180247710
	public UniTask Setup(string inImageURL, string inLongDescription); // 0x00000001804CBFC0-0x00000001804CC090
	[AsyncStateMachine] // 0x00000001802478A0-0x00000001802478F0
	public static Task<Sprite> FetchIconAndSponsorId(string inImageURL); // 0x00000001804CBD50-0x00000001804CBE30
	[AsyncStateMachine] // 0x0000000180247C00-0x0000000180247C50
	public static Task<Sprite> FetchSponsorImage(string inImageURL); // 0x00000001804CBE30-0x00000001804CBF10
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Start>b__4_1(); // 0x00000001804CC1A0-0x00000001804CC2C0
}

