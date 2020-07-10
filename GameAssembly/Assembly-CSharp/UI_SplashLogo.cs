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

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_SplashLogo : MonoBehaviour // TypeDefIndex: 12363
{
	// Fields
	public static string sponsorId; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _logoImage; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _sponsorImage; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWTextMeshProUGUI _descriptionText; // 0x30

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 12364
	{
		// Fields
		public static readonly <>c <>9; // 0x00
		public static Func<bool> <>9__4_0; // 0x08

		// Constructors
		static <>c(); // 0x0000000180EE1C30-0x0000000180EE1C90
		public <>c(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__4_0(); // 0x0000000180EE1850-0x0000000180EE18A0
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <Setup>d__6 : IAsyncStateMachine // TypeDefIndex: 12365
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
		private void MoveNext(); // 0x00000001801F11C0-0x00000001801F11D0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F0500-0x00000001801F0510
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <FetchIconAndSponsorId>d__7 : IAsyncStateMachine // TypeDefIndex: 12366
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<Sprite> <>t__builder; // 0x08
		public string inImageURL; // 0x20
		private TaskAwaiter<Sprite> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F10B0-0x00000001801F10C0
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F10C0-0x00000001801F1110
	}

	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private struct <FetchSponsorImage>d__8 : IAsyncStateMachine // TypeDefIndex: 12367
	{
		// Fields
		public int <>1__state; // 0x00
		public AsyncTaskMethodBuilder<Sprite> <>t__builder; // 0x08
		public string inImageURL; // 0x20
		private TaskAwaiter<Sprite> <>u__1; // 0x28

		// Methods
		private void MoveNext(); // 0x00000001801F1110-0x00000001801F1120
		[DebuggerHidden] // 0x00000001800B36B0-0x00000001800B36C0
		private void SetStateMachine(IAsyncStateMachine stateMachine); // 0x00000001801F1120-0x00000001801F1170
	}

	// Constructors
	public UI_SplashLogo(); // 0x0000000180E095D0-0x0000000180E095E0

	// Methods
	private void Start(); // 0x0000000180EF6FD0-0x0000000180EF70E0
	public void Setup(string inLongDescription); // 0x0000000180EF6E50-0x0000000180EF6F00
	[AsyncStateMachine] // 0x0000000180150840-0x0000000180150890
	public UniTask Setup(string inImageURL, string inLongDescription); // 0x0000000180EF6F00-0x0000000180EF6FD0
	[AsyncStateMachine] // 0x0000000180150C90-0x0000000180150CE0
	public static Task<Sprite> FetchIconAndSponsorId(string inImageURL); // 0x0000000180EF6C90-0x0000000180EF6D70
	[AsyncStateMachine] // 0x0000000180150F40-0x0000000180150F90
	public static Task<Sprite> FetchSponsorImage(string inImageURL); // 0x0000000180EF6D70-0x0000000180EF6E50
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Start>b__4_1(); // 0x0000000180EF70E0-0x0000000180EF7200
}

