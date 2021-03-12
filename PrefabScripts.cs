using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabScripts : MonoBehaviour
{

    public GameObject coin;
    public GameObject singleBrick;
    public GameObject legoBrick;

    void Start()
    {

        Instantiate(coin);
        coin.transform.position = new Vector3(1, 1, -10);
        Instantiate(coin);
        coin.transform.position = new Vector3(-2, 1, 8);
        Instantiate(coin);
        coin.transform.position = new Vector3(3, 1, 7);
        Instantiate(coin);
        coin.transform.position = new Vector3(4, 1, -6);
        Instantiate(coin);
        coin.transform.position = new Vector3(-6, 1, -5);
        Instantiate(coin);
        coin.transform.position = new Vector3(7, 1, 4);
        Instantiate(coin);
        coin.transform.position = new Vector3(-8, 1, 3);
        Instantiate(coin);
        coin.transform.position = new Vector3(9, 1, -8);


        Instantiate(singleBrick);
        singleBrick.transform.position = new Vector3(11, 1, 6);
        Instantiate(singleBrick);
        singleBrick.transform.position = new Vector3(-2, 1, -8);

        Instantiate(legoBrick);
        legoBrick.transform.position = new Vector3(-8, 1, -10);

    }
}