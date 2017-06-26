using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Nucleon : MonoBehaviour {

    public float attractionForce;

    private Rigidbody rb;

	void Awake () {
        rb = GetComponent<Rigidbody>();
	}
	
	void FixedUpdate () {
        rb.AddForce(transform.localPosition * -attractionForce);
	}
}
