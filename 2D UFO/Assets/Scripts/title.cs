using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(new Vector3(0, 3, 0));
        if(Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(1);
        }
        
    }
}
