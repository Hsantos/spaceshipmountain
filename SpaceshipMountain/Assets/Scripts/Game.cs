using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    private Spaceship spaceShip;
    private MoonGenerator moon;

    void Awake()
    {
        spaceShip = ((GameObject) Instantiate(Resources.Load("Prefab/Spaceship"))).AddComponent<Spaceship>();
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
