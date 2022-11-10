using UnityEngine;

public class Quit : MonoBehaviour {
    
    void Update() {

        if (Input.GetKey(KeyCode.LeftAlt)) {

            if (Input.GetKey(KeyCode.W)) {

                if (Input.GetKeyDown(KeyCode.K)) {

                    Application.Quit();

                    Debug.Log("Quit!");

                }

            }

        }

        if (Input.GetKey(KeyCode.LeftAlt)) {

            if (Input.GetKeyDown(KeyCode.F4)) {

                

            }

        }

    }

}
