using UnityEngine;
using UnityEditor;
using Models;
using Proyecto26;
using System.Collections.Generic;
using UnityEngine.Networking;
using System;

[Serializable]
public class Obj
{
	public override string ToString(){
		return "";
	}
}
public class MainScript : MonoBehaviour {

	private readonly string basePath = "https://jsonplaceholder.typicode.com";
	private RequestHelper currentRequest;

	private void LogMessage(string title, string message) {
#if UNITY_EDITOR
		EditorUtility.DisplayDialog (title, message, "Ok");
#else
		Debug.Log(message);
#endif
	}

	public void GetPrimitive(){
		RestClient.Get<int>(basePath + "/get-p").Then(res => {
			this.LogMessage("get-primitive", res.ToString());
		});
	}

	
	public void Get(){
		RestClient.Get<Obj>(basePath + "/get-o").Then(res => {
			this.LogMessage("get-obj", res.ToString());
		});
	}

	
	
	public void GetArray(){
		RestClient.GetArray<Obj>(basePath + "/get-a").Then(res => {
			this.LogMessage("get-array", "hmmm---");
			foreach(Obj t in res){
				this.LogMessage("get-array----t", t.ToString());
			}
			this.LogMessage("get-array", "---hmmm");
		});
	}

}