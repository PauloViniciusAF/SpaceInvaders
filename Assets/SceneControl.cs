using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        GameObject[] gos = GameObject.FindGameObjectsWithTag("enemy");
        if(gos.Length == 0){
            if (scene.name == "Fase1"){
                SceneManager.LoadScene("Fase2");
            } else if(scene.name == "Fase2"){
                SceneManager.LoadScene("Fase3");
            }
        }
    }
}
