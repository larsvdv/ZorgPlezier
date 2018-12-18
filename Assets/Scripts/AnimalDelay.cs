using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalDelay : MonoBehaviour {

    private Animator anim;

	void Start () {
        anim = GetComponent<Animator>();
        anim.Play(0, -1, Random.value);


	}

}
