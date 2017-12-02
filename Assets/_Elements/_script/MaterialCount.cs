using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[CreateAssetMenu]
public class MaterialCount : ScriptableObject
{
	public Dictionary<MaterialType, int> countDictionary = new Dictionary<MaterialType, int>();

	public void Reset() {
		countDictionary.Clear ();
	}

	public void AddMaterial(MaterialType type, int value) {
		if(countDictionary.ContainsKey (type)) {
			countDictionary [type] += value;
		} else {
			countDictionary.Add (type, value);
		}
	}

	public string Info {
		get {
			string info = "";

			foreach (MaterialType type in countDictionary.Keys) {
				info += type.materialName + ": " + countDictionary [type] + "\n";
			}

			return info;
		}
	}
}

