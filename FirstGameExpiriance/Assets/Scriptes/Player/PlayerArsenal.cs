using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerArsenal : MonoBehaviour
{
    [SerializeField] private GameObject bolt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("2"))
            {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Instantiate(bolt, mousePos, Quaternion.Euler(0, 0, 0));
            Debug.Log("Выстрел");
        }
    }
}
