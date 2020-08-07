/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_TarDownloader : MonoBehaviour // TypeDefIndex: 11307
{
	// Fields
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private static UI_TarDownloader <instance>k__BackingField; // 0x00
	private Canvas _canvas; // 0x20
	public GameObject groupOnOff; // 0x28
	[Header] // 0x000000018027DA50-0x000000018027DA80
	public GameObject groupProgressBar; // 0x30
	public Slider progressBar; // 0x38
	public UnityEngine.UI.Text labelPercentage; // 0x40
	public UnityEngine.UI.Text labelProgressText; // 0x48
	public UnityEngine.UI.Text labelEstimatedTime; // 0x50
	public UnityEngine.UI.Text labelCurrentTarName; // 0x58
	private float _progressTime; // 0x60
	private float _progressTimer; // 0x64

	// Properties
	public static UI_TarDownloader instance { [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ get; [CompilerGenerated] /* 0x00000001801CDAD0-0x00000001801CDAE0 */ private set; } // 0x00000001804D4400-0x00000001804D4440 0x00000001804D4440-0x00000001804D4480
	public Canvas canvas { get; } // 0x00000001804D4380-0x00000001804D4400 

	// Constructors
	public UI_TarDownloader(); // 0x00000001804D4360-0x00000001804D4380

	// Methods
	private void Start(); // 0x00000001804D4130-0x00000001804D4180
	public void Open(); // 0x00000001804D3FD0-0x00000001804D4070
	public void Close(); // 0x00000001804D3EE0-0x00000001804D3F90
	private void Update(); // 0x00000001804D41B0-0x00000001804D4360
	public void SetProgressLabel(string inString); // 0x00000001804D40D0-0x00000001804D4100
	public void SetProgressSlider(float inValue); // 0x00000001804D4100-0x00000001804D4130
	public void SetEstimatedTimeLabel(string inString); // 0x00000001804D40A0-0x00000001804D40D0
	public void SetCurrentTarNameLabel(string inString); // 0x00000001804D4070-0x00000001804D40A0
	private void OnDestroy(); // 0x00000001804D3F90-0x00000001804D3FD0
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private void <Close>b__18_0(); // 0x00000001804D4180-0x00000001804D41B0
}

