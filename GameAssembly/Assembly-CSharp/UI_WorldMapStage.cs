/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public class UI_WorldMapStage : MonoBehaviour // TypeDefIndex: 13857
{
	// Fields
	public static UI_WorldMapStage instance; // 0x00
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Transform _cameraParent; // 0x20
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 _cameraRotationMin; // 0x28
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 _cameraRotationMax; // 0x30
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 _cameraPositionMin; // 0x38
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private Vector2 _cameraPositionMax; // 0x40
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private UI_WorldMapButton _rootButton; // 0x48
	private Vector2 _lastMousePos; // 0x50
	private Vector2 _mouseVelocity; // 0x58
	private Stack<UI_WorldMapButton> _levelButtonNavStack; // 0x60
	[SerializeField] // 0x00000001801CDAD0-0x00000001801CDAE0
	private GameObject _subLevelButton; // 0x68
	public Action<UI_WorldMapButton> OnLevelButtonSelected; // 0x70

	// Properties
	public UI_WorldMapButton RootButton { get; } // 0x00000001803743E0-0x00000001803743F0 
	public GameObject subLevelButton { get; } // 0x00000001803765E0-0x00000001803765F0 

	// Nested types
	[CompilerGenerated] // 0x00000001801CDAD0-0x00000001801CDAE0
	private sealed class <>c__DisplayClass16_0 // TypeDefIndex: 13858
	{
		// Fields
		public UI_WorldMapLevelButton[] worldMapLevelButtons; // 0x10

		// Constructors
		public <>c__DisplayClass16_0(); // 0x0000000180373240-0x0000000180373250

		// Methods
		internal bool <Start>b__0(); // 0x00000001804472F0-0x0000000180447360
		internal void <Start>b__1(); // 0x0000000180447360-0x0000000180447470
	}

	// Constructors
	public UI_WorldMapStage(); // 0x0000000180454500-0x0000000180454660

	// Methods
	private void Start(); // 0x0000000180454200-0x0000000180454500
	private void OnDestroy(); // 0x0000000180453FF0-0x0000000180454060
	private void Update(); // 0x00000001803774A0-0x00000001803774B0
	public void RemoveScene(); // 0x0000000180454060-0x00000001804540F0
	public void BtnClicked_Back(); // 0x0000000180453D20-0x0000000180453DD0
	public void BtnClicked_WorldMapLevelButton(UI_WorldMapButton inButton); // 0x0000000180453DD0-0x0000000180453FF0
	private void SelectLevelButton(UI_WorldMapButton inButton); // 0x00000001804540F0-0x0000000180454200
}

