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

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Data
{
	[CustomClassObfuscation] // 0x00000001801DE050-0x00000001801DE0C0
	[RequireComponent] // 0x00000001801DE050-0x00000001801DE0C0
	public abstract class UserDataStore : UnityEngine.MonoBehaviour, IUserDataStore, IControllerMapStore // TypeDefIndex: 6482
	{
		// Constructors
		protected UserDataStore(); // 0x0000000180568C50-0x0000000180569020
	
		// Methods
		private void OnDestroy(); // 0x00000001807208D0-0x0000000180720A60
		internal void Initialize(); // 0x0000000180720750-0x00000001807208B0
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
		public virtual void SaveControllerMap(int playerId, ControllerMap controllerMap); // 0x00000001803774A0-0x00000001803774B0
		public virtual ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId); // 0x000000018037DDC0-0x000000018037DDD0
		protected abstract void OnInitialize();
		protected abstract void OnControllerConnected(ControllerStatusChangedEventArgs args);
		protected abstract void OnControllerDisconnected(ControllerStatusChangedEventArgs args);
		[Obsolete] // 0x00000001801DE420-0x00000001801DE450
		protected virtual void OnControllerPreDiscconnect(ControllerStatusChangedEventArgs args); // 0x00000001803774A0-0x00000001803774B0
		protected virtual void OnControllerPreDisconnect(ControllerStatusChangedEventArgs args); // 0x00000001807208B0-0x00000001807208D0
	}
}
