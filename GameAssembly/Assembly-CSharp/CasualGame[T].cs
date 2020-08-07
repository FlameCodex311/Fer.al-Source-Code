/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class CasualGame<T> : MonoBehaviour // TypeDefIndex: 10843
	where T : CasualGame<T>
{
	// Fields
	protected static T _instance;
	private int _inputBlockers;
	private int _pausedCount;
	private Dictionary<string, MethodInfo> _casualGameCommandRouteTable;

	// Properties
	public static T instance { get; }
	public static bool InputBlocked { get; }
	public static bool Paused { get; }

	// Nested types
	[Serializable]
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c // TypeDefIndex: 10844
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
	public static bool GetMouseButtonDown(int inMouseButton = 0 /* Metadata: 0x0077C226 */);
	public static bool GetMouseButton(int inMouseButton = 0 /* Metadata: 0x0077C22A */);
	public static bool GetMouseButtonUp(int inMouseButton = 0 /* Metadata: 0x0077C22E */);
	public virtual void BtnClicked_Settings();
	private void SetupCasualGameCommandAttributes();
	protected void OnCasualGameCommand(CasualGameCommand inMessage);
	protected virtual void HandleGameCommand(CasualGameCommand inMessage);
	protected virtual void SendGameCommand(params /* 0x00000001801CDAD0-0x00000001801CDAE0 */ string[] inArgs);
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Awake>b__9_1();
}

