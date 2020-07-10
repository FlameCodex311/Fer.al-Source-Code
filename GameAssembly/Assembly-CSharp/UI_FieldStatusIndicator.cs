/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI.Shapes;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_FieldStatusIndicator : MonoBehaviour // TypeDefIndex: 12307
{
	// Fields
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private WWImage _statusImage; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Rectangle _backgroundRectangle; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Rectangle _statusBorderRectangle; // 0x30
	[Header] // 0x00000001801325F0-0x0000000180132640
	[SerializeField] // 0x00000001801325F0-0x0000000180132640
	private Sprite _emptySprite; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite _verifyingSprite; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite _invalidSprite; // 0x48
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Sprite _validSprite; // 0x50
	[Header] // 0x0000000180132ED0-0x0000000180132F20
	[SerializeField] // 0x0000000180132ED0-0x0000000180132F20
	private Color _offColor; // 0x58
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _onColor; // 0x68
	[Header] // 0x00000001801332E0-0x0000000180133330
	[SerializeField] // 0x00000001801332E0-0x0000000180133330
	private Color _emptyColor; // 0x78
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _verifyingColor; // 0x88
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _invalidColor; // 0x98
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Color _validColor; // 0xA8
	[Header] // 0x00000001800DA180-0x00000001800DA1D0
	[SerializeField] // 0x00000001800DA180-0x00000001800DA1D0
	private FeralAudioEmitter _validSoundFX; // 0xB8
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioEmitter _invalidSoundFX; // 0xC0
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private FeralAudioEmitter _emptySoundFX; // 0xC8
	private FieldStatus? _currentStatus; // 0xD0

	// Nested types
	public enum FieldStatus // TypeDefIndex: 12308
	{
		Empty = 0,
		Verifying = 1,
		Invalid = 2,
		Valid = 3
	}

	// Constructors
	public UI_FieldStatusIndicator(); // 0x0000000180E3F9A0-0x0000000180E3FA40

	// Methods
	private void OnEnable(); // 0x0000000180E3F070-0x0000000180E3F0C0
	private void Reset(); // 0x0000000180E3F0C0-0x0000000180E3F100
	public void SetStatus(FieldStatus inStatus, bool inPlayAudio = true /* Metadata: 0x00782E2C */); // 0x0000000180E3F100-0x0000000180E3F9A0
}

