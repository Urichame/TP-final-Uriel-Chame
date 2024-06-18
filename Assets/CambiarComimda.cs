using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarComimda : MonoBehaviour
{
    public GameObject[] comida;
    public int currentIndex = -1;


    void Start()
    {
        DesactivateAll();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            currentIndex++;
            if(currentIndex < comida.Length)
            {
                activeByIndex(currentIndex);
                desactivateByIndex(currentIndex);
            }
        }
        else if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            currentIndex--;
            if(currentIndex <  comida.Length)
            {
                activeByIndex(currentIndex);
                desactivateByIndex(currentIndex);
            }
        }
    }

    void DesactivateAll()
    {
        for(int i = 0; i < comida.Length; i++)
        {
            comida[i].SetActive(false);
        }
    }

    void activeByIndex( int index)
    {
        comida[index].SetActive(true);
    }
    void desactivateByIndex( int index)
    {
        comida[index - 1].SetActive(false);
    }
}
