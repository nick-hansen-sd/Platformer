using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public TextMeshProUGUI timeText;
    float timeLeft = 500;
    bool levelFailed = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timeText.text = $"Time\n{((int)timeLeft).ToString()}";
        if (timeLeft <= 0)
        {
            timeLeft = 0;
            if (!levelFailed)
            {
                Debug.Log("Player failed");
                levelFailed = true;
            }
        }
    }
}