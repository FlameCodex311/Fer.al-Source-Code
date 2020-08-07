/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 51: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5871-7113

namespace Rewired.Interfaces
{
	public interface IUserDataStore // TypeDefIndex: 6480
	{
		// Methods
		void Save();
		void SaveControllerData(int playerId, ControllerType controllerType, int controllerId);
		void SaveControllerData(ControllerType controllerType, int controllerId);
		void SavePlayerData(int playerId);
		void SaveInputBehavior(int playerId, int behaviorId);
		void Load();
		void LoadControllerData(int playerId, ControllerType controllerType, int controllerId);
		void LoadControllerData(ControllerType controllerType, int controllerId);
		void LoadPlayerData(int playerId);
		void LoadInputBehavior(int playerId, int behaviorId);
	}
}
