using TMPro;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public TextMeshProUGUI timeText;
    float timeLeft = 500;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (timeLeft > 0) {
            timeLeft -= Time.deltaTime;
            timeText.text = $"Time\n{((int)timeLeft).ToString()}";
        }
    }
}
