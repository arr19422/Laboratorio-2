using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{

    public GameObject spherePrefab;
    public GameObject newSphere;
    // Start is called before the first frame update
    void Start()
    {
        newSphere = Instantiate(spherePrefab, new Vector3(-7.5f, 2, -7), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            generateShepre();
        }
    }

    private void generateShepre()
    {
        if (!newSphere)
        {
            newSphere = Instantiate(spherePrefab, new Vector3(-7.5f, 2, -7), Quaternion.identity);
        }

    }
}
