﻿using UnityEngine;

public class RandomRotator : MonoBehaviour {
    public float tumble;

    private void Start() {
        GetComponent<Rigidbody>().angularVelocity =
            Random.insideUnitSphere * tumble; // returns a random vector3 unitary
    }
}