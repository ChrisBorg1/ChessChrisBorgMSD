using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{

    public GameObject progressBar;
    private Slider slider;
    public float MaxTime = 6.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }



    // Update is called once per frame
    void Update()
    {
          MaxTime -= Time.deltaTime;
        if (MaxTime < 5f)
        {
            if (slider.value < 1)
            {
                slider.value += 0.25f * Time.deltaTime;
            }
            if (slider.value == slider.maxValue)
            {
               this.gameObject.SetActive(false);
            }
        }
    }
}
