using TMPro;

using UnityEngine;

public class Percentage : MonoBehaviour {

    [SerializeField] private int percentage;

    [SerializeField] private float time;

    public TextMeshProUGUI YourText;

    private void Start() {

        percentage = 0;

        time = 5;

        YourText.text = string.Format("{0}% done", percentage);

    }

    private void Update() {

        if (time >= 0) {
            
            time -= Time.deltaTime;
        
        }

        if (time <= 0) {

            percentage += Random.Range(1, 7);

            Debug.Log("Percentage: " + percentage);

            time = Random.Range(1, 1500);

            YourText.text = string.Format("{0}% done", percentage);

        }

        if (percentage >= 100) {

            Application.Quit();

        }

    }

}