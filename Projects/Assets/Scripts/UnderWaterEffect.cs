using UnityEngine;
using System.Collections;

public class UnderWaterEffect : MonoBehaviour {
	private bool defaultFog = true;
	private Color defaultFogColor = new Color(0, 0.4f, 0.7f, 0.6f);
	private Color ExitFogColor = new Color(0, 0, 0, 0);
	private float defaultFogDensity;
	private bool defaultSkybox;
	public Material noSkybox ; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider hit)
	{
		if(hit.CompareTag("waterColler")){
			Debug.Log ("waterColler");
			RenderSettings.fog = true ;
			RenderSettings.fogColor = defaultFogColor;
			RenderSettings.fogDensity = 0.01f;
			RenderSettings.skybox = noSkybox;
		}
	}

	void OnTriggerExit(Collider hit)
	{
		if(hit.CompareTag("waterColler")){
			Debug.Log("exit");
			RenderSettings.fog = false ;
			RenderSettings.fogColor = ExitFogColor;
			RenderSettings.fogDensity = 0;
			RenderSettings.skybox = noSkybox;
		}

	}
}
