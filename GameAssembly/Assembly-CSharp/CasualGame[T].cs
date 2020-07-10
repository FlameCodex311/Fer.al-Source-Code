/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class CasualGame<T> : MonoBehaviour // TypeDefIndex: 13178
	where T : CasualGame<T>
{
	// Fields
	protected static T _instance;
	private int _inputBlockers;
	private int _pausedCount;

	// Properties
	public static T instance { get; }
	public static bool InputBlocked { get; }
	public static bool Paused { get; }

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c // TypeDefIndex: 13179
	{
		// Fields
		public static readonly <>c<T> <>9;
		public static Func<bool> <>9__9_0;

		// Constructors
		static <>c();
		public <>c();

		// Methods
		internal bool <Awake>b__9_0();
	}

	// Constructors
	public CasualGame();
	static CasualGame();

	// Methods
	protected virtual void Awake();
	protected virtual void OnDestroy();
	protected virtual void OnWindowOpened(WindowOpenedMessage inMessage);
	protected virtual void OnWindowClosed(WindowClosedMessage inMessage);
	protected virtual void OnGamePaused(CasualGamePausedMessage inMessage);
	public static bool GetMouseButtonDown(int inMouseButton = 0 /* Metadata: 0x0078376B */);
	public static bool GetMouseButton(int inMouseButton = 0 /* Metadata: 0x0078376F */);
	public static bool GetMouseButtonUp(int inMouseButton = 0 /* Metadata: 0x00783773 */);
	public virtual void BtnClicked_Settings();
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Awake>b__9_1();
}

