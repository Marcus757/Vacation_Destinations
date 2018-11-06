using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour {

	public Texture Loc_1;
	public Texture Loc_2;
	public List<Texture> texs = new List<Texture>();

	void OnGUI(){
		if(GUI.Button(new Rect(10,10, 100, 50), "Change")){
			Texture mat = this.GetComponent<Renderer> ().material.mainTexture;
			if(mat == Loc_1){
				this.GetComponent<Renderer>().material.mainTexture = Loc_2;
			}else{
				this.GetComponent<Renderer>().material.mainTexture = Loc_1;
			}
		}
	}



}
