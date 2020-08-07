/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class EmoteTemp : MonoBehaviour // TypeDefIndex: 11572
{
	// Fields
	public WWImage emoteIcon; // 0x20
	public Transform tween; // 0x28
	public GameObject groupTempThinking; // 0x30
	private float _tweenTime; // 0x38
	private float _cachedTweenDefaultScale; // 0x3C

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 11573
	{
		// Fields
		public ActorBase inActorBase; // 0x10
		public EmoteTemp <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass5_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal void <Setup>b__0(); // 0x000000018086BEF0-0x000000018086C130
	}

	// Constructors
	public EmoteTemp(); // 0x000000018085DBF0-0x000000018085DC00

	// Methods
	public void Setup(ActorBase inActorBase); // 0x000000018085D9B0-0x000000018085DAE0
	public void SetEmote(string inImageDefID, float inTime = -1f /* Metadata: 0x0077CDE9 */); // 0x000000018085D8E0-0x000000018085D9B0
	public void UnEmote(); // 0x000000018085DB50-0x000000018085DBF0
	private void ScaleUp(bool inValue); // 0x000000018085D7C0-0x000000018085D8E0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <SetEmote>b__6_0(); // 0x000000018085DB50-0x000000018085DBF0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <ScaleUp>b__8_0(); // 0x000000018085DAE0-0x000000018085DB50
}

