using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i = 3;
    int r = -1;
    // Start is called before the first frame update
    void Start()
    {
        this.r = Random.Range(150, 251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log($"{this.gameObject.name}:{i}");
        if (this.gameObject.tag == "Red" && i == 100)
        {
            this.gameObject.SetActive(false);
        }
        if (this.gameObject.tag == "Blue" && i == r)
        {
            this.gameObject.GetComponent<Renderer>().enabled = false;
        }
    }
}
