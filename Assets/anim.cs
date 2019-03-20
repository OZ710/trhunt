using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour {
     public Animator anime;
	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("l") && anime.GetCurrentAnimatorStateInfo(0).IsName("none"))
		{
			anime.Play("open");
		
		}
		else if(Input.GetKeyDown("l") && anime.GetCurrentAnimatorStateInfo(0).IsName("close"))
		{
			anime.Play("open");
		}
		else if(Input.GetKeyDown("l") && anime.GetCurrentAnimatorStateInfo(0).IsName("open"))
		{
			anime.Play("close");
		}

	}
}
