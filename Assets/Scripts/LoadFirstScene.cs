using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LoadFirstScene : MonoBehaviour, IPointerEnterHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadSceneGerald()
    {
        SceneManager.LoadScene(1);
        Debug.Log("button cliqué");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }
}
