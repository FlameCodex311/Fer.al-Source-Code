/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_TarDownloader : MonoBehaviour // TypeDefIndex: 13640
{
	// Fields
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private static UI_TarDownloader <instance>k__BackingField; // 0x00
	private Canvas _canvas; // 0x20
	public GameObject groupOnOff; // 0x28
	[Header] // 0x00000001800E0F40-0x00000001800E0F70
	public GameObject groupProgressBar; // 0x30
	public Slider progressBar; // 0x38
	public UnityEngine.UI.Text labelPercentage; // 0x40
	public UnityEngine.UI.Text labelProgressText; // 0x48
	public UnityEngine.UI.Text labelEstimatedTime; // 0x50
	public UnityEngine.UI.Text labelCurrentTarName; // 0x58
	private float _progressTime; // 0x60
	private float _progressTimer; // 0x64

	// Properties
	public static UI_TarDownloader instance { [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ get; [CompilerGenerated] /* 0x00000001800B36B0-0x00000001800B36C0 */ private set; } // 0x0000000180F937A0-0x0000000180F937E0 0x0000000180F937E0-0x0000000180F93820
	public Canvas canvas { get; } // 0x0000000180F93720-0x0000000180F937A0 

	// Constructors
	public UI_TarDownloader(); // 0x0000000180F93700-0x0000000180F93720

	// Methods
	private void Start(); // 0x0000000180F934D0-0x0000000180F93520
	public void Open(); // 0x0000000180F93370-0x0000000180F93410
	public void Close(); // 0x0000000180F93280-0x0000000180F93330
	private void Update(); // 0x0000000180F93550-0x0000000180F93700
	public void SetProgressLabel(string inString); // 0x0000000180F93470-0x0000000180F934A0
	public void SetProgressSlider(float inValue); // 0x0000000180F934A0-0x0000000180F934D0
	public void SetEstimatedTimeLabel(string inString); // 0x0000000180F93440-0x0000000180F93470
	public void SetCurrentTarNameLabel(string inString); // 0x0000000180F93410-0x0000000180F93440
	private void OnDestroy(); // 0x0000000180F93330-0x0000000180F93370
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private void <Close>b__18_0(); // 0x0000000180F93520-0x0000000180F93550
}

