﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class City_Duplicator : MonoBehaviour {
    public GameObject city;
    public static Vector3 cityStart;
    public static Vector3 cityEnd;

	// Use this for initialization
	void Start () {
        cityStart = city.transform.Find("SouthEnd").transform.position;
        Vector3 size = city.GetComponent<BoxCollider>().bounds.size;

        float z = size.z;
        for (int i = 0; i < 100; i++) {
            cityEnd = Object.Instantiate(city, new Vector3(city.transform.position.x, city.transform.position.y, z), city.transform.rotation).transform.position;
            z -= size.z;
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
