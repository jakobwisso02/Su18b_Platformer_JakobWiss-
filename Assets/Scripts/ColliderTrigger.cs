using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColliderTrigger : MonoBehaviour
{

    public int minimumScoreNeeded = 0;

    public string sceneToLoad = "Su18b_Platformer_JakobWisso";


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player" && PickUpCoin.score >= minimumScoreNeeded)
        {
            SceneManager.LoadScene(sceneToLoad);
            PickUpCoin.score = 0;
        }
    }

}
