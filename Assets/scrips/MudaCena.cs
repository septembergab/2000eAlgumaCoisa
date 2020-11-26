using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MudaCena : MonoBehaviour
{
    public int Cena;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Mudar()
    {
        //metodo pra mudar a cena
        SceneManager.LoadScene(Cena);
    }

    
}
