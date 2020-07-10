/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class EmoteTemp : MonoBehaviour // TypeDefIndex: 10082
{
	// Fields
	public WWImage emoteIcon; // 0x20
	public Transform tween; // 0x28
	public GameObject groupTempThinking; // 0x30
	private float _tweenTime; // 0x38
	private float _cachedTweenDefaultScale; // 0x3C

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass5_0 // TypeDefIndex: 10083
	{
		// Fields
		public ActorBase inActorBase; // 0x10
		public EmoteTemp <>4__this; // 0x18

		// Constructors
		public <>c__DisplayClass5_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal void <Setup>b__0(); // 0x000000018119D650-0x000000018119D8A0
	}

	// Constructors
	public EmoteTemp(); // 0x0000000181190FF0-0x0000000181191000

	// Methods
	public void Setup(ActorBase inActorBase); // 0x0000000181190DB0-0x0000000181190EE0
	public void SetEmote(string inImageDefID, float inTime = -1f /* Metadata: 0x007469C3 */); // 0x0000000181190CE0-0x0000000181190DB0
	public void UnEmote(); // 0x0000000181190F50-0x0000000181190FF0
	private void ScaleUp(bool inValue); // 0x0000000181190BC0-0x0000000181190CE0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <SetEmote>b__6_0(); // 0x0000000181190F50-0x0000000181190FF0
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <ScaleUp>b__8_0(); // 0x0000000181190EE0-0x0000000181190F50
}

