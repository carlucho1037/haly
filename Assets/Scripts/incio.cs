using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class incio : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
       
    }



    public static void CargaNivel(string pNombreNivel){
    //    SceneManager.LoadScene ("play");
       SceneManager.LoadScene (pNombreNivel);
 
        }

}
