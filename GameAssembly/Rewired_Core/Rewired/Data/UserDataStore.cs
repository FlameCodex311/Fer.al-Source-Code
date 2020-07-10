/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Interfaces;
using UnityEngine;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

namespace Rewired.Data
{
	[CustomClassObfuscation] // 0x0000000180141110-0x0000000180141180
	[RequireComponent] // 0x0000000180141110-0x0000000180141180
	public abstract class UserDataStore : UnityEngine.MonoBehaviour, IUserDataStore, IControllerMapStore // TypeDefIndex: 6323
	{
		// Constructors
		protected UserDataStore(); // 0x0000000180407560-0x0000000180407570
	
		// Methods
		private void OnDestroy(); // 0x00000001804073D0-0x0000000180407560
		internal void Initialize(); // 0x0000000180407240-0x00000001804073B0
		public abstract void Load();
		public abstract void LoadControllerData(int playerId, ControllerType controllerType, int controllerId);
		public abstract void LoadControllerData(ControllerType controllerType, int controllerId);
		public abstract void LoadPlayerData(int playerId);
		public abstract void LoadInputBehavior(int playerId, int behaviorId);
		public abstract void Save();
		public abstract void SaveControllerData(int playerId, ControllerType controllerType, int controllerId);
		public abstract void SaveControllerData(ControllerType controllerType, int controllerId);
		public abstract void SavePlayerData(int playerId);
		public abstract void SaveInputBehavior(int playerId, int behaviorId);
		public virtual void SaveControllerMap(int playerId, ControllerMap controllerMap); // 0x00000001803581E0-0x00000001803581F0
		public virtual ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018035FCC0-0x000000018035FCD0
		protected abstract void OnInitialize();
		protected abstract void OnControllerConnected(ControllerStatusChangedEventArgs args);
		protected abstract void OnControllerDisconnected(ControllerStatusChangedEventArgs args);
		[Obsolete] // 0x0000000180142640-0x0000000180142670
		protected virtual void OnControllerPreDiscconnect(ControllerStatusChangedEventArgs args); // 0x00000001803581E0-0x00000001803581F0
		protected virtual void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args); // 0x00000001804073B0-0x00000001804073D0
	}
}
