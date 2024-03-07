
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneScript : MonoBehaviour
{
   public void Start ()
   {

    //Para cagar la escena
    SceneManager.LoadScene ("Exterior");
    
   }

   public void Exit ()
   {
      //Para salir del juego
    
        Application.Quit();
    
   }
}
