using UnityEngine;
using System.Collections;

public class DrawWebcamTexture : MonoBehaviour {

	public void Start () {
		WebCamTexture webcam = new WebCamTexture();
		GameObject bgimg = GameObject.Find("BackgroundImage");
		bgimg.guiTexture.texture = webcam;
		webcam.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
