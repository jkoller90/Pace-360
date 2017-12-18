using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PBack : MonoBehaviour
{

    private bool gazedAt = false;
    private float gazedTime = 2.0f;
    private float timer = 0.0f;
    private Slider slider = null;

    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gazedAt)
        {
            timer += Time.deltaTime;

            if (slider.value >= 1.0f)
            {
                SceneManager.LoadScene("Home2");
                timer = 0.0f;
            }
        }
        else
        {
            timer = 0.0f;
        }
        slider.value = timer / gazedTime;
    }

    public void PointerEnter()
    {
        gazedAt = true;

    }

    public void PointerExit()
    {
        gazedAt = false;

    }
}
