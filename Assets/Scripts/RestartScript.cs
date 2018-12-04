using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScript : MonoBehaviour
{
    public string sceneToLoad = "Su18b_Platformer_JakobWisso";

    void FixedUpdate()
    {
        // Om man trycker på R så händer det i måsvingarna
        if (Input.GetKeyDown(KeyCode.R))
        {
            // Laddar in scenen sceneToLoad vilket är Su18b_Platformer_JakobWisso i detta scriptet
            SceneManager.LoadScene(sceneToLoad);
        }
    }


}
