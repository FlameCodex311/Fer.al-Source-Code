/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 83: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10381-16398

public interface IInteractable // TypeDefIndex: 11958
{
	// Methods
	int Interactions();
	float Timer();
	Transform Transform();
	Vector3 Offset();
	List<string> ActionIconDefIds();
	List<Action> InteractActions();
	void OnInteractionStart();
	void OnInteractionCancel();
	void RequestInteraction(Interactable.EInteractableMessage inInteractionType);
}

