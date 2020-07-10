/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;

// Image 50: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 5712-6954

internal interface sNfUcPzqbmfpkWQZGXbzVNvzIYo // TypeDefIndex: 6526
{
	// Properties
	ControllerMap MWiOWGzUiqOkOMPKltvfuPDthis[int index] { get => default; }
	int SHujHYUxHggDGFiBfPBtOLtZhMW { get; }
	IList<ControllerMap> JCOaizEBVSmHYTLsOlmPEmHhbdXD { get; }

	// Methods
	IEnumerable<ControllerMap> IterateMapsInCategory_ControllerMap(int param_0000db1c);
	IList<T> GetMaps<T>()
		where T : ControllerMap;
	void Add(ControllerMap param_0000db1d, BoolOption param_0000db1e);
	void Remove(ControllerMap param_0000db1f);
	void Remove(int param_0000db20);
	void Remove(int param_0000db21, int param_0000db22);
	void RemoveById(int param_0000db23);
	int IndexOf(int param_0000db24);
	int IndexOf(int param_0000db25, int param_0000db26);
	bool Contains(int param_0000db27);
	bool Contains(int param_0000db28, int param_0000db29);
	void Clear(bool param_0000db2a);
	void Clear(int param_0000db2b, bool param_0000db2c);
	void ClearByLayout(int param_0000db2d, bool param_0000db2e);
	int SetEnabledAll(bool param_0000db2f);
	int SetEnabledByCategory(bool param_0000db30, int param_0000db31);
	int SetEnabledByCategory(bool param_0000db32, int param_0000db33, int param_0000db34);
	bool ContainsMapInCategory(int param_0000db35);
	ControllerMap GetMap(int param_0000db36);
	ControllerMap GetMap(int param_0000db37, int param_0000db38);
	ControllerMap[] GetMaps();
	ControllerMap GetMapByCategory(int param_0000db39);
	ControllerMap[] GetMapsByCategory(int param_0000db3a);
	int GetMapsByCategory(int param_0000db3b, List<ControllerMap> param_0000db3c, bool param_0000db3d);
	int GetMapsByCategory<T>(int param_0000db3e, List<T> param_0000db3f, bool param_0000db40)
		where T : ControllerMap;
	int GetMaps(List<ControllerMap> param_0000db41, bool param_0000db42);
	int GetMaps<T>(List<T> param_0000db43, bool param_0000db44)
		where T : ControllerMap;
}

