/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ThisOtherThing.UI.Shapes;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_FieldStatusIndicator : MonoBehaviour // TypeDefIndex: 13891
{
	// Fields
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private WWImage _statusImage; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Rectangle _backgroundRectangle; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Rectangle _statusBorderRectangle; // 0x30
	[Header] // 0x000000018022C7D0-0x000000018022C820
	[SerializeField] // 0x000000018022C7D0-0x000000018022C820
	private Sprite _emptySprite; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite _verifyingSprite; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite _invalidSprite; // 0x48
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Sprite _validSprite; // 0x50
	[Header] // 0x000000018022D080-0x000000018022D0D0
	[SerializeField] // 0x000000018022D080-0x000000018022D0D0
	private Color _offColor; // 0x58
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _onColor; // 0x68
	[Header] // 0x000000018022D490-0x000000018022D4E0
	[SerializeField] // 0x000000018022D490-0x000000018022D4E0
	private Color _emptyColor; // 0x78
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _verifyingColor; // 0x88
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _invalidColor; // 0x98
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Color _validColor; // 0xA8
	[Header] // 0x00000001801D2A20-0x00000001801D2A70
	[SerializeField] // 0x00000001801D2A20-0x00000001801D2A70
	private FeralAudioEmitter _validSoundFX; // 0xB8
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioEmitter _invalidSoundFX; // 0xC0
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private FeralAudioEmitter _emptySoundFX; // 0xC8
	private FieldStatus? _currentStatus; // 0xD0

	// Nested types
	public enum FieldStatus // TypeDefIndex: 13892
	{
		Empty = 0,
		Verifying = 1,
		Invalid = 2,
		Valid = 3
	}

	// Constructors
	public UI_FieldStatusIndicator(); // 0x00000001803771D0-0x0000000180377270

	// Methods
	private void OnEnable(); // 0x00000001803768B0-0x0000000180376900
	private void Reset(); // 0x0000000180376900-0x0000000180376940
	public void SetStatus(FieldStatus inStatus, bool inPlayAudio = true /* Metadata: 0x007BA53B */); // 0x0000000180376940-0x00000001803771D0
}

