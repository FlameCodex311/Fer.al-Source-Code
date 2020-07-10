/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 81: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 9977-16354

public class UI_WorldMapStage : MonoBehaviour // TypeDefIndex: 12668
{
	// Fields
	public static UI_WorldMapStage instance; // 0x00
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Transform _cameraParent; // 0x20
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 _cameraRotationMin; // 0x28
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 _cameraRotationMax; // 0x30
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 _cameraPositionMin; // 0x38
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private Vector2 _cameraPositionMax; // 0x40
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private UI_WorldMapButton _rootButton; // 0x48
	private Vector2 _lastMousePos; // 0x50
	private Vector2 _mouseVelocity; // 0x58
	private Stack<UI_WorldMapButton> _levelButtonNavStack; // 0x60
	[SerializeField] // 0x00000001800B36B0-0x00000001800B36C0
	private GameObject _subLevelButton; // 0x68
	public Action<UI_WorldMapButton> OnLevelButtonSelected; // 0x70

	// Properties
	public UI_WorldMapButton RootButton { get; } // 0x0000000180369C40-0x0000000180369C50 
	public GameObject subLevelButton { get; } // 0x0000000180358970-0x0000000180358980 

	// Nested types
	[CompilerGenerated] // 0x00000001800B36B0-0x00000001800B36C0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 12669
	{
		// Fields
		public UI_WorldMapLevelButton[] worldMapLevelButtons; // 0x10

		// Constructors
		public <>c__DisplayClass16_0(); // 0x000000018036B6C0-0x000000018036B6D0

		// Methods
		internal bool <Start>b__0(); // 0x0000000180F7A870-0x0000000180F7A8E0
		internal void <Start>b__1(); // 0x0000000180F7A8E0-0x0000000180F7AA00
	}

	// Constructors
	public UI_WorldMapStage(); // 0x0000000180F88680-0x0000000180F887E0

	// Methods
	private void Start(); // 0x0000000180F88380-0x0000000180F88680
	private void OnDestroy(); // 0x0000000180F88170-0x0000000180F881E0
	private void Update(); // 0x00000001803581E0-0x00000001803581F0
	public void RemoveScene(); // 0x0000000180F881E0-0x0000000180F88270
	public void BtnClicked_Back(); // 0x0000000180F87EA0-0x0000000180F87F50
	public void BtnClicked_WorldMapLevelButton(UI_WorldMapButton inButton); // 0x0000000180F87F50-0x0000000180F88170
	private void SelectLevelButton(UI_WorldMapButton inButton); // 0x0000000180F88270-0x0000000180F88380
}

